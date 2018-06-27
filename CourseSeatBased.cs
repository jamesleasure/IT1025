using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CourseSeatBased : Course
    {
        public int seatsInRoom;
        public string roomNumber;
        public string building;

        public CourseSeatBased() :base() { }

        public CourseSeatBased (string id, string title, int capacity, int seats, string roomNumber, string building)
            :base(id, title, capacity) 
        {
            this.seatsInRoom = seats;
            this.roomNumber = roomNumber;
            this.building = building;
        }

        public new void Describe()
        {
            Console.WriteLine($"Id: {this.id}");
            Console.WriteLine($"title: {this.title}");
            Console.WriteLine($"Capacity: {this.capacity}");
            Console.WriteLine($"Completed: {this.completed}");
            Console.WriteLine($"Active: {this.active}");
            Console.WriteLine($"Room: {this.building} {this.roomNumber}");
            Console.WriteLine($"Seats in Room: {this.seatsInRoom}");
        }
    }
}
