using System;
namespace WpfSet;

public class Student : IComparable<Student>
{
    public Student(int id, string name, Gender gender)
    {
        Id = id;
        Name = name;
        Gender = gender;
    }

    public int Id { get; private set; }

    public string Name { get; private set; }

    public Gender Gender { get; private set; }

#pragma warning disable CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
    public int CompareTo(Student other)
#pragma warning restore CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
    {
        return Id.CompareTo(other.Id);
    }
}