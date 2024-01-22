﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Campus.Models;

[Table("applications")]
public class Applications
{
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
