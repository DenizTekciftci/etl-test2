using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientAumId
{
    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime AumDate { get; set; }

    public int ClientPpId { get; set; }

    public double CashDkk { get; set; }

    public double InstDkk { get; set; }

    public double PpFundDkk { get; set; }

    public double MmFundDkk { get; set; }

    public double InOutDkkWCash { get; set; }

    public double InOutDkkWoCash { get; set; }

    public double TotalAumDkk { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
