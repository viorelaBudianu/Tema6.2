using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        private ulong SSN;
        private List<ulong> CheckSsn = new List<ulong>();
        private string PermanentAdress;
        private ulong MobilePhone;
        private string Email;
        private string course;
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public Student(string FirstName, string MiddleName, string Lastname, ulong SSN, ulong Mobile, string Adress, string email, string course, University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = Lastname;
            this.SSN = SSN;
            this.MobilePhone = Mobile;
            this.PermanentAdress = Adress;
            this.Email = email;
            this.course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }



        public ulong SocialSecurityNumber
        {
            get
            {
                return this.SSN;
            }
            set
            {
                if (CheckSsn.Contains(value))
                {
                    throw new ArgumentException("The SSN is not unique. We either have the student in our system, or you entered an invalid Social Security Number");
                }
                else
                {
                    this.SSN = value;
                    CheckSsn.Add(value);
                }

            }
        }
        public string Adress
        {
            get { return this.PermanentAdress; }
            set { this.PermanentAdress = value; }
        }

        public ulong Mobile
        {
            get { return this.MobilePhone; }
            set { this.MobilePhone = value; }
        }
        public string EMail
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        //Methods
        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (student.FirstName == this.FirstName && student.MiddleName == this.MiddleName && student.LastName == this.LastName &&
                student.SSN == this.SSN && student.PermanentAdress == this.PermanentAdress && student.MobilePhone == this.MobilePhone && student.Email == this.Email &&
                student.course == this.course && student.Specialty == this.Specialty && student.University == this.University && student.Faculty == this.Faculty)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Overload operator ==
        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        // Overload operator !=
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }
        //overload GetHashCode()
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        // Override ToString() method
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("First name: " + this.FirstName);
            builder.AppendLine("Middle name: " + this.MiddleName);
            builder.AppendLine("Last name: " + this.LastName);
            builder.AppendLine("SSN: " + this.SSN);
            builder.AppendLine("Address: " + this.PermanentAdress);
            builder.AppendLine("Phone number: " + this.MobilePhone);
            builder.AppendLine("Email: " + this.Email);
            builder.AppendLine("Course: " + this.Course);
            builder.AppendLine("University: " + this.University);
            builder.AppendLine("Faculty: " + this.Faculty);
            builder.AppendLine("Specialty: " + this.Specialty);

            return builder.ToString();
        }
        //Deep copy
        public Student Clone()
        {
            Student s = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Mobile, this.PermanentAdress, this.Email, this.course, this.University, this.Faculty, this.Specialty);
            return s;
        }


        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student curentStudent)
        {
            int firstNameCompare = this.FirstName.CompareTo(curentStudent.FirstName);

            if (firstNameCompare != 0)
            {
                return firstNameCompare;
            }
            else
            {
                int middleNameCompare = this.MiddleName.CompareTo(curentStudent.MiddleName);

                if (middleNameCompare != 0)
                {
                    return middleNameCompare;
                }
                else
                {
                    int lastNameCompare = this.LastName.CompareTo(curentStudent.LastName);

                    if (lastNameCompare != 0)
                    {
                        return lastNameCompare;
                    }
                    else
                    {
                        int SSNCompare = this.SSN.CompareTo(curentStudent.SSN);

                        if (SSNCompare != 0) // If names are equals, compare students by SSN
                        {
                            return SSNCompare;
                        }
                        else // Both students are equals
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

