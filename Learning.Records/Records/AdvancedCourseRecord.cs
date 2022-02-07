namespace Learning.Records.Records
{
    // records can use inheritance but only from other records, derived positional records have to repeat all property declarations
    public record AdvancedCourseRecord(string Name, decimal Price) : CourseRecord(Name);
}
