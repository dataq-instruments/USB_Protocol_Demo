# USB_Protocol_demo

 It demonstrate how to use protocol (**without .NET class**) to set up and acquire data then display in a chart. It applies to DI-1100, DI-1110, DI-1120, DI-2108, DI-2008, DI-4108, DI-4208, DI-4718B, and DI-4730 USB

**Prerequisites**:

1) Firmware 1.35 is recommended https://github.com/dataq-instruments/Firmware_Upgrade. Earlier version of firmware may not work properly at higher sample rate

2) Understand the protocol, please refer to  https://www.dataq.com/resources/pdfs/misc/Dataq-Instruments-Protocol.pdf
 
3) Turn 21xx/11xx/41xx/47xx into CDC mode: plug the device to USB port, if the LED already blinks Yellow, stop, you are already in CDC mode. If not, once the LED turns blinking Green, push and hold the button immediately (within 5 second time frame), the LED should turn white, hold until LED turns Red, then release the button, now the LED will blink yellow to indicate CDC mode. If you need to exit CDC mode, repeate the same action and a green blinking LED will indicate LibUSB mode.

4) This example uses Xchart to plot the waveform, which is installed when you install WinDaq addons (https://www.dataq.com/products/windaq/add_ons/index.htm) to your PC. 

   
**Run it**:

 1)Use Windows Device Manager to find out the COM port for your device and enter it to COM Port text box <br/>
![alt text](https://www.dataq.com/resources/repository/matlab_devicemanager.png)
 2)Select the appropriate srate and matching ps values <br/>
 3)Click Run to start it<br/>
 4)You can drag the waveform up and down, and use the mouse wheel to zoom in and out <br/>
 5)To debug, please read the protocol to find out more, and exam the error codes<br/>
  
 
![alt text](https://www.dataq.com/resources/repository/rawcdc.gif "ScreenCapture by LICECap")

When you download and build this project for the first time, good chance you will run in an error like "Couldn't process file form1.resx due to its being in the internet or Restricted zone or having the mark of the web on the file. Remove the mark of the web if you want to process these files."

To deal with it, you will need to locate the offending .resx files in solution directory, right click on it, open the properties and check the option "unblock". Repeat this for all offending .resx files before reloading the project

![alt text](https://www.dataq.com/resources/repository/resxunblock.png "how to unblock resx files")

 
**Extra**:

 For more info regarding the features of XChart, please refer to http://ultimaserial.com/XChart.html

