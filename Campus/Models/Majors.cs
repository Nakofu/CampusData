using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Campus.Models;

[Table("majors")]
public class Majors
{
    [Key]
    [Column("name")]
    public string Name { get; set; }
    
    [Column("students")]
    public string Students { get; set; }
    
    public override string ToString()
    {
        var stNums = Students.Split(',');
        var strBuilder = new StringBuilder();
        strBuilder.Append("    {\n");
        strBuilder.Append($"      \"name\": \"{Name}\",\n");
        strBuilder.Append($"      \"students\": [\n");
        strBuilder.Append($"        \"{stNums[0]}\",\n");
        strBuilder.Append($"        \"{stNums[1]}\"\n");
        strBuilder.Append("      ]\n");
        strBuilder.Append("    }");
        return strBuilder.ToString();
    }
}
