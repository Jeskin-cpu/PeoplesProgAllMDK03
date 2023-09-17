using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dlyZheni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SQLiteConnection SQL;

        private void ShowPhoto(int phId)
        {
            Form2 newForm = new Form2();
            string queryString = "SELECT NameInfo FROM chtliks Where Id = @NmId";
            SQLiteCommand command = new SQLiteCommand(queryString, SQL);
            command.Parameters.AddWithValue("@NmId", phId); // Здесь я предположил, что nmId является ошибкой и должно быть phId
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string NameInfo = reader.GetString(0);
                newForm.textBox1.Text = NameInfo;
            }

            string queryStringPhoto = "SELECT Photo1, Photo2 FROM Photos Where Id = @PhId";
            SQLiteCommand commandPhoto = new SQLiteCommand(queryStringPhoto, SQL);
            commandPhoto.Parameters.AddWithValue("@PhId", phId);

            SQLiteDataReader readerPhoto = commandPhoto.ExecuteReader();
            while (readerPhoto.Read())
            {
                string Photo1 = readerPhoto.GetString(0);
                string Photo2 = readerPhoto.GetString(1);

                newForm.pictureBox1.Image = Image.FromFile(Photo1);
                newForm.pictureBox2.Image = Image.FromFile(Photo2);
            }

            reader.Close();
            readerPhoto.Close();


            newForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowPhoto(1);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            SQL = new SQLiteConnection(GVN.connection);
            await SQL.OpenAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPhoto(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowPhoto(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowPhoto(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowPhoto(5);
        }
    }
}
