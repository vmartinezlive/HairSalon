using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest
  {
    public void Dispose()
    {
        Client.ClearAll();
    }

    // public ClientTest()
    // {
    //   DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=vicky_martinez_test;";
    // }

    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
    {
      Client newClient = new Client("Vicky", "Tanvi", 1, 1);
      Assert.AreEqual(typeof(Client), newClient.GetType());
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      int expectedId = 1;
      Client newClient = new Client("Vicky", "Tanvi", 1, expectedId);

      int actualId = newClient.GetId();

      Assert.AreEqual(expectedId, actualId);
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string expectedName = "Vicky";
      Client newClient = new Client(expectedName, "Tanvi", 1, 1);

      string actualName = newClient.GetName();

      Assert.AreEqual(expectedName, actualName);
    }

    
    [TestMethod]
    public void GetStylist_ReturnsStylist_String()
    {
      string expectedStylist = "Tanvi";
      Client newClient = new Client("Vicky", expectedStylist, 1, 1);

      string actualStylist = newClient.GetStylist();

      Assert.AreEqual(expectedStylist, actualStylist);
    }

    [TestMethod]
    public void GetStylistId_ReturnsId_Int()
    {
      int expectedStylistId = 1;
      Client newClient = new Client("Vicky", "Tanvi",expectedStylistId, 1);

      int actualStylistId = newClient.GetStylistId();

      Assert.AreEqual(expectedStylistId, actualStylistId);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ClientList()
    {
      //Arrange
      List<Client> expectedClientList = new List<Client> { };

      //Act
      List<Client> actualClientList = Client.GetAll();

      //Assert
      CollectionAssert.AreEqual(expectedClientList, actualClientList);
    }

    [TestMethod]
    public void Save_SavesToDatabase_ClientList()
    {
      //Arrange
      Client newClient = new Client("Vicky", "Tanvi", 1, 1);
      List<Client> expectedClientList = new List<Client>{newClient};

      //Act
      newClient.Save();
      List<Client> actualClientList = Client.GetAll();

      Console.WriteLine(expectedClientList[0].GetName());
      Console.WriteLine(actualClientList[0].GetName());
      //Assert
      CollectionAssert.AreEqual(expectedClientList, actualClientList);
    }

    [TestMethod]
  public void GetAll_ReturnsClient_List()
  {
    //Arrange
    Client clientOne = new Client("Vicky", "Stylist", 1, 1);
    Client clientTwo = new Client("Bob", "Chris", 2, 2);
    List<Client> expectedClientList = new List<Client> { clientOne, clientTwo };

    //Act
    List<Client> actualClientList = Client.GetAll();

    //Assert
    CollectionAssert.AreEqual(expectedClientList, actualClientList);
  }

  [TestMethod]
    public void Find_ReturnsCorrectClient_Client()
    {
      //Arrange
      string client01 = "Beth";
      string client02 = "Grace";
      Client newClient1 = new Client(client01);
      Client newClient2 = new Client(client02);

      //Act
      Client result = Client.Find(2);

      //Assert
      Assert.AreEqual(newClient2, result);
    }


 }
}
