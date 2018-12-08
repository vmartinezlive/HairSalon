using Microsoft.VisualStudio.TestTools.UnitTesting;
// using MySql.Data.MySqlClient;
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
        // Client.ClearAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=vinter_test;";
    }

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
    public void GetStylistlId_ReturnsId_Int()
    {
      int expectedStylistlId = 1;
      Client newClient = new Client("Vicky", "Tanvi",expectedStylistlId, 1);

      int actualStylistlId = newClient.GetStylistlId();

      Assert.AreEqual(expectedStylistlId, actualStylistlId);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      //Arrange
      List<Client> expectedClientList = new List<Client> { };

      //Act
      List<Client> actualClientList = Client.GetAll();

      //Assert
      CollectionAssert.AreEqual(expectedClientList, actualClientList);
    }

 }
}
