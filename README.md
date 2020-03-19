# _Best Restaurants_

#### _ASP.NET MVC practice for Epicodus_, _Mar. 19 2020_

#### By _**Alyssa Colistro, Rachel Schieferstein, K Wicz**_

## Description

_A website where users can add their favorite restaurants based on the type of cuisine they offer._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
|User can can choose to add a new cuisine| "Mongolian Street Food"| "Mongolian Street Food" is added to the cuisine database|
|User can view all cuisines|Selects "view all"|All cuisines in the cuisine table of the database are printed to the page|
|User can view all restaurants of each cuisine|Clicks "Mongolian Street Food"|All restaurants that serve "Mongolian Street Food" are displayed.|
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
* ``git clone https://github.com/kwicz/BestRestaurants``
* ``cd BestRestaurants.Solution``

_Confirm that you have navigated to the CarDealership.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd BestRestaurants``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``


_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

### Create Project Database
* Navigate to your terminal and open MySQL
```sh
mysql -uroot -p<your_password_here>
```
* Once in MySQL, create a database for storing project data:
```sh
CREATE DATABASE `best_restaurants`;
```
* Create a table in best_restaurants for storing cusine data:
```sh
CREATE TABLE `cuisines` (
  `cuisineid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cuisineid`));
```
* Create a table in best_restaurants for storing restaurant data:
```sh
CREATE TABLE `restaurants` (
  `restaurantid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `rating` int(11) DEFAULT '0',
  `cuisineid` int(11) DEFAULT '0',
  PRIMARY KEY (`restaurantid`));
```

And Bon Apetit! Your project is now ready.

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kwicz/bestrestaurants/issues) here on GitHub._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _dotnet script_
* _MySQL_
* _EF Core_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Alyssa Colistro, Rachel Schieferstein, K Wicz_**