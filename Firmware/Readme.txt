1)Complete MBED link
https://os.mbed.com/teams/MaximIntegrated/code/Smart_E_Load_MAXREFDES1213/



2)Just in case, make sure to install the following driver

https://os.mbed.com/handbook/Windows-serial-configuration


3)The following packet structure is used for constant and dynamic modes


•	Packet structure  CONSTANT CURRENT MODE
+---+--------+-----+
|CM |LR/HR/SV|Value|
+---+--------+-----+
CM:  Indicates constant mode is triggered
LR/HR:  Selects between low and high range in constant mode
SV:  Stop pulling current


•	Packet structure  TRANSIENT MODE
+--+-----+--+--+--+--+---+--+--+-+-----+------------+-------+--------------+--+
|TM|LR/HR|SV|VC|SP|PC|SDC|DC|SF|F|SR_UP|R_up current|SR_DOWN|R_down current|FR|
+--+-----+--+--+--+--+---+--+--+-+-----+------------+-------+--------------+--+

TM:  Indicates transient mode is triggered
LR/HR:  Selects between low and high range in Transient mode
Sv:  Size of number of characters of valley current
VC: value of valley current
Sp:  Size of number of characters of peak current
PC: Peak current
Sd:  Size of duty cycle characters
DC: Duty cycle value
Sf:  Size of frequency characters
F:  Frequency of the signal
SR_UP:  Size of ramp up current
SR_Down: Size of ramp down current
R_up: Ramp up current
R_down: Ramp down current
FR: Loop starts here

