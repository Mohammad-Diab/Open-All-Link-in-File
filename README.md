# Open All Link in File

A small Windows console app that opens every link listed in a text file, one after another. Written in C# on .NET Framework 4.5.

## Features

- Asks for the path of a text file that has one link per line.
- Opens each line with its default handler (`Process.Start`): web addresses open in the default browser, and file or folder paths open too.
- Waits for a key press between links, so you can deal with each page before the next one opens.
- Empty lines are skipped. A line that can't be opened, or a file that can't be read, prints the error and the app carries on.

The file should be saved as UTF-8 and hold nothing but links.

## Requirements

Windows with .NET Framework 4.5 or later. Windows 8, 10 and 11 already include it.

## Usage

Download `Open-All-Link-in-File-v1.0.0.7z` from [Releases](https://github.com/Mohammad-Diab/Open-All-Link-in-File/releases), extract it, and run `Open All Link in File.exe`. There is no installer.

Type the full path of the text file (without quotes) and press Enter, then press any key to open each next link.

The exe is not signed, so Windows SmartScreen may warn the first time you run it: click **More info**, then **Run anyway**.

## Building

```
git clone https://github.com/Mohammad-Diab/Open-All-Link-in-File.git
```

Open `Open all link in file.sln` in Visual Studio and build, or run:

```
MSBuild "Open all link in file.sln" /p:Configuration=Release
```

The exe is written to `Open all link in file\bin\Release`.

The project targets .NET Framework 4.5. Recent Visual Studio versions don't ship its reference assemblies; if the build stops with `MSB3644`, extract the [Microsoft.NETFramework.ReferenceAssemblies.net45](https://www.nuget.org/packages/Microsoft.NETFramework.ReferenceAssemblies.net45) NuGet package and point MSBuild at its `build` folder:

```
MSBuild "Open all link in file.sln" /p:Configuration=Release /p:TargetFrameworkRootPath=<package>\build
```

## Author

Mohammad Diab

## License

[Apache 2.0](LICENSE)
