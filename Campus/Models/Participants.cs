﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Campus.Models;

public class Participants
{
    public string Month { get; set; }
    
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