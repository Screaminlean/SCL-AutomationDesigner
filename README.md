# AutomationDesigner

Excel Addin for creating an open source low code solution for cad automation.

Used in conjuction with an Inventor Wrapper and Solidworks wrapper also in this repo.

Visit [Here](https://youtu.be/BZphGDApiC8) for a demo of solidworks

Visit [Here](https://youtu.be/4ZBVhaNvh8I) for a demo of Inventor

# My fork
I forked from the [original](https://github.com/jraleighdev/AutomationDesigner) as there seemed to be no response from the author for issues or instructions on installing.


# Versions
## v1.0.0.6
To install go to the releases
* Updated packages
  * Microsoft.Xaml.Behaviors.Wpf to 1.1.135
  * MahApps.Metro to 2.4.10
  * ControlzEx to version 5.0.2 (highest we can with the MahApps.Metro)
  * InventorWrapper can't be updated just yet!
- Cleaned up warnings for unused varables.
- Updated the build targets for x64 as anyCPU is bad!
- Removed signing and updated the reference to Autodesk.Inventor.Interop.dll
- Updated Autodesk.Inventor.Interop.dll to v25.0.0.0
- Built binary
- Added VstoAddinInstaller to create setup without signing.
- Created github release.

## Original v1.0.0.5
No information or response from the author.


