using System;
using System.Collections.Generic;

namespace SportsApp.Models;

public partial class User:AspNetUser
{
    //public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    //public string Email { get; set; } = null!;

    public bool IsContestant { get; set; }

    public int? Age { get; set; }

    public int? Weight { get; set; }

    public int? Height { get; set; }

    public int? FirstCompYear { get; set; }

    public int? LastCompYear { get; set; }

    public int CountryId { get; set; }

    public string? PhotoUrl { get; set; }

    public string IsAdmin { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public string? SportCategory { get; set; }

    public DateOnly LastUpdate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Lineup> Lineups { get; set; } = new List<Lineup>();

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();
}
