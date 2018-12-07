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
#### 
