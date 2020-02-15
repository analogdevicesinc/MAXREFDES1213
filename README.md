# MAXREFDES1213 -- Smart Electronic Load
Maxim is an Analog mixed signal semiconductor company focused on developing power management products that include power converters (works with both high and low current) and PMIC’s (Mostly focused on low currents). A traditional tool to test these components would cost around $1000 for each unit and these units are heavy and usually powered by 110 Volts AC. The focus of this project is to develop a smart portable electronic load for testing these power management chips. The main features of this design are:
<ul>
<li>This design is USB powered.</li>
<li>This design showcases the capability of PIXI (MAX11311) and the MAX32630FTHR board (microcontroller kit).</li>
<li>This design is portable and can be easily carried from computer to computer.</li>
<li>This design has a GUI (developed in Visual Studio for Microsoft Windows) and firmware (developed in MBED using MAX32630FTHR) that controls the load currents.</li>
<li>Most of the hardware components in this design are Maxim-made.</li>
<li>This design has two modes (most common modes used in testing power management components).</li>
<ul><li>Constant current mode, which has two current ranges 0 to 100mA and 0 to 10A.</li>
<li>Load transient mode where the load current switches between two current ranges 0to 100mA and 0 to 10A.</li></ul>
<li>This load transient mode is also available in EE-SIM so now the user can compare simulation with the real time results.</li>
<li>Design functionality: Using the GUI and FTHR board to create and control the constant and transient load currents through PIXI. ON and OFF times and slew rates of the transient mode currents are also controlled by the GUI and FTHR to test power converters and PMICs.</li>
</ul>
<p>
<b>Contents:</b>
<ul>
<li>MAXREFDES1213 board</li>
<li>MAX3263FTHR, and MAX32625PICO (Dapllink programmer)</li>
<li>Fan</li>
<li>12V adapter</li>
<li>USB cables</li>
</ul>

<b>Requirements:</b>
<ol>
<li>MAXREFDES1213 board (order form above) with firmware loaded.</li>
<li>A PC to install the GUI.</li>
<li>Power supply 0 to 40V current 0 to 10A (12V power supply comes with the order).</li>
</ol>
<p>
<b>Getting Started</b>
<ol>
<li>Click the "Clone or Download" button and click "Download ZIP" above (from the main GITHUB repo page). After the download finishes, unzip the file to a directory of your choosing. All the files needed to run the board can be found in the Firmware and Software directories.</li>
<li>You need to program the FTHR board with the Smart_E_Load_FM_rev2.MAX32630FTHR.bin file found in the Firmware directory.</li>
<li>Please install by double-clicking the GUI using setup.exe located in the .\Software\Publish directory.</li>
<li>For hardware setup, install the fan and 12 V adapter if you are working with high currents. If you are planning to work on low current applications, there is no need to install the fan.</li>
<li>The complete procedure is mentioned in the design documents found on the MAXREFDES1213's page on Maxim's website.</li>
<li>Fan connection: The J7 has three pins and the "Thermal Take" has four pins. When you connect the Fan make sure you connect the bottom three pins of the fan and leave the top one.</li>
</ol>
