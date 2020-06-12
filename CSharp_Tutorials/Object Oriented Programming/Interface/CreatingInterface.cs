using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    // IDisplayable -– Any object that implements the Display() method
    interface IDisplayable
    {
        // Return a description of yourself.
        string Display();
    }
    //class Student : IDisplayable
    //{
    //    public Student(string name, double grade)
    //    { 
    //        Name = name; Grade = grade; 
    //    }
    //    public string Name {  get; private set; }
    //    public double Grade { get; private set; }
    //    public string Display()
    //    {
    //        string padName = Name.PadRight(9);
    //        return String.Format("{0}: {1:N0}", padName,Grade);
    //    }
    //    // DisplayArray -– Display an array of objects that implement
    //    // the IDisplayable interface.
    //    public static void DisplayArray(IDisplayable displayables)
    //    {
    //        foreach (IDisplayable disp in displayables)
    //        {
    //            Console.WriteLine("{0}", disp.Display());
    //        }

    //    }
    //}


    // Student -- Description of a student with name and grade
    //class Student : IComparable<Student>, IDisplayable // Instantiation
    //{
    //    // Constructor -- initialize a new student object.
    //    public Student(double grade)
    //    {
    //        Grade = grade;
    //    }
    //    public double Grade { get; private set; }
    //    // Implement the IComparable<T> interface:
    //    // CompareTo -- Compare another object (in this case, Student objects) and
    //    // decide which one comes after the other in the sorted array.
    //    public int CompareTo(Student rightStudent)
    //    {
    //        // Compare the current Student (call her ‘left’) against the other
    //        // student (call her ‘right’).
    //        Student leftStudent = this;
    //        // Now generate a -1, 0 or 1 based on the Sort criteria (the student’s
    //        // grade). I could use class Double’s CompareTo() method instead).
    //        if (rightStudent.Grade < leftStudent.Grade)
    //            return -1;
    //        if (rightStudent.Grade > leftStudent.Grade)
    //            return 1;
    //        return 0;
    //    }
    //}

}
