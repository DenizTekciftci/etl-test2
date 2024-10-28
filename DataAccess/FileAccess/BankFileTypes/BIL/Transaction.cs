using CsvHelper.Configuration.Attributes;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.BIL;

public class Transaction : BankTransaction
{
    public override DateTime TradeDate => AccountingDate;
    public override DateTime ValueDate => _valueDate;
    public override string Currency => OpeCurr;
    public override double Price => LastQuote;
    [Ignore]
    public override double Quantity
    {
        get => _quantity;
        set => _quantity = value;
    }
    
    [Ignore]
    public override double Amount
    {
        get => AccountAmount;
        set => AccountAmount = value;
    }

    public override string ISIN => ud_isin_code;
    public override string TradeType => $"{OPE_NATURE}, {OPE_TYPE}, {Type_operation}";
    public override string Account => _account;

    [Format(DateStringFormats.ddsMMsyyyy)]
    public DateTime INPUT_DATE { get; set;}
    public string OPE_NATURE { get; set;}
    public string OPE_TYPE { get; set;}
    [Name("INSTR_CODE")]
    public string Instrument { get; set;}
    [Name("QUANTITY")]
    public double _quantity { get; set;}
    [Name("ACCOUNT_AMOUNT")]
    public double AccountAmount { get; set;}
    public string cash_portfolio { get; set;}
    public string OPE_CODE { get; set;}
    [Name("portfolio")]
    public string Depot { get; set;}
    public string OPE_STATUS { get; set;}
    [Default(0)]
    [Name("LAST_QUOTE")]
    public double LastQuote { get; set;}
    [Name("OPE_CURR")]
    public string OpeCurr { get; set;}
    [Name("ACCOUNT")]
    public string _account { get; set;}
    [Name("ACCOUNT_CURR")]
    public string AccCurrency { get; set;}

    [Name("accounting_date")]
    [Format(DateStringFormats.ddsMMsyyyy)]
    public DateTime AccountingDate { get; set;}
    [Format(DateStringFormats.ddsMMsyyyy)]
    [Name("value_date")]
    public DateTime _valueDate { get; set;}
    public string input_user { get; set;}
    [Format(DateStringFormats.ddsMMsyyyy)]
    public DateTime creation_date { get; set;}
    public string last_modif_user { get; set;}
    public string last_modif_date { get; set;}
    public string BOLD { get; set;}
    public string INSTR_NAME { get; set;}
    [Name("ud_isin_code")]
    public string ud_isin_code { get; set;}
    public string ud_fee_1_type_code { get; set;}
    public string ud_fee_1_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_1_amount { get; set;}
    public string ud_fee_1_curr { get; set;}
    public string ud_fee_2_type_code { get; set;}
    public string ud_fee_2_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_2_amount { get; set;}
    public string ud_fee_2_curr { get; set;}
    public string ud_fee_3_type_code { get; set;}
    public string ud_fee_3_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_3_amount { get; set;}
    public string ud_fee_3_curr { get; set;}
    public string ud_fee_4_type_code { get; set;}
    public string ud_fee_4_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_4_amount { get; set;}
    public string ud_fee_4_curr { get; set;}
    public string ud_fee_5_type_code { get; set;}
    public string ud_fee_5_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_5_amount { get; set;}
    public string ud_fee_5_curr { get; set;}
    public string ud_fee_6_type_code { get; set;}
    public string ud_fee_6_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_6_amount { get; set;}
    public string ud_fee_6_curr { get; set;}
    public string ud_fee_7_type_code { get; set;}
    public string ud_fee_7_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_7_amount { get; set;}
    public string ud_fee_7_curr { get; set;}
    public string ud_fee_8_type_code { get; set;}
    public string ud_fee_8_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_8_amount { get; set;}
    public string ud_fee_8_curr { get; set;}
    public string ud_fee_9_type_code { get; set;}
    public string ud_fee_9_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_9_amount { get; set;}
    public string ud_fee_9_curr { get; set;}
    public string ud_fee_10_type_code { get; set;}
    public string ud_fee_10_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_10_amount { get; set;}
    public string ud_fee_10_curr { get; set;}
    public string ud_fee_11_type_code { get; set;}
    public string ud_fee_11_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_11_amount { get; set;}
    public string ud_fee_11_curr { get; set;}
    public string ud_fee_12_type_code { get; set;}
    public string ud_fee_12_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_12_amount { get; set;}
    public string ud_fee_12_curr { get; set;}
    public string ud_fee_13_type_code { get; set;}
    public string ud_fee_13_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_13_amount { get; set;}
    public string ud_fee_13_curr { get; set;}
    public string ud_fee_14_type_code { get; set;}
    public string ud_fee_14_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_14_amount { get; set;}
    public string ud_fee_14_curr { get; set;}
    public string ud_fee_15_type_code { get; set;}
    public string ud_fee_15_type_denom { get; set;}
    [Default(0)]
    public double ud_fee_15_amount { get; set;}
    public string ud_fee_15_curr { get; set;}
    public string market_third_code { get; set;}
    public string market_third_name { get; set;}
    [Name("op_gross_amount")]
    public string GrossAmount { get; set;}
    public string op_exch_rate { get; set;}
    [Name("revers_oper_nat")]
    public string Reverse { get; set;}
    public string revers_oper_code { get; set;}
    [Name("account1_code (new)")]
    public string account1_code { get; set;}
    [Name("account1_curr (new)")]
    public string account1_curr { get; set;}
    [Name("account1_iban (new)")]
    public string IBAN1 { get; set;}
    [Name("account1_amount (new)")]
    public string account1_amount{ get; set;}
    [Name("account2_code (new)")]
    public string account2_code { get; set;}
    [Name("account2_curr (new)")]
    public string account2_curr { get; set;}
    [Name("account2_iban (new)")]
    public string IBAN2 { get; set;}
    [Name("account2_amount (new)")]
    public string account2_amount { get; set;}
    [Name("account3_code (new)")]
    public string account3_code { get; set;}
    [Name("account3_curr (new)")]
    public string account3_curr { get; set;}
    [Name("account3_iban (new)")]
    public string IBAN3 { get; set;}
    [Name("account3_amount (new)")]
    public string account3_amount { get; set;}
    public string Type_operation { get; set;}
    public string Accrued_interests { get; set;}
    public override List<(string, double)> GetCosts()
    {
        return
        [
            (ud_fee_1_type_denom, ud_fee_1_amount),
            (ud_fee_2_type_denom, ud_fee_2_amount),
            (ud_fee_3_type_denom, ud_fee_3_amount),
            (ud_fee_4_type_denom, ud_fee_4_amount),
            (ud_fee_5_type_denom, ud_fee_5_amount),
            (ud_fee_6_type_denom, ud_fee_6_amount),
            (ud_fee_7_type_denom, ud_fee_7_amount),
            (ud_fee_8_type_denom, ud_fee_8_amount),
            (ud_fee_9_type_denom, ud_fee_9_amount),
            (ud_fee_10_type_denom, ud_fee_10_amount),
            (ud_fee_11_type_denom, ud_fee_11_amount),
            (ud_fee_12_type_denom, ud_fee_12_amount),
            (ud_fee_13_type_denom, ud_fee_13_amount),
            (ud_fee_14_type_denom, ud_fee_14_amount),
            (ud_fee_15_type_denom, ud_fee_15_amount),
        ];
    }
}