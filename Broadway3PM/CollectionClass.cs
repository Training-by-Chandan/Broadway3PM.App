using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public class GenericCollectionClass
    {
        //List<T>, Dictionary<TKey, TValue>, SortedList<TKey, TValue>,Queue<T>, Stack<T>, Hashset<T>
        public static void ListExample()
        {
            List<string> listStr = new List<string>();
            listStr.Add("1");
            listStr.Add("2");
            listStr.Add("value 3");
            listStr.Add("value 4");
            listStr.Add("value 5");
            listStr.Add("1");
            listStr.Add("1");
            listStr.Add("value 6");
            listStr.Add("1");
            listStr.Add("1");
            listStr.Add("value 7");
            listStr.Add("value 8");
            listStr.Add("value 9");
            listStr.Insert(5, "Item 5");
            listStr.RemoveAt(5);

            List<string> newlist = new List<string> { "item value1", "item 2", "item 3" };

            listStr.AddRange(newlist);

            var OneList = (
                from l in listStr where l == "1" select l
                ).ToList();

            var ValueList = (
                from l in listStr where l.Contains("value") select l
                ).ToList();

            //select l from liststr l where l='1'
        }

        public static void ListExample2()
        {
            var data = DummyData.GetDummyStudentData();

            var namedata = (

                from student in data
                where student.Name.StartsWith("R")
                orderby student.Name
                select student.Name

                ).ToList();

            var namedatanew = data
                .Where(p => p.Name.StartsWith("R"))
                .OrderBy(p => p.Name)
                .Select(student => student.Name)
                .ToList();

            var email = (from s in data select s.Email).ToList();

            var groupedData = (
                from d in data
                group d by d.Address

                );
            //new { key = g.Key, count = g.Count() } => this is annonymous type
            var grouping = (from g in groupedData select new { key = g.Key, count = g.Count() }).ToList();
        }

        public static void ListJoinExample()
        {
            var student = DummyData.GetDummyStudentData();
            var record = DummyData.GetDummyRecordData();

            var joinedData =
                from s in student
                join r in record on s.Name equals r.Name
                where r.Marks <= 40
                select new { Name = s.Name, Address = s.Address, Email = s.Email, Marks = r.Marks };
        }
    }

    public class NonGenericCollectionClass
    {
        //object
        //Arraylist, SertedList, Stack, Queue, Hashtable, BitArray,
    }

    public class DummyData
    {
        public static List<Student> GetDummyStudentData()
        {
            var list = new List<Student>();
            list.Add(new Student { Name = "Ram", Address = "Ktm", Email = "ram@gmail.com" });
            list.Add(new Student { Name = "Ram1", Address = "Ktm", Email = "Ram1@gmail.com" });
            list.Add(new Student { Name = "ram2", Address = "Ktm", Email = "ram2@gmail.com" });
            list.Add(new Student { Name = "jay", Address = "Ktm", Email = "jay@gmail.com" });
            list.Add(new Student { Name = "Hari", Address = "Ktm", Email = "hari@gmail.com" });
            list.Add(new Student { Name = "Krishna", Address = "Bkt", Email = "krishna@gmail.com" });
            list.Add(new Student { Name = "Jasmine", Address = "Bkt", Email = "jasmine@gmail.com" });
            list.Add(new Student { Name = "Chandan", Address = "Ktm", Email = "Chandan@gmail.com" });
            list.Add(new Student { Name = "Broadway", Address = "Ktm", Email = "broadway@gmail.com" });
            list.Add(new Student { Name = "Dipendra", Address = "Llt", Email = "dipendra@gmail.com" });
            list.Add(new Student { Name = "Sagar", Address = "Ktm", Email = "sagar@gmail.com" });
            list.Add(new Student { Name = "John", Address = "Llt", Email = "john@gmail.com" });
            list.Add(new Student { Name = "Vin", Address = "Ktm", Email = "vin@gmail.com" });
            list.Add(new Student { Name = "Tom", Address = "Nyc", Email = "tom@gmail.com" });
            list.Add(new Student { Name = "Robert", Address = "Ktm", Email = "robert@gmail.com" });

            return list;
        }

        public static List<StudentRecord> GetDummyRecordData()
        {
            var list = new List<StudentRecord>();
            list.Add(new StudentRecord { Marks = 30, Name = "Ram", });
            list.Add(new StudentRecord { Marks = 50, Name = "jay", });
            list.Add(new StudentRecord { Marks = 40, Name = "Jasmine", });
            list.Add(new StudentRecord { Marks = 60, Name = "jay", });
            list.Add(new StudentRecord { Marks = 60, Name = "jay", });
            list.Add(new StudentRecord { Marks = 60, Name = "jay", });
            list.Add(new StudentRecord { Marks = 70, Name = "Hari", });
            list.Add(new StudentRecord { Marks = 30, Name = "Ram", });
            list.Add(new StudentRecord { Marks = 30, Name = "Jasmine", });
            list.Add(new StudentRecord { Marks = 30, Name = "Chandan", });
            list.Add(new StudentRecord { Marks = 30, Name = "Ram", });
            list.Add(new StudentRecord { Marks = 30, Name = "John", });
            list.Add(new StudentRecord { Marks = 30, Name = "John", });
            list.Add(new StudentRecord { Marks = 30, Name = "John", });
            list.Add(new StudentRecord { Marks = 30, Name = "Chandan", });
            list.Add(new StudentRecord { Marks = 30, Name = "John", });
            list.Add(new StudentRecord { Marks = 30, Name = "John", });
            list.Add(new StudentRecord { Marks = 30, Name = "John", });
            list.Add(new StudentRecord { Marks = 30, Name = "Ram", });
            list.Add(new StudentRecord { Marks = 30, Name = "Jasmine", });
            list.Add(new StudentRecord { Marks = 30, Name = "Jasmine", });
            list.Add(new StudentRecord { Marks = 30, Name = "Jasmine", });
            list.Add(new StudentRecord { Marks = 30, Name = "Robert", });

            return list;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

    public class StudentRecord
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }
}