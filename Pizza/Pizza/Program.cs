using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        public static  void Main (string[] args)
        {
            Console.WriteLine("ingrese tamaño de pizza");
            var tamaño = Console.ReadLine();
            Console.WriteLine("ingrese tipo de pizza");
            var tipo = Console.ReadLine();
            if (tipo == "carnivora")
            {
                if (tamaño == "pequeña")
                {
                    string pizza = PedirCarnivora(tamaño);
                    Console.WriteLine(pizza);
                }
            }
            Console.Read();
        }


        static string PedirCarnivora(string tamaño)
        {
            if (tamaño == "pequeña")
            {
                var pequeña = new Carnivora() { CantidadCarne = "poca", salchicha = false, Tamaño = tamaño, Tipo = "carnivora", Porciones = 4 };
                return "porciones: " + pequeña.Porciones + " tamaño: " + pequeña.Tamaño + " Tipo: " + pequeña.Tipo + " Con salchicha: " + pequeña.salchicha + " Cantidad de Carne: " + pequeña.CantidadCarne;
            }
            else
            {
                if (tamaño == "mediana")
                {
                    var mediana = new Carnivora() { CantidadCarne = "medio", salchicha = true, Tamaño = tamaño, Tipo = "carnivora", Porciones = 6 };
                    return "porciones: " + mediana.Porciones + " tamaño: " + mediana.Tamaño + " Tipo: " + mediana.Tipo + " Con salchicha: " + mediana.salchicha + " Cantidad de Carne: " + mediana.CantidadCarne;
                }
                else
                {
                    if (tamaño == "grande")
                    {
                        var grande = new Carnivora() { CantidadCarne = "bastante", salchicha = true, Tamaño = tamaño, Tipo = "carnivora", Porciones = 8 };
                        return "porciones: " + grande.Porciones + " tamaño: " + grande.Tamaño + " Tipo: " + grande.Tipo + " Con salchicha: " + grande.salchicha + " Cantidad de Carne: " + grande.CantidadCarne;
                    }
                    else
                    {
                        return "no hay ese tipo de pizza";
                    }
                }
            }
        }
    }
}
