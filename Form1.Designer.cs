namespace Odd_or_Even_WForms
{
    partial class Main_window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            this.hello = new System.Windows.Forms.Label();
            this.player1_choose_text = new System.Windows.Forms.Label();
            this.player2_choose_text = new System.Windows.Forms.Label();
            this.player2_odd_or_even_text = new System.Windows.Forms.Label();
            this.amount_text = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.odd_even_text = new System.Windows.Forms.Label();
            this.winner_text = new System.Windows.Forms.Label();
            this.winner_player = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.amount_box = new System.Windows.Forms.TextBox();
            this.amount_box2 = new System.Windows.Forms.TextBox();
            this.restart = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.LinkLabel();
            this.player1_odd_or_even_text = new System.Windows.Forms.Label();
            this.start_game = new System.Windows.Forms.Button();
            this.players_choose = new System.Windows.Forms.Label();
            this.loading_timer = new System.Windows.Forms.Timer(this.components);
            this.blackline_middle = new System.Windows.Forms.PictureBox();
            this.twit_soc = new System.Windows.Forms.Button();
            this.vk_soc = new System.Windows.Forms.Button();
            this.az_lang = new System.Windows.Forms.Button();
            this.ru_lang = new System.Windows.Forms.Button();
            this.en_lang = new System.Windows.Forms.Button();
            this.blackline_top = new System.Windows.Forms.PictureBox();
            this.player2_number_5 = new System.Windows.Forms.Button();
            this.player2_number_4 = new System.Windows.Forms.Button();
            this.player2_number_3 = new System.Windows.Forms.Button();
            this.player2_number_2 = new System.Windows.Forms.Button();
            this.player2_number_1 = new System.Windows.Forms.Button();
            this.even_player2 = new System.Windows.Forms.Button();
            this.odd_player2 = new System.Windows.Forms.Button();
            this.player1_number_5 = new System.Windows.Forms.Button();
            this.player1_number_4 = new System.Windows.Forms.Button();
            this.player1_number_3 = new System.Windows.Forms.Button();
            this.player1_number_2 = new System.Windows.Forms.Button();
            this.player1_number_1 = new System.Windows.Forms.Button();
            this.even_player1 = new System.Windows.Forms.Button();
            this.odd_player1 = new System.Windows.Forms.Button();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.blackline_bottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.blackline_middle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackline_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackline_bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // hello
            // 
            this.hello.BackColor = System.Drawing.Color.Black;
            this.hello.Font = new System.Drawing.Font("Bebas Neue Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello.ForeColor = System.Drawing.Color.White;
            this.hello.Location = new System.Drawing.Point(15, 160);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(232, 40);
            this.hello.TabIndex = 0;
            this.hello.Text = "Hi players!";
            this.hello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1_choose_text
            // 
            this.player1_choose_text.AutoSize = true;
            this.player1_choose_text.Font = new System.Drawing.Font("Bebas Neue Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_choose_text.ForeColor = System.Drawing.Color.White;
            this.player1_choose_text.Location = new System.Drawing.Point(54, 345);
            this.player1_choose_text.Name = "player1_choose_text";
            this.player1_choose_text.Size = new System.Drawing.Size(240, 96);
            this.player1_choose_text.TabIndex = 1;
            this.player1_choose_text.Text = "Player 1: can choose only\r\n[                 ]\r\nand numbers from 1 to 5\r\n";
            this.player1_choose_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2_choose_text
            // 
            this.player2_choose_text.AutoSize = true;
            this.player2_choose_text.Font = new System.Drawing.Font("Bebas Neue Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2_choose_text.ForeColor = System.Drawing.Color.White;
            this.player2_choose_text.Location = new System.Drawing.Point(971, 345);
            this.player2_choose_text.Name = "player2_choose_text";
            this.player2_choose_text.Size = new System.Drawing.Size(241, 96);
            this.player2_choose_text.TabIndex = 2;
            this.player2_choose_text.Text = "Player 2: can choose only\r\n[                 ]\r\nand numbers from 1 to 5";
            this.player2_choose_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2_odd_or_even_text
            // 
            this.player2_odd_or_even_text.BackColor = System.Drawing.Color.Transparent;
            this.player2_odd_or_even_text.Font = new System.Drawing.Font("Bebas Neue Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2_odd_or_even_text.ForeColor = System.Drawing.Color.Red;
            this.player2_odd_or_even_text.Location = new System.Drawing.Point(1058, 376);
            this.player2_odd_or_even_text.Name = "player2_odd_or_even_text";
            this.player2_odd_or_even_text.Size = new System.Drawing.Size(63, 32);
            this.player2_odd_or_even_text.TabIndex = 3;
            this.player2_odd_or_even_text.Text = "0";
            this.player2_odd_or_even_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.player2_odd_or_even_text.Click += new System.EventHandler(this.player2_odd_or_even_text_Click);
            // 
            // amount_text
            // 
            this.amount_text.AutoSize = true;
            this.amount_text.Font = new System.Drawing.Font("Bebas Neue Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_text.ForeColor = System.Drawing.Color.White;
            this.amount_text.Location = new System.Drawing.Point(529, 466);
            this.amount_text.Name = "amount_text";
            this.amount_text.Size = new System.Drawing.Size(219, 32);
            this.amount_text.TabIndex = 19;
            this.amount_text.Text = "The amount is equal to:";
            this.amount_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.Transparent;
            this.amount.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.amount.Location = new System.Drawing.Point(529, 503);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(70, 70);
            this.amount.TabIndex = 20;
            this.amount.Text = "0";
            this.amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // odd_even_text
            // 
            this.odd_even_text.BackColor = System.Drawing.Color.Transparent;
            this.odd_even_text.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odd_even_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.odd_even_text.Location = new System.Drawing.Point(678, 503);
            this.odd_even_text.Name = "odd_even_text";
            this.odd_even_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.odd_even_text.Size = new System.Drawing.Size(70, 70);
            this.odd_even_text.TabIndex = 21;
            this.odd_even_text.Text = "0";
            this.odd_even_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winner_text
            // 
            this.winner_text.AutoSize = true;
            this.winner_text.Font = new System.Drawing.Font("Bebas Neue Regular", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner_text.ForeColor = System.Drawing.Color.White;
            this.winner_text.Location = new System.Drawing.Point(426, 629);
            this.winner_text.Name = "winner_text";
            this.winner_text.Size = new System.Drawing.Size(418, 116);
            this.winner_text.TabIndex = 22;
            this.winner_text.Text = "Winner is [                               ]\r\nCongratulations!";
            this.winner_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winner_player
            // 
            this.winner_player.BackColor = System.Drawing.Color.Transparent;
            this.winner_player.Font = new System.Drawing.Font("Bebas Neue Regular", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner_player.ForeColor = System.Drawing.Color.Red;
            this.winner_player.Location = new System.Drawing.Point(603, 629);
            this.winner_player.Name = "winner_player";
            this.winner_player.Size = new System.Drawing.Size(211, 50);
            this.winner_player.TabIndex = 23;
            this.winner_player.Text = "0";
            this.winner_player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Bebas Neue Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit.Location = new System.Drawing.Point(1136, 103);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 50);
            this.exit.TabIndex = 24;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // amount_box
            // 
            this.amount_box.BackColor = System.Drawing.Color.DimGray;
            this.amount_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amount_box.Font = new System.Drawing.Font("Bebas Neue Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount_box.ForeColor = System.Drawing.Color.Red;
            this.amount_box.Location = new System.Drawing.Point(154, 710);
            this.amount_box.Multiline = true;
            this.amount_box.Name = "amount_box";
            this.amount_box.Size = new System.Drawing.Size(35, 35);
            this.amount_box.TabIndex = 25;
            this.amount_box.Text = "0";
            this.amount_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount_box.Visible = false;
            // 
            // amount_box2
            // 
            this.amount_box2.BackColor = System.Drawing.Color.DimGray;
            this.amount_box2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amount_box2.Font = new System.Drawing.Font("Bebas Neue Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount_box2.ForeColor = System.Drawing.Color.Red;
            this.amount_box2.Location = new System.Drawing.Point(1073, 710);
            this.amount_box2.Multiline = true;
            this.amount_box2.Name = "amount_box2";
            this.amount_box2.Size = new System.Drawing.Size(35, 35);
            this.amount_box2.TabIndex = 26;
            this.amount_box2.Text = "0";
            this.amount_box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount_box2.Visible = false;
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Black;
            this.restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Font = new System.Drawing.Font("Bebas Neue Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.restart.Location = new System.Drawing.Point(1136, 47);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(116, 50);
            this.restart.TabIndex = 27;
            this.restart.Text = "RESTART";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // copyright
            // 
            this.copyright.ActiveLinkColor = System.Drawing.Color.Red;
            this.copyright.BackColor = System.Drawing.Color.Black;
            this.copyright.DisabledLinkColor = System.Drawing.Color.Red;
            this.copyright.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyright.ForeColor = System.Drawing.Color.White;
            this.copyright.LinkArea = new System.Windows.Forms.LinkArea(158, 6);
            this.copyright.LinkColor = System.Drawing.Color.Red;
            this.copyright.Location = new System.Drawing.Point(32, 772);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(1200, 36);
            this.copyright.TabIndex = 28;
            this.copyright.TabStop = true;
            this.copyright.Text = "© OoE, 2016-2017. All rights reserved. | From Azerbaijan with love.\r\nThank you fo" +
    "r playing my first game app on C# | Created by Mikhail RashkaByorn Palagin.\r\nDon" +
    "ate";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.copyright.UseCompatibleTextRendering = true;
            this.copyright.VisitedLinkColor = System.Drawing.Color.Red;
            this.copyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.copyright_LinkClicked);
            // 
            // player1_odd_or_even_text
            // 
            this.player1_odd_or_even_text.BackColor = System.Drawing.Color.Transparent;
            this.player1_odd_or_even_text.Font = new System.Drawing.Font("Bebas Neue Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_odd_or_even_text.ForeColor = System.Drawing.Color.Red;
            this.player1_odd_or_even_text.Location = new System.Drawing.Point(140, 376);
            this.player1_odd_or_even_text.Name = "player1_odd_or_even_text";
            this.player1_odd_or_even_text.Size = new System.Drawing.Size(63, 32);
            this.player1_odd_or_even_text.TabIndex = 38;
            this.player1_odd_or_even_text.Text = "0";
            this.player1_odd_or_even_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.player1_odd_or_even_text.Click += new System.EventHandler(this.player1_odd_or_even_text_Click);
            // 
            // start_game
            // 
            this.start_game.AutoSize = true;
            this.start_game.BackColor = System.Drawing.Color.Black;
            this.start_game.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.start_game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.start_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_game.Font = new System.Drawing.Font("Bebas Neue Regular", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_game.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.start_game.Location = new System.Drawing.Point(436, 384);
            this.start_game.Name = "start_game";
            this.start_game.Size = new System.Drawing.Size(392, 173);
            this.start_game.TabIndex = 39;
            this.start_game.Text = "START";
            this.start_game.UseVisualStyleBackColor = false;
            this.start_game.Click += new System.EventHandler(this.start_game_Click);
            // 
            // players_choose
            // 
            this.players_choose.Font = new System.Drawing.Font("Bebas Neue Regular", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.players_choose.ForeColor = System.Drawing.Color.Red;
            this.players_choose.Location = new System.Drawing.Point(218, 223);
            this.players_choose.Name = "players_choose";
            this.players_choose.Size = new System.Drawing.Size(827, 77);
            this.players_choose.TabIndex = 40;
            this.players_choose.Text = "0";
            this.players_choose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loading_timer
            // 
            this.loading_timer.Interval = 1000;
            this.loading_timer.Tick += new System.EventHandler(this.loading_timer_Tick);
            // 
            // blackline_middle
            // 
            this.blackline_middle.BackColor = System.Drawing.Color.Transparent;
            this.blackline_middle.ErrorImage = global::Odd_or_Even_WForms.Properties.Resources.black_line;
            this.blackline_middle.Image = global::Odd_or_Even_WForms.Properties.Resources.black_line;
            this.blackline_middle.InitialImage = global::Odd_or_Even_WForms.Properties.Resources.black_line;
            this.blackline_middle.Location = new System.Drawing.Point(-8, 160);
            this.blackline_middle.Name = "blackline_middle";
            this.blackline_middle.Size = new System.Drawing.Size(1280, 40);
            this.blackline_middle.TabIndex = 36;
            this.blackline_middle.TabStop = false;
            // 
            // twit_soc
            // 
            this.twit_soc.BackColor = System.Drawing.Color.Black;
            this.twit_soc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.twit_soc.FlatAppearance.BorderSize = 0;
            this.twit_soc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.twit_soc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.twit_soc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twit_soc.ForeColor = System.Drawing.Color.Transparent;
            this.twit_soc.Image = global::Odd_or_Even_WForms.Properties.Resources.twit_32;
            this.twit_soc.Location = new System.Drawing.Point(1180, 4);
            this.twit_soc.Name = "twit_soc";
            this.twit_soc.Size = new System.Drawing.Size(32, 32);
            this.twit_soc.TabIndex = 35;
            this.twit_soc.UseVisualStyleBackColor = false;
            this.twit_soc.Click += new System.EventHandler(this.twit_soc_Click);
            this.twit_soc.MouseEnter += new System.EventHandler(this.twit_soc_MouseEnter);
            this.twit_soc.MouseLeave += new System.EventHandler(this.twit_soc_MouseLeave);
            // 
            // vk_soc
            // 
            this.vk_soc.BackColor = System.Drawing.Color.Black;
            this.vk_soc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vk_soc.FlatAppearance.BorderSize = 0;
            this.vk_soc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.vk_soc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.vk_soc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vk_soc.ForeColor = System.Drawing.Color.Transparent;
            this.vk_soc.Image = global::Odd_or_Even_WForms.Properties.Resources.vk_32;
            this.vk_soc.Location = new System.Drawing.Point(1140, 4);
            this.vk_soc.Name = "vk_soc";
            this.vk_soc.Size = new System.Drawing.Size(32, 32);
            this.vk_soc.TabIndex = 34;
            this.vk_soc.UseVisualStyleBackColor = false;
            this.vk_soc.Click += new System.EventHandler(this.vk_soc_Click);
            this.vk_soc.MouseEnter += new System.EventHandler(this.vk_soc_MouseEnter);
            this.vk_soc.MouseLeave += new System.EventHandler(this.vk_soc_MouseLeave);
            // 
            // az_lang
            // 
            this.az_lang.BackColor = System.Drawing.Color.Black;
            this.az_lang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.az_lang.FlatAppearance.BorderSize = 0;
            this.az_lang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.az_lang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.az_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.az_lang.ForeColor = System.Drawing.Color.Transparent;
            this.az_lang.Image = global::Odd_or_Even_WForms.Properties.Resources.az;
            this.az_lang.Location = new System.Drawing.Point(128, 4);
            this.az_lang.Name = "az_lang";
            this.az_lang.Size = new System.Drawing.Size(32, 32);
            this.az_lang.TabIndex = 33;
            this.az_lang.UseVisualStyleBackColor = false;
            this.az_lang.MouseEnter += new System.EventHandler(this.az_lang_MouseEnter);
            this.az_lang.MouseLeave += new System.EventHandler(this.az_lang_MouseLeave);
            // 
            // ru_lang
            // 
            this.ru_lang.BackColor = System.Drawing.Color.Black;
            this.ru_lang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ru_lang.FlatAppearance.BorderSize = 0;
            this.ru_lang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ru_lang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ru_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ru_lang.ForeColor = System.Drawing.Color.Transparent;
            this.ru_lang.Image = global::Odd_or_Even_WForms.Properties.Resources.ru;
            this.ru_lang.Location = new System.Drawing.Point(89, 4);
            this.ru_lang.Name = "ru_lang";
            this.ru_lang.Size = new System.Drawing.Size(32, 32);
            this.ru_lang.TabIndex = 32;
            this.ru_lang.UseVisualStyleBackColor = false;
            this.ru_lang.MouseEnter += new System.EventHandler(this.ru_lang_MouseEnter);
            this.ru_lang.MouseLeave += new System.EventHandler(this.ru_lang_MouseLeave);
            // 
            // en_lang
            // 
            this.en_lang.BackColor = System.Drawing.Color.Black;
            this.en_lang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.en_lang.FlatAppearance.BorderSize = 0;
            this.en_lang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.en_lang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.en_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.en_lang.ForeColor = System.Drawing.Color.Transparent;
            this.en_lang.Image = global::Odd_or_Even_WForms.Properties.Resources.en;
            this.en_lang.Location = new System.Drawing.Point(50, 4);
            this.en_lang.Name = "en_lang";
            this.en_lang.Size = new System.Drawing.Size(32, 32);
            this.en_lang.TabIndex = 31;
            this.en_lang.UseVisualStyleBackColor = false;
            this.en_lang.MouseEnter += new System.EventHandler(this.en_lang_MouseEnter);
            this.en_lang.MouseLeave += new System.EventHandler(this.en_lang_MouseLeave);
            // 
            // blackline_top
            // 
            this.blackline_top.BackColor = System.Drawing.Color.Transparent;
            this.blackline_top.ErrorImage = global::Odd_or_Even_WForms.Properties.Resources.black_line;
            this.blackline_top.Image = global::Odd_or_Even_WForms.Properties.Resources.black_line;
            this.blackline_top.InitialImage = global::Odd_or_Even_WForms.Properties.Resources.black_line;
            this.blackline_top.Location = new System.Drawing.Point(-8, 0);
            this.blackline_top.Name = "blackline_top";
            this.blackline_top.Size = new System.Drawing.Size(1280, 40);
            this.blackline_top.TabIndex = 30;
            this.blackline_top.TabStop = false;
            // 
            // player2_number_5
            // 
            this.player2_number_5.BackColor = System.Drawing.Color.Transparent;
            this.player2_number_5.FlatAppearance.BorderSize = 0;
            this.player2_number_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player2_number_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player2_number_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player2_number_5.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2_number_5.Image = global::Odd_or_Even_WForms.Properties.Resources.num_5;
            this.player2_number_5.Location = new System.Drawing.Point(1096, 630);
            this.player2_number_5.Name = "player2_number_5";
            this.player2_number_5.Size = new System.Drawing.Size(70, 70);
            this.player2_number_5.TabIndex = 17;
            this.player2_number_5.Text = "5";
            this.player2_number_5.UseVisualStyleBackColor = false;
            this.player2_number_5.Click += new System.EventHandler(this.player2_number_5_Click);
            this.player2_number_5.MouseEnter += new System.EventHandler(this.player2_number_5_MouseEnter);
            this.player2_number_5.MouseLeave += new System.EventHandler(this.player2_number_5_MouseLeave);
            // 
            // player2_number_4
            // 
            this.player2_number_4.BackColor = System.Drawing.Color.Transparent;
            this.player2_number_4.FlatAppearance.BorderSize = 0;
            this.player2_number_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player2_number_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player2_number_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player2_number_4.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2_number_4.Image = global::Odd_or_Even_WForms.Properties.Resources.num_4;
            this.player2_number_4.Location = new System.Drawing.Point(1015, 630);
            this.player2_number_4.Name = "player2_number_4";
            this.player2_number_4.Size = new System.Drawing.Size(70, 70);
            this.player2_number_4.TabIndex = 16;
            this.player2_number_4.Text = "4";
            this.player2_number_4.UseVisualStyleBackColor = false;
            this.player2_number_4.Click += new System.EventHandler(this.player2_number_4_Click);
            this.player2_number_4.MouseEnter += new System.EventHandler(this.player2_number_4_MouseEnter);
            this.player2_number_4.MouseLeave += new System.EventHandler(this.player2_number_4_MouseLeave);
            // 
            // player2_number_3
            // 
            this.player2_number_3.BackColor = System.Drawing.Color.Transparent;
            this.player2_number_3.FlatAppearance.BorderSize = 0;
            this.player2_number_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player2_number_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player2_number_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player2_number_3.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2_number_3.Image = global::Odd_or_Even_WForms.Properties.Resources.num_3;
            this.player2_number_3.Location = new System.Drawing.Point(1136, 549);
            this.player2_number_3.Name = "player2_number_3";
            this.player2_number_3.Size = new System.Drawing.Size(70, 70);
            this.player2_number_3.TabIndex = 15;
            this.player2_number_3.Text = "3";
            this.player2_number_3.UseVisualStyleBackColor = false;
            this.player2_number_3.Click += new System.EventHandler(this.player2_number_3_Click);
            this.player2_number_3.MouseEnter += new System.EventHandler(this.player2_number_3_MouseEnter);
            this.player2_number_3.MouseLeave += new System.EventHandler(this.player2_number_3_MouseLeave);
            // 
            // player2_number_2
            // 
            this.player2_number_2.BackColor = System.Drawing.Color.Transparent;
            this.player2_number_2.FlatAppearance.BorderSize = 0;
            this.player2_number_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player2_number_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player2_number_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player2_number_2.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2_number_2.Image = global::Odd_or_Even_WForms.Properties.Resources.num_2;
            this.player2_number_2.Location = new System.Drawing.Point(1055, 549);
            this.player2_number_2.Name = "player2_number_2";
            this.player2_number_2.Size = new System.Drawing.Size(70, 70);
            this.player2_number_2.TabIndex = 14;
            this.player2_number_2.Text = "2";
            this.player2_number_2.UseVisualStyleBackColor = false;
            this.player2_number_2.Click += new System.EventHandler(this.player2_number_2_Click);
            this.player2_number_2.MouseEnter += new System.EventHandler(this.player2_number_2_MouseEnter);
            this.player2_number_2.MouseLeave += new System.EventHandler(this.player2_number_2_MouseLeave);
            // 
            // player2_number_1
            // 
            this.player2_number_1.BackColor = System.Drawing.Color.Transparent;
            this.player2_number_1.FlatAppearance.BorderSize = 0;
            this.player2_number_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player2_number_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player2_number_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player2_number_1.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2_number_1.Image = global::Odd_or_Even_WForms.Properties.Resources.num_1;
            this.player2_number_1.Location = new System.Drawing.Point(974, 549);
            this.player2_number_1.Name = "player2_number_1";
            this.player2_number_1.Size = new System.Drawing.Size(70, 70);
            this.player2_number_1.TabIndex = 13;
            this.player2_number_1.Text = "1";
            this.player2_number_1.UseVisualStyleBackColor = false;
            this.player2_number_1.Click += new System.EventHandler(this.player2_number_1_Click);
            this.player2_number_1.MouseEnter += new System.EventHandler(this.player2_number_1_MouseEnter);
            this.player2_number_1.MouseLeave += new System.EventHandler(this.player2_number_1_MouseLeave);
            // 
            // even_player2
            // 
            this.even_player2.BackColor = System.Drawing.Color.Transparent;
            this.even_player2.FlatAppearance.BorderSize = 0;
            this.even_player2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.even_player2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.even_player2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.even_player2.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.even_player2.Image = global::Odd_or_Even_WForms.Properties.Resources.e_button;
            this.even_player2.Location = new System.Drawing.Point(1096, 468);
            this.even_player2.Name = "even_player2";
            this.even_player2.Size = new System.Drawing.Size(70, 70);
            this.even_player2.TabIndex = 12;
            this.even_player2.Text = "EVEN";
            this.even_player2.UseVisualStyleBackColor = false;
            this.even_player2.Click += new System.EventHandler(this.even_player2_Click);
            this.even_player2.MouseEnter += new System.EventHandler(this.even_player2_MouseEnter);
            this.even_player2.MouseLeave += new System.EventHandler(this.even_player2_MouseLeave);
            // 
            // odd_player2
            // 
            this.odd_player2.BackColor = System.Drawing.Color.Transparent;
            this.odd_player2.FlatAppearance.BorderSize = 0;
            this.odd_player2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.odd_player2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.odd_player2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odd_player2.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.odd_player2.Image = global::Odd_or_Even_WForms.Properties.Resources.o_button;
            this.odd_player2.Location = new System.Drawing.Point(1015, 468);
            this.odd_player2.Name = "odd_player2";
            this.odd_player2.Size = new System.Drawing.Size(70, 70);
            this.odd_player2.TabIndex = 11;
            this.odd_player2.Text = "ODD";
            this.odd_player2.UseVisualStyleBackColor = false;
            this.odd_player2.Click += new System.EventHandler(this.odd_player2_Click);
            this.odd_player2.MouseEnter += new System.EventHandler(this.odd_player2_MouseEnter);
            this.odd_player2.MouseLeave += new System.EventHandler(this.odd_player2_MouseLeave);
            // 
            // player1_number_5
            // 
            this.player1_number_5.BackColor = System.Drawing.Color.Transparent;
            this.player1_number_5.FlatAppearance.BorderSize = 0;
            this.player1_number_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player1_number_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player1_number_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player1_number_5.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1_number_5.Image = global::Odd_or_Even_WForms.Properties.Resources.num_5;
            this.player1_number_5.Location = new System.Drawing.Point(177, 630);
            this.player1_number_5.Name = "player1_number_5";
            this.player1_number_5.Size = new System.Drawing.Size(70, 70);
            this.player1_number_5.TabIndex = 10;
            this.player1_number_5.Text = "5";
            this.player1_number_5.UseVisualStyleBackColor = false;
            this.player1_number_5.Click += new System.EventHandler(this.player1_number_5_Click);
            this.player1_number_5.MouseEnter += new System.EventHandler(this.player1_number_5_MouseEnter);
            this.player1_number_5.MouseLeave += new System.EventHandler(this.player1_number_5_MouseLeave);
            // 
            // player1_number_4
            // 
            this.player1_number_4.BackColor = System.Drawing.Color.Transparent;
            this.player1_number_4.FlatAppearance.BorderSize = 0;
            this.player1_number_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player1_number_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player1_number_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player1_number_4.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1_number_4.Image = global::Odd_or_Even_WForms.Properties.Resources.num_4;
            this.player1_number_4.Location = new System.Drawing.Point(96, 630);
            this.player1_number_4.Name = "player1_number_4";
            this.player1_number_4.Size = new System.Drawing.Size(70, 70);
            this.player1_number_4.TabIndex = 9;
            this.player1_number_4.Text = "4";
            this.player1_number_4.UseVisualStyleBackColor = false;
            this.player1_number_4.Click += new System.EventHandler(this.player1_number_4_Click);
            this.player1_number_4.MouseEnter += new System.EventHandler(this.player1_number_4_MouseEnter);
            this.player1_number_4.MouseLeave += new System.EventHandler(this.player1_number_4_MouseLeave);
            // 
            // player1_number_3
            // 
            this.player1_number_3.BackColor = System.Drawing.Color.Transparent;
            this.player1_number_3.FlatAppearance.BorderSize = 0;
            this.player1_number_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player1_number_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player1_number_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player1_number_3.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1_number_3.Image = global::Odd_or_Even_WForms.Properties.Resources.num_3;
            this.player1_number_3.Location = new System.Drawing.Point(217, 549);
            this.player1_number_3.Name = "player1_number_3";
            this.player1_number_3.Size = new System.Drawing.Size(70, 70);
            this.player1_number_3.TabIndex = 8;
            this.player1_number_3.Text = "3";
            this.player1_number_3.UseVisualStyleBackColor = false;
            this.player1_number_3.Click += new System.EventHandler(this.player1_number_3_Click);
            this.player1_number_3.MouseEnter += new System.EventHandler(this.player1_number_3_MouseEnter);
            this.player1_number_3.MouseLeave += new System.EventHandler(this.player1_number_3_MouseLeave);
            // 
            // player1_number_2
            // 
            this.player1_number_2.BackColor = System.Drawing.Color.Transparent;
            this.player1_number_2.FlatAppearance.BorderSize = 0;
            this.player1_number_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player1_number_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player1_number_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player1_number_2.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1_number_2.Image = global::Odd_or_Even_WForms.Properties.Resources.num_2;
            this.player1_number_2.Location = new System.Drawing.Point(136, 549);
            this.player1_number_2.Name = "player1_number_2";
            this.player1_number_2.Size = new System.Drawing.Size(70, 70);
            this.player1_number_2.TabIndex = 7;
            this.player1_number_2.Text = "2";
            this.player1_number_2.UseVisualStyleBackColor = false;
            this.player1_number_2.Click += new System.EventHandler(this.player1_number_2_Click);
            this.player1_number_2.MouseEnter += new System.EventHandler(this.player1_number_2_MouseEnter);
            this.player1_number_2.MouseLeave += new System.EventHandler(this.player1_number_2_MouseLeave);
            // 
            // player1_number_1
            // 
            this.player1_number_1.BackColor = System.Drawing.Color.Transparent;
            this.player1_number_1.FlatAppearance.BorderSize = 0;
            this.player1_number_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.player1_number_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player1_number_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player1_number_1.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1_number_1.Image = global::Odd_or_Even_WForms.Properties.Resources.num_1;
            this.player1_number_1.Location = new System.Drawing.Point(55, 549);
            this.player1_number_1.Name = "player1_number_1";
            this.player1_number_1.Size = new System.Drawing.Size(70, 70);
            this.player1_number_1.TabIndex = 6;
            this.player1_number_1.Text = "1";
            this.player1_number_1.UseVisualStyleBackColor = false;
            this.player1_number_1.Click += new System.EventHandler(this.player1_number_1_Click);
            this.player1_number_1.MouseEnter += new System.EventHandler(this.player1_number_1_MouseEnter);
            this.player1_number_1.MouseLeave += new System.EventHandler(this.player1_number_1_MouseLeave);
            // 
            // even_player1
            // 
            this.even_player1.BackColor = System.Drawing.Color.Transparent;
            this.even_player1.FlatAppearance.BorderSize = 0;
            this.even_player1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.even_player1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.even_player1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.even_player1.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.even_player1.Image = global::Odd_or_Even_WForms.Properties.Resources.e_button;
            this.even_player1.Location = new System.Drawing.Point(177, 468);
            this.even_player1.Name = "even_player1";
            this.even_player1.Size = new System.Drawing.Size(70, 70);
            this.even_player1.TabIndex = 5;
            this.even_player1.Text = "EVEN";
            this.even_player1.UseVisualStyleBackColor = false;
            this.even_player1.Click += new System.EventHandler(this.even_player1_Click);
            this.even_player1.MouseEnter += new System.EventHandler(this.even_player1_MouseEnter);
            this.even_player1.MouseLeave += new System.EventHandler(this.even_player1_MouseLeave);
            // 
            // odd_player1
            // 
            this.odd_player1.BackColor = System.Drawing.Color.Transparent;
            this.odd_player1.FlatAppearance.BorderSize = 0;
            this.odd_player1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.odd_player1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.odd_player1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odd_player1.Font = new System.Drawing.Font("Bebas Neue Regular", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.odd_player1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.odd_player1.Image = global::Odd_or_Even_WForms.Properties.Resources.o_button;
            this.odd_player1.Location = new System.Drawing.Point(96, 468);
            this.odd_player1.Name = "odd_player1";
            this.odd_player1.Size = new System.Drawing.Size(70, 70);
            this.odd_player1.TabIndex = 4;
            this.odd_player1.Text = "ODD";
            this.odd_player1.UseVisualStyleBackColor = false;
            this.odd_player1.Click += new System.EventHandler(this.odd_player1_Click);
            this.odd_player1.MouseEnter += new System.EventHandler(this.odd_player1_MouseEnter);
            this.odd_player1.MouseLeave += new System.EventHandler(this.odd_player1_MouseLeave);
            // 
            // logo_img
            // 
            this.logo_img.BackColor = System.Drawing.Color.Transparent;
            this.logo_img.ErrorImage = global::Odd_or_Even_WForms.Properties.Resources.Logo_app;
            this.logo_img.Image = global::Odd_or_Even_WForms.Properties.Resources.Logo_app;
            this.logo_img.InitialImage = global::Odd_or_Even_WForms.Properties.Resources.Logo_app;
            this.logo_img.Location = new System.Drawing.Point(527, 40);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(210, 120);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 29;
            this.logo_img.TabStop = false;
            // 
            // blackline_bottom
            // 
            this.blackline_bottom.BackColor = System.Drawing.Color.Transparent;
            this.blackline_bottom.ErrorImage = global::Odd_or_Even_WForms.Properties.Resources.black_line;
            this.blackline_bottom.Image = global::Odd_or_Even_WForms.Properties.Resources.black_line;
            this.blackline_bottom.InitialImage = global::Odd_or_Even_WForms.Properties.Resources.black_line;
            this.blackline_bottom.Location = new System.Drawing.Point(-8, 770);
            this.blackline_bottom.Name = "blackline_bottom";
            this.blackline_bottom.Size = new System.Drawing.Size(1280, 40);
            this.blackline_bottom.TabIndex = 37;
            this.blackline_bottom.TabStop = false;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1264, 811);
            this.Controls.Add(this.hello);
            this.Controls.Add(this.players_choose);
            this.Controls.Add(this.amount_text);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.odd_even_text);
            this.Controls.Add(this.winner_player);
            this.Controls.Add(this.player1_odd_or_even_text);
            this.Controls.Add(this.player2_odd_or_even_text);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.blackline_middle);
            this.Controls.Add(this.twit_soc);
            this.Controls.Add(this.vk_soc);
            this.Controls.Add(this.az_lang);
            this.Controls.Add(this.ru_lang);
            this.Controls.Add(this.en_lang);
            this.Controls.Add(this.blackline_top);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.amount_box2);
            this.Controls.Add(this.amount_box);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.winner_text);
            this.Controls.Add(this.player2_number_5);
            this.Controls.Add(this.player2_number_4);
            this.Controls.Add(this.player2_number_3);
            this.Controls.Add(this.player2_number_2);
            this.Controls.Add(this.player2_number_1);
            this.Controls.Add(this.even_player2);
            this.Controls.Add(this.odd_player2);
            this.Controls.Add(this.player1_number_5);
            this.Controls.Add(this.player1_number_4);
            this.Controls.Add(this.player1_number_3);
            this.Controls.Add(this.player1_number_2);
            this.Controls.Add(this.player1_number_1);
            this.Controls.Add(this.even_player1);
            this.Controls.Add(this.odd_player1);
            this.Controls.Add(this.player2_choose_text);
            this.Controls.Add(this.player1_choose_text);
            this.Controls.Add(this.logo_img);
            this.Controls.Add(this.blackline_bottom);
            this.Controls.Add(this.start_game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 850);
            this.MinimumSize = new System.Drawing.Size(1280, 850);
            this.Name = "Main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odd or Even | ver. 1.0 [Beta]";
            this.Load += new System.EventHandler(this.Main_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blackline_middle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackline_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackline_bottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Label player1_choose_text;
        private System.Windows.Forms.Label player2_choose_text;
        private System.Windows.Forms.Label player2_odd_or_even_text;
        private System.Windows.Forms.Button odd_player1;
        private System.Windows.Forms.Button even_player1;
        private System.Windows.Forms.Button player1_number_1;
        private System.Windows.Forms.Button player1_number_2;
        private System.Windows.Forms.Button player1_number_3;
        private System.Windows.Forms.Button player1_number_4;
        private System.Windows.Forms.Button player1_number_5;
        private System.Windows.Forms.Button player2_number_5;
        private System.Windows.Forms.Button player2_number_4;
        private System.Windows.Forms.Button player2_number_3;
        private System.Windows.Forms.Button player2_number_2;
        private System.Windows.Forms.Button player2_number_1;
        private System.Windows.Forms.Button even_player2;
        private System.Windows.Forms.Button odd_player2;
        private System.Windows.Forms.Label amount_text;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label odd_even_text;
        private System.Windows.Forms.Label winner_text;
        private System.Windows.Forms.Label winner_player;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox amount_box;
        private System.Windows.Forms.TextBox amount_box2;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.LinkLabel copyright;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.PictureBox blackline_top;
        private System.Windows.Forms.Button en_lang;
        private System.Windows.Forms.Button ru_lang;
        private System.Windows.Forms.Button az_lang;
        private System.Windows.Forms.Button vk_soc;
        private System.Windows.Forms.Button twit_soc;
        private System.Windows.Forms.PictureBox blackline_middle;
        private System.Windows.Forms.PictureBox blackline_bottom;
        private System.Windows.Forms.Label player1_odd_or_even_text;
        private System.Windows.Forms.Button start_game;
        private System.Windows.Forms.Label players_choose;
        private System.Windows.Forms.Timer loading_timer;
    }
}

