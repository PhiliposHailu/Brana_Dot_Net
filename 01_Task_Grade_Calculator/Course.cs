public class CourseGrade
{
    public string CourseName {get;}
    public int Score {get; set;}

    CourseGrade(string name, int value)
    {
        CourseName = name;
        Score = value;
    }

}

