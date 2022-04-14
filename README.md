# ByteniZ3R devtool 
(formerly called BytesGen)

![ByteniZ3R title logo](https://github.com/mvac7/mSXdevtools_ByteniZ3R/raw/main/GFX/ByteniZ3R_logoX3.png)
    
```
Short:        Another generator of data tables in Bytes.         
Architecture: Microsoft .Net Framework 4.0
Programming language: Visual BASIC .net
License:      GNU General Public License v3   
```

## Sorry! This text is pending correction of the English translation

                                                               

---

## Description

Generates tables of 8 bits unsigned values, from waveforms in different programming languages (BASIC, C or ASM).

This tool is designed primarily to support cross-development of retro-computer applications.
   
This software was developed in Microsoft Visual Studio Community 2019.




---

## License

Copyright (C) 2022 mvac7

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.
 

---

## Requirements:

* Windows OS with .net framework v4.0
* Display with minimum resolution: XVGA (1024x768)



## How to Install and Run
 
Unpack ByteniZ3R ZIP somewhere on your hard disk (It is not inside a folder). 
   
For run, execute ByteniZ3R.exe  


## Features

* Sinus, Cosinus, Square, Triangle and Sawtooth waveforms table generator.
* Random table generator.
* Maximum and minimum adjustment.
* Phase and Frequency adjustmens.
* BASIC, C and Assembler output.
* Supports several number systems and data formats (decimal, hexadecimal or binary)
* Edit info project.
* Save/Load project files.
* Save output to source code or binary

---

## History of versions

This application started as a tool that generated tables of random numbers that I used for the development of the visual effects application veejingSX for MSX computers.

Later I would add the option to load binary files and dump them in tables formatted for different programming languages.

The next step was to generate mathematical forms to use as paths for sprite movement and thinking of a future version that will serve for musical waveforms (thinking of the SCC).

The most current versions have a new name because one day I woke up with the need to provide a unique and cool name. 
The thinking brain behind the new name is Mr. [Fubukimaru](http://www.gamerachan.org/fubu/).

In March 2022, I resumed this project which I had pending a v0.9b Release. 
Updated some classes, removed binary loading, and gave the frontend a new look.
The decision to remove the binary load is due to the fact that I have been developing several specific applications for different compressors for some time. 
This functionality is no longer required.

![ByteniZ3R screenshot](https://github.com/mvac7/mSXdevtools_ByteniZ3R/raw/main/GFX/screenshots/ByteniZ3R_v0910b_screenshot01.png)


### ByteniZ3R v0.9.n (2022).

- Remove binary handling function #6 
- Remove compress data (No compression is obtained with this data type)
- Add Reverse Sawtooth waveform
- Updated graphical interface


### ByteniZ3R v0.9.1b (August 2021).

- Save/Load Project File.
- Add Project Info
- Move Random tab to waveform.
- Add Square waveform
- Add Triangle waveform
- Add Sawtooth waveform
- Add Phase property, to move the waveform.
- Add Frequency property.
- Add sliders in all wave form values.
- Improvements in the visualization of the graphic output of the wave.
- In the output it shows the parameters in a comment.
- Save binary file from output (with compression). For assemblers and compilers that allow to include binary files.
- Refresh output data and graphic when the input data are modified.
- Show hex dump from a loaded binary file.
- Config for paths and default output type data.
- More internal improvements.


### BytesGen! v0.8.1b (January 2018) 

Not published.


### BytesGen! v0.8b (May 2016) 

Not published.


### BytesGen! v0.7.2.0b (February 2014)

- Output Textbox and buttons, added to the Output GroupBox.
- Clear button

[Google Code](https://code.google.com/archive/p/bytes-gen/)

### BytesGen! v0.7.1.0b (?) 

Not published.

- basic line changes do increase to 10 (before = 15). 
- drag & drop a file from the system to the input file (binary file).
- Added new output formats data (hex).
- Output is cleared when switching tabs.


### BytesGen v0.7.0.0b (May 2013) First published version

Requires: PC with Windows System and Framework 2.0

[Google Code](https://code.google.com/archive/p/bytes-gen/)





---

## Acknowledgments
  
I want to give a special thanks to all those who freely share their knowledge with the MSX developer community.

- Avelino Herrera > [`WEB`](http://msx.avelinoherrera.com/index_es.html)
- Nerlaska > [`Blog`](http://albertodehoyonebot.blogspot.com.es)
- Marq > [`Marq`](http://www.kameli.net/marq/)
- MSXKun/Paxanga soft > [`WEB`](http://paxangasoft.retroinvaders.com/)
- Fubukimaru [`gitHub`](https://github.com/Fubukimaru)
- Andrear > [`Blog`](http://andrear.altervista.org/home/msxsoftware.php)
- Sapphire/Z80ST > [`WEB`](http://z80st.auic.es/)
- Fernando García > [`Video Tutorial`](http://www.z80st.es/cursos/bitvision-assembler)
- Ramones > [`MSXblog`](https://www.msxblog.es/tutoriales-de-programacion-en-ensamblador-ramones/) - [`MSXbanzai`](http://msxbanzai.tni.nl/dev/faq.html)
- Eric Boez > [`gitHub`](https://github.com/ericb59)
- MSX Assembly Page > [`WEB`](http://map.grauw.nl/resources/msxbios.php)
- Portar MSX Tech Doc > [`WEB`](https://problemkaputt.de/portar.htm)
- MSX Resource Center > [`WEB`](http://www.msx.org/)
- Karoshi MSX Community > [`WEB`](http://karoshi.auic.es/)
- BlueMSX emulator >> [`WEB`](http://www.bluemsx.com/)
- OpenMSX emulator >> [`WEB`](http://openmsx.sourceforge.net/)
- [`WebMSX`](https://webmsx.org/) emulator by Paulo A. Peccin >> [`gitHub`](https://github.com/ppeccin/webmsx)
- fMSX emulator by Marat Fayzullin [`WEB`](https://fms.komkon.org/fMSX/)
- Meisei emulator by Hap >> `?`

