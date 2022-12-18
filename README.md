# Blacksmiths Forge

Modding tool for Cultist Simulator. 
Designed to have a smaller, less bloated scope than Carcass Spark with support for newer Cultist Simulator modding features. 


## TODO

 - Add a main overview to see everything that loaded
	 - A ListView on one side showing each file
		 - (Double) Click on one of the filenames to select it
			 - Shows its contents in the ListView next to it
			 - Some info displayed above entities ListView
				 - Entity type for file (can't change)
				 - Number of entities
				 - Selected filename (just so you can be extra sure)
			 - Buttons above entities list view
				 - New Entity
				 - Delete Entity
				 - Edit Entity
				 - Rename File
				 - Copy Entity
				 - Paste Entity
 - Add all main Entity types
	 - Add all main properties present in current version (`gateofhorn`) of the game's code
	 - Create forms for editing
		 - Raw JSON Editor via Scintilla
		 - Tree Editor of some kind?
			 - 