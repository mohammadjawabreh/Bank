using System;
using System.Collections.Generic;

namespace Bank.Models;

public partial class Testimonial
{
    public decimal Id { get; set; }

    public decimal? UserId { get; set; }

    public string? Name { get; set; }

    public string? Image { get; set; }

    public string? Message { get; set; }

    public string? Stuts { get; set; }

    public virtual Useraccount? User { get; set; }
}
