using System;

namespace Library
{
    public class Paciente
    {
        private string name;

        private string id;

        private string phoneNumber;

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

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Id inválido");
                    this.id = "ERROR";
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Número inválido");
                    this.phoneNumber = "ERROR";
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }

        public Paciente(string name, string id, string phoneNumber)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }

    }

}
