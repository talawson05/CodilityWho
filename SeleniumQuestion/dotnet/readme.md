# Prerequisites 

Chrome<br>
dotnet version 3+

## Install
Install the packages in the .csproj, either through your IDE or using ```dotnet restore``` on the command line within the directory with the csproj file.
<br>Verify the install by running the default test provided, you should see a Chrome browser open and close, as it checks the page title.

## Write tests
Choose your preferred IDE or Text Editor from the ones available.
<br>Create each test as a new test method within the provided test class
<br>The setup method provides an instantiated webdriver object on the target page.