using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_POO_Unidad_6
{
    class Program
    {

         class Inventario
        {

            string nombre, descripcion;
            float precio;
            int cantidadS;

            public void CrearRegistro()
            {
                StreamWriter sw = new StreamWriter("Productos.txt", true);

                Console.Write("Ingrese el nombre del Producto: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese la descripcion del Producto: ");
                descripcion = Console.ReadLine();
                Console.Write("Ingrese el precio del producto: ");
                precio = Single.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad en stock del producto: ");
                cantidadS = Int32.Parse(Console.ReadLine());

                // Escribe los datos del archivo          
                sw.Write(nombre + "\r\n");
                sw.Write(descripcion + "\r\n\n");
                sw.Write(precio + "\r\n");
                sw.Write(cantidadS + "\r\n");

                Console.WriteLine("Escribiendo en el archivo...");
                sw.Close();
                Console.Write("Presione enter para volver al menu principal...");
                Console.ReadKey();
            }

            public void LeerRegistro()
            {
                StreamReader sr = new StreamReader("Productos.txt");//busca en el archivo .txt       
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
                Console.Write("Presione enter para volver al menu principal...");
                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                int opcion;

                // creacion del objeto
                Inventario I1 = new Inventario();
                do
                {
                    // Menu de Opciones
                    Console.Clear();
                    Console.WriteLine("\n MENU DE OPCIONES");
                    Console.WriteLine("1.- Ingresar un nuevo producto.");
                    Console.WriteLine("2.- Leer un productos.");
                    Console.WriteLine("3.- Salida del programa.");
                    Console.Write("\nQue opcion deseas: ");
                    opcion = Int16.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:

                            I1.CrearRegistro();

                            break;

                        case 2:
                            // Bloque de lectura
                            I1.LeerRegistro();

                            break;
                        case 3:
                            Console.Write("\nPresione <enter> para salir del programa.");
                            Console.ReadKey();
                            break;

                        default:
                            Console.Write("\nEsa opcion no existe!!, Presione <enter> para continuar...");
                            Console.ReadKey();
                            break;

                    }
                } while (opcion != 3);
            }
        }
        

    }
}
