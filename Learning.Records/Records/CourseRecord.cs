namespace Learning.Records.Records
{
    // positional record
    public record CourseRecord(string Name, string Author)
    {
        // custome record property, can be method too
        public string Title => $"{Name}, {Author}";
    }
}
