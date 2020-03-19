# _Best Restaurants_

#### _ASP.NET MVC practice for Epicodus_, _Mar. 19 2020_

#### By _**Alyssa Colistro, Rachel Schlieferstein, Katy Solovewicz**_

## Description

_A website where users can add their favorite restaurants based on the type of cuisine they offer._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
|User can can choose to add a new cuisine| "Mongolian Street Food"| "Mongolian Street Food" is added to the cuisine database|
|User can view all cuisines|Selects "view all"|All cuisines in the cuisine table of the database are printed to the page|
|User can view all restaurants of each cuisine|Clicks a cuisine|All restaurants belonging to that cuisine type are displayed.|
|User can edit added cuisines|"Mongolian Street Food" --> "Szechuan Street Food"|"Mongolian Street Food" is updated to "Szechuan Street Food" in the cuisine table|
|User can delete cuisines|User selects "Delete" from options on "Szechuan Street Food" Details page|"Szechuan Street Food" is removed from the cuisines table.|
|User can add a new restaurant and specify which cuisine it belongs to, as well as other restaurant details.|"Lucky Strike", "Szechuan Street Food"|"Lucky Strike" is added to the restaurants table, with the idea of the specified cuisine in a cuisine column.|
|User can view all restaurants|Selects "view all"|User can see all restaurants listed in the restaurants table.|
|User can edit restaurants|"Lucky Strike" --> "Unlucky Cat"|"Lucky Strike" is updated to "Unlucky Cat" in the restaraunt table.|
|User can delete restaurants|User selects "Delete"|The row with "Unlucky Cat" is removed from the restaurants table.|


## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/CarDealership.Solution``
* ``cd CarDealership.Solution``

_Confirm that you have navigated to the CarDealership.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd CarDealership``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``

_Test this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd CarDealership.Tests``
* ``dotnet restore``
* ``dotnet test``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _dotnet script_
* _MSTest_
* _MySQL_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin, Alyssa Colistro_**