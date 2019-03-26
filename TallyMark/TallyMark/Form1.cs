using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallyMark
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            numberLabel.Text = $"{count}";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            count += 1;
            numberLabel.Text = $"{count}";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count -= 1;
                numberLabel.Text = $"{count}";
            }
            
        }
    }
}
