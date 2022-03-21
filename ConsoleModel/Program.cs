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
            Dictionary<string,string> fields = Connection.GetTableFields("eleve");
            Console.WriteLine("ELEVE:");
            foreach(KeyValuePair<string,string> field in fields)
            {
                Console.WriteLine(field.Key + " | " + field.Value);
            }


            //create student
            Eleve elv1 = new Eleve();
            elv1.id = 0;
            elv1.prenom = "aymane";
            elv1.nom = "dabdoubi";
            elv1.code = "CB00000";
            elv1.code_fil = "ginf2";
            elv1.niveau = "YEET";

            Eleve elv2 = new Eleve();
            elv2.id = 1;
            elv2.prenom = "aymane";
            elv2.nom = "not dabdoubi";
            elv2.code = "BC11111";
            elv2.code_fil = "ginf2";
            elv2.niveau = "TEEY";

            //save student 
            elv1.save();

            //check if eleve exists in db
            Eleve elvFound = (Eleve) elv1.find();
            Console.WriteLine(elvFound.ToString());

            //delete student
            elv1.delete();

            //check existance again
            elvFound = (Eleve) elv1.find();
            Console.WriteLine(elvFound == null ? "not found" : elvFound.ToString());


            Console.WriteLine("-----------------------------------------");


            //show all students
            elv1.save();
            elv2.save();

            //show all students
            List<dynamic> elvs = Eleve.All<Eleve>();
            foreach(Eleve eleve in elvs)
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
