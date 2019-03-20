using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial
{
    class LibreriaClases
    {
        public int num, nument1, nument2, resultado1, n, edad1, edad2, edad3, edad4, edad5;
        public String nombre1;

        public LibreriaClases()
        {
            num = 0;
            nument1 = 0;
            nument2 = 0;
            resultado1 = 0;
            n = 1;
            nombre1 = "";
           
        }

        public void metodo1() {
            switch(num){
                case 1:
                    Console.WriteLine("Por favor ingrese el primer numero entero: ");
                    nument1 = int.Parse(Console.ReadLine());
                    if (nument1==0)
                    {
                        Console.WriteLine("EL PRODUCTO DE 0 POR CUALQUIER NUMERO ES 0");
                    }
                    else if (nument1 > 0)
                    {
                        Console.WriteLine("Por favor ingrese el segundo numero entero:");
                        nument2 = int.Parse(Console.ReadLine());
                        resultado1 = nument1 * nument2;
                        Console.WriteLine("El producto de ambos numeros enteros es: "+resultado1);
                    }
                    break;
            }
        }

        public void metodo2()
        {
            Console.WriteLine("Digite una de las siguientes opciones: ");
            Console.WriteLine("Presione 1-Multiplicacion de 2 numeros, 2-Divicion de 2 numeros enteros, 3- Para escribir el nombre de 5 alumnos, 4-Para escribir la edad de 5 alumnos ");
            num = int.Parse(Console.ReadLine());
            switch(num){
                case 1:
                    metodo1();
                    break;

                case 2:
                    Console.WriteLine("Por favor ingrese el primer numero entero: ");
                    nument1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor ingrese el segundo numero entero: ");
                    nument2 = int.Parse(Console.ReadLine());
                    if (nument2==0)
                    {
                        Console.WriteLine("ERROR. NO SE PUEDE DIVIDIR ENTRE CERO");
                    }
                    else if (nument2>0)
                    {
                        resultado1 = (nument1 / nument2);
                        Console.WriteLine("El resultado de la division es: "+resultado1);
                    }
                    break;
                case 3:
                    for (int i = 0; i <= 5; i++)
                    {
                        Console.WriteLine("Por favor ingrese el nombre del alumno nª"+i);
                        nombre1 = Console.ReadLine();
                        Console.WriteLine("Nombre: " + nombre1);
                        //i = i + 1;
                    }
                    
                    
                    break;
                case 4:
                    do{
                        Console.WriteLine("Por favor ingrese el nombre del alumno nª" + n);
                        edad1 =int.Parse(Console.ReadLine());
                        Console.WriteLine("La edad del Estudiante nª"+n+" es: "+edad1);
                        n = n + 1;
                    }while(n<=5);
                    break;
                default:
                    break;
            }
        }

        
    }
}
