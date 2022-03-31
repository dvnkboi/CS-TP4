using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes.Models
{
    public class Moyenne : ModelApp.Model
    {
        public int niveau { get; set; }
        public string code_elv { get; set; }
        public string code_fil { get; set; }
        public double moyenne { get; set; }


        public override string ToString()
        {
            return $"Moyenne: \n {niveau} - {code_elv} - {code_fil} - {moyenne}";
        }
    }
}
