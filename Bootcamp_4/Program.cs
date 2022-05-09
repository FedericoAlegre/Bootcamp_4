using System;

namespace Bootcamp_4
{
    class Program
    {
        Persona[] arrP = new Persona[3];
        static void Ejercicio2(Program p)
        {
            //Program P = new Program();
            LlenarArreglo(p.arrP, 0);
            Console.WriteLine(p.arrP[0].ToString());
            Console.WriteLine($"¿es mayor de edad? {p.arrP[0].EsMayorDeEdad()}");          
            
        }

        static void Ejercicio1(Program p)
        {
            //Program arrP = new Program();
            LlenarArreglo(p.arrP, 0);
            MostrarArreglo(p.arrP, 0);
        }

        static void MostrarArreglo(Persona[] p, int i)
        {
            Console.WriteLine($"Persona {i+1}: {p[i].ToString()}");
            i++;
            if (i < 3) MostrarArreglo(p, i);

        }

        static void LlenarArreglo(Persona[] p, int i)
        {
            Persona aux = new Persona();
            Console.Write($"Ingrese el nombre de la persona {i+1}: ");
            aux.Nombre = Console.ReadLine();
            aux.Dni = TryAndCatchInt($"Ingrese el DNI de la persona {i+1}");
            aux.Edad = TryAndCatchInt($"Ingrese la Edad de la persona {i + 1}");
            p[i] = aux;
            i++;
            if (i < 3) LlenarArreglo(p, i);
            
        }

        static int TryAndCatchInt(string msg)
        {
            bool f = false;
            int option = 0;
            do
            {
                Console.WriteLine(msg);
                string s = Console.ReadLine();
                try
                {
                    option = int.Parse(s);
                    f = true;

                }
                catch (Exception)
                {

                    Console.WriteLine("Ingreso un dato invalido!!");
                }
            } while (f != true);
            return option;          

        }

        static void Menu(int o, Program p)
        {
            if (o > 0)
            {
                switch (o)
                {
                    case 1:
                        {
                            Ejercicio1(p);
                            break;
                        }
                    case 2:
                        {
                            Ejercicio2(p);
                            break;
                        }
                    case 3:
                        {
                            Console.Beep();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("NUMERO INVALIDO");
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
                Menu(TryAndCatchInt("Menu:\n0: Apagar\n1: Ejercicio 1\n2: Ejercicio 2\n3: Honk! "), p);
            }

        }
        
        static void Main(string[] args)
        {
            Program person = new Program();
            Console.WriteLine("Challenge 4");
            Menu(TryAndCatchInt("Menu:\n0: Apagar"), person);            
        }

    }
}
