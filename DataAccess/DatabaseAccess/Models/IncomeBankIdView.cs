using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IncomeBankIdView
{
    public int BankId { get; set; }

    public string? Bank { get; set; }

    public string? JbCode { get; set; }

    public string? Ec { get; set; }

    public string CountryName { get; set; } = null!;
}
