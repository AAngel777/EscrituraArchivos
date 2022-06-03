using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            // si el archivo no existe lo creara
            // si el archivo existe, escribira en el
            string[] lines =
            {
                "Esto es la primer linea",
                "Esto es la segunda linea",
                "Esto es la tercer linea"
            };
            // recorrer el arreglo para escriir las lineas en el archiv
            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close();

            Console.WriteLine("Escribiendo....");
            Console.ReadLine();
        } // cerrar el archivo

    }
}
}
