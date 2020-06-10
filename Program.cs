using System;

namespace Localización_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
             var fechaActual = System.DateTime.Now;
            var actualEnUTC = System.DateTime.UtcNow;
            //Crear fecha
            System.Console.WriteLine("Crear una fecha \n Escribe un dia");
            int dia = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Escribe un mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Escribe un año");
            int año = Convert.ToInt32(Console.ReadLine());
            //Crear hora
            System.Console.WriteLine("Ahora escribe una hora \n Escribe la hora");
            int hora = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Escribe un minuto");
            int minuto = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Escribe un segundo");
            int seg = Convert.ToInt32(Console.ReadLine());

            var fecha = new System.DateTime(año, mes, dia, hora, minuto, seg);
            //imprimir y 2h despues
            System.Console.WriteLine($"La fecha que ingresaste es: {fecha}");
            System.Console.WriteLine($"Fecha actual dos horas y 30 minutos despues:  {fechaActual.AddHours(2).AddMinutes(30)}");
            //UTC
            System.Console.WriteLine($"Tu hora acual en formato UTC es: {actualEnUTC}");

            // otro país 

            System.Console.WriteLine("Fecha y hora en Tokio");
            System.Console.WriteLine(TimeZoneInfo.ConvertTime(fechaActual, TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time")));

            // Comparar 
            System.Console.WriteLine("Comparar la fecha y hora actual con la fecha y hora ingresada.");

            if (fecha == fechaActual)
            {
                System.Console.WriteLine("La fecha es la misma");
            }

            else if (fecha < fechaActual)
            {

                TimeSpan diferencia = fechaActual - fecha;
                System.Console.WriteLine($"Han pasado {diferencia.Days} días");

            }

            else
            {

                TimeSpan diferencia = fecha - fechaActual;
                System.Console.WriteLine($"Han pasado {diferencia.Days} días");

            }
        }
    }
}
