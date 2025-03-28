﻿using _21點重製.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21點重製.Service
{
    public class PlayerService
    {
        /// <summary>
        /// 開場取得2張撲克牌，並加到 Playercard 手中
        /// </summary>
        /// <param name="ThePlayer"></param>
        /// <param name="PokerList"></param>
        public void AddCard(IPlayer ThePlayer,List<CardNo> PokerList)    
        {
            for (int i = 0; i < 2; i++)
            {
                ThePlayer.PlayerCardNo.Add(PokerList[0]);
                PokerList.RemoveAt(0);    //扣除發牌的張數
                ThePlayer.PlayCardPoint = new CardValue(ThePlayer.PlayerCardNo[i].Value);
                ThePlayer.PlayerPoker.Add(ThePlayer.PlayCardPoint);
                ThePlayer.PlayerPoint += ThePlayer.PlayCardPoint.TrueValue;
            }
            ThePlayer.PlayerPoint = CheckAce(ThePlayer.PlayerPoint, ThePlayer.PlayerPoker);
        }

        /// <summary>
        /// 取得一張撲克牌
        /// </summary>
        /// <param name="ThePlayer"></param>
        /// <param name="PokerList"></param>
        public void TakeCard(IPlayer ThePlayer, List<CardNo> PokerList)
        {
            ThePlayer.PlayerCardNo.Add(PokerList[0]);
            PokerList.RemoveAt(0);
            ThePlayer.PlayerTake = new TakeCard(ThePlayer.panplayer);
            CreatePokerPicture(ThePlayer);
            //CreatePokerPicture(ThePlayer.PlayerCardNo[ThePlayer.PlayerCardNo.Count - 1], ThePlayer.TakeCount, ThePlayer.PlayerPoker);
            
            ThePlayer.TakeCount++;
            ThePlayer.PlayerPoint += ThePlayer.PlayerPoker[ThePlayer.TakeCount].TrueValue;
            ThePlayer.PlayerPoint = CheckAce(ThePlayer.PlayerPoint, ThePlayer.PlayerPoker);
        }

        public int CheckAce(int PlayerPoint, List<CardValue> PlayerPoker)
        {
            if (PlayerPoint > 21)
            {
                for (int i = 0; i < PlayerPoker.Count; i++)
                {
                    if (PlayerPoker[i].TrueValue == 11)
                    {
                        PlayerPoker[i].TrueValue = 1;
                        PlayerPoint -= 10;
                        break;
                    }

                }
            }
            return PlayerPoint;
        }


        public void CreatePokerPicture(IPlayer ThePlayer)   //建立圖片
        {
            PictureBox PokerPictureBox = new PictureBox();
            PokerPictureBox.Size = new Size(104, 146);
            PokerPictureBox.Location = new Point(0 + ThePlayer.TakeCount * 130, 0);
            PokerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CardNo PlayerCard = ThePlayer.PlayerCardNo[ThePlayer.PlayerCardNo.Count - 1];
            PokerPictureBox.Image = new Bitmap(Application.StartupPath + "\\撲克牌\\" + PlayerCard.Symbol + PlayerCard.Value + ".png");

            ThePlayer.panplayer.Controls.Add(PokerPictureBox);
            //CardValue GetCardValue = new CardValue(PlayerCard.Value);
            //ThePlayer.PlayerPoker.Add(GetCardValue);
            CardValue GetCardValue = new CardValue(ThePlayer.PlayerCardNo[ThePlayer.PlayerCardNo.Count - 1].Value);
            ThePlayer.PlayerPoker.Add(GetCardValue);
        }
    }
}
