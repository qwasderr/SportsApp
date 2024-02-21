using System;
using System.Collections.Generic;

namespace SportsApp.Models;

public partial class Event
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Details { get; set; }

    public virtual ICollection<CompetitionEvent> CompetitionEvents { get; set; } = new List<CompetitionEvent>();

    public virtual ICollection<EventVideo> EventVideos { get; set; } = new List<EventVideo>();

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();
}
