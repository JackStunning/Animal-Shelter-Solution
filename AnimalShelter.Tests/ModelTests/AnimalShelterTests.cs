using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AnimalShelter.Models;
using System;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Tests
{
    [TestClass]
    public class AnimalTest : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }

        public ItemTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=animal_shelter_test;";
        }

        [TestMethod]
        publicvoid GetAll_ReturnsEmptyListFromDatabase_AnimalList()
        {
            List<Animal> newList = new List<Animal> {};
            List<Animal> result = Animal.GetAll();
            CollectionAssert.AreEqual(newList, result); 
        }
    }
}