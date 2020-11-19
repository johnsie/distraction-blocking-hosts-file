using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distraction_blocking_hosts_file
{
    public partial class Form1 : Form
    {

        String file_name = "..\\..\\..\\new_hosts_file.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists(file_name))
            {

            }
            else
            {
                using (StreamWriter sw = File.CreateText(file_name))
                {
                 
                }
            }


            string[] lines = System.IO.File.ReadAllLines(file_name);

           lstBlockedSites.Items.AddRange(lines);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = File.AppendText(file_name))
            {
                sw.WriteLine("127.0.0.1 "+ txtURL.Text );
            }

            lstBlockedSites.Items.Add("127.0.0.1 " + txtURL.Text);

            }//end void

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstBlockedSites.Items.RemoveAt(lstBlockedSites.SelectedIndex);


            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(file_name);
            foreach (var item in lstBlockedSites.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(file_name);
        }
    }
}
