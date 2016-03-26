# BrowserStack-PNUnit
This repo should help you run PNUnit tests on BrowserStack

### Setting up the tests

1. Download and extract the NUnit 2.6.4 bundle (NUnit-2.6.4.zip) from http://www.nunit.org/index.php?p=download
2. Download and extract the latest Selenium C# bundle from http://www.seleniumhq.org/download
3. Create a new project in Visual Studio.
 * Select ".Net Framework 3.5" in the "New Project" dialog. 
 * Select "Class Library"
 * Assign a name to the project
 * Click "OK"
4. In the "Project Explorer", select the project and right-click on references. Then select "Add reference" option and add the following DLL's in your project references:
  1. All the DLL files from Selenium-dotnet net35 folder (total 4).
  2. Following DLL files from NUnit/bin folder:
    * nunit.framework.dll
    * pnunit.framework.dll

5. Copy the test from the BrowserstackTest.cs file available in this repo. Please add your username and password to the test file.
6. Build the solution (Ctrl+Shift+B)
7. This will display a path of the project DLL file that is created. Copy the "projectname.dll" file to NUnit/bin folder.
8. Also add the 4 Selenium-donet DLL's (net35) to the NUnit/bin folder. 
9. Create a "bs_test.conf" file as available in this repo. This file contains the BrowserStack capabilities to be set for the test and the class details to be executed.
10. Use the following commands to run the test:
  1. start pnunit-agent.exe agent.conf
  2. pnunit-launcher.exe bs_test.conf

11. This will initiate the tests on BrowserStack. Check running tests on the BrowserStack's [Automate Dashboard] (https://www.browserstack.com/automate)
