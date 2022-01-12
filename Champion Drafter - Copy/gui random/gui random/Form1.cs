using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_random
{
    public partial class Form1 : Form
    {

        int b2 = 1;
        int b3 = 1;
        int b4 = 1;
        int b5 = 1;
        int b6 = 1;
        int b7 = 1;
        int b8 = 1;
        int b9 = 1;
        int b10= 1;
        int b11= 1;
        int b12= 1;
        int b13= 1;
        int b14= 1;
        int b15= 1;
        int b16= 1;
        int b17= 1;
        int b18= 1;
        int b19= 1;
        int b20= 1;
        int b21= 1;



        private void InitializeMyButton()
        {

            Button button1 = new Button();
            button1.DialogResult = DialogResult.OK;
            Controls.Add(button1);

            Button button2 = new Button();
            button2.DialogResult = DialogResult.OK;
            Controls.Add(button2);
            Button button3 = new Button();
            button3.DialogResult = DialogResult.OK;
            Controls.Add(button3);

            Button button4 = new Button();
            button4.DialogResult = DialogResult.OK;
            Controls.Add(button4);

            Button button5 = new Button();
            button5.DialogResult = DialogResult.OK;
            Controls.Add(button5);

            Button button6 = new Button();
            button6.DialogResult = DialogResult.OK;
            Controls.Add(button6);

            Button button7 = new Button();
            button7.DialogResult = DialogResult.OK;
            Controls.Add(button7);

            Button button8 = new Button();
            button8.DialogResult = DialogResult.OK;
            Controls.Add(button8);

            Button button9 = new Button();
            button9.DialogResult = DialogResult.OK;
            Controls.Add(button9);

            Button button10 = new Button();
            button10.DialogResult = DialogResult.OK;
            Controls.Add(button10);

            Button button11 = new Button();
            button11.DialogResult = DialogResult.OK;
            Controls.Add(button11);

            Button button12 = new Button();
            button12.DialogResult = DialogResult.OK;
            Controls.Add(button12);

            Button button13 = new Button();
            button13.DialogResult = DialogResult.OK;
            Controls.Add(button13);

            Button button14 = new Button();
            button14.DialogResult = DialogResult.OK;
            Controls.Add(button14);

            Button button15 = new Button();
            button15.DialogResult = DialogResult.OK;
            Controls.Add(button15);

            Button button16 = new Button();
            button16.DialogResult = DialogResult.OK;
            Controls.Add(button16);

            Button button17 = new Button();
            button17.DialogResult = DialogResult.OK;
            Controls.Add(button17);

            Button button18 = new Button();
            button18.DialogResult = DialogResult.OK;
            Controls.Add(button18);

            Button button19 = new Button();
            button19.DialogResult = DialogResult.OK;
            Controls.Add(button19);

            Button button20 = new Button();
            button20.DialogResult = DialogResult.OK;
            Controls.Add(button20);

            Button button21 = new Button();
            button21.DialogResult = DialogResult.OK;
            Controls.Add(button21);

        }

        public Form1()
        {
            InitializeComponent();

        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);
            string[] Champions = { "Aatrox", "Ahri", "Akali","Akshan", "Alistar", "Amumu", "Anivia", "Annie", "Aphelios", "Ashe", "Aurelion Sol", "Azir", "Bard", "Blitzcrank", "Brand", "Braum", "Caitlyn", "Camille", "Cassiopeia", "Cho'Gath", "Corki", "Darius", "Diana", "Draven", "Dr.Mundo", "Ekko", "Elise", "Evelynn", "Ezreal", "Fiddlesticks", "Fiora", "Fizz", "Galio", "Gangplank", "Garen", "Gnar", "Gragas", "Graves", "GWEN", "Hecarim", "Heimersinger", "Illaoi", "Irelia", "Ivern", "Janna", "Jarvan IV", "Jax", "Jayce", "Jhin", "Jinx", "Kai'Sa", "Kalista", "Karma", "Karthus", "Kassadin", "Katarina", "Kayle", "Kayn", "Kennen", "Kha'Zix", "Kindred", "Kled", "Kog'Maw", "LeBlanc", "Lee Sin", "Leona", "Lillia", "Lissandra", "Lucian", "Lulu", "Lux", "Malphite", "Malzahar", "Maokai", "Master Yi", "Miss Fortune", "Mordekaiser", "Morgana", "Nami", "Nasus", "Nautilus", "Neeko", "Nidalee", "Nocturne", "Nunu & Willump", "Olaf", "Orianna", "Ornn", "Pantheon", "Poppy", "Pyke", "Qiyana", "Quinn", "Rakan", "Rammus", "Rek'Sai", "Rell", "Renekton", "Rengar", "Riven", "Rumble", "Ryze", "Samira", "Sejuani", "Senna", "Seraphine", "Sett", "Shaco", "Shen", "Shyvanna", "Singed", "Sion", "Sivir", "Skarner", "Sona", "Soraka", "Swain", "Sylas", "Syndra", "Tham Kench", "Taliyah", "Talon", "Taric", "Teemo", "Thresh", "Tristana", "Trundle", "Tryndamere", "Twisted Fate", "Twitch", "Udyr", "Urgot", "Varus", "Vayne", "Veigar","Vex", "Vel'Koz", "Vi", "Viego", "Viktor", "Vladimir", "Volibear", "Warwick", "Wukong", "Xayah", "Xerath", "Xin Zhao", "Yasuo", "Yone", "Yorick", "Yuumi", "Zac", "Zed", "Ziggs", "Zilean", "Zoe", "Zyra" };
            List<string> Champs = new List<string>();
            Champs.AddRange(Champions);
            Random rand = new Random();
            string debug = "";
            List<Image> imgs = new List<Image>();
            List<string> Names = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                var index = rand.Next(Champs.Count - i);
                debug += Champs[index] + "\n";
                Names.Add(Champs[index]);
                imgs.Add(Image.FromFile(fullPath + "/" + Champs[index] + ".png"));
                Champs.RemoveAt(index);
            }
            button2.BackgroundImage = imgs[0];
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            label2.Text = Names[0];
            button3.BackgroundImage = imgs[1];
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            label3.Text = Names[1];
            button4.BackgroundImage = imgs[2];
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            label4.Text = Names[2];
            button5.BackgroundImage = imgs[3];
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            label5.Text = Names[3];
            button6.BackgroundImage = imgs[4];
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            label6.Text = Names[4];
            button7.BackgroundImage = imgs[5];
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            label7.Text = Names[5];
            button8.BackgroundImage = imgs[6];
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            label8.Text = Names[6];
            button9.BackgroundImage = imgs[7];
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            label9.Text = Names[7];
            button10.BackgroundImage = imgs[8];
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            label10.Text = Names[8];
            button11.BackgroundImage = imgs[9];
            button11.BackgroundImageLayout = ImageLayout.Stretch;
            label11.Text = Names[9];
            button12.BackgroundImage = imgs[10];
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            label12.Text = Names[10];
            button13.BackgroundImage = imgs[11];
            button13.BackgroundImageLayout = ImageLayout.Stretch;
            label13.Text = Names[11];
            button14.BackgroundImage = imgs[12];
            button14.BackgroundImageLayout = ImageLayout.Stretch;
            label14.Text = Names[12];
            button15.BackgroundImage = imgs[13];
            button15.BackgroundImageLayout = ImageLayout.Stretch;
            label15.Text = Names[13];
            button16.BackgroundImage = imgs[14];
            button16.BackgroundImageLayout = ImageLayout.Stretch;
            label16.Text = Names[14];
            button17.BackgroundImage = imgs[15];
            button17.BackgroundImageLayout = ImageLayout.Stretch;
            label17.Text = Names[15];
            button18.BackgroundImage = imgs[16];
            button18.BackgroundImageLayout = ImageLayout.Stretch;
            label18.Text = Names[16];
            button19.BackgroundImage = imgs[17];
            button19.BackgroundImageLayout = ImageLayout.Stretch;
            label19.Text = Names[17];
            button20.BackgroundImage = imgs[18];
            button20.BackgroundImageLayout = ImageLayout.Stretch;
            label20.Text = Names[18];
            button21.BackgroundImage = imgs[19];
            button21.BackgroundImageLayout = ImageLayout.Stretch;
            label21.Text = Names[19];
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b2 == 0)
            {
                Image no = Image.FromFile( fullPath + "/" + "lane.png");
                button2.Image = no;
                b2 = 1;
            }
            else if (b2 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button2.Image = x;
                b2 = 2;
            }
            else if (b2 == 2) 
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button2.Image = y;
                b2 = 3;
            }
            else if (b2 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button2.Image = z;
                b2 = 0;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b3 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button3.Image = no;
                b3 = 1;
            }
            else if (b3 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button3.Image = x;
                b3 = 2;
            }
            else if (b3 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button3.Image = y;
                b3 = 3;
            }
            else if (b3 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button3.Image = z;
                b3 = 0;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b4 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button4.Image = no;
                b4 = 1;
            }
            else if (b4 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button4.Image = x;
                b4= 2;
            }
            else if (b4 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button4.Image = y;
                b4 = 3;
            }
            else if (b4 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button4.Image = z;
                b4 = 0;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b5 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button5.Image = no;
                b5 = 1;
            }
            else if (b5== 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button5.Image = x;
                b5 = 2;
            }
            else if (b5 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button5.Image = y;
                b5 = 3;
            }
            else if (b5 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button5.Image = z;
                b5 = 0;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b6 == 0)
            {


                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button6.Image = no;
                b6 = 1;
            }
            else if (b6 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button6.Image = x;
                b6 = 2;
            }
            else if (b6 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button6.Image = y;
                b6 = 3;
            }
            else if (b6 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button6.Image = z;
                b6 = 0;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b7 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button7.Image = no;
                b7 = 1;
            }
            else if (b7 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button7.Image = x;
                b7 = 2;
            }
            else if (b7 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button7.Image = y;
                b7 = 3;
            }
            else if (b7 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button7.Image = z;
                b7 = 0;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b8 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button8.Image = no;
                b8 = 1;
            }
            else if (b8 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button8.Image = x;
                b8 = 2;
            }
            else if (b8 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button8.Image = y;
                b8 = 3;
            }
            else if (b8 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button8.Image = z;
                b8 = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b9 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button9.Image = no;
                b9 = 1;
            }
            else if (b9 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button9.Image = x;
                b9 = 2;
            }
            else if (b9 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button9.Image = y;
                b9 = 3;
            }
            else if (b9 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button9.Image = z;
                b9 = 0;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b10 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button10.Image = no;
                b10 = 1;
            }
            else if (b10 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button10.Image = x;
                b10 = 2;
            }
            else if (b10 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button10.Image = y;
                b10 = 3;
            }
            else if (b10 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button10.Image = z;
                b10 = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b11 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button11.Image = no;
                b11 = 1;
            }
            else if (b11 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button11.Image = x;
                b11 = 2;
            }
            else if (b11 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button11.Image = y;
                b11 = 3;
            }
            else if (b11 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button11.Image = z;
                b11 = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b12 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button12.Image = no;
                b12 = 1;
            }
            else if (b12 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button12.Image = x;
                b12 = 2;
            }
            else if (b12 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button12.Image = y;
                b12 = 3;
            }
            else if (b12 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button12.Image = z;
                b12 = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b13 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button13.Image = no;
                b13 = 1;
            }
            else if (b13 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button13.Image = x;
                b13 = 2;
            }
            else if (b13 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button13.Image = y;
                b13 = 3;
            }
            else if (b13 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button13.Image = z;
                b13 = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b14 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button14.Image = no;
                b14 = 1;
            }
            else if (b14 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button14.Image = x;
                b14 = 2;
            }
            else if (b14 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button14.Image = y;
                b14 = 3;
            }
            else if (b14 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button14.Image = z;
                b14 = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b15 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button15.Image = no;
                b15 = 1;
            }
            else if (b15 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button15.Image = x;
                b15 = 2;
            }
            else if (b15 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button15.Image = y;
                b15 = 3;
            }
            else if (b15 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button15.Image = z;
                b15 = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b16 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button16.Image = no;
                b16 = 1;
            }
            else if (b16 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button16.Image = x;
                b16 = 2;
            }
            else if (b16 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button16.Image = y;
                b16 = 3;
            }
            else if (b16 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button16.Image = z;
                b16 = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b17 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button17.Image = no;
                b17 = 1;
            }
            else if (b17 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button17.Image = x;
                b17 = 2;
            }
            else if (b17 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button17.Image = y;
                b17 = 3;
            }
            else if (b17 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button17.Image = z;
                b17 = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b18 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button18.Image = no;
                b18 = 1;
            }
            else if (b18 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button18.Image = x;
                b18 = 2;
            }
            else if (b18 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button18.Image = y;
                b18 = 3;
            }
            else if (b18 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button18.Image = z;
                b18 = 0;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b19 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button19.Image = no;
                b19 = 1;
            }
            else if (b19 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button19.Image = x;
                b19 = 2;
            }
            else if (b19 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button19.Image = y;
                b19 = 3;
            }
            else if (b19 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button19.Image = z;
                b19 = 0;
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b20 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button20.Image = no;
                b20 = 1;
            }
            else if (b20 == 1)
            {
                Image x = Image.FromFile(@fullPath + "/" + "Dane.png");
                button20.Image = x;
                b20 = 2;
            }
            else if (b20 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button20.Image = y;
                b20 = 3;
            }
            else if (b20 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button20.Image = z;
                b20 = 0;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string filename = "Funny League Champs";
            string fullPath = "";
            fullPath = Path.GetFullPath(filename);

            if (b21 == 0)
            {
                Image no = Image.FromFile(fullPath + "/" + "lane.png");
                button21.Image = no;
                b21 = 1;
            }
            else if (b21 == 1)
            {
                Image x = Image.FromFile(fullPath + "/" + "Dane.png");
                button21.Image = x;
                b21 = 2;
            }
            else if (b21 == 2)
            {
                Image y = Image.FromFile(fullPath + "/" + "Bane.png");
                button21.Image = y;
                b21 = 3;
            }
            else if (b21 == 3)
            {
                Image z = Image.FromFile(fullPath + "/" + "kane.png");
                button21.Image = z;
                b21 = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
