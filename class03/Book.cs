using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class03
{
    class Book
    {
        List<double> grades;
        private String name;
        public Book(String name) {

            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade) {

            grades.Add(grade);

        }
        public void Show() {

            Console.WriteLine(name);
            if (grades.Count >= 3) {
                foreach(double item in grades)
                {
                    Console.WriteLine(item);

                }

            }

            Console.ReadKey();
        }
        public void LowandHigh() {
            var HighGrade = double.MinValue;
            var LowGrade = double.MaxValue;
            foreach (double item in grades) {

                HighGrade = Math.Max(item, HighGrade);
                LowGrade = Math.Min(item, LowGrade);

            }
            Console.WriteLine($"最高成绩：{HighGrade},最低成绩：{LowGrade}");
            Console.ReadKey();

        }
        public double Find() {
          var grade1=  grades.Find(grade=> {

                return grade > 70;

            });

            return grade1;
        }

    }
}
