using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Campus.Models;

public class Participants
{
    public string month { get; set; }
    
    public int amount { get; set; }

    public override string ToString()
    {
        var strBuilder = new StringBuilder();
        strBuilder.Append("    {\n");
        strBuilder.Append($"      \"month\": \"{month}\",\n");
        strBuilder.Append($"      \"amount\": {amount}\n");
        strBuilder.Append("    }");
        return strBuilder.ToString();
    }
}