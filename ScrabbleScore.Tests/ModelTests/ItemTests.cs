using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
    [TestMethod]
    public void Constructor_CreatesInstanceOf_Item()
    {
      Item i = new("test");
      Assert.AreEqual(typeof(Item), i.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Item i = new(description);
      string result = i.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_ChangesDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      string updatedDescription = "Do the dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Item> newList = new List<Item> { };

      // Act
      List<Item> result = Item.GetAll();

      // foreach (Item thisItem in result)
      // {
      //   Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
      // }

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string d1 = "Walk the dog";
      string d2 = "Wash the dishes";
      Item i1 = new(d1);
      Item i2 = new(d2);
      List<Item> l = new List<Item> { i1, i2 };

      //Act
      List<Item> result = Item.GetAll();

      // foreach (Item thisItem in result)
      // {
      //   Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
      // }

      //Assert
      CollectionAssert.AreEqual(l, result);
    }

  }
}
