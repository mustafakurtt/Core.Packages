namespace Core.CrossCuttingConcerns.Logging;

public class LogParameter
{
    public string Name { get; set; }
    public object Value { get; set; }
    public object Type { get; set; }

    public LogParameter()
    {
        
    }

    public LogParameter(string name, object value, object type)
    {
        Name = name;
        Value = value;
        Type = type;
    }
}