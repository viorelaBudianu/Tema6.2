using System;
using System.Text;

namespace Students
{
    public class Person
    {
        private string Name;
        private Nullable<int> Age;

        //Constructor
        public Person(string name, Nullable<int> age)
        {
            this.Name = name;
            this.Age = age;
        }

        //Proprietati
        public string PersonName
        {
            get { return this.Name; }
            set
            {
                if (this.Name == null)
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                else
                {
                    this.Name = value;
                }
            }
        }

        public Nullable<int> PersonAge
        {
            get { return this.Age; }
            set
            {
                if (Age <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative!");
                }
            }
        }

        // Override metoda ToString()

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Name: " + this.Name);

            if (this.Age == null)
            {
                stringBuilder.Append($"Age is null for {this.Name}");
            }
            else
            {
                stringBuilder.Append("Age: " + this.Age);
            }

            return stringBuilder.ToString();
        }
    }
}
