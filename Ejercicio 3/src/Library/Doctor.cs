using System;

namespace Library
{
    public class Doctor
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Nombre inválido");
                    this.name = "ERROR";
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public Doctor(string name)
        {
            this.Name = name;
        }

    }

}