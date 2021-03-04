using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoDM_DB
{
    public partial class FormFilm : Form
    {
        Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8;
        Label lbl1, lbl2, lbl3 ,lbl4, lbl5, lbl6, lbl7, lbl8;
        ComboBox cBox;
        SqlDataAdapter Film_adapter;
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\DataKino.mdf; Integrated Security = True");
        public FormFilm()
        {
            Height = 350;
            Width = 800;
            Text = "Film select";

            Size = new Size(1050, 600);
            BackColor = Color.FromArgb(174, 214, 211);

            connection.Open();
            Film_adapter = new SqlDataAdapter("SELECT * FROM Film", connection);
            DataTable film_table = new DataTable();
            Film_adapter.Fill(film_table);

            btn1 = new Button();
            btn1.Size = new Size(200, 200);
            btn1.Location = new Point(30, 50);
            btn1.BackgroundImage = Image.FromFile("../../imgage/avatar.jpg");
            btn1.BackgroundImageLayout = ImageLayout.Stretch;
            btn1.Click += Btn1_Click;
            Controls.Add(btn1);

            btn2 = new Button();
            btn2.Size = new Size(200, 200);
            btn2.Location = new Point(290, 50);
            btn2.BackgroundImage = Image.FromFile("../../imgage/soul.jpg");
            btn2.BackgroundImageLayout = ImageLayout.Stretch;
            btn2.Click += Btn2_Click;
            Controls.Add(btn2);

            btn3 = new Button();
            btn3.Size = new Size(200, 200);
            btn3.Location = new Point(550, 50);
            btn3.BackgroundImage = Image.FromFile("../../imgage/dju.jpg");
            btn3.BackgroundImageLayout = ImageLayout.Stretch;
            btn3.Click += Btn3_Click;
            Controls.Add(btn3);

            btn4 = new Button();
            btn4.Size = new Size(200, 200);
            btn4.Location = new Point(810, 50);
            btn4.BackgroundImage = Image.FromFile("../../imgage/alita.jpg");
            btn4.BackgroundImageLayout = ImageLayout.Stretch;
            btn4.Click += Btn4_Click;
            Controls.Add(btn4);

            btn5 = new Button();
            btn5.Size = new Size(200, 200);
            btn5.Location = new Point(30, 300);
            btn5.BackgroundImage = Image.FromFile("../../imgage/res.jpg");
            btn5.BackgroundImageLayout = ImageLayout.Stretch;
            btn5.Click += Btn5_Click;
            Controls.Add(btn5);

            btn6 = new Button();
            btn6.Size = new Size(200, 200);
            btn6.Location = new Point(290, 300);
            btn6.BackgroundImage = Image.FromFile("../../imgage/baby.jpg");
            btn6.BackgroundImageLayout = ImageLayout.Stretch;
            btn6.Click += Btn6_Click;
            Controls.Add(btn6);

            btn7 = new Button();
            btn7.Size = new Size(200, 200);
            btn7.Location = new Point(550, 300);
            btn7.BackgroundImage = Image.FromFile("../../imgage/spider.jpg");
            btn7.BackgroundImageLayout = ImageLayout.Stretch;
            btn7.Click += Btn7_Click;
            Controls.Add(btn7);

            btn8 = new Button();
            btn8.Size = new Size(200, 200);
            btn8.Location = new Point(810, 300);
            btn8.BackgroundImage = Image.FromFile("../../imgage/jur1.jpg");
            btn8.BackgroundImageLayout = ImageLayout.Stretch;
            btn8.Click += Btn8_Click;
            Controls.Add(btn8);


            lbl1 = new Label();
            lbl1.Text = "Avatar";
            lbl1.Size = new Size(70, 20);
            lbl1.Location = new Point(100, 270);
            Controls.Add(lbl1);

            lbl2 = new Label();
            lbl2.Text = "Soul";
            lbl2.Size = new Size(90, 20);
            lbl2.Location = new Point(370, 270);
            Controls.Add(lbl2);

            lbl3 = new Label();
            lbl3.Text = "Djumadji";
            lbl3.Size = new Size(70, 20);
            lbl3.Location = new Point(620, 270);
            Controls.Add(lbl3);

            lbl4 = new Label();
            lbl4.Text = "Alita: Battle Angel";
            lbl4.Size = new Size(130, 20);
            lbl4.Location = new Point(870, 270);
            Controls.Add(lbl4);

            lbl5 = new Label();
            lbl5.Text = "Resident Evil";
            lbl5.Size = new Size(90, 20);
            lbl5.Location = new Point(100, 520);
            Controls.Add(lbl5);

            lbl6 = new Label();
            lbl6.Text = "Baby driver";
            lbl6.Size = new Size(70, 20);
            lbl6.Location = new Point(370, 520);
            Controls.Add(lbl6);

            lbl7 = new Label();
            lbl7.Text = "Spider man";
            lbl7.Size = new Size(70, 20);
            lbl7.Location = new Point(620, 520);
            Controls.Add(lbl7);

            lbl8 = new Label();
            lbl8.Text = "jurassic world";
            lbl8.Size = new Size(90, 20);
            lbl8.Location = new Point(890, 520);
            Controls.Add(lbl8);

            cBox = new ComboBox();
            cBox.Size = new Size(180, 20);
            cBox.Location = new Point(430, 20);
            foreach (DataRow row in film_table.Rows)
            {
                cBox.Items.Add(row["Genre"]);
            }
            connection.Close();
            cBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox.SelectedIndex = 0;
            Controls.Add(cBox);
        }



        private void Btn1_Click(object sender, EventArgs e)
        {
            Form1 Kino = new Form1();
            Kino.Show();
            Kino.Text = "Avatar";
            Hide();
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            Form1 Kino = new Form1();
            Kino.Show();
            Kino.Text = "Soul";
            Hide();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Form1 Kino = new Form1();
            Kino.Show();
            Kino.Text = "Djumadji";
            Hide();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Form1 Kino = new Form1();
            Kino.Show();
            Kino.Text = "Alita: Battle Angel";
            Hide();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Form1 Kino = new Form1();
            Kino.Show();
            Kino.Text = "Resident Evil";
            Hide();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Form1 Kino = new Form1();
            Kino.Show();
            Kino.Text = "Baby driver";
            Hide();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Form1 Kino = new Form1();
            Kino.Show(); 
            Kino.Text = "Spider man";
            Hide();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Form1 Kino = new Form1();
            Kino.Show();
            Kino.Text = "jurassic world";
            Hide();
        }
    }
}
