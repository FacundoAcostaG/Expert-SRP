using System;

namespace Library
{
    public class LugarDeConsulta
    {
        private string lugar;

        public string Lugar
        {
            get
            {
                return this.lugar;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Lugar inválido");
                    this.lugar = "ERROR";
                }
                else
                {
                    this.lugar = value;
                }
            }
        }

        public LugarDeConsulta(string lugar)
        {
            this.Lugar = lugar;
        }

    }

}