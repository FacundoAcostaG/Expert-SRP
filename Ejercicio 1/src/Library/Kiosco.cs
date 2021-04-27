using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = Moneda.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioAlfajor(a.PrecioMasa, a.PrecioDulce);

        }
       
    }
}
