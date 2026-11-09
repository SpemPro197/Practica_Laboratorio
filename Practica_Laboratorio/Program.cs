using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom.Compiler;

namespace Practica_Laboratorio
{
    internal class Program
    {
        static string Ruta_archivo = "registros";
        
        static string[] codigos = { "OC-101" , "OC-102" , "OC-103" , "OC-104", "OC-105" , "OC-106" };
        static int max_lotes = codigos.Length;
        static float[] precios_lotes;
        static string[] codigos_ocupados;
        static string[] proveedores = { "TechCorp I", "LogiExpress", "InsumosGlobal", "TechCorp II", "AlfaSuministros", "ServiReds" };
        static float[] columnas;
        static float[] filas;
        static float[] matriz_financiera;
        static int temp;

        static public void Ingresar_Pedido()
        {
            max_lotes++;
            Console.WriteLine("Porfavor asegurese de ingresar los datos con los codigos validos correspondientes.");
            Console.WriteLine("Codigos validos: " );
            for(int i = 0; i < codigos.Length; i++)
            {
                Console.WriteLine(codigos[i]);
            }

            Console.WriteLine("Ingrese el codigo: ");
            string lote_elegido = Console.ReadLine();

            for(int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == lote_elegido)
                {
                    i = temp;
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un codigo valido.");
                    return;
                }
            }

            Console.WriteLine("Por favor ingrese el monto que va a pagar: ");
            float precio_lote = float.Parse(Console.ReadLine());
            if(precio_lote > 0)
            {
                precios_lotes[temp] = precio_lote;
            }
            else
            {
                Console.WriteLine("Por favor ingrese un precio valido, mayor a 0 y que sea un numero valido.");
                return;
    
            }

                Console.WriteLine("Por favor ingrese la cantidad de lotes que desea comprar: ");
            int cantidad_lote = int.Parse(Console.ReadLine());
            
            if(cantidad_lote <= 0)
            {
                Console.WriteLine("Porfavor, ingrese una cantidad valida, mayor a 0.");
                return;
            }

                Random numero_aleatorio = new Random();

            Console.WriteLine("¡Datos registrados exitosamente!!! Numero de pedido: " + numero_aleatorio.Next(0 - 100));
            
        }

        static public void Mostrar_Lotes()
        {
            Console.WriteLine("============================================");
            for (int i = 0; i < codigos.Length; i++)
            {
                Console.WriteLine("\t CODIGO \t CANTIDAD \t PRECIO");
                Console.WriteLine($"Codigo: {codigos[i]}\t Prov: {proveedores[i]}\t Monto: {precios_lotes[i]}");
            }
            Console.WriteLine("============================================");
        }

        static public void Buscar_lote()
        {
            Console.WriteLine("Por favor ingrese el codigo del lote: ");
            string busqueda = Console.ReadLine();
                for (int i = 0; i < codigos.Length; i++)
                {
                    if (busqueda == codigos[i])
                    {
                        Console.WriteLine("Encontrado!!!");
                        Console.WriteLine($"Codigo: {codigos[i]}\t Prov: {proveedores[i]}");
                    }
                }
        }


        static void Main(string[] args)
        {
            int opc = 0;
            while (opc != 4)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Bienvenido al sistema de Entrega y Pedido de Lotes de LotesYMas!!");
                Console.WriteLine("Por favor, ingrese una de las siguientes opciones para poder continuar.");
                Console.WriteLine("1. [ Ingresar pedido. ]");
                Console.WriteLine("2. [ Mostrar todos los lotes disponibles. ]");
                Console.WriteLine("3. [ Buscar lote. ]");
                Console.WriteLine("4. [ Salir ]");
                Console.WriteLine("");
                Console.WriteLine("Ingrese la opcion elegida: ");
                opc = int.Parse(Console.ReadLine());

                Console.WriteLine("========================================================================");

                switch (opc)
                {
                    case 1:
                        Ingresar_Pedido();
                        break;
                    case 2:
                        Mostrar_Lotes();
                        break;
                    case 3:
                        Buscar_lote();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar nuestro sistema para hacer pedidos!!!!, hasta pronto!!");
                        Console.WriteLine("Cerrando....");
                        break;
                }
            }

        } 
    }
}
