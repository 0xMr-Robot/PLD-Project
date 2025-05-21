using com.calitha.goldparser;
using System.Windows.Forms;

namespace Gold_parser3
{
    public partial class Form1 : Form
    {
        MyParser p;
        public Form1()
        {
            InitializeComponent();
            p = new MyParser("Lang_Like_Python.cgt", Syntac, lexical);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Syntac.Items.Clear();
            lexical.Items.Clear();
            p.Parse(textBox1.Text);
        }
    }
}
