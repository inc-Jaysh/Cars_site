namespace DBFirst_Car_Site.Models
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public string Number { get; set; }

        public Person(string name,  int age, string city, string number)
        {
            Number = number;
            Name = name;
            Age = age;
            City = city;
        }

        Person() {

        }

        public void Print()
        {
            Console.Write("Персона");
        }

    }
}
