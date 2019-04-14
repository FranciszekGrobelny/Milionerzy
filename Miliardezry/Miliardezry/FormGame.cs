using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;



namespace Miliardezry
{
    public partial class FormGame : Form
    {
        ClassPlayer Player = new ClassPlayer();
        

        String Answer;
        int n = 1;
        
        
        public FormGame()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przycisk zatwierdzający odpowiedź gracza. Sprawdza jego odpowiedź(jeśli dobra to włącza dźwię oklasków,zmienia wartość pieniędzy w textBoxach
        /// i uruchamia metode klasy ClassPlayer.Jeśli zła to uruchamia metode klasy ClassPlayer i ustawia wszystki etextBoxy na stan początkowy)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnswer_Click(object sender, EventArgs e)
        {

            if (textBoxAnswer.Text == Answer)
            {

                SoundPlayer splayer = new SoundPlayer(@"C:\Users\FRANEK\Desktop\Miliardezry\applause.wav");
                splayer.Play();

                switch (n)
                {
                    case 1:
                        textBoxActuallMoney.Text = "500 zł";
                        textBoxEnsureMoney.Text = "0 zł";
                        break;
                    case 2:
                        textBoxActuallMoney.Text = "1 000 zł";
                        textBoxEnsureMoney.Text = "0 zł";
                        break;
                    case 3:
                        textBoxActuallMoney.Text = "2 000 zł";
                        textBoxEnsureMoney.Text = "0 zł";
                        break;
                    case 4:
                        textBoxActuallMoney.Text = "10 000 zł";
                        textBoxEnsureMoney.Text = "5 000 zł";
                        break;
                    case 5:
                        textBoxActuallMoney.Text = "100 000 zł";
                        textBoxEnsureMoney.Text = "5 000 zł";
                        break;
                    case 6:
                        textBoxActuallMoney.Text = "1 000 000 zł";
                        textBoxEnsureMoney.Text = "100 000 zł";
                        break;
                    case 7:
                        textBoxActuallMoney.Text = "20 000 000 zł";
                        textBoxEnsureMoney.Text = "100 000 zł";
                        break;
                    case 8:
                        textBoxActuallMoney.Text = "500 000 000 zł";
                        textBoxEnsureMoney.Text = "100 000 zł";
                        break;
                    case 9:
                        textBoxActuallMoney.Text = "750 000 000 zł";
                        textBoxEnsureMoney.Text = "100 000 zł";
                        break;
                    case 10:
                        textBoxActuallMoney.Text = "1 000 000 000 zł";
                        textBoxEnsureMoney.Text = "1 000 000 000 zł";

                        Player.SaveMoney(textBoxEnsureMoney.Text, textBoxNick.Text);

                        MessageBox.Show("Brawo!!! Wygrałeś 1 miliard!!!");
                        n = 0;
                        textBoxActuallMoney.Text = "0 zł";
                        textBoxEnsureMoney.Text = "0 zł";
                        textBoxQuestion.Text = "";
                        textBoxA.Text = "";
                        textBoxB.Text = "";
                        textBoxC.Text = "";
                        textBoxD.Text = "";
                        textBoxAnswer.Text = "";
                        Close();
                        
                        break;
                }
                n++;
            }
            else
            {
                MessageBox.Show("Błędna odpowiedź! Wygrywasz " + textBoxEnsureMoney.Text + "");

                string EnsureMoney = textBoxEnsureMoney.Text;
                if (textBoxEnsureMoney.Text == "0 zł") {
                    textBoxEnsureMoney.Text = "zero zł";
                };
                string Nick = textBoxNick.Text;
                Player.SaveMoney(textBoxEnsureMoney.Text, textBoxNick.Text);

                MessageBox.Show("Twój wynik został zapisany.");
                Close();
                n = 1;
                textBoxActuallMoney.Text = "0 zł";
                textBoxEnsureMoney.Text = "0 zł";
                textBoxQuestion.Text = "";
                textBoxA.Text = "";
                textBoxB.Text = "";
                textBoxC.Text = "";
                textBoxD.Text = "";
                textBoxAnswer.Text = "";
            }

            
           
        }
        /// <summary>
        /// Przycisk wypisujący treści komórek z bazy danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            Random zmiennaPytania = new Random();
            int k = zmiennaPytania.Next(1,3);

            String source = @"Data Source=YOU;Initial Catalog=miliarderzy;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            String SqlQuery = $"SELECT * FROM TablePytania WHERE PoziomTrudności = {n} AND NrPytania = {k}";
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBoxQuestion.Text = (dr["Tresc"].ToString());
                textBoxA.Text = (dr["A"].ToString());
                textBoxB.Text = (dr["B"].ToString());
                textBoxC.Text = (dr["C"].ToString());
                textBoxD.Text = (dr["D"].ToString());
                Answer = (dr["Poprawna"].ToString());
            }
            con.Close();

            if (n == 11)
            {
                Close();
            }

            
        }
        /// <summary>
        /// Kopiowanie wartości textBoxNick z FormMenu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGame_Load(object sender, EventArgs e)
        {
            textBoxNick.Text = FormMenu.Nick;
        }

        
    }
}
