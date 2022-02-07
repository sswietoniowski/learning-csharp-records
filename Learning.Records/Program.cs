using Learning.Records.Classes;
using static System.Console;

static void PrintCourse(Course course)
{
    WriteLine($"Course name: {course.Name}, created by: {course.Author}.");
}

var course = new Course()
{
    Name = "Basics of C#",
    Author = "John Doe"
};

var anotherCourse = course;

anotherCourse.Name = "Intricaties of C#"; // we're dealing with reference type!

PrintCourse(course);
PrintCourse(anotherCourse);