using System;
using System.Collections.Generic;

namespace Bank.Models;

public partial class Role
{
    public decimal Id { get; set; }

    public string? Rolename { get; set; }

    public virtual ICollection<Useraccount> Useraccounts { get; set; } = new List<Useraccount>();
}
