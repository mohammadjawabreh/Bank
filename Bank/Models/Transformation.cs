using System;
using System.Collections.Generic;

namespace Bank.Models;

public partial class Transformation
{
    public decimal Id { get; set; }

    public decimal? FromwalletId { get; set; }

    public decimal? TowalletId { get; set; }

    public decimal? Commission { get; set; }

    public decimal? Transferamount { get; set; }

    public DateTime? DateFrom { get; set; }

    public virtual Wallet? Fromwallet { get; set; }

    public virtual Wallet? Towallet { get; set; }
}
