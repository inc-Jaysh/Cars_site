namespace DBFirst_Car_Site.Models
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public int NumberCode { get; set; }

        public string Phone { get; set; }

        Person(int age) {
            this.Age = age;
        }

        public void Print()
        {
            Console.Error.WriteLine("Не персона");
        }

    }
}
