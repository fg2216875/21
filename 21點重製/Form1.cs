using _21點重製.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _21點重製
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ranorder;
        int PlayerCount = 2;
        
        List<CardNo> CardDeck = new List<CardNo>();    //建立一組撲克牌
        Player you;                  //宣告一名玩家
        Banker banker;             //宣告一名莊家
        gamechip playerchip;         //宣告雙方的籌碼
        CardNo cn, order;
        private void Form1_Load(object sender, EventArgs e)
        {
            GameService _GameService = new GameService();
            //執行時先建立一副撲克牌
            CardDeck = _GameService.ReStart();
            CardDeck = _GameService.Shuffle(CardDeck);
            //for(int i = 0; i < 4; i++)             
            //{
            //    for(int s = 0; s < 13; s++)
            //    {
            //        cn = new CardNo();
            //        cn.Symbol = (i+1) + "";
            //        cn.Value = s + 1;
            //        Cardnumber.Add(cn);                              
            //    }                
            //}
            you = new Player(panPlayer);          //建立玩家
            banker = new Banker(panMain);       //建立莊家
            playerchip = new gamechip(banker.PlayerChip, you.PlayerChip);   //建立雙方的籌碼  
            playerchip.showchip += lblMoney;
            playerchip.addclear += Clear;
        }
        //Random rand = new Random();
        //private void Shuffle()             //將撲克牌做洗牌
        //{
        //    for (int i = 0; i < Cardnumber.Count; i++)
        //    {
        //        ranorder = rand.Next(0, 52);
        //        order = Cardnumber[i];
        //        Cardnumber[i] = Cardnumber[ranorder];
        //        Cardnumber[ranorder] = order;               
        //    }
        //}

        //private void ReStart()             //檢查撲克牌數量若小於(PlayerCount * 2)，則將重新建立和洗牌
        //{
        //    if (Cardnumber.Count <= PlayerCount * 2)     
        //    {
        //        Cardnumber.Clear();
        //        for (int i = 0; i < 4; i++)
        //        {
        //            for (int s = 0; s < 13; s++)
        //            {
        //                cn = new CardNo();
        //                cn.Symbol = (i + 1) + "";
        //                cn.Value = s + 1;
        //                Cardnumber.Add(cn);
        //            }
        //        }
        //        Shuffle();
        //        GC.Collect();
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PlayerService _PlayerService = new PlayerService();
            _PlayerService.TakeCard(you, CardDeck);
            _PlayerService.CreatePokerPicture(you);
            //you.TakeCard(CardDeck);
            lblPlayer.Text = you.PlayerPoint.ToString();
            if (you.PlayerCardNo.Count == 5)
            {
                btnAdd.Enabled = false;    //先限定最多拿5張
            }
            playerchip.check(you.PlayerPoint);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            GameService _GameService = new GameService();
            picMain2.Image = new Bitmap(Application.StartupPath + "\\撲克牌\\" + banker.PlayerCardNo[1].Symbol + banker.PlayerCardNo[1].Value + ".png");
            lblMain.Text = banker.PlayerPoint + "";
            //Cardnumber = _GameService.ReStart();
            if (banker.PlayerPoint < you.PlayerPoint)     //莊家依下列狀況做行動
            {
                timer1.Enabled = true;
            }
            else if (banker.PlayerPoint > you.PlayerPoint)
            {
                MessageBox.Show("莊家獲勝");
                playerchip.losemoney();
                Clear();
            }
            else if (banker.PlayerPoint == you.PlayerPoint)
            {
                MessageBox.Show("和局");
                Clear();
            }                  
        }

        public void lblMoney(int a,int b)     //將結束後的籌碼顯示出來
        {
            lblplayerchip.Text = a.ToString();
            lblmainchip.Text = b.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            you.PlayerCardNo.Clear();
            banker.PlayerCardNo.Clear();
            you.PlayerPoker.Clear();
            banker.PlayerPoker.Clear();
            panPlayer.Controls.Clear();
            panMain.Controls.Clear();
            picPlayer1.Image = null;
            picPlayer2.Image = null;
            picMain1.Image = null;
            picMain2.Image = null;
            lblMain.Text = "";
            lblPlayer.Text = "";
            you.TakeCount = 0;
            banker.TakeCount = 0;
            you.PlayerPoint = 0;
            banker.PlayerPoint = 0;
            btnStart.Enabled = true;
            btnAdd.Enabled = false;
            btnStop.Enabled = false;
            numericUpDown1.Enabled = true;
            numericUpDown1.Value = 0;
        }     

        private void timer1_Tick(object sender, EventArgs e)
        {
            PlayerService _PlayerService = new PlayerService();
            if (banker.PlayerPoint > you.PlayerPoint)          //莊家加牌後要選擇的方法
            {
                timer1.Enabled = false;
                playerchip.compare(banker.PlayerPoint, you.PlayerPoint);
            }
            else if (banker.PlayerPoint == you.PlayerPoint)
            {
                timer1.Enabled = false;
                MessageBox.Show("和局");
                Clear();
            }
            else if (banker.PlayerCardNo.Count >= 5)
            {
                timer1.Enabled = false;
                playerchip.compare(banker.PlayerPoint, you.PlayerPoint);
            }
            else
            {
                //banker.MakerTakeCard(CardDeck);
                _PlayerService.TakeCard(banker,CardDeck);
                _PlayerService.CreatePokerPicture(banker);
                lblMain.Text = banker.PlayerPoint + "";
            }

        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = int.Parse(lblplayerchip.Text);  //限制輸入金額只能小於等於現有的金額
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            GameService _GameService = new GameService();
            PlayerService _PlayerService = new PlayerService();
            numericUpDown1.Enabled = false;
            playerchip.getchip((int)numericUpDown1.Value);       //將玩家輸入的金額傳到gamechip裡
            if(CardDeck.Count <= PlayerCount * 5)
            {
                CardDeck = _GameService.ReStart();
                CardDeck = _GameService.Shuffle(CardDeck);
            }
            //發牌給玩家
            _PlayerService.AddCard(you, CardDeck);
            //發牌給莊家
            _PlayerService.AddCard(banker, CardDeck);
            //you.AddCard(CardDeck);             
            //banker.MakerAddCard(CardDeck);       
            picPlayer1.Image = new Bitmap(Application.StartupPath + "\\撲克牌\\"+you.PlayerCardNo[0].Symbol+ you.PlayerCardNo[0].Value + ".png");
            picPlayer2.Image = new Bitmap(Application.StartupPath + "\\撲克牌\\" + you.PlayerCardNo[1].Symbol + you.PlayerCardNo[1].Value + ".png");
            picMain1.Image = new Bitmap(Application.StartupPath + "\\撲克牌\\" + banker.PlayerCardNo[0].Symbol+ banker.PlayerCardNo[0].Value + ".png");
            picMain2.Image = new Bitmap(Application.StartupPath + "\\撲克牌\\撲克牌背面.jpg");      //莊家蓋一張牌                                                           
            lblPlayer.Text = you.PlayerPoint + "";            
            btnAdd.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            
        }
    }
}
