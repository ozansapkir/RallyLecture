using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Alimentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.Click += new EventHandler(comboBox1_Click);
        }


        void comboBox1_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.comboBox1.Text = this.folderBrowserDialog1.SelectedPath;
            if (comboBox1.Text != "")
            {
                DirectoryInfo direction = new DirectoryInfo(@comboBox1.Text);
                FileInfo[] fichier = direction.GetFiles("*.csv");

                foreach (FileInfo f in fichier)
                {
                    clb1.Items.Add(f);
                }
            }
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

            //cbListNiveau.Items.Add();
        }



        private void cbListNiveau_Click(object sender, EventArgs e)
        {
            cbListNiveau.Items.Clear();

            List<Niveau> LesNiveau = new List<Niveau>();
            TableNiveau SelectNiveau = new TableNiveau();

            LesNiveau = SelectNiveau.lesNiveaux();

            foreach (Niveau UnNiveau in LesNiveau)
            {
                this.cbListNiveau.Items.Add(UnNiveau.NiveauScolaire);
            }

        }
    }
}
