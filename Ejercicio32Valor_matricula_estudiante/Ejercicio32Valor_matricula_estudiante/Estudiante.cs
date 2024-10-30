using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32Valor_matricula_estudiante
{
    public class Estudiante
    {
        public int Creditos { get; set; }
        public int Estrato { get; set; }
        public const decimal ValorCreditoNormal = 100000; // Asignar el valor normal del crédito

        public decimal CalcularMatricula()
        {
            decimal costoTotal = 0;

            if (Creditos <= 20)
            {
                costoTotal = Creditos * ValorCreditoNormal;
            }
            else
            {
                // Cálculo para créditos adicionales
                int creditosExtras = Creditos - 20;
                costoTotal = (20 * ValorCreditoNormal) + (creditosExtras * ValorCreditoNormal * 2);
            }

            // Aplicar descuento según el estrato
            if (Estrato == 1)
            {
                costoTotal *= 0.2m; // 80% de descuento
            }
            else if (Estrato == 2)
            {
                costoTotal *= 0.5m; // 50% de descuento
            }
            else if (Estrato == 3)
            {
                costoTotal *= 0.7m; // 30% de descuento
            }

            return costoTotal;
        }

        public decimal CalcularSubsidio()
        {
            if (Estrato == 1)
            {
                return 200000; // Subsidio para estrato 1
            }
            else if (Estrato == 2)
            {
                return 100000; // Subsidio para estrato 2
            }
            return 0; // No hay subsidio para estratos 3 y superiores
        }
    }
}

