using ModelApp;
using System;
using System.Collections.Generic;

namespace ConsoleModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //create connection
            Connection.Connect("Server=127.0.0.1;Database=csharp;Uid=root;Pwd=8576;","MySql");


            //description of student table
            Dictionary<string, string> fields = Connection.GetTableFields("eleve");
            Console.WriteLine("ELEVE:");
            foreach (KeyValuePair<string, string> field in fields)
            {
                Console.WriteLine(field.Key + " | " + field.Value);
            }


            //create student
            Eleve elv1 = new Eleve() { id = 0, code = "CB0000", nom = "dabdoubi", prenom = "aymane", code_fil = "ginf2", niveau = "TEEY" };
            Eleve elv2 = new Eleve() { id = 1, code = "BC1111", nom = "oulad sine", prenom = "Saloua", code_fil = "ginf2", niveau = "TEEY" };
            Eleve elv3 = new Eleve() { id = 2, code = "X01010", nom = "Ramy", prenom = "Ayman", code_fil = "ginf2", niveau = "YEET" };
            Eleve elv4 = new Eleve() { id = 3, code = "X10101", nom = "benkhanous", prenom = "Salaheddine", code_fil = "ginf2", niveau ="YEET" };

            //save student 
            elv1.save();
            Console.WriteLine($"student {elv1.code} saved");

            Console.WriteLine("\n find output:");

            //check if eleve exists in db
            Eleve elvFound = (Eleve)elv1.find();
            Console.WriteLine(elvFound == null ? "not found" : elvFound.ToString());

            //delete student
            elv1.delete();

            Console.WriteLine("\n find output after delete:");

            //check existance again
            elvFound = (Eleve)elv1.find();
            Console.WriteLine(elvFound == null ? "not found" : elvFound.ToString());


            Console.WriteLine("-----------------------------------------");


            //show all students
            elv1.save();
            elv2.save();
            elv3.save();
            elv4.save();

            //show all students
            Console.WriteLine($"All students:");
            List<dynamic> elvs = Eleve.All<Eleve>();
            foreach (Eleve eleve in elvs)
            {
                Console.WriteLine(eleve.ToString());
            }


            Console.WriteLine("-----------------------------------------");


            //select using criteria
            Dictionary<string, object> criteria = new Dictionary<string, object>()
            {
                {"niveau", "TEEY" }
            };

            //select and display
            List<dynamic> selection = Eleve.select<Eleve>(criteria);
            foreach (Eleve eleve in selection)
            {
                Console.WriteLine(eleve.ToString());
            }


        }
    }
}
