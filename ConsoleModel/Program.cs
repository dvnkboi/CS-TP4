using ModelApp;
using System;
using System.Collections.Generic;
using GestionNotes.utils;
using System.Linq;
using System.IO;
using GestionNotes.Models;

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
            Console.WriteLine("\n------------------CONNECTION------------------");

            Console.WriteLine("\nConnection sql string: Server=127.0.0.1;Database=csharp;Uid=root;Pwd=*******;");
            Connection.Connect("Server=127.0.0.1;Database=csharp;Uid=root;Pwd=8576;", "MySql");

            Console.WriteLine("\n-----------------CONNECTION OK----------------");

            Eleve elv0 = new() { id = 1649766495, code = "uwuUWU", nom = "test_proc", prenom = "proc_insert", code_fil = "ginf", niveau = 2 };

            Console.WriteLine("\n------------------PROCEDURES------------------");
            Console.WriteLine("\nINSERT:");
            elv0.Delete();
            elv0.Save("insert_eleve");
            Console.WriteLine(elv0.Find());

            Console.WriteLine("\nUPDATE:");
            elv0.prenom = "proc_update";
            elv0.Save("update_eleve");
            Console.WriteLine(elv0.Find());

            Console.WriteLine("\nDELETE:");
            elv0.Delete("delete_eleve");
            Console.WriteLine((elv0.Find())?.ToString() ?? "not found");

            Console.WriteLine("\n-----------------PROCEDURES OK----------------");
            Console.WriteLine("\n-------------------TRIGGERS-------------------");

            elv0.Save();
            Note note0 = new() { id = 1649766495, code_elv = "uwuUWU", code_mat = "c# prog", note = 12 };
            Note note1 = new() { id = 1321315533, code_elv = "uwuUWU", code_mat = "intro JEE", note = 10 };

            Console.WriteLine("\nBefore note insert");
            Console.WriteLine(Moyenne.Find<Moyenne>(elv0.id)?.ToString() ?? "moyenne not found");

            Console.WriteLine("\nInsert note1 = 12");
            elv0.nom = "test_trigger";
            elv0.prenom = "test_insert";
            note0.Save();
            Console.WriteLine($"{elv0.Find()} \n {Moyenne.Find<Moyenne>(elv0.id)}");

            Console.WriteLine("\nInsert note2 = 10");
            elv0.nom = "test_trigger";
            elv0.prenom = "test_insert";
            note1.Save();
            Console.WriteLine($"{elv0.Find()} \n {Moyenne.Find<Moyenne>(elv0.id)}");

            Console.WriteLine("\nInsert note2 = 13");
            elv0.nom = "test_trigger";
            elv0.prenom = "test_update";
            note1.note = 13;
            note1.Save();
            Console.WriteLine($"{elv0.Find()} \n {Moyenne.Find<Moyenne>(elv0.id)}");            

            Console.WriteLine("\n------------------TRIGGERS OK-----------------");
            Console.WriteLine("\n--------------------FIELDS--------------------");

            //description of student table
            Dictionary<string, string> fields = Connection.GetTableFields("eleve");
            Console.WriteLine("\nELEVE:");
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
            elv1.Save();
            Console.WriteLine($"\nStudent {elv1.code} saved");

            Console.WriteLine("\nfind output:");

            //check if eleve exists in db
            Eleve elvFound = elv1.Find();
            Eleve elvFoundStatic = Eleve.Find<Eleve>(elv1.id);
            Console.WriteLine("non static " + elvFound?.ToString() ?? "not found");
            Console.WriteLine("static " + elvFoundStatic?.ToString() ?? "not found static");

            //delete student
            elv1.Delete();

            Console.WriteLine("\nfind output after delete:");

            //check existance again
            elvFound = elv1.Find();
            Console.WriteLine(elvFound?.ToString() ?? "not found");

            Console.WriteLine("\n----------------MANIPULATION OK---------------");
            Console.WriteLine("\n-------------------SHOW ALL-------------------");

            //show all students
            elv1.Save();
            elv2.Save();
            elv3.Save();
            elv4.Save();

            //show all students
            Console.WriteLine($"\nAll students:");
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

            Console.WriteLine("\nSelect niveau = 2 and code_fil = ginf:");
            //select and display
            List<dynamic> selection = Eleve.Select<Eleve>(criteria);
            foreach (Eleve eleve in selection)
            {
                Console.WriteLine(eleve.ToString());
            }

            Console.WriteLine("\n------------------SELECT OK-------------------");
            Console.WriteLine("\n--------------------EXPORT--------------------");

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ConvEngine.CreateCSV<Eleve>(Eleve.All<Eleve>().OfType<Eleve>().ToList<Eleve>(), Path.Combine(docPath, "test_mysql.csv"));
            Console.WriteLine("\nWrote CSV at " + Path.Combine(docPath, "test_mysql.csv"));
            ConvEngine.CreateXLS<Eleve>(Eleve.All<Eleve>().OfType<Eleve>().ToList<Eleve>(), Path.Combine(docPath, "test_mysql.xlsx"));
            Console.WriteLine("\nWrote CSV at " + Path.Combine(docPath, "test_mysql.xlsx"));

            Console.WriteLine("\n------------------EXPORT OK-------------------");
            Console.WriteLine("\n-------------------CLEAN UP-------------------");

            elv1.Delete();
            elv2.Delete();
            elv3.Delete();
            elv4.Delete();
            note0.Delete();
            note1.Delete();
            elv0.Delete();
            Console.WriteLine("\nTest students deleted");

            Console.WriteLine("\n-----------------CLEAN UP OK------------------");
            Console.WriteLine("\n------------------TEST DONE-------------------");

            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("---------------------Mssql--------------------");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("\n------------------CONNECTION------------------");
            //create connection
            Console.WriteLine("\nConnection sql string: Data Source=STEALTH-15;Initial Catalog=csharp;Integrated Security=True");
            Connection.Connect("Data Source=STEALTH-15;Initial Catalog=csharp;Integrated Security=True", "MsSql");
            Console.WriteLine("\nConnection sql string: STEALTH-15;Initial Catalog=csharp;Persist Security Info=True;User ID=sa;Password=******");
            Connection.Connect("Data Source=STEALTH-15;Initial Catalog=csharp;Persist Security Info=True;User ID=sa;Password=8576", "MsSql");

            Console.WriteLine("\n-----------------CONNECTION OK----------------");

            elv0 = new() { id = 1649766495, code = "uwuUWU", nom = "test_proc", prenom = "proc_insert", code_fil = "ginf", niveau = 2 };

            Console.WriteLine("\n------------------PROCEDURES------------------");
            Console.WriteLine("\nINSERT:");
            elv0.Delete();
            elv0.Save("insert_eleve");
            Console.WriteLine(elv0.Find());

            Console.WriteLine("\nUPDATE:");
            elv0.prenom = "proc_update";
            elv0.Save("update_eleve");
            Console.WriteLine(elv0.Find());

            Console.WriteLine("\nDELETE:");
            elv0.Delete("delete_eleve");
            Console.WriteLine((elv0.Find())?.ToString() ?? "not found");

            Console.WriteLine("\n-----------------PROCEDURES OK----------------");
            Console.WriteLine("\n-------------------TRIGGERS-------------------");

            elv0.Save();
            note0 = new() { id = 1649766495, code_elv = "uwuUWU", code_mat = "c# prog", note = 12 };
            note1 = new() { id = 1321315533, code_elv = "uwuUWU", code_mat = "intro JEE", note = 10 };

            Console.WriteLine("\nBefore note insert");
            Console.WriteLine(Moyenne.Find<Moyenne>(elv0.id)?.ToString() ?? "moyenne not found");

            Console.WriteLine("\nInsert note1 = 12");
            elv0.nom = "test_trigger";
            elv0.prenom = "test_insert";
            note0.Save();
            Console.WriteLine($"{elv0.Find()} \n {Moyenne.Find<Moyenne>(elv0.id)}");

            Console.WriteLine("\nInsert note2 = 10");
            elv0.nom = "test_trigger";
            elv0.prenom = "test_insert";
            note1.Save();
            Console.WriteLine($"{elv0.Find()} \n {Moyenne.Find<Moyenne>(elv0.id)}");

            Console.WriteLine("\nInsert note2 = 13");
            elv0.nom = "test_trigger";
            elv0.prenom = "test_update";
            note1.note = 13;
            note1.Save();
            Console.WriteLine($"{elv0.Find()} \n {Moyenne.Find<Moyenne>(elv0.id)}");

            Console.WriteLine("\n------------------TRIGGERS OK-----------------");
            Console.WriteLine("\n--------------------FIELDS--------------------");

            //description of student table
            fields = Connection.GetTableFields("eleve");
            Console.WriteLine("\nELEVE:");
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
            elv1.Save();
            Console.WriteLine($"\nStudent {elv1.code} saved");

            Console.WriteLine("\nfind output:");

            //check if eleve exists in db
            elvFound = elv1.Find();
            elvFoundStatic = Eleve.Find<Eleve>(elv1.id);
            Console.WriteLine("non static " + elvFound?.ToString() ?? "not found");
            Console.WriteLine("static " + elvFoundStatic?.ToString() ?? "not found static");

            //delete student
            elv1.Delete();

            Console.WriteLine("\nfind output after delete:");

            //check existance again
            elvFound = elv1.Find();
            Console.WriteLine(elvFound?.ToString() ?? "not found");

            Console.WriteLine("\n----------------MANIPULATION OK---------------");
            Console.WriteLine("\n-------------------SHOW ALL-------------------");

            //show all students
            elv1.Save();
            elv2.Save();
            elv3.Save();
            elv4.Save();

            //show all students
            Console.WriteLine($"\nAll students:");
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

            Console.WriteLine("\nSelect niveau = 2 and code_fil = ginf:");
            //select and display
            selection = Eleve.Select<Eleve>(criteria);
            foreach (Eleve eleve in selection)
            {
                Console.WriteLine(eleve.ToString());
            }

            Console.WriteLine("\n------------------SELECT OK-------------------");
            Console.WriteLine("\n--------------------EXPORT--------------------");

            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ConvEngine.CreateCSV<Eleve>(Eleve.All<Eleve>().OfType<Eleve>().ToList<Eleve>(), Path.Combine(docPath, "test_mssql.csv"));
            Console.WriteLine("\nWrote CSV at " + Path.Combine(docPath, "test_mssql.csv"));
            ConvEngine.CreateXLS<Eleve>(Eleve.All<Eleve>().OfType<Eleve>().ToList<Eleve>(), Path.Combine(docPath, "test_mssql.xlsx"));
            Console.WriteLine("\nWrote CSV at " + Path.Combine(docPath, "test_mssql.xlsx"));

            Console.WriteLine("\n------------------EXPORT OK-------------------");
            Console.WriteLine("\n-------------------CLEAN UP-------------------");

            elv1.Delete();
            elv2.Delete();
            elv3.Delete();
            elv4.Delete();
            note0.Delete();
            note1.Delete();
            elv0.Delete();
            Console.WriteLine("\nTest students deleted");

            Console.WriteLine("\n-----------------CLEAN UP OK------------------");
            Console.WriteLine("\n------------------TEST DONE-------------------");

            Console.WriteLine("\n\n-----------------ALL SUCCESS------------------");
        }
    }
}
