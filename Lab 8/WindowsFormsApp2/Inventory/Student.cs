using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Student
    {
        private static List<Student> students = new List<Student>();
        public string Name { get; set; }
        public int id { get; set; }
        public string dob { get; set; }
        public string Batch { get; set; }

        public void save()
        {
            students.Add(this);
        }
        public static List<Student> getAll()
        {
            return students;
        }
        public static Student findName(string name)
        {
            return students.Find(s => s.Name == name);
        }
        public static Student findID(int id)
        {
            return students.Find(s => s.id == id);
        }
    }
}
