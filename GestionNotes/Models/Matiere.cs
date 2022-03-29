using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes.Models
{
    public class Matiere : ModelApp.Model
    {
        public string code { get; set; }
        public string designation { get; set; }
        public string vh { get; set; }
        public string code_mod { get; set; }


        public override string ToString()
        {
            return $"Matiere: \n {code} - {designation} - {vh} - {code_mod}";
        }
    }
}
