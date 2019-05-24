using System;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Viorela",null);
            Person person1 = new Person("Alex", 26);

            Console.WriteLine(person);
            Console.WriteLine(person1);

            //public Student(string FirstName, string MiddleName, string Lastname, ulong SSN, ulong Mobile, string Adress, string email, string course, University university, Faculty faculty, Specialty specialty)
            Student student1 = new Student("Hariga", "Elena", "Viorela", 213223123, 741669147, "Nicolae Iorga", "vio@yahoo.com", "Math", University.AlexandruIoanCuza, Faculty.BusinessAdministration, Specialty.BusinessAdministrationSystem);
            Student student2 = new Student("Budianu","Viorela","Elena", 213223123, 741669147, "Nicolae Iorga", "vio@yahoo.com", "Math", University.AlexandruIoanCuza, Faculty.BusinessAdministration, Specialty.BusinessAdministrationSystem);

            Console.WriteLine("First student equal to second student? {0}", Student.Equals(student1, student2));
            Console.WriteLine("First student == second student? {0}", student1 == student2); 
            Console.WriteLine("Firs student != second student? {0}", student1 != student2); 
            Console.WriteLine();

            Student student = new Student("Budianu", "Viorela", "Elena", 213223123, 741669147, "Nicolae Iorga", "vio@yahoo.com", "Math", University.AlexandruIoanCuza, Faculty.BusinessAdministration, Specialty.BusinessAdministrationSystem);

            Console.WriteLine("First student equal to third student? {0}", Student.Equals(student1, student));
            Console.WriteLine("First student == third student? {0}", student1 == student);
            Console.WriteLine("First student != third student? {0}", student1 != student);
            Console.WriteLine();
        }
    }
}
