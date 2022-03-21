using ModelApp;
using System;
using System.Collections.Generic;

namespace ConsoleModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection.Connect("Server=127.0.0.1;Database=csharp;Uid=root;Pwd=8576;","MySql");
            Dictionary<string,string> fields = Connection.GetTableFields("eleve");

            //description of eleve
            Console.WriteLine("ELEVE:");
            foreach(KeyValuePair<string,string> field in fields)
            {
                Console.WriteLine(field.Key + " | " + field.Value);
            }


            //eleve stuff
            Eleve elv1 = new Eleve();
            elv1.id = 0;
            elv1.prenom = "aymane";
            elv1.nom = "dabdoubi";
            elv1.code = "CB00000";
            elv1.code_fil = "ginf2";
            elv1.niveau = "YOOT";

            elv1.save();

            Eleve elvFound =(Eleve) elv1.find();

            Console.WriteLine(elvFound.ToString());

        }
    }
}
