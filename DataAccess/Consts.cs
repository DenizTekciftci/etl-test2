namespace DataAccess;

public class Consts
{
    public const string CorporateActionTools = "Corporate Action Tool, ";
    public const string TilbageførselObligrationsrente = "Tilbageførsel obligationsrente";
    public const string InSuffix = ", in";
    public const string OutSuffix = ", out";
    public const string Ignore = "IGNORE";
    public const string DexSecurityTransactions = "dex_security_transactions";
    public const string DexDividendTransactions = "dex_dividend_transactions";
    public const string DexCashTransactions = "dex_cash_transactions";
    public const string DexBondCoupons = "dex_bond_coupons";
    public static string AccountNotFoundError(string accountNumber) => $"Account not found for: {accountNumber}";
    public static string AccountNotFoundForDepotAndCurrencyError(string depot, string currency) => $"Account not found for depot: {depot} and currency: {currency}";
    public static string NoProcessor(string fileName) => $"No processor for {fileName}";
    public static string InstrumentNotFoundError(string isin) => $"Instrument not found for isin: {isin}";
    public static string FundCodeNotFound(int fundCode) => $"Instrument not found for fund code: {fundCode}";
    public static string DuplicateIgnored(string type) => $"Duplicate {type} ignored";
    public static string NoTradeTypeForBank(string tradeType, string bank) => $"No tradetype: {tradeType} for bank: {bank}";
}