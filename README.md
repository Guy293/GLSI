# Whats that?
Games state Integration On LiveStream layout
This program shows on your stream info about your game for the viewers!
I also plan to do special effects on events and scene control on OBS.
For now it only supports CS:GO. O plan adding Dota 2  & Fortnite and PUBG.


## Installation
When the program is gonna be done i will update this.


## FAQ
### Can i get Banned?
Nop. this is working on leagle State Integration.

### How can i help?
If you find bugs or have suggestions feel free to write it in Issues.


## To Do:
- [ ] Save Settings
- [ ] Add visual effects
- [ ] Add fortnite

## Nerd shit
yay im not alone!
Every game has its own technic 

On CS:GO It based on [Valves Game State Integration](https://developer.valvesoftware.com/wiki/Counter-Strike:_Global_Offensive_Game_State_Integration)
I use [CSGSI](https://github.com/rakijah/CSGSI) library, its for C# And much easier to use.
CSGO sends Json to localhost IP with the info given in the .cfg file.
The program reads it and update the text files. Then the OBS reads the file and change it to the viewers.
