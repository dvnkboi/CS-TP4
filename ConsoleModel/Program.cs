using ModelApp;
using System;
using System.Collections.Generic;
using GestionNotes.utils;
using System.Linq;
using System.IO;

namespace ConsoleModel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("---------------------Mysql--------------------");
            Console.WriteLine("----------------------------------------------");

            //create connection
            Connection.Connect("Server=127.0.0.1;Database=csharp;Uid=root;Pwd=8576;", "MySql");

            Eleve elv0 = new() { id = 1649766495, code = "uwuUWU", nom = "test_proc", prenom = "proc_insert", code_fil = "ginf", niveau = 2 };

            Console.WriteLine("\n------------------PROCEDURES------------------");
            elv0.delete();
            elv0.save("insert_eleve");
            Console.WriteLine((Eleve)elv0.find());

            elv0.prenom = "proc_update";
            elv0.save("update_eleve");
            Console.WriteLine((Eleve)elv0.find());

            elv0.delete("delete_eleve");
            Console.WriteLine(((Eleve)elv0.find())?.ToString() ?? "not found");

            Console.WriteLine("\n-----------------PROCEDURES OK----------------");
            Console.WriteLine("\n--------------------FIELDS--------------------");

            //description of student table
            Dictionary<string, string> fields = Connection.GetTableFields("eleve");
            Console.WriteLine("ELEVE:");
            foreach (KeyValuePair<string, string> field in fields)
            {
                Console.WriteLine(field.Key + " | " + field.Value);
            }

            Console.WriteLine("\n-------------------FIELDS OK------------------");
            Console.WriteLine("\n-----------------MANIPULATION-----------------");

            //create student
            Eleve elv1 = new Eleve() { id = 123456789, code = "00000000000000", nom = "dabdoubi", prenom = "aymane", code_fil = "ginf", niveau = 2 };
            Eleve elv2 = new Eleve() { id = 987654321, code = "000000000000000", nom = "oulad sine", prenom = "Saloua", code_fil = "ginf", niveau = 2 };
            Eleve elv3 = new Eleve() { id = 918273645, code = "0000000000000000", nom = "Ramy", prenom = "Ayman", code_fil = "ginf", niveau = 2 };
            Eleve elv4 = new Eleve() { id = 564738291, code = "00000000000000000", nom = "benkhanous", prenom = "Salaheddine", code_fil = "ginf", niveau = 2 };

            //save student 
            elv1.save();
            Console.WriteLine($"student {elv1.code} saved");

            Console.WriteLine("\n find output:");

            //check if eleve exists in db
            Eleve elvFound = (Eleve)elv1.find();
            Eleve elvFoundStatic = (Eleve)Eleve.find<Eleve>(elv1.id);
            Console.WriteLine("non static " + elvFound?.ToString() ?? "not found");
            Console.WriteLine("static " + elvFoundStatic?.ToString() ?? "not found static");

            //delete student
            elv1.delete();

            Console.WriteLine("\n find output after delete:");

            //check existance again
            elvFound = (Eleve)elv1.find();
            Console.WriteLine(elvFound?.ToString() ?? "not found");

            Console.WriteLine("\n----------------MANIPULATION OK---------------");
            Console.WriteLine("\n-------------------SHOW ALL-------------------");

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

            Console.WriteLine("\n-----------------SHOW ALL OK------------------");
            Console.WriteLine("\n--------------------SELECT--------------------");

            //select using criteria
            Dictionary<string, object> criteria = new Dictionary<string, object>()
            {
                {"niveau", 2 },
                {"code_fil","ginf" }
            };

            //select and display
            List<dynamic> selection = Eleve.select<Eleve>(criteria);
            foreach (Eleve eleve in selection)
            {
                Console.WriteLine(eleve.ToString());
            }

            Console.WriteLine("\n------------------SELECT OK-------------------");
            Console.WriteLine("\n--------------------EXPORT--------------------");

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ConvEngine.CreateCSV<Eleve>(Eleve.All<Eleve>().OfType<Eleve>().ToList<Eleve>(), Path.Combine(docPath, "test_mysql.csv"));
            Console.WriteLine("wrote CSV at " + Path.Combine(docPath, "test_mysql.csv"));
            ConvEngine.CreateXLS<Eleve>(Eleve.All<Eleve>().OfType<Eleve>().ToList<Eleve>(), Path.Combine(docPath, "test_mysql.xlsx"));
            Console.WriteLine("wrote CSV at " + Path.Combine(docPath, "test_mysql.xlsx"));

            Console.WriteLine("\n------------------EXPORT OK-------------------");
            Console.WriteLine("\n-------------------CLEAN UP-------------------");

            elv1.delete();
            elv2.delete();
            elv3.delete();
            elv4.delete();

            Console.WriteLine("\n-----------------CLEAN UP OK------------------");
            Console.WriteLine("\n------------------TEST DONE-------------------");

            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("---------------------Mssql--------------------");
            Console.WriteLine("----------------------------------------------");

            //create connection
            Connection.Connect("Data Source=STEALTH-15;Initial Catalog=csharp;Integrated Security=True", "MsSql");
            Connection.Connect("Data Source=STEALTH-15;Initial Catalog=csharp;Persist Security Info=True;User ID=sa;Password=8576", "MsSql");

            elv0 = new() { id = 1649766495, code = "uwuUWU", nom = "test_proc", prenom = "proc_insert", code_fil = "ginf", niveau = 2 };

            Console.WriteLine("\n------------------PROCEDURES------------------");
            elv0.delete();
            elv0.save("insert_eleve");
            Console.WriteLine((Eleve)elv0.find());

            elv0.prenom = "proc_update";
            elv0.save("update_eleve");
            Console.WriteLine((Eleve)elv0.find());

            elv0.delete("delete_eleve");
            Console.WriteLine(((Eleve)elv0.find())?.ToString() ?? "not found");

            Console.WriteLine("\n-----------------PROCEDURES OK----------------");
            Console.WriteLine("\n--------------------FIELDS--------------------");

            //description of student table
            fields = Connection.GetTableFields("moyenne");
            Console.WriteLine("ELEVE:");
            foreach (KeyValuePair<string, string> field in fields)
            {
                Console.WriteLine(field.Key + " | " + field.Value);
            }

            Console.WriteLine("\n-------------------FIELDS OK------------------");
            Console.WriteLine("\n-----------------MANIPULATION-----------------");

            //create student
            elv1 = new Eleve() { id = 123456789, code = "00000000000000", nom = "dabdoubi", prenom = "aymane", code_fil = "ginf", niveau = 2 };
            elv2 = new Eleve() { id = 987654321, code = "000000000000000", nom = "oulad sine", prenom = "Saloua", code_fil = "ginf", niveau = 2 };
            elv3 = new Eleve() { id = 918273645, code = "0000000000000000", nom = "Ramy", prenom = "Ayman", code_fil = "ginf", niveau = 2 };
            elv4 = new Eleve() { id = 564738291, code = "00000000000000000", nom = "benkhanous", prenom = "Salaheddine", code_fil = "ginf", niveau = 2 };

            //save student 
            elv1.save();
            Console.WriteLine($"student {elv1.code} saved");

            Console.WriteLine("\n find output:");

            //check if eleve exists in db
            elvFound = (Eleve)elv1.find();
            elvFoundStatic = (Eleve)Eleve.find<Eleve>(elv1.id);
            Console.WriteLine("non static " + elvFound?.ToString() ?? "not found");
            Console.WriteLine("static " + elvFoundStatic?.ToString() ?? "not found static");

            //delete student
            elv1.delete();

            Console.WriteLine("\n find output after delete:");

            //check existance again
            elvFound = (Eleve)elv1.find();
            Console.WriteLine(elvFound?.ToString() ?? "not found");

            Console.WriteLine("\n----------------MANIPULATION OK---------------");
            Console.WriteLine("\n-------------------SHOW ALL-------------------");

            //show all students
            elv1.save();
            elv2.save();
            elv3.save();
            elv4.save();

            //show all students
            Console.WriteLine($"All students:");
            elvs = Eleve.All<Eleve>();
            foreach (Eleve eleve in elvs)
            {
                Console.WriteLine(eleve.ToString());
            }

            Console.WriteLine("\n-----------------SHOW ALL OK------------------");
            Console.WriteLine("\n--------------------SELECT--------------------");

            //select using criteria
            criteria = new Dictionary<string, object>()
            {
                {"niveau", 2 },
                {"code_fil","ginf" }
            };

            //select and display
            selection = Eleve.select<Eleve>(criteria);
            foreach (Eleve eleve in selection)
            {
                Console.WriteLine(eleve.ToString());
            }

            Console.WriteLine("\n------------------SELECT OK-------------------");
            Console.WriteLine("\n--------------------EXPORT--------------------");

            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ConvEngine.CreateCSV<Eleve>(Eleve.All<Eleve>().OfType<Eleve>().ToList<Eleve>(), Path.Combine(docPath, "test_mssql.csv"));
            Console.WriteLine("wrote CSV at " + Path.Combine(docPath, "test_mssql.csv"));
            ConvEngine.CreateXLS<Eleve>(Eleve.All<Eleve>().OfType<Eleve>().ToList<Eleve>(), Path.Combine(docPath, "test_mssql.xlsx"));
            Console.WriteLine("wrote CSV at " + Path.Combine(docPath, "test_mssql.xlsx"));

            Console.WriteLine("\n------------------EXPORT OK-------------------");
            Console.WriteLine("\n-------------------CLEAN UP-------------------");

            elv1.delete();
            elv2.delete();
            elv3.delete();
            elv4.delete();

            Console.WriteLine("\n-----------------CLEAN UP OK------------------");
            Console.WriteLine("\n------------------TEST DONE-------------------");

            Console.WriteLine("\n\n-----------------ALL SUCCESS------------------");
        }
    }
}
