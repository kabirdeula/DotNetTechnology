using System;
using System.Collections.Generic;

class Student {
    public string name;
    public int age;
    public string program;

    public Student(string name, int age, string program) {
        this.name = name;
        this.age = age;
        this.program = program;
    }
}

class StudentList {
    public List<Student> students;

    public StudentList() {
        students = new List<Student>();
    }

    public void addStudent(Student student) {
        students.Add(student);
    }

    public void printStudents() {
        Console.WriteLine("\n\n\t\tStudent List:");
        foreach (Student student in students) {
            Console.WriteLine("\t\tName: " + student.name);
            Console.WriteLine("\t\tAge: " + student.age);
            Console.WriteLine("\t\tProgram: " + student.program);
            Console.WriteLine();
        }
    }
}

class Program {
    static void Main(string[] args) {
        StudentList studentList = new StudentList();
        studentList.addStudent(new Student("Krishna Gurung", 22, "BCA"));
        studentList.addStudent(new Student("Ram Bahadur", 24, "BIM"));
        studentList.addStudent(new Student("Sita Rai", 26, "BIT"));
        studentList.printStudents();
    }
}
