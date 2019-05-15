using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wintellect.PowerCollections;

namespace Translator
{
    
    public partial class Form1 : Form
    {
        public AddWord frm = new AddWord();

        public static List<KeyValuePair<string,string>> wordlist = new List<KeyValuePair<string,string>>(); 
        public static MultiDictionary<string, string> words = new MultiDictionary<string, string>(true);

        public string file;
        public static int selection;

        public Form1()
        {
            InitializeComponent();
            
            InitializeComboBoxes();
            //addWordWindow.Visible = false;
        }

        public string LookUpWord(string word, string langA, string langB)
        {
            string output;
            CheckIfFilesExists(langA, langB);

            PopulateWordList();

            if (words.ContainsKey(word))
            {
                output = words[word].ToString().Trim('{','}');
                Console.WriteLine(output);

                return output;
            }
            else
            {
                output = "no such word";
                return output;
            }
            
        }

        private void PopulateWordList()
        {
            Console.WriteLine("reading words from file");
            StreamReader sr = new StreamReader(file);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] arr = line.Split(',');
                if (selection == 0)
                {
                    words.Add(arr[0], arr[1]);
                }
                else
                {
                    words.Add(arr[1], arr[0]);
                }
            }
            foreach(var i in words)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Done Populating Word List");

        }

        private void CheckIfFilesExists(string langA, string langB)
        {
            file = langA + langB + ".dat";
            selection = 1;

            Console.WriteLine("Checking Files");
            if (!File.Exists(file))
            {
                Console.WriteLine("{0} does not exist, trying next permiantation", file);
                file = langB + langA + ".dat";
                selection = 0;
            }
            if (!File.Exists(file))
            {
                MessageBox.Show("There is no file for the selected languages", "No file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            words.Clear();
            langTwo_TB.Clear();
            langTwo_TB.Text = LookUpWord(langOne_TB.Text.ToLower(), langOne_CB.Text, langTwo_CB.Text);

        }

        private void InitializeComboBoxes()
        {
            foreach (string i in Languages.language)
            {
                langOne_CB.Items.Add(i);
                langTwo_CB.Items.Add(i);
            }
            langOne_CB.SelectedIndex = 0;
            langTwo_CB.SelectedIndex = 1;
        }

        private void Swap_BTN_Click(object sender, EventArgs e)
        {
            int temp;
            temp = langOne_CB.SelectedIndex;
            langOne_CB.SelectedIndex = langTwo_CB.SelectedIndex;
            langTwo_CB.SelectedIndex = temp;
            
        }

        private void AddNewWord_BTN_Click(object sender, EventArgs e)
        {

            frm.Show();
            frm.langOneAdd_CB.SelectedIndex = langOne_CB.SelectedIndex;
            frm.langTwoAdd_CB.SelectedIndex = langTwo_CB.SelectedIndex;
        }
    }
}
