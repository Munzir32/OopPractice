    using System;
     
    public class FirstClass
    {
        public static void Main(string[] args)
        {

            System.Console.WriteLine(" enter the three names");
            int total = 3;
            Person[] persons = new Person[total];
     
            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person() {
                    Name = Console.ReadLine()};
            }
     
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
     
            Console.ReadLine();
        }
     
    }