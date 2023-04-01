namespace PracticWork2;

public class Student
{
    private string _lastName;
    private DateTime _dateBirthday;
    private int _group;
    private int[] _marks;

    public string SetLastName
    {
        set => _lastName = value;
    }

    public DateTime SetDateBirthday
    {
        set => _dateBirthday = value;
    }

    public int SetGroup
    {
        set => _group = value;
    }

    public int[] SetMarks
    {
        set => _marks = value;
    }

    public Student() {}
    public Student(string lastName, DateTime dateBirthday, int group, int[] marks)
    {
        _lastName = lastName;
        _dateBirthday = dateBirthday;
        _group = group;
        _marks = new int [5];
        _marks = marks;
    }

    public void GetStudentInfo(string lastName, DateTime birthday)
    {
        if (_lastName == lastName && _dateBirthday == birthday)
        {
            string result = "Студент " + _lastName;
            result += " группы №" + _group;
            result += "\nДень рождение " + _dateBirthday.ToString("dd-MM-yyyy");
            result += "\nУспеваемость: " + string.Join(" ", _marks);
            Console.WriteLine(result);
        }

            
    }
}