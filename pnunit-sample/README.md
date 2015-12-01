# pnunit-sample
Sample code to run C# webdriver tests in parallel on multiple browsers on [BrowserStack Automate](http://www.browserstack.com/automate) using PNunit framework.

### Downloading PNunit
- Download [pnunit.zip](https://s3.amazonaws.com/browserStack/selenium/PNUnit.zip) and extract its contents into a folder say, "pnunit". This folder will contain .dll files for PNunit , Nunit, PNunit agent and launcher

### Setting up the tests
- Clone the repo and add `BrowserStackTest.cs` file into your C# project
- Replace `<BrowserStack.user>` and `<BrowserStack.key>` in `BrowserStackTest.cs` with your  browserstack `username` and `auth_key`
- Add refrences to pnunit and nunit frameworks in the C# project, from the "pnunit" folder to your project (nunit.framework.dll, pnunit.framework.dll, WebDriver.dll & WebDriver.Support.dll).
- If required, modify the `TestCase()` method in `BrowserStackTest.cs`. By default it contains a simple google search test case 
-  Set the following option in the project properties:
Project properties → Output type → Class Library
- Build your project. This will create a 'ProjectName.dll' file and its location is specified in the console output of Visual Studio.
- Make changes in `test.conf` 
	- Specify the 'ProjectName.dll' in '<Assembly>' parameter of 'test.conf'	 
	- Specify the browsers in which you want to run your tests
- Add the 'ProjectName.dll' file of your project, `test.conf` and any other refrenced .dll files like webdriver to "pnunit" folder (extracted earlier)

### Running the tests
- Go to pnunit directory <br/>`cd pnunit` 
- Start the agent <br/> You can specify the port on which agent runs in `agent.conf` <br/> Run `start agent agent.conf` 
- Launcher wil launch the tests.<br/>Run `launcher test.conf`
- View your tests running on [BrowserStack Automate](http://www.browserstack.com/automate)

### Note
- All the files (BrowserStackTest.cs, test.conf, ProjectName.dll, launcher.exe & agent.exe) should be present in the same folder which was extracted from pnunit.zip.
