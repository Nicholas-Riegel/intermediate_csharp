namespace classes_01;

public class PlayerClass(string name, bool isCaptain)
{
    private string? _name = name;
    private bool _isCaptain = isCaptain;

    public string Name
    {
        get
        { 
            return string.IsNullOrWhiteSpace(_name) ? "Value of _name is null or whitespace" : _name; 
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

    public bool IsCaptain
    {
        get
        {
            return _isCaptain;
        }
        // no set function makes is readonly; 
        // but can set it through the constructor
    }   
}