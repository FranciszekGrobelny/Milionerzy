using System;
using System.Windows.Forms;

namespace Miliardezry
{
    public partial class FormMenu : Form
    {
        
        public static string Nick;

        FormGame Game = new FormGame();
        FromTop10 Top10 = new FromTop10();
        ClassPlayer Player = new ClassPlayer();
       
        public FormMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przycisk włączający okno gry(przepisuje też wartość texxtBoxNick to FormGame).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Nick = textBoxEnterNick.Text;

            Player.SaveNick(textBoxEnterNick.Text);            

            Game.ShowDialog();
        }
        /// <summary>
        /// Przycisk otwierający okno z top 10 graczami.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTop10_Click(object sender, EventArgs e)
        {
            Top10.ShowDialog();
        }
        /// <summary>
        /// Przycisk otwierający okienko z instrukcją.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Gra miliarderzy to teleturniej w którym główną 
wygraną jest 1 000 000 000 zł. 
Aby wygrać główna nagrodę gracz musi odpowiedzieć poprawnie 
na 10 pytań, natomiast jeżeli gracz popełni błąd kończy grę  z wygraną gwarantowaną.

Aby zacząć grę należy wpisać nazwę gracza i wybrać opcje „Graj”->”losuj pytanie”. 
Następnie pokazuje się pytanie i w okienku na dole należy wpisać poprawna odpowiedz i zatwierdzić przyciskiem „zatwierdź”. 
Aby przejść do następnego pytania wybieramy po raz  kolejny przycisk „losuj pytanie” 

Miłej zabawy! 
Życzy spółka Frankopolo
");
        }
    }
}
