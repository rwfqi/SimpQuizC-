using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz telah selesai!" + Environment.NewLine +
                                "Kamu telah menjawab " + score + " pertanyaan dengan benar" + Environment.NewLine +
                                "Nilai total Kamu adalah " + percentage + " %" + Environment.NewLine +
                                "Klik Ok untuk bermain lagi"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {

            

            switch(qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Apa warna dari Langit?";

                    button1.Text = "Biru";
                    button2.Text = "Kuning";
                    button3.Text = "Ungu";
                    button4.Text = "Merah";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Siapa nama tokoh utama dari Komik Iron Man?";

                    button1.Text = "Tony Stank";
                    button2.Text = "Tony Stark";
                    button3.Text = "Rody";
                    button4.Text = "Peter Quill";

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.fortnite;

                    lblQuestion.Text = "Siapa yang membuat game diatas?";

                    button1.Text = "EA";
                    button2.Text = "Activision";
                    button3.Text = "Square Enix";
                    button4.Text = "Epic Games";

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Dimana letak ibukota England?";

                    button1.Text = "Birmingham";
                    button2.Text = "London";
                    button3.Text = "Brighton";
                    button4.Text = "Liverpool";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.eafc;

                    lblQuestion.Text = "Apa nama game diatas?";

                    button1.Text = "Fifa";
                    button2.Text = "Pro Evolution Soccer";
                    button3.Text = "Winning Eleven";
                    button4.Text = "Football Manager";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.gtasa;

                    lblQuestion.Text = "Siapa nama karakter utama dalam game ini?";

                    button1.Text = "Ezio";
                    button2.Text = "Franklin Clinton";
                    button3.Text = "Carl Johnson";
                    button4.Text = "Alfiansyah Bustami";

                    correctAnswer = 3;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.csgo;

                    lblQuestion.Text = "Apa nama game dari gambar diatas?";

                    button1.Text = "Counter Strike: 2";
                    button2.Text = "Call of Duty";
                    button3.Text = "Battlefield";
                    button4.Text = "Half Life 3";

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.lbj;

                    lblQuestion.Text = "Siapa nama pemain basket diatas?";

                    button1.Text = "Kobe Bryant";
                    button2.Text = "Michael Jordan";
                    button3.Text = "LeBron James";
                    button4.Text = "Stephen Curry";

                    correctAnswer = 3;

                    break;

                case 9:

                    pictureBox1.Image = Properties.Resources.ryo;

                    lblQuestion.Text = "Siapa nama tokoh dari Anime Bocchi The Rock diatas?";

                    button1.Text = "Nijika Ijichi";
                    button2.Text = "Ikuyo Kita";
                    button3.Text = "Hitori Gotoh";
                    button4.Text = "Ryo Yamada";

                    correctAnswer = 4;

                    break;

                case 10:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Bahasa C# dikembangkan oleh siapa?";

                    button1.Text = "Google";
                    button2.Text = "Microsoft";
                    button3.Text = "Oracle";
                    button4.Text = "JetBrains";

                    correctAnswer = 2;

                    break;



            }




        }

    }
}
