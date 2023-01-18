namespace NBA_League_Romania.domain;

public class Student : Entity<Guid>
{
    private string name;
    private string school;

    public Student() {}
    
    public Student(string name, string school)
    {
        this.name = name;
        this.school = school;
        base.Id = Guid.NewGuid();
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string School
    {
        get => school;
        set => school = value ?? throw new ArgumentNullException(nameof(value));
    }
}