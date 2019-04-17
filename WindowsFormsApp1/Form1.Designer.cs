namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStarAdd = new System.Windows.Forms.Button();
            this.buttonStarClear = new System.Windows.Forms.Button();
            this.buttonStarRm = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labeRDme = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelLDme = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDis = new System.Windows.Forms.Label();
            this.labelAP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTAS = new System.Windows.Forms.Label();
            this.labelGS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBackGround = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackGround)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.label21);
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            this.splitContainer1.Panel2.Controls.Add(this.label19);
            this.splitContainer1.Panel2.Controls.Add(this.label18);
            this.splitContainer1.Panel2.Controls.Add(this.labeRDme);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.labelLDme);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.labelDis);
            this.splitContainer1.Panel2.Controls.Add(this.labelAP);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.labelTAS);
            this.splitContainer1.Panel2.Controls.Add(this.labelGS);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBackGround);
            this.splitContainer1.Size = new System.Drawing.Size(944, 700);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStarAdd);
            this.groupBox1.Controls.Add(this.buttonStarClear);
            this.groupBox1.Controls.Add(this.buttonStarRm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Star";
            // 
            // buttonStarAdd
            // 
            this.buttonStarAdd.Location = new System.Drawing.Point(15, 23);
            this.buttonStarAdd.Name = "buttonStarAdd";
            this.buttonStarAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonStarAdd.TabIndex = 0;
            this.buttonStarAdd.Text = "add star";
            this.buttonStarAdd.UseVisualStyleBackColor = true;
            this.buttonStarAdd.Click += new System.EventHandler(this.buttonStarAdd_click);
            // 
            // buttonStarClear
            // 
            this.buttonStarClear.Location = new System.Drawing.Point(119, 53);
            this.buttonStarClear.Name = "buttonStarClear";
            this.buttonStarClear.Size = new System.Drawing.Size(75, 23);
            this.buttonStarClear.TabIndex = 2;
            this.buttonStarClear.Text = "clear";
            this.buttonStarClear.UseVisualStyleBackColor = true;
            this.buttonStarClear.Click += new System.EventHandler(this.buttonStarClear_click);
            // 
            // buttonStarRm
            // 
            this.buttonStarRm.Location = new System.Drawing.Point(15, 53);
            this.buttonStarRm.Name = "buttonStarRm";
            this.buttonStarRm.Size = new System.Drawing.Size(75, 23);
            this.buttonStarRm.TabIndex = 1;
            this.buttonStarRm.Text = "rm star";
            this.buttonStarRm.UseVisualStyleBackColor = true;
            this.buttonStarRm.Click += new System.EventHandler(this.buttonStarRm_click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 14F);
            this.label21.ForeColor = System.Drawing.Color.Green;
            this.label21.Location = new System.Drawing.Point(346, 656);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 19);
            this.label21.TabIndex = 41;
            this.label21.Text = "S";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 14F);
            this.label20.ForeColor = System.Drawing.Color.Green;
            this.label20.Location = new System.Drawing.Point(335, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 19);
            this.label20.TabIndex = 40;
            this.label20.Text = "N ↑";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 14F);
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(671, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 19);
            this.label19.TabIndex = 39;
            this.label19.Text = "E";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 14F);
            this.label18.ForeColor = System.Drawing.Color.Green;
            this.label18.Location = new System.Drawing.Point(22, 350);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 19);
            this.label18.TabIndex = 38;
            this.label18.Text = "W";
            // 
            // labeRDme
            // 
            this.labeRDme.AutoSize = true;
            this.labeRDme.Font = new System.Drawing.Font("宋体", 14F);
            this.labeRDme.ForeColor = System.Drawing.Color.Green;
            this.labeRDme.Location = new System.Drawing.Point(655, 662);
            this.labeRDme.Name = "labeRDme";
            this.labeRDme.Size = new System.Drawing.Size(49, 19);
            this.labeRDme.TabIndex = 36;
            this.labeRDme.Text = "44.7";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 11F);
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(615, 666);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "DME";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14F);
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(615, 641);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 19);
            this.label15.TabIndex = 34;
            this.label15.Text = "RKN";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 14F);
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(615, 612);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 19);
            this.label16.TabIndex = 33;
            this.label16.Text = "VOR R";
            // 
            // labelLDme
            // 
            this.labelLDme.AutoSize = true;
            this.labelLDme.Font = new System.Drawing.Font("宋体", 14F);
            this.labelLDme.ForeColor = System.Drawing.Color.Green;
            this.labelLDme.Location = new System.Drawing.Point(49, 663);
            this.labelLDme.Name = "labelLDme";
            this.labelLDme.Size = new System.Drawing.Size(49, 19);
            this.labelLDme.TabIndex = 32;
            this.labelLDme.Text = "44.7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 11F);
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(12, 669);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "DME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14F);
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(12, 641);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "SSB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14F);
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(12, 612);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "VOR L";
            // 
            // labelDis
            // 
            this.labelDis.AutoSize = true;
            this.labelDis.Font = new System.Drawing.Font("宋体", 14F);
            this.labelDis.ForeColor = System.Drawing.Color.White;
            this.labelDis.Location = new System.Drawing.Point(615, 53);
            this.labelDis.Name = "labelDis";
            this.labelDis.Size = new System.Drawing.Size(59, 19);
            this.labelDis.TabIndex = 28;
            this.labelDis.Text = "5.7NM";
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.Font = new System.Drawing.Font("宋体", 14F);
            this.labelAP.ForeColor = System.Drawing.Color.White;
            this.labelAP.Location = new System.Drawing.Point(615, 34);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(89, 19);
            this.labelAP.TabIndex = 27;
            this.labelAP.Text = "1141.03z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.ForeColor = System.Drawing.Color.Violet;
            this.label6.Location = new System.Drawing.Point(615, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "DEP-3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "175  /  5";
            // 
            // labelTAS
            // 
            this.labelTAS.AutoSize = true;
            this.labelTAS.Font = new System.Drawing.Font("宋体", 14F);
            this.labelTAS.ForeColor = System.Drawing.Color.White;
            this.labelTAS.Location = new System.Drawing.Point(140, 5);
            this.labelTAS.Name = "labelTAS";
            this.labelTAS.Size = new System.Drawing.Size(39, 19);
            this.labelTAS.TabIndex = 24;
            this.labelTAS.Text = "263";
            // 
            // labelGS
            // 
            this.labelGS.AutoSize = true;
            this.labelGS.Font = new System.Drawing.Font("宋体", 14F);
            this.labelGS.ForeColor = System.Drawing.Color.White;
            this.labelGS.Location = new System.Drawing.Point(42, 5);
            this.labelGS.Name = "labelGS";
            this.labelGS.Size = new System.Drawing.Size(39, 19);
            this.labelGS.TabIndex = 23;
            this.labelGS.Text = "267";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "TAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "GS";
            // 
            // pictureBackGround
            // 
            this.pictureBackGround.BackColor = System.Drawing.Color.Transparent;
            this.pictureBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBackGround.Name = "pictureBackGround";
            this.pictureBackGround.Size = new System.Drawing.Size(716, 700);
            this.pictureBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackGround.TabIndex = 43;
            this.pictureBackGround.TabStop = false;
            this.pictureBackGround.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBackGround_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timerRefershPic_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "plane";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "300";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "400";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "x:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 700);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "ND - PLAN";
            this.Shown += new System.EventHandler(this.initialWindow);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackGround)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labeRDme;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelLDme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDis;
        private System.Windows.Forms.Label labelAP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTAS;
        private System.Windows.Forms.Label labelGS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStarAdd;
        private System.Windows.Forms.PictureBox pictureBackGround;
        private System.Windows.Forms.Button buttonStarClear;
        private System.Windows.Forms.Button buttonStarRm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

