using System;

namespace SRP
{
    public class Libro
    {

        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            libro.SectorBiblioteca = sector;
            libro.EstanteBiblioteca = estante;
        }
    }
}
   
        
        
