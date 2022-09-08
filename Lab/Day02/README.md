# Day 02

<p>September 7, 2022</p>

### Question:

<p>Create a class Person that contains name, age, address and phone number as an attributes and do the following tasks,
    
    - inherite person class to Student class.

    - add sID and collegeName in subclass student.

    - inherite Person class to Teacher class.

    - add tID and subjectTaught in Teacher.

    - create display method in every classes.

    - display all the information of student and teacher.
</p>

### Source Code:

```csharp
public class MyClass
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Srijana Gurung", 17, "Chetrapati", "9883145890");
        p1.display();
        Student s1 = new Student("Ruben Shrestha", 26, "Indrachowk", "9841513439", 186, "PIS");
        s1.Display();
        Teacher t1 = new Teacher("Pushpa Baruwal", 29, "Khichapokhari", "9849527167", 192, "DBMS");
        t1.Display();
    }
}

class Person
{
    public string name;
    public int age;
    public string address;
    public string phoneNumber;

    public Person(string name, int age, string address, string phoneNumber){
        this.name = name;
        this.age = age;
        this.address = address;
        this.phoneNumber = phoneNumber;
    }

    public void display(){
        Console.WriteLine("Name: "+ name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Phone Number: " + phoneNumber);   
    }
}

class Student : Person{
    public int sID;
    public string collegeName;

    public Student(string name, int age, string address, string phoneNumber, int sID, string collegeName) : base(name, age, address, phoneNumber){
        this.sID = sID;
        this.collegeName = collegeName;
    }

    public void Display(){
        base.display();
        Console.WriteLine("Student ID: "+ sID);
        Console.WriteLine("College Name: " + collegeName);
    }

}

class Teacher : Person{
    public int tID;
    public string subjectTaught;

    public Teacher(string name, int age, string address, string phoneNumber, int tID, string subjectTaught) : base(name, age, address, phoneNumber){
        this.tID = tID;
        this.subjectTaught = subjectTaught;
    }
    public void Display(){
        base.display();
        Console.WriteLine("Teacher ID: "+ tID);
        Console.WriteLine("Subject Taught: " + subjectTaught);
    }
}
```

### Output:

![Output](./output.png)