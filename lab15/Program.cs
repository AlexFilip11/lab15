using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
namespace lab15
{
    class Program
    {
        static void Main()
        {
            // Create a list of student objects
            List<Student> studenti = new List<Student>()
        {
            new Student(Guid.NewGuid(), "Filip", "Alex", 23, Specializare.informatica),
            new Student(Guid.NewGuid(), "Stan", "Maria", 22, Specializare.informatica),
            new Student(Guid.NewGuid(), "Pop", "Denisa", 19, Specializare.litere),
            new Student(Guid.NewGuid(), "Popa", "Alina", 26, Specializare.constructii),
            new Student(Guid.NewGuid(), "Chis", "Valentin", 25, Specializare.informatica),
            new Student(Guid.NewGuid(), "Pop", "Mihai", 18, Specializare.constructii),
            new Student(Guid.NewGuid(), "Alb", "David", 20, Specializare.constructii),
            new Student(Guid.NewGuid(), "Negru", "Bogdan", 27, Specializare.litere),
            new Student(Guid.NewGuid(), "Maior", "Emilia", 28, Specializare.litere),
            new Student(Guid.NewGuid(), "Pop", "Olivia", 27, Specializare.informatica)
        };

            var GetCelMaiInvarstaDeLaInfo = studenti.Where(s => s.Specializare == Specializare.informatica)
                                            .OrderByDescending(s => s.Varsta)
                                            .FirstOrDefault();
            Console.WriteLine(GetCelMaiInvarstaDeLaInfo);

            var GetCelMaiTanarStudent = studenti.OrderBy(s => s.Varsta).FirstOrDefault();
            Console.WriteLine(GetCelMaiTanarStudent);
            var GetStudentiiDeLaLitereCrescator = studenti.Where(s => s.Specializare == Specializare.litere)
                                                    .OrderBy(s => s.Varsta)
                                                    .ThenBy(s => s.Nume)
                                                    .ThenBy(s => s.Prenume)
                                                    .ToList();
            
            foreach(var student in GetStudentiiDeLaLitereCrescator)
            { Console.WriteLine(student); }

            var GetPrimulStudentConstructiiPeste20 = studenti.Where(s => s.Specializare == Specializare.constructii && s.Varsta >= 20)
                                                            .OrderBy(s=> s.Varsta)
                                                            .FirstOrDefault();
            Console.WriteLine(GetPrimulStudentConstructiiPeste20);

            var GetVarstaMedie = studenti.Average(s => s.Varsta);
            var GetStudentiCuVarstaMedie = studenti.Where(s => s.Varsta == GetVarstaMedie).ToList();
            if(GetStudentiCuVarstaMedie != null)
            {
                Console.WriteLine($"Varsta medie este {GetVarstaMedie}");
                foreach (var student in GetStudentiCuVarstaMedie)
                { Console.WriteLine(student); }
            }
            else
            {
                Console.WriteLine("Nu sunt studenti care sa aiba varsta medie");
            }

            var GetStudentiDescrescatorVarsta = studenti.Where(s => s.Varsta >= 18 && s.Varsta <= 35)
                                                        .OrderByDescending(s => s.Varsta)
                                                        .ThenBy(s => s.Nume)
                                                        .ThenBy(s => s.Prenume)
                                                        .ToList();
            foreach (var student in GetStudentiDescrescatorVarsta)
            { Console.WriteLine(student); }

            var GetUltimulStudent = studenti.LastOrDefault();
            Console.WriteLine(GetUltimulStudent);

            var GetVarstaMinima = studenti.Min(s => s.Varsta);
            if(GetVarstaMinima<18)
            { Console.WriteLine("Exista minori"); }
            else
            { Console.WriteLine("Nu exista minori"); }
        }
    }
}