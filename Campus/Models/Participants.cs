using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Campus.Models;

[Table("participants")]
public class Participants
{
    //[Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //[Column("id")]
    //public string Id { get; set; }
    
    [Key]
    [Column("month")]
    public string Month { get; set; }
    
    [Column("amount")]
    public int Amount { get; set; }

    public override string ToString()
    {
        var strBuilder = new StringBuilder();
        strBuilder.Append("    {\n");
        strBuilder.Append($"      \"month\": \"{Month}\",\n");
        strBuilder.Append($"      \"amount\": {Amount}\n");
        strBuilder.Append("    }");
        return strBuilder.ToString();
    }
}