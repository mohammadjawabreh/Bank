using System;
using System.Collections.Generic;

namespace Bank.Models;

public partial class Bank
{
    public decimal Id { get; set; }

    public string? Bankname { get; set; }

    public string? ImagPath { get; set; }

    public string? ContactNumber { get; set; }

    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();
}
