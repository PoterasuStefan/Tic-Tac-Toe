using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {


        bool next_icon=true;
        public Form1()
        {
            InitializeComponent();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Player 1's turn";

        }



        private void label1_Click(object sender, EventArgs e)
        {
            

            Label clickedLabel = sender as Label;


            
            

            if (next_icon)
            {
                clickedLabel.Text = "X";
                next_icon = false;
                ActiveForm.Text = "Player 2's turn";
            }
            else
            {
                clickedLabel.Text = "O";
                next_icon = true;
                ActiveForm.Text = "Player 1's turn";
            }
            //checkfor vertical
            if (label1.Text.Equals( label2.Text)&&label2.Text.Equals(label3.Text)&&label1.Text.Length==1)
                {
                MessageBox.Show("The winner is "+ label1.Text);
            }
            if (label4.Text.Equals(label5.Text) && label5.Text.Equals(label6.Text) && label4.Text.Length == 1)
            {
                MessageBox.Show("The winner is " + label4.Text);
            }
            if (label7.Text.Equals(label8.Text) && label8.Text.Equals(label9.Text) && label7.Text.Length == 1)
            {
                MessageBox.Show("The winner is " + label7.Text);
            }
            //orizontal
            if (label1.Text.Equals(label4.Text) && label4.Text.Equals(label7.Text) && label1.Text.Length == 1)
            {
                MessageBox.Show("The winner is " + label1.Text);
            }
            if (label2.Text.Equals(label5.Text) && label5.Text.Equals(label8.Text) && label2.Text.Length == 1)
            {
                MessageBox.Show("The winner is " + label2.Text);
            }
            if (label3.Text.Equals(label5.Text) && label5.Text.Equals(label9.Text) && label3.Text.Length == 1)
            {
                MessageBox.Show("The winner is " + label3.Text);
            }
            //diagonal
            if (label1.Text.Equals(label5.Text) && label5.Text.Equals(label9.Text) && label1.Text.Length == 1)
            {
                MessageBox.Show("The winner is " + label1.Text);
            }
            if (label3.Text.Equals(label5.Text) && label5.Text.Equals(label7.Text) && label3.Text.Length == 1)
            {
                MessageBox.Show("The winner is " + label3.Text); ;
            }
        }
    }
}
