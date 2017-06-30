using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Odd_or_Even_WForms
{
    public partial class Main_window : Form
    {
        bool odd_player1_btn = false; // Флаг для кнопки odd_player_1 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool even_player1_btn = false; // Флаг для кнопки even_player_1 для проверки нажата ли она / Изначально флаг стоит FALSE

        bool odd_player2_btn = false; // Флаг для кнопки odd_player_2 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool even_player2_btn = false; // Флаг для кнопки even_player_2 для проверки нажата ли она / Изначально флаг стоит FALSE

        bool player1_number_1_btn = false; // Флаг для кнопки 1 игрока 1 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool player1_number_2_btn = false; // Флаг для кнопки 2 игрока 1 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool player1_number_3_btn = false; // Флаг для кнопки 3 игрока 1 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool player1_number_4_btn = false; // Флаг для кнопки 4 игрока 1 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool player1_number_5_btn = false; // Флаг для кнопки 5 игрока 1 для проверки нажата ли она / Изначально флаг стоит FALSE

        bool player2_number_1_btn = false; // Флаг для кнопки 1 игрока 2 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool player2_number_2_btn = false; // Флаг для кнопки 2 игрока 2 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool player2_number_3_btn = false; // Флаг для кнопки 3 игрока 2 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool player2_number_4_btn = false; // Флаг для кнопки 4 игрока 2 для проверки нажата ли она / Изначально флаг стоит FALSE
        bool player2_number_5_btn = false; // Флаг для кнопки 5 игрока 2 для проверки нажата ли она / Изначально флаг стоит FALSE

        int p1; // Пустая переменная для цифр игрока 1
        int p2; // Пустая переменная для цифр игрока 2
        int count; // Пустая переменная для сложение цирфы игрока 1 и игрока 2 
        string player1; // Пустая строка для Чет/Нечет игрока 1
        string player2; // Пустая строка для Чет/Нечет игрока 2

        int countdown; // Пустая переменная для таймера авто-старта игры

        public Main_window()
        {
            InitializeComponent();
            all_btn_hide();
        }

        public void all_btn_hide() // Метод для скрытия нужных кнопок при запуске игры
        {
            // Отключает всю панель игрока 1
            player1_choose_text.Visible = false;
            player1_odd_or_even_text.Visible = false;
            player1_odd_or_even_text.ForeColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            odd_player1.Visible = false;
            even_player1.Visible = false;
            player1_number_1.Visible = false;
            player1_number_2.Visible = false;
            player1_number_3.Visible = false;
            player1_number_4.Visible = false;
            player1_number_5.Visible = false;

            // Отключает всю панель игрока 2
            player2_choose_text.Visible = false;
            player2_odd_or_even_text.Visible = false;
            player2_odd_or_even_text.ForeColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            odd_player2.Visible = false;
            even_player2.Visible = false;
            player2_number_1.Visible = false;
            player2_number_2.Visible = false;
            player2_number_3.Visible = false;
            player2_number_4.Visible = false;
            player2_number_5.Visible = false;

            // Отключает все что в центре
            players_choose.Visible = false;
            amount_text.Visible = false;
            amount.Visible = false;
            odd_even_text.Visible = false;
            winner_text.Visible = false;
            winner_player.Visible = false;
            winner_player.ForeColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));

            // Настройки таймера обратного отсчета
            countdown = 60;
            loading_timer.Enabled = true;
            loading_timer.Start();

        }

        private void Main_window_Load(object sender, EventArgs e)
        {

        }

        private void loading_timer_Tick(object sender, EventArgs e) // Таймер и его функции по тику
        {
            players_choose.Visible = true;
            players_choose.ForeColor = Color.White;
            players_choose.Text = "<<<- Wait: " + (--countdown).ToString() + "  |  or press start ->>>";
            if (countdown == 0)
            {
                loading_timer.Stop(); // Отключение таймера

                // Включает всю панель игрока 1
                player1_choose_text.Visible = true;
                player1_odd_or_even_text.Visible = true;
                odd_player1.Visible = true;
                even_player1.Visible = true;
                player1_number_1.Visible = true;
                player1_number_2.Visible = true;
                player1_number_3.Visible = true;
                player1_number_4.Visible = true;
                player1_number_5.Visible = true;

                // Включает всю панель игрока 2
                player2_choose_text.Visible = true;
                player2_odd_or_even_text.Visible = true;
                odd_player2.Visible = true;
                even_player2.Visible = true;
                player2_number_1.Visible = true;
                player2_number_2.Visible = true;
                player2_number_3.Visible = true;
                player2_number_4.Visible = true;
                player2_number_5.Visible = true;

                // Включает все что в центре
                players_choose.Visible = true;
                players_choose.ForeColor = Color.Red; // Возвращает красный цвет тексту
                amount_text.Visible = true;
                amount.Visible = true;
                odd_even_text.Visible = true;
                winner_text.Visible = true;
                winner_player.Visible = true;

                // Скрывает кнопку START
                start_game.Visible = false;

                // Жеребьевка на то кто начинает игру первым
                Random rnd = new Random();
                int player_rnd = rnd.Next(1, 3);

                switch (player_rnd)
                {
                    case 1:
                        players_choose.Text = "Player 1 starts first";
                        break;

                    case 2:
                        players_choose.Text = "Player 2 starts first";
                        break;
                }
            }

        }

        private void start_game_Click(object sender, EventArgs e) // Кнопка START на клик
        {
            loading_timer.Stop(); // Отключение таймера

            // Включает всю панель игрока 1
            player1_choose_text.Visible = true;
            player1_odd_or_even_text.Visible = true;
            odd_player1.Visible = true;
            even_player1.Visible = true;
            player1_number_1.Visible = true;
            player1_number_2.Visible = true;
            player1_number_3.Visible = true;
            player1_number_4.Visible = true;
            player1_number_5.Visible = true;

            // Включает всю панель игрока 2
            player2_choose_text.Visible = true;
            player2_odd_or_even_text.Visible = true;
            odd_player2.Visible = true;
            even_player2.Visible = true;
            player2_number_1.Visible = true;
            player2_number_2.Visible = true;
            player2_number_3.Visible = true;
            player2_number_4.Visible = true;
            player2_number_5.Visible = true;

            // Включает все что в центре
            players_choose.Visible = true;
            players_choose.ForeColor = Color.Red; // Возвращает красный цвет тексту
            amount_text.Visible = true;
            amount.Visible = true;
            odd_even_text.Visible = true;
            winner_text.Visible = true;
            winner_player.Visible = true;

            // Скрывает кнопку START после ее нажатия
            start_game.Visible = false;

            // Жеребьевка на то кто начинает игру первым
            Random rnd = new Random();
            int player_rnd = rnd.Next(1, 3);

            switch (player_rnd)
            {
                case 1:
                    players_choose.Text = "Player 1 starts first";
                    break;

                case 2:
                    players_choose.Text = "Player 2 starts first";
                    break;
            }
        }

        private void player1_odd_or_even_text_Click(object sender, EventArgs e)
        {

        }

        private void odd_player1_Click(object sender, EventArgs e) // Кнопка ODD на клик
        {
            odd_player1_btn = true; // Отсылает во флаг значение TRUE
            odd_player1.Image = Properties.Resources.o_button_mp; // Меняет картинку на нажатую
            even_player1.Image = Properties.Resources.e_button; // Заменяет картинку у кнопки EVEN на не нажатую
            player2_odd_or_even_text.Text = even_player1.Text; // Отсылает текст о том что выбрать можно только Even
            player2_odd_or_even_text.ForeColor = Color.Red; // Меняет цвет надписи на красный у игрока 2
            even_player2.Enabled = true; // Включает кнопку у 2го игрока
            odd_player2.Enabled = false; // Отключает кнопку у 2го игрока
            even_player2.Image = Properties.Resources.e_button_mp; // Подсвечивает у 2го игрока, ту кнопку которую можно нажать
            odd_player2.Image = Properties.Resources.o_button; // Убирает подсветку неактивной кнопки у 2 игрока

            // Присвоение переменной player1 строку ODD, а переменной player2 строку EVEN
            player1 = odd_player1.Text;
            player2 = even_player2.Text;
        }

        private void odd_player1_MouseEnter(object sender, EventArgs e) // Кнопка ODD на наведение мыши
        {
            odd_player1.Image = Properties.Resources.o_button_mp;
        }

        private void odd_player1_MouseLeave(object sender, EventArgs e) // Кнопка ODD на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (odd_player1_btn == true)
            {
                odd_player1.Image = Properties.Resources.o_button_mp;
            }
            else

                odd_player1.Image = Properties.Resources.o_button;
            odd_player1_btn = false;
        }

        private void even_player1_Click(object sender, EventArgs e) // Кнопка EVEN на клик
        {
            even_player1_btn = true; // Отсылает во флаг значение TRUE
            even_player1.Image = Properties.Resources.e_button_mp; // Меняет картинку на нажатую
            odd_player1.Image = Properties.Resources.o_button; // Заменяет картинку у кнопки ODD на не нажатую
            player2_odd_or_even_text.Text = odd_player1.Text; // Отсылает текст о том что выбрать можно только Odd
            player2_odd_or_even_text.ForeColor = Color.Red; // Меняет цвет надписи на красный у игрока 2
            odd_player2.Enabled = true; // Включает кнопку у 2го игрока
            even_player2.Enabled = false; // Отключает кнопку у 2го игрока
            odd_player2.Image = Properties.Resources.o_button_mp; // Подсвечивает у 2го игрока, ту кнопку которую можно нажать
            even_player2.Image = Properties.Resources.e_button;  // Убирает подсветку неактивной кнопки у 2 игрока

            // Присвоение переменной player1 строку EVEN, а переменной player2 строку ODD
            player1 = even_player1.Text;
            player2 = odd_player2.Text;
        }

        private void even_player1_MouseEnter(object sender, EventArgs e) // Кнопка EVEN на наведение мыши
        {
            even_player1.Image = Properties.Resources.e_button_mp;
        }

        private void even_player1_MouseLeave(object sender, EventArgs e) // Кнопка EVEN на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (even_player1_btn == true)
            {
                even_player1.Image = Properties.Resources.e_button_mp;
            }
            else
                even_player1.Image = Properties.Resources.e_button;
            even_player1_btn = false;
        }

        private void player1_number_1_Click(object sender, EventArgs e)
        {
            player1_number_1_btn = true; // Отсылает во флаг значение TRUE
            player1_number_1.Image = Properties.Resources.num_1_mp; // Меняет картинку на нажатую
            player1_number_2.Image = Properties.Resources.num_2; // Заменяет картинку у кнопки 2 игрока 1 на не нажатую
            player1_number_3.Image = Properties.Resources.num_3; // Заменяет картинку у кнопки 3 игрока 1 на не нажатую
            player1_number_4.Image = Properties.Resources.num_4; // Заменяет картинку у кнопки 4 игрока 1 на не нажатую
            player1_number_5.Image = Properties.Resources.num_5; // Заменяет картинку у кнопки 5 игрока 1 на не нажатую

            // Запись цифры в переменную p1 и невидимый текстбокс amount_box, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p1 = int.Parse(player1_number_1.Text);
            amount_box.Text = p1.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе
                
                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

        }

        private void player1_number_1_MouseEnter(object sender, EventArgs e) // Кнопка 1 на наведение мыши
        {
            player1_number_1.Image = Properties.Resources.num_1_mp;
        }

        private void player1_number_1_MouseLeave(object sender, EventArgs e) // Кнопка 1 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player1_number_1_btn == true)
            {
                player1_number_1.Image = Properties.Resources.num_1_mp;
            }
            else
                player1_number_1.Image = Properties.Resources.num_1;
            player1_number_1_btn = false;
        }

        private void player1_number_2_Click(object sender, EventArgs e)
        {
            player1_number_2_btn = true; // Отсылает во флаг значение TRUE
            player1_number_2.Image = Properties.Resources.num_2_mp; // Меняет картинку на нажатую
            player1_number_1.Image = Properties.Resources.num_1; // Заменяет картинку у кнопки 1 игрока 1 на не нажатую
            player1_number_3.Image = Properties.Resources.num_3; // Заменяет картинку у кнопки 3 игрока 1 на не нажатую
            player1_number_4.Image = Properties.Resources.num_4; // Заменяет картинку у кнопки 4 игрока 1 на не нажатую
            player1_number_5.Image = Properties.Resources.num_5; // Заменяет картинку у кнопки 5 игрока 1 на не нажатую

            // Запись цифры в переменную p1 и невидимый текстбокс amount_box, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p1 = int.Parse(player1_number_2.Text);
            amount_box.Text = p1.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }
        }

        private void player1_number_2_MouseEnter(object sender, EventArgs e) // Кнопка 2 на наведение мыши
        {
            player1_number_2.Image = Properties.Resources.num_2_mp;
        }

        private void player1_number_2_MouseLeave(object sender, EventArgs e) // Кнопка 2 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player1_number_2_btn == true)
            {
                player1_number_2.Image = Properties.Resources.num_2_mp;
            }
            else
                player1_number_2.Image = Properties.Resources.num_2;
            player1_number_2_btn = false;
        }

        private void player1_number_3_Click(object sender, EventArgs e)
        {
            player1_number_3_btn = true; // Отсылает во флаг значение TRUE
            player1_number_3.Image = Properties.Resources.num_3_mp; // Меняет картинку на нажатую
            player1_number_1.Image = Properties.Resources.num_1; // Заменяет картинку у кнопки 1 игрока 1 на не нажатую
            player1_number_2.Image = Properties.Resources.num_2; // Заменяет картинку у кнопки 2 игрока 1 на не нажатую
            player1_number_4.Image = Properties.Resources.num_4; // Заменяет картинку у кнопки 4 игрока 1 на не нажатую
            player1_number_5.Image = Properties.Resources.num_5; // Заменяет картинку у кнопки 5 игрока 1 на не нажатую

            // Запись цифры в переменную p1 и невидимый текстбокс amount_box, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p1 = int.Parse(player1_number_3.Text);
            amount_box.Text = p1.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }
        }

        private void player1_number_3_MouseEnter(object sender, EventArgs e) // Кнопка 3 на наведение мыши
        {
            player1_number_3.Image = Properties.Resources.num_3_mp;
        }

        private void player1_number_3_MouseLeave(object sender, EventArgs e) // Кнопка 3 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player1_number_3_btn == true)
            {
                player1_number_3.Image = Properties.Resources.num_3_mp;
            }
            else
                player1_number_3.Image = Properties.Resources.num_3;
            player1_number_3_btn = false;
        }

        private void player1_number_4_Click(object sender, EventArgs e)
        {
            player1_number_4_btn = true; // Отсылает во флаг значение TRUE
            player1_number_4.Image = Properties.Resources.num_4_mp; // Меняет картинку на нажатую
            player1_number_1.Image = Properties.Resources.num_1; // Заменяет картинку у кнопки 1 игрока 1 на не нажатую
            player1_number_2.Image = Properties.Resources.num_2; // Заменяет картинку у кнопки 2 игрока 1 на не нажатую
            player1_number_3.Image = Properties.Resources.num_3; // Заменяет картинку у кнопки 3 игрока 1 на не нажатую
            player1_number_5.Image = Properties.Resources.num_5; // Заменяет картинку у кнопки 5 игрока 1 на не нажатую

            // Запись цифры в переменную p1 и невидимый текстбокс amount_box, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p1 = int.Parse(player1_number_4.Text);
            amount_box.Text = p1.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }
        }

        private void player1_number_4_MouseEnter(object sender, EventArgs e) // Кнопка 4 на наведение мыши
        {
            player1_number_4.Image = Properties.Resources.num_4_mp;
        }

        private void player1_number_4_MouseLeave(object sender, EventArgs e) // Кнопка 4 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player1_number_4_btn == true)
            {
                player1_number_4.Image = Properties.Resources.num_4_mp;
            }
            else
                player1_number_4.Image = Properties.Resources.num_4;
            player1_number_4_btn = false;
        }

        private void player1_number_5_Click(object sender, EventArgs e)
        {
            player1_number_5_btn = true; // Отсылает во флаг значение TRUE
            player1_number_5.Image = Properties.Resources.num_5_mp; // Меняет картинку на нажатую
            player1_number_1.Image = Properties.Resources.num_1; // Заменяет картинку у кнопки 1 игрока 1 на не нажатую
            player1_number_2.Image = Properties.Resources.num_2; // Заменяет картинку у кнопки 2 игрока 1 на не нажатую
            player1_number_3.Image = Properties.Resources.num_3; // Заменяет картинку у кнопки 3 игрока 1 на не нажатую
            player1_number_4.Image = Properties.Resources.num_4; // Заменяет картинку у кнопки 4 игрока 1 на не нажатую

            // Запись цифры в переменную p1 и невидимый текстбокс amount_box, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p1 = int.Parse(player1_number_5.Text);
            amount_box.Text = p1.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }
        }

        private void player1_number_5_MouseEnter(object sender, EventArgs e) // Кнопка 5 на наведение мыши
        {
            player1_number_5.Image = Properties.Resources.num_5_mp;
        }

        private void player1_number_5_MouseLeave(object sender, EventArgs e) // Кнопка 5 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player1_number_5_btn == true)
            {
                player1_number_5.Image = Properties.Resources.num_5_mp;
            }
            else
                player1_number_5.Image = Properties.Resources.num_5;
            player1_number_5_btn = false;
        }

        private void player2_odd_or_even_text_Click(object sender, EventArgs e)
        {

        }

        private void odd_player2_Click(object sender, EventArgs e)
        {
            odd_player2_btn = true; // Отсылает во флаг значение TRUE
            odd_player2.Image = Properties.Resources.o_button_mp; // Меняет картинку на нажатую
            even_player2.Image = Properties.Resources.e_button; // Заменяет картинку у кнопки EVEN на не нажатую
            player1_odd_or_even_text.Text = even_player2.Text; // Отсылает текст о том что выбрать можно только Even
            player1_odd_or_even_text.ForeColor = Color.Red; // Меняет цвет надписи на красный у игрока 1
            even_player1.Enabled = true; // Включает кнопку у 1го игрока
            odd_player1.Enabled = false; // Отключает кнопку у 1го игрока
            even_player1.Image = Properties.Resources.e_button_mp; // Подсвечивает у 1го игрока, ту кнопку которую можно нажать
            odd_player1.Image = Properties.Resources.o_button; // Убирает подсветку неактивной кнопки у 1 игрока

            // Присвоение переменной player2 строку ODD, а переменной player1 строку EVEN
            player2 = odd_player2.Text;
            player1 = even_player1.Text;
        }

        private void odd_player2_MouseEnter(object sender, EventArgs e) // Кнопка ODD на наведение мыши
        {
            odd_player2.Image = Properties.Resources.o_button_mp;
        }

        private void odd_player2_MouseLeave(object sender, EventArgs e) // Кнопка ODD на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (odd_player2_btn == true)
            {
                odd_player2.Image = Properties.Resources.o_button_mp;
            }
            else

                odd_player2.Image = Properties.Resources.o_button;
            odd_player2_btn = false;
        }

        private void even_player2_Click(object sender, EventArgs e)
        {
            even_player2_btn = true; // Отсылает во флаг значение TRUE
            even_player2.Image = Properties.Resources.e_button_mp; // Меняет картинку на нажатую
            odd_player2.Image = Properties.Resources.o_button; // Заменяет картинку у кнопки ODD на не нажатую
            player1_odd_or_even_text.Text = odd_player2.Text; // Отсылает текст о том что выбрать можно только Odd
            player1_odd_or_even_text.ForeColor = Color.Red; // Меняет цвет надписи на красный у игрока 1
            odd_player1.Enabled = true; // Включает кнопку у 1го игрока
            even_player1.Enabled = false; // Отключает кнопку у 1го игрока
            odd_player1.Image = Properties.Resources.o_button_mp; // Подсвечивает у 1го игрока, ту кнопку которую можно нажать
            even_player1.Image = Properties.Resources.e_button;  // Убирает подсветку неактивной кнопки у 1 игрока

            // Присвоение переменной player2 строку EVEN, а переменной player1 строку ODD
            player2 = even_player2.Text;
            player1 = odd_player1.Text;
        }

        private void even_player2_MouseEnter(object sender, EventArgs e) // Кнопка EVEN на наведение мыши
        {
            even_player2.Image = Properties.Resources.e_button_mp;
        }

        private void even_player2_MouseLeave(object sender, EventArgs e) // Кнопка EVEN на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (even_player2_btn == true)
            {
                even_player2.Image = Properties.Resources.e_button_mp;
            }
            else

                even_player2.Image = Properties.Resources.e_button;
            even_player2_btn = false;
        }

        private void player2_number_1_Click(object sender, EventArgs e)
        {
            player2_number_1_btn = true; // Отсылает во флаг значение TRUE
            player2_number_1.Image = Properties.Resources.num_1_mp; // Меняет картинку на нажатую
            player2_number_2.Image = Properties.Resources.num_2; // Заменяет картинку у кнопки 2 игрока 2 на не нажатую
            player2_number_3.Image = Properties.Resources.num_3; // Заменяет картинку у кнопки 3 игрока 2 на не нажатую
            player2_number_4.Image = Properties.Resources.num_4; // Заменяет картинку у кнопки 4 игрока 2 на не нажатую
            player2_number_5.Image = Properties.Resources.num_5; // Заменяет картинку у кнопки 5 игрока 2 на не нажатую

            // Запись цифры в переменную p2 и невидимый текстбокс amount_box2, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p2 = int.Parse(player2_number_1.Text);
            amount_box2.Text = p2.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }
        }

        private void player2_number_1_MouseEnter(object sender, EventArgs e) // Кнопка 1 на наведение мыши
        {
            player2_number_1.Image = Properties.Resources.num_1_mp;
        }

        private void player2_number_1_MouseLeave(object sender, EventArgs e) // Кнопка 1 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player2_number_1_btn == true)
            {
                player2_number_1.Image = Properties.Resources.num_1_mp;
            }
            else
                player2_number_1.Image = Properties.Resources.num_1;
            player2_number_1_btn = false;
        }

        private void player2_number_2_Click(object sender, EventArgs e)
        {
            player2_number_2_btn = true; // Отсылает во флаг значение TRUE
            player2_number_2.Image = Properties.Resources.num_2_mp; // Меняет картинку на нажатую
            player2_number_1.Image = Properties.Resources.num_1; // Заменяет картинку у кнопки 1 игрока 2 на не нажатую
            player2_number_3.Image = Properties.Resources.num_3; // Заменяет картинку у кнопки 3 игрока 2 на не нажатую
            player2_number_4.Image = Properties.Resources.num_4; // Заменяет картинку у кнопки 4 игрока 2 на не нажатую
            player2_number_5.Image = Properties.Resources.num_5; // Заменяет картинку у кнопки 5 игрока 2 на не нажатую

            // Запись цифры в переменную p2 и невидимый текстбокс amount_box2, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p2 = int.Parse(player2_number_2.Text);
            amount_box2.Text = p2.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }
        }

        private void player2_number_2_MouseEnter(object sender, EventArgs e) // Кнопка 2 на наведение мыши
        {
            player2_number_2.Image = Properties.Resources.num_2_mp;
        }

        private void player2_number_2_MouseLeave(object sender, EventArgs e) // Кнопка 2 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player2_number_2_btn == true)
            {
                player2_number_2.Image = Properties.Resources.num_2_mp;
            }
            else
                player2_number_2.Image = Properties.Resources.num_2;
            player2_number_2_btn = false;
        }

        private void player2_number_3_Click(object sender, EventArgs e)
        {
            player2_number_3_btn = true; // Отсылает во флаг значение TRUE
            player2_number_3.Image = Properties.Resources.num_3_mp; // Меняет картинку на нажатую
            player2_number_1.Image = Properties.Resources.num_1; // Заменяет картинку у кнопки 1 игрока 2 на не нажатую
            player2_number_2.Image = Properties.Resources.num_2; // Заменяет картинку у кнопки 2 игрока 2 на не нажатую
            player2_number_4.Image = Properties.Resources.num_4; // Заменяет картинку у кнопки 4 игрока 2 на не нажатую
            player2_number_5.Image = Properties.Resources.num_5; // Заменяет картинку у кнопки 5 игрока 2 на не нажатую

            // Запись цифры в переменную p2 и невидимый текстбокс amount_box2, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p2 = int.Parse(player2_number_3.Text);
            amount_box2.Text = p2.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }
        }

        private void player2_number_3_MouseEnter(object sender, EventArgs e) // Кнопка 3 на наведение мыши
        {
            player2_number_3.Image = Properties.Resources.num_3_mp;
        }

        private void player2_number_3_MouseLeave(object sender, EventArgs e) // Кнопка 3 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player2_number_3_btn == true)
            {
                player2_number_3.Image = Properties.Resources.num_3_mp;
            }
            else
                player2_number_3.Image = Properties.Resources.num_3;
            player2_number_3_btn = false;
        }

        private void player2_number_4_Click(object sender, EventArgs e)
        {
            player2_number_4_btn = true; // Отсылает во флаг значение TRUE
            player2_number_4.Image = Properties.Resources.num_4_mp; // Меняет картинку на нажатую
            player2_number_1.Image = Properties.Resources.num_1; // Заменяет картинку у кнопки 1 игрока 2 на не нажатую
            player2_number_2.Image = Properties.Resources.num_2; // Заменяет картинку у кнопки 2 игрока 2 на не нажатую
            player2_number_3.Image = Properties.Resources.num_3; // Заменяет картинку у кнопки 3 игрока 2 на не нажатую
            player2_number_5.Image = Properties.Resources.num_5; // Заменяет картинку у кнопки 5 игрока 2 на не нажатую

            // Запись цифры в переменную p2 и невидимый текстбокс amount_box2, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p2 = int.Parse(player2_number_4.Text);
            amount_box2.Text = p2.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }
        }

        private void player2_number_4_MouseEnter(object sender, EventArgs e) // Кнопка 4 на наведение мыши
        {
            player2_number_4.Image = Properties.Resources.num_4_mp;
        }

        private void player2_number_4_MouseLeave(object sender, EventArgs e) // Кнопка 4 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player2_number_4_btn == true)
            {
                player2_number_4.Image = Properties.Resources.num_4_mp;
            }
            else
                player2_number_4.Image = Properties.Resources.num_4;
            player2_number_4_btn = false;
        }

        private void player2_number_5_Click(object sender, EventArgs e)
        {
            player2_number_5_btn = true; // Отсылает во флаг значение TRUE
            player2_number_5.Image = Properties.Resources.num_5_mp; // Меняет картинку на нажатую
            player2_number_1.Image = Properties.Resources.num_1; // Заменяет картинку у кнопки 1 игрока 2 на не нажатую
            player2_number_2.Image = Properties.Resources.num_2; // Заменяет картинку у кнопки 2 игрока 2 на не нажатую
            player2_number_3.Image = Properties.Resources.num_3; // Заменяет картинку у кнопки 3 игрока 2 на не нажатую
            player2_number_4.Image = Properties.Resources.num_4; // Заменяет картинку у кнопки 4 игрока 2 на не нажатую

            // Запись цифры в переменную p2 и невидимый текстбокс amount_box2, далее проверка чтобы amount_box & amount_box2 не были равны нулю
            // Если условие проходит, то идет сложение двух переменный p1 & p2 и вывод их суммы на текстбокс amount
            p2 = int.Parse(player2_number_5.Text);
            amount_box2.Text = p2.ToString();
            if (Convert.ToInt32(amount_box.Text) != 0 && Convert.ToInt32(amount_box2.Text) != 0)
            {
                count = p1 + p2;
                amount.Text = count.ToString();
            }

            switch (count) // Вывод картинки которая сходится с суммой переменной count, также вывод картинки ODD или EVEN в зависимости от суммы переменной count
            {
                case 2:
                    amount.Image = Properties.Resources.num_2_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 3:
                    amount.Image = Properties.Resources.num_3_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 4:
                    amount.Image = Properties.Resources.num_4_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 5:
                    amount.Image = Properties.Resources.num_5_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 6:
                    amount.Image = Properties.Resources.num_6_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 7:
                    amount.Image = Properties.Resources.num_7_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 8:
                    amount.Image = Properties.Resources.num_8_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;

                case 9:
                    amount.Image = Properties.Resources.num_9_mp;
                    odd_even_text.Image = Properties.Resources.o_button_mp;
                    break;

                case 10:
                    amount.Image = Properties.Resources.num_10_mp;
                    odd_even_text.Image = Properties.Resources.e_button_mp;
                    break;
            }

            // Проверка условий для игроков на наличие того кто выйграл. Проверка проводится при нажатии любой из цирф панели игрока 1 и/или панели игрока 2
            if (player1 == even_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player1 == odd_player1.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 1";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }

            if (player2 == even_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 0 || player2 == odd_player2.Text && Convert.ToInt32(amount.Text) != 0 && Convert.ToInt32(amount.Text) % 2 == 1)
            {
                winner_player.Text = "Player 2";
                winner_player.ForeColor = Color.Red; // Меняет цвет надписи на красный
                players_choose.Text = "Winner winner chicken dinner"; // Выводит текст о победе

                // Проигрывается музыка для победителя
                SoundPlayer winner_sound;
                winner_sound = new SoundPlayer(Properties.Resources.winner_diner);
                winner_sound.Load(); winner_sound.Play();
            }
        }

        private void player2_number_5_MouseEnter(object sender, EventArgs e) // Кнопка 5 на наведение мыши
        {
            player2_number_5.Image = Properties.Resources.num_5_mp;
        }

        private void player2_number_5_MouseLeave(object sender, EventArgs e) // Кнопка 5 на отведение мыши, с проверкой условия нажата ли была кнопка
        {
            if (player2_number_5_btn == true)
            {
                player2_number_5.Image = Properties.Resources.num_5_mp;
            }
            else
                player2_number_5.Image = Properties.Resources.num_5;
            player2_number_5_btn = false;
        }

        private void restart_Click(object sender, EventArgs e) // Кнопка рестарта игры
        {
            Application.Restart();
        }

        private void exit_Click(object sender, EventArgs e) // Кнопка выхода из игры
        {
            Application.Exit();
        }

        private void copyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Ссылка Donate в копирайте
        {
            System.Diagnostics.Process.Start("https://vk.com/sne.byorn");
        }

        private void vk_soc_Click(object sender, EventArgs e) // Кнопка ВК на клик
        {
            System.Diagnostics.Process.Start("https://vk.com/sne.byorn");
        }

        private void vk_soc_MouseEnter(object sender, EventArgs e) // Кнопка ВК на наведние мышки
        {
            vk_soc.Image = Properties.Resources.vk_32_mouse;
        }

        private void vk_soc_MouseLeave(object sender, EventArgs e) // Кнопка ВК на отведение мышки
        {
            vk_soc.Image = Properties.Resources.vk_32;
        }

        private void twit_soc_Click(object sender, EventArgs e) // Кнопка Твиттера на клик
        {
            System.Diagnostics.Process.Start("https://twitter.com/4tkz_ru");
        }

        private void twit_soc_MouseEnter(object sender, EventArgs e) // Кнопка Твиттера на наведение мышки
        {
            twit_soc.Image = Properties.Resources.twit_32_mouse;
        }

        private void twit_soc_MouseLeave(object sender, EventArgs e) // Кнопка Твиттера на отведение мышки
        {
            twit_soc.Image = Properties.Resources.twit_32;
        }

        private void az_lang_MouseEnter(object sender, EventArgs e) // Кнопка Азербайджанского языка на наведение мышки
        {
            az_lang.Image = Properties.Resources.az_mouse;
        }

        private void az_lang_MouseLeave(object sender, EventArgs e) // Кнопка Азербайджанского языка на отведение мышки
        {
            az_lang.Image = Properties.Resources.az;
        }

        private void ru_lang_MouseEnter(object sender, EventArgs e) // Кнопка Русского языка на наведение мышки
        {
            ru_lang.Image = Properties.Resources.ru_mouse;
        }

        private void ru_lang_MouseLeave(object sender, EventArgs e) // Кнопка Русского языка на отведение мышки
        {
            ru_lang.Image = Properties.Resources.ru;
        }

        private void en_lang_MouseEnter(object sender, EventArgs e) // Кнопка Английского языка на наведение мышки
        {
            en_lang.Image = Properties.Resources.en_mouse;
        }

        private void en_lang_MouseLeave(object sender, EventArgs e) // Кнопка Английского языка на отведение мышки
        {
            en_lang.Image = Properties.Resources.en;
        }
    }
}
