using System;

namespace ProgramacionSecuencial;
class Program
{
    static void Main(string[] args)
    {


        int numero1, numero2;

        try
        {

            Console.WriteLine("Ingrese el primer número entero:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número entero:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int suma = numero1 + numero2;
            int producto = numero1 * numero2;

            Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");
            Console.WriteLine($"El producto de {numero1} y {numero2} es: {producto}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrio el Siguiente error: { ex.Message }");
        }
                Console.ReadLine();
            }


        }












