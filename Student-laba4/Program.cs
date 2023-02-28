
internal class Program
{
    private static void Main(string[] args)
    {
        Student[] students =
        {
            new Student("Олегов", "Х.Н.", 324, new int[] {5,3,4,4,4}),
            new Student("Алексеев", "К.Р.", 14, new int[] {2,3,5,4,4}),
            new Student("Сергеев", "Г.С.", 643, new int[] {3,3,3,3,3}),
            new Student("Матвеев", "П.Г.", 543, new int[]{4,4,4,4,4}),
            new Student("Никитин", "Э.Х", 414, new int[]{5,5,5,5,5}),
            new Student("Сидоров", "Е.Ш.", 64, new int[]{4,4,5,5,3}),
            new Student("Волков", "В.В.", 2, new int[]{2,2,2,2,2})
        };
        foreach (Student student in students)
        {
            student.Print();
        }
        Console.WriteLine("\n\n\n\n");
        var sortedStudents = students.OrderBy(s => s.AvgGrade);
        foreach(Student student in sortedStudents)
        {
            student.Print();
        }
    }
}
class Student
{
    string surname;
    string initials;
    int group;
    int[] grades;
    double avgGrade;

    public Student(string surname, string initials, int group, int[] grades)
    {
        this.surname = surname;
        this.initials = initials;
        this.group = group;
        this.grades = grades;
        avgGrade = grades.Average();
    }
    public double AvgGrade
    {
        get { return avgGrade; }
    }
    public void Print()
    {
        Console.WriteLine($"ФИО: {surname} {initials}, группа: {group},  средний балл: {avgGrade}");
    }
}