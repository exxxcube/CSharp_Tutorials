using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace CSharp_Tutorials.Object_Oriented_Programming.Let_Me_Say_About_this
{
    #region Objects are responsible for themselves Example
    //public class Student //Objects are responsible for themselves
    //{
    //    public string name;
    //    // OutputName -- Output the student’s name.
    //    public static void OutputName(Student student)
    //    {
    //        // Output current student’s name.
    //        Console.WriteLine("Student's name is {0}", student.name);
    //    }
    //    // SetName -- Modify the student object’s name.
    //    public static void SetName(Student student, string name)
    //    {
    //        student.name = name;
    //    }
    //}
    //public class PassObject
    //{
    //    public static void PassObjectMain()
    //    {
    //        Student student = new Student();
    //        // Set the name by accessing it directly.s
    //        Console.WriteLine("The first time:");
    //        student.name = "Madeleine";
    //        Student.OutputName(student);
    //        // Change the name using a method.
    //        Console.WriteLine("After being modified:");
    //        Student.SetName(student, "Willa");
    //        Student.OutputName(student);
    //        // Change the name using a method.
    //        Console.WriteLine("Press Enter to terminate...");
    //        Console.Read();
    //    }
    //}
    #endregion
    #region  Invoke a member method through the object
    //public class Student
    //{
    //    // The name information to describe a student
    //    public string firstname;
    //    public string lastname;
    //    // SetName -- Save name information. (Nonstatic.)
    //    public void Setname(string fname, string lname)
    //    {
    //        firstname = fname;
    //        lastname = lname;
    //    }
    //    // ToNameString -- Convert the student object into a
    //    // string for display. (Nonstatic.)
    //    public string ToNameString()
    //    {
    //        string s = firstname + " " + lastname;
    //        return s;
    //    }
    //}
    //class MainProgram
    //{
    //    public static void MainProg()
    //    {
    //        Student student = new Student();
    //        student.Setname("Stephen", "Davis"); // Call instance method.
    //        Console.WriteLine("Student's name is " + student.ToNameString());
    //        // Wait for user to acknowledge.
    //        Console.WriteLine("Press Enter to terminate...");
    //        Console.Read();
    //    }
    //}
    #endregion
    #region When is this explicit?
    class Person
    {
        public string name;
        public int id;
        public void Init(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
    #endregion
    #region ReferencingThisExplicitly
    //// Student -- The class for university students.
    //public class Student
    //{
    //    // All students have a name and an id.
    //    public string _name;
    //    public int _id;
    //    // The course in which the student is enrolled
    //    CourseInstance _courseInstance;
    //    // Init -- Initialize the student object.
    //    public void Init(string name, int id)
    //    {
    //        this._name = name;
    //        this._id = id;
    //        _courseInstance = null;
    //    }
    //    // Enroll -- Enroll the current student in a course.
    //    public void Enroll(string courseID)
    //    {
    //        _courseInstance = new CourseInstance();
    //        _courseInstance.Init(this,courseID);     // Here’s the explicit reference.
    //    }
    //    // Display the name of the student and the course.
    //    public void DisplayCourse()
    //    {
    //        Console.WriteLine(_name);
    //        _courseInstance.Display();
    //    }
    //}
    //public class ReferencingThisExplicitlyProg
    //{
    //    public static void ReferencingThisExplicitlyMain()
    //    {
    //        // Create a student.
    //        Student student = new Student();
    //        student.Init("Stephen Davis",1234);
    //        // Now enroll the student in a course.
    //        Console.WriteLine("Enrolling Stephen Davis in Biology 101");
    //        student.Enroll("Biology 101");
    //        // Display student course.
    //        Console.WriteLine("Resulting student record:");
    //        student.DisplayCourse();
    //        // Wait for user to acknowledge the results.
    //        Console.WriteLine("Press Enter to terminate...");
    //        Console.Read();
    //    }
    //}    
    //// CourseInstance -- A combination of a student with
    //// a university course.    
    //public class CourseInstance
    //{
    //    public Student _student;
    //    public string _courseID;
    //    // Init -- Tie the student to the course.
    //    public void Init(Student student, string courseID)
    //    {
    //        this._student = student;
    //        this._courseID = courseID;
    //    }
    //    // Display -- Output the name of the course.
    //    public void Display()
    //    {
    //        Console.WriteLine(_courseID);
    //    }
    //}
    #endregion
    #region What happens when you don’t have this?
    public class Student
    {
        public string _firstname;
        public string _lastname;
        // InitStudent -- Initialize the student object.
        public void InitStudent(string firstName,string lastName)
        {
            _firstname = firstName;
            _lastname = lastName;
        }
        // OutputBanner (static) -- Output the introduction.
        public static void OutputBanner()
        {            
            Console.WriteLine("Aren’t we clever:");
            // Console.WriteLine(? what student do we use ?); = The problem!
        }
        // OutputBannerAndName (nonstatic) -- Output intro.
        public void OutputBannerAndName()
        {
            // The class Student is implied but no this
            // object is passed to the static method.
            OutputBanner();
            // The current Student object is passed explicitly.
            OutputName(this);
        }
        // OutputName -- Output the student’s name.
        public static void OutputName(Student student)
        {
            // Here, the Student object is referenced explicitly.
            Console.WriteLine("Student’s name is {0}",student.ToNameString());
        }
        // ToNameString -- Fetch the student’s name.
        public string ToNameString()
        {
            // Here, the current object is implicit --
            // this could have been written:
            // return this._firstName + “ “ + this._lastName;
            return _firstname + " " + _lastname;
        }
    }
    public class MixingStaticAndInstanceMethods
    {
        public static void MixingStaticAndInstanceMethodsMain()
        {
            Student student = new Student();
            student.InitStudent("Madeleine", "Cather");
            // Output the banner and name statically.
            Student.OutputBanner();
            Student.OutputName(student);
            Console.WriteLine();
            // Output the banner and name again using instance.
            student.OutputBannerAndName();
            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
    #endregion
}
