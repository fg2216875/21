using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21點重製.Service
{
    public class GameService
    {
        /// <summary>
        /// 按照順序重新建立牌組
        /// </summary>
        /// <param name="PlayerCount"></param>
        /// <returns></returns>
        public List<CardNo> ReStart()            
        {
            List<CardNo> CardDeck = new List<CardNo>();
            for (int i = 0; i < 4; i++)
            {
                for (int s = 0; s < 13; s++)
                {
                    CardNo carNo = new CardNo();
                    carNo.Symbol = (i + 1).ToString();
                    carNo.Value = s + 1;
                    CardDeck.Add(carNo);
                }
            }
            GC.Collect();
            return CardDeck;
        }

        /// <summary>
        /// 將撲克牌做洗牌
        /// </summary>
        /// <param name="Cardnumber"></param>
        public List<CardNo> Shuffle(List<CardNo> Cardnumber)             
        {
            int RandomIndex;  //在洗牌時，代表的位置
            CardNo CurrentCard;
            Random random = new Random();
            for (int i = 0; i < Cardnumber.Count; i++)
            {
                RandomIndex = random.Next(0, 52);        //使用亂數隨機挑選要交換位置的Index值
                CurrentCard = Cardnumber[i];             //將原先未洗牌的排組，把該撲克牌的值先存到變數中
                Cardnumber[i] = Cardnumber[RandomIndex]; //先將亂數選到的撲克牌，替換掉原先牌組
                Cardnumber[RandomIndex] = CurrentCard;   //把在變數中撲克牌的，放回RandomIndex的位置上
            }
            return Cardnumber;
        }

        public int CheckPokerValue(int PokerValue)
        {
            int TrueValue = 0;
            //遇到J,Q,K,A等撲克牌時，依規則將數值做調整
            if (PokerValue >= 11)
            {
                TrueValue = 10;
            }
            else if (PokerValue == 1)
            {
                TrueValue = 11;
            }
            else
            {
                TrueValue = PokerValue;
            }
            return TrueValue;
        }

        /// <summary>
        /// 比較雙方的點數大小
        /// </summary>
        /// <param name="BankerPoint"></param>
        /// <param name="PlayerPoint"></param>
        /// <returns></returns>
        //public string ComparePoint(int BankerPoint, int PlayerPoint)
        //{
        //    string ShowMessage = "";
        //    if (BankerPoint > 21)
        //    {
        //        ShowMessage = "玩家獲勝";
        //        WinMoney();
        //        addclear();
        //    }
        //    else if (BankerPoint > PlayerPoint)
        //    {
        //        ShowMessage = "莊家獲勝!";
        //        LoseMoney();
        //        addclear();
        //    }
        //    else if (BankerPoint == PlayerPoint)
        //    {
        //        ShowMessage = "平手和局";
        //        draw();
        //        addclear();
        //    }
        //    return ShowMessage;
        //}

        public void LoseMoney(Banker BankerInfo, Player PlayerInfo, decimal PlayerBetChip)
        {
            BankerInfo.PlayerChip += (int)PlayerBetChip;
            PlayerInfo.PlayerChip -= (int)PlayerBetChip;
            //BankerInitailChip += (int)PlayerBetChip;
            //PlayerInitailChip -= (int)PlayerBetChip;
            //int[] MoneyArray = new int[] { BankerInitailChip, PlayerInitailChip };
            //return MoneyArray;
        }
        public void WinMoney(Banker BankerInfo, Player PlayerInfo, decimal PlayerBetChip)
        {
            BankerInfo.PlayerChip -= (int)PlayerBetChip;
            PlayerInfo.PlayerChip += (int)PlayerBetChip;
            //BankerInitailChip -= (int)PlayerBetChip;
            //PlayerInitailChip += (int)PlayerBetChip;
            //int[] MoneyArray = new int[] { BankerInitailChip, PlayerInitailChip };
            //return MoneyArray;
        }
    }
}
