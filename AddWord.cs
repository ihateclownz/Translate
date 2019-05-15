using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void AddWord_BTN_Click(object sender, EventArgs e)
        {
            if (Form1.words.ContainsKey(langOneAdd_TB.Text) || Form1.words.ContainsKey(langTwoAdd_TB.Text)) {
                MessageBox.Show("Word list already contains "+ langOneAdd_TB.Text + "./n With the value of: " + Form1.words[langOneAdd_TB.Text], "No file", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                Console.WriteLine("WTF");
            }
            Console.WriteLine(Form1.words.ContainsKey(langOneAdd_TB.Text));
            //if(langOneAdd_CB.SelectedIndex == 0)
            //{

            //}
        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            langOneAdd_TB.Text = "";
            langTwoAdd_TB.Text = "";
            this.Visible = false;
        }

        private void InitializeComboBox()
        {
            foreach (string i in Languages.language)
            {
                langOneAdd_CB.Items.Add(i);
                langTwoAdd_CB.Items.Add(i);
            }

        }

    }
}
