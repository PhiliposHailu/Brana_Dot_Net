Student student1 = new(1, "Clearica");
Student student2 = new(2, "Kevin");
Student student3 = new(3, "David");

List<string> courses = ["Math", "English", "Physics",  "Biology", "History"];
List<int> s1Grades = [77, 99, 81, 100, 99];
List<int> s2Grades = [99, 80, 99, 80, 77];
List<int> s3Grades = [60, 99, 65, 99, 99];

List<Student> students = [student1, student2, student3];
List<List<int>> grades = [s1Grades, s2Grades, s3Grades];

void addStudentGrade(List<int> grades, Student s) 
{
    for (int i = 0; i < grades.Count; i++)
    {
        CourseGrade curCourse = new(courses[i], grades[i]);
        s.AddGrade(curCourse);
    }
}

for (int i = 0; i < grades.Count; i++)
{
    addStudentGrade(grades[i], students[i]);
    Console.WriteLine(students[i]);
}