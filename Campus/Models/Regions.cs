using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Campus.Models;

[Table("regions")]
public class Regions
{
    public string Name { get; set; }
    
    public string Users { get; set; }
    
    public int Percentage { get; set; }
    
    public override string ToString()
    {
        var usNums = Users.Split(',');
        
        var strBuilder = new StringBuilder();
        strBuilder.Append("    {\n");
        strBuilder.Append($"      \"name\": \"{Name}\",\n");
        strBuilder.Append($"      \"users\": [\n");
        strBuilder.Append($"        {int.Parse(usNums[0])},\n");
        strBuilder.Append($"        {int.Parse(usNums[1])}\n");
        strBuilder.Append("      ],\n");
        strBuilder.Append($"      \"percentage\": {Percentage}\n");
        strBuilder.Append("    }");
        return strBuilder.ToString();
    }
}
