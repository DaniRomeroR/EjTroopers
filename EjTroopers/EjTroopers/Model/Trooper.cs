using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjTroopers.Model
{
    public class Trooper
    {
        public int id { get; set; }
        public string first_name { get; set; }

        public override string ToString()
        {
            return "ID: "+id+" NOMBRE: "+first_name;
        }
    }
}
