using System;
using System.Collections.Generic;

namespace Bank.Models;

public partial class Visacard
{
    public decimal Id { get; set; }

    public string? Owneremail { get; set; }

    public string? Ownername { get; set; }

    public decimal? CardNumber { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public decimal? Cvv { get; set; }
}
