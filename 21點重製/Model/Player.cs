using _21點重製.Interface;
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
        /// <summary>
        /// 目前手中握有的撲克牌
        /// </summary>
        public List<CardNo> PlayerCardNo { get; set; }
        /// <summary>
        /// 當前撲克牌的實際點數大小
        /// </summary>
        public List<CardValue> PlayerPoker { get; set; }
        public CardValue PlayCardPoint { get; set; }
        /// <summary>
        /// 玩家圖片控制項
        /// </summary>
        public Control panplayer { get; set; }
        /// <summary>
        /// 玩家初始的金額
        /// </summary>
        public int PlayerChip { get; set; }
        /// <summary>
        /// 玩家加牌的次數
        /// </summary>
        public int TakeCount { get; set; }
        /// <summary>
        /// 玩家點數總和
        /// </summary>
        public int PlayerPoint { get; set; }  
        public Player(Control a)
        {
            PlayerCardNo = new List<CardNo>();
            PlayerPoker = new List<CardValue>();
            panplayer = a;
            PlayerChip = 100;
            TakeCount = 0;
            PlayerPoint = 0;
        }
    }
}
