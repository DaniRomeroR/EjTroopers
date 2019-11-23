using EjTroopers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjTroopers.Services
{
    class SearchService
    {
        public static List<Trooper> searchTroopers(List<Trooper> ListTrooper,string name)
        {
            var resul = ListTrooper.Where(x => x.first_name == name);
            ListTrooper.Clear();
            ListTrooper = resul.ToList();
            return ListTrooper;
        }
    }
}
