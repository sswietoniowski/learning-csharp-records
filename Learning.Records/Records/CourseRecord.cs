﻿namespace Learning.Records.Records
{
    // keyword class is not required here (it is like that by default), I've added it to constract with record struct in declaration
    public record class CourseRecord(string Name)
    {
        // constructor with parameters is created only for the positional parameters, 
        // if we decide to create custom record we must create it by ourself
        public CourseRecord(string name, string author) : this(name) // must be called to initialize positional parameters
        {
            Author = author;
        }

        // destructuring is also generated only for the positional parameters
        public void Deconstruct(out string name, out string author)
        {
            name = Name;
            author = Author;
        }

        public string Author { get; init; } = default!;
        public string Title => $"{Name}, {Author}";
    }

    // starting with C# 10 we can have record structs (you know different management allocation amont other things ;-))
    public record struct CourseRecordAsStruct
    {
        public string Name;
        public string Author;
    }
}
