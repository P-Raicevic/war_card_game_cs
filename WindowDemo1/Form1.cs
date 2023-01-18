using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowDemo1
{
    public partial class Form1 : Form
    {
        Game g1 = new Game();
        Queue p1 = new Queue();
        Queue p2 = new Queue();
        Queue pomoc = new Queue();
        Graphics g;
        Pen p;


        /*
        Bitmap _3C = new Bitmap(WindowDemo1.Properties.Resources._3C, new Size(114, 165));
        Bitmap _4C = new Bitmap(WindowDemo1.Properties.Resources._4C, new Size(114, 165));
        Bitmap _5C = new Bitmap(WindowDemo1.Properties.Resources._5C, new Size(114, 165));
        Bitmap _6C = new Bitmap(WindowDemo1.Properties.Resources._6C, new Size(114, 165));
        Bitmap _7C = new Bitmap(WindowDemo1.Properties.Resources._7C, new Size(114, 165));
        Bitmap _8C = new Bitmap(WindowDemo1.Properties.Resources._8C, new Size(114, 165));
        Bitmap _2C = new Bitmap(WindowDemo1.Properties.Resources._2C, new Size(114, 165));
        Bitmap _9C = new Bitmap(WindowDemo1.Properties.Resources._9C, new Size(114, 165));
        Bitmap _10C = new Bitmap(WindowDemo1.Properties.Resources._10C, new Size(114, 165));
        Bitmap _11C = new Bitmap(WindowDemo1.Properties.Resources._11C, new Size(114, 165));
        Bitmap _12C = new Bitmap(WindowDemo1.Properties.Resources._12C, new Size(114, 165));
        Bitmap _13C = new Bitmap(WindowDemo1.Properties.Resources._13C, new Size(114, 165));
        Bitmap _14C = new Bitmap(WindowDemo1.Properties.Resources._14C, new Size(114, 165));

        Bitmap _3D = new Bitmap(WindowDemo1.Properties.Resources._3D, new Size(114, 165));
        Bitmap _4D = new Bitmap(WindowDemo1.Properties.Resources._4D, new Size(114, 165));
        Bitmap _5D = new Bitmap(WindowDemo1.Properties.Resources._5D, new Size(114, 165));
        Bitmap _6D = new Bitmap(WindowDemo1.Properties.Resources._6D, new Size(114, 165));
        Bitmap _7D = new Bitmap(WindowDemo1.Properties.Resources._7D, new Size(114, 165));
        Bitmap _8D = new Bitmap(WindowDemo1.Properties.Resources._8D, new Size(114, 165));
        Bitmap _2D = new Bitmap(WindowDemo1.Properties.Resources._2D, new Size(114, 165));
        Bitmap _9D = new Bitmap(WindowDemo1.Properties.Resources._9D, new Size(114, 165));
        Bitmap _10D = new Bitmap(WindowDemo1.Properties.Resources._10D, new Size(114, 165));
        Bitmap _11D = new Bitmap(WindowDemo1.Properties.Resources._11D, new Size(114, 165));
        Bitmap _12D = new Bitmap(WindowDemo1.Properties.Resources._12D, new Size(114, 165));
        Bitmap _13D = new Bitmap(WindowDemo1.Properties.Resources._13D, new Size(114, 165));
        Bitmap _14D = new Bitmap(WindowDemo1.Properties.Resources._14D, new Size(114, 165));

        Bitmap _3H = new Bitmap(WindowDemo1.Properties.Resources._3H, new Size(114, 165));
        Bitmap _4H = new Bitmap(WindowDemo1.Properties.Resources._4H, new Size(114, 165));
        Bitmap _5H = new Bitmap(WindowDemo1.Properties.Resources._5H, new Size(114, 165));
        Bitmap _6H = new Bitmap(WindowDemo1.Properties.Resources._6H, new Size(114, 165));
        Bitmap _7H = new Bitmap(WindowDemo1.Properties.Resources._7H, new Size(114, 165));
        Bitmap _8H = new Bitmap(WindowDemo1.Properties.Resources._8H, new Size(114, 165));
        Bitmap _2H = new Bitmap(WindowDemo1.Properties.Resources._2H, new Size(114, 165));
        Bitmap _9H = new Bitmap(WindowDemo1.Properties.Resources._9H, new Size(114, 165));
        Bitmap _10H = new Bitmap(WindowDemo1.Properties.Resources._10H, new Size(114, 165));
        Bitmap _11H = new Bitmap(WindowDemo1.Properties.Resources._11H, new Size(114, 165));
        Bitmap _12H = new Bitmap(WindowDemo1.Properties.Resources._12H, new Size(114, 165));
        Bitmap _13H = new Bitmap(WindowDemo1.Properties.Resources._13H, new Size(114, 165));
        Bitmap _14H = new Bitmap(WindowDemo1.Properties.Resources._14H, new Size(114, 165));

        Bitmap _3S = new Bitmap(WindowDemo1.Properties.Resources._3S, new Size(114, 165));
        Bitmap _4S = new Bitmap(WindowDemo1.Properties.Resources._4S, new Size(114, 165));
        Bitmap _5S = new Bitmap(WindowDemo1.Properties.Resources._5S, new Size(114, 165));
        Bitmap _6S = new Bitmap(WindowDemo1.Properties.Resources._6S, new Size(114, 165));
        Bitmap _7S = new Bitmap(WindowDemo1.Properties.Resources._7S, new Size(114, 165));
        Bitmap _8S = new Bitmap(WindowDemo1.Properties.Resources._8S, new Size(114, 165));
        Bitmap _2S = new Bitmap(WindowDemo1.Properties.Resources._2S, new Size(114, 165));
        Bitmap _9S = new Bitmap(WindowDemo1.Properties.Resources._9S, new Size(114, 165));
        Bitmap _10S = new Bitmap(WindowDemo1.Properties.Resources._10S, new Size(114, 165));
        Bitmap _11S = new Bitmap(WindowDemo1.Properties.Resources._11S, new Size(114, 165));
        Bitmap _12S = new Bitmap(WindowDemo1.Properties.Resources._12S, new Size(114, 165));
        Bitmap _13S = new Bitmap(WindowDemo1.Properties.Resources._13S, new Size(114, 165));
        Bitmap _14S = new Bitmap(WindowDemo1.Properties.Resources._14S, new Size(114, 165));

    */

        Bitmap back = new Bitmap(WindowDemo1.Properties.Resources.back, new Size(114, 165));
        Bitmap green = new Bitmap(WindowDemo1.Properties.Resources.gruen, new Size(114, 165));









        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = WindowDemo1.Properties.Resources.back;
            pictureBox2.Image = WindowDemo1.Properties.Resources.back;
            pictureBox3.Image = WindowDemo1.Properties.Resources.gruen;
            pictureBox4.Image = WindowDemo1.Properties.Resources.gruen;

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            g1.start(p1,p2,pomoc);
            pictureBox1.Image = WindowDemo1.Properties.Resources.back;
            pictureBox2.Image = WindowDemo1.Properties.Resources.back;
            pictureBox3.Image = WindowDemo1.Properties.Resources.gruen;
            pictureBox4.Image = WindowDemo1.Properties.Resources.gruen;
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = ""+(p1.Count);
            textBox4.Text = ""+(p2.Count);
            MessageBox.Show("Mozete zapoceti igru!");
        }

        private String ImeKarte(Card c)
        {
            String s1 = c.face;
            String s2 = c.suit;

            switch (s1)
            {
                case "2":
                    s1 = "Two";
                    break;
                case "3":
                    s1 = "Three";
                    break;
                case "4":
                    s1 = "Four";
                    break;
                case "5":
                    s1 = "Five";
                    break;
                case "6":
                    s1 = "Six";
                    break;
                case "7":
                    s1 = "Seven";
                    break;
                case "8":
                    s1 = "Eight";
                    break;
                case "9":
                    s1 = "Nine";
                    break;
                case "10":
                    s1 = "Ten";
                    break;
                case "11":
                    s1 = "Jack";
                    break;
                case "12":
                    s1 = "Queen";
                    break;
                case "13":
                    s1 = "King";
                    break;
                case "14":
                    s1 = "Ace";
                    break;
            }

            switch (s2)
            {
                case "H":
                    s2 = "Heart";
                    break;
                case "C":
                    s2 = "Club";
                    break;
                case "S":
                    s2 = "Spade";
                    break;
                case "D":
                    s2 = "Diamond";
                    break;
            }
            return s1 + " of " + s2;
        }
        private void UpdateLabel()
        {
            if (p1.Count == 0 || p2.Count == 0)
            {
                textBox2.Text = "Kraj!";
                return;
            }

            Card k1 = (Card)p1.Peek();
            Card k2 = (Card)p2.Peek();

            if (Int32.Parse(k1.face) > Int32.Parse(k2.face))
            {
                textBox2.Text = "Player takes cards: " + ImeKarte(k1) + " is greater than " + ImeKarte(k2);
                return;
            }
            else if (Int32.Parse(k1.face) < Int32.Parse(k2.face))
            {
                textBox2.Text = "Computer takes cards: " + ImeKarte(k1) + " is less than " + ImeKarte(k2);
                return;
            }

            else if (Int32.Parse(k1.face) == Int32.Parse(k2.face))
            {
                textBox2.Text = "War: " + ImeKarte(k1) + " is equal to " + ImeKarte(k2);
                return;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);
            x++;
            textBox1.Text = x.ToString();



            if (p1.Count == 0 && p2.Count == 0)
            {
                g1.start(p1, p2, pomoc);
                textBox3.Text = "" + (p1.Count);
                textBox4.Text = "" + (p2.Count);
                textBox1.Text = "1";
            }
            if (p1.Count != 0)
            {
                String s1 = "" + p1.Peek();
                switch (s1)
                {
                    case "2C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._2C;
                        break;
                    case "3C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._3C;
                        break;
                    case "4C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._4C;
                        break;
                    case "5C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._5C;
                        break;
                    case "6C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._6C;
                        break;
                    case "7C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._7C;
                        break;
                    case "8C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._8C;
                        break;
                    case "9C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._9C;
                        break;
                    case "10C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._10C;
                        break;
                    case "11C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._11C;
                        break;
                    case "12C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._12C;
                        break;
                    case "13C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._13C;
                        break;
                    case "14C":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._14C;
                        break;
                    case "2D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._2D;
                        break;
                    case "3D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._3D;
                        break;
                    case "4D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._4D;
                        break;
                    case "5D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._5D;
                        break;
                    case "6D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._6D;
                        break;
                    case "7D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._7D;
                        break;
                    case "8D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._8D;
                        break;
                    case "9D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._9D;
                        break;
                    case "10D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._10D;
                        break;
                    case "11D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._11D;
                        break;
                    case "12D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._12D;
                        break;
                    case "13D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._13D;
                        break;
                    case "14D":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._14D;
                        break;
                    case "2S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._2S;
                        break;
                    case "3S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._3S;
                        break;
                    case "4S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._4S;
                        break;
                    case "5S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._5S;
                        break;
                    case "6S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._6S;
                        break;
                    case "7S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._7S;
                        break;
                    case "8S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._8S;
                        break;
                    case "9S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._9S;
                        break;
                    case "10S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._10S;
                        break;
                    case "11S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._11S;
                        break;
                    case "12S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._12S;
                        break;
                    case "13S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._13S;
                        break;
                    case "14S":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._14S;
                        break;
                    case "2H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._2H;
                        break;
                    case "3H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._3H;
                        break;
                    case "4H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._4H;
                        break;
                    case "5H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._5H;
                        break;
                    case "6H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._6H;
                        break;
                    case "7H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._7H;
                        break;
                    case "8H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._8H;
                        break;
                    case "9H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._9H;
                        break;
                    case "10H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._10H;
                        break;
                    case "11H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._11H;
                        break;
                    case "12H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._12H;
                        break;
                    case "13H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._13H;
                        break;
                    case "14H":
                        pictureBox4.Image = WindowDemo1.Properties.Resources._14H;
                        break;
                }
            }
            if (p2.Count != 0)
            {
                String s1 = "" + p2.Peek();
                switch (s1)
                {
                    case "2C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._2C;
                        break;
                    case "3C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._3C;
                        break;
                    case "4C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._4C;
                        break;
                    case "5C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._5C;
                        break;
                    case "6C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._6C;
                        break;
                    case "7C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._7C;
                        break;
                    case "8C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._8C;
                        break;
                    case "9C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._9C;
                        break;
                    case "10C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._10C;
                        break;
                    case "11C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._11C;
                        break;
                    case "12C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._12C;
                        break;
                    case "13C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._13C;
                        break;
                    case "14C":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._14C;
                        break;
                    case "2D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._2D;
                        break;
                    case "3D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._3D;
                        break;
                    case "4D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._4D;
                        break;
                    case "5D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._5D;
                        break;
                    case "6D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._6D;
                        break;
                    case "7D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._7D;
                        break;
                    case "8D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._8D;
                        break;
                    case "9D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._9D;
                        break;
                    case "10D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._10D;
                        break;
                    case "11D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._11D;
                        break;
                    case "12D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._12D;
                        break;
                    case "13D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._13D;
                        break;
                    case "14D":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._14D;
                        break;
                    case "2S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._2S;
                        break;
                    case "3S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._3S;
                        break;
                    case "4S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._4S;
                        break;
                    case "5S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._5S;
                        break;
                    case "6S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._6S;
                        break;
                    case "7S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._7S;
                        break;
                    case "8S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._8S;
                        break;
                    case "9S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._9S;
                        break;
                    case "10S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._10S;
                        break;
                    case "11S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._11S;
                        break;
                    case "12S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._12S;
                        break;
                    case "13S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._13S;
                        break;
                    case "14S":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._14S;
                        break;
                    case "2H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._2H;
                        break;
                    case "3H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._3H;
                        break;
                    case "4H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._4H;
                        break;
                    case "5H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._5H;
                        break;
                    case "6H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._6H;
                        break;
                    case "7H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._7H;
                        break;
                    case "8H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._8H;
                        break;
                    case "9H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._9H;
                        break;
                    case "10H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._10H;
                        break;
                    case "11H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._11H;
                        break;
                    case "12H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._12H;
                        break;
                    case "13H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._13H;
                        break;
                    case "14H":
                        pictureBox3.Image = WindowDemo1.Properties.Resources._14H;
                        break;
                }
            }
            UpdateLabel();
            if (p1.Count == 0)
                pictureBox4.Image = WindowDemo1.Properties.Resources.gruen;
            if (p2.Count == 0)
                pictureBox3.Image = WindowDemo1.Properties.Resources.gruen;
            g1.igraj(p1, p2);
            if (p1.Count == 0)
            {
                pictureBox1.Image = WindowDemo1.Properties.Resources.gruen;

            }
            else if (p1.Count > 0)
            {
                pictureBox1.Image = WindowDemo1.Properties.Resources.back;
            }

            if (p2.Count == 0)
            {
                pictureBox2.Image = WindowDemo1.Properties.Resources.gruen;
            }
            else if (p1.Count > 0)
            {
                pictureBox2.Image = WindowDemo1.Properties.Resources.back;
            }

            textBox3.Text = "" + p1.Count;
            textBox4.Text = "" + p2.Count;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Igra zapocinje tako sto se spil promijesa a zatim se podijeli na dva jednaka dijela" +
                ". Igrac zapocinje igru tako sto uzima kartu sa vrha spila i stavlja je na sto. Igrac cija karta ima vecu " +
                "vrijednost nosi kartu. Karte se stavljaju na dno spila. Ako igraci imaju iste karte tada dolazi do rata i uporedjuje" +
                " se sledeca karta. Tako se radi sve dok se ne dobiju dvije razlicite karte. Tada igrac sa vecom kartom uzima sve" +
                " karte koje su se koristile tokom rata. Igrac koji prvi ostane bez karata je izgubio.","Pravila Igre!");
        }

        private void winGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g1.start2(p1, p2, pomoc);
            
            pictureBox3.Image = WindowDemo1.Properties.Resources.gruen;
            pictureBox4.Image = WindowDemo1.Properties.Resources.gruen;
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "" + p1.Count;
            textBox4.Text = "" + p2.Count;
            MessageBox.Show("Mozete zapoceti igru!");
        }

        private void loseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g1.start3(p1, p2, pomoc);

            pictureBox3.Image = WindowDemo1.Properties.Resources.gruen;
            pictureBox4.Image = WindowDemo1.Properties.Resources.gruen;
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "" + p1.Count;
            textBox4.Text = "" + p2.Count;
            MessageBox.Show("Mozete zapoceti igru!");
        }

        private void Form1_Enter(object sender, EventArgs e)
        {



        }

       
    }
}
