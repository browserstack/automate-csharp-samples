1. Download Gallio and install:
https://code.google.com/p/mb-unit/downloads/detail?name=GallioBundle-3.4.14.0-Setup-x64.msi

2. Open Visual Studio and create a new project

3. Download the Selenium dotnet driver and add the 4 DLLs from the net40 folder as references in the project
http://www.seleniumhq.org/download/

4. Right click on references -> Add reference -> Assemblies ->Framework
Then search for `Gallio` And `MbUnit` and add their DLL files respectively

5. Copy paste the test file in your project and add your BrowserStack Automate `Username` and `Access Key`.

6. Add the following commands in your `AssemblyInfo.cs` file:
```
using MbUnit.Framework;

//Parallel test
[assembly: DegreeOfParallelism(2)]
[assembly: Parallelizable(TestScope.All)]
```
7. Build your project. This will create the project DLL file.

8. Start `Icarus GUI Test Runner` application on your desktop.

9. Then click on "Add" button and select the `project.dll` by navigating to the VS project.

10. click on run.
