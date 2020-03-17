using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public string Type {get; set;}
        public int Id {get; set;}

        public Animal(string type, int id)
        {
            Type = type;
            Id = id;
        }

        public static List<Animal> GetAll()
        {
        List<Animal> allAnimals = new List<Animal> {};
        MySqlConnection conn = DB.Connection();
        conn.Open();
        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM items;";
        MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        while (rdr.Read())
        {
            int animalId = rdr.GetInt32(0);
            string animalType = rdr.GetString(1);
            Animal newAnimal = new Animal(animalType, animalId);
            allAnimals.Add(newAnimal);
        }

        conn.Close();
        if (conn!= null)
        { 
            conn.Dispose();
        }

        return allAnimals;
        }

        public static void ClearAll()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM animals;";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public override bool Equals(System.Object otherAnimal)
        {
            if(!(otherAnimal is Animal))
            {
                return false;
            }
            else
            {
                Animal newAnimal = (Animal) otherAnimal;
                bool typeEquality = (this.Type == newItem.Type);
                bool idEqaulity = (this.Id == newItem.Id);
                return (typeEquality && idEqaulity);
            }
        }

        public void Save()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;

            cmd.CommandText = @"INSERT INTO animals (type) VALUES (@AnimalType);";
            MySqlParameter type = new MySqlParameter();
            type.ParameterName = "@AnimalType";
            type.Value = this.Type;
            cmdParameters.Add(type);
            cmd.ExecuteNonQuery();

            conn.Close();
            if(conn != null)
            {
                conn.Dispose();
            }
        }
    }
    

    // public Animals (List<Type> differentAnimals)
    // {
    //     TypeofAnimal = differentAnimals;
    // }


}


