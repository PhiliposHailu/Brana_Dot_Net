public class Student
{
    public int Id {get; set;}
    public string Name {get; set;}
    public List<CourseGrade> Grades {get; set;}

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
        Grades = [];
    } 

    public void AddGrade(CourseGrade grade)
    {
        Grades.Add(grade);
    }
    public double GetAverageScore()
    {
        double val = 0;
        for (int i = 0; i < Grades.Count; i++)
        {
            val = val + Grades[i].Score;
        }

        return val / (double)Grades.Count;
    }

    public string GetLetterGrade()
    {
        double avg = GetAverageScore();
        if (avg >= 90)
        {
            return "A";
        }
        if (avg >= 80)
        {
            return "B";
        }
        if (avg >= 70)
        {
            return "C";
        }
        if (avg >= 60)
        {
            return "D";
        }
        return "F";

    }
}