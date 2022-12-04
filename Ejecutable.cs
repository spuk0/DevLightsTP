using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion
{
    internal class Ejecutable
    {
        public static void Main(string[] args)
        {
            int opcion = 0;

            //menu
            while (opcion != 16)
            {
                int numero = 0;
                Console.WriteLine("*************************************************************************************************\n" +                   
                    "[1]>Dado un valor, devolver un mensaje 'El valor es mayor que' sólo cuando se cumpla dicha condicion.\n" +
                    "[2]>Pedir un número entero por teclado y calcular si es par o impar.\n" +
                    "[3]>Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar.\n" +
                    "[4]>Dada un número del 1 al 10, devolver su “versión” en números romanos.\n" +
                    "[5]>Leer el nombre y las edades de dos personas y devolver el nombre del menor.\n" +
                    "    En caso de que tengan la misma edad también debe indicarse. Devolver también la diferencia de edad\n" +
                    "    en caso de corresponder.\n" +
                    "[6]>Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados.\n" +
                    "    También que calcule su perímetro y su área.\n" +
                    "[7]>Desglosar cantidad de billetes dada considerando las denominaciones 1000, 500, 100, 50, 20, 10, 5, 2 y 1\n" +
                    "[8]>Pide un numero N, y muestra todos los numeros del 1 al N\n" +
                    "[9]>Pedir 15 numeros y escribir la suma total.\n" +
                    "[10]>Pide 5 números e indica si alguno es múltiplo de 3.\n" +
                    "[11]>Escriba un programa que solicite una contraseña y la vuelva a solicitar hasta que\n" +
                    "     las dos contraseñas coincidan.\n" +
                    "[12]>Mismo que el 11 pero con un límite de tres peticiones. \n" +
                    "     Luego de las tres peticiones no debe solicitar más la contraseña y terminar el programa.\n" +
                    "[13]>Proponer al usuario que adivine un número a base de intentarlo.\n" +
                    "[14]>Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o «menor».\n" +
                    "[15]>Crea un programa que permita sumar N números. \n" +
                    "     El usuario decide cuándo termina de introducir números al indicar la palabra ‘fin’.\n" +
                    "[16]>Salir\n*************************************************************************************************" +
                    "\nSeleccione el numero del ejercicio: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        ejercicio1(numero);
                        limpiarYMenu();
                        break;
                    case 2:
                        ejercicio2(numero);
                        limpiarYMenu();
                        break;
                    case 3:
                        ejercicio3(numero);
                        limpiarYMenu();
                        break;
                    case 4:
                        ejercicio4(numero);
                        limpiarYMenu();
                        break;
                    case 5:
                        ejercicio5();
                        limpiarYMenu();
                        break;
                    case 6:
                        ejercicio6();
                        limpiarYMenu();
                        break;
                    case 7:
                        ejercicio7();
                        limpiarYMenu();
                        break;
                    case 8:
                        Console.WriteLine("Ingresar numero N");
                        numero = int.Parse(Console.ReadLine());
                        Console.WriteLine (ejercicio8(numero));
                        limpiarYMenu();
                        break;
                    case 9:
                        Console.WriteLine ($"La suma de los 15 numeros es {ejercicio9()}");
                        limpiarYMenu();
                        break;
                    case 10:
                        ejercicio10();
                        limpiarYMenu();
                        break;
                    case 11:
                        ejercicio11();
                        limpiarYMenu();
                        break;
                    case 12:
                        ejercicio12();
                        limpiarYMenu();
                        break;
                    case 13:
                        ejercicio13();
                        limpiarYMenu();
                        break;
                    case 14:
                        ejercicio14();
                        limpiarYMenu();
                        break;
                    case 15:
                        ejercicio15();
                        limpiarYMenu();
                        break;

                }
            }

            //LimpiarYMenu
            static void limpiarYMenu()
            {
                Console.WriteLine("Presione UNA tecla para volver al menu");
                Console.ReadKey();
                Console.Clear();
            }

            //Ejercicio 1
            static void ejercicio1(int p_numero)
            {
                Console.WriteLine("Ingresar valor que sera comparado con 100: ");
                p_numero = int.Parse(Console.ReadLine());
                if (p_numero > 100)
                {
                    Console.WriteLine($"{p_numero} es mayor que 100");
                }
                else
                {
                    Console.WriteLine($"{p_numero} es menor que 100");
                }
            }

            //Ejercicio 2
            static void ejercicio2(int p_numero)
            {
                Console.WriteLine("Ingresar numero entero para ver si es par o impar");
                p_numero = int.Parse(Console.ReadLine());
                if ((p_numero % 2) == 0)
                {
                    Console.WriteLine("Par");
                }
                else
                {
                    Console.WriteLine("Impar");
                }
            }

            //Ejercicio 3
            static void ejercicio3(int p_numero)
            {
                Console.WriteLine("Ingresar valor entero");
                p_numero = int.Parse(Console.ReadLine());
                int mitad = p_numero / 2;
                if ((p_numero % 2) == 0 && (mitad % 2) > 0)
                {
                    Console.WriteLine("Cumple con la condicion");
                }
                else
                {
                    Console.WriteLine("No cumple la condicion");
                }
            }

            //Ejercicio 4
            static void ejercicio4(int p_numero)
            {
                Console.WriteLine("Ingresar valor entero para pasarlo a romano");
                p_numero = int.Parse(Console.ReadLine());
                switch (p_numero)
                {
                    case 0:
                        Console.WriteLine("No hay cero");
                        break;
                    case 1:
                        Console.WriteLine($"{p_numero} en romano es I");
                        break;
                    case 2:
                        Console.WriteLine($"{p_numero} en romano es II");
                        break;
                    case 3:
                        Console.WriteLine($"{p_numero} en romano es III");
                        break;
                    case 4:
                        Console.WriteLine($"{p_numero} en romano es IV");
                        break;
                    case 5:
                        Console.WriteLine($"{p_numero} en romano es V");
                        break;
                    case 6:
                        Console.WriteLine($"{p_numero} en romano es VI");
                        break;
                    case 7:
                        Console.WriteLine($"{p_numero} en romano es VII");
                        break;
                    case 8:
                        Console.WriteLine($"{p_numero} en romano es VIII");
                        break;
                    case 9:
                        Console.WriteLine($"{p_numero} en romano es IX");
                        break;
                    case 10:
                        Console.WriteLine($"{p_numero} en romano es X");
                        break;
                }
            }

            //Ejercicio5
            static void ejercicio5()
            {
                Console.WriteLine("\n\nNombre de primer persona: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Edad de primer persona: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\nNombre de segunda persona: ");
                string nombre2 = Console.ReadLine();
                Console.WriteLine("Edad de segunda persona: ");
                int edad2 = int.Parse(Console.ReadLine());

                if (edad > edad2 && edad != edad2)
                {
                    Console.WriteLine($"{nombre2} es el menor. Diferencia de edad: {edad - edad2}");
                }
                if (edad < edad2 && edad != edad2)
                {
                    Console.WriteLine($"{nombre} es el menor. Diferencia de edad: {edad2 - edad}");
                }
                if (edad2 == edad)
                {
                    Console.WriteLine("Tienen la misma edad");
                }
            }

            //Ejercicio 6
            static void ejercicio6()
            {
                Console.WriteLine("Ingrese la base del triangulo: ");
                int basee = int.Parse(Console.ReadLine());
                Console.WriteLine("\nLado 2: ");
                int lado2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nLado 3: ");
                int lado3 = int.Parse(Console.ReadLine());

                int hipotenusa = (int)Math.Sqrt(Math.Pow(lado3, 2) + Math.Pow(lado2, 2));
                int area = (basee * hipotenusa) / 2;
                int perimetro = basee + lado2 + lado3;

                if (basee == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Es un triangulo equilatero");

                }
                if (basee == lado2 || basee == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Es un triangulo isoceles");
                }
                if (basee != lado2 && basee != lado3 && lado2 != lado3)
                {
                    Console.WriteLine("Es un triangulo escaleno");
                }

                Console.WriteLine($"El perimetro es {perimetro}\nEl area es {area}\nLa hipotenusa es {hipotenusa}");
            }

            //Ejercicio 7
            static void ejercicio7()
            {
                Console.WriteLine("Ingrese cantidad a desglosar: ");
                int dinero = int.Parse(Console.ReadLine());
                int billete1000 = 0, billete500 = 0, billete100 = 0, billete50 = 0, billete20 = 0, billete10 = 0, billete5 = 0, billete2 = 0, billete1 = 0;

                while (dinero != 0)
                {
                    billete1000 = (dinero - (dinero % 1000)) / 1000;
                    dinero = dinero % 1000;
                    billete500 = (dinero - (dinero % 500)) / 500;
                    dinero = dinero % 500;
                    billete100 = (dinero - (dinero % 100)) / 100;
                    dinero = dinero % 100;
                    billete50 = (dinero - (dinero % 50)) / 50;
                    dinero = dinero % 50;
                    billete20 = (dinero - (dinero % 20)) / 20;
                    dinero = dinero % 20;
                    billete10 = (dinero - (dinero % 10)) / 10;
                    dinero = dinero % 10;
                    billete5 = (dinero - (dinero % 5)) / 5;
                    dinero = dinero % 5;
                    billete1 = (dinero - (dinero % 1)) / 1;
                    dinero = dinero % 1;
                }

                Console.WriteLine($"{billete1000} billetes de 1000\n{billete500} billetes de 500\n{billete100} billetes de 100" +
                    $"\n{billete50} billetes de 50\n{billete20} billetes de 20\n{billete10} billetes de 10\n{billete5} billetes de 5" +
                    $"\n{billete1} billetes de 1");
            }

            //Ejercicio 8
            static string ejercicio8(int p_numero) {
                string cadena = "";
                for (int i = 0;i<p_numero; i++)
                {
                    cadena += (i + 1) + " ";
                }
                return cadena;
            }

            //Ejercicio 9
            static int ejercicio9()
            {
                int num = 0, suma = 0;
                for(int i = 0; i < 15; i++)
                {
                    Console.WriteLine($"Ingresar numero {i+1}");
                    num = int.Parse(Console.ReadLine());
                    suma += num;
                }
                return suma;
            }

            //Ejercicio 10
            static void ejercicio10()
            {
                int num = 0;
                string multiplos = "";
                for(int i=0; i<5 ; i++)
                {
                    Console.WriteLine($"Ingresar numero {i + 1}");
                    num = int.Parse(Console.ReadLine());
                    if (esMultiploDeTres(num))
                    {
                        multiplos += $" - {num} - ";
                    }
                }
                Console.WriteLine($"Multiplos de 3:\n{multiplos}");
            }

            static bool esMultiploDeTres(int p_numero)
            {
                if(p_numero % 3 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Ejercicio11
            static void ejercicio11()
            {
                string password = "inosuke";
                string passwordAIngresar = "";
                Console.WriteLine("Ingresar contraseña: ");
                passwordAIngresar = Console.ReadLine();

                while (passwordAIngresar != password)
                {
                    Console.WriteLine("¡Incorrecto!. \nIngresar contraseña: ");
                    passwordAIngresar = Console.ReadLine();
                }
                Console.WriteLine("\nBienvenido señor Stark");
            }

            //Ejercicio 12
            static void ejercicio12()
            {
                int limites = 0;
                string password = "inosuke";
                string passwordAIngresar = "";
                Console.WriteLine("Ingresar contraseña: ");
                passwordAIngresar = Console.ReadLine();

                while (passwordAIngresar != password)
                {
                    if (limites < 2)
                    {
                        Console.WriteLine($"¡Incorrecto! {limites+1}/3. \nIngresar contraseña: ");
                        passwordAIngresar = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Superaste el limite de intentos");
                        break;
                    }
                    
                    limites++;
                }
                Console.WriteLine("\nBienvenido señor Stark");

            }

            //Ejercicio 13
            static void ejercicio13()
            {
                const int adivinanza = 3;
                Console.WriteLine("¡Adivine el numero que esta guardado en la memoria!. Escribir:");
                int adivinar = int.Parse(Console.ReadLine());

                while (adivinanza != adivinar)
                {
                    Console.WriteLine("Ese no es el numero XD intenta de nuevo: ");
                    adivinar = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"¡Bien ahi! la respuesta era {adivinanza}, le pegaste!");
            }

            //Ejercicio 14
            static void ejercicio14()
            {
                const int adivinanza = 3;            
                Console.WriteLine("¡Adivine el numero que esta guardado en la memoria!. Escribir:");
                int adivinar = int.Parse(Console.ReadLine());

                while (adivinanza != adivinar)
                {
                    if(adivinar < adivinanza)
                    {
                        Console.WriteLine($"Ese no es el numero XD, proba con uno mayor: ");
                        adivinar = int.Parse(Console.ReadLine());
                    }else
                    {
                        Console.WriteLine($"Ese no es el numero XD, proba con uno menor: ");
                        adivinar = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine($"¡Bien ahi! la respuesta era {adivinanza}, le pegaste!");
            }

            //Ejercicio15
            static void ejercicio15()
            {
                string condicion = "";
                int suma = 0;
                Console.WriteLine("Ingrese un numero para empezar a sumar");
                suma = int.Parse(Console.ReadLine());

                while(condicion != "fin" && condicion != "Fin" && condicion != "FIN")
                {
                    Console.WriteLine("Ingresa el siguiente numero a sumar: ");
                    suma += int.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es {suma}, quiere seguir sumando?\nEscribir 'si' para continuar o 'fin' para terminar:");
                    condicion = Console.ReadLine();
                }
                Console.WriteLine($"El resultado final de todas las sumas fue {suma}, de nada c;");
            }
        }
    }
}
