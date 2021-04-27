using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}

/*
La clase Kiosko no cumple con el patrón Expert. Una de sus responsabilidades es calcular el precio del alfajor, pero esta clase no es la experta en información pues se la pide a Alfajor.
El precio del alfajor debería ser calculado en la clase Alfajor, que sí es la experta en información.

Tampoco cumple con el principio SRP porque encontramos más de una razón por la cual la clase puede cambiar: podría cambiar la condición para poder comprar el alfajor, y podría cambiar el cálculo del cambio de moneda (si introducimos otra moneda diferente que no sean U$S).

*/
