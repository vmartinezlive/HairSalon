using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest : IDisposable
  {

    public void Dispose()
    {
      Stylist.ClearAll();
      Client.ClearAll();
    }

    public StylistTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=victoria_martinez_test;";
    }

    [TestMethod]
    public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
    {
      Stylist newStylist = new Stylist("test stylist");
      Assert.AreEqual(typeof(Stylist), newStylist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Vicky";
      Stylist newStylist = new Stylist(name);

      //Act
      string result = newStylist.GetName();

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsStylistId_Int()
    {
      //Arrange
      string name = "Test Stylist";
      Stylist newStylist = new Stylist(name);

      //Act
      int result = newStylist.GetId();

      //Assert
      Assert.AreEqual(1, result);
    }


    [TestMethod]
    public void GetAll_RetrievesAllStylist_StylistList()
    {
      //Arrange
      Stylist newStylist = new Stylist("Martha");
      newStyl.Save();
      Stylist firstStylist = new Stylist("Sharon", newStylist.GetId());
      firstStylist.Save();
      Stylist secondStylist = new Stylist("Jim", newCategory.GetId());
      secondStylist.Save();
      List<Stylist> testStylistList = new List<Stylist> { firstStylist, secondStylist};

      //Act
      List<Stylist> resultStylistList = newCategory.GetStylists();

      //Assert
      CollectionAssert.AreEqual(testStylistList, resultStylistList);
    }

    [TestMethod]
    public void Find_ReturnsCorrectStylist_Stylist()
    {
      //Arrange
      string name01 = "Becky";
      string name02 = "Sue";
      Stylist newStylist1 = new Stylist(name01);
      Stylist newStylist2 = new Stylist(name02);

      //Act
      Stylist result = Stylist.Find(2);

      //Assert
      Assert.AreEqual(newStylist2, result);
    }

    [TestMethod]
    public void GetClients_ReturnsEmptyClientsList_ClientsList()
    {
      //Arrange
      string name = "Work";
      Stylist newStylist = new Stylist(name);
      List<Clients> newList = new List<Clients> { };

      //Act
      List<Clients> result = newStylist.GetClients();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

// *** not in TO DO list

   //  [TestMethod]
   //  public void GetAll_StylistEmptyAtFirst_List()
   //  {
   //    //Arrange, Act
   //    int result = Stylist.GetAll().Count;
   // 
   //    //Assert
   //    Assert.AreEqual(0, result);
   //  }
   //
   //  [TestMethod]
   //  public void Save_SavesStylistToDatabase_StylistList()
   //  {
   //    //Arrange
   //    Stylist testStylist = new Stylist("Martha");
   //    testStylist.Save();
   //
   //    //Act
   //    List<Stylist> result = Stylist.GetAll();
   //    List<Stylist> testList = new List<Stylist>{testStylist};
   //
   //    //Assert
   //    CollectionAssert.AreEqual(testList, result);
   //  }
   //
   //  [TestMethod]
   // public void Delete_DeletesStylistAssociationsFromDatabase_StylistList()
   // {
   //   //Arrange
   //   Client testClient = new Client("Jane");
   //   testClient.Save();
   //   string testName = "Kim";
   //   Stylist testStylist = new Stylist(testName);
   //   testStylist.Save();
   //
   //   //Act
   //   testStylist.AddClient(testClient);
   //   testStylist.Delete();
   //   List<Stylist> resultClientStylist = testClient.GetStylist();
   //   List<Stylist> testClientStylist
   //   = new List<Stylist> {};
   //
   //   //Assert
   //   CollectionAssert.AreEqual(testClientStylist, resultClientStylist);
   // }
