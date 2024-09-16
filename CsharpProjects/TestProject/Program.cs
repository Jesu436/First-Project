using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] alumnos = {"Sophia", "Andrew", "Emma", "Logan"};


        int[][] notas = {
            new int[] {90, 86, 87, 98, 100},
            new int[] {92, 89, 81, 96, 90},
            new int[] {90, 85, 87, 98, 68},
            new int[] {90, 95, 87, 88, 96},
        };

        foreach (var alumno in alumnos.Select((nombre, indice)  => new { nombre, indice}))
        {
            int[] notasAlumno = notas[alumno.indice];
            int sumaNotas = 0;
            int creditosAdicionales = 0;


            foreach (var nota in notasAlumno)
            {
                if (nota <= 10)
                {
                    creditosAdicionales += nota;
            
                }
                else
                {
                    sumaNotas += nota;
                }
            }

            double notaFinal = (sumaNotas + (creditosAdicionales * 10)) / 5.0;
            string calificacion = ObtenerCalificacion(notaFinal);

            Console.WriteLine($"{alumno.nombre}: Nota final = {notaFinal:F2}, Calificacion = {calificacion}");

        }
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();

    }

    static string ObtenerCalificacion(double nota)
    {
        if (nota >= 97) return "A+";
        else if (nota >= 93) return "A";
        else if (nota >= 90) return "A-";
        else if (nota >= 87) return "B+";
        else if (nota >= 83) return "B";
        else if (nota >= 80) return "B-";
        else if (nota >= 77) return "C+";
        else if (nota >= 73) return "C";
        else if (nota >= 70) return "C-";
        else if (nota >= 67) return "D+";
        else if (nota >= 63) return "D";
        else if (nota >= 60) return "D-";
        else return "F";
    }
    
}




    






