using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class MgmtPerfFeesView
{
    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public string? Account { get; set; }

    public string? FeeDescription { get; set; }

    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime FeeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int AccountId { get; set; }

    public int FeeTypeId { get; set; }

    public string Currency { get; set; } = null!;

    /// <summary>
    /// Provided in negative terms to reflect cash impact on client account
    /// </summary>
    public double FeeGrossVat { get; set; }

    /// <summary>
    /// Provided in positive terms, to reflect income for PP
    /// </summary>
    public double FeeNetVat { get; set; }

    public int IncomeBankId { get; set; }

    public string? Comment { get; set; }

    public sbyte PpTransaction { get; set; }

    public sbyte CashImpact { get; set; }

    public int? TransactionId { get; set; }

    public double? PricePp { get; set; }
}
