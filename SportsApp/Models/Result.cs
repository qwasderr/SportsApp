using System;
using System.Collections.Generic;

namespace SportsApp.Models;

public partial class Result
{
    public int EventId { get; set; }

    public int CompetitionId { get; set; }

    public int UserId { get; set; }

    public string? Result1 { get; set; }

    public int? Place { get; set; }

    public float? Points { get; set; }

    public virtual Competition Competition { get; set; } = null!;

    public virtual Event Event { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
