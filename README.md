# CVSJoiner
Task: Write a command line program to "join" .csv files. Use any programming language you're comfortable with. Your program should work similarly to the unix "join" utility (google for it). Unlike the unix join, your program will not require files to be sorted on the key. Your program must also accept the "type" of join to use---merge join, inner loop join, or hash join, etc. Test your program on "large" files (e.g. make sure it doesn't blow up on one million records, etc.)

Solution: contains a [Xamarin Studio/VS C# console app project](https://github.com/DylanCh/CVSJoiner/tree/master/UnixCVSJoiner.Console) and a [WinForm project](https://github.com/DylanCh/CVSJoiner/tree/master/UnixCVSJoiner.WinForm). he main method is located in Program.cs. Forking is welcomed and appreciated!

Importing project(s) from this solution: download the source code, create a new Solution called UnixCVSJoiner in Xamarin Studio (Console) or Visual Studio (Console/WinForm), and Add existing project -> select the project(s).

Create a new solution: Create a new C# console project in Visual Studio/Xamarin Studio, and load the 3 classes (Program.cs, CVSParser.cs and Joiner.cs) into the new project, and build, run.
