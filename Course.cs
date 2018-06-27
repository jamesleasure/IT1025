using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Course
    {
        public string id;
        public string title;
        public int capacity;
        public int enrollment;
        public bool completed;
        public bool active;

        public Course()
        {
            this.enrollment = 0;
            completed = false;
            active = false;
        }

        public Course (string id, string title, int capacity)
        {
            this.id = id;
            this.title = title;
            this.capacity = capacity;
            this.enrollment = 0;
            completed = false;
            active = false;
        }
        public void Rename(string id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public void SetActive(bool isActive)
        {
            this.active = isActive;
        }

        public void Complete()
        {
            this.completed = true;
        }

        public void ChangeCapacity(int capacity)
        {
            this.capacity += capacity;
        }

        public void ChangeEnrollment(int changeby)
        {
            this.enrollment += changeby;
        }

        public void Describe()
        {
            Console.WriteLine($"Id: {this.id}");
            Console.WriteLine($"title: {this.title}");
            Console.WriteLine($"Capacity: {this.capacity}");
            Console.WriteLine($"Completed: {this.completed}");
            Console.WriteLine($"Active: {this.active}");
        }
    }
}
