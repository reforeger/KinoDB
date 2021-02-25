﻿using System;
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
    public partial class Form1 : Form
    {
        int i, j;
        Label lbl;
        Button btnC, btnB;
        ComboBox cBox;
        ListBox lBox;
        SqlDataAdapter Hall_adapter;
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\DataKino.mdf; Integrated Security = True");
        int[] row_list;
        int[] places_list;
        public Form1()
        {
            Height = 500;
            Width = 350;
            BackColor = Color.Wheat;
            connection.Open();
            Hall_adapter = new SqlDataAdapter("SELECT * FROM Halls", connection);
            DataTable halls_table = new DataTable();
            Hall_adapter.Fill(halls_table);

            lbl = new Label();
            lbl.Text = "Select a hall:";
            lbl.Size = new Size(70, 20);
            lbl.Location = new Point(10, 64);
            Controls.Add(lbl);

            cBox = new ComboBox();
            cBox.Size = new Size(180, 20);
            cBox.Location = new Point(80, 60);
            foreach (DataRow row in halls_table.Rows)
            {
                cBox.Items.Add(row["HallName"]);
            }

            row_list = new int[halls_table.Rows.Count];
            places_list = new int[halls_table.Rows.Count];
            int a = 0;
            foreach (DataRow row in halls_table.Rows)
            {
                row_list[a] = (int)row["Row"];
                places_list[a] = (int)row["Places"];
                a = a + 1;
            }
            connection.Close();
            cBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox.SelectedIndex = 0;
            Controls.Add(cBox);

            lBox = new ListBox();
            lBox.Size = new Size(180, 100);
            lBox.Location = new Point(80, 100);
            Controls.Add(lBox);

            btnC = new Button();
            btnC.Text = "Continue";
            btnC.Size = new Size(120, 40);
            btnC.Location = new Point(110, 400);
            btnC.BackColor = Color.LightGray;
            btnC.Click += BtnC_Click;
            Controls.Add(btnC);

            btnB = new Button();
            btnB.Text = "Back";
            btnB.Size = new Size(80, 30);
            btnB.Location = new Point(10, 10);
            btnB.BackColor = Color.LightGray;
            btnB.Click += BtnB_Click;
            Controls.Add(btnB);
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            FormFilm films = new FormFilm();
            films.Show();
            Hide();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            i = row_list[cBox.SelectedIndex];
            j = places_list[cBox.SelectedIndex];
            Kino Hall = new Kino(i, j);
            Hall.Show();
            Hide();
        }
    }
}
