using CorePackages.Domain.Comman;

namespace CorePackages.Domain.Entities;

public class Configuration<T> : BaseEntity
{
    public string Name { get; set; }
    // Type alanını T tipine göre otomatik olarak belirlemek için
    public string Type
    {
        get
        {
            return GetTypeString(typeof(T));
        }
    }
    public T Value { get; set; }
    public bool IsActive { get; set; }
    public string ApplicationName { get; set; }



    private string GetTypeString(Type type)
    {
        if (type == typeof(int))
            return "int";
        else if (type == typeof(string))
            return "string";
        else if (type == typeof(double))
            return "double";
        else if (type == typeof(bool))
            return "bool";
        else
            return "unknown";
    }
}
