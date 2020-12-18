namespace CDCRawSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comport = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.srate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ps = new System.Windows.Forms.TextBox();
            this.axXChart1 = new AxXCHARTLib.AxXChart();
            this.stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axXChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device COM port: ";
            // 
            // comport
            // 
            this.comport.Location = new System.Drawing.Point(111, 8);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(28, 20);
            this.comport.TabIndex = 1;
            this.comport.Text = "4";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(602, 9);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(58, 29);
            this.run.TabIndex = 2;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(10, 428);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(39, 13);
            this.Status.TabIndex = 3;
            this.Status.Text = "Output";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "srate:";
            // 
            // srate
            // 
            this.srate.Location = new System.Drawing.Point(233, 8);
            this.srate.Name = "srate";
            this.srate.Size = new System.Drawing.Size(36, 20);
            this.srate.TabIndex = 6;
            this.srate.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ps";
            // 
            // ps
            // 
            this.ps.Location = new System.Drawing.Point(319, 8);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(32, 20);
            this.ps.TabIndex = 8;
            this.ps.Text = "7";
            // 
            // axXChart1
            // 
            this.axXChart1.Enabled = true;
            this.axXChart1.Location = new System.Drawing.Point(17, 44);
            this.axXChart1.Name = "axXChart1";
            this.axXChart1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axXChart1.OcxState")));
            this.axXChart1.Size = new System.Drawing.Size(723, 371);
            this.axXChart1.TabIndex = 9;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(679, 8);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(60, 30);
            this.stop.TabIndex = 10;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.axXChart1);
            this.Controls.Add(this.ps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.srate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.run);
            this.Controls.Add(this.comport);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Protocol Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axXChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox comport;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ps;
        private AxXCHARTLib.AxXChart axXChart1;
        private System.Windows.Forms.Button stop;
    }
}

