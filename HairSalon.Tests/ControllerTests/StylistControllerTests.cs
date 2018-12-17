using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientControllerTest
    {

      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
        //Arrange
        ClientController controller = new ClientController();

        //Act
        IActionResult view = controller.Create("Wash hair");

        //Assert
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }

      [TestMethod]
      public void Create_RedirectsToCorrectAction_Index()
      {
        //Arrange
        ClientController controller = new ClientController();
        RedirectToActionResult actionResult = controller.Create("Wash hair") as RedirectToActionResult;

        //Act
        string result = actionResult.ActionName;

        //Assert
        Assert.AreEqual(result, "Index");
      }

    }
}
