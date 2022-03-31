using System;
using System.Collections.Generic;
using System.Text;
using ModelApp;

namespace ConsoleModel
{
    class Eleve: Model
    {

        public string code { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int niveau { get; set; }
        public string code_fil { get; set; }


        public override string ToString()
        {
            return $"Eleve: \n {code} - {nom} - {prenom} - {niveau} - {code_fil}";
        }
    }
}
