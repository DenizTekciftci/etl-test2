using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class LatestClientFtNumber
{
    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime HoldingDate { get; set; }

    public int ClientPpId { get; set; }

    public double FtRenterisikoÆndring { get; set; }

    public double ModelbaseretÆndring { get; set; }

    public double KurslisteÆndring { get; set; }

    public double ModVar { get; set; }

    public double Varighed { get; set; }

    public double KursKon { get; set; }

    public double EffRnt { get; set; }

    public double Afkned100 { get; set; }

    public double Afkned50 { get; set; }

    public double Afkuænd { get; set; }

    public double Afkop50 { get; set; }

    public double Afkop100 { get; set; }

    public double FtVar { get; set; }

    public double FtRenterisikoTotal { get; set; }

    public double ModelbaseretTotal { get; set; }

    public double KurslisteTotal { get; set; }
}
