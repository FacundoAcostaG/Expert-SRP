using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}
/*
La clase Alfajor cumple con el principio SRP. Esta responsabilidad está totalmente encapsulada por la clase por las propiedades get y set, y no hallamos más de una razón por la cual la clase podría cambiar.

Como mencionamos anteriormente, la responsabilidad de esta clase es conocer el precio de los ingredientes. Si la miramos indpendientemente de la clase Kiosko, cumple con el patrón Expert porque ninguna otra clase conoce los precios. 
Si se analiza en conjunto a la clase Kiosko, concluímos que no cumple con el patrón Expert porque es quien debería calcular el precio de los alfajores (por ser el experto en información), pero no lo hace.

*/