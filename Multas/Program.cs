using System;

namespace Multas
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Agente agente = new Agente();

            Console.WriteLine("Introduzca los datos del agente:");
            Console.WriteLine("Codigo: ");
            agente.Codigo = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            agente.Nombre = Console.ReadLine();
            Console.WriteLine("Direccion: ");
            agente.Direccion = Console.ReadLine();
            Console.WriteLine("Fecha de Ingreso: ");
            agente.Ingreso = Console.ReadLine();

            Console.WriteLine("\n Ahora introduzca los datos del cponductor: ");

            Conductor conductor = new Conductor();
            
            Console.WriteLine("Codigo: ");
            conductor.Cedula = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            conductor.Nombre = Console.ReadLine();
            Console.WriteLine("Direccion: ");
            conductor.Direccion = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento: ");
            conductor.Nacimiento = Console.ReadLine();
            Console.WriteLine("Tiopo de licencia: ");
            conductor.Licencia = Console.ReadLine();

            Console.WriteLine("Continue con los datos del vehiculo.");

            Vehiculo vehiculo = new Vehiculo();

            Console.WriteLine("Numero de placa: ");
            vehiculo.Placa = Console.ReadLine();
            Console.WriteLine("Marca del vehiculo: ");
            vehiculo.Marca = Console.ReadLine();
            Console.WriteLine("Modelo del vehiculo: ");
            vehiculo.Modelo = Console.ReadLine();
            Console.WriteLine("NumeRO DE CHASIS: ");
            vehiculo.Chasis = Console.ReadLine();
            Console.WriteLine("Ano del vehiculo: ");
            vehiculo.Ano = Console.ReadLine();
            Console.WriteLine("Ciolor del vehiculo: ");
            vehiculo.Color = Console.ReadLine();

            conductor.vehiculo = vehiculo;

            Console.WriteLine("Ingrese el tipo de multa.");
            Console.WriteLine("Tipo 1 - Obstruccion de transito. \nTipo 2 - Pase de semaforo en rojo. \nTipo 3 - Hablar en el celular. \n Tipo 4 - Conducir si cinturon. \nTipo 5 - Licencia vencida.");

            string tipo = Console.ReadLine();

            conductor.Tipo(tipo);

            Datos<Conductor> GuardarConductor = new Datos<Conductor>(conductor);
            Datos<Agente> GuardarAgente = new Datos<Agente>(agente);
            GuardarAgente.Guardar();
            GuardarConductor.Guardar();

            Console.WriteLine($"Sus datos se guardaron");

        }
    }
}
