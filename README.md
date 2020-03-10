# SharpReplacer

A simple C# WinForms application able to replace strings in multiple files, accepting regular expressions as well.


## How to use

1. Select the folder that contains the files you want to replace content.
   - (Opcional) Add a filter. Default is "*.*", which means "every file, every extension".
2. Add the strings to replace. The "+/-" buttons creates/deletes lines of replacement. You can switch the case sensitive function and use regular expressions too.
3. To replace all strings in all files(that matches the filter) in the selected folder, click the "Replace" button. The "Replace in all sub-directories" do exactly what its name suggests: executes the replace function in all sub-folders.


## License

This project is licensed under the GNU General Public License, see the [LICENSE](LICENSE) file for details.
