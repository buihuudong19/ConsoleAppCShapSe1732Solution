using ConsoleAppOopDemo.Domain;

namespace ConsoleAppOopDemo;
public class StudentManager
{
    private Student[] _students;
    private int _size;

    public StudentManager()
    {
        _students = new Student[2];
        _size = 0;

    }

    public void AddStudent(Student student)
    {
        if (isFull())
        {
            Student[] temp = new Student[2 * Count()];
            Array.Copy(_students, 0, temp, 0, _size);
            _students = temp;
        }
        _students[_size++] = student;
    }
    public void UpdateStudent(Student student)
    {

    }
    public bool RemoveStudent(int? id)
    {
        return false;
    }
    public void Sort()
    {

    }
    public void Display()
    {
        foreach (Student student in _students)
        {
            Console.WriteLine(student);
        }

    }
    public int Count() => _size;
    public bool isFull()=> _size >= _students.Length;
}
