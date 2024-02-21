using System;
using System.Collections.Generic;

namespace SportsApp.Models;

public partial class Lineup
{
    public int Id { get; set; }

    public int CompetitionId { get; set; }

    public int UserId { get; set; }

    public string? Details { get; set; }

    public int IsConfirmed { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public int? Place { get; set; }

    public float? Points { get; set; }

    public virtual Competition Competition { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
