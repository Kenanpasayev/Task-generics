using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Room
    {
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable = true;

        public Room(string name, double price, int personCapacity)
        {
            Id = _id++;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public string ShowInfo()
        {
            return $"Room ID: {Id}, Name: {Name}, Price: {Price}, Person Capacity: {PersonCapacity}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}

