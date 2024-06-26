﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form1 : Form
    {
        private readonly HelloContext _dbContext;
        private DataGridViewRow _selectedRow;


        public Form1()
        {
            InitializeComponent();
            _dbContext = new HelloContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            UserDataLoad();
            //MessageBox.Show("Uygulamaya hoşgeldiniz :) ", "Merhaba",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            //LoadData();
            //dataGridView1.ReadOnly = false;
        }


        private void UserDataLoad(List<User> users = null)
        {
            var dataUsrs = new List<User>();

            if (users == null)
             dataUsrs = _dbContext.Users.ToList();
            else dataUsrs = users;

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("CreateDate");
            dataTable.Columns.Add("Name");

            foreach (var item in dataUsrs)
            {
                dataTable.Rows.Add(item.id, item.createdate, item.name);
            }

            dataGridView1.DataSource = dataTable;

        }


        //private void LoadData()
        //{
        //    // Örnek olarak veritabanından bir tabloyu yüklüyoruz
        //    var data = _dbContext.Users.ToList(); // MyEntities, DbContext'in DbSet'i

        //    // DataGridView'e veri yüklemek için DataTable kullanabiliriz
        //    var dataTable = new DataTable();
        //    dataTable.Columns.Add("Id"); // Örnek kolon ekleme
        //    dataTable.Columns.Add("CreateDate"); // Örnek kolon ekleme
        //    dataTable.Columns.Add("Name"); // Örnek kolon ekleme

        //    // Veritabanından alınan verileri DataTable'a ekleme
        //    foreach (var item in data)
        //    {
        //        dataTable.Rows.Add(item.id, item.createdate, item.name); // Örnek propertylerin eklenmesi
        //    }

        //    // DataGridView'e DataTable'ı bağlama
        //    dataGridView1.DataSource = dataTable;
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                var usr = new User() { name = textBox1.Text };

                _dbContext.Users.Add(usr);
                _dbContext.SaveChanges();
                UserDataLoad();
                textBox1.Text = string.Empty;
                MessageBox.Show("İlgili kayıt eklenmiştir");
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int id = int.Parse(_selectedRow.Cells[0].Value.ToString());

            DialogResult result = MessageBox.Show($"İlgili {id} nolu kaydı silmek istiyormusunuz? ","Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //MessageBox.Show("Evet'e tıklandı!");
                using (var dbContext = new HelloContext())
                {
                    var usr = dbContext.Users.FirstOrDefault(x => x.id == id);
                    dbContext.Users.Remove(usr);
                    dbContext.SaveChanges();
                }
                UserDataLoad();
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                var usr = _dbContext.Users.FirstOrDefault(x => x.name.ToLower() == textBox2.Text.ToLower());
                //var usrlst = new List<User>();
                //usrlst.Add(usr);
                UserDataLoad(new List<User> { usr });
                //UserDataLoad(usrlst);
            }
            else
                UserDataLoad();
        }
               

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {   
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            _selectedRow = row;



            string id = row.Cells[0].Value.ToString();
            string createDate = row.Cells[1].Value.ToString();
            string name = row.Cells[2].Value.ToString();
            label4.Text = name;
            label3.Text = id;

            //MessageBox.Show($"Seçilen satırın hücreleri: {cell1Value}, {cell2Value}");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string newValue = cell.Value.ToString();

                // Değiştirilen hücrenin yeni değerini kullanabilir veya işleyebilirsiniz
                DialogResult  result = MessageBox.Show($"Değiştirilen hücrenin yeni değerini  {newValue} yapmak istiyormusunuz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var id = int.Parse(row.Cells[0].Value.ToString());
                    var usr = _dbContext.Users.FirstOrDefault(x => x.id == id);
                    usr.name = newValue;
                    _dbContext.SaveChanges();
                    UserDataLoad();
                }
                else
                {
                    UserDataLoad();

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
