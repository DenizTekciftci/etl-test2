using CsvHelper.Configuration.Attributes;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.Jyske
{
    public class Transaction : BankTransaction
    {
        [Name("REC-TYPE")]
        public string RecType {get;set;}
        public string DEPOTNR {get;set;}
        public string KONTONR {get;set;}
        public int FONDSKODE {get;set;}
        public string ORDRENR {get;set;}
        [Name("REG-KODE")]
        public string RegKode {get;set;}
        [Name("ORDREN-RE")]
        public string OrdrenRe {get;set;}
        [Name("NOTA-DATO")]
        public string NotaDato {get;set;}
        [Name("KØB-SALG")]
        public string KøbSalg {get;set;}
        public string PAPIRMØNT {get;set;}
        public string AFREGNINGMØNT {get;set;}
        [Format(DateStringFormats.yyyydMMddd)]
        public DateTime HANDELSDATO {get;set;}
        [Format(DateStringFormats.yyyydMMddd)]
        public DateTime VALØRDATO {get;set;}
        public string VALUTAKURS {get;set;}
        public double PÅLYDENDE {get;set;}
        public double HANDELSKURS {get;set;}
        public string KURSVÆRDI {get;set;}
        public string OMKOSTNING {get;set;}
        public double NETTOBELØB {get;set;}
        public string PRENTE {get;set;}
        public string INDEKSFAKTOR {get;set;}
        public string UDTRÆKNING { get; set; }

        public override DateTime TradeDate => HANDELSDATO;

        public override DateTime ValueDate => VALØRDATO;

        public override string Currency => AFREGNINGMØNT;

        public override double Price => HANDELSKURS;

        [Ignore]
        public override double Quantity
        {
            get => PÅLYDENDE;
            set => PÅLYDENDE = value;
        }

        [Ignore]
        public override double Amount
        {
            get => NETTOBELØB;
            set => NETTOBELØB = value;
        }

        public override string ISIN => _isin;

        public override string TradeType => KøbSalg;

        public override string Account => KONTONR[0] == '0' ? KONTONR[1..] : KONTONR;
        public override List<(string costType, double cost)> GetCosts()
        {
            return 
            [
                (nameof(OMKOSTNING), Cost)
            ];
        }

        [Ignore]
        public string _isin { get; set; }
        
        [Ignore]
        public double Cost {
            get => Convert.ToDouble(OMKOSTNING.Replace(" ", ""));
            set => OMKOSTNING = value.ToString();
        }
    }
}
