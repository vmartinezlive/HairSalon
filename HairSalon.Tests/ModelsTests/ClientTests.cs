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

 }
}
