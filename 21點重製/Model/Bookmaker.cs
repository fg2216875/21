using _21點重製.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21點重製
{
    class Banker:IPlayer
    {
        //public List<CardValue> MakerPoker = new List<CardValue>();
        //public List<CardNo> Makercard = new List<CardNo>();
        //CardValue makercardpoint;
        //TakeCard makertake;
        //Control panmaker;
        //public int BankerChip = 1000;
        //public int BankerPoint = 0;
        //public int TakeCount = 0;
        /// <summary>
        /// 莊家中撲克牌的原始牌面大小
        /// </summary>
        public List<CardNo> PlayerCardNo { get; set; }
        /// <summary>
        /// 莊家撲中克牌的實際大小
        /// </summary>
        public List<CardValue> PlayerPoker { get; set; }
        public CardValue PlayCardPoint { get; set; }
        public Control panplayer { get; set; }
        public int PlayerChip { get; set; }   
        public int TakeCount { get; set; }    
        public int PlayerPoint { get; set; }  
        public Banker(Control a)
        {
            PlayerPoker = new List<CardValue>();
            PlayerCardNo = new List<CardNo>();
            panplayer = a;
            PlayerChip = 1000;
            PlayerPoint = 0;
            TakeCount = 0;
        }
        //public void MakerAddCard(List<CardNo> poker)    //取得卡牌，並加到 Playercard 手中
        //{
        //    for (int i = 0; i < 2; i++)
        //    {
        //        Makercard.Add(poker[0]);
        //        poker.RemoveAt(0);        // 扣除發牌的張數
        //        makercardpoint = new CardValue(Makercard[i].Value);
        //        MakerPoker.Add(makercardpoint);
        //        makerpoint += makercardpoint.TrueValue;
        //    }
        //    makercardpoint.checkAce(ref makerpoint, MakerPoker);
        //}
        //public void MakerTakeCard(List<CardNo> poker)
        //{
        //    Makercard.Add(poker[0]);
        //    poker.RemoveAt(0);
        //    makertake = new TakeCard(panmaker);
        //    makertake.createPic(Makercard[Makercard.Count - 1], takecount, MakerPoker);
        //    takecount++;
        //    makerpoint += MakerPoker[takecount + 1].TrueValue;
        //    makercardpoint.checkAce(ref makerpoint, MakerPoker);
        //}
        
    }
}
