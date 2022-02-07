using Learning.Records.Classes;
using Learning.Records.Records;
using static System.Console;

static void PrintCourse(Course course)
{
    WriteLine($"Course name: {course.Name}, created by: {course.Author}.");
}

static void PrintCourseRecord(CourseRecord course)
{
    WriteLine($"Course name: {course.Name}, created by: {course.Author}.");
}

var course = new Course()
{
    Name = "Basic C#",
    Author = "John Doe"
};

var anotherCourse = course;

anotherCourse.Name = "Intricaties of C# classes"; // we're dealing with reference type!

PrintCourse(course);
PrintCourse(anotherCourse);


var courseRecord = new CourseRecord("Advanced C#", "Alex Fox"); // positional record

var anotherRecord = courseRecord;

//anotherRecord.Name = "Intricaties of C# records"; // records are reference type, but :-) with a twist (immutable), init only property in this case

anotherRecord = courseRecord with { Name = "Intricaties of C# records" }; // to change anything we must create a new object

PrintCourseRecord(courseRecord);
PrintCourseRecord(anotherRecord);