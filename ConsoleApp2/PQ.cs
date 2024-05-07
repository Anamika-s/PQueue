using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     
        public class Patient
        {
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; }

            public Patient(string name, int age)
            {
                Name = name;
                Age = age;
            }

            static void Main()
            {
                var patients = new List<(Patient, int)>()
{
    (new("Sarah", 23), 4),
    (new("Joe", 50), 2),
    (new("Elizabeth", 60), 1),
    (new("Natalie", 16), 5),
    (new("Angie", 25), 3)
};
                var hospitalQueue = new PriorityQueue<Patient, int>(patients);
                var highestPriorityPatient = hospitalQueue.Dequeue();
                Console.WriteLine(highestPriorityPatient.Name);
            }
        }
    }
