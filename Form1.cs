using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Four_In_A_Line
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X turn; false Y turn
        int turn_count = 0;
        static String player1, player2;
        bool against_computer1 = false;
        bool against_computer2 = false;


        public Form1()
        {
            InitializeComponent();
            A1.Enabled = A2.Enabled = A3.Enabled = A4.Enabled = A5.Enabled = A6.Enabled = A7.Enabled = false;
            B1.Enabled = B2.Enabled = B3.Enabled = B4.Enabled = B5.Enabled = B6.Enabled = B7.Enabled = false;
            C1.Enabled = C2.Enabled = C3.Enabled = C4.Enabled = C5.Enabled = C6.Enabled = C7.Enabled = false;
            D1.Enabled = D2.Enabled = D3.Enabled = D4.Enabled = D5.Enabled = D6.Enabled = D7.Enabled = false;
            E1.Enabled = E2.Enabled = E3.Enabled = E4.Enabled = E5.Enabled = E6.Enabled = E7.Enabled = false;
            F1.Enabled = F2.Enabled = F3.Enabled = F4.Enabled = F5.Enabled = F6.Enabled = F7.Enabled = true;
            label4.Text = player1;
            label6.Text = player2;
            check_computer1();
            check_computer2();
            button2.Visible = false;
        }

        public static void setPlayerNames(String name1, String name2)
        {
            player1 = name1;
            player2 = name2;
        }

        private void check_computer1()
        {
            if (player2 == "Computer")
                against_computer1 = true;
            else
                against_computer1 = false;
        }

        private void check_computer2()
        {
            if (player1 == "Computer")
            {
                against_computer2 = true;
                F3.BackColor = Color.LightGreen;
                F3.Enabled = false;
                E3.Enabled = true;
                turn = false;
            }
            else
                against_computer2 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vs1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.G_Win_Count = new System.Windows.Forms.Label();
            this.Draw_Count = new System.Windows.Forms.Label();
            this.P_Win_Count = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.F7 = new RoundButton();
            this.roundButton72 = new RoundButton();
            this.F6 = new RoundButton();
            this.roundButton74 = new RoundButton();
            this.F5 = new RoundButton();
            this.roundButton76 = new RoundButton();
            this.F4 = new RoundButton();
            this.roundButton78 = new RoundButton();
            this.F3 = new RoundButton();
            this.roundButton80 = new RoundButton();
            this.F2 = new RoundButton();
            this.roundButton82 = new RoundButton();
            this.F1 = new RoundButton();
            this.roundButton84 = new RoundButton();
            this.E7 = new RoundButton();
            this.roundButton58 = new RoundButton();
            this.E6 = new RoundButton();
            this.roundButton60 = new RoundButton();
            this.E5 = new RoundButton();
            this.roundButton62 = new RoundButton();
            this.E4 = new RoundButton();
            this.roundButton64 = new RoundButton();
            this.E3 = new RoundButton();
            this.roundButton66 = new RoundButton();
            this.E2 = new RoundButton();
            this.roundButton68 = new RoundButton();
            this.E1 = new RoundButton();
            this.roundButton70 = new RoundButton();
            this.D7 = new RoundButton();
            this.roundButton44 = new RoundButton();
            this.D6 = new RoundButton();
            this.roundButton46 = new RoundButton();
            this.D5 = new RoundButton();
            this.roundButton48 = new RoundButton();
            this.D4 = new RoundButton();
            this.roundButton50 = new RoundButton();
            this.D3 = new RoundButton();
            this.roundButton52 = new RoundButton();
            this.D2 = new RoundButton();
            this.roundButton54 = new RoundButton();
            this.D1 = new RoundButton();
            this.roundButton56 = new RoundButton();
            this.C7 = new RoundButton();
            this.roundButton30 = new RoundButton();
            this.C6 = new RoundButton();
            this.roundButton32 = new RoundButton();
            this.C5 = new RoundButton();
            this.roundButton34 = new RoundButton();
            this.C4 = new RoundButton();
            this.roundButton36 = new RoundButton();
            this.C3 = new RoundButton();
            this.roundButton38 = new RoundButton();
            this.C2 = new RoundButton();
            this.roundButton40 = new RoundButton();
            this.C1 = new RoundButton();
            this.roundButton42 = new RoundButton();
            this.B7 = new RoundButton();
            this.roundButton16 = new RoundButton();
            this.B6 = new RoundButton();
            this.roundButton18 = new RoundButton();
            this.B5 = new RoundButton();
            this.roundButton20 = new RoundButton();
            this.B4 = new RoundButton();
            this.roundButton22 = new RoundButton();
            this.B3 = new RoundButton();
            this.roundButton24 = new RoundButton();
            this.B2 = new RoundButton();
            this.roundButton26 = new RoundButton();
            this.B1 = new RoundButton();
            this.roundButton28 = new RoundButton();
            this.A7 = new RoundButton();
            this.roundButton14 = new RoundButton();
            this.A6 = new RoundButton();
            this.roundButton12 = new RoundButton();
            this.A5 = new RoundButton();
            this.roundButton10 = new RoundButton();
            this.A4 = new RoundButton();
            this.roundButton8 = new RoundButton();
            this.A3 = new RoundButton();
            this.roundButton6 = new RoundButton();
            this.A2 = new RoundButton();
            this.roundButton4 = new RoundButton();
            this.A1 = new RoundButton();
            this.roundButton2 = new RoundButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Four In A Line :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetScoreToolStripMenuItem,
            this.changeModeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetScoreToolStripMenuItem
            // 
            this.resetScoreToolStripMenuItem.Name = "resetScoreToolStripMenuItem";
            this.resetScoreToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.resetScoreToolStripMenuItem.Text = "Reset Score";
            this.resetScoreToolStripMenuItem.Click += new System.EventHandler(this.resetScoreToolStripMenuItem_Click);
            // 
            // changeModeToolStripMenuItem
            // 
            this.changeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vsComputerToolStripMenuItem,
            this.vs1ToolStripMenuItem});
            this.changeModeToolStripMenuItem.Name = "changeModeToolStripMenuItem";
            this.changeModeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.changeModeToolStripMenuItem.Text = "Change Mode";
            // 
            // vsComputerToolStripMenuItem
            // 
            this.vsComputerToolStripMenuItem.Name = "vsComputerToolStripMenuItem";
            this.vsComputerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.vsComputerToolStripMenuItem.Text = "1 vs Computer";
            this.vsComputerToolStripMenuItem.Click += new System.EventHandler(this.vsComputerToolStripMenuItem_Click);
            // 
            // vs1ToolStripMenuItem
            // 
            this.vs1ToolStripMenuItem.Name = "vs1ToolStripMenuItem";
            this.vs1ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.vs1ToolStripMenuItem.Text = "1 vs 1";
            this.vs1ToolStripMenuItem.Click += new System.EventHandler(this.vs1ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.tipsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // tipsToolStripMenuItem
            // 
            this.tipsToolStripMenuItem.Name = "tipsToolStripMenuItem";
            this.tipsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.tipsToolStripMenuItem.Text = "Tips";
            this.tipsToolStripMenuItem.Click += new System.EventHandler(this.tipsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(303, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "a game of strategy";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Four_In_A_Line.Properties.Resources.old_paper;
            this.pictureBox5.Location = new System.Drawing.Point(769, 240);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(134, 210);
            this.pictureBox5.TabIndex = 95;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Four_In_A_Line.Properties.Resources.rsz_sword;
            this.pictureBox4.Location = new System.Drawing.Point(881, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 79);
            this.pictureBox4.TabIndex = 94;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Four_In_A_Line.Properties.Resources.rsz_sword;
            this.pictureBox3.Location = new System.Drawing.Point(769, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 79);
            this.pictureBox3.TabIndex = 93;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::Four_In_A_Line.Properties.Resources.bumpy_aqua_background;
            this.pictureBox2.Location = new System.Drawing.Point(12, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(734, 547);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(805, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 96;
            this.label2.Text = "Score";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(779, 258);
            this.label4.MaximumSize = new System.Drawing.Size(113, 16);
            this.label4.MinimumSize = new System.Drawing.Size(113, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 97;
            this.label4.Text = "Green Win Count";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(797, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "Draw Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 379);
            this.label6.MaximumSize = new System.Drawing.Size(107, 16);
            this.label6.MinimumSize = new System.Drawing.Size(107, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 99;
            this.label6.Text = "Pink Win Count";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // G_Win_Count
            // 
            this.G_Win_Count.AutoSize = true;
            this.G_Win_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.G_Win_Count.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_Win_Count.Location = new System.Drawing.Point(828, 281);
            this.G_Win_Count.Name = "G_Win_Count";
            this.G_Win_Count.Size = new System.Drawing.Size(15, 16);
            this.G_Win_Count.TabIndex = 100;
            this.G_Win_Count.Text = "0";
            // 
            // Draw_Count
            // 
            this.Draw_Count.AutoSize = true;
            this.Draw_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Draw_Count.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw_Count.Location = new System.Drawing.Point(828, 346);
            this.Draw_Count.Name = "Draw_Count";
            this.Draw_Count.Size = new System.Drawing.Size(15, 16);
            this.Draw_Count.TabIndex = 101;
            this.Draw_Count.Text = "0";
            // 
            // P_Win_Count
            // 
            this.P_Win_Count.AutoSize = true;
            this.P_Win_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.P_Win_Count.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_Win_Count.Location = new System.Drawing.Point(828, 407);
            this.P_Win_Count.Name = "P_Win_Count";
            this.P_Win_Count.Size = new System.Drawing.Size(15, 16);
            this.P_Win_Count.TabIndex = 102;
            this.P_Win_Count.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(773, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 49);
            this.button2.TabIndex = 103;
            this.button2.Text = "Play again?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // F7
            // 
            this.F7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.F7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.F7.FlatAppearance.BorderSize = 5;
            this.F7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.F7.Location = new System.Drawing.Point(643, 534);
            this.F7.Name = "F7";
            this.F7.Size = new System.Drawing.Size(66, 66);
            this.F7.TabIndex = 91;
            this.F7.UseVisualStyleBackColor = false;
            this.F7.Click += new System.EventHandler(this.button_click7);
            this.F7.MouseEnter += new System.EventHandler(this.button_enter);
            this.F7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton72
            // 
            this.roundButton72.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton72.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton72.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton72.FlatAppearance.BorderSize = 5;
            this.roundButton72.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton72.Location = new System.Drawing.Point(641, 532);
            this.roundButton72.Name = "roundButton72";
            this.roundButton72.Size = new System.Drawing.Size(70, 70);
            this.roundButton72.TabIndex = 92;
            this.roundButton72.UseVisualStyleBackColor = false;
            // 
            // F6
            // 
            this.F6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.F6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.F6.FlatAppearance.BorderSize = 5;
            this.F6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.F6.Location = new System.Drawing.Point(545, 534);
            this.F6.Name = "F6";
            this.F6.Size = new System.Drawing.Size(66, 66);
            this.F6.TabIndex = 89;
            this.F6.UseVisualStyleBackColor = false;
            this.F6.Click += new System.EventHandler(this.button_click6);
            this.F6.MouseEnter += new System.EventHandler(this.button_enter);
            this.F6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton74
            // 
            this.roundButton74.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton74.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton74.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton74.FlatAppearance.BorderSize = 5;
            this.roundButton74.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton74.Location = new System.Drawing.Point(543, 532);
            this.roundButton74.Name = "roundButton74";
            this.roundButton74.Size = new System.Drawing.Size(70, 70);
            this.roundButton74.TabIndex = 90;
            this.roundButton74.UseVisualStyleBackColor = false;
            // 
            // F5
            // 
            this.F5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.F5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.F5.FlatAppearance.BorderSize = 5;
            this.F5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.F5.Location = new System.Drawing.Point(446, 536);
            this.F5.Name = "F5";
            this.F5.Size = new System.Drawing.Size(66, 66);
            this.F5.TabIndex = 87;
            this.F5.UseVisualStyleBackColor = false;
            this.F5.Click += new System.EventHandler(this.button_click5);
            this.F5.MouseEnter += new System.EventHandler(this.button_enter);
            this.F5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton76
            // 
            this.roundButton76.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton76.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton76.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton76.FlatAppearance.BorderSize = 5;
            this.roundButton76.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton76.Location = new System.Drawing.Point(444, 534);
            this.roundButton76.Name = "roundButton76";
            this.roundButton76.Size = new System.Drawing.Size(70, 70);
            this.roundButton76.TabIndex = 88;
            this.roundButton76.UseVisualStyleBackColor = false;
            // 
            // F4
            // 
            this.F4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.F4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.F4.FlatAppearance.BorderSize = 5;
            this.F4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.F4.Location = new System.Drawing.Point(347, 534);
            this.F4.Name = "F4";
            this.F4.Size = new System.Drawing.Size(66, 66);
            this.F4.TabIndex = 85;
            this.F4.UseVisualStyleBackColor = false;
            this.F4.Click += new System.EventHandler(this.button_click4);
            this.F4.MouseEnter += new System.EventHandler(this.button_enter);
            this.F4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton78
            // 
            this.roundButton78.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton78.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton78.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton78.FlatAppearance.BorderSize = 5;
            this.roundButton78.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton78.Location = new System.Drawing.Point(345, 532);
            this.roundButton78.Name = "roundButton78";
            this.roundButton78.Size = new System.Drawing.Size(70, 70);
            this.roundButton78.TabIndex = 86;
            this.roundButton78.UseVisualStyleBackColor = false;
            // 
            // F3
            // 
            this.F3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.F3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.F3.FlatAppearance.BorderSize = 5;
            this.F3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.F3.Location = new System.Drawing.Point(248, 536);
            this.F3.Name = "F3";
            this.F3.Size = new System.Drawing.Size(66, 66);
            this.F3.TabIndex = 83;
            this.F3.UseVisualStyleBackColor = false;
            this.F3.Click += new System.EventHandler(this.button_click3);
            this.F3.MouseEnter += new System.EventHandler(this.button_enter);
            this.F3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton80
            // 
            this.roundButton80.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton80.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton80.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton80.FlatAppearance.BorderSize = 5;
            this.roundButton80.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton80.Location = new System.Drawing.Point(246, 534);
            this.roundButton80.Name = "roundButton80";
            this.roundButton80.Size = new System.Drawing.Size(70, 70);
            this.roundButton80.TabIndex = 84;
            this.roundButton80.UseVisualStyleBackColor = false;
            // 
            // F2
            // 
            this.F2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.F2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.F2.FlatAppearance.BorderSize = 5;
            this.F2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.F2.Location = new System.Drawing.Point(148, 536);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(66, 66);
            this.F2.TabIndex = 81;
            this.F2.UseVisualStyleBackColor = false;
            this.F2.Click += new System.EventHandler(this.button_click2);
            this.F2.MouseEnter += new System.EventHandler(this.button_enter);
            this.F2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton82
            // 
            this.roundButton82.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton82.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton82.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton82.FlatAppearance.BorderSize = 5;
            this.roundButton82.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton82.Location = new System.Drawing.Point(146, 534);
            this.roundButton82.Name = "roundButton82";
            this.roundButton82.Size = new System.Drawing.Size(70, 70);
            this.roundButton82.TabIndex = 82;
            this.roundButton82.UseVisualStyleBackColor = false;
            // 
            // F1
            // 
            this.F1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.F1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.F1.FlatAppearance.BorderSize = 5;
            this.F1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.F1.Location = new System.Drawing.Point(50, 534);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(66, 66);
            this.F1.TabIndex = 79;
            this.F1.UseVisualStyleBackColor = false;
            this.F1.Click += new System.EventHandler(this.button_click1);
            this.F1.MouseEnter += new System.EventHandler(this.button_enter);
            this.F1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton84
            // 
            this.roundButton84.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton84.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton84.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton84.FlatAppearance.BorderSize = 5;
            this.roundButton84.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton84.Location = new System.Drawing.Point(48, 532);
            this.roundButton84.Name = "roundButton84";
            this.roundButton84.Size = new System.Drawing.Size(70, 70);
            this.roundButton84.TabIndex = 80;
            this.roundButton84.UseVisualStyleBackColor = false;
            // 
            // E7
            // 
            this.E7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.E7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.E7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E7.FlatAppearance.BorderSize = 5;
            this.E7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.E7.Location = new System.Drawing.Point(643, 448);
            this.E7.Name = "E7";
            this.E7.Size = new System.Drawing.Size(66, 66);
            this.E7.TabIndex = 77;
            this.E7.UseVisualStyleBackColor = false;
            this.E7.Click += new System.EventHandler(this.button_click7);
            this.E7.MouseEnter += new System.EventHandler(this.button_enter);
            this.E7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton58
            // 
            this.roundButton58.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton58.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton58.FlatAppearance.BorderSize = 5;
            this.roundButton58.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton58.Location = new System.Drawing.Point(641, 446);
            this.roundButton58.Name = "roundButton58";
            this.roundButton58.Size = new System.Drawing.Size(70, 70);
            this.roundButton58.TabIndex = 78;
            this.roundButton58.UseVisualStyleBackColor = false;
            // 
            // E6
            // 
            this.E6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.E6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.E6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E6.FlatAppearance.BorderSize = 5;
            this.E6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.E6.Location = new System.Drawing.Point(545, 448);
            this.E6.Name = "E6";
            this.E6.Size = new System.Drawing.Size(66, 66);
            this.E6.TabIndex = 75;
            this.E6.UseVisualStyleBackColor = false;
            this.E6.Click += new System.EventHandler(this.button_click6);
            this.E6.MouseEnter += new System.EventHandler(this.button_enter);
            this.E6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton60
            // 
            this.roundButton60.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton60.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton60.FlatAppearance.BorderSize = 5;
            this.roundButton60.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton60.Location = new System.Drawing.Point(543, 446);
            this.roundButton60.Name = "roundButton60";
            this.roundButton60.Size = new System.Drawing.Size(70, 70);
            this.roundButton60.TabIndex = 76;
            this.roundButton60.UseVisualStyleBackColor = false;
            // 
            // E5
            // 
            this.E5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.E5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.E5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E5.FlatAppearance.BorderSize = 5;
            this.E5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.E5.Location = new System.Drawing.Point(446, 450);
            this.E5.Name = "E5";
            this.E5.Size = new System.Drawing.Size(66, 66);
            this.E5.TabIndex = 73;
            this.E5.UseVisualStyleBackColor = false;
            this.E5.Click += new System.EventHandler(this.button_click5);
            this.E5.MouseEnter += new System.EventHandler(this.button_enter);
            this.E5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton62
            // 
            this.roundButton62.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton62.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton62.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton62.FlatAppearance.BorderSize = 5;
            this.roundButton62.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton62.Location = new System.Drawing.Point(444, 448);
            this.roundButton62.Name = "roundButton62";
            this.roundButton62.Size = new System.Drawing.Size(70, 70);
            this.roundButton62.TabIndex = 74;
            this.roundButton62.UseVisualStyleBackColor = false;
            // 
            // E4
            // 
            this.E4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.E4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.E4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E4.FlatAppearance.BorderSize = 5;
            this.E4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.E4.Location = new System.Drawing.Point(347, 448);
            this.E4.Name = "E4";
            this.E4.Size = new System.Drawing.Size(66, 66);
            this.E4.TabIndex = 71;
            this.E4.UseVisualStyleBackColor = false;
            this.E4.Click += new System.EventHandler(this.button_click4);
            this.E4.MouseEnter += new System.EventHandler(this.button_enter);
            this.E4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton64
            // 
            this.roundButton64.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton64.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton64.FlatAppearance.BorderSize = 5;
            this.roundButton64.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton64.Location = new System.Drawing.Point(345, 446);
            this.roundButton64.Name = "roundButton64";
            this.roundButton64.Size = new System.Drawing.Size(70, 70);
            this.roundButton64.TabIndex = 72;
            this.roundButton64.UseVisualStyleBackColor = false;
            // 
            // E3
            // 
            this.E3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.E3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.E3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E3.FlatAppearance.BorderSize = 5;
            this.E3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.E3.Location = new System.Drawing.Point(248, 450);
            this.E3.Name = "E3";
            this.E3.Size = new System.Drawing.Size(66, 66);
            this.E3.TabIndex = 69;
            this.E3.UseVisualStyleBackColor = false;
            this.E3.Click += new System.EventHandler(this.button_click3);
            this.E3.MouseEnter += new System.EventHandler(this.button_enter);
            this.E3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton66
            // 
            this.roundButton66.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton66.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton66.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton66.FlatAppearance.BorderSize = 5;
            this.roundButton66.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton66.Location = new System.Drawing.Point(246, 448);
            this.roundButton66.Name = "roundButton66";
            this.roundButton66.Size = new System.Drawing.Size(70, 70);
            this.roundButton66.TabIndex = 70;
            this.roundButton66.UseVisualStyleBackColor = false;
            // 
            // E2
            // 
            this.E2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.E2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.E2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E2.FlatAppearance.BorderSize = 5;
            this.E2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.E2.Location = new System.Drawing.Point(148, 450);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(66, 66);
            this.E2.TabIndex = 67;
            this.E2.UseVisualStyleBackColor = false;
            this.E2.Click += new System.EventHandler(this.button_click2);
            this.E2.MouseEnter += new System.EventHandler(this.button_enter);
            this.E2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton68
            // 
            this.roundButton68.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton68.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton68.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton68.FlatAppearance.BorderSize = 5;
            this.roundButton68.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton68.Location = new System.Drawing.Point(146, 448);
            this.roundButton68.Name = "roundButton68";
            this.roundButton68.Size = new System.Drawing.Size(70, 70);
            this.roundButton68.TabIndex = 68;
            this.roundButton68.UseVisualStyleBackColor = false;
            // 
            // E1
            // 
            this.E1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.E1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.E1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E1.FlatAppearance.BorderSize = 5;
            this.E1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.E1.Location = new System.Drawing.Point(50, 448);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(66, 66);
            this.E1.TabIndex = 65;
            this.E1.UseVisualStyleBackColor = false;
            this.E1.Click += new System.EventHandler(this.button_click1);
            this.E1.MouseEnter += new System.EventHandler(this.button_enter);
            this.E1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton70
            // 
            this.roundButton70.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton70.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton70.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton70.FlatAppearance.BorderSize = 5;
            this.roundButton70.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton70.Location = new System.Drawing.Point(48, 446);
            this.roundButton70.Name = "roundButton70";
            this.roundButton70.Size = new System.Drawing.Size(70, 70);
            this.roundButton70.TabIndex = 66;
            this.roundButton70.UseVisualStyleBackColor = false;
            // 
            // D7
            // 
            this.D7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.D7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D7.FlatAppearance.BorderSize = 5;
            this.D7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D7.Location = new System.Drawing.Point(641, 364);
            this.D7.Name = "D7";
            this.D7.Size = new System.Drawing.Size(66, 66);
            this.D7.TabIndex = 63;
            this.D7.UseVisualStyleBackColor = false;
            this.D7.Click += new System.EventHandler(this.button_click7);
            this.D7.MouseEnter += new System.EventHandler(this.button_enter);
            this.D7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton44
            // 
            this.roundButton44.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton44.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton44.FlatAppearance.BorderSize = 5;
            this.roundButton44.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton44.Location = new System.Drawing.Point(639, 362);
            this.roundButton44.Name = "roundButton44";
            this.roundButton44.Size = new System.Drawing.Size(70, 70);
            this.roundButton44.TabIndex = 64;
            this.roundButton44.UseVisualStyleBackColor = false;
            // 
            // D6
            // 
            this.D6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.D6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D6.FlatAppearance.BorderSize = 5;
            this.D6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D6.Location = new System.Drawing.Point(543, 364);
            this.D6.Name = "D6";
            this.D6.Size = new System.Drawing.Size(66, 66);
            this.D6.TabIndex = 61;
            this.D6.UseVisualStyleBackColor = false;
            this.D6.Click += new System.EventHandler(this.button_click6);
            this.D6.MouseEnter += new System.EventHandler(this.button_enter);
            this.D6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton46
            // 
            this.roundButton46.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton46.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton46.FlatAppearance.BorderSize = 5;
            this.roundButton46.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton46.Location = new System.Drawing.Point(541, 362);
            this.roundButton46.Name = "roundButton46";
            this.roundButton46.Size = new System.Drawing.Size(70, 70);
            this.roundButton46.TabIndex = 62;
            this.roundButton46.UseVisualStyleBackColor = false;
            // 
            // D5
            // 
            this.D5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.D5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D5.FlatAppearance.BorderSize = 5;
            this.D5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D5.Location = new System.Drawing.Point(444, 366);
            this.D5.Name = "D5";
            this.D5.Size = new System.Drawing.Size(66, 66);
            this.D5.TabIndex = 59;
            this.D5.UseVisualStyleBackColor = false;
            this.D5.Click += new System.EventHandler(this.button_click5);
            this.D5.MouseEnter += new System.EventHandler(this.button_enter);
            this.D5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton48
            // 
            this.roundButton48.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton48.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton48.FlatAppearance.BorderSize = 5;
            this.roundButton48.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton48.Location = new System.Drawing.Point(442, 364);
            this.roundButton48.Name = "roundButton48";
            this.roundButton48.Size = new System.Drawing.Size(70, 70);
            this.roundButton48.TabIndex = 60;
            this.roundButton48.UseVisualStyleBackColor = false;
            // 
            // D4
            // 
            this.D4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.D4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D4.FlatAppearance.BorderSize = 5;
            this.D4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D4.Location = new System.Drawing.Point(345, 364);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(66, 66);
            this.D4.TabIndex = 57;
            this.D4.UseVisualStyleBackColor = false;
            this.D4.Click += new System.EventHandler(this.button_click4);
            this.D4.MouseEnter += new System.EventHandler(this.button_enter);
            this.D4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton50
            // 
            this.roundButton50.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton50.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton50.FlatAppearance.BorderSize = 5;
            this.roundButton50.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton50.Location = new System.Drawing.Point(343, 362);
            this.roundButton50.Name = "roundButton50";
            this.roundButton50.Size = new System.Drawing.Size(70, 70);
            this.roundButton50.TabIndex = 58;
            this.roundButton50.UseVisualStyleBackColor = false;
            // 
            // D3
            // 
            this.D3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.D3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D3.FlatAppearance.BorderSize = 5;
            this.D3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D3.Location = new System.Drawing.Point(246, 366);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(66, 66);
            this.D3.TabIndex = 55;
            this.D3.UseVisualStyleBackColor = false;
            this.D3.Click += new System.EventHandler(this.button_click3);
            this.D3.MouseEnter += new System.EventHandler(this.button_enter);
            this.D3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton52
            // 
            this.roundButton52.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton52.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton52.FlatAppearance.BorderSize = 5;
            this.roundButton52.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton52.Location = new System.Drawing.Point(244, 364);
            this.roundButton52.Name = "roundButton52";
            this.roundButton52.Size = new System.Drawing.Size(70, 70);
            this.roundButton52.TabIndex = 56;
            this.roundButton52.UseVisualStyleBackColor = false;
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.D2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D2.FlatAppearance.BorderSize = 5;
            this.D2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D2.Location = new System.Drawing.Point(146, 366);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(66, 66);
            this.D2.TabIndex = 53;
            this.D2.UseVisualStyleBackColor = false;
            this.D2.Click += new System.EventHandler(this.button_click2);
            this.D2.MouseEnter += new System.EventHandler(this.button_enter);
            this.D2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton54
            // 
            this.roundButton54.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton54.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton54.FlatAppearance.BorderSize = 5;
            this.roundButton54.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton54.Location = new System.Drawing.Point(144, 364);
            this.roundButton54.Name = "roundButton54";
            this.roundButton54.Size = new System.Drawing.Size(70, 70);
            this.roundButton54.TabIndex = 54;
            this.roundButton54.UseVisualStyleBackColor = false;
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.D1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D1.FlatAppearance.BorderSize = 5;
            this.D1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D1.Location = new System.Drawing.Point(48, 364);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(66, 66);
            this.D1.TabIndex = 51;
            this.D1.UseVisualStyleBackColor = false;
            this.D1.Click += new System.EventHandler(this.button_click1);
            this.D1.MouseEnter += new System.EventHandler(this.button_enter);
            this.D1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton56
            // 
            this.roundButton56.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton56.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton56.FlatAppearance.BorderSize = 5;
            this.roundButton56.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton56.Location = new System.Drawing.Point(46, 362);
            this.roundButton56.Name = "roundButton56";
            this.roundButton56.Size = new System.Drawing.Size(70, 70);
            this.roundButton56.TabIndex = 52;
            this.roundButton56.UseVisualStyleBackColor = false;
            // 
            // C7
            // 
            this.C7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.C7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C7.FlatAppearance.BorderSize = 5;
            this.C7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.C7.Location = new System.Drawing.Point(639, 279);
            this.C7.Name = "C7";
            this.C7.Size = new System.Drawing.Size(66, 66);
            this.C7.TabIndex = 49;
            this.C7.UseVisualStyleBackColor = false;
            this.C7.Click += new System.EventHandler(this.button_click7);
            this.C7.MouseEnter += new System.EventHandler(this.button_enter);
            this.C7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton30
            // 
            this.roundButton30.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton30.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton30.FlatAppearance.BorderSize = 5;
            this.roundButton30.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton30.Location = new System.Drawing.Point(637, 277);
            this.roundButton30.Name = "roundButton30";
            this.roundButton30.Size = new System.Drawing.Size(70, 70);
            this.roundButton30.TabIndex = 50;
            this.roundButton30.UseVisualStyleBackColor = false;
            // 
            // C6
            // 
            this.C6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.C6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C6.FlatAppearance.BorderSize = 5;
            this.C6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.C6.Location = new System.Drawing.Point(541, 279);
            this.C6.Name = "C6";
            this.C6.Size = new System.Drawing.Size(66, 66);
            this.C6.TabIndex = 47;
            this.C6.UseVisualStyleBackColor = false;
            this.C6.Click += new System.EventHandler(this.button_click6);
            this.C6.MouseEnter += new System.EventHandler(this.button_enter);
            this.C6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton32
            // 
            this.roundButton32.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton32.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton32.FlatAppearance.BorderSize = 5;
            this.roundButton32.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton32.Location = new System.Drawing.Point(539, 277);
            this.roundButton32.Name = "roundButton32";
            this.roundButton32.Size = new System.Drawing.Size(70, 70);
            this.roundButton32.TabIndex = 48;
            this.roundButton32.UseVisualStyleBackColor = false;
            // 
            // C5
            // 
            this.C5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.C5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C5.FlatAppearance.BorderSize = 5;
            this.C5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.C5.Location = new System.Drawing.Point(442, 281);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(66, 66);
            this.C5.TabIndex = 45;
            this.C5.UseVisualStyleBackColor = false;
            this.C5.Click += new System.EventHandler(this.button_click5);
            this.C5.MouseEnter += new System.EventHandler(this.button_enter);
            this.C5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton34
            // 
            this.roundButton34.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton34.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton34.FlatAppearance.BorderSize = 5;
            this.roundButton34.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton34.Location = new System.Drawing.Point(440, 279);
            this.roundButton34.Name = "roundButton34";
            this.roundButton34.Size = new System.Drawing.Size(70, 70);
            this.roundButton34.TabIndex = 46;
            this.roundButton34.UseVisualStyleBackColor = false;
            // 
            // C4
            // 
            this.C4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.C4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C4.FlatAppearance.BorderSize = 5;
            this.C4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.C4.Location = new System.Drawing.Point(343, 279);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(66, 66);
            this.C4.TabIndex = 43;
            this.C4.UseVisualStyleBackColor = false;
            this.C4.Click += new System.EventHandler(this.button_click4);
            this.C4.MouseEnter += new System.EventHandler(this.button_enter);
            this.C4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton36
            // 
            this.roundButton36.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton36.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton36.FlatAppearance.BorderSize = 5;
            this.roundButton36.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton36.Location = new System.Drawing.Point(341, 277);
            this.roundButton36.Name = "roundButton36";
            this.roundButton36.Size = new System.Drawing.Size(70, 70);
            this.roundButton36.TabIndex = 44;
            this.roundButton36.UseVisualStyleBackColor = false;
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.C3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C3.FlatAppearance.BorderSize = 5;
            this.C3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.C3.Location = new System.Drawing.Point(244, 281);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(66, 66);
            this.C3.TabIndex = 41;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click3);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton38
            // 
            this.roundButton38.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton38.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton38.FlatAppearance.BorderSize = 5;
            this.roundButton38.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton38.Location = new System.Drawing.Point(242, 279);
            this.roundButton38.Name = "roundButton38";
            this.roundButton38.Size = new System.Drawing.Size(70, 70);
            this.roundButton38.TabIndex = 42;
            this.roundButton38.UseVisualStyleBackColor = false;
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.C2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C2.FlatAppearance.BorderSize = 5;
            this.C2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.C2.Location = new System.Drawing.Point(144, 281);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(66, 66);
            this.C2.TabIndex = 39;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click2);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton40
            // 
            this.roundButton40.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton40.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton40.FlatAppearance.BorderSize = 5;
            this.roundButton40.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton40.Location = new System.Drawing.Point(142, 279);
            this.roundButton40.Name = "roundButton40";
            this.roundButton40.Size = new System.Drawing.Size(70, 70);
            this.roundButton40.TabIndex = 40;
            this.roundButton40.UseVisualStyleBackColor = false;
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.C1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C1.FlatAppearance.BorderSize = 5;
            this.C1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.C1.Location = new System.Drawing.Point(46, 279);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(66, 66);
            this.C1.TabIndex = 37;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click1);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton42
            // 
            this.roundButton42.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton42.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton42.FlatAppearance.BorderSize = 5;
            this.roundButton42.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton42.Location = new System.Drawing.Point(44, 277);
            this.roundButton42.Name = "roundButton42";
            this.roundButton42.Size = new System.Drawing.Size(70, 70);
            this.roundButton42.TabIndex = 38;
            this.roundButton42.UseVisualStyleBackColor = false;
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B7.FlatAppearance.BorderSize = 5;
            this.B7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.B7.Location = new System.Drawing.Point(639, 194);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(66, 66);
            this.B7.TabIndex = 35;
            this.B7.UseVisualStyleBackColor = false;
            this.B7.Click += new System.EventHandler(this.button_click7);
            this.B7.MouseEnter += new System.EventHandler(this.button_enter);
            this.B7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton16
            // 
            this.roundButton16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton16.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton16.FlatAppearance.BorderSize = 5;
            this.roundButton16.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton16.Location = new System.Drawing.Point(637, 192);
            this.roundButton16.Name = "roundButton16";
            this.roundButton16.Size = new System.Drawing.Size(70, 70);
            this.roundButton16.TabIndex = 36;
            this.roundButton16.UseVisualStyleBackColor = false;
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B6.FlatAppearance.BorderSize = 5;
            this.B6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.B6.Location = new System.Drawing.Point(541, 194);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(66, 66);
            this.B6.TabIndex = 33;
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Click += new System.EventHandler(this.button_click6);
            this.B6.MouseEnter += new System.EventHandler(this.button_enter);
            this.B6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton18
            // 
            this.roundButton18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton18.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton18.FlatAppearance.BorderSize = 5;
            this.roundButton18.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton18.Location = new System.Drawing.Point(539, 192);
            this.roundButton18.Name = "roundButton18";
            this.roundButton18.Size = new System.Drawing.Size(70, 70);
            this.roundButton18.TabIndex = 34;
            this.roundButton18.UseVisualStyleBackColor = false;
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B5.FlatAppearance.BorderSize = 5;
            this.B5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.B5.Location = new System.Drawing.Point(442, 196);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(66, 66);
            this.B5.TabIndex = 31;
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.button_click5);
            this.B5.MouseEnter += new System.EventHandler(this.button_enter);
            this.B5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton20
            // 
            this.roundButton20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton20.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton20.FlatAppearance.BorderSize = 5;
            this.roundButton20.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton20.Location = new System.Drawing.Point(440, 194);
            this.roundButton20.Name = "roundButton20";
            this.roundButton20.Size = new System.Drawing.Size(70, 70);
            this.roundButton20.TabIndex = 32;
            this.roundButton20.UseVisualStyleBackColor = false;
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B4.FlatAppearance.BorderSize = 5;
            this.B4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.B4.Location = new System.Drawing.Point(343, 194);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(66, 66);
            this.B4.TabIndex = 29;
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.button_click4);
            this.B4.MouseEnter += new System.EventHandler(this.button_enter);
            this.B4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton22
            // 
            this.roundButton22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton22.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton22.FlatAppearance.BorderSize = 5;
            this.roundButton22.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton22.Location = new System.Drawing.Point(341, 192);
            this.roundButton22.Name = "roundButton22";
            this.roundButton22.Size = new System.Drawing.Size(70, 70);
            this.roundButton22.TabIndex = 30;
            this.roundButton22.UseVisualStyleBackColor = false;
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B3.FlatAppearance.BorderSize = 5;
            this.B3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.B3.Location = new System.Drawing.Point(244, 196);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(66, 66);
            this.B3.TabIndex = 27;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click3);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton24
            // 
            this.roundButton24.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton24.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton24.FlatAppearance.BorderSize = 5;
            this.roundButton24.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton24.Location = new System.Drawing.Point(242, 194);
            this.roundButton24.Name = "roundButton24";
            this.roundButton24.Size = new System.Drawing.Size(70, 70);
            this.roundButton24.TabIndex = 28;
            this.roundButton24.UseVisualStyleBackColor = false;
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B2.FlatAppearance.BorderSize = 5;
            this.B2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.B2.Location = new System.Drawing.Point(144, 196);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(66, 66);
            this.B2.TabIndex = 25;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click2);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton26
            // 
            this.roundButton26.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton26.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton26.FlatAppearance.BorderSize = 5;
            this.roundButton26.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton26.Location = new System.Drawing.Point(142, 194);
            this.roundButton26.Name = "roundButton26";
            this.roundButton26.Size = new System.Drawing.Size(70, 70);
            this.roundButton26.TabIndex = 26;
            this.roundButton26.UseVisualStyleBackColor = false;
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B1.FlatAppearance.BorderSize = 5;
            this.B1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.B1.Location = new System.Drawing.Point(46, 194);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(66, 66);
            this.B1.TabIndex = 23;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click1);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton28
            // 
            this.roundButton28.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton28.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton28.FlatAppearance.BorderSize = 5;
            this.roundButton28.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton28.Location = new System.Drawing.Point(44, 192);
            this.roundButton28.Name = "roundButton28";
            this.roundButton28.Size = new System.Drawing.Size(70, 70);
            this.roundButton28.TabIndex = 24;
            this.roundButton28.UseVisualStyleBackColor = false;
            // 
            // A7
            // 
            this.A7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.A7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.A7.FlatAppearance.BorderSize = 5;
            this.A7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.A7.Location = new System.Drawing.Point(637, 109);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(66, 66);
            this.A7.TabIndex = 19;
            this.A7.UseVisualStyleBackColor = false;
            this.A7.Click += new System.EventHandler(this.button_click7);
            this.A7.MouseEnter += new System.EventHandler(this.button_enter);
            this.A7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton14
            // 
            this.roundButton14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton14.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton14.FlatAppearance.BorderSize = 5;
            this.roundButton14.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton14.Location = new System.Drawing.Point(635, 107);
            this.roundButton14.Name = "roundButton14";
            this.roundButton14.Size = new System.Drawing.Size(70, 70);
            this.roundButton14.TabIndex = 20;
            this.roundButton14.UseVisualStyleBackColor = false;
            // 
            // A6
            // 
            this.A6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.A6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.A6.FlatAppearance.BorderSize = 5;
            this.A6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.A6.Location = new System.Drawing.Point(539, 109);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(66, 66);
            this.A6.TabIndex = 17;
            this.A6.UseVisualStyleBackColor = false;
            this.A6.Click += new System.EventHandler(this.button_click6);
            this.A6.MouseEnter += new System.EventHandler(this.button_enter);
            this.A6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton12
            // 
            this.roundButton12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton12.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton12.FlatAppearance.BorderSize = 5;
            this.roundButton12.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton12.Location = new System.Drawing.Point(537, 107);
            this.roundButton12.Name = "roundButton12";
            this.roundButton12.Size = new System.Drawing.Size(70, 70);
            this.roundButton12.TabIndex = 18;
            this.roundButton12.UseVisualStyleBackColor = false;
            // 
            // A5
            // 
            this.A5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.A5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.A5.FlatAppearance.BorderSize = 5;
            this.A5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.A5.Location = new System.Drawing.Point(440, 111);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(66, 66);
            this.A5.TabIndex = 15;
            this.A5.UseVisualStyleBackColor = false;
            this.A5.Click += new System.EventHandler(this.button_click5);
            this.A5.MouseEnter += new System.EventHandler(this.button_enter);
            this.A5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton10.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton10.FlatAppearance.BorderSize = 5;
            this.roundButton10.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton10.Location = new System.Drawing.Point(438, 109);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(70, 70);
            this.roundButton10.TabIndex = 16;
            this.roundButton10.UseVisualStyleBackColor = false;
            // 
            // A4
            // 
            this.A4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.A4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.A4.FlatAppearance.BorderSize = 5;
            this.A4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.A4.Location = new System.Drawing.Point(341, 109);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(66, 66);
            this.A4.TabIndex = 13;
            this.A4.UseVisualStyleBackColor = false;
            this.A4.Click += new System.EventHandler(this.button_click4);
            this.A4.MouseEnter += new System.EventHandler(this.button_enter);
            this.A4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton8.FlatAppearance.BorderSize = 5;
            this.roundButton8.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton8.Location = new System.Drawing.Point(339, 107);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(70, 70);
            this.roundButton8.TabIndex = 14;
            this.roundButton8.UseVisualStyleBackColor = false;
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.A3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.A3.FlatAppearance.BorderSize = 5;
            this.A3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.A3.Location = new System.Drawing.Point(242, 111);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(66, 66);
            this.A3.TabIndex = 11;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click3);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton6.FlatAppearance.BorderSize = 5;
            this.roundButton6.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton6.Location = new System.Drawing.Point(240, 109);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(70, 70);
            this.roundButton6.TabIndex = 12;
            this.roundButton6.UseVisualStyleBackColor = false;
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.A2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.A2.FlatAppearance.BorderSize = 5;
            this.A2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.A2.Location = new System.Drawing.Point(142, 111);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(66, 66);
            this.A2.TabIndex = 9;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click2);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton4.FlatAppearance.BorderSize = 5;
            this.roundButton4.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton4.Location = new System.Drawing.Point(140, 109);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(70, 70);
            this.roundButton4.TabIndex = 10;
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.A1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.A1.FlatAppearance.BorderSize = 5;
            this.A1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.A1.Location = new System.Drawing.Point(44, 109);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(66, 66);
            this.A1.TabIndex = 5;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click1);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton2.FlatAppearance.BorderSize = 5;
            this.roundButton2.ForeColor = System.Drawing.SystemColors.Window;
            this.roundButton2.Location = new System.Drawing.Point(42, 107);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(70, 70);
            this.roundButton2.TabIndex = 6;
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(925, 636);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.P_Win_Count);
            this.Controls.Add(this.Draw_Count);
            this.Controls.Add(this.G_Win_Count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.F7);
            this.Controls.Add(this.roundButton72);
            this.Controls.Add(this.F6);
            this.Controls.Add(this.roundButton74);
            this.Controls.Add(this.F5);
            this.Controls.Add(this.roundButton76);
            this.Controls.Add(this.F4);
            this.Controls.Add(this.roundButton78);
            this.Controls.Add(this.F3);
            this.Controls.Add(this.roundButton80);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.roundButton82);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.roundButton84);
            this.Controls.Add(this.E7);
            this.Controls.Add(this.roundButton58);
            this.Controls.Add(this.E6);
            this.Controls.Add(this.roundButton60);
            this.Controls.Add(this.E5);
            this.Controls.Add(this.roundButton62);
            this.Controls.Add(this.E4);
            this.Controls.Add(this.roundButton64);
            this.Controls.Add(this.E3);
            this.Controls.Add(this.roundButton66);
            this.Controls.Add(this.E2);
            this.Controls.Add(this.roundButton68);
            this.Controls.Add(this.E1);
            this.Controls.Add(this.roundButton70);
            this.Controls.Add(this.D7);
            this.Controls.Add(this.roundButton44);
            this.Controls.Add(this.D6);
            this.Controls.Add(this.roundButton46);
            this.Controls.Add(this.D5);
            this.Controls.Add(this.roundButton48);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.roundButton50);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.roundButton52);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.roundButton54);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.roundButton56);
            this.Controls.Add(this.C7);
            this.Controls.Add(this.roundButton30);
            this.Controls.Add(this.C6);
            this.Controls.Add(this.roundButton32);
            this.Controls.Add(this.C5);
            this.Controls.Add(this.roundButton34);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.roundButton36);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.roundButton38);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.roundButton40);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.roundButton42);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.roundButton16);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.roundButton18);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.roundButton20);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.roundButton22);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.roundButton24);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.roundButton26);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.roundButton28);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.roundButton14);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.roundButton12);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.roundButton10);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.roundButton8);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.roundButton6);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox5);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Four In A Line";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }
      

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void roundButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e)
        {

        }

        private void roundButton6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Thomas Kim, 2016 \nThank you for playing.", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connect 4 pieces vertically, horizontally or diagonally. \nYou can only place pieces from the bottom up. \n", "How to Play");
        }

        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(i) Always start in the middle. \n(ii) Watch out for your opponent's move. \n(iii) Try to find out how to create a forced move. \n(iv) Look a few moves ahead. \n(v) Most importantly, enjoy the game! \n", "Tips");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }




        private void button_click1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.BackColor = Color.LightGreen;
            else
                b.BackColor = Color.LightPink;

            turn = !turn;
            turn_count++;
            disableButtonsInGame1();
            CheckForWinner();

            // checking whether the player is against computer and if it's computer's turn
            if ((!turn) && (against_computer1))
            {
                computer_make_move1();
            }

            if ((turn) && (against_computer2))
            {
                computer_make_move2();
            }
        }

        private void button_click2(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.BackColor = Color.LightGreen;
            else
                b.BackColor = Color.LightPink;

            turn = !turn;
            turn_count++;
            disableButtonsInGame2();
            CheckForWinner();

            if ((!turn) && (against_computer1))
            {
                computer_make_move1();
            }

            if ((turn) && (against_computer2))
            {
                computer_make_move2();
            }
        }

        private void button_click3(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.BackColor = Color.LightGreen;
            else
                b.BackColor = Color.LightPink;

            turn = !turn;
            turn_count++;
            disableButtonsInGame3();
            CheckForWinner();

            if ((!turn) && (against_computer1))
            {
                computer_make_move1();
            }

            if ((turn) && (against_computer2))
            {
                computer_make_move2();
            }
        }

        private void button_click4(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.BackColor = Color.LightGreen;
            else
                b.BackColor = Color.LightPink;

            turn = !turn;
            turn_count++;
            disableButtonsInGame4();
            CheckForWinner();

            if ((!turn) && (against_computer1))
            {
                computer_make_move1();
            }

            if ((turn) && (against_computer2))
            {
                computer_make_move2();
            }
        }

        private void button_click5(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.BackColor = Color.LightGreen;
            else
                b.BackColor = Color.LightPink;

            turn = !turn;
            turn_count++;
            disableButtonsInGame5();
            CheckForWinner();

            if ((!turn) && (against_computer1))
            {
                computer_make_move1();
            }

            if ((turn) && (against_computer2))
            {
                computer_make_move2();
            }
        }

        private void button_click6(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.BackColor = Color.LightGreen;
            else
                b.BackColor = Color.LightPink;

            turn = !turn;
            turn_count++;
            disableButtonsInGame6();
            CheckForWinner();

            if ((!turn) && (against_computer1))
            {
                computer_make_move1();
            }

            if ((turn) && (against_computer2))
            {
                computer_make_move2();
            }
        }

        private void button_click7(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.BackColor = Color.LightGreen;
            else
                b.BackColor = Color.LightPink;

            turn = !turn;
            turn_count++;
            disableButtonsInGame7();
            CheckForWinner();

            if ((!turn) && (against_computer1))
            {
                computer_make_move1();
            }

            if ((turn) && (against_computer2))
            {
                computer_make_move2();
            }
        }

        private void computer_make_move1()
        {
            //priority 1: get four in a line
            //priority 2: block its opponent from winning 
            //priority 3: Make three in a line
            //priority 4: Attempt to block three in a line
            //priority 5: go for middle space
            //priority 6: pick an open spot

            Button move = null;

            move = look_pink_spot();
            if (move == null)
            {
                move = look_green_spot();
                if (move == null)
                {
                    move = look_for_pink_two();
                    if (move == null)
                    {
                        move = look_for_green_two();
                        if (move == null)
                        {
                            move = look_for_middle();
                            if (move == null)
                            {
                                move = look_for_space();
                                if (move == null)
                                {
                                    move = returnnull();
                                }
                            }
                        }
                    }
                }
            }

            move.PerformClick();
        }

        private void computer_make_move2()
        {
            Button move = null;

            move = look_green_spot();
            if (move == null)
            {
                move = look_pink_spot();
                if (move == null)
                {
                    move = look_for_pink_two();
                    if (move == null)
                    {
                        move = look_for_green_two();
                        if (move == null)
                        {
                            move = look_for_middle();
                            if (move == null)
                            {
                                move = look_for_space();
                                if (move == null)
                                {
                                    move = returnnull();
                                }
                            }
                        }
                    }
                }
            }

            move.PerformClick();
        }

        private Button returnnull()
        {
            return A1;
        }

        private Button look_pink_spot()
        {
            Console.WriteLine("Looking for a good spot...");

            // horizontal checks
            if ((A1.BackColor == Color.LightPink) && (A1.BackColor == A2.BackColor) && (A1.BackColor == A3.BackColor) && (A4.Enabled))
                return A4;
            if ((A2.BackColor == Color.LightPink) && (A2.BackColor == A3.BackColor) && (A2.BackColor == A4.BackColor) && (A5.Enabled))
                return A5;
            if ((A2.BackColor == Color.LightPink) && (A2.BackColor == A3.BackColor) && (A2.BackColor == A4.BackColor) && (A1.Enabled))
                return A1;
            if ((A3.BackColor == Color.LightPink) && (A3.BackColor == A4.BackColor) && (A3.BackColor == A5.BackColor) && (A6.Enabled))
                return A6;
            if ((A3.BackColor == Color.LightPink) && (A3.BackColor == A4.BackColor) && (A3.BackColor == A5.BackColor) && (A2.Enabled))
                return A2;
            if ((A4.BackColor == Color.LightPink) && (A4.BackColor == A5.BackColor) && (A4.BackColor == A6.BackColor) && (A7.Enabled))
                return A7;
            if ((A4.BackColor == Color.LightPink) && (A4.BackColor == A5.BackColor) && (A4.BackColor == A6.BackColor) && (A3.Enabled))
                return A3;
            if ((A5.BackColor == Color.LightPink) && (A5.BackColor == A6.BackColor) && (A5.BackColor == A7.BackColor) && (A4.Enabled))
                return A4;

            if ((B1.BackColor == Color.LightPink) && (B1.BackColor == B2.BackColor) && (B1.BackColor == B3.BackColor) && (B4.Enabled))
                return B4;
            if ((B2.BackColor == Color.LightPink) && (B2.BackColor == B3.BackColor) && (B2.BackColor == B4.BackColor) && (B5.Enabled))
                return B5;
            if ((B2.BackColor == Color.LightPink) && (B2.BackColor == B3.BackColor) && (B2.BackColor == B4.BackColor) && (B1.Enabled))
                return B1;
            if ((B3.BackColor == Color.LightPink) && (B3.BackColor == B4.BackColor) && (B3.BackColor == B5.BackColor) && (B6.Enabled))
                return B6;
            if ((B3.BackColor == Color.LightPink) && (B3.BackColor == B4.BackColor) && (B3.BackColor == B5.BackColor) && (B2.Enabled))
                return B2;
            if ((B4.BackColor == Color.LightPink) && (B4.BackColor == B5.BackColor) && (B4.BackColor == B6.BackColor) && (B7.Enabled))
                return B7;
            if ((B4.BackColor == Color.LightPink) && (B4.BackColor == B5.BackColor) && (B4.BackColor == B6.BackColor) && (B3.Enabled))
                return B3;
            if ((B5.BackColor == Color.LightPink) && (B5.BackColor == B6.BackColor) && (B5.BackColor == B7.BackColor) && (B4.Enabled))
                return B4;

            if ((C1.BackColor == Color.LightPink) && (C1.BackColor == C2.BackColor) && (C1.BackColor == C3.BackColor) && (C4.Enabled))
                return C4;
            if ((C2.BackColor == Color.LightPink) && (C2.BackColor == C3.BackColor) && (C2.BackColor == C4.BackColor) && (C5.Enabled))
                return C5;
            if ((C2.BackColor == Color.LightPink) && (C2.BackColor == C3.BackColor) && (C2.BackColor == C4.BackColor) && (C1.Enabled))
                return C1;
            if ((C3.BackColor == Color.LightPink) && (C3.BackColor == C4.BackColor) && (C3.BackColor == C5.BackColor) && (C6.Enabled))
                return C6;
            if ((C3.BackColor == Color.LightPink) && (C3.BackColor == C4.BackColor) && (C3.BackColor == C5.BackColor) && (C2.Enabled))
                return C2;
            if ((C4.BackColor == Color.LightPink) && (C4.BackColor == C5.BackColor) && (C4.BackColor == C6.BackColor) && (C7.Enabled))
                return C7;
            if ((C4.BackColor == Color.LightPink) && (C4.BackColor == C5.BackColor) && (C4.BackColor == C6.BackColor) && (C3.Enabled))
                return C3;
            if ((C5.BackColor == Color.LightPink) && (C5.BackColor == C6.BackColor) && (C5.BackColor == C7.BackColor) && (C4.Enabled))
                return C4;

            if ((D1.BackColor == Color.LightPink) && (D1.BackColor == D2.BackColor) && (D1.BackColor == D3.BackColor) && (D4.Enabled))
                return D4;
            if ((D2.BackColor == Color.LightPink) && (D2.BackColor == D3.BackColor) && (D2.BackColor == D4.BackColor) && (D5.Enabled))
                return D5;
            if ((D2.BackColor == Color.LightPink) && (D2.BackColor == D3.BackColor) && (D2.BackColor == D4.BackColor) && (D1.Enabled))
                return D1;
            if ((D3.BackColor == Color.LightPink) && (D3.BackColor == D4.BackColor) && (D3.BackColor == D5.BackColor) && (D6.Enabled))
                return D6;
            if ((D3.BackColor == Color.LightPink) && (D3.BackColor == D4.BackColor) && (D3.BackColor == D5.BackColor) && (D2.Enabled))
                return D2;
            if ((D4.BackColor == Color.LightPink) && (D4.BackColor == D5.BackColor) && (D4.BackColor == D6.BackColor) && (D7.Enabled))
                return D7;
            if ((D4.BackColor == Color.LightPink) && (D4.BackColor == D5.BackColor) && (D4.BackColor == D6.BackColor) && (D3.Enabled))
                return D3;
            if ((D5.BackColor == Color.LightPink) && (D5.BackColor == D6.BackColor) && (D5.BackColor == D7.BackColor) && (D4.Enabled))
                return D4;

            if ((E1.BackColor == Color.LightPink) && (E1.BackColor == E2.BackColor) && (E1.BackColor == E3.BackColor) && (E4.Enabled))
                return E4;
            if ((E2.BackColor == Color.LightPink) && (E2.BackColor == E3.BackColor) && (E2.BackColor == E4.BackColor) && (E5.Enabled))
                return E5;
            if ((E2.BackColor == Color.LightPink) && (E2.BackColor == E3.BackColor) && (E2.BackColor == E4.BackColor) && (E1.Enabled))
                return E1;
            if ((E3.BackColor == Color.LightPink) && (E3.BackColor == E4.BackColor) && (E3.BackColor == E5.BackColor) && (E6.Enabled))
                return E6;
            if ((E3.BackColor == Color.LightPink) && (E3.BackColor == E4.BackColor) && (E3.BackColor == E5.BackColor) && (E2.Enabled))
                return E2;
            if ((E4.BackColor == Color.LightPink) && (E4.BackColor == E5.BackColor) && (E4.BackColor == E6.BackColor) && (E7.Enabled))
                return E7;
            if ((E4.BackColor == Color.LightPink) && (E4.BackColor == E5.BackColor) && (E4.BackColor == E6.BackColor) && (E3.Enabled))
                return E3;
            if ((E5.BackColor == Color.LightPink) && (E5.BackColor == E6.BackColor) && (E5.BackColor == E7.BackColor) && (E4.Enabled))
                return E4;

            if ((F1.BackColor == Color.LightPink) && (F1.BackColor == F2.BackColor) && (F1.BackColor == F3.BackColor) && (F4.Enabled))
                return F4;
            if ((F2.BackColor == Color.LightPink) && (F2.BackColor == F3.BackColor) && (F2.BackColor == F4.BackColor) && (F5.Enabled))
                return F5;
            if ((F2.BackColor == Color.LightPink) && (F2.BackColor == F3.BackColor) && (F2.BackColor == F4.BackColor) && (F1.Enabled))
                return F1;
            if ((F3.BackColor == Color.LightPink) && (F3.BackColor == F4.BackColor) && (F3.BackColor == F5.BackColor) && (F6.Enabled))
                return F6;
            if ((F3.BackColor == Color.LightPink) && (F3.BackColor == F4.BackColor) && (F3.BackColor == F5.BackColor) && (F2.Enabled))
                return F2;
            if ((F4.BackColor == Color.LightPink) && (F4.BackColor == F5.BackColor) && (F4.BackColor == F6.BackColor) && (F7.Enabled))
                return F7;
            if ((F4.BackColor == Color.LightPink) && (F4.BackColor == F5.BackColor) && (F4.BackColor == F6.BackColor) && (F3.Enabled))
                return F3;
            if ((F5.BackColor == Color.LightPink) && (F5.BackColor == F6.BackColor) && (F5.BackColor == F7.BackColor) && (F4.Enabled))
                return F4;

            // vertical checks

            if ((F1.BackColor == Color.LightPink) && (F1.BackColor == E1.BackColor) && (F1.BackColor == D1.BackColor) && (C1.Enabled))
                return C1;
            if ((E1.BackColor == Color.LightPink) && (E1.BackColor == D1.BackColor) && (E1.BackColor == C1.BackColor) && (B1.Enabled))
                return B1;
            if ((D1.BackColor == Color.LightPink) && (D1.BackColor == C1.BackColor) && (D1.BackColor == B1.BackColor) && (A1.Enabled))
                return A1;

            if ((F2.BackColor == Color.LightPink) && (F2.BackColor == E2.BackColor) && (F2.BackColor == D2.BackColor) && (C2.Enabled))
                return C2;
            if ((E2.BackColor == Color.LightPink) && (E2.BackColor == D2.BackColor) && (E2.BackColor == C2.BackColor) && (B2.Enabled))
                return B2;
            if ((D2.BackColor == Color.LightPink) && (D2.BackColor == C2.BackColor) && (D2.BackColor == B2.BackColor) && (A2.Enabled))
                return A2;

            if ((F3.BackColor == Color.LightPink) && (F3.BackColor == E3.BackColor) && (F3.BackColor == D3.BackColor) && (C3.Enabled))
                return C3;
            if ((E3.BackColor == Color.LightPink) && (E3.BackColor == D3.BackColor) && (E3.BackColor == C3.BackColor) && (B3.Enabled))
                return B3;
            if ((D3.BackColor == Color.LightPink) && (D3.BackColor == C3.BackColor) && (D3.BackColor == B3.BackColor) && (A3.Enabled))
                return A3;

            if ((F4.BackColor == Color.LightPink) && (F4.BackColor == E4.BackColor) && (F4.BackColor == D4.BackColor) && (C4.Enabled))
                return C4;
            if ((E4.BackColor == Color.LightPink) && (E4.BackColor == D4.BackColor) && (E4.BackColor == C4.BackColor) && (B4.Enabled))
                return B4;
            if ((D4.BackColor == Color.LightPink) && (D4.BackColor == C4.BackColor) && (D4.BackColor == B4.BackColor) && (A4.Enabled))
                return A4;

            if ((F5.BackColor == Color.LightPink) && (F5.BackColor == E5.BackColor) && (F5.BackColor == D5.BackColor) && (C5.Enabled))
                return C5;
            if ((E5.BackColor == Color.LightPink) && (E5.BackColor == D5.BackColor) && (E5.BackColor == C5.BackColor) && (B5.Enabled))
                return B5;
            if ((D5.BackColor == Color.LightPink) && (D5.BackColor == C5.BackColor) && (D5.BackColor == B5.BackColor) && (A5.Enabled))
                return A5;

            if ((F6.BackColor == Color.LightPink) && (F6.BackColor == E6.BackColor) && (F6.BackColor == D6.BackColor) && (C6.Enabled))
                return C6;
            if ((E6.BackColor == Color.LightPink) && (E6.BackColor == D6.BackColor) && (E6.BackColor == C6.BackColor) && (B6.Enabled))
                return B6;
            if ((D6.BackColor == Color.LightPink) && (D6.BackColor == C6.BackColor) && (D6.BackColor == B6.BackColor) && (A6.Enabled))
                return A6;

            if ((F7.BackColor == Color.LightPink) && (F7.BackColor == E7.BackColor) && (F7.BackColor == D7.BackColor) && (C7.Enabled))
                return C7;
            if ((E7.BackColor == Color.LightPink) && (E7.BackColor == D7.BackColor) && (E7.BackColor == C7.BackColor) && (B7.Enabled))
                return B7;
            if ((D7.BackColor == Color.LightPink) && (D7.BackColor == C7.BackColor) && (D7.BackColor == B7.BackColor) && (A7.Enabled))
                return A7;

            // diagonal checks

            if ((F1.BackColor == Color.LightPink) && (F1.BackColor == E2.BackColor) && (F1.BackColor == D3.BackColor) && (C4.Enabled))
                return C4;
            if ((F2.BackColor == Color.LightPink) && (F2.BackColor == E3.BackColor) && (F2.BackColor == D4.BackColor) && (C5.Enabled))
                return C5;
            if ((F3.BackColor == Color.LightPink) && (F3.BackColor == E4.BackColor) && (F3.BackColor == D5.BackColor) && (C6.Enabled))
                return C6;
            if ((F4.BackColor == Color.LightPink) && (F4.BackColor == E5.BackColor) && (F4.BackColor == D6.BackColor) && (C7.Enabled))
                return C7;
            if ((F4.BackColor == Color.LightPink) && (F4.BackColor == E3.BackColor) && (F4.BackColor == D2.BackColor) && (C1.Enabled))
                return C1;
            if ((F5.BackColor == Color.LightPink) && (F5.BackColor == E4.BackColor) && (F5.BackColor == D3.BackColor) && (C2.Enabled))
                return C1;
            if ((F6.BackColor == Color.LightPink) && (F6.BackColor == E5.BackColor) && (F6.BackColor == D4.BackColor) && (C3.Enabled))
                return C3;
            if ((F7.BackColor == Color.LightPink) && (F7.BackColor == E6.BackColor) && (F7.BackColor == D5.BackColor) && (C4.Enabled))
                return C4;

            if ((E1.BackColor == Color.LightPink) && (E1.BackColor == D2.BackColor) && (E1.BackColor == C3.BackColor) && (B4.Enabled))
                return B4;
            if ((E2.BackColor == Color.LightPink) && (E2.BackColor == D3.BackColor) && (E2.BackColor == C4.BackColor) && (B5.Enabled))
                return B5;
            if ((E3.BackColor == Color.LightPink) && (E3.BackColor == D4.BackColor) && (E3.BackColor == C5.BackColor) && (B6.Enabled))
                return B6;
            if ((E4.BackColor == Color.LightPink) && (E4.BackColor == D5.BackColor) && (E4.BackColor == C6.BackColor) && (B7.Enabled))
                return B7;
            if ((E4.BackColor == Color.LightPink) && (E4.BackColor == D3.BackColor) && (E4.BackColor == C2.BackColor) && (B1.Enabled))
                return B1;
            if ((E5.BackColor == Color.LightPink) && (E5.BackColor == D4.BackColor) && (E5.BackColor == C3.BackColor) && (B2.Enabled))
                return B1;
            if ((E6.BackColor == Color.LightPink) && (E6.BackColor == D5.BackColor) && (E6.BackColor == C4.BackColor) && (B3.Enabled))
                return B3;
            if ((E7.BackColor == Color.LightPink) && (E7.BackColor == D6.BackColor) && (E7.BackColor == C5.BackColor) && (B4.Enabled))
                return B4;

            if ((D1.BackColor == Color.LightPink) && (D1.BackColor == C2.BackColor) && (D1.BackColor == B3.BackColor) && (A4.Enabled))
                return A4;
            if ((D2.BackColor == Color.LightPink) && (D2.BackColor == C3.BackColor) && (D2.BackColor == B4.BackColor) && (A5.Enabled))
                return A5;
            if ((D3.BackColor == Color.LightPink) && (D3.BackColor == C4.BackColor) && (D3.BackColor == B5.BackColor) && (A6.Enabled))
                return A6;
            if ((D4.BackColor == Color.LightPink) && (D4.BackColor == C5.BackColor) && (D4.BackColor == B6.BackColor) && (A7.Enabled))
                return A7;
            if ((D4.BackColor == Color.LightPink) && (D4.BackColor == C3.BackColor) && (D4.BackColor == B2.BackColor) && (A1.Enabled))
                return A1;
            if ((D5.BackColor == Color.LightPink) && (D5.BackColor == C4.BackColor) && (D5.BackColor == B3.BackColor) && (A2.Enabled))
                return A1;
            if ((D6.BackColor == Color.LightPink) && (D6.BackColor == C5.BackColor) && (D6.BackColor == B4.BackColor) && (A3.Enabled))
                return A3;
            if ((D7.BackColor == Color.LightPink) && (D7.BackColor == C6.BackColor) && (D7.BackColor == B5.BackColor) && (A4.Enabled))
                return A4;

            if ((C1.BackColor == Color.LightPink) && (C1.BackColor == D2.BackColor) && (C1.BackColor == E3.BackColor) && (F4.Enabled))
                return F4;
            if ((C2.BackColor == Color.LightPink) && (C2.BackColor == D3.BackColor) && (C2.BackColor == E4.BackColor) && (F5.Enabled))
                return F5;
            if ((C3.BackColor == Color.LightPink) && (C3.BackColor == D4.BackColor) && (C3.BackColor == E5.BackColor) && (F6.Enabled))
                return F6;
            if ((C4.BackColor == Color.LightPink) && (C4.BackColor == D5.BackColor) && (C4.BackColor == E6.BackColor) && (F7.Enabled))
                return F7;
            if ((C4.BackColor == Color.LightPink) && (C4.BackColor == D3.BackColor) && (C4.BackColor == E2.BackColor) && (F1.Enabled))
                return F1;
            if ((C5.BackColor == Color.LightPink) && (C5.BackColor == D4.BackColor) && (C5.BackColor == E3.BackColor) && (F2.Enabled))
                return F1;
            if ((C6.BackColor == Color.LightPink) && (C6.BackColor == D5.BackColor) && (C6.BackColor == E4.BackColor) && (F3.Enabled))
                return F3;
            if ((C7.BackColor == Color.LightPink) && (C7.BackColor == D6.BackColor) && (C7.BackColor == E5.BackColor) && (F4.Enabled))
                return F4;

            if ((B1.BackColor == Color.LightPink) && (B1.BackColor == C2.BackColor) && (B1.BackColor == D3.BackColor) && (E4.Enabled))
                return E4;
            if ((B2.BackColor == Color.LightPink) && (B2.BackColor == C3.BackColor) && (B2.BackColor == D4.BackColor) && (E5.Enabled))
                return E5;
            if ((B3.BackColor == Color.LightPink) && (B3.BackColor == C4.BackColor) && (B3.BackColor == D5.BackColor) && (E6.Enabled))
                return E6;
            if ((B4.BackColor == Color.LightPink) && (B4.BackColor == C5.BackColor) && (B4.BackColor == D6.BackColor) && (E7.Enabled))
                return E7;
            if ((B4.BackColor == Color.LightPink) && (B4.BackColor == C3.BackColor) && (B4.BackColor == D2.BackColor) && (E1.Enabled))
                return E1;
            if ((B5.BackColor == Color.LightPink) && (B5.BackColor == C4.BackColor) && (B5.BackColor == D3.BackColor) && (E2.Enabled))
                return E1;
            if ((B6.BackColor == Color.LightPink) && (B6.BackColor == C5.BackColor) && (B6.BackColor == D4.BackColor) && (E3.Enabled))
                return E3;
            if ((B7.BackColor == Color.LightPink) && (B7.BackColor == C6.BackColor) && (B7.BackColor == D5.BackColor) && (E4.Enabled))
                return E4;

            if ((A1.BackColor == Color.LightPink) && (A1.BackColor == B2.BackColor) && (A1.BackColor == C3.BackColor) && (D4.Enabled))
                return D4;
            if ((A2.BackColor == Color.LightPink) && (A2.BackColor == B3.BackColor) && (A2.BackColor == C4.BackColor) && (D5.Enabled))
                return D5;
            if ((A3.BackColor == Color.LightPink) && (A3.BackColor == B4.BackColor) && (A3.BackColor == C5.BackColor) && (D6.Enabled))
                return D6;
            if ((A4.BackColor == Color.LightPink) && (A4.BackColor == B5.BackColor) && (A4.BackColor == C6.BackColor) && (D7.Enabled))
                return D7;
            if ((A4.BackColor == Color.LightPink) && (A4.BackColor == B3.BackColor) && (A4.BackColor == C2.BackColor) && (D1.Enabled))
                return D1;
            if ((A5.BackColor == Color.LightPink) && (A5.BackColor == B4.BackColor) && (A5.BackColor == C3.BackColor) && (D2.Enabled))
                return D1;
            if ((A6.BackColor == Color.LightPink) && (A6.BackColor == B5.BackColor) && (A6.BackColor == C4.BackColor) && (D3.Enabled))
                return D3;
            if ((A7.BackColor == Color.LightPink) && (A7.BackColor == B6.BackColor) && (A7.BackColor == C5.BackColor) && (D4.Enabled))
                return D4;

            return null;

        }

        private Button look_green_spot()
        {
            Console.WriteLine("Working on how to beat you...");

            // horizontal checks
            if ((A1.BackColor == Color.LightGreen) && (A1.BackColor == A2.BackColor) && (A1.BackColor == A3.BackColor) && (A4.Enabled))
                return A4;
            if ((A2.BackColor == Color.LightGreen) && (A2.BackColor == A3.BackColor) && (A2.BackColor == A4.BackColor) && (A5.Enabled))
                return A5;
            if ((A2.BackColor == Color.LightGreen) && (A2.BackColor == A3.BackColor) && (A2.BackColor == A4.BackColor) && (A1.Enabled))
                return A1;
            if ((A3.BackColor == Color.LightGreen) && (A3.BackColor == A4.BackColor) && (A3.BackColor == A5.BackColor) && (A6.Enabled))
                return A6;
            if ((A3.BackColor == Color.LightGreen) && (A3.BackColor == A4.BackColor) && (A3.BackColor == A5.BackColor) && (A2.Enabled))
                return A2;
            if ((A4.BackColor == Color.LightGreen) && (A4.BackColor == A5.BackColor) && (A4.BackColor == A6.BackColor) && (A7.Enabled))
                return A7;
            if ((A4.BackColor == Color.LightGreen) && (A4.BackColor == A5.BackColor) && (A4.BackColor == A6.BackColor) && (A3.Enabled))
                return A3;
            if ((A5.BackColor == Color.LightGreen) && (A5.BackColor == A6.BackColor) && (A5.BackColor == A7.BackColor) && (A4.Enabled))
                return A4;

            if ((B1.BackColor == Color.LightGreen) && (B1.BackColor == B2.BackColor) && (B1.BackColor == B3.BackColor) && (B4.Enabled))
                return B4;
            if ((B2.BackColor == Color.LightGreen) && (B2.BackColor == B3.BackColor) && (B2.BackColor == B4.BackColor) && (B5.Enabled))
                return B5;
            if ((B2.BackColor == Color.LightGreen) && (B2.BackColor == B3.BackColor) && (B2.BackColor == B4.BackColor) && (B1.Enabled))
                return B1;
            if ((B3.BackColor == Color.LightGreen) && (B3.BackColor == B4.BackColor) && (B3.BackColor == B5.BackColor) && (B6.Enabled))
                return B6;
            if ((B3.BackColor == Color.LightGreen) && (B3.BackColor == B4.BackColor) && (B3.BackColor == B5.BackColor) && (B2.Enabled))
                return B2;
            if ((B4.BackColor == Color.LightGreen) && (B4.BackColor == B5.BackColor) && (B4.BackColor == B6.BackColor) && (B7.Enabled))
                return B7;
            if ((B4.BackColor == Color.LightGreen) && (B4.BackColor == B5.BackColor) && (B4.BackColor == B6.BackColor) && (B3.Enabled))
                return B3;
            if ((B5.BackColor == Color.LightGreen) && (B5.BackColor == B6.BackColor) && (B5.BackColor == B7.BackColor) && (B4.Enabled))
                return B4;

            if ((C1.BackColor == Color.LightGreen) && (C1.BackColor == C2.BackColor) && (C1.BackColor == C3.BackColor) && (C4.Enabled))
                return C4;
            if ((C2.BackColor == Color.LightGreen) && (C2.BackColor == C3.BackColor) && (C2.BackColor == C4.BackColor) && (C5.Enabled))
                return C5;
            if ((C2.BackColor == Color.LightGreen) && (C2.BackColor == C3.BackColor) && (C2.BackColor == C4.BackColor) && (C1.Enabled))
                return C1;
            if ((C3.BackColor == Color.LightGreen) && (C3.BackColor == C4.BackColor) && (C3.BackColor == C5.BackColor) && (C6.Enabled))
                return C6;
            if ((C3.BackColor == Color.LightGreen) && (C3.BackColor == C4.BackColor) && (C3.BackColor == C5.BackColor) && (C2.Enabled))
                return C2;
            if ((C4.BackColor == Color.LightGreen) && (C4.BackColor == C5.BackColor) && (C4.BackColor == C6.BackColor) && (C7.Enabled))
                return C7;
            if ((C4.BackColor == Color.LightGreen) && (C4.BackColor == C5.BackColor) && (C4.BackColor == C6.BackColor) && (C3.Enabled))
                return C3;
            if ((C5.BackColor == Color.LightGreen) && (C5.BackColor == C6.BackColor) && (C5.BackColor == C7.BackColor) && (C4.Enabled))
                return C4;

            if ((D1.BackColor == Color.LightGreen) && (D1.BackColor == D2.BackColor) && (D1.BackColor == D3.BackColor) && (D4.Enabled))
                return D4;
            if ((D2.BackColor == Color.LightGreen) && (D2.BackColor == D3.BackColor) && (D2.BackColor == D4.BackColor) && (D5.Enabled))
                return D5;
            if ((D2.BackColor == Color.LightGreen) && (D2.BackColor == D3.BackColor) && (D2.BackColor == D4.BackColor) && (D1.Enabled))
                return D1;
            if ((D3.BackColor == Color.LightGreen) && (D3.BackColor == D4.BackColor) && (D3.BackColor == D5.BackColor) && (D6.Enabled))
                return D6;
            if ((D3.BackColor == Color.LightGreen) && (D3.BackColor == D4.BackColor) && (D3.BackColor == D5.BackColor) && (D2.Enabled))
                return D2;
            if ((D4.BackColor == Color.LightGreen) && (D4.BackColor == D5.BackColor) && (D4.BackColor == D6.BackColor) && (D7.Enabled))
                return D7;
            if ((D4.BackColor == Color.LightGreen) && (D4.BackColor == D5.BackColor) && (D4.BackColor == D6.BackColor) && (D3.Enabled))
                return D3;
            if ((D5.BackColor == Color.LightGreen) && (D5.BackColor == D6.BackColor) && (D5.BackColor == D7.BackColor) && (D4.Enabled))
                return D4;

            if ((E1.BackColor == Color.LightGreen) && (E1.BackColor == E2.BackColor) && (E1.BackColor == E3.BackColor) && (E4.Enabled))
                return E4;
            if ((E2.BackColor == Color.LightGreen) && (E2.BackColor == E3.BackColor) && (E2.BackColor == E4.BackColor) && (E5.Enabled))
                return E5;
            if ((E2.BackColor == Color.LightGreen) && (E2.BackColor == E3.BackColor) && (E2.BackColor == E4.BackColor) && (E1.Enabled))
                return E1;
            if ((E3.BackColor == Color.LightGreen) && (E3.BackColor == E4.BackColor) && (E3.BackColor == E5.BackColor) && (E6.Enabled))
                return E6;
            if ((E3.BackColor == Color.LightGreen) && (E3.BackColor == E4.BackColor) && (E3.BackColor == E5.BackColor) && (E2.Enabled))
                return E2;
            if ((E4.BackColor == Color.LightGreen) && (E4.BackColor == E5.BackColor) && (E4.BackColor == E6.BackColor) && (E7.Enabled))
                return E7;
            if ((E4.BackColor == Color.LightGreen) && (E4.BackColor == E5.BackColor) && (E4.BackColor == E6.BackColor) && (E3.Enabled))
                return E3;
            if ((E5.BackColor == Color.LightGreen) && (E5.BackColor == E6.BackColor) && (E5.BackColor == E7.BackColor) && (E4.Enabled))
                return E4;

            if ((F1.BackColor == Color.LightGreen) && (F1.BackColor == F2.BackColor) && (F1.BackColor == F3.BackColor) && (F4.Enabled))
                return F4;
            if ((F2.BackColor == Color.LightGreen) && (F2.BackColor == F3.BackColor) && (F2.BackColor == F4.BackColor) && (F5.Enabled))
                return F5;
            if ((F2.BackColor == Color.LightGreen) && (F2.BackColor == F3.BackColor) && (F2.BackColor == F4.BackColor) && (F1.Enabled))
                return F1;
            if ((F3.BackColor == Color.LightGreen) && (F3.BackColor == F4.BackColor) && (F3.BackColor == F5.BackColor) && (F6.Enabled))
                return F6;
            if ((F3.BackColor == Color.LightGreen) && (F3.BackColor == F4.BackColor) && (F3.BackColor == F5.BackColor) && (F2.Enabled))
                return F2;
            if ((F4.BackColor == Color.LightGreen) && (F4.BackColor == F5.BackColor) && (F4.BackColor == F6.BackColor) && (F7.Enabled))
                return F7;
            if ((F4.BackColor == Color.LightGreen) && (F4.BackColor == F5.BackColor) && (F4.BackColor == F6.BackColor) && (F3.Enabled))
                return F3;
            if ((F5.BackColor == Color.LightGreen) && (F5.BackColor == F6.BackColor) && (F5.BackColor == F7.BackColor) && (F4.Enabled))
                return F4;

            // vertical checks

            if ((F1.BackColor == Color.LightGreen) && (F1.BackColor == E1.BackColor) && (F1.BackColor == D1.BackColor) && (C1.Enabled))
                return C1;
            if ((E1.BackColor == Color.LightGreen) && (E1.BackColor == D1.BackColor) && (E1.BackColor == C1.BackColor) && (B1.Enabled))
                return B1;
            if ((D1.BackColor == Color.LightGreen) && (D1.BackColor == C1.BackColor) && (D1.BackColor == B1.BackColor) && (A1.Enabled))
                return A1;

            if ((F2.BackColor == Color.LightGreen) && (F2.BackColor == E2.BackColor) && (F2.BackColor == D2.BackColor) && (C2.Enabled))
                return C2;
            if ((E2.BackColor == Color.LightGreen) && (E2.BackColor == D2.BackColor) && (E2.BackColor == C2.BackColor) && (B2.Enabled))
                return B2;
            if ((D2.BackColor == Color.LightGreen) && (D2.BackColor == C2.BackColor) && (D2.BackColor == B2.BackColor) && (A2.Enabled))
                return A2;

            if ((F3.BackColor == Color.LightGreen) && (F3.BackColor == E3.BackColor) && (F3.BackColor == D3.BackColor) && (C3.Enabled))
                return C3;
            if ((E3.BackColor == Color.LightGreen) && (E3.BackColor == D3.BackColor) && (E3.BackColor == C3.BackColor) && (B3.Enabled))
                return B3;
            if ((D3.BackColor == Color.LightGreen) && (D3.BackColor == C3.BackColor) && (D3.BackColor == B3.BackColor) && (A3.Enabled))
                return A3;

            if ((F4.BackColor == Color.LightGreen) && (F4.BackColor == E4.BackColor) && (F4.BackColor == D4.BackColor) && (C4.Enabled))
                return C4;
            if ((E4.BackColor == Color.LightGreen) && (E4.BackColor == D4.BackColor) && (E4.BackColor == C4.BackColor) && (B4.Enabled))
                return B4;
            if ((D4.BackColor == Color.LightGreen) && (D4.BackColor == C4.BackColor) && (D4.BackColor == B4.BackColor) && (A4.Enabled))
                return A4;

            if ((F5.BackColor == Color.LightGreen) && (F5.BackColor == E5.BackColor) && (F5.BackColor == D5.BackColor) && (C5.Enabled))
                return C5;
            if ((E5.BackColor == Color.LightGreen) && (E5.BackColor == D5.BackColor) && (E5.BackColor == C5.BackColor) && (B5.Enabled))
                return B5;
            if ((D5.BackColor == Color.LightGreen) && (D5.BackColor == C5.BackColor) && (D5.BackColor == B5.BackColor) && (A5.Enabled))
                return A5;

            if ((F6.BackColor == Color.LightGreen) && (F6.BackColor == E6.BackColor) && (F6.BackColor == D6.BackColor) && (C6.Enabled))
                return C6;
            if ((E6.BackColor == Color.LightGreen) && (E6.BackColor == D6.BackColor) && (E6.BackColor == C6.BackColor) && (B6.Enabled))
                return B6;
            if ((D6.BackColor == Color.LightGreen) && (D6.BackColor == C6.BackColor) && (D6.BackColor == B6.BackColor) && (A6.Enabled))
                return A6;

            if ((F7.BackColor == Color.LightGreen) && (F7.BackColor == E7.BackColor) && (F7.BackColor == D7.BackColor) && (C7.Enabled))
                return C7;
            if ((E7.BackColor == Color.LightGreen) && (E7.BackColor == D7.BackColor) && (E7.BackColor == C7.BackColor) && (B7.Enabled))
                return B7;
            if ((D7.BackColor == Color.LightGreen) && (D7.BackColor == C7.BackColor) && (D7.BackColor == B7.BackColor) && (A7.Enabled))
                return A7;

            // diagonal checks

            if ((F1.BackColor == Color.LightGreen) && (F1.BackColor == E2.BackColor) && (F1.BackColor == D3.BackColor) && (C4.Enabled))
                return C4;
            if ((F2.BackColor == Color.LightGreen) && (F2.BackColor == E3.BackColor) && (F2.BackColor == D4.BackColor) && (C5.Enabled))
                return C5;
            if ((F3.BackColor == Color.LightGreen) && (F3.BackColor == E4.BackColor) && (F3.BackColor == D5.BackColor) && (C6.Enabled))
                return C6;
            if ((F4.BackColor == Color.LightGreen) && (F4.BackColor == E5.BackColor) && (F4.BackColor == D6.BackColor) && (C7.Enabled))
                return C7;
            if ((F4.BackColor == Color.LightGreen) && (F4.BackColor == E3.BackColor) && (F4.BackColor == D2.BackColor) && (C1.Enabled))
                return C1;
            if ((F5.BackColor == Color.LightGreen) && (F5.BackColor == E4.BackColor) && (F5.BackColor == D3.BackColor) && (C2.Enabled))
                return C1;
            if ((F6.BackColor == Color.LightGreen) && (F6.BackColor == E5.BackColor) && (F6.BackColor == D4.BackColor) && (C3.Enabled))
                return C3;
            if ((F7.BackColor == Color.LightGreen) && (F7.BackColor == E6.BackColor) && (F7.BackColor == D5.BackColor) && (C4.Enabled))
                return C4;

            if ((E1.BackColor == Color.LightGreen) && (E1.BackColor == D2.BackColor) && (E1.BackColor == C3.BackColor) && (B4.Enabled))
                return B4;
            if ((E2.BackColor == Color.LightGreen) && (E2.BackColor == D3.BackColor) && (E2.BackColor == C4.BackColor) && (B5.Enabled))
                return B5;
            if ((E3.BackColor == Color.LightGreen) && (E3.BackColor == D4.BackColor) && (E3.BackColor == C5.BackColor) && (B6.Enabled))
                return B6;
            if ((E4.BackColor == Color.LightGreen) && (E4.BackColor == D5.BackColor) && (E4.BackColor == C6.BackColor) && (B7.Enabled))
                return B7;
            if ((E4.BackColor == Color.LightGreen) && (E4.BackColor == D3.BackColor) && (E4.BackColor == C2.BackColor) && (B1.Enabled))
                return B1;
            if ((E5.BackColor == Color.LightGreen) && (E5.BackColor == D4.BackColor) && (E5.BackColor == C3.BackColor) && (B2.Enabled))
                return B1;
            if ((E6.BackColor == Color.LightGreen) && (E6.BackColor == D5.BackColor) && (E6.BackColor == C4.BackColor) && (B3.Enabled))
                return B3;
            if ((E7.BackColor == Color.LightGreen) && (E7.BackColor == D6.BackColor) && (E7.BackColor == C5.BackColor) && (B4.Enabled))
                return B4;

            if ((D1.BackColor == Color.LightGreen) && (D1.BackColor == C2.BackColor) && (D1.BackColor == B3.BackColor) && (A4.Enabled))
                return A4;
            if ((D2.BackColor == Color.LightGreen) && (D2.BackColor == C3.BackColor) && (D2.BackColor == B4.BackColor) && (A5.Enabled))
                return A5;
            if ((D3.BackColor == Color.LightGreen) && (D3.BackColor == C4.BackColor) && (D3.BackColor == B5.BackColor) && (A6.Enabled))
                return A6;
            if ((D4.BackColor == Color.LightGreen) && (D4.BackColor == C5.BackColor) && (D4.BackColor == B6.BackColor) && (A7.Enabled))
                return A7;
            if ((D4.BackColor == Color.LightGreen) && (D4.BackColor == C3.BackColor) && (D4.BackColor == B2.BackColor) && (A1.Enabled))
                return A1;
            if ((D5.BackColor == Color.LightGreen) && (D5.BackColor == C4.BackColor) && (D5.BackColor == B3.BackColor) && (A2.Enabled))
                return A1;
            if ((D6.BackColor == Color.LightGreen) && (D6.BackColor == C5.BackColor) && (D6.BackColor == B4.BackColor) && (A3.Enabled))
                return A3;
            if ((D7.BackColor == Color.LightGreen) && (D7.BackColor == C6.BackColor) && (D7.BackColor == B5.BackColor) && (A4.Enabled))
                return A4;

            return null;
        }

        private Button look_for_pink_two()
        {
            Console.WriteLine("Thinking rationally...");

            // horizontal checks
            if ((A1.BackColor == Color.LightPink) && (A1.BackColor == A2.BackColor) && (A3.Enabled))
                return A3;
            if ((A2.BackColor == Color.LightPink) && (A2.BackColor == A3.BackColor) && (A4.Enabled))
                return A4;
            if ((A2.BackColor == Color.LightPink) && (A2.BackColor == A3.BackColor) && (A1.Enabled))
                return A1;
            if ((A3.BackColor == Color.LightPink) && (A3.BackColor == A4.BackColor) && (A5.Enabled))
                return A5;
            if ((A3.BackColor == Color.LightPink) && (A3.BackColor == A4.BackColor) && (A2.Enabled))
                return A2;
            if ((A4.BackColor == Color.LightPink) && (A4.BackColor == A5.BackColor) && (A3.Enabled))
                return A3;
            if ((A4.BackColor == Color.LightPink) && (A4.BackColor == A5.BackColor) && (A6.Enabled))
                return A6;
            if ((A5.BackColor == Color.LightPink) && (A5.BackColor == A6.BackColor) && (A4.Enabled))
                return A4;
            if ((A5.BackColor == Color.LightPink) && (A5.BackColor == A6.BackColor) && (A7.Enabled))
                return A7;
            if ((A6.BackColor == Color.LightPink) && (A6.BackColor == A7.BackColor) && (A5.Enabled))
                return A5;

            if ((B1.BackColor == Color.LightPink) && (B1.BackColor == B2.BackColor) && (B3.Enabled))
                return B3;
            if ((B2.BackColor == Color.LightPink) && (B2.BackColor == B3.BackColor) && (B4.Enabled))
                return B4;
            if ((B2.BackColor == Color.LightPink) && (B2.BackColor == B3.BackColor) && (B1.Enabled))
                return B1;
            if ((B3.BackColor == Color.LightPink) && (B3.BackColor == B4.BackColor) && (B5.Enabled))
                return B5;
            if ((B3.BackColor == Color.LightPink) && (B3.BackColor == B4.BackColor) && (B2.Enabled))
                return B2;
            if ((B4.BackColor == Color.LightPink) && (B4.BackColor == B5.BackColor) && (B3.Enabled))
                return B3;
            if ((B4.BackColor == Color.LightPink) && (B4.BackColor == B5.BackColor) && (B6.Enabled))
                return B6;
            if ((B5.BackColor == Color.LightPink) && (B5.BackColor == B6.BackColor) && (B4.Enabled))
                return B4;
            if ((B5.BackColor == Color.LightPink) && (B5.BackColor == B6.BackColor) && (B7.Enabled))
                return B7;
            if ((B6.BackColor == Color.LightPink) && (B6.BackColor == B7.BackColor) && (B5.Enabled))
                return B5;

            if ((C1.BackColor == Color.LightPink) && (C1.BackColor == C2.BackColor) && (C3.Enabled))
                return C3;
            if ((C2.BackColor == Color.LightPink) && (C2.BackColor == C3.BackColor) && (C4.Enabled))
                return C4;
            if ((C2.BackColor == Color.LightPink) && (C2.BackColor == C3.BackColor) && (C1.Enabled))
                return C1;
            if ((C3.BackColor == Color.LightPink) && (C3.BackColor == C4.BackColor) && (C5.Enabled))
                return C5;
            if ((C3.BackColor == Color.LightPink) && (C3.BackColor == C4.BackColor) && (C2.Enabled))
                return C2;
            if ((C4.BackColor == Color.LightPink) && (C4.BackColor == C5.BackColor) && (C3.Enabled))
                return C3;
            if ((C4.BackColor == Color.LightPink) && (C4.BackColor == C5.BackColor) && (C6.Enabled))
                return C6;
            if ((C5.BackColor == Color.LightPink) && (C5.BackColor == C6.BackColor) && (C4.Enabled))
                return C4;
            if ((C5.BackColor == Color.LightPink) && (C5.BackColor == C6.BackColor) && (C7.Enabled))
                return C7;
            if ((C6.BackColor == Color.LightPink) && (C6.BackColor == C7.BackColor) && (C5.Enabled))
                return C5;

            if ((D1.BackColor == Color.LightPink) && (D1.BackColor == D2.BackColor) && (D3.Enabled))
                return D3;
            if ((D2.BackColor == Color.LightPink) && (D2.BackColor == D3.BackColor) && (D4.Enabled))
                return D4;
            if ((D2.BackColor == Color.LightPink) && (D2.BackColor == D3.BackColor) && (D1.Enabled))
                return D1;
            if ((D3.BackColor == Color.LightPink) && (D3.BackColor == D4.BackColor) && (D5.Enabled))
                return D5;
            if ((D3.BackColor == Color.LightPink) && (D3.BackColor == D4.BackColor) && (D2.Enabled))
                return D2;
            if ((D4.BackColor == Color.LightPink) && (D4.BackColor == D5.BackColor) && (D3.Enabled))
                return D3;
            if ((D4.BackColor == Color.LightPink) && (D4.BackColor == D5.BackColor) && (D6.Enabled))
                return D6;
            if ((D5.BackColor == Color.LightPink) && (D5.BackColor == D6.BackColor) && (D4.Enabled))
                return D4;
            if ((D5.BackColor == Color.LightPink) && (D5.BackColor == D6.BackColor) && (D7.Enabled))
                return D7;
            if ((D6.BackColor == Color.LightPink) && (D6.BackColor == D7.BackColor) && (D5.Enabled))
                return D5;

            if ((E1.BackColor == Color.LightPink) && (E1.BackColor == E2.BackColor) && (E3.Enabled))
                return E3;
            if ((E2.BackColor == Color.LightPink) && (E2.BackColor == E3.BackColor) && (E4.Enabled))
                return E4;
            if ((E2.BackColor == Color.LightPink) && (E2.BackColor == E3.BackColor) && (E1.Enabled))
                return E1;
            if ((E3.BackColor == Color.LightPink) && (E3.BackColor == E4.BackColor) && (E5.Enabled))
                return E5;
            if ((E3.BackColor == Color.LightPink) && (E3.BackColor == E4.BackColor) && (E2.Enabled))
                return E2;
            if ((E4.BackColor == Color.LightPink) && (E4.BackColor == E5.BackColor) && (E3.Enabled))
                return E3;
            if ((E4.BackColor == Color.LightPink) && (E4.BackColor == E5.BackColor) && (E6.Enabled))
                return E6;
            if ((E5.BackColor == Color.LightPink) && (E5.BackColor == E6.BackColor) && (E4.Enabled))
                return E4;
            if ((E5.BackColor == Color.LightPink) && (E5.BackColor == E6.BackColor) && (E7.Enabled))
                return E7;
            if ((E6.BackColor == Color.LightPink) && (E6.BackColor == E7.BackColor) && (E5.Enabled))
                return E5;

            if ((F1.BackColor == Color.LightPink) && (F1.BackColor == F2.BackColor) && (F3.Enabled))
                return F3;
            if ((F2.BackColor == Color.LightPink) && (F2.BackColor == F3.BackColor) && (F4.Enabled))
                return F4;
            if ((F2.BackColor == Color.LightPink) && (F2.BackColor == F3.BackColor) && (F1.Enabled))
                return F1;
            if ((F3.BackColor == Color.LightPink) && (F3.BackColor == F4.BackColor) && (F5.Enabled))
                return F5;
            if ((F3.BackColor == Color.LightPink) && (F3.BackColor == F4.BackColor) && (F2.Enabled))
                return F2;
            if ((F4.BackColor == Color.LightPink) && (F4.BackColor == F5.BackColor) && (F3.Enabled))
                return F3;
            if ((F4.BackColor == Color.LightPink) && (F4.BackColor == F5.BackColor) && (F6.Enabled))
                return F6;
            if ((F5.BackColor == Color.LightPink) && (F5.BackColor == F6.BackColor) && (F4.Enabled))
                return F4;
            if ((F5.BackColor == Color.LightPink) && (F5.BackColor == F6.BackColor) && (F7.Enabled))
                return F7;
            if ((F6.BackColor == Color.LightPink) && (F6.BackColor == F7.BackColor) && (F5.Enabled))
                return F5;

            // diagonal checks

            if ((F1.BackColor == Color.LightPink) && (F1.BackColor == E2.BackColor) && (D3.Enabled))
                return D3;
            if ((F2.BackColor == Color.LightPink) && (F2.BackColor == E3.BackColor) && (D4.Enabled))
                return D4;
            if ((F3.BackColor == Color.LightPink) && (F3.BackColor == E4.BackColor) && (D5.Enabled))
                return D5;
            if ((F4.BackColor == Color.LightPink) && (F4.BackColor == E5.BackColor) && (D6.Enabled))
                return D6;
            if ((F7.BackColor == Color.LightPink) && (F7.BackColor == E6.BackColor) && (D5.Enabled))
                return D5;
            if ((F6.BackColor == Color.LightPink) && (F6.BackColor == E5.BackColor) && (D4.Enabled))
                return D4;
            if ((F5.BackColor == Color.LightPink) && (F5.BackColor == E4.BackColor) && (D3.Enabled))
                return D3;
            if ((F4.BackColor == Color.LightPink) && (F4.BackColor == E3.BackColor) && (D2.Enabled))
                return D2;

            if ((E1.BackColor == Color.LightPink) && (E1.BackColor == D2.BackColor) && (C3.Enabled))
                return C3;
            if ((E2.BackColor == Color.LightPink) && (E2.BackColor == D3.BackColor) && (C4.Enabled))
                return C4;
            if ((E3.BackColor == Color.LightPink) && (E3.BackColor == D4.BackColor) && (C5.Enabled))
                return C5;
            if ((E4.BackColor == Color.LightPink) && (E4.BackColor == D5.BackColor) && (C6.Enabled))
                return C6;
            if ((E5.BackColor == Color.LightPink) && (E5.BackColor == D6.BackColor) && (C7.Enabled) && (F4.Enabled))
                return F4;
            if ((E7.BackColor == Color.LightPink) && (E7.BackColor == D6.BackColor) && (C5.Enabled))
                return C5;
            if ((E6.BackColor == Color.LightPink) && (E6.BackColor == D5.BackColor) && (C4.Enabled))
                return C4;
            if ((E5.BackColor == Color.LightPink) && (E5.BackColor == D4.BackColor) && (C3.Enabled))
                return C3;
            if ((E4.BackColor == Color.LightPink) && (E4.BackColor == D3.BackColor) && (C2.Enabled))
                return C2;
            if ((E5.BackColor == Color.LightPink) && (E3.BackColor == D2.BackColor) && (C1.Enabled) && (F4.Enabled))
                return F4;

            if ((D1.BackColor == Color.LightPink) && (D1.BackColor == C2.BackColor) && (B3.Enabled))
                return B3;
            if ((D2.BackColor == Color.LightPink) && (D2.BackColor == C3.BackColor) && (B4.Enabled))
                return B4;
            if ((D3.BackColor == Color.LightPink) && (D3.BackColor == C4.BackColor) && (B5.Enabled))
                return B5;
            if ((D4.BackColor == Color.LightPink) && (D4.BackColor == C5.BackColor) && (B6.Enabled))
                return B6;
            if ((D5.BackColor == Color.LightPink) && (D5.BackColor == C6.BackColor) && (B7.Enabled) && (E4.Enabled))
                return E4;
            if ((D7.BackColor == Color.LightPink) && (D7.BackColor == C6.BackColor) && (B5.Enabled))
                return B5;
            if ((D6.BackColor == Color.LightPink) && (D6.BackColor == C5.BackColor) && (B4.Enabled))
                return B4;
            if ((D5.BackColor == Color.LightPink) && (D5.BackColor == C4.BackColor) && (B3.Enabled))
                return B3;
            if ((D4.BackColor == Color.LightPink) && (D4.BackColor == C3.BackColor) && (B2.Enabled))
                return B2;
            if ((D5.BackColor == Color.LightPink) && (D3.BackColor == C2.BackColor) && (B1.Enabled) && (E4.Enabled))
                return E4;

            if ((C1.BackColor == Color.LightPink) && (C1.BackColor == B2.BackColor) && (A3.Enabled))
                return A3;
            if ((C2.BackColor == Color.LightPink) && (C2.BackColor == B3.BackColor) && (A4.Enabled))
                return A4;
            if ((C3.BackColor == Color.LightPink) && (C3.BackColor == B4.BackColor) && (A5.Enabled))
                return A5;
            if ((C4.BackColor == Color.LightPink) && (C4.BackColor == B5.BackColor) && (A6.Enabled))
                return A6;
            if ((C5.BackColor == Color.LightPink) && (C5.BackColor == B6.BackColor) && (A7.Enabled) && (D4.Enabled))
                return D4;
            if ((C7.BackColor == Color.LightPink) && (C7.BackColor == B6.BackColor) && (A5.Enabled))
                return A5;
            if ((C6.BackColor == Color.LightPink) && (C6.BackColor == B5.BackColor) && (A4.Enabled))
                return A4;
            if ((C5.BackColor == Color.LightPink) && (C5.BackColor == B4.BackColor) && (A3.Enabled))
                return A3;
            if ((C4.BackColor == Color.LightPink) && (C4.BackColor == B3.BackColor) && (A2.Enabled))
                return A2;
            if ((C5.BackColor == Color.LightPink) && (C3.BackColor == B2.BackColor) && (A1.Enabled) && (D4.Enabled))
                return D4;

            // no vertical checks needed as three in a line in vertical position can easily be blocked

            return null;
        }

        private Button look_for_green_two()
        {
            Console.WriteLine("Thinking logically...");

            // horizontal checks
            if ((A1.BackColor == Color.LightGreen) && (A1.BackColor == A2.BackColor) && (A3.Enabled))
                return A3;
            if ((A2.BackColor == Color.LightGreen) && (A2.BackColor == A3.BackColor) && (A4.Enabled))
                return A4;
            if ((A2.BackColor == Color.LightGreen) && (A2.BackColor == A3.BackColor) && (A1.Enabled))
                return A1;
            if ((A3.BackColor == Color.LightGreen) && (A3.BackColor == A4.BackColor) && (A5.Enabled))
                return A5;
            if ((A3.BackColor == Color.LightGreen) && (A3.BackColor == A4.BackColor) && (A2.Enabled))
                return A2;
            if ((A4.BackColor == Color.LightGreen) && (A4.BackColor == A5.BackColor) && (A3.Enabled))
                return A3;
            if ((A4.BackColor == Color.LightGreen) && (A4.BackColor == A5.BackColor) && (A6.Enabled))
                return A6;
            if ((A5.BackColor == Color.LightGreen) && (A5.BackColor == A6.BackColor) && (A4.Enabled))
                return A4;
            if ((A5.BackColor == Color.LightGreen) && (A5.BackColor == A6.BackColor) && (A7.Enabled))
                return A7;
            if ((A6.BackColor == Color.LightGreen) && (A6.BackColor == A7.BackColor) && (A5.Enabled))
                return A5;

            if ((B1.BackColor == Color.LightGreen) && (B1.BackColor == B2.BackColor) && (B3.Enabled))
                return B3;
            if ((B2.BackColor == Color.LightGreen) && (B2.BackColor == B3.BackColor) && (B4.Enabled))
                return B4;
            if ((B2.BackColor == Color.LightGreen) && (B2.BackColor == B3.BackColor) && (B1.Enabled))
                return B1;
            if ((B3.BackColor == Color.LightGreen) && (B3.BackColor == B4.BackColor) && (B5.Enabled))
                return B5;
            if ((B3.BackColor == Color.LightGreen) && (B3.BackColor == B4.BackColor) && (B2.Enabled))
                return B2;
            if ((B4.BackColor == Color.LightGreen) && (B4.BackColor == B5.BackColor) && (B3.Enabled))
                return B3;
            if ((B4.BackColor == Color.LightGreen) && (B4.BackColor == B5.BackColor) && (B6.Enabled))
                return B6;
            if ((B5.BackColor == Color.LightGreen) && (B5.BackColor == B6.BackColor) && (B4.Enabled))
                return B4;
            if ((B5.BackColor == Color.LightGreen) && (B5.BackColor == B6.BackColor) && (B7.Enabled))
                return B7;
            if ((B6.BackColor == Color.LightGreen) && (B6.BackColor == B7.BackColor) && (B5.Enabled))
                return B5;

            if ((C1.BackColor == Color.LightGreen) && (C1.BackColor == C2.BackColor) && (C3.Enabled))
                return C3;
            if ((C2.BackColor == Color.LightGreen) && (C2.BackColor == C3.BackColor) && (C4.Enabled))
                return C4;
            if ((C2.BackColor == Color.LightGreen) && (C2.BackColor == C3.BackColor) && (C1.Enabled))
                return C1;
            if ((C3.BackColor == Color.LightGreen) && (C3.BackColor == C4.BackColor) && (C5.Enabled))
                return C5;
            if ((C3.BackColor == Color.LightGreen) && (C3.BackColor == C4.BackColor) && (C2.Enabled))
                return C2;
            if ((C4.BackColor == Color.LightGreen) && (C4.BackColor == C5.BackColor) && (C3.Enabled))
                return C3;
            if ((C4.BackColor == Color.LightGreen) && (C4.BackColor == C5.BackColor) && (C6.Enabled))
                return C6;
            if ((C5.BackColor == Color.LightGreen) && (C5.BackColor == C6.BackColor) && (C4.Enabled))
                return C4;
            if ((C5.BackColor == Color.LightGreen) && (C5.BackColor == C6.BackColor) && (C7.Enabled))
                return C7;
            if ((C6.BackColor == Color.LightGreen) && (C6.BackColor == C7.BackColor) && (C5.Enabled))
                return C5;

            if ((D1.BackColor == Color.LightGreen) && (D1.BackColor == D2.BackColor) && (D3.Enabled))
                return D3;
            if ((D2.BackColor == Color.LightGreen) && (D2.BackColor == D3.BackColor) && (D4.Enabled))
                return D4;
            if ((D2.BackColor == Color.LightGreen) && (D2.BackColor == D3.BackColor) && (D1.Enabled))
                return D1;
            if ((D3.BackColor == Color.LightGreen) && (D3.BackColor == D4.BackColor) && (D5.Enabled))
                return D5;
            if ((D3.BackColor == Color.LightGreen) && (D3.BackColor == D4.BackColor) && (D2.Enabled))
                return D2;
            if ((D4.BackColor == Color.LightGreen) && (D4.BackColor == D5.BackColor) && (D3.Enabled))
                return D3;
            if ((D4.BackColor == Color.LightGreen) && (D4.BackColor == D5.BackColor) && (D6.Enabled))
                return D6;
            if ((D5.BackColor == Color.LightGreen) && (D5.BackColor == D6.BackColor) && (D4.Enabled))
                return D4;
            if ((D5.BackColor == Color.LightGreen) && (D5.BackColor == D6.BackColor) && (D7.Enabled))
                return D7;
            if ((D6.BackColor == Color.LightGreen) && (D6.BackColor == D7.BackColor) && (D5.Enabled))
                return D5;

            if ((E1.BackColor == Color.LightGreen) && (E1.BackColor == E2.BackColor) && (E3.Enabled))
                return E3;
            if ((E2.BackColor == Color.LightGreen) && (E2.BackColor == E3.BackColor) && (E4.Enabled))
                return E4;
            if ((E2.BackColor == Color.LightGreen) && (E2.BackColor == E3.BackColor) && (E1.Enabled))
                return E1;
            if ((E3.BackColor == Color.LightGreen) && (E3.BackColor == E4.BackColor) && (E5.Enabled))
                return E5;
            if ((E3.BackColor == Color.LightGreen) && (E3.BackColor == E4.BackColor) && (E2.Enabled))
                return E2;
            if ((E4.BackColor == Color.LightGreen) && (E4.BackColor == E5.BackColor) && (E3.Enabled))
                return E3;
            if ((E4.BackColor == Color.LightGreen) && (E4.BackColor == E5.BackColor) && (E6.Enabled))
                return E6;
            if ((E5.BackColor == Color.LightGreen) && (E5.BackColor == E6.BackColor) && (E4.Enabled))
                return E4;
            if ((E5.BackColor == Color.LightGreen) && (E5.BackColor == E6.BackColor) && (E7.Enabled))
                return E7;
            if ((E6.BackColor == Color.LightGreen) && (E6.BackColor == E7.BackColor) && (E5.Enabled))
                return E5;

            if ((F1.BackColor == Color.LightGreen) && (F1.BackColor == F2.BackColor) && (F3.Enabled))
                return F3;
            if ((F2.BackColor == Color.LightGreen) && (F2.BackColor == F3.BackColor) && (F4.Enabled))
                return F4;
            if ((F2.BackColor == Color.LightGreen) && (F2.BackColor == F3.BackColor) && (F1.Enabled))
                return F1;
            if ((F3.BackColor == Color.LightGreen) && (F3.BackColor == F4.BackColor) && (F5.Enabled))
                return F5;
            if ((F3.BackColor == Color.LightGreen) && (F3.BackColor == F4.BackColor) && (F2.Enabled))
                return F2;
            if ((F4.BackColor == Color.LightGreen) && (F4.BackColor == F5.BackColor) && (F3.Enabled))
                return F3;
            if ((F4.BackColor == Color.LightGreen) && (F4.BackColor == F5.BackColor) && (F6.Enabled))
                return F6;
            if ((F5.BackColor == Color.LightGreen) && (F5.BackColor == F6.BackColor) && (F4.Enabled))
                return F4;
            if ((F5.BackColor == Color.LightGreen) && (F5.BackColor == F6.BackColor) && (F7.Enabled))
                return F7;
            if ((F6.BackColor == Color.LightGreen) && (F6.BackColor == F7.BackColor) && (F5.Enabled))
                return F5;

            // diagonal checks

            if ((F1.BackColor == Color.LightGreen) && (F1.BackColor == E2.BackColor) && (D3.Enabled))
                return D3;
            if ((F2.BackColor == Color.LightGreen) && (F2.BackColor == E3.BackColor) && (D4.Enabled))
                return D4;
            if ((F3.BackColor == Color.LightGreen) && (F3.BackColor == E4.BackColor) && (D5.Enabled))
                return D5;
            if ((F4.BackColor == Color.LightGreen) && (F4.BackColor == E5.BackColor) && (D6.Enabled))
                return D6;
            if ((F7.BackColor == Color.LightGreen) && (F7.BackColor == E6.BackColor) && (D5.Enabled))
                return D5;
            if ((F6.BackColor == Color.LightGreen) && (F6.BackColor == E5.BackColor) && (D4.Enabled))
                return D4;
            if ((F5.BackColor == Color.LightGreen) && (F5.BackColor == E4.BackColor) && (D3.Enabled))
                return D3;
            if ((F4.BackColor == Color.LightGreen) && (F4.BackColor == E3.BackColor) && (D2.Enabled))
                return D2;

            if ((E1.BackColor == Color.LightGreen) && (E1.BackColor == D2.BackColor) && (C3.Enabled))
                return C3;
            if ((E2.BackColor == Color.LightGreen) && (E2.BackColor == D3.BackColor) && (C4.Enabled))
                return C4;
            if ((E3.BackColor == Color.LightGreen) && (E3.BackColor == D4.BackColor) && (C5.Enabled))
                return C5;
            if ((E4.BackColor == Color.LightGreen) && (E4.BackColor == D5.BackColor) && (C6.Enabled))
                return C6;
            if ((E5.BackColor == Color.LightGreen) && (E5.BackColor == D6.BackColor) && (C7.Enabled) && (F4.Enabled))
                return F4;
            if ((E7.BackColor == Color.LightGreen) && (E7.BackColor == D6.BackColor) && (C5.Enabled))
                return C5;
            if ((E6.BackColor == Color.LightGreen) && (E6.BackColor == D5.BackColor) && (C4.Enabled))
                return C4;
            if ((E5.BackColor == Color.LightGreen) && (E5.BackColor == D4.BackColor) && (C3.Enabled))
                return C3;
            if ((E4.BackColor == Color.LightGreen) && (E4.BackColor == D3.BackColor) && (C2.Enabled))
                return C2;
            if ((E5.BackColor == Color.LightGreen) && (E3.BackColor == D2.BackColor) && (C1.Enabled) && (F4.Enabled))
                return F4;

            if ((D1.BackColor == Color.LightGreen) && (D1.BackColor == C2.BackColor) && (B3.Enabled))
                return B3;
            if ((D2.BackColor == Color.LightGreen) && (D2.BackColor == C3.BackColor) && (B4.Enabled))
                return B4;
            if ((D3.BackColor == Color.LightGreen) && (D3.BackColor == C4.BackColor) && (B5.Enabled))
                return B5;
            if ((D4.BackColor == Color.LightGreen) && (D4.BackColor == C5.BackColor) && (B6.Enabled))
                return B6;
            if ((D5.BackColor == Color.LightGreen) && (D5.BackColor == C6.BackColor) && (B7.Enabled) && (E4.Enabled))
                return E4;
            if ((D7.BackColor == Color.LightGreen) && (D7.BackColor == C6.BackColor) && (B5.Enabled))
                return B5;
            if ((D6.BackColor == Color.LightGreen) && (D6.BackColor == C5.BackColor) && (B4.Enabled))
                return B4;
            if ((D5.BackColor == Color.LightGreen) && (D5.BackColor == C4.BackColor) && (B3.Enabled))
                return B3;
            if ((D4.BackColor == Color.LightGreen) && (D4.BackColor == C3.BackColor) && (B2.Enabled))
                return B2;
            if ((D5.BackColor == Color.LightGreen) && (D3.BackColor == C2.BackColor) && (B1.Enabled) && (E4.Enabled))
                return E4;

            if ((C1.BackColor == Color.LightGreen) && (C1.BackColor == B2.BackColor) && (A3.Enabled))
                return A3;
            if ((C2.BackColor == Color.LightGreen) && (C2.BackColor == B3.BackColor) && (A4.Enabled))
                return A4;
            if ((C3.BackColor == Color.LightGreen) && (C3.BackColor == B4.BackColor) && (A5.Enabled))
                return A5;
            if ((C4.BackColor == Color.LightGreen) && (C4.BackColor == B5.BackColor) && (A6.Enabled))
                return A6;
            if ((C5.BackColor == Color.LightGreen) && (C5.BackColor == B6.BackColor) && (A7.Enabled) && (D4.Enabled))
                return D4;
            if ((C7.BackColor == Color.LightGreen) && (C7.BackColor == B6.BackColor) && (A5.Enabled))
                return A5;
            if ((C6.BackColor == Color.LightGreen) && (C6.BackColor == B5.BackColor) && (A4.Enabled))
                return A4;
            if ((C5.BackColor == Color.LightGreen) && (C5.BackColor == B4.BackColor) && (A3.Enabled))
                return A3;
            if ((C4.BackColor == Color.LightGreen) && (C4.BackColor == B3.BackColor) && (A2.Enabled))
                return A2;
            if ((C5.BackColor == Color.LightGreen) && (C3.BackColor == B2.BackColor) && (A1.Enabled) && (D4.Enabled))
                return D4; 

            return null;
        }


        private Button look_for_middle()
        {
            Console.WriteLine("Calculating strategy...");

            if (F4.Enabled)
                return F4;
            if (F3.Enabled)
                return F3;
            if (F5.Enabled)
                return F5;
            if (F6.Enabled)
                return F6;
            if (F2.Enabled)
                return F2;

            if (E4.Enabled)
                return E4;
            if (E3.Enabled)
                return E3;
            if (E5.Enabled)
                return E5;
            if (E6.Enabled)
                return E6;
            if (E2.Enabled)
                return E2;

            if (D4.Enabled)
                return D4;
            if (D3.Enabled)
                return D3;
            if (D5.Enabled)
                return D5;
            if (D6.Enabled)
                return D6;
            if (D2.Enabled)
                return D2;

            if (C4.Enabled)
                return C4;
            if (C3.Enabled)
                return C3;
            if (C5.Enabled)
                return C5;
            if (C6.Enabled)
                return C6;
            if (C2.Enabled)
                return C2;

            if (B4.Enabled)
                return B4;
            if (B3.Enabled)
                return B3;
            if (B5.Enabled)
                return B5;
            if (B6.Enabled)
                return B6;
            if (B2.Enabled)
                return B2;

            if (A4.Enabled)
                return A4;
            if (A3.Enabled)
                return A3;
            if (A5.Enabled)
                return A5;
            if (A6.Enabled)
                return A6;
            if (A2.Enabled)
                return A2;

            return null;
        }

        private Button look_for_space()
        {
            Console.WriteLine("Looking for open space...");

            if (F1.Enabled)
                return F1;
            if (F7.Enabled)
                return F7;

            if (E7.Enabled)
                return E7;
            if (E1.Enabled)
                return E1;

            if (D7.Enabled)
                return D7;
            if (D1.Enabled)
                return D1;

            if (C7.Enabled)
                return C7;
            if (C1.Enabled)
                return C1;

            if (B7.Enabled)
                return B7;
            if (B1.Enabled)
                return B1;

            if (A7.Enabled)
                return A7;
            if (A1.Enabled)
                return A1;

            return null;
        }

        private void CheckForWinner()
        {
            bool there_is_a_winner = false;

            // horizontal checks
            if (((A1.BackColor == Color.LightGreen) || (A1.BackColor == Color.LightPink)) &&
                (A1.BackColor == A2.BackColor) && (A1.BackColor == A3.BackColor) && (A1.BackColor == A4.BackColor))
                there_is_a_winner = true;
            if (((A5.BackColor == Color.LightGreen) || (A5.BackColor == Color.LightPink)) &&
                (A2.BackColor == A3.BackColor) && (A2.BackColor == A4.BackColor) && (A2.BackColor == A5.BackColor))
                there_is_a_winner = true;
            if (((A5.BackColor == Color.LightGreen) || (A5.BackColor == Color.LightPink)) &&
                (A3.BackColor == A4.BackColor) && (A3.BackColor == A5.BackColor) && (A3.BackColor == A6.BackColor))
                there_is_a_winner = true;
            if (((A5.BackColor == Color.LightGreen) || (A5.BackColor == Color.LightPink)) &&
                (A4.BackColor == A5.BackColor) && (A4.BackColor == A6.BackColor) && (A4.BackColor == A7.BackColor))
                there_is_a_winner = true;
            if (((B1.BackColor == Color.LightGreen) || (B1.BackColor == Color.LightPink)) &&
                (B1.BackColor == B2.BackColor) && (B1.BackColor == B3.BackColor) && (B1.BackColor == B4.BackColor))
                there_is_a_winner = true;
            if (((B5.BackColor == Color.LightGreen) || (B5.BackColor == Color.LightPink)) &&
                (B2.BackColor == B3.BackColor) && (B2.BackColor == B4.BackColor) && (B2.BackColor == B5.BackColor))
                there_is_a_winner = true;
            if (((B5.BackColor == Color.LightGreen) || (B5.BackColor == Color.LightPink)) &&
                (B3.BackColor == B4.BackColor) && (B3.BackColor == B5.BackColor) && (B3.BackColor == B6.BackColor))
                there_is_a_winner = true;
            if (((B5.BackColor == Color.LightGreen) || (B5.BackColor == Color.LightPink)) &&
                (B4.BackColor == B5.BackColor) && (B4.BackColor == B6.BackColor) && (B4.BackColor == B7.BackColor))
                there_is_a_winner = true;
            if (((C1.BackColor == Color.LightGreen) || (C1.BackColor == Color.LightPink)) &&
                (C1.BackColor == C2.BackColor) && (C1.BackColor == C3.BackColor) && (C1.BackColor == C4.BackColor))
                there_is_a_winner = true;
            if (((C5.BackColor == Color.LightGreen) || (C5.BackColor == Color.LightPink)) &&
                (C2.BackColor == C3.BackColor) && (C2.BackColor == C4.BackColor) && (C2.BackColor == C5.BackColor))
                there_is_a_winner = true;
            if (((C5.BackColor == Color.LightGreen) || (C5.BackColor == Color.LightPink)) &&
                (C3.BackColor == C4.BackColor) && (C3.BackColor == C5.BackColor) && (C3.BackColor == C6.BackColor))
                there_is_a_winner = true;
            if (((C5.BackColor == Color.LightGreen) || (C5.BackColor == Color.LightPink)) &&
                (C4.BackColor == C5.BackColor) && (C4.BackColor == C6.BackColor) && (C4.BackColor == C7.BackColor))
                there_is_a_winner = true;
            if (((D1.BackColor == Color.LightGreen) || (D1.BackColor == Color.LightPink)) &&
                (D1.BackColor == D2.BackColor) && (D1.BackColor == D3.BackColor) && (D1.BackColor == D4.BackColor))
                there_is_a_winner = true;
            if (((D5.BackColor == Color.LightGreen) || (D5.BackColor == Color.LightPink)) &&
                (D2.BackColor == D3.BackColor) && (D2.BackColor == D4.BackColor) && (D2.BackColor == D5.BackColor))
                there_is_a_winner = true;
            if (((D5.BackColor == Color.LightGreen) || (D5.BackColor == Color.LightPink)) &&
                (D3.BackColor == D4.BackColor) && (D3.BackColor == D5.BackColor) && (D3.BackColor == D6.BackColor))
                there_is_a_winner = true;
            if (((D5.BackColor == Color.LightGreen) || (D5.BackColor == Color.LightPink)) &&
                (D4.BackColor == D5.BackColor) && (D4.BackColor == D6.BackColor) && (D4.BackColor == D7.BackColor))
                there_is_a_winner = true;
            if (((E1.BackColor == Color.LightGreen) || (E1.BackColor == Color.LightPink)) &&
                (E1.BackColor == E2.BackColor) && (E1.BackColor == E3.BackColor) && (E1.BackColor == E4.BackColor))
                there_is_a_winner = true;
            if (((E5.BackColor == Color.LightGreen) || (E5.BackColor == Color.LightPink)) &&
                (E2.BackColor == E3.BackColor) && (E2.BackColor == E4.BackColor) && (E2.BackColor == E5.BackColor))
                there_is_a_winner = true;
            if (((E5.BackColor == Color.LightGreen) || (E5.BackColor == Color.LightPink)) &&
                (E3.BackColor == E4.BackColor) && (E3.BackColor == E5.BackColor) && (E3.BackColor == E6.BackColor))
                there_is_a_winner = true;
            if (((E5.BackColor == Color.LightGreen) || (E5.BackColor == Color.LightPink)) &&
                (E4.BackColor == E5.BackColor) && (E4.BackColor == E6.BackColor) && (E4.BackColor == E7.BackColor))
                there_is_a_winner = true;
            if (((F1.BackColor == Color.LightGreen) || (F1.BackColor == Color.LightPink)) &&
                (F1.BackColor == F2.BackColor) && (F1.BackColor == F3.BackColor) && (F1.BackColor == F4.BackColor))
                there_is_a_winner = true;
            if (((F5.BackColor == Color.LightGreen) || (F5.BackColor == Color.LightPink)) &&
                (F2.BackColor == F3.BackColor) && (F2.BackColor == F4.BackColor) && (F2.BackColor == F5.BackColor))
                there_is_a_winner = true;
            if (((F5.BackColor == Color.LightGreen) || (F5.BackColor == Color.LightPink)) &&
                (F3.BackColor == F4.BackColor) && (F3.BackColor == F5.BackColor) && (F3.BackColor == F6.BackColor))
                there_is_a_winner = true;
            if (((F5.BackColor == Color.LightGreen) || (F5.BackColor == Color.LightPink)) &&
                (F4.BackColor == F5.BackColor) && (F4.BackColor == F6.BackColor) && (F4.BackColor == F7.BackColor))
                there_is_a_winner = true;

            // vertical checks
            if (((A1.BackColor == Color.LightGreen) || (A1.BackColor == Color.LightPink)) &&
                (A1.BackColor == B1.BackColor) && (A1.BackColor == C1.BackColor) && (A1.BackColor == D1.BackColor))
                there_is_a_winner = true;
            if (((E1.BackColor == Color.LightGreen) || (E1.BackColor == Color.LightPink)) &&
                (B1.BackColor == C1.BackColor) && (B1.BackColor == D1.BackColor) && (B1.BackColor == E1.BackColor))
                there_is_a_winner = true;
            if (((E1.BackColor == Color.LightGreen) || (E1.BackColor == Color.LightPink)) &&
                (C1.BackColor == D1.BackColor) && (C1.BackColor == E1.BackColor) && (C1.BackColor == F1.BackColor))
                there_is_a_winner = true;
            if (((A2.BackColor == Color.LightGreen) || (A2.BackColor == Color.LightPink)) &&
                (A2.BackColor == B2.BackColor) && (A2.BackColor == C2.BackColor) && (A2.BackColor == D2.BackColor))
                there_is_a_winner = true;
            if (((E2.BackColor == Color.LightGreen) || (E2.BackColor == Color.LightPink)) &&
                (B2.BackColor == C2.BackColor) && (B2.BackColor == D2.BackColor) && (B2.BackColor == E2.BackColor))
                there_is_a_winner = true;
            if (((E2.BackColor == Color.LightGreen) || (E2.BackColor == Color.LightPink)) &&
                (C2.BackColor == D2.BackColor) && (C2.BackColor == E2.BackColor) && (C2.BackColor == F2.BackColor))
                there_is_a_winner = true;
            if (((A3.BackColor == Color.LightGreen) || (A3.BackColor == Color.LightPink)) &&
                (A3.BackColor == B3.BackColor) && (A3.BackColor == C3.BackColor) && (A3.BackColor == D3.BackColor))
                there_is_a_winner = true;
            if (((E3.BackColor == Color.LightGreen) || (E3.BackColor == Color.LightPink)) &&
                (B3.BackColor == C3.BackColor) && (B3.BackColor == D3.BackColor) && (B3.BackColor == E3.BackColor))
                there_is_a_winner = true;
            if (((E3.BackColor == Color.LightGreen) || (E3.BackColor == Color.LightPink)) &&
                (C3.BackColor == D3.BackColor) && (C3.BackColor == E3.BackColor) && (C3.BackColor == F3.BackColor))
                there_is_a_winner = true;
            if (((A4.BackColor == Color.LightGreen) || (A4.BackColor == Color.LightPink)) &&
                (A4.BackColor == B4.BackColor) && (A4.BackColor == C4.BackColor) && (A4.BackColor == D4.BackColor))
                there_is_a_winner = true;
            if (((E4.BackColor == Color.LightGreen) || (E4.BackColor == Color.LightPink)) &&
                (B4.BackColor == C4.BackColor) && (B4.BackColor == D4.BackColor) && (B4.BackColor == E4.BackColor))
                there_is_a_winner = true;
            if (((E4.BackColor == Color.LightGreen) || (E4.BackColor == Color.LightPink)) &&
                (C4.BackColor == D4.BackColor) && (C4.BackColor == E4.BackColor) && (C4.BackColor == F4.BackColor))
                there_is_a_winner = true;
            if (((A5.BackColor == Color.LightGreen) || (A5.BackColor == Color.LightPink)) &&
                (A5.BackColor == B5.BackColor) && (A5.BackColor == C5.BackColor) && (A5.BackColor == D5.BackColor))
                there_is_a_winner = true;
            if (((E5.BackColor == Color.LightGreen) || (E5.BackColor == Color.LightPink)) &&
                (B5.BackColor == C5.BackColor) && (B5.BackColor == D5.BackColor) && (B5.BackColor == E5.BackColor))
                there_is_a_winner = true;
            if (((E5.BackColor == Color.LightGreen) || (E5.BackColor == Color.LightPink)) &&
                (C5.BackColor == D5.BackColor) && (C5.BackColor == E5.BackColor) && (C5.BackColor == F5.BackColor))
                there_is_a_winner = true;
            if (((A6.BackColor == Color.LightGreen) || (A6.BackColor == Color.LightPink)) &&
                (A6.BackColor == B6.BackColor) && (A6.BackColor == C6.BackColor) && (A6.BackColor == D6.BackColor))
                there_is_a_winner = true;
            if (((E6.BackColor == Color.LightGreen) || (E6.BackColor == Color.LightPink)) &&
                (B6.BackColor == C6.BackColor) && (B6.BackColor == D6.BackColor) && (B6.BackColor == E6.BackColor))
                there_is_a_winner = true;
            if (((E6.BackColor == Color.LightGreen) || (E6.BackColor == Color.LightPink)) &&
                (C6.BackColor == D6.BackColor) && (C6.BackColor == E6.BackColor) && (C6.BackColor == F6.BackColor))
                there_is_a_winner = true;
            if (((A7.BackColor == Color.LightGreen) || (A7.BackColor == Color.LightPink)) &&
                (A7.BackColor == B7.BackColor) && (A7.BackColor == C7.BackColor) && (A7.BackColor == D7.BackColor))
                there_is_a_winner = true;
            if (((E7.BackColor == Color.LightGreen) || (E7.BackColor == Color.LightPink)) &&
                (B7.BackColor == C7.BackColor) && (B7.BackColor == D7.BackColor) && (B7.BackColor == E7.BackColor))
                there_is_a_winner = true;
            if (((E7.BackColor == Color.LightGreen) || (E7.BackColor == Color.LightPink)) &&
                (C7.BackColor == D7.BackColor) && (C7.BackColor == E7.BackColor) && (C7.BackColor == F7.BackColor))
                there_is_a_winner = true;

            // diagonal checks
            if (((C1.BackColor == Color.LightGreen) || (C1.BackColor == Color.LightPink)) &&
                (C1.BackColor == D2.BackColor) && (C1.BackColor == E3.BackColor) && (C1.BackColor == F4.BackColor))
                there_is_a_winner = true;
            if (((B1.BackColor == Color.LightGreen) || (B1.BackColor == Color.LightPink)) &&
                (B1.BackColor == C2.BackColor) && (B1.BackColor == D3.BackColor) && (B1.BackColor == E4.BackColor))
                there_is_a_winner = true;
            if (((C2.BackColor == Color.LightGreen) || (C2.BackColor == Color.LightPink)) &&
                (C2.BackColor == D3.BackColor) && (C2.BackColor == E4.BackColor) && (C2.BackColor == F5.BackColor))
                there_is_a_winner = true;
            if (((A1.BackColor == Color.LightGreen) || (A1.BackColor == Color.LightPink)) &&
                (A1.BackColor == B2.BackColor) && (A1.BackColor == C3.BackColor) && (A1.BackColor == D4.BackColor))
                there_is_a_winner = true;
            if (((B2.BackColor == Color.LightGreen) || (B2.BackColor == Color.LightPink)) &&
                (B2.BackColor == C3.BackColor) && (B2.BackColor == D4.BackColor) && (B2.BackColor == E5.BackColor))
                there_is_a_winner = true;
            if (((C3.BackColor == Color.LightGreen) || (C3.BackColor == Color.LightPink)) &&
                (C3.BackColor == D4.BackColor) && (C3.BackColor == E5.BackColor) && (C3.BackColor == F6.BackColor))
                there_is_a_winner = true;
            if (((A2.BackColor == Color.LightGreen) || (A2.BackColor == Color.LightPink)) &&
                (A2.BackColor == B3.BackColor) && (A2.BackColor == C4.BackColor) && (A2.BackColor == D5.BackColor))
                there_is_a_winner = true;
            if (((B3.BackColor == Color.LightGreen) || (B3.BackColor == Color.LightPink)) &&
                (B3.BackColor == C4.BackColor) && (B3.BackColor == D5.BackColor) && (B3.BackColor == E6.BackColor))
                there_is_a_winner = true;
            if (((C4.BackColor == Color.LightGreen) || (C4.BackColor == Color.LightPink)) &&
                (C4.BackColor == D5.BackColor) && (C4.BackColor == E6.BackColor) && (C4.BackColor == F7.BackColor))
                there_is_a_winner = true;
            if (((A3.BackColor == Color.LightGreen) || (A3.BackColor == Color.LightPink)) &&
                (A3.BackColor == B4.BackColor) && (A3.BackColor == C5.BackColor) && (A3.BackColor == D6.BackColor))
                there_is_a_winner = true;
            if (((B4.BackColor == Color.LightGreen) || (B4.BackColor == Color.LightPink)) &&
                (B4.BackColor == C5.BackColor) && (B4.BackColor == D6.BackColor) && (B4.BackColor == E7.BackColor))
                there_is_a_winner = true;
            if (((A4.BackColor == Color.LightGreen) || (A4.BackColor == Color.LightPink)) &&
                (A4.BackColor == B5.BackColor) && (A4.BackColor == C6.BackColor) && (A4.BackColor == D7.BackColor))
                there_is_a_winner = true;
            if (((D1.BackColor == Color.LightGreen) || (D1.BackColor == Color.LightPink)) &&
                (D1.BackColor == C2.BackColor) && (D1.BackColor == B3.BackColor) && (D1.BackColor == A4.BackColor))
                there_is_a_winner = true;
            if (((E1.BackColor == Color.LightGreen) || (E1.BackColor == Color.LightPink)) &&
                (E1.BackColor == D2.BackColor) && (E1.BackColor == C3.BackColor) && (E1.BackColor == B4.BackColor))
                there_is_a_winner = true;
            if (((D2.BackColor == Color.LightGreen) || (D2.BackColor == Color.LightPink)) &&
                (D2.BackColor == C3.BackColor) && (D2.BackColor == B4.BackColor) && (D2.BackColor == A5.BackColor))
                there_is_a_winner = true;
            if (((F1.BackColor == Color.LightGreen) || (F1.BackColor == Color.LightPink)) &&
                (F1.BackColor == E2.BackColor) && (F1.BackColor == D3.BackColor) && (F1.BackColor == C4.BackColor))
                there_is_a_winner = true;
            if (((E2.BackColor == Color.LightGreen) || (E2.BackColor == Color.LightPink)) &&
                (E2.BackColor == D3.BackColor) && (E2.BackColor == C4.BackColor) && (E2.BackColor == B5.BackColor))
                there_is_a_winner = true;
            if (((D3.BackColor == Color.LightGreen) || (D3.BackColor == Color.LightPink)) &&
                (D3.BackColor == C4.BackColor) && (D3.BackColor == B5.BackColor) && (D3.BackColor == A6.BackColor))
                there_is_a_winner = true;
            if (((F2.BackColor == Color.LightGreen) || (F2.BackColor == Color.LightPink)) &&
                (F2.BackColor == E3.BackColor) && (F2.BackColor == D4.BackColor) && (F2.BackColor == C5.BackColor))
                there_is_a_winner = true;
            if (((E3.BackColor == Color.LightGreen) || (E3.BackColor == Color.LightPink)) &&
                (E3.BackColor == D4.BackColor) && (E3.BackColor == C5.BackColor) && (E3.BackColor == B6.BackColor))
                there_is_a_winner = true;
            if (((D4.BackColor == Color.LightGreen) || (D4.BackColor == Color.LightPink)) &&
                (D4.BackColor == C5.BackColor) && (D4.BackColor == B6.BackColor) && (D4.BackColor == A7.BackColor))
                there_is_a_winner = true;
            if (((F3.BackColor == Color.LightGreen) || (F3.BackColor == Color.LightPink)) &&
                (F3.BackColor == E4.BackColor) && (F3.BackColor == D5.BackColor) && (F3.BackColor == C6.BackColor))
                there_is_a_winner = true;
            if (((E4.BackColor == Color.LightGreen) || (E4.BackColor == Color.LightPink)) &&
                (E4.BackColor == D5.BackColor) && (E4.BackColor == C6.BackColor) && (E4.BackColor == B7.BackColor))
                there_is_a_winner = true;
            if (((F4.BackColor == Color.LightGreen) || (F4.BackColor == Color.LightPink)) &&
                (F4.BackColor == E5.BackColor) && (F4.BackColor == D6.BackColor) && (F4.BackColor == C7.BackColor))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = player2;
                    P_Win_Count.Text = (Int32.Parse(P_Win_Count.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    G_Win_Count.Text = (Int32.Parse(G_Win_Count.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " Wins!", "Result!");

                button2.Visible = true;

                button2.Enabled = true;
            } // winner

            else
            {
                if (turn_count == 42)
                {
                    Draw_Count.Text = (Int32.Parse(Draw_Count.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "Bummer!");
                    button2.Visible = true;
                    button2.Enabled = true;
                }
                
            }

        } // end of CheckForWinner

        private void disableButtons()
        {
            foreach (Control c in Controls)
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end try
                catch { }
        } //end foreach

        private void disableButtonsInGame1()
        {
            {
                // First Column
                if (F1.Enabled)
                {
                    F1.Enabled = false;
                    E1.Enabled = true;
                }
                else if (E1.Enabled)
                {
                    E1.Enabled = false;
                    D1.Enabled = true;
                }
                else if (D1.Enabled)
                {
                    D1.Enabled = false;
                    C1.Enabled = true;
                }
                else if (C1.Enabled)
                {
                    C1.Enabled = false;
                    B1.Enabled = true;
                }
                else if (B1.Enabled)
                {
                    B1.Enabled = false;
                    A1.Enabled = true;
                }
                else if (A1.Enabled)
                    A1.Enabled = false;
            }
        }

        private void disableButtonsInGame2()
        {
            // Second Column
            if (F2.Enabled)
            {
                F2.Enabled = false;
                E2.Enabled = true;
            }
            else if (E2.Enabled)
            {
                E2.Enabled = false;
                D2.Enabled = true;
            }
            else if (D2.Enabled)
            {
                D2.Enabled = false;
                C2.Enabled = true;
            }
            else if (C2.Enabled)
            {
                C2.Enabled = false;
                B2.Enabled = true;
            }
            else if (B2.Enabled)
            {
                B2.Enabled = false;
                A2.Enabled = true;
            }
            else if (A2.Enabled)
                A2.Enabled = false;
        }

        private void disableButtonsInGame3()
        {
            // Third Column
            if (F3.Enabled)
            {
                F3.Enabled = false;
                E3.Enabled = true;
            }
            else if (E3.Enabled)
            {
                E3.Enabled = false;
                D3.Enabled = true;
            }
            else if (D3.Enabled)
            {
                D3.Enabled = false;
                C3.Enabled = true;
            }
            else if (C3.Enabled)
            {
                C3.Enabled = false;
                B3.Enabled = true;
            }
            else if (B3.Enabled)
            {
                B3.Enabled = false;
                A3.Enabled = true;
            }
            else if (A3.Enabled)
                A3.Enabled = false;
        }

        private void disableButtonsInGame4()
        {
            // Fourth Column
            if (F4.Enabled)
            {
                F4.Enabled = false;
                E4.Enabled = true;
            }
            else if (E4.Enabled)
            {
                E4.Enabled = false;
                D4.Enabled = true;
            }
            else if (D4.Enabled)
            {
                D4.Enabled = false;
                C4.Enabled = true;
            }
            else if (C4.Enabled)
            {
                C4.Enabled = false;
                B4.Enabled = true;
            }
            else if (B4.Enabled)
            {
                B4.Enabled = false;
                A4.Enabled = true;
            }
            else if (A4.Enabled)
                A4.Enabled = false;
        }

        private void disableButtonsInGame5()
        {
            // Fifth Column
            if (F5.Enabled)
            {
                F5.Enabled = false;
                E5.Enabled = true;
            }
            else if (E5.Enabled)
            {
                E5.Enabled = false;
                D5.Enabled = true;
            }
            else if (D5.Enabled)
            {
                D5.Enabled = false;
                C5.Enabled = true;
            }
            else if (C5.Enabled)
            {
                C5.Enabled = false;
                B5.Enabled = true;
            }
            else if (B5.Enabled)
            {
                B5.Enabled = false;
                A5.Enabled = true;
            }
            else if (A5.Enabled)
                A5.Enabled = false;
        }

        private void disableButtonsInGame6()
        {
            // Sixth Column
            if (F6.Enabled)
            {
                F6.Enabled = false;
                E6.Enabled = true;
            }
            else if (E6.Enabled)
            {
                E6.Enabled = false;
                D6.Enabled = true;
            }
            else if (D6.Enabled)
            {
                D6.Enabled = false;
                C6.Enabled = true;
            }
            else if (C6.Enabled)
            {
                C6.Enabled = false;
                B6.Enabled = true;
            }
            else if (B6.Enabled)
            {
                B6.Enabled = false;
                A6.Enabled = true;
            }
            else if (A6.Enabled)
                A6.Enabled = false;
        }

        private void disableButtonsInGame7()
        {
            // Seventh Column
            if (F7.Enabled)
            {
                F7.Enabled = false;
                E7.Enabled = true;
            }
            else if (E7.Enabled)
            {
                E7.Enabled = false;
                D7.Enabled = true;
            }
            else if (D7.Enabled)
            {
                D7.Enabled = false;
                C7.Enabled = true;
            }
            else if (C7.Enabled)
            {
                C7.Enabled = false;
                B7.Enabled = true;
            }
            else if (B7.Enabled)
            {
                B7.Enabled = false;
                A7.Enabled = true;
            }
            else if (A7.Enabled)
                A7.Enabled = false;
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.BackColor = Color.LightGreen;
                else
                    b.BackColor = Color.LightPink;
            } //end if
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.BackColor = Color.FromArgb(240, 240, 240);
            } //end if

        }

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G_Win_Count.Text = "0";
            P_Win_Count.Text = "0";
            Draw_Count.Text = "0";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void vsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();

            this.Hide();

            f3.ShowDialog();

            this.Close();
        }

        private void vs1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();

            this.Hide();

            f2.ShowDialog();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    A1.Enabled = A2.Enabled = A3.Enabled = A4.Enabled = A5.Enabled = A6.Enabled = A7.Enabled = false;
                    B1.Enabled = B2.Enabled = B3.Enabled = B4.Enabled = B5.Enabled = B6.Enabled = B7.Enabled = false;
                    C1.Enabled = C2.Enabled = C3.Enabled = C4.Enabled = C5.Enabled = C6.Enabled = C7.Enabled = false;
                    D1.Enabled = D2.Enabled = D3.Enabled = D4.Enabled = D5.Enabled = D6.Enabled = D7.Enabled = false;
                    E1.Enabled = E2.Enabled = E3.Enabled = E4.Enabled = E5.Enabled = E6.Enabled = E7.Enabled = false;
                    F1.Enabled = F2.Enabled = F3.Enabled = F4.Enabled = F5.Enabled = F6.Enabled = F7.Enabled = true;
                    b.BackColor = Color.FromArgb(240, 240, 240);
                } // end try
                catch { }
            } //end foreach

            button2.Visible = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    A1.Enabled = A2.Enabled = A3.Enabled = A4.Enabled = A5.Enabled = A6.Enabled = A7.Enabled = false;
                    B1.Enabled = B2.Enabled = B3.Enabled = B4.Enabled = B5.Enabled = B6.Enabled = B7.Enabled = false;
                    C1.Enabled = C2.Enabled = C3.Enabled = C4.Enabled = C5.Enabled = C6.Enabled = C7.Enabled = false;
                    D1.Enabled = D2.Enabled = D3.Enabled = D4.Enabled = D5.Enabled = D6.Enabled = D7.Enabled = false;
                    E1.Enabled = E2.Enabled = E3.Enabled = E4.Enabled = E5.Enabled = E6.Enabled = E7.Enabled = false;
                    F1.Enabled = F2.Enabled = F3.Enabled = F4.Enabled = F5.Enabled = F6.Enabled = F7.Enabled = true;
                    b.BackColor = Color.FromArgb(240, 240, 240);
                } // end try
                catch { }
            } //end foreach

            button2.Visible = false;
        }

        
    }


}
