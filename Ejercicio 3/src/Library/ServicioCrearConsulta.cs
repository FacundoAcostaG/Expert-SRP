using System;
using System.Text;

namespace Library
{
    public class ServicioCrearConsulta
    {
        private string idConsulta;

        public string IdConsulta
        {
            get
            {
                return this.idConsulta;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Id de consulta inválido");
                    this.idConsulta = "ERROR";
                }
                else
                {
                    this.idConsulta = value;
                }
            }
        }
        public static string CreateAppointment(Paciente paciente, Doctor doctor, LugarDeConsulta lugar, DateTime date)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (paciente.Name == "ERROR")
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (paciente.Id == "ERROR")
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (paciente.PhoneNumber == "ERROR")
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (lugar.Lugar == "ERROR")
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (doctor.Name == "ERROR")
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
