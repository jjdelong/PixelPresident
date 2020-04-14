
/*
 *     Date: April 13, 2020
 *     Author: Josh DeLong
 *     Project 4: Create a C# GUI application that allows maintenance of student
 *     records
 *     Parent Class - Student
 *         Child Class - DormStudent
 *
 *     - Define a Student base class (ID and name)
 *         - child class of DormStudent
 *             - dorm location, meal plan type
 *         - Student class should implement IComparable interface so the students
 *             can be sorted by student ID.
 *         - Classes should use properties, constructors and ToString override.
 */

namespace Project4
{
    public class Student
    {
        private string _id { get; set; }
        private string _name { get; set; }
    }    // END class Student
}    // END Project4 namespace