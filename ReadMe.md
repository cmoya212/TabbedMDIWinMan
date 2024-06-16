# Tabbed MDI Window Manager For WinForms
**\*\*\*NOTE: This is a legacy project and not actively maintained. It was formerly maintained in Codeplex and has been moved here in case it helps any developers using WinForms and bulding multi-window applications.\*\*\***
## Overview
MDIWindowManager is a control that can be added to your MDI Parent forms to achieve the Tabbed Document Interface (TDI) seen in many modern applications.
- Completely transparent and non-intrusive. There is no complex "framework" locking you into a particular technology... windows do not need to derive from some base class and no code changes need to be done on either the child windows or in your MDI child loading code.
- Built-in support for various window layouts, Tile Vertically, Tile Horizontally, Pop out to desktop... all while keeping the aesthetic tabbed interface (no title bar on child windows, no overlapping windows, etc).
- Supports CTRL+TAB forward and reverse window switching.
- Supports advanced 2 and 3-pane views without forcing the user to implement their windows as UserControls.
- Supports minimizing the window manager (in multi-pane scenarios) in a novel way while still keeping tabbed aesthetics.
- Built-in "Windows" menu that can be cloned and added to your parent form. Furthermore, since MDI Children are still MDI Children under the scenes, there is full support for menu merging.
## Documentation
- **[Documentation](https://1drv.ms/w/s!AtUuwRmVvmd4g75JxWunqL6y38xnNQ?e=xM7Iac)**
- **[Object Model](http://www.simonaplanner.com/cflashSoft/progs/mdiwinman/Doc/)**
## Download
- **[DLL - MdiWinMan.zip](http://www.simonaplanner.com/cflashSoft/progs/mdiwinman/)**
(See readme for instructions)
### Source Code
https://github.com/cmoya212/TabbedMDIWinMan