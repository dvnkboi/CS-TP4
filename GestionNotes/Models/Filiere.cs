using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes.Models
{
    public class Filiere : ModelApp.Model
    {
        public string code { get; set; }
        public string designation { get; set; }


        public override string ToString()
        {
            return $"Filiere: \n {code} - {designation}";
        }
    }
}
