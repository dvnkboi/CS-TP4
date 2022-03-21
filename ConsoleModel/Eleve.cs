using System;
using System.Collections.Generic;
using System.Text;
using ModelApp;

namespace ConsoleModel
{
    class Eleve: Model
    {
        public string code, nom, prenom, niveau, code_fil;

        public override string ToString()
        {
            return $"Eleve: \n {code} - {nom} - {prenom} - {niveau} - {code_fil}";
        }
    }
}
