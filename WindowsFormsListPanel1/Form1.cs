using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsListPanel1.UC;


namespace WindowsFormsListPanel1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UserControl1 userControls_1 = new UserControl1();
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 0));
            tableLayoutPanel1.Controls.Add(userControls_1, 1, 0);
        }

        //private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        //{
            
        //}
    }
}
