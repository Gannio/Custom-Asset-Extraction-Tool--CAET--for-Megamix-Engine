# Custom Asset Extraction Tool (CAET) for Megamix
This is a tool designed to take custom assets created within the Megamix engine and copy them into a new set of folders seperated from the default assets. Files are kept in the same specifications of directories, making it easy to port them into a new project file.

Currently, asset collection is based on nomenclature specified for MaGMML3 (e.g. sprGannio_MySprite), so objects must have a specific username/word after the intial prefix in order to be collected.

##Usage
First, browse for the project file of the project holding your assets. This will let the program know to start from that directory.
Next, type your username in the Username text box.
Finally, click Output! to choose a place to save your file. When choosing where to save, it will look like the file you are saving is an actual file rather than a folder, because Visual Studio's normal folder option uses the uglier folder tree, which would make navigation much slower overall. The name of this 'file' will be the name of the outputted folder.
