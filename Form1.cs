using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BL;
using DA;


namespace _3layer_university
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            student st = new student();
            dataGridView1.DataSource = st.select();          
        }

        private void add_Click(object sender, EventArgs e)
        {
            frmadd fa = new frmadd();
            fa.ShowDialog();
      
            Form1_Load(null, null);
        }

       

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin fl = new frmlogin();
            fl.ShowDialog();
        
      
        }
    }
}
