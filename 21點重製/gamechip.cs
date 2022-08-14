using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21點重製
{
    class gamechip
    {
        int playerchip;
        int makerchip;
        private int chip;
        public gamechip(int a,int b)
        {
            makerchip = a;
            playerchip = b;
        }
        public delegate void callchip(int a, int b);   
        public event callchip showchip;     //建立一個事件，把Form1的 lblMoney(int a,int b) 方法存入showchip
        public delegate void formclear();
        public event formclear addclear;    //建立一個事件，把Form1的 Clear() 方法存入addclear
        public void getchip(int a)
        {
            chip = a;
        }
        public void losemoney()
        {
            makerchip += chip;
            playerchip -= chip;
            showchip(playerchip, makerchip);            
        }
        public void winmoney()
        {
            makerchip -= chip;
            playerchip += chip;
            showchip(playerchip, makerchip);          
        }
        public void draw()
        {
            showchip(playerchip, makerchip);
        }
        public void check(int a)
        {
            if (a > 21)
            {
                MessageBox.Show("超過21點了!");
                losemoney();
                addclear();
            }
        }
        public void compare(int x, int y)
        {
            if (x > 21)
            {
                MessageBox.Show("玩家獲勝");
                winmoney();
                addclear();
            }
            else if (x > y)
            {
                MessageBox.Show("莊家獲勝!");
                losemoney();
                addclear();
            }
            else if (x == y)
            {
                MessageBox.Show("平手和局");
                draw();
                addclear(); 
            }
        }
    }
}
