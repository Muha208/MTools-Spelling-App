using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpellingMethod;

namespace SpellingApp
{
    public partial class SpellingToolForm : Form
    {
        public SpellingToolForm()
        {
            InitializeComponent();
        }
        private static string GetTheString(ComboBox comboBox, CheckBox checkBox, TextBox textBox)
        {
            string TextInput, TextFromCB, TextFromChech, TextFromTextBox;
            TextFromCB = comboBox.Text;
            TextFromTextBox = textBox.Text;
            TextFromChech = "";
            TextInput = "";
            if (TextFromTextBox != "")
            {
                if (checkBox.Checked)
                {
                    TextFromChech = checkBox.Text;
                }
                if (int.TryParse(TextFromTextBox, out int SpellingNumber))
                {
                    TextInput = Methods.SpellingNumber(SpellingNumber).ToString();
                }
                return (TextInput + " " + TextFromCB + " " + TextFromChech);
            }

            return (TextInput + " " + TextFromCB + " " + TextFromChech);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSpelling_Click(object sender, EventArgs e)
        {

        }

        private void SpellingToolForm_Load(object sender, EventArgs e)
        {
            #region Fill ComboBox By Curancy
            cbCurancy.Items.Add("");
            cbCurancy.Items.Add("جنيه مصري");
            cbCurancy.Items.Add("دولار أمريكي");
            cbCurancy.Items.Add("ريال سعودي");
            cbCurancy.Items.Add("دينار كويتي");
            cbCurancy.SelectedIndex = 0;
            #endregion

        }
        private void tbInputNumber_TextChanged(object sender, EventArgs e)
        {
            rtbResultText.Text = GetTheString(cbCurancy, cbOnly, tbInputNumber);
        }

        private void cbCurancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbResultText.Text = GetTheString(cbCurancy, cbOnly, tbInputNumber);
        }

        private void cbOnly_CheckedChanged(object sender, EventArgs e)
        {
            rtbResultText.Text = GetTheString(cbCurancy, cbOnly, tbInputNumber);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string UriMtool = @"https://github.com/Muha208/MTools_Spelling_App.git";
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = UriMtool;
            process.Start();
        }
    }
}
