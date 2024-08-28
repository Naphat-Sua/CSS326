using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

class StudentDBMS
{
    private List<Student> students;
    private int counter;

    public StudentDBMS()
    {
        students = new List<Student>();
        counter = 0;
    }

    public void AddStudent(string name, int age)
    {
        counter++;
        Student newStudent = new Student(counter, name, age);
        students.Add(newStudent);
        Console.WriteLine("Student added successfully!");
    }

    // Method to display all students
    public void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("----- List of Students -----");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }

    // Method to search for a student by their ID
    public void SearchStudentById(int id)
    {
        Student foundStudent = students.Find(student => student.Id == id);
        if (foundStudent != null)
        {
            Console.WriteLine("----- Student Found -----");
            Console.WriteLine($"ID: {foundStudent.Id}, Name: {foundStudent.Name}, Age: {foundStudent.Age}");
        }
        else
        {
            Console.WriteLine($"Student with ID {id} not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        StudentDBMS studentDB = new StudentDBMS();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("===== Student Management System =====");
            Console.WriteLine("1. Add a new student");
            Console.WriteLine("2. Display all students");
            Console.WriteLine("3. Search student by ID");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter student's name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter student's age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    studentDB.AddStudent(name, age);
                    break;
                case 2:
                    studentDB.DisplayAllStudents();
                    break;
                case 3:
                    Console.Write("Enter student ID to search: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    studentDB.SearchStudentById(id);
                    break;
                case 4:
                    exit = true;
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}
