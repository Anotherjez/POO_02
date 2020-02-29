using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicapoo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Apartamento> apartamentos = new List<Apartamento>();
            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Venta/Alquiler de Apartamentos\n\n[1] Poner en venta tu Apartamento\n[2] Poner en alquiler tu Apartamento\n[3] Ver Apartamentos en Venta/Alquiler\n[4] Salir");
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese una opcion valida...!");
                    Console.ReadKey();
                }
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Apartamento vender = new Apartamento();
                        vender.Vender();
                        apartamentos.Add(vender);                        
                        break;
                    case 2:
                        Apartamento alquiler = new Apartamento();
                        alquiler.Alquiler();
                        apartamentos.Add(alquiler);
                        break;
                    case 3:
                        foreach(Apartamento ap in apartamentos)
                        {
                            Console.WriteLine($"Apartamento\n\nEstado: {ap.Estado} \nDireccion: {ap.Direccion} \nColor: {ap.Color} \nArea de construccion: {ap.Area} m2" +
                                $"\nCantidad de plazas de parqueo: {ap.Parqueos} \nCantidad de habitaciones: {ap.Habitaciones} \nCantidad de baños: {ap.Bath} \nPrecio RD$ {ap.Precio} \n");                            
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (op != 4);
        }
    }
}
