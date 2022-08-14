using _21點重製.Interface;
using _21點重製.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21點重製
{
    public class Player: IPlayer
    {
        //private List<CardNo> _PlayerCardNo = new List<CardNo>();
        //private List<CardValue> _PlayerPoker = new List<CardValue>();
        //private CardValue _PlayCardPoint;
        //private TakeCard _playertake;
        //private Control _panplayer;
        //private int _playerchip = 100;   //玩家初始的金額
        //private int _TakeCount = 0;      //玩家加牌的次數
        //private int _PlayerPoint = 0;    //玩家點數總和

        public List<CardNo> PlayerCardNo { get; set; }
        public List<CardValue> PlayerPoker { get; set; }
        public CardValue PlayCardPoint { get; set; }
        public TakeCard PlayerTake { get; set; }
        public Control panplayer { get; set; }
        public int PlayerChip { get; set; }   //玩家初始的金額
        public int TakeCount { get; set; }     //玩家加牌的次數
        public int PlayerPoint { get; set; }  //玩家點數總和
        public Player(Control a)
        {
            PlayerCardNo = new List<CardNo>();
            PlayerPoker = new List<CardValue>();
            panplayer = a;
            PlayerChip = 100;
            TakeCount = 0;
            PlayerPoint = 0;
        }

        /// <summary>
        /// 取得卡牌，並加到 PlayerCardNo 手中
        /// </summary>
        /// <param name="poker"></param>
        //public void AddCard(List<CardNo> poker)    
        //{
        //    for (int i = 0; i <  2; i++)
        //    {
        //        PlayerCardNo.Add(poker[0]);
        //        poker.RemoveAt(0);    //扣除發牌的張數
        //        PlayCardPoint = new CardValue(PlayerCardNo[i].Value);
        //        PlayerPoker.Add(PlayCardPoint);
        //        PlayerPoint += PlayCardPoint.TrueValue;
        //    }
        //    PlayCardPoint.checkAce(ref PlayerPoint, PlayerPoker);             
        //}
        //public void TakeCard(List<CardNo> poker)
        //{
        //    PlayerCardNo.Add(poker[0]);
        //    poker.RemoveAt(0);
        //    playertake = new TakeCard(panplayer);
        //    playertake.createPic(PlayerCardNo[PlayerCardNo.Count - 1], TakeCount, PlayerPoker);
        //    TakeCount++;
        //    PlayerPoint += PlayerPoker[TakeCount + 1].TrueValue;
        //    PlayCardPoint.checkAce(ref PlayerPoint, PlayerPoker);
        //}

    }
}
