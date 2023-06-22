using System;
using System.Collections.Generic;

namespace Bank.Models;

public partial class Wallet
{
    public decimal Id { get; set; }

    public decimal? UserId { get; set; }

    public decimal? BankId { get; set; }

    public decimal? Iban { get; set; }

    public decimal? Balance { get; set; }

    public string? Stuts { get; set; }

    public virtual Bank? Bank { get; set; }

    public virtual ICollection<Transformation> TransformationFromwallets { get; set; } = new List<Transformation>();

    public virtual ICollection<Transformation> TransformationTowallets { get; set; } = new List<Transformation>();

    public virtual Useraccount? User { get; set; }
}
