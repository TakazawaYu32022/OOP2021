﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pelmanism
{
    //カードクラス
    class Card:Button
    {
        //カードの横幅と高さ(W = Width,H = Height)
        private const int SizeW = 50, SizeH = 70;

        //カードの絵柄
        public string Picture { get; set; }
        //カードの状態{true:表,false:裏}
        public bool State { get; set; }
        //カード表面の色
        public Color OpenColor { get; } = Color.White;
        //カード裏面の色
        public Color CloseColor { get; } = Color.LightSeaGreen;

        public Card(string picture)
        {
            Picture = picture;
            State = false;
            Size = new Size(SizeW, SizeH);
            BackColor = CloseColor;
            Font = new Font("MS UI Gothic", 14, FontStyle.Bold);
            Enabled = false;
        }

        //カードをオープンする
        public void Open()
        {
            State = true; //表
            BackColor = OpenColor;
            Text = Picture;//pictureだけど文字が入ってるからstring
            Enabled = false;//カードを表にしたので選択不可になる

        }

        public void Close()
        {
            State = false; //裏
            BackColor = CloseColor;
            Text = "";//裏なので表示しない
            Enabled = true;//カードが裏なので選択可

        }
        //カードをひっくり返す
        public void Turn()
        {
            if (State)
                Close();//裏にする
            else
                Open();//表にする
        }
    }
}
