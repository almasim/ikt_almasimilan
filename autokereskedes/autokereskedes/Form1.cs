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

namespace autokereskedes
{
    public partial class Form1 : Form
    {
        List<Cars> clist = new List<Cars>();
        class Cars
        {

            public string marka;
            public string tipus;
            public string ev;
            public string szin;
            public string rendszam;


            public Cars(string sor)
            {
                string[] s = sor.Split(';');
                marka = s[0];
                tipus = s[1];
                ev = s[2];
                szin = s[3];
                rendszam= s[4];
            }
        }
        public Form1()
        {
            InitializeComponent();

        }
        string filename = "";
        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                listBox1.Items.Clear();
                op.ShowDialog();
                filename = op.FileName;
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    clist.Add(new Cars(sr.ReadLine()));

                }
                foreach (var item in File.ReadAllLines(filename))
                {
                    listBox1.Items.Add(item);
                }
                sr.Close();
            }
            catch (Exception i)
            {

                MessageBox.Show(i.ToString());
            }

        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (filename != "")
                {
                    StreamWriter sw = new StreamWriter(filename);
                    foreach (var item in listBox1.Items)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nincs más elmentve");
                throw;
            }
        }

        private void újLétrehozásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count != 0)
                {
                    SaveFileDialog s = new SaveFileDialog();
                    s.ShowDialog();
                    filename = s.FileName;

                    StreamWriter sw = new StreamWriter(filename);
                    foreach (var item in listBox1.Items)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count==0)
                {
                    listBox1.Items.Add(txtMárka.Text + ";" + txtTipus.Text + ";" + txtÉv.Text + ";" + txtSzin.Text + "; " + txtRendszam.Text);
                    clist.Add(new Cars(txtMárka.Text + ";" + txtTipus.Text + ";" + txtÉv.Text + ";" + txtSzin.Text + "; " + txtRendszam.Text));
                }
                else
                {
                    
                    for (int i = 0; i < clist.Count; i++)
                    {
                        if (clist[i].rendszam==txtRendszam.Text)
                        {
                            MessageBox.Show("Vanmárilyen");
                            break;
                        }
                        else
                        {
                            listBox1.Items.Add(txtMárka.Text + ";" + txtTipus.Text + ";" + txtÉv.Text + ";" + txtSzin.Text + "; " + txtRendszam.Text);
                            clist.Add(new Cars(txtMárka.Text + ";" + txtTipus.Text + ";" + txtÉv.Text + ";" + txtSzin.Text + "; " + txtRendszam.Text));
                            break;
                        }
                    }
                }
            }
            catch (Exception q)
            {
                MessageBox.Show(q.ToString());
                
            }
        }

        private void névjegyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Almási Milán.");
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < clist.Count; i++)
            {
                clist[listBox1.SelectedIndex].marka = txtMárka.Text;
                clist[listBox1.SelectedIndex].rendszam = txtRendszam.Text;
                clist[listBox1.SelectedIndex].szin = txtSzin.Text;
                clist[listBox1.SelectedIndex].tipus = txtTipus.Text; 
                clist[listBox1.SelectedIndex].ev = txtÉv.Text; 
            }
            listBox1.Items.Clear();
            foreach (var item in clist)
            {
                listBox1.Items.Add(item.marka + ";" + item.tipus + ";" + item.ev + ";" + item.szin + ";" + item.rendszam);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            clist.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Clear();
            foreach (var item in clist)
            {
                listBox1.Items.Add(item.marka+";"+item.tipus+";"+item.ev+";"+item.szin+";"+item.rendszam);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < clist.Count; i++)
            {
                txtMárka.Text = clist[listBox1.SelectedIndex].marka;
                txtRendszam.Text = clist[listBox1.SelectedIndex].rendszam;
                txtSzin.Text = clist[listBox1.SelectedIndex].szin;
                txtTipus.Text = clist[listBox1.SelectedIndex].tipus;
                txtÉv.Text = clist[listBox1.SelectedIndex].ev;
            }
        }
    }
}
