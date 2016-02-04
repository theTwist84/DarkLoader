# RogueLoader [![Build status](https://ci.appveyor.com/api/projects/status/evq3v5pgw6wxegi4?svg=true)](https://ci.appveyor.com/project/no1dead/rogueloader)


Rogueloader is a tool aimed to work with all programs doing real time memory edits using pattern scanning with its primary focus being Tom Clancy's The Division

Anyone is welcome to help work on RogueLoader, so please, please do! 


You can easily help us by building patches, no C# compiling required. Check out the [PatchEditor](https://github.com/dark-c0de/DarkLoader/wiki/Patch-Editor)

## Tested Versions
* 1.0 Beta Build

### Here's a feature list of what it can do right now:
1. Pattern scan and create patterns and patches to share with other users (pull requests!), see [PatchEditor](https://github.com/dark-c0de/DarkLoader/wiki/Patch-Editor)

### Here's what's planned:
1. Hook Console for command access.
2. Hook into Scripts Engine To call scripts.
3. etc anything else that might be needed.


### TODO
If you're a developer and you can help dig into the code, here's some things that need to be done.
* Add pattern matching to the `MagicPatches.ExePatches`. Currently ExePatches do not support matching like the memory scanner does. 
* Allow people to update their patch JSON without removing changes they've made.

Enjoy!
