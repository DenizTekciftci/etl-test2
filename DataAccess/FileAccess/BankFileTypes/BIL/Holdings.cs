using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;
using Shared.Consts;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.BIL;

public class Holdings : BankHolding
{ 
    public string portfolio { get; set; }
    [Format(DateStringFormats.ddsMMsyyyy)]
    public DateTime val_date { get; set; }
    public string instrument { get; set; }
    public string instrument_CURR { get; set; }
    public string date_rembt { get; set; }
    public decimal quantity { get; set; }
    public string last_price { get; set; }
    public string pos_curr { get; set; }
    public string pos_accr_int_m { get; set; }
    public string pos_mkt_val_m { get; set; }
    public string cost { get; set; }
    public string ref_curr { get; set; }
    public string ref_mkt_val_m { get; set; }
    public string Profit_Loss { get; set; }
    public string sub_pos_nat { get; set; }
    public string blocage { get; set; }
    public string accr_int_num_period_n { get; set; }
    public string NUM_CTR { get; set; }
    public string CODE_LOC { get; set; }
    public string APP_CODE { get; set; }
    public string pos_fees { get; set; }
    public string denom_instr { get; set; }
    public string type_instr { get; set; }
    public string nature_instr { get; set; }
    public string system_curr { get; set; }
    public string Exch_ptf_sys { get; set; }
    public string sys_curr_mkt_value { get; set; }
    public string ud_isin_code { get; set; }
    public string pos_exch_rate { get; set; }
    public string fi_mkt_val { get; set; }
    public string price_exch_rate { get; set; }
    public string ref_accr_int { get; set; }
    public string ref_mkt_val { get; set; }
    public string accr_int_curr { get; set; }
    public string pos_accr_int { get; set; }
    public string Racine { get; set; }
    public string last_price_date { get; set; }
    [Ignore]
    public string account { get; set; }
    public override DateTime HoldingDate => val_date;
    public override string ISIN => ud_isin_code;
    public override decimal? Amount => quantity;
    public override decimal? Quantity => quantity;
    public override string Currency => instrument_CURR;
    // If it's a cash balance the instrument column holds the account name
    // Otherwise, we retrieve the account name via the depot and the currency
    public override string AccountName => account;
    public override HoldingType HoldingType => GetHoldingType();

    private HoldingType GetHoldingType()
    {
        // if (string.IsNullOrEmpty(ISIN)) return HoldingType.Cash;
        // if (!string.IsNullOrEmpty(ISIN)) return HoldingType.Instrument;
        
        if (APP_CODE == "CCO") return HoldingType.Cash;
        if (APP_CODE == "SMF") return HoldingType.Instrument;

        return HoldingType.Other;
    }
}