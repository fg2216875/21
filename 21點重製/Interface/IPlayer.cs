using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21點重製.Interface
{
    public interface IPlayer
    {
        List<CardNo> PlayerCardNo { get; set; }
        List<CardValue> PlayerPoker { get; set; }
        CardValue PlayCardPoint { get; set; }
        TakeCard PlayerTake { get; set; }
        Control panplayer { get; set; }
        int PlayerChip { get; set; }  //玩家初始的金額
        int TakeCount { get; set; }      //玩家加牌的次數
        int PlayerPoint { get; set; }    //玩家點數總和
    }
}
