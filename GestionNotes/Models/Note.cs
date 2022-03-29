using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes.Models
{
    public class Note : ModelApp.Model
    {
        public string code_elv { get; set; }
        public string code_mat { get; set; }
        public double note { get; set; }


        public override string ToString()
        {
            return $"Note: \n {code_elv} - {code_mat} - {note}";
        }
    }
}
