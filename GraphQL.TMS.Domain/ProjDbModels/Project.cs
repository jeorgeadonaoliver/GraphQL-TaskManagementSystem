using System;
using System.Collections.Generic;

namespace GraphQL.TMS.Domain.ProjDbModels;

public partial class Project
{
    public int ProjectId { get; set; }

    public string ProjectName { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Description { get; set; }

    public int? TeamId { get; set; }

    public virtual Team? Team { get; set; }
}
