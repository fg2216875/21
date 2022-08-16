using _21點重製.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21點重製
{
    public class Banker:IPlayer
    {
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
    }
}
