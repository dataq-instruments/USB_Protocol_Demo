﻿using System;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace CDCRawSample
{
    public partial class Form1 : Form
    {
        int portname = 10;
        static SerialPort serialPort;
        static byte [] ADCBuffer;
        static int headADCBuffer=0;
        static int tailADCBuffer=0;
        Thread readThread;
        static int AvailableBytes=0;
        static string mysrate;
        static string myps;
        static bool acq = false;

        public Form1()
        {
            int i = 0;
            InitializeComponent();

            ADCBuffer = new byte [200000];
            for (i = 0; i < ADCBuffer.Length; i++) ADCBuffer[i] = 0;
            comport.Text = portname.ToString();

            readThread = new Thread(Read);
            readThread.Priority = ThreadPriority.Highest;
        }

        private void run_Click(object sender, EventArgs e)
        {
            mysrate = srate.Text;
            myps = ps.Text;

            serialPort = new SerialPort();
            serialPort.PortName = "COM"+comport.Text;
            serialPort.ReadTimeout = 10;
            serialPort.WriteTimeout = 50;
            serialPort.ReadBufferSize = 4096 * 1024;  //big buffer

            try
            {
                serialPort.Open();
                serialPort.DiscardInBuffer();
            }
            catch
            {
                Status.Text = "Failed to open the port";
                return;
            }
            if (readThread.IsAlive == false)
                readThread.Start();

            timer1.Enabled = true;

            Setup();

            acq = true;
        }

        private static void Read()
        {
            int i;
            while (true)
            {
                if (acq)
                {
                    try
                    {
                        AvailableBytes = serialPort.BytesToRead;
                        AvailableBytes = AvailableBytes - (AvailableBytes % 2);
                    }
                    catch
                    {
                        AvailableBytes = 0;
                    }

                    if (AvailableBytes > 0)
                    {
                        if (AvailableBytes > (ADCBuffer.Length - headADCBuffer)) AvailableBytes = ADCBuffer.Length - headADCBuffer;
                        i = serialPort.Read(ADCBuffer, headADCBuffer, AvailableBytes);
                        headADCBuffer = headADCBuffer + i;
                        if (headADCBuffer >= ADCBuffer.Length) headADCBuffer = 0;
                    }
                }
                else
                {
                    /*We just dump ALL command echo in this demo*/
                    try
                    {
                        serialPort.Read(ADCBuffer, 0, serialPort.BytesToRead);
                    }
                    catch
                    {
                    }
                }
                Thread.Sleep(1);
            }
        }

        static void WriteRes(string s)
        {
            try
            {
                serialPort.WriteLine(s);
            }
            catch (TimeoutException) { }
            Thread.Sleep(50);
        }

        public static void Setup()
        {
            int i;
            WriteRes("stop\r");
            Thread.Sleep(100);
            serialPort.DiscardInBuffer();

            WriteRes("encode 0\r");
            
            WriteRes("slist 0 0\r");
            WriteRes("srate "+mysrate+ "\r");
            WriteRes("ps "+ myps+"\r");

            WriteRes("dec 5\r");
            WriteRes("deca 1\r");

            Thread.Sleep(100);
            serialPort.DiscardInBuffer();
            WriteRes("start\r");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int availablebyte = headADCBuffer-tailADCBuffer;

            if (availablebyte < 0) availablebyte = availablebyte + ADCBuffer.Length;

            int availablescan= availablebyte / 2; //two channels = 4 bytes per scan

            if (availablescan>0)
            {
                int j;

                Int16[,] PlotData = new Int16[1, availablescan];

                Int16 n;

                for (j = 0; j < availablescan; j++)
                {
                    n = BitConverter.ToInt16(ADCBuffer, tailADCBuffer);
                    tailADCBuffer = tailADCBuffer + 2;
                    PlotData[0, j] = n;

                    if (tailADCBuffer >= ADCBuffer.Length) tailADCBuffer = 0;
                }

                axXChart1
                    .Chart(PlotData);

                Status.Text = PlotData[0,availablescan-1].ToString();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                acq = false;
                WriteRes("stop\r");
                Thread.Sleep(200);
                serialPort.Close();
            }
            catch { };
            readThread.Abort();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            try
            {
                acq = false;
                WriteRes("stop\r");
                Thread.Sleep(200);
                serialPort.Close();
            }
            catch { };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
