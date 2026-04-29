Student student1 = new(1, "Clearica");
Student student2 = new(2, "Kevin");
Student student3 = new(3, "David");

List<string> courses = ["Math", "English", "Physics",  "Biology", "History"];
List<int> s1Grades = [77, 99, 81, 100, 99];
List<int> s2Grades = [99, 80, 99, 80, 77];
List<int> s3Grades = [60, 99, 65, 99, 99];

void addStudentGrade(List<int> grades, Student s) 
{
    for (int i = 0; i < grades.Count; i++)
    {
        CourseGrade curCourse = new(courses[i], grades[i]);
        s.AddGrade(curCourse);
    }
}
addStudentGrade(s1Grades, student1);
addStudentGrade(s2Grades, student2);
addStudentGrade(s3Grades, student3);


Console.WriteLine(student1.Grades);
Console.WriteLine(student2.Grades);
Console.WriteLine(student3.Grades);
