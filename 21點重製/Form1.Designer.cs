namespace _21點重製
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.picMain1 = new System.Windows.Forms.PictureBox();
            this.picMain2 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panPlayer = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.btnreset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblmainchip = new System.Windows.Forms.Label();
            this.lblplayerchip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnStart.Location = new System.Drawing.Point(1251, 356);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "發牌";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picMain1
            // 
            this.picMain1.Location = new System.Drawing.Point(315, 22);
            this.picMain1.Margin = new System.Windows.Forms.Padding(4);
            this.picMain1.Name = "picMain1";
            this.picMain1.Size = new System.Drawing.Size(139, 182);
            this.picMain1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain1.TabIndex = 2;
            this.picMain1.TabStop = false;
            // 
            // picMain2
            // 
            this.picMain2.BackColor = System.Drawing.Color.Transparent;
            this.picMain2.Location = new System.Drawing.Point(475, 22);
            this.picMain2.Margin = new System.Windows.Forms.Padding(4);
            this.picMain2.Name = "picMain2";
            this.picMain2.Size = new System.Drawing.Size(139, 182);
            this.picMain2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain2.TabIndex = 3;
            this.picMain2.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.picPlayer2.Location = new System.Drawing.Point(475, 569);
            this.picPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(139, 182);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer2.TabIndex = 4;
            this.picPlayer2.TabStop = false;
            // 
            // picPlayer1
            // 
            this.picPlayer1.BackColor = System.Drawing.SystemColors.Control;
            this.picPlayer1.Location = new System.Drawing.Point(315, 569);
            this.picPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(139, 182);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer1.TabIndex = 5;
            this.picPlayer1.TabStop = false;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMain.Location = new System.Drawing.Point(453, 222);
            this.lblMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(31, 35);
            this.lblMain.TabIndex = 6;
            this.lblMain.Text = "0";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPlayer.Location = new System.Drawing.Point(453, 525);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(31, 35);
            this.lblPlayer.TabIndex = 7;
            this.lblPlayer.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnAdd.Location = new System.Drawing.Point(340, 759);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "要牌";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnStop.Location = new System.Drawing.Point(500, 759);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 36);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "停牌";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panPlayer
            // 
            this.panPlayer.Location = new System.Drawing.Point(635, 569);
            this.panPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.panPlayer.Name = "panPlayer";
            this.panPlayer.Size = new System.Drawing.Size(491, 182);
            this.panPlayer.TabIndex = 10;
            // 
            // panMain
            // 
            this.panMain.Location = new System.Drawing.Point(635, 22);
            this.panMain.Margin = new System.Windows.Forms.Padding(4);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(491, 182);
            this.panMain.TabIndex = 11;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnreset.Location = new System.Drawing.Point(1251, 166);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(133, 52);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset 暫時";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("新細明體", 12F);
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(203, 759);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 31);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblmainchip
            // 
            this.lblmainchip.AutoSize = true;
            this.lblmainchip.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblmainchip.Location = new System.Drawing.Point(199, 58);
            this.lblmainchip.Name = "lblmainchip";
            this.lblmainchip.Size = new System.Drawing.Size(62, 24);
            this.lblmainchip.TabIndex = 14;
            this.lblmainchip.Text = "1000";
            // 
            // lblplayerchip
            // 
            this.lblplayerchip.AutoSize = true;
            this.lblplayerchip.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblplayerchip.Location = new System.Drawing.Point(227, 709);
            this.lblplayerchip.Name = "lblplayerchip";
            this.lblplayerchip.Size = new System.Drawing.Size(46, 24);
            this.lblplayerchip.TabIndex = 15;
            this.lblplayerchip.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(199, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "金額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(219, 673);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "金額";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 826);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblplayerchip);
            this.Controls.Add(this.lblmainchip);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panPlayer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.picMain2);
            this.Controls.Add(this.picMain1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picPlayer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picMain1;
        private System.Windows.Forms.PictureBox picMain2;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panPlayer;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblmainchip;
        private System.Windows.Forms.Label lblplayerchip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

