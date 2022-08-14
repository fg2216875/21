using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21點重製
{
    public class TakeCard : PictureBox
    {
        Control ct = new Control();
        public TakeCard(Control a)
        {           
            ct = a;
        }
        CardValue cvtake;
        public void createPic(CardNo theCard,int count, List<CardValue> deck)   //建立圖片
        {
            this.Size = new Size(104, 146);
            Location = new Point(0 + count * 130, 0);
            SizeMode = PictureBoxSizeMode.Zoom;
            Image = new Bitmap(Application.StartupPath + "\\撲克牌\\" + theCard.Symbol + theCard.Value + ".png");
            ct.Controls.Add(this);
            cvtake = new CardValue(theCard.Value);
            deck.Add(cvtake);
        }
       
    }
}
