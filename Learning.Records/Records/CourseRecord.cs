namespace Learning.Records.Records
{
    public record CourseRecord(string Name)
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
}
