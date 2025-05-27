using System;
using System.Collections.Generic;

namespace GraphQL.TMS.Domain.ProjDbModels;

public partial class EmployeeProject
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? ProjectId { get; set; }

    public string? RoleInProject { get; set; }
}
