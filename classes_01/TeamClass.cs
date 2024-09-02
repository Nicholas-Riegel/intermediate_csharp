namespace classes_01;

public class TeamClass
{
    private string? _name;

    public string Name
    {
        get
        { 
            return string.IsNullOrEmpty(_name) ? "Value of _name is null or empty" : _name; 
        }
        set
        { 
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Invalid name.");
            }
            else
            {
                _name = value;
            }
        }
    }
}