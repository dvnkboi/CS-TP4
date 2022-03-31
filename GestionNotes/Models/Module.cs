using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes.Models
{
    public class Module : ModelApp.Model
    {
        public string code { get; set; }
        public string designation { get; set; }
        public int niveau { get; set; }
        public string semestre { get; set; }
        public string code_fil { get; set; }


        public override string ToString()
        {
            return $"Module: \n {code} - {designation} - {niveau} - {semestre} - {code_fil}";
        }
    }
}
