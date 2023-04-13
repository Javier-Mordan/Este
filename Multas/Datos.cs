using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Multas
{
    class Datos<T>
    {
        public T valor;
        public Datos(T _valor)
        {
            valor = _valor;
        }


        List<string> datos = new List<string>();

        public Conductor Conductor { get; set; }
        public Agente Agente { get; set; }


        public List<string> Guardar()
        {
            string este = JsonConvert.SerializeObject(valor);
            datos.Add( este);
            Console.WriteLine(datos);
            return datos;
        }

        
    }
}
