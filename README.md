# Hair Salon Application

#### C# Application with using database, December 7, 2018

#### By Victoria Martinez

## Description
MVC web application for a hair salon. The owner should be able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist.

The directory/file structure created is:

```
HairSalon.Solution
├── HairSalon
│   ├── Controllers
│   │   ├── HomeController.cs
│   │   └── ClassController.cs
│   ├── Models
│   │   └── Class.cs
│   ├── Program.cs
│   ├── Startup.cs
│   ├── HairSalon.csproj
│   └── Views
│       ├── Class
│       │   ├── DeleteAll.cshtml
│       │   ├── Index.cshtml
│       │   ├── New.cshtml
│       │   └── Show.cshtml
│       ├── Home
│       │   └── Index.cshtml
└── HairSalon.Tests
    ├── ControllerTests
    │   ├── HomeControllerTests.cs
    │   └── ClassControllerTests.cs
    ├── ModelTests
    │   └── ClassTests.cs
    └── HairSalon.Tests.csproj

```

### Specifications:
##### Spec 1: Do a thing:
- [ ] **Expect:** Input: some input; Output: some output;

## Setup/Installation Requirements
Clone the code from [GitHub](https://github.com/vmartinezlive/HairSalon.git).
Open the cloned directory from your terminal.

#### To launch MySQL servers:
* Access MySQL executing the command mysql -uroot -proot in the terminal.
Accessing phpMyAdmin with MAMP

* Ensure the MAMP server is running. Launch MAMP and check the Apache Server and MySQL Sever checkboxes in the upper-left corner of the MAMP window. If checked, they're running. If they're not checked, click Start Servers to launch.
* After servers are running, click Open start page in the MAMP window.
This will take us to the MAMP startup page in the browser at localhost:8888/MAMP/.
* Select the Tools menu from the top navbar of this page. Then select phpMyAdmin from the resulting drop-down.
* This will open phpMyAdmin in a new browser window or tab.

#### Sql Stylist Sql
Server: localhost:8889 Database: vicky_martinez
* stylist
CREATE TABLE `vicky_martinez`.`stylist` ( `id` INT NULL , `name` VARCHAR(255) NOT NULL , `client` VARCHAR(255) NOT NULL ) ENGINE = InnoDB;
* client
CREATE TABLE `vicky_martinez`.`client` ( `id` INT NULL , `name` VARCHAR(255) NOT NULL , `stylist` VARCHAR(255) NOT NULL ) ENGINE = InnoDB;

#### Exporting Database from MAMP
* Start MAMP servers and click Open WebStart page in the MAMP window.
* In the website you're taken to, select phpMyAdmin from the Tools dropdown.
* Open phpMyAdmin and select your database from the left side.
* Select the Export tab near the top of the screen.
* Change the Export Method from Quick to Custom.
* Choose Select All to ensure all database tables are included.
* In the Output section, choose to output the database to a file.
* Under Compression choose None or zipped. (Do NOT use gzipped; it has common import errors!)
* Under Format leave SQL selected.
* In Format-specific options leave the default selections intact.
* Under Object creation options check the box for Add CREATE DATABASE/USE. * * This will make sure your database is created with the correct name when you later import it back into phpMyAdmin.
* Under Data creation options leave the defaults intact, but make sure the radio button under Syntax to use when inserting data is set to both of the above.
* Finally, click Go.



#### Downloading & Importing the Database
* Download this zip file. Open the file to unzip it.
Launch MAMP, click Start Servers, and double-check the Apache Server and MySQL Sever checkboxes in the upper-left corner of the MAMP window are selected.
* After servers are running, click Open start page on the MAMP window. This will take us to the MAMP startup page in our browser at localhost:8888/MAMP/.
* Select the Import tab near the top of this page.
* Under File to import, select the unzipped database file. Keep all other default values on the form, and click Go at the bottom of the page.
* You should see a Import has been successfully finished success message, and a new world database appear in the left-hand list.

## Known Bugs
There are no known bugs on this application.

## Support and contact details
For any issues or questions contact Victoria Martinez: vmartinez72@live.com

## Technologies Used

HTML, CSS, Json, C# MySQL

### License
Copyright (c) 2018 ** Victoria Martinez **
