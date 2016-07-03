using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentInfo
{
    public class StudentPersonalInfo
    {
        string name;
        string address;
        int age;
        int height;
        int weight;

        public StudentPersonalInfo(string name, string address, int age,int height, int weight)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public int GetAge()
        {
            return this.age;
        }

        public int[] GetPhysical()
        {
            int[] physical = new int[1];
            physical[0] = this.height;
            physical[1] = this.weight;

            return physical;            
        }

    }

    public class StudentCourse
    {
        string courseName;
        int courseLevel;
        string instituteName;

        public StudentCourse(string course, int level, string college)
        {
            this.courseName = course;
            this.courseLevel = level;
            this.instituteName = college;
        }

        public Dictionary<string,string> GetCollegeDetails()
        {
            Dictionary<string, string> collegeDetailsCol = new Dictionary<string, string>();
            collegeDetailsCol.Add("courseName", this.courseName);
            collegeDetailsCol.Add("courseLevel", this.courseLevel.ToString());
            collegeDetailsCol.Add("instituteName", this.instituteName);

            return collegeDetailsCol;
        }

    }

    public class Studentmarks
    {
        int marks;
        string Grade;

        public Studentmarks(int marks, string grade)
        {
            this.marks = marks;
            this.Grade = grade;
        }

        public int GetMark()
        {
            int mark = this.marks;
            return mark;
        }

        public string GetGrade()
        {           
            return this.Grade;
        }
    }
    
    
}
