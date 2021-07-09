using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47_AT_YARIŞI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int birincisolauzaklık, ikincisolauzaklık, ucuncusolauzaklık, dorduncusolauzaklık, besincisolauzaklık;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Left = 0; // ilkat
            pictureBox2.Left = 0;//ikinciat
            pictureBox3.Left = 0;//üçüncüat
            pictureBox4.Left = 0;
            pictureBox5.Left = 0;
            label1.Text = ""; //mesaj yazısı
            label2.Text = "0";// zaman
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
            panel6.BackColor = Color.Black;
        }

        Random rastgele = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label2.Text);
            derece++;
            label2.Text = derece.ToString();
            int biratgenislik = pictureBox1.Width;
            int ikiatgenislik = pictureBox2.Width;
            int ucatgenislik = pictureBox2.Width;
            int dortatgenislik = pictureBox2.Width;
            int besatgenislik = pictureBox2.Width;
            int bitisuzaklık1 = panel2.Left;
            int bitisuzaklık2 = panel3.Left;
            int bitisuzaklık3 = panel4.Left;
            int bitisuzaklık4 = panel5.Left;
            int bitisuzaklık5 = panel6.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(5, 15);
            pictureBox5.Left = pictureBox5.Left + rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5 && pictureBox1.Left > pictureBox4.Left + 5 && pictureBox1.Left > pictureBox5.Left + 5)
            {
                label1.Text = "         *****  1. AT YARIŞI ÖNDE GÖTÜRÜYOR  *****";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5 && pictureBox2.Left > pictureBox4.Left + 5 && pictureBox2.Left > pictureBox5.Left + 5)
            {
                label1.Text = "         *****  2. AT YARIŞI ÖNDE GÖTÜRÜYOR  *****";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox4.Left + 5 && pictureBox3.Left > pictureBox5.Left + 5)
            {
                label1.Text = "         *****  3. AT YARIŞI ÖNDE GÖTÜRÜYOR  *****";
            }
            if (pictureBox4.Left > pictureBox1.Left + 5 && pictureBox4.Left > pictureBox2.Left + 5 && pictureBox4.Left > pictureBox3.Left + 5 && pictureBox4.Left > pictureBox5.Left + 5)
            {
                label1.Text = "         *****  4. AT YARIŞI ÖNDE GÖTÜRÜYOR  *****";
            }
            if (pictureBox5.Left > pictureBox1.Left + 5 && pictureBox5.Left > pictureBox2.Left + 5 && pictureBox5.Left > pictureBox3.Left + 5 && pictureBox5.Left > pictureBox4.Left + 5)
            {
                label1.Text = "         *****  5. AT YARIŞI ÖNDE GÖTÜRÜYOR  *****";
            }
            if (biratgenislik + pictureBox1.Left >= bitisuzaklık1)
            {
                timer1.Enabled = false;
                label1.Text = ("              >>>>>>> 1. AT KAZANDI <<<<<<<");
                panel2.BackColor = Color.White;
            }
            if (ikiatgenislik + pictureBox2.Left >= bitisuzaklık2)
            {
                timer1.Enabled = false;
                label1.Text = ("              >>>>>>> 2. AT KAZANDI <<<<<<<");
                panel3.BackColor = Color.White;
            }
            if (ucatgenislik + pictureBox3.Left >= bitisuzaklık3)
            {
                timer1.Enabled = false;
                label1.Text = ("              >>>>>>> 3. AT KAZANDI <<<<<<<");
                panel4.BackColor = Color.White;
            }
            if (dortatgenislik + pictureBox4.Left >= bitisuzaklık4)
            {
                timer1.Enabled = false;
                label1.Text = ("              >>>>>>> 4. AT KAZANDI <<<<<<<");
                panel5.BackColor = Color.White;
            }
            if (besatgenislik + pictureBox5.Left >= bitisuzaklık5)
            {
                timer1.Enabled = false;
                label1.Text = ("              >>>>>>> 5. AT KAZANDI <<<<<<<");
                panel6.BackColor = Color.White;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            birincisolauzaklık = pictureBox1.Left;
            ikincisolauzaklık = pictureBox2.Left;
            ucuncusolauzaklık = pictureBox3.Left;
            dorduncusolauzaklık = pictureBox4.Left;
            besincisolauzaklık = pictureBox5.Left;
        }
    }
}
