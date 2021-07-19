using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSqlProj.BLL.DTO;
using TestSqlProj.BLL.Services;
using TestSqlProj.DAL.EF;
using TestSqlProj.DAL.Models;
using TestSqlProj.DAL.Repositories;
using TestSqlProj.DAL.Repositories.Interfaces;

namespace TestSqlProj.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNew();
        }
        void ReadNew()
        {
            listBox1.Items.Clear();
            ServiceDTO serv = new ServiceDTO();
            foreach (var item in serv.GetAll())
            {
                listBox1.Items.Add($"{item.Id} {item.Name} {item.Age}");
            }
        }

        void CreateNew()
        {
            UserDTO user = new UserDTO();
            ServiceDTO service = new ServiceDTO();
            user.Name = textBox1.Text;
            user.Age = int.Parse(textBox2.Text);
            service.Add(user);
            ReadNew();
        }

        void Read()
        {
            listBox1.Items.Clear();
            UserContext db = new UserContext();
            Repository repository = new Repository(db);
            foreach (var item in repository.GetAll())
            {
                listBox1.Items.Add($"{item.Id} {item.Name} {item.Age}");
            }
        }

        void Create()
        {
            User user = new User();
            user.Name = textBox1.Text;
            user.Age = int.Parse(textBox2.Text);
            UserContext db = new UserContext();
            Repository repository = new Repository(db);
            repository.Create(user);
            ReadNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceDTO s = new ServiceDTO();
            s.Delete(int.Parse(textBox3.Text));
            ReadNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceDTO s = new ServiceDTO();
           var user = s.FindId(int.Parse(textBox3.Text));
            if (user != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"{user.Id}: {user.Name} - {user.Age}");
            }
            else
            {
                MessageBox.Show($"Запись с Id={textBox3.Text} не найдена!");
            }
        }
    }
}
