namespace classes_01;

public class PlayerClass(string firstName, string lastName, bool isCaptain)
{
    private string? _firstName = firstName;
    private string? _lastName = lastName;
    private string? _fullName;
    private bool _isCaptain = isCaptain;

    public string FirstName
    {
        get => string.IsNullOrWhiteSpace(_firstName) ? "Value of _firstName is null or whitespace" : _firstName; 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Invalid name.");
            }
            else
            {
                _firstName = value;
                _fullName = null;
            }
        }
    }
    
    public string LastName
    {
        get => string.IsNullOrWhiteSpace(_lastName) ? "Value of _firstName is null or whitespace" : _lastName; 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Invalid name.");
            }
            else
            {
                _lastName = value;
                _fullName = null;
            }
        }
    }

    // Readonly property
    public bool IsCaptain
    {
        get => _isCaptain;
        // no set function makes is readonly; 
        // but can set it through the constructor
    }

    // Computed property
    public string FullName
    {
        get
        {
            _fullName ??= $"{FirstName} {LastName}";
            return _fullName;
        }
    }   
}