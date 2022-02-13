using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models; 
using System;

namespace Bakery.Tests 
{
  [TestClass]
  public class BakeryTests
  {

  [TestMethod]

  public void BreadConstructor_CreatesAnInstanceOfBread_Bread()
  {
    Bread newBread = new Bread(1);
    Assert.AreEqual(typeof(Bread), newBread.GetType());
  }

  [TestMethod]
  public void SetNumber_SetNumberOfLoaves_Int()
  {
  int NumberOfLoaves = 1;
  Bread newBread = new Bread(NumberOfLoaves);
  Assert.AreEqual(1, NumberOfLoaves);
  }

  [TestMethod]

  public void SetPrice_SetPriceOfOneLoaf_Int()
  {
    int NumberOfLoaves = 1;
    Bread newBread = new Bread(NumberOfLoaves);
    newBread.SetPrice();
    Assert.AreEqual(5, newBread.SetPrice());
  }

  [TestMethod]

  public void SetPrice_SetDiscountedPrice_Int()
  {
    int NumberOfLoaves = 3;
    Bread newBread = new Bread(NumberOfLoaves);
    newBread.SetPrice();
    Assert.AreEqual(10, newBread.SetPrice());
  }

  [TestMethod]

  public void PastryConstructor_CreatesAnInstanceOfPastries_Pastry()
  {
    Pastry newPastry = new Pastry(1);
    Assert.AreEqual(typeof(Pastry), newPastry.GetType());
  }

  [TestMethod]
  
  public void SetNumber_SetNumberOfPastries_Int()
  {
    int NumberOfPastries = 1;
    Pastry newPastry = new Pastry(NumberOfPastries);
    Assert.AreEqual(1, NumberOfPastries);
  }

  [TestMethod]
  
  
  public void SetPrice_SetPriceOfOnePastry_Int()
  {
    int NumberOfPastries = 1;
    Pastry newPastry = new Pastry(NumberOfPastries);
    newPastry.SetPrice();
    Assert.AreEqual(2, newPastry.SetPrice());
  }

  [TestMethod]

  public void SetPrice_SetPriceOfGreaterNumberOfPastries_Int()
  {
    int NumberOfPastries = 6;
    Pastry newPastry = new Pastry(NumberOfPastries);
    newPastry.SetPrice();
    Assert.AreEqual(10, newPastry.SetPrice());
  }

  [TestMethod]

  public void GetTotal_AddBakeryItems_Int()
  {
    Assert.AreEqual(8, OrderTotal.CalculatedTotal(4, 4));
  }
  }
  
} 
  