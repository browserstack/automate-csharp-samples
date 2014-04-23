# pnunit-sample
Sample code to run C# webdriver tests in parallel on multiple browsers on [BrowserStack Automate](http://www.browserstack.com/automate) using PNunit framework.

### Downloading PNunit
- Download [pnunit.zip](https://s3.amazonaws.com/browserStack/selenium/PNUnit.zip) and extract its contents into a folder say, "pnunit". This folder will contain .dll files for PNunit , Nunit, PNunit agent and launcher

### Setting up the tests
- Clone the repo and add `Test.cs` file into your C# project
- Replace `<BrowserStack.user>` and `<BrowserStack.key>` in `Test.cs` with your  browserstack `username` and `auth_key`
- Add refrences to pnunit and nunit frameworks from the "pnunit" folder to your project 
- If required, modify the `TestCase()` method in `Test.cs`. By default it contains a simple google search test case 
- Build your project
- Make changes in `test.conf` 
	- Specify your projects .dll and tests	 
	- Specify the browsers in which you want to run your tests
- Add the .dll file of your project, `test.conf` and any other refrenced .dll files like webdriver to "pnunit" folder

### Running the tests
- Go to pnunit directory <br/>`cd pnunit` 
- Start the agent <br/> You can specify the port on which agent runs in `agent.conf` <br/> Run `start agent agent.conf` 
- Launcher wil launch the tests.<br/>Run `launcher test.conf`
- View your tests running on [BrowserStack Automate](http://www.browserstack.com/automate)
