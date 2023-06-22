using System;
using System.Collections.Generic;

namespace Bank.Models;

public partial class Contactu
{
    public decimal Id { get; set; }

    public string? Fullname { get; set; }

    public string? Email { get; set; }

    public string? Phonenumber { get; set; }

    public string? Message { get; set; }
}
