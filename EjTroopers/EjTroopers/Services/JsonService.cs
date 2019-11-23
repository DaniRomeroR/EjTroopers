using System;
using System.Resources;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EjTroopers.Model;

namespace EjTroopers.Services
{
    class JsonService
    {
        public static List<Trooper>  lectura() {
            String archivo = File.ReadAllText("TrooperList.json");
            List<Trooper> tropa = JsonConvert.DeserializeObject<List<Trooper>>(archivo);
            return tropa;
        }
    }
}
