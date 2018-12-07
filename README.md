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

To launch MySQL servers:
* Access MySQL executing the command mysql -uroot -proot in the terminal.

Downloading & Importing the Database
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
