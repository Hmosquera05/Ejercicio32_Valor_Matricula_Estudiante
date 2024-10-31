using System.Security.Cryptography;
using System;
using Ejercicio32Valor_matricula_estudiante;

public class Program
{
    private static void Main(string[] args)
    {

        /*32.Se desea obtener el valor de la matrícula de un estudiante cuyo valor se calcula de la siguiente manera en un subprograma:

             •	Si toma 20 o menos créditos, paga el crédito al valor normal.
             •	Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal.
             •	Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:
              - Si el estrato es 1, el descuento es del 80 %.
              - Si el estrato es 2, el descuento es del 50 %.
              - Si el estrato es 3, el descuento es del 30 %.

          Además, los estratos 1 y 2 reciben subsidio de alimentación y transporte de la siguiente manera (el cual se debe calcular en otro subprograma):

             •	Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
             •	Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.
          Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio.

          La aplicación debe preguntar al usuario si quiere volver al inicio o no para calcular la matrícula de un nuevo estudiante.*/
        {
            bool continuar = true;

            while (continuar)
            {
                Estudiante estudiante = new Estudiante();

                Console.WriteLine("Ingrese el número de créditos:");
                estudiante.Creditos = int.Parse(Console.ReadLine());

                //Se le solicita al estudiante su estrato
                Console.WriteLine("Ingrese el estrato del estudiante (1,2 o 3):");
                estudiante.Estrato = int.Parse(Console.ReadLine());

                //Dependiendo el estrato se muestran el costo de la matrícula + los subsidios
                decimal costoMatricula = estudiante.CalcularMatricula();
                decimal subsidio = estudiante.CalcularSubsidio();

                //Se muestran los resultados de la matricula y subsidios que apliquen
                Console.WriteLine($"El costo de la matrícula es: {costoMatricula:C}");
                Console.WriteLine($"El valor del subsidio es: {subsidio:C}");

                //Se pregunta al usuario si quiere volver al inicio o no para calcular la matrícula de un nuevo estudiante.
                Console.WriteLine("¿Desea calcular la matrícula de un nuevo estudiante? (s/n):");
                string respuesta = Console.ReadLine();
                continuar = respuesta.Equals("s", StringComparison.OrdinalIgnoreCase);
            }
        }
    }

}
