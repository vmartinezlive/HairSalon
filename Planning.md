Planning Document

* Outline Classes/Tables
* Outline Models/Methods
* Create Database/Tables
* Create Test database
* Export Database
* Add Exported Database to HairSalon.Solution folder
* Create Models folder
* Crate .cs file for each Class in Models folder
* Create ControllerTests file for each Class and HomeController
* Create basic content for all files
* Set up tests files for working with the database
* Test that class properties can be retrieved
* Implement teardown using Dispose() and ClearAll() so that test data is cleared between each tests
* Add Equals() method to type cast objects, "Stylist" in this case that are in different parts of the memory - one in RAM, one from the database - as same object.
* Test that Save() saves to Database & GetAll() gets all "Stylist".


### Classes
* Stylist
* Client

### Stylist properties
* ID
* Name
* Clients

### Client properties
* ID
* Name
* Stylist

### Stylist Model
* public string GetName()
* public void Add()
* public void Delete()
* public List<Stylist> GetAll()
* public void Save()

### Client Model
* public string GetName()
* public void Add()
* public void Delete()
* public List<Client> GetAll()
* public void Save()

## Specifications
### Stylist Model
#### Spec 1: Stylist return stylist
**Example**
Input: "Vicky"
Output: "Vicky"
##### Spec 2: Stylist returns stylist id
**Example:**
Input:  Stylist: Vicky ID: 1
Output: 1
##### Spec: Stylist returns stylist name
**Example:**
Input:  "Vicky"
Output: "Vicky"
##### Spec: Stylist returns client name
**Example:**
Input:  Clients: "Vicky", "Tanvi", "Shiela"
Output: "Vicky", "Tanvi", "Shiela"
##### Spec: Stylist returns client id
**Example:**
Input:  Clients & ID: "Vicky, 1"
Output: 1
##### Spec: Stylist returns empty list
**Example:**
Input:
stylistOne: ("Vicky", "Tanvi" 1)
stylistTwo: ("Bob", 'Michael" 2)
Output: List<Bottle>{}
### Spec: Test that ClearAll() clears database
**Example:**
Input:
stylistOne: ("Vicky", "Tanvi" 1)
Output: List<stylistOne>{}
### Spec: Test that Save() saves to database
**Example:**
Input:
stylistOne: ("Vicky", "Tanvi" 1)
stylistTwo: ("Bob", 'Michael" 2)
Output: List<Stylist>{stylistOne, stylistTwo}
##### Spec: Stylist returns a list of all Stylist
**Example:**
Input:
stylistOne: ("Vicky", "Tanvi" 1)
stylistTwo: ("Bob", 'Michael" 2)
Output: List<Stylist>{stylistOne, stylistTwo}





### Client Model
#### Spec 1: Client return Client
**Example**
Input: "Vicky"
Output: "Vicky"
##### Spec 2: Client returns Client id
**Example:**
Input:  Client: Vicky ID: 1
Output: 1
##### Spec: Client returns Client name
**Example:**
Input:  "Vicky"
Output: "Vicky"
##### Spec: Client returns stylist name
**Example:**
Input:  Clients / Stylist: "Tanvi / Vicky"
Output: "Tanvi / Vicky"
##### Spec: Client returns client id
**Example:**
Input:  Clients & ID: "Tanvi, 1"
Output: 1
##### Spec: Client returns empty list
**Example:**
Input:
ClientOne: ("Vicky", "Tanvi" 1)
ClientTwo: ("Bob", 'Michael" 2)
Output: List<Bottle>{}
### Spec: Test that ClearAll() clears database
**Example:**
Input:
ClientOne: ("Vicky", "Tanvi" 1)
Output: List<ClientOne>{}
### Spec: Test that Save() saves to database
**Example:**
Input:
ClientOne: ("Vicky", "Tanvi" 1)
ClientTwo: ("Bob", 'Michael" 2)
Output: List<Client>{ClientOne, ClientTwo}
##### Spec: Client returns a list of all Client
**Example:**
Input:
ClientOne: ("Vicky", "Tanvi" 1)
ClientTwo: ("Bob", 'Michael" 2)
Output: List<Client>{ClientOne, ClientTwo}
