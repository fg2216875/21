using _21點重製.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        
        List<CardNo> CardDeck = new List<CardNo>();    //建立一組撲克牌
        Player you;                  //宣告一名玩家
        Banker banker;             //宣告一名莊家
        private void Form1_Load(object sender, EventArgs e)
        {
            GameService _GameService = new GameService();
            //執行時先建立一副撲克牌
            CardDeck = _GameService.ReStart();
            CardDeck = _GameService.Shuffle(CardDeck);

            you = new Player(panPlayer);          //建立玩家
            banker = new Banker(panMain);       //建立莊家
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PlayerService _PlayerService = new PlayerService();
            GameService _GameService = new GameService();
            _PlayerService.TakeCard(you, CardDeck);
            _PlayerService.CreatePokerPicture(you);

            lblPlayer.Text = you.PlayerPoint.ToString();
            if (you.PlayerCardNo.Count == 5)
            {
                btnAdd.Enabled = false;    //先限定最多拿5張
            }
            if(you.PlayerPoint > 21)
            {
                MessageBox.Show("超過21點了!");
                _GameService.LoseMoney(banker, you, numericUpDown1.Value);
                lblMoney(banker.PlayerChip, you.PlayerChip);
                Clear();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            string path = dir.Parent.Parent.FullName.ToString();
            string fullPath = Path.Combine(path, "Picture", banker.PlayerCardNo[1].Symbol + banker.PlayerCardNo[1].Value.ToString() + ".png");
            picMain2.Image = new Bitmap(fullPath);

            lblMain.Text = banker.PlayerPoint.ToString();
            btnAdd.Enabled = false;
            btnStop.Enabled = false;
            timer1.Enabled = true;
        }

        public void lblMoney(int BankerChip,int PlayerChip)     //將結束後的籌碼顯示出來
        {
            lblplayerchip.Text = PlayerChip.ToString();
            lblmainchip.Text = BankerChip.ToString();
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
            GameService _GameService = new GameService();
            if (banker.PlayerPoint > 21)
            {
                timer1.Enabled = false;
                MessageBox.Show("玩家獲勝!");
                _GameService.WinMoney(banker, you, numericUpDown1.Value);
                lblMoney(banker.PlayerChip, you.PlayerChip);
                Clear();
            }
            else if (banker.PlayerPoint > you.PlayerPoint)          //莊家加牌後要選擇的方法
            {
                timer1.Enabled = false;   
                _GameService.LoseMoney(banker, you, numericUpDown1.Value);
                lblMoney(banker.PlayerChip, you.PlayerChip);
                MessageBox.Show("莊家獲勝!");
                Clear();
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
                string ShowMessage = "";
                if (banker.PlayerPoint > 21 || banker.PlayerPoint < you.PlayerPoint)
                {
                    ShowMessage = "玩家獲勝";
                    _GameService.WinMoney(banker, you, numericUpDown1.Value);
                    lblMoney(banker.PlayerChip, you.PlayerChip);
                }
                else if (banker.PlayerPoint > you.PlayerPoint)
                {
                    ShowMessage = "莊家獲勝!";
                    _GameService.LoseMoney(banker, you, numericUpDown1.Value);
                    lblMoney(banker.PlayerChip, you.PlayerChip);
                }
                else if (banker.PlayerPoint == you.PlayerPoint)
                {
                    ShowMessage = "和局";
                }
                MessageBox.Show(ShowMessage);
                Clear();
            }
            else
            {
                _PlayerService.TakeCard(banker,CardDeck);
                _PlayerService.CreatePokerPicture(banker);
                lblMain.Text = banker.PlayerPoint.ToString();
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
            int PlayerCount = 2;
            numericUpDown1.Enabled = false;
            //檢查剩餘的撲克牌數量是否有超過一定數量
            if(CardDeck.Count <= PlayerCount * 5)
            {
                CardDeck = _GameService.ReStart();
                CardDeck = _GameService.Shuffle(CardDeck);
            }
            //發牌給玩家
            _PlayerService.AddCard(you, CardDeck);
            //發牌給莊家
            _PlayerService.AddCard(banker, CardDeck);
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            string path = dir.Parent.Parent.FullName.ToString();
            string fullPath = Path.Combine(path, "Picture", you.PlayerCardNo[0].Symbol + you.PlayerCardNo[0].Value.ToString() + ".png");
            picPlayer1.Image = new Bitmap(fullPath);
            fullPath = Path.Combine(path, "Picture", you.PlayerCardNo[1].Symbol + you.PlayerCardNo[1].Value.ToString() + ".png");
            picPlayer2.Image = new Bitmap(fullPath);
            fullPath = Path.Combine(path, "Picture", banker.PlayerCardNo[0].Symbol + banker.PlayerCardNo[0].Value.ToString() + ".png");
            picMain1.Image = new Bitmap(fullPath);
            //莊家蓋一張牌     
            fullPath = Path.Combine(path, "Picture", "撲克牌背面.jpg");
            picMain2.Image = new Bitmap(fullPath);                                                            
            lblPlayer.Text = you.PlayerPoint.ToString();            
            btnAdd.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;       
        }
    }
}
