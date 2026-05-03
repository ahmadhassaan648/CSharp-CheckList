using System.Data.SqlTypes;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CheckList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedbooks = "";

            if (chcsharp.Checked) { selectedbooks += "C# Programming Basics \n"; }

            if (chjava.Checked) { selectedbooks += "Java Programming \n"; }

            if (chpyt.Checked) { selectedbooks += "Python For Beginners \n"; }

            if (chdsa.Checked) { selectedbooks += "Data Structure And Algorithms \n"; }

            if (chdbms.Checked) { selectedbooks += "Database Management System (SQL) \n"; }

            if (choop.Checked) { selectedbooks += "Object Oriented Programming \n"; }

            if (chweb.Checked) { selectedbooks += "Web Development (HTML, CSS, JS) \n"; }

            if (chcpp.Checked) { selectedbooks += "C++ Programming Fundamentals \n"; }


            if (selectedbooks != "")
            {
                MessageBox.Show("Your selected books are the following:\n\n" + selectedbooks);
            }
            else
            {
                MessageBox.Show("No book selected");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldatetime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }
    }
}
