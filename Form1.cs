using Blue_Ribbon_Finalists.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blue_Ribbon_Finalists
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // create array for 6 ribbon objects
        Entry[] ribbons = new Entry[6];
        int currentIndex = 0;
        int maxIndex = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            string exePath = System.IO.Path.GetDirectoryName( System.Reflection.Assembly.GetEntryAssembly().Location);
            ribbons[0] = new Entry("Chopped Steak", "IL", "Burger", "3 hours", Image.FromFile("0.jpg"));
            ribbons[1] = new Entry("Chicken Wings", "TX", "Chicken", "1 hour", Image.FromFile("1.jpg"));
            ribbons[2] = new Entry("Wheat Break", "CA", "Bread", "3 hours", Image.FromFile("2.jpg"));
            ribbons[3] = new Entry("Rainbow Salad", "WA", "Salad", "1 hours", Image.FromFile("3.jpg"));
            ribbons[4] = new Entry("LEMON HERBED CHICKEN", "WI", "Chicken", "2 hours", Image.FromFile("4.jpg"));
            ribbons[5] = new Entry("French Toast Sticks", "FL", "French Fries", "3 hours", Image.FromFile("5.jpg"));

            lblNumberOfEntriesValue.Text = ribbons.Count().ToString();
            maxIndex = ribbons.Count() - 1;
            updateControls();
        }

        private void updateControls()
        {
            lblEntryNameValue.Text = ribbons[currentIndex].EntryName;
            lblStateValue.Text = ribbons[currentIndex].State;
            lblCategoryValue.Text = ribbons[currentIndex].Category;
            lblPreperationTimeValue.Text = ribbons[currentIndex].PrepTime;
            picRibbon.Image = ribbons[currentIndex].Photo;
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            if (currentIndex == 0)
            {
                currentIndex = maxIndex;
            } else
            {
                currentIndex--;

            }
            updateControls();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex == maxIndex)
            {
                currentIndex = 0;
            } else
            {
                currentIndex++;
            }
            updateControls();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var formAbout = new Form2();
            formAbout.Show();
        }
    }
}
