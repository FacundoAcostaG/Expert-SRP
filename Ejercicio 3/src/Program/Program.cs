using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("Steven Jhonson", "986782342", "5555-555-555");
            Doctor doctor1 = new Doctor("Armand");
            LugarDeConsulta lugar1 = new LugarDeConsulta("Wall Street");

            string appointmentResult = ServicioCrearConsulta.CreateAppointment(paciente1, doctor1, lugar1, DateTime.Now);
            Console.WriteLine(appointmentResult);

            Paciente paciente2 = new Paciente("Antonia Mescia", "", "6666-555-555");
            Doctor doctor2 = new Doctor("Luis Miguel");
            LugarDeConsulta lugar2 = new LugarDeConsulta("Montevideo");

            string appointmentResult2 = ServicioCrearConsulta.CreateAppointment(paciente2, doctor2, lugar2, DateTime.Now);
            Console.WriteLine(appointmentResult2);

        }
    }
}
