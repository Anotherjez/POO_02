using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicapoo02
{
    class Apartamento
    {
        public string Direccion { get; set; }
        public string Color { get; set; }
        public double Area { get; set; }
        public int Parqueos { get; set; }
        public int Habitaciones { get; set; }
        public int Bath { get; set; }
        public double Precio { get; set; }
        public string Estado { get; set; }

        public void Vender()
        {
            Console.WriteLine("Vender Apartamento\nAqui pondra a la venta su apartamento ingresando los datos del mismo \n");
            Datos();
            Estado = "En venta";
        }
        public void Alquiler()
        {
            Console.WriteLine("Poner en alquiler Apartamento\nAqui pondra en alquiler su apartamento ingresando los datos del mismo \n");
            Datos();
            Estado = "En alquiler";
        }
        private void Datos() 
        {
            bool error = false;
            do
            {                
                try
                {
                    Console.Write("Ingrese la direccion del apartamento: ");
                    Direccion = Console.ReadLine();
                    Console.Write("Color: ");
                    Color = Console.ReadLine();
                    Console.Write("Area de construccion: ");
                    Area = double.Parse(Console.ReadLine());
                    Console.Write("Cantidad de plazas de parqueo: ");
                    Parqueos = int.Parse(Console.ReadLine());
                    Console.Write("Cantidad de habitaciones: ");
                    Habitaciones = int.Parse(Console.ReadLine());
                    Console.Write("Cantidad de baños: ");
                    Bath = int.Parse(Console.ReadLine());
                    Console.Write("Precio RD$ ");
                    Precio = double.Parse(Console.ReadLine());
                    error = false;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un valor valido...");
                    Console.ReadKey();
                    Console.Clear();
                    error = true; //Para evitar el uso de goto
                } 
            } while (error == true);
        }
    }
}
