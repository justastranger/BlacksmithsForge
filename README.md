# Blacksmiths Forge

Modding tool for Cultist Simulator. 
Designed to have a smaller, less bloated scope than Carcass Spark with support for newer Cultist Simulator modding features. 


## TODO

- [x] Add a main overview to see everything that loaded
	- [x] A ListView on one side showing each file
		- [x] (Double) Click on one of the filenames to select it
			- [x] Shows its contents in the ListView next to it
			- [x] Some info displayed about the entities in the ListView
				- [x] Entity type for file (can't change)
				- [x] Number of entities
				- [x] Selected filename (just so you can be extra sure)
			- [ ] Buttons above entities list view
				- [x] New Entity
				- [ ] Delete Entity
				- [x] Edit Entity
					- [x] Using Text
					- [x] Using TreeView
					- [ ] Maybe a high-level, Carcass Spark-esque control-based editor
				- [ ] Rename/move File
				- [ ] Copy Entity
				- [ ] Paste Entity
- [x] TreeView-based editor
	- [x] Context menu when right clicking a property or value
		- [x] Rename property
		- [x] Add property
		- [x] Add values to Dictionary and List properties
		- [x] Delete properties
		- [ ] Input forms for adding more advanced values
			- [x] RecipeLink
			- [x] Sphere (aka slot)
			- [ ] Mutation
			- [x] Expulsion
			- [x] XTrigger
		- [x] Dictionary editor
			- Would be more intuitive for editing keys *and* values
				- As it stands, you can double-click a value to edit it but you have to right click the key to rename it as a property
		- [ ] Tabbed Array editor
			- [ ] Each entry gets its own Scintilla text editor
			- [ ] Only other alternative would be to create a control for editing each Entity Type
				- [ ] The effort could be recycled in an un-tabbed editor for single Entities
					- [ ] With a Type in the constructor, the editor form could lookup the correct control for the Entity it has
					- [ ] The control itself could be tabbed to separate properties from property operations
						- [ ] Main tab
						- [ ] Operations for Lists
							- [ ] `"property$append: ["example1", {"id": "example2"}]"`
							- [ ] `"property$prepend": ["example1", {"id": "example2"}]`
							- [ ] `"property$remove": ["example1", "example2"]`
							- [ ] `"property$clear: <anything>`
						- [ ] Operations for Dictionaries
							- [ ] `"property$add": {"example1": 2}`
							- [ ] `"property$remove": ["example1", "example2"]`
							- [ ] `"property$clear: <anything>`
						- [ ] Operations for Numbers
							- [ ] `"property$plus": 1`
							- [ ] `"property$minus": 2`
							- [ ] `"property$clear: <anything>`
						- [ ] Operations for Strings
							- [ ] `"property$prefix": "example"`
							- [ ] `"property$postfix": "example"`
							- [ ] `"property$replace": [{"example1": "example2"}]`
							- [ ] `"property$replacelast": [{"example1": "example2"}]`
							- [ ] `"property$clear": <anything>`
						- [ ] Complex Operations
							- [ ] `"property$listedit"`
							- [ ] `"property$dictedit"`
- [ ] 