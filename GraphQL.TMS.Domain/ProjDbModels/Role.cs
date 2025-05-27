﻿using System;
using System.Collections.Generic;

namespace GraphQL.TMS.Domain.ProjDbModels;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
