using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21點重製.Model
{
    public class PlayerStaticModel
    {
        public List<CardNo> PlayerCardNo = new List<CardNo>();
        public List<CardValue> PlayerPoker = new List<CardValue>();
        public CardValue PlayCardPoint;
        public TakeCard playertake;
        public Control panplayer;
        public int playerchip;   //玩家初始的金額
        public int TakeCount;      //玩家加牌的次數
        public int PlayerPoint;    //玩家點數總和
    }
}
