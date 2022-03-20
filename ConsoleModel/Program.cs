using ModelApp;
using System;
using System.Collections.Generic;

namespace ConsoleModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection.Connect("Server=127.0.0.1;Database=c#;Uid=root;Pwd=8576;","MySql");
            Dictionary<string,string> fields = Connection.GetTableFields("eleve");

            //description of eleve
            Console.WriteLine("ELEVE:");
            foreach(KeyValuePair<string,string> field in fields)
            {
                Console.WriteLine(field.Key + " | " + field.Value);
            }
        }
    }
}
