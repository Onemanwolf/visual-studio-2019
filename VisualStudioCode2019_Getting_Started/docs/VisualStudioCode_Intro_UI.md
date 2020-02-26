# User Interface

At its heart, Visual Studio Code is a code editor. Like many other code editors, VS Code adopts a common user interface and layout of an explorer on the left, showing all of the files and folders you have access to, and an editor on the right, showing the content of the files you have opened.


![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/VisualStudioCode2019_Getting_Started/docs/Images/hero.png?raw=true "Request Pipeline")


# Basic Layout
VS Code comes with a simple and intuitive layout that maximizes the space provided for the editor while leaving ample room to browse and access the full context of your folder or project. The UI is divided into five areas:

* Editor - The main area to edit your files. You can open as many editors as you like side by side vertically and horizontally.
* Side Bar - Contains different views like the Explorer to assist you while working on your project.
* Status Bar - Information about the opened project and the files you edit.
* Activity Bar - Located on the far left-hand side, this lets you switch between views and gives you additional context-specific indicators, like the number of outgoing changes when Git is enabled.
* Panels - You can display different panels below the editor region for output or debug information, errors and warnings, or an integrated terminal. Panel can also be moved to the right for more vertical space.

Each time you start VS Code, it opens up in the same state it was in when you last closed it. The folder, layout, and opened files are preserved.

Open files in each editor are displayed with tabbed headers ([Tabs](https://code.visualstudio.com/docs/getstarted/userinterface#_tabs)) at the top of the editor region. To learn more about tabbed headers, see the Tabs section below.

>Tip:           
>You can move the Side Bar to the right hand side (View > Move Side Bar Right) or toggle its visibility ```(Ctrl+B)```.

# Side by side editing

You can open as many editors as you like side by side vertically and horizontally. If you already have one editor open, there are multiple ways of opening another editor to the side of the existing one:

* Alt click on a file in the Explorer.
* Ctrl+\ to split the active editor into two.
* Open to the Side (Ctrl+Enter) from the Explorer context menu on a file.
* Click the Split Editor button in the upper right of an editor.
* Drag and drop a file to any side of the editor region.
* Ctrl+Enter (macOS: Cmd+Enter) in the Quick Open (Ctrl+P) file list.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/VisualStudioCode2019_Getting_Started/docs/Images/sidebyside.png?raw=true "Request Pipeline")

Whenever you open another file, the editor that is active will display the content of that file. So if you have two editors side by side and you want to open file 'foo.cs' into the right-hand editor, make sure that editor is active (by clicking inside it) before opening file 'foo.cs'.

By default editors will open to the right-hand side of the active one. You can change this behavior through the setting workbench.editor.openSideBySideDirection and configure to open new editors to the bottom of the active one instead.

When you have more than one editor open you can switch between them quickly by holding the Ctrl (macOS: Cmd) key and pressing 1, 2, or 3.

>Tip: You can resize editors and reorder >them. Drag and drop the editor title area to reposition or resize the editor.

# Minimap

A Minimap (code outline) gives you a high-level overview of your source code, which is useful for quick navigation and code understanding. A file's minimap is shown on the right side of the editor. You can click or drag the shaded area to quickly jump to different sections of your file.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/VisualStudioCode2019_Getting_Started/docs/Images/minimap.png?raw=true "Request Pipeline")


>Tip: You can move the minimap to the left >hand side or disable it completely by respectively setting "editor.minimap.side": "left" or "editor.minimap.enabled": false in your user or workspace settings.

## Indent Guides

The image above also shows indentation guides (vertical lines) which help you quickly see matching indent levels. If you would like to disable indent guides, you can set "editor.renderIndentGuides": false in your user or workspace settings.

# Breadcrumbs

The editor has a navigation bar above its contents called Breadcrumbs. It shows the current location and allows you to quickly navigate between folders, files, and symbols.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/VisualStudioCode2019_Getting_Started/docs/Images/breadcrumbs.png?raw=true "Request Pipeline")

Breadcrumbs always show the file path and if the current file type has language support for symbols, the symbol path up to the cursor position. You can disable breadcrumbs with the View > Show Breadcrumbs toggle command. For more information about the breadcrumbs feature, such as how to customize their appearance, see the Breadcrumbs section of the Code Navigation article.

# Explorer

The Explorer is used to browse, open, and manage all of the files and folders in your project. VS Code is file and folder based - you can get started immediately by opening a file or folder in VS Code.

After opening a folder in VS Code, the contents of the folder are shown in the Explorer. You can do many things from here:

* Create, delete, and rename files and folders.
* Move files and folders with drag and drop.
* Use the context menu to explore all options.

>Tip: You can drag and drop files into the >Explorer from outside VS Code to copy them (if the explorer is empty VS Code will open them instead)

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/VisualStudioCode2019_Getting_Started/docs/Images/explorer_menu.png?raw=true "Request Pipeline")

VS Code works very well with other tools that you might use, especially command-line tools. If you want to run a command-line tool in the context of the folder you currently have open in VS Code, right-click the folder and select Open in Command Prompt (or Open in Terminal on macOS or Linux).

You can also navigate to the location of a file or folder in the native Explorer by right-clicking on a file or folder and selecting Reveal in Explorer (or Reveal in Finder on macOS or Open Containing Folder on Linux).

>**Tip:** Type ```Ctrl+P``` (Quick Open) to quickly search and open a file by its name.

By default, VS Code excludes some folders from the Explorer (for example. ```.git```). Use the ```files.exclude``` [setting]() to configure rules for hiding files and folders from the Explorer.

>**Tip:** This is really useful to hide derived resources files, like ```\*.meta``` in Unity, or ```\*.js``` in a TypeScript project. For Unity to exclude the ```\*.cs.meta``` files, the pattern to choose would be: ```"**/*.cs.meta": true```. For TypeScript, you can exclude generated JavaScript for TypeScript files with: ```"**/*.js": {"when": "$(basename).ts"}.```

## Multi-selection
You can select multiple files in the **File Explorer** and **OPEN EDITORS** view to run actions (Delete, Drag and Drop, Open to the Side) on multiple items. Use the Ctrl/Cmd key with click to select individual files and ```Shift + click``` to select a range. If you select two items, you can now use the context menu Compare Selected command to quickly diff two files.

>**Note:** In earlier VS Code releases, clicking with the Ctrl/Cmd key pressed would open a file in a new Editor Group to the side. If you would still like this behavior, you can use the workbench.list.multiSelectModifier setting to change multi-selection to use the Alt key.

"workbench.list.multiSelectModifier": "alt"
## Filtering the document tree
You can type to filter the currently visible files in the File Explorer. With the focus on the File Explorer start to type part of the file name you want to match. You will see a filter box in the top-right of the File Explorer showing what you have typed so far and matching file names will be highlighted. When you press the cursor keys to move up and down the file list, it will jump between matching files or folders.

Hovering over the filter box and selecting Enable Filter on Type will show only matching files/folders. Use the 'X' Clear button to clear the filter.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/VisualStudioCode2019_Getting_Started/docs/Images/file-explorer-filter.png?raw=true "Request Pipeline")