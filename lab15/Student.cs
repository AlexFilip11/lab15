using System;

namespace lab15
{
    class Student
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public Specializare Specializare { get; set; }
        public Student(Guid Id, string Nume, string Prenume, int Varsta, Specializare Specializare)
        {
            this.Id = Id;
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Varsta = Varsta;
            this.Specializare = Specializare;
        }
        public override string ToString() =>
            $"{Id} {Nume} {Prenume} {Varsta} {Specializare}";

    }
}
