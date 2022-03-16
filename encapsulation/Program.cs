Student student1 = new Student();
student1.Name = "Ayşe";
student1.Surname = "Yılmaz";
student1.StudentNo = 293;
student1.ClassNo = 3;
student1.GetStudentInfo();

student1.IncreaseStudentGrade();
student1.GetStudentInfo();

Student student2 = new Student("Deniz", "Arda", 256, 1);
student2.DecreaseStudentGrade();
student2.DecreaseStudentGrade();
student2.GetStudentInfo();
class Student
{
    private string name;
    private string surname;
    private int studentNo;
    private int classNo;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Surname { get => surname; set => surname = value; }
    public int StudentNo { get => studentNo; set => studentNo = value; }
    public int ClassNo
    {
        get => classNo;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf En Az 1 Olabilir!");
                classNo = 1;
            }
            else
            {
                classNo = value;
            }
        }
    }

    public Student(string name, string surname, int studentNo, int classNo)
    {
        Name = name;
        Surname = surname;
        StudentNo = studentNo;
        ClassNo = classNo;
    }

    public Student() { }

    public void GetStudentInfo()
    {
        Console.WriteLine("**************** Student Info *****************");
        Console.WriteLine("Student Name        : {0}", this.Name);
        Console.WriteLine("Student Surname     : {0}", this.Surname);
        Console.WriteLine("Student No          : {0}", this.StudentNo);
        Console.WriteLine("Student Class No    : {0}", this.ClassNo);
    }
    public void IncreaseStudentGrade()
    {
        this.ClassNo = this.ClassNo + 1;
    }
    public void DecreaseStudentGrade()
    {
        this.ClassNo = this.ClassNo - 1;
    }
}