using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaSDedicnosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //toto je neurčitá osoba
            //Osoba o = new Osoba(16, "Jonáš");
            //o.Introduce();
            //tato metoda ve třídě Osoba neexistuje
            //o.WriteHomework()

            Student s = new Student(15, "Karel");
            Student s2 = new Student(16, "Jonáš");

            s.WriteHomework();

            Teacher t = new Teacher(40, "Jiřina");
            Teacher t2 = new Teacher(45, "Karolína");

            t.gradeHomework();

            //Introduce zná student od rodiče
            Console.WriteLine(s.Introduce());
            //WriteHomework zná jen Student
            Console.WriteLine(s.WriteHomework());
            //Console.WriteLine(t.WriteHomework());

            //list pouze studentů
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            
            //List požaduje třídu student, nemůžu nacpat učitele
            //students.Add(t);

            //List pouze učitelů
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(t);
            teachers.Add(t2);

            //procházím list studentů a znají i svoji metodu WriteHomework
            foreach(Student student in students)
            {
                Console.WriteLine(student.Introduce());
                Console.WriteLine(student.WriteHomework());
            }

            //procházím list učitelů a znají i svoji metodu GradeHomework
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.Introduce());
                Console.WriteLine(teacher.gradeHomework());
            }

            //Mohu udělat nadřazený list Osoba, ale znemožním přístup ke specifickým metodám
            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(s);
            osoby.Add(s2);
            osoby.Add(t);
            osoby.Add(t2);

            foreach (Osoba osoba in osoby)
            {
                //Metoda introduce je validní, protože ji zná i třída Osoba
                Console.WriteLine(osoba.Introduce());
                
                //osoba nezná WriteHomework
                //sjednocením do jednoho listu jsem znemožnil použijtí věci z Teacher a Student
                //Console.WriteLine(osoba.WriteHomework());
            }


            


        }
    }
}
