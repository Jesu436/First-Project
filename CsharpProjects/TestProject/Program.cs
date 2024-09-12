using System.Text;
string[] cursos = {"English 101", "Algebra 101", "Biology 101", "Computer science 1", "Psycologi 101" };
double[] calificaciones = {4.0, 3.0, 3.0, 3.0, 4.0};
int[] creditos = {3, 3, 4, 4, 3};
double sumacalificacionesponderadas = 0;
int sumacreditos = 0;
for (int i = 0; i < cursos.Length; i++)
{
    sumacalificacionesponderadas += calificaciones[i] * creditos[i];
    sumacreditos += creditos[i];
    }

double gpa = sumacalificacionesponderadas / sumacreditos;

Console.WriteLine("Estudiante: Sophia Bulga");
Console.WriteLine("Curso\t\t\tNota\tHoras Credito");
for (int i = 0; i < cursos.Length; i++)
{
    Console.WriteLine($"{cursos[i],-20}\t{calificaciones[i]}\t{creditos[i]}");
    Console.WriteLine($"\nGPA Final: {gpa:F2}");
}


