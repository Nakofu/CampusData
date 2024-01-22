using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Campus.Models;

[Table("schools")]
public class Schools
{
    public string Name { get; set; }
    
    public string Students { get; set; }

    public string Honours { get; set; }
    
    public string Applicants { get; set; }
    
    public override string ToString()
    {
        var stNums = Students.Split(',');
        var hoNums = Honours.Split(',');
        var apNums = Applicants.Split(',');
        
        var strBuilder = new StringBuilder();
        strBuilder.Append("    {\n");
        strBuilder.Append($"      \"name\": \"{Name}\",\n");
        strBuilder.Append($"      \"students\": [\n");
        strBuilder.Append($"        \"{stNums[0]}\",\n");
        strBuilder.Append($"        \"{stNums[1]}\"\n");
        strBuilder.Append("      ],\n");
        strBuilder.Append($"      \"honours\": [\n");
        strBuilder.Append($"        \"{hoNums[0]}\",\n");
        strBuilder.Append($"        \"{hoNums[1]}\"\n");
        strBuilder.Append("      ],\n");
        strBuilder.Append($"      \"applicants\": [\n");
        strBuilder.Append($"        \"{apNums[0]}\",\n");
        strBuilder.Append($"        \"{apNums[1]}\"\n");
        strBuilder.Append("      ]\n");
        strBuilder.Append("    }");
        return strBuilder.ToString();
    }
}
