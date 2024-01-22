using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Campus.Models;

[Table("pages")]
public class Pages
{
    [Key]
    [Column("name")]
    public string Name { get; set; }
    
    [Column("time")]
    public int Time { get; set; }
    
    [Column("percentage")]
    public int Percentage { get; set; }
    
    public override string ToString()
    {
        var strBuilder = new StringBuilder();
        strBuilder.Append("    {\n");
        strBuilder.Append($"      \"name\": \"{Name}\",\n");
        strBuilder.Append($"      \"time\": {Time},\n");
        strBuilder.Append($"      \"percentage\": {Percentage}\n");
        strBuilder.Append("    }");
        return strBuilder.ToString();
    }
}
