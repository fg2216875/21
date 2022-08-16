using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21點重製
{
    public enum CardSymbol
    {
        Clubs = 1,
        Spades = 2,
        Diamonds = 3,
        Hearts = 4
    }
    public class CardValue
    {
      
        public int TrueValue; 
        public CardValue(int a)
        {
            //遇到J,Q,K,A等撲克牌時，依規則將數值做調整
            if (a >= 11)
            {
                TrueValue = 10;
            }
            else if (a == 1)
            {
                TrueValue = 11;
            }
            else {
                TrueValue = a;
            }
        }
    }
    public class CardNo
    {
        public int Value { get; set; }
        private string _Symbol;
        public string Symbol
        {
            get
            {
                return _Symbol;
            }
            set
            {
                switch (value)
                {
                    case "1":
                        _Symbol = "梅花";
                        break;
                    case "2":
                        _Symbol = "黑桃";
                        break;
                    case "3":
                        _Symbol = "磚塊";
                        break;
                    case "4":
                        _Symbol = "紅心";
                        break;
                }
            }
        }       
    }
}
