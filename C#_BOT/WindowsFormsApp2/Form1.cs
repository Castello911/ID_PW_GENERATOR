using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            string[] items = { "1", "2", "3" };

            var query = from i1 in items
                        from i2 in items
                        from i3 in items

                        select i1 + i2 + i3;


            foreach (var result in query) 
            {
                listBox1.Text = (Convert.ToString(result));
            }
                
        }

 
    }
}
