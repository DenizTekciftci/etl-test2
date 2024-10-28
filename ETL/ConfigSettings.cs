using Shared.Enums;

namespace PP_Capital;

public class ConfigSettings
{
    public string PPCapitalDBConnectionString { get; set; }
    public BankConfigs BankConfigs  { get; set; }
    public CronExpressions CronExpressions  { get; set; }
    
    public Thresholds Thresholds { get; set; }
    public PythonPaths PythonPaths { get; set; }
    
    public int PythonTimeoutMs { get; set; }
}
public class PythonPaths
{
    public string Python { get; set; }
    public string Wd { get; set; }
    public string Step0 { get; set; }
    public string Step3 { get; set; }
    public string Step6 { get; set; }
}

public class Thresholds
{
    public decimal CashValidationThreshold { get; set; }
    public decimal InstrumentValidationThreshold { get; set; }
}

public class CronExpressions
{
    public string ETL { get; set; }
    public string FileMover { get; set; }
    public string HoldingsValidation { get; set; }
    public string ResetProgress { get; set;}
    public string InsertReturnDate { get; set;}
    public string InsertPrices { get; set;}
}

public class BankConfigs
{
    public string JyskeSource { get; set; }
    public string JyskeUnprocessed { get; set; }
    public string JyskeArchive { get; set; }
    public string JyskeNogleTal { get; set; }
    public string SaxoSource { get; set; }
    public string SaxoUnprocessed { get; set; }
    public string SaxoArchive { get; set; }
    public string SparNordSource { get; set; }
    public string SparNordUnprocessed { get; set; }
    public string SparNordArchive { get; set; }
    public string BilSource { get; set; }
    public string BilUnprocessed { get; set; }
    public string BilArchive { get; set; }
    public string NordnetSource { get; set; }
    public string NordnetUnprocessed { get; set; }
    public string NordnetArchive { get; set; }
    public string EFGSource { get; set; }
    public string EFGUnprocessed { get; set; }
    public string EFGArchive { get; set; }
    public string RILBASource { get; set; }
    public string RILBAUnprocessed { get; set; }
    public string RILBAArchive { get; set; }
    public string VPSource { get; set; }
    public string VPUnprocessed { get; set; }
    public string VPArchive { get; set; }

    public List<(string inbox, string unProcessed, string archive, Bank)> GetConfigs()
    {
        return
        [
            (JyskeSource, JyskeUnprocessed, JyskeArchive, Bank.Jyske),
            (SaxoSource, SaxoUnprocessed, SaxoArchive, Bank.Saxo),
            (SparNordSource, SparNordUnprocessed, SparNordArchive, Bank.SparNord),
            (NordnetSource, NordnetUnprocessed, NordnetArchive, Bank.Nordnet),
            (BilSource, BilUnprocessed, BilArchive, Bank.Bil),
            (EFGSource, EFGUnprocessed, EFGArchive, Bank.EFG),
            (RILBASource, RILBAUnprocessed, RILBAArchive, Bank.RILBA),
            // (VPSource, VPUnprocessed, VPArchive, Bank.VP),
        ];
    }
}