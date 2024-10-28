using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientInfoView
{
    public int ClientPpId { get; set; }

    public string ClientName { get; set; } = null!;

    public string? Address { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public int CountryId { get; set; }

    public string? Cvr { get; set; }

    public string? ContractType { get; set; }

    public string? ClientType { get; set; }

    public string? TimeUsed { get; set; }

    public int ManagerId { get; set; }

    public long? OnTop { get; set; }

    public int? PartnerId { get; set; }
}
