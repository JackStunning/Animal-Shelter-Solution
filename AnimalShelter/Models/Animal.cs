using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public string Breed {get; set;}
        public string Name { get; set; }
        public string Gender { get; set; } 
        public string Date { get; set; }
        public int Id {get; set;}

        // public Animal(int id, string name, string gender, string date, string breed)
        // {
        //     Id = id;
        //     Name = name;
        //     Gender = gender;
        //     Date = date;
        //     Breed = breed;
        // }
        
        // public static Animal Find(int searchId)
        // {
        //     MySqlConnection conn = DB.Connection();
        //     conn.Open();

        //     var cmd = conn.CreateCommand() as MySqlCommand;
        //     cmd.CommandText = @"SELECT * FROM `items` WHERE id = @thisId;";
            
        //     MySqlParameter thisId = new MySqlParameter();
        //     thisId.ParameterName = "@thisId";
        //     thisId.Value = id;
        //     cmd.Parameters.Add(thisId);

        //     var rdr = cmd.ExecuteReader() as MySqlDataReader;
        //     int animalId = 0;
        //     string animalBreed = "";
        //     string animalName = "";
        //     string animalGender = "";
        //     string animalDate = "";

        //     while (rdr.Read())
        //     {
        //         animalId = rdr.GetInt32(0);
        //         animalBreed = rdr.GetString(1);
        //         animalName = rdr.GetString(2);
        //         animalGender = rdr.GetString(3);
        //         animalDate = rdr.GetString(4);
        //     }

        //     Animal foundAnimal = new Animal(animalId, animalBreed, animalName, animalGender, animalDate);

        //     conn.Close();
        //     if (conn != null)
        //     {
        //         conn.Dispose();
        //     }
        //     return foundAnimal;
        // }

        // public static List<Animal> GetAll()
        // {
        //     List<Animal> allAnimals = new List<Animal> { };
        //     MySqlConnection conn = DB.Connection();
        //     conn.Open();
        //     MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //     cmd.CommandText = @"SELECT * FROM animals;";
        //     MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        //     while (rdr.Read())
        //     {
        //         int animalId = rdr.GetInt32(0);
        //         string animalName = rdr.GetString(1);
        //         string animalGender = rdr.GetString(2);
        //         string animalDate = rdr.GetString(3);
        //         string animalBreed = rdr.GetString(4);
        //         Animal newAnimal = new Animal(animalId, animalName, animalGender, animalDate, animalBreed);
        //         allAnimals.Add(newAnimal);
        //     }
        //     conn.Close();
        //     if (conn != null)
        //     {
        //         conn.Dispose();
        //     }
        //     return allAnimals;
        // }

        // public static void ClearAll()
        // {
        //     MySqlConnection conn = DB.Connection();
        //     conn.Open();
        //     MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //     cmd.CommandText = @"DELETE FROM animals;";
        //     cmd.ExecuteNonQuery();
        //     conn.Close();
        //     if(conn != null)
        //     {
        //         conn.Dispose();
        //     }
        // }

        // public override bool Equals(System.Object otherAnimal)
        // {
        //     if (!(otherAnimal is Animal))
        //     {
        //         return false;
        //     }
        //     else
        //     {
        //         Animal newAnimal = (Animal) otherAnimal;
        //         bool idEquality = (this.Id == newAnimal.Id);
        //         bool breedEquality = (this.Breed == newAnimal.Breed);
        //         return (idEquality && breedEquality);
        //     }
        // }

        // public void Save()
        // {
        //     MySqlConnection conn = DB.Connection();
        //     conn.Open();
        //     var cmd = conn.CreateCommand() as MySqlCommand;

        //     cmd.CommandText = @"INSERT INTO animals (name) VALUES (@AnimalName);";
        //     MySqlParameter name = new MySqlParameter();
        //     name.ParameterName = "@AnimalName";
        //     name.Value = this.Name;
        //     cmd.Parameters.Add(name);
        //     cmd.ExecuteNonQuery();
        //     Id = (int) cmd.LastInsertedId;
        //     conn.Close();
        //     if (conn != null)
        //     {
        //         conn.Dispose();
        //     }
        // }

    }
    

    // public Animals (List<Type> differentAnimals)
    // {
    //     TypeofAnimal = differentAnimals;
    // }


}


