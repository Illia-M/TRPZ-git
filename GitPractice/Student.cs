public record Student
{
    public Student(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException($"'{nameof(firstName)}' cannot be null or whitespace.", nameof(firstName));
        }

        if (string.IsNullOrEmpty(lastName))
        {
            throw new ArgumentException($"'{nameof(lastName)}' cannot be null or empty.", nameof(lastName));
        }

        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string FullName => FirstName + " " + LastName;

    public bool TryChangeName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            return false;
        }

        if (FirstName == firstName)
        {
            return false;
        }

        FirstName = firstName;

        return true;
    }
   
}