# Whats that?
Games state Integration On LiveStream layout
This program shows on your stream info about your game for the viewers!
I also plan to do special effects on events and scene control on OBS.
For now it only supports CS:GO. O plan adding Dota 2  & Fortnite and PUBG.


## Installation
Download the latest release from [Here](https://github.com/Guy293/GLSI/releases)
Unzip the folder
Make sure your CS:GO is closed or restart the game later
Open GLSI.exe
Click on set up config file
If it shows an eror find where steam library is located: \Counter-Strike Global Offensive\ folder then click Ok
Now check wich stats you want and click start
Now go to OBS or any other program you use for streaming, recording, ETC...
Add new text Source
Select Read from file and search the program directory and the state text file you want
now set up your font, color, size, ETC... and click OK
Have Fun!

## FAQ
### Can i get Banned?
Nop. this is working on leagle State Integration.

### How can i help?
If you find bugs or have suggestions feel free to write it in Issues.


## To Do:
- [x] Save Settings
- [ ] Auto update from github
- [ ] Icon
- [ ] Add visual effects
- [ ] Add fortnite
- [ ] Run in system tray

## Nerd shit
yay im not alone!
Every game has its own technic 

On CS:GO It based on [Valves Game State Integration](https://developer.valvesoftware.com/wiki/Counter-Strike:_Global_Offensive_Game_State_Integration)
I use [CSGSI](https://github.com/rakijah/CSGSI) library, its for C# And much easier to use.
CSGO sends Json to localhost IP with the info given in the .cfg file.
The program reads it and update the text files. Then the OBS reads the file and change it to the viewers.
