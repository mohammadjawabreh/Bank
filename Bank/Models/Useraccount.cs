using System;
using System.Collections.Generic;

namespace Bank.Models;

public partial class Useraccount
{
    public decimal Id { get; set; }

    public decimal? RoleId { get; set; }

    public string? Fullname { get; set; }

    public string? Email { get; set; }

    public string? ImagPath { get; set; }

    public string? Password { get; set; }

    public string? Phonenumber { get; set; }

    public virtual Role? Role { get; set; }

    public virtual ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();

    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();
}
