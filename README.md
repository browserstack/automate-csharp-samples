automate-csharp-samples
=======================

Documentation for writing Automate test scripts in C#  

## Install selenium driver for .net

 - Download selenium web-driver in zip format from http://selenium.googlecode.com/files/selenium-dotnet-2.33.0.zip
 - Create folder C:\selenium-dotnet (or your default folder for .net libs in MAC/Linux) and unzip the downloaded file in the same location.
 - Driver API reference can be found here: http://selenium.googlecode.com/git/docs/api/dotnet/index.html

## Setup your IDE to write selenium tests

### Visual Studio:

 - In order to write selenium test in visual studio, create a new "Console Application" in visual studio. File→New Project→Visual c#→Console Application.
 - Then the selenium libraries are needed to be imported through "Solution Explorer" pane. Right click on References, browse through C:\selenium-dotnet\selenium-dotnet-2.33.0\net40 and import the libraries.

For C# frameworks integration with BrowserStack, refer to their individual repositories - 

- [Pnunit](https://github.com/browserstack/pnunit-browserstack)