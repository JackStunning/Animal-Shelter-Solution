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
            Animal.ClearAll();
        }

        public AnimalTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=animal_shelter_test;";
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyListFromDatabase_AnimalList()
        {
            List<Animal> newList = new List<Animal> {};
            List<Animal> result = Animal.GetAll();
            CollectionAssert.AreEqual(newList, result); 
        }

        [TestMethod]
        public void Equals_ReturnsTrueIfBreedsAreTheSame_Animal()
        {
            Animal firstAnimal = new Animal(1, "Bob", "Female", "0115", "Cat");
            Animal secondAnimal = new Animal(1, "Bob", "Female", "0115", "Cat");

            Assert.AreEqual(firstAnimal, secondAnimal);
        }

        [TestMethod]
        public void Save_SavesToDatabase_ItemList()
        {
            //Arrange
            Animal testAnimal = new Animal(1, "Bob", "Female", "0115", "Cat");

            //Act
            testAnimal.Save();
            List<Animal> result = Animal.GetAll();
            List<Animal> testList = new List<Animal>{testAnimal};

            //Assert
            CollectionAssert.AreEqual(testList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAnimals_AnimalList()
        {
            //Arrange
            Animal newAnimal1 = new Animal(1, "Bob", "Female", "0115", "Cat");
            newAnimal1.Save(); // New code
            Animal newAnimal2 = new Animal(2, "Bobb", "Male", "0114", "Dog");
            newAnimal2.Save(); // New code
            List<Animal> newList = new List<Animal> { newAnimal1, newAnimal2 };

            //Act
            List<Animal> result = Animal.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectAnimalFromDatabase_Animal()
        {
            Animal newAnimal = new Animal("1", "Sally", "Female", "0222", "Horse");
            newAnimal.Save();
            Animal newAnimal2 = new Animal("2", "Peter", "Male", "0330", "Donky");
            Animal foundAnimal = Animal.Find(newAnimal.Id);
            Assert.AreEqual(newAnimal, foundAnimal);
        }
    }
}