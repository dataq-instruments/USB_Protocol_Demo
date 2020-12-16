# USB_Protocol_demo

 It demonstrate how to use protocol to set up and acquire data then display in a chart. It applies to DI-1100, DI-1110, DI-1120, DI-2108, DI-2008, DI-4108, DI-4208, DI-4718B, and DI-4730 USB

**Prerequisites**:

Understand the protocol, please refer to  https://www.dataq.com/resources/pdfs/misc/Dataq-Instruments-Protocol.pdf
 
This example uses Xchart to plot the waveform, which is installed when you install WinDaq addons (https://www.dataq.com/products/windaq/add_ons/index.htm) to your PC. 
  
Turn 21xx/11xx/41xx/47xx into CDC mode: plug the device to USB port, if the LED already blinks Yellow, stop, you are already in CDC mode. If not, once the LED turns blinking Green, push and hold the button immediately (within 5 second time frame), the LED should turn white, hold until LED turns Red, then release the button, now the LED will blink yellow to indicate CDC mode. If you need to exit CDC mode, repeate the same action and a green blinking LED will indicate LibUSB mode.

From Device Manager, find out the COM port of the device connected to

![alt text](https://www.dataq.com/resources/repository/matlab_devicemanager.png)


   
**Run it**:

 1)Use Windows Device Manager to find out the COM port for your device and enter it to COM Port text box <br/>
 2)Select the appropriate srate and matching ps values <br/>
 3)Click Run to start it<br/>
 4)You can drag the waveform up and down, and use the mouse wheel to zoom in and out <br/>
 5)To debug, please read the protocol to find out more, and exam the error codes<br/>
 6)Due to USB COM port's bandwidth, one should limit the throughput rate to 30K samples per seconds
 
 
![alt text](https://www.dataq.com/resources/repository/rawcdc.gif "ScreenCapture by LICECap")
 
**Extra**:

 For more info regarding the features of XChart, please refer to http://ultimaserial.com/XChart.html

