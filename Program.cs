using System;
using System.Collections.Generic;

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public int HouseNumber { get; set; }
}

public class Student
{
    private string lastName;
    private string firstName;
    private string middleName;
    private DateTime birthDate;
    private Address homeAddress;
    private string phoneNumber;
    private List<int> grades;

    public Student(string lastName, string firstName, string middleName, DateTime birthDate, Address homeAddress, string phoneNumber)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.middleName = middleName;
        this.birthDate = birthDate;
        this.homeAddress = homeAddress;
        this.phoneNumber = phoneNumber;
        this.grades = new List<int>();
    }

    public Student(string lastName, string firstName, string middleName, DateTime birthDate, Address homeAddress, string phoneNumber, List<int> grades)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.middleName = middleName;
        this.birthDate = birthDate;
        this.homeAddress = homeAddress;
        this.phoneNumber = phoneNumber;
        this.grades = grades;
    }

    public string LastName
    { get; set; }

    public string FirstName
    { get; set; }

    public string MiddleName
    { get; set; }

    public DateTime BirthDate
    { get; set; }
    public Address HomeAddress
    { get; set; }

    public string PhoneNumber
    { get; set; }

    public List<int> Grades
    { get; set; }

    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Middle Name: {middleName}");
        Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Home Address: {homeAddress.City}, {homeAddress.Street}, {homeAddress.HouseNumber}");
        Console.WriteLine($"Phone Number: {phoneNumber}");
        Console.WriteLine($"Grades: {string.Join(", ", grades)}");
    }
}
class Program
{
    static void Main(string[] args)
    {

        Address address = new Address
        {
            City = "Odesa",
            Street = "heroes of the defense of Odessa",
            HouseNumber = 22
        };

        Student student1 = new Student("Yakuskin", "Arkadiy", "D.", new DateTime(1990, 1, 1), address, "555-1234");
        student1.AddGrade(80);
        student1.AddGrade(90);
        student1.AddGrade(85);
        student1.DisplayInfo();
    }
}
