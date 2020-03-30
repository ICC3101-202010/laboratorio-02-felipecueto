using System;
using System.Collections.Generic;
namespace Laboratorio2
{
  
    class MainClass
    {
        public static void Main(string[] args)
        {
            Espotifai espotifai = new Espotifai();
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Hola Bienvenido Espotifai");
                Console.WriteLine("Seleccione una opción por favor\n");
                Console.WriteLine("(1)-Ver canciones Agregadas");
                Console.WriteLine("(2)-Agregar nueva cancion");
                Console.WriteLine("(3)-Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        espotifai.VerCanciones();
                        Console.WriteLine("\n Presione cualquier tecla para continuar...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("Nombre de la cancion");
                        String name = Console.ReadLine();

                        Console.WriteLine("Album de la cancion");
                        String album = Console.ReadLine();

                        Console.WriteLine("Artista de la cancion");
                        String artist = Console.ReadLine();

                        Console.WriteLine("Genero de la cancion");
                        String gender = Console.ReadLine();

                        Cancion Newsong = new Cancion(name, album, artist, gender);

                        if (espotifai.AgregarCancion(Newsong))
                        {
                            Console.WriteLine("Cancion agregada con exito");
                        }
                        else
                        {
                            Console.WriteLine("Esta Cancion ya fue agregada anteriorimente");
                        }

                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();

                        break;
                   
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Cerrando Programa");
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Porfavor elige una opción valida...");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;


                }
            }

        }
    }
}
            

