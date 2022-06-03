# ByteniZ3R devtool 
(formerly called BytesGen)

![ByteniZ3R title logo](https://github.com/mvac7/mSXdevtools_ByteniZ3R/raw/main/GFX/ByteniZ3R_logoX3.png)
    
```
Short:        Waveform data table generator.         
Architecture: Microsoft .Net Framework 4.0
Programming language: Visual BASIC .net
License:      GNU General Public License v3   
```

## Sorry! This text is pending correction of the English translation
                                                               

<br/>

---

## Description

Generates tables of 8 bits unsigned values, from waveforms in different programming languages (BASIC, C or ASM).
It can be useful for generating graphics or creating paths to move [Sprites](https://en.wikipedia.org/wiki/Sprite_(computer_graphics)).

It includes examples for various development environments of the MSX system (Assembler, C and BASIC), 
which is what I know (sorry developers of other platforms).

You can access the documentation here with [`ByteniZ3R devtool DOC`](Docs/HOWTO.md).

In the source code [`Examples/`](Examples/), you can find applications for testing and learning purposes.

This project is open source, so you can improve or adapt the tool to your needs.
   
This software was developed in Microsoft Visual Studio Community 2019.
 

<br/>

---

## License

Copyright (C) 2022 mvac7

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.
 
<br/>

---

## Requirements:

* Windows OS with .net framework v4.0
* Display with minimum resolution: XVGA (1024x768)

<br/>


---

## Features

* 7 waveform generators: Sine, Cosine, Square, Triangle, Sawtooth, Reverse Sawtooth and Noise.
* Maximum and minimum adjustment.
* Phase and Frequency adjustmens.
* BASIC, C or Assembler output.
* Supports several number systems and data formats (decimal, hexadecimal or binary)
* Edit info project (Name, Version, Author, Group, and Description).
* Save/Load project files.
* Save output to source code 
* Save output to binary file

![ByteniZ3R screenshot](https://github.com/mvac7/mSXdevtools_ByteniZ3R/raw/main/GFX/screenshots/ByteniZ3R_v0916b_screenshot01.png)

<br/>

---

## History of versions

This application started as a tool that generated tables of random numbers that I used for the development of the visual effects application veejingSX for MSX computers.

Later I would add the option to load binary files and dump them in tables formatted for different programming languages.

The next step was to add waveforms. One of the applications for which I wanted to use it is to create paths for the movement of sprites, 
although I was also thinking of a future version (probably v1) that would allow generating samples for the SCC (requires signed Byte numbers).

In March 2022, I resumed this project which I had pending a v0.9b Release. 
Updated some classes, removed binary loading, and gave the frontend a new look.
The decision to remove the binary load is due to the fact that I have been developing several specific applications for different compressors for some time. 
This functionality is no longer required.


### ByteniZ3R v0.9.n (2022).

- Removed binary file handling function. (Apps for this feature will be available soon.) 
- Removed compress data (No compression is obtained with this data type)
- Add Reverse Sawtooth waveform
- Updated graphical interface (piXel style)
- Configure colors of the graph and the data output.
- Accepts tabs in the assembler output data format (add <tab>)
- It allows to obtain the data in binary numbers.
- Add binary number system in output data settings.


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


<br/>

---

## Acknowledgments
  
I want to give a special thanks to all those who freely share their knowledge with the MSX developer community.

- MSXKun/Paxanga soft > [`WEB`](http://paxangasoft.retroinvaders.com/)
- Fubukimaru > [`gitHub`](https://github.com/Fubukimaru)
- Avelino Herrera > [`WEB`](http://msx.avelinoherrera.com/index_es.html)
- Nerlaska > [`Blog`](http://albertodehoyonebot.blogspot.com.es)
- Marq > [`Marq`](http://www.kameli.net/marq/)
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

---
