using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Practica_de_Ejercicios
{

    class Program
    {
        static void Main(string[] args)
        {
            Numeromayor0();

            //Console.WriteLine("Escribe un numero");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escribe una letra que sustituira a ese número");
            //char letra = char.Parse(Console.ReadLine());
            //string zero = "0";
            //for (int counter = 1; counter < 50; counter++)
            //{

            //    if (counter == num || counter==num+20)
            //    {
            //        Console.WriteLine(zero + zero + letra);

            //    } else if(counter>9)
            //    {
            //        Console.WriteLine(zero+ counter);

            //    }
            //    else
            //    {
            //        Console.WriteLine(zero + zero + counter);
            //    } 
            //}

            //Console.WriteLine("Cuantos numeros quieres sumar?");
            //int asknum = int.Parse(Console.ReadLine());
            //while (asknum == 0)
            //{
            //    Console.WriteLine("Has introducido un numero incorrecto, prueba de nuevo porfavor");
            //    asknum = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Introduce " + asknum + " numeros");
            //int num1 = int.Parse(Console.ReadLine());
            //int suma = num1;
            //int contador = 1;

            //while (contador!=asknum)
            //{


            //    num1 = int.Parse(Console.ReadLine());
            //    contador++;

            //    suma = suma + num1;

            //}
            //Console.WriteLine("El resultado de tu suma es " +suma);














        }


        static void Exercise_smallest_to_largest()
        {
            Console.WriteLine("Escribeme dos numeros seguidos, el primero menor que el segundo,  para descubrir que números hay entre ellos");
            int insertnum1 = int.Parse(Console.ReadLine());
            int insertnum2 = int.Parse(Console.ReadLine());
            Console.WriteLine(MenoraMayor(insertnum1, insertnum2));

        }


        static int MenoraMayor(int num1, int num2)

        {

            for (int counter = 1; num1 < num2; counter++)
            {

                Console.WriteLine(num1);
                int result = num1++;
            }
            return num1;

        }

        static void ExerciseTxtNum()
        {
            Console.WriteLine("¿Cuantas veces quieres ver el texto?");
            string repeatedtext = "Tres tristes tigres tragaban trigo en un trigal";
            Console.WriteLine(repeatedtext);
            int insertnum = int.Parse(Console.ReadLine());
            TxtNum(repeatedtext, insertnum);
        }

        static void TxtNum(string txt, int num)
        {

            for (int counter = 1; counter <= num; counter++)
            {
                Console.WriteLine(txt);


            }
            


        }

        static void FloydTriangle()
        {
            Console.WriteLine("Introduceme un numero entre el 3 y el 10 para imprimir el triangulo de Floyd");
            int insertnum = int.Parse(Console.ReadLine());

            while (insertnum < 3 || insertnum > 10)
            {
                Console.WriteLine("Has introducido un numero erroneo, introduce un numero del 3 al 10");
                insertnum = int.Parse(Console.ReadLine());
            }
            Floyd(insertnum);

        }



        static void Floyd(int num)
        {

            
            int i, j , k  = 1;

            for (i = 1; i <= num; i++)
            {

                //Console.WriteLine(firstnum +"bucle 1");

                for (j = 1; j <= i; j++)
                {

                    k = j;

                    Console.Write(k + " ");
                    
                    
                    //Console.WriteLine(firstnum+" " +total+ "bucle 2");
                    //total++;



                }
                Console.WriteLine();


            }
           


        }

        static void Contador()
        {

            Console.WriteLine("Escribe un numero");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe una letra que sustituira a ese número");
            string letra = Console.ReadLine();
            string countervalue;

            for( int decenas=0; decenas<10; decenas = decenas + 1)
            {
                for(int unidades = 0; unidades < 10; unidades = unidades + 1) {

                    string valuetoprint;
                    if(decenas == num)
                    {

                        valuetoprint = letra;

                    }
                    else
                    {

                        valuetoprint = decenas.ToString();
                    }

                    if (unidades == num)
                    {

                        valuetoprint = valuetoprint + letra;


                    }
                    else
                    {
                        valuetoprint = valuetoprint + unidades;

                    }

                    Console.WriteLine(" el resultado fnal es " + valuetoprint);
               

                }
                
            }
        }

        static void Contador2(int num, char lyrics)
        {
            
            
            
            //string zero = "0";
            //for (int counter = 1; counter < 20; counter = counter + 1)
            //{

            //    if (counter == num)
            //    {
            //        Console.WriteLine(zero + zero + lyrics);

            //    }
            //    else if (counter >= 10)
            //    {
            //        Console.WriteLine(zero + counter);

            //    }
            //    else
            //    {
            //        Console.WriteLine(zero + zero + counter);
            //    }

            //}



        }

        static void Numeromayor0()
        {
            Console.WriteLine("El resultado de la serie: 1 + 1/2 + 1/3 + 1/4 + 1/5 + 1/6 + ... + 1/N es..? ");
            Console.WriteLine("Introduce un numero para saberlo");
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Recievenumeromayor0(num));

        }


        static float Recievenumeromayor0(int num)
        {
            const float DIVIDENDO = 1;
            float div;
            float result = 0;

            for(int i=1; i<=num; i = i + 1)
            {

                div = DIVIDENDO / i;
                Console.WriteLine(DIVIDENDO + "/" + i + " ");
                result = result + div;
            }
            return result;
        }

        static void NumeroEnteroPositivo()
        {

            Console.WriteLine("Introduce un número para realizar la cadena correspondiente");
            int numinsert = int.Parse(Console.ReadLine());
            RepeatedNumbers(numinsert);

        }

        static void RepeatedNumbers(int num)
        {
            string resultado = "";
            
            for (int i = 1; i < num; i= i +1) //el numero que vamos a repetir
            {


                resultado = resultado + i;
                for (int m = 1; m <= i; m = m + 1) //numero de veces que repetimos i
                {
                    resultado = resultado + i;
                    


                }
                

            }
            Console.WriteLine(resultado);


        }

        static void Ejercicio2()
        {
            Console.WriteLine("Escribeme dos numeros para ser sumados");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int suma = num1 + num2;
            Console.WriteLine(suma);
            Console.WriteLine("Quieres continuar?, escribe 1(si) o 2 para el (no)");

            int decision = int.Parse(Console.ReadLine());
            while (decision == 1)
            {
                Console.WriteLine("Escribeme dos numeros para ser sumados");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                suma = num1 + num2;
                Console.WriteLine(suma);
                Console.WriteLine("Quieres continuar?, escribe 1(si) o 2 para el (no)");

                decision = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Has salido del bucle");
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Vamos a  descubrir esta serie numerica:  1, 9, 25, 49, ? ,? ,? ..");

            int numerodelaserie = 1;
            int valoracumulado = 8;
            int contador = 0;

            while (contador != 7)
            {
                Console.WriteLine(numerodelaserie);
                numerodelaserie = numerodelaserie + valoracumulado;
                valoracumulado = valoracumulado + 8;
                contador++;

            }


        }

        static void Ejercicio4()
        {

            int primernumero = 4;
            int contador = 0;
            int bandera = 0;

            while (bandera != 6)
            {

                Console.WriteLine(primernumero);



                if (contador == 0)
                {
                    primernumero = primernumero + 52;
                    contador = 1;
                }
                else if (contador == 1)
                {

                    primernumero = primernumero + 36;
                    contador = 0;
                }


                bandera++;




            }


        }
    }
}
