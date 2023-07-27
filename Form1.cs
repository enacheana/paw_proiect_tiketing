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

namespace paw_proiect_tiketing
{
    public partial class Form1 : Form
    {
        List<Programmer> Programmers = new List<Programmer>();
        public Form1()
        {
            InitializeComponent();
            incarcaDate();
            lvProgrammers.ContextMenuStrip=contextMenuStrip1;
            tvProgrammers.ContextMenuStrip=contextMenuStrip2;
        }

       private void incarcaDate()
        {
            StreamReader sr = new StreamReader("Programmers.txt");
            string linie;
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    string[] linieSplit = linie.Split(',');
                    string nume = linie.Split(',')[0];
                    int nivelExperienta = Convert.ToInt32(linie.Split(',')[1]);
                    int varsta = Convert.ToInt32(linie.Split(',')[2]);
                    string[] limbajeArray = linieSplit[3].Split(';');
                    List<string> limbaje = new List<string> (limbajeArray);
                    Programmer p = new Programmer(nume, nivelExperienta, varsta, limbaje);
                    Programmers.Add(p);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Datele au fost incarcate!");
        }

        private void btnPopulareLV_Click(object sender, EventArgs e)
        {
            foreach (Programmer p in Programmers)
            {

                ListViewItem item = new ListViewItem(p.Nume);
              //  item.SubItems.Add(p.NivelExperienta.ToString());
                if (p.NivelExperienta > 4)
                {
                    item.SubItems.Add("Experimentat");
                }
                else
                {
                    item.SubItems.Add("Intermediar");
                }
                item.SubItems.Add(p.Varsta.ToString());
                item.SubItems.Add(string.Join(";", p.Limbaje));
                lvProgrammers.Items.Add(item);

            }
        }

        private void btnStergereElemLV_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in lvProgrammers.Items)
                if (itm.Checked)
                    itm.Remove();
        }

        private void stergeElementLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in lvProgrammers.Items)
                if (itm.Checked)
                    itm.Remove();
        }


        private void lvProgrammers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach (ListViewItem item in lvProgrammers.CheckedItems)
            {
                e.Item.BackColor = Color.Red;
            }
        }


        private void btnPopulareTV_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Programmers");
            tvProgrammers.Nodes.Add(parinte);

            foreach (Programmer p in Programmers)
            {
                TreeNode copil = new TreeNode(p.Nume);

                TreeNode nepot1 = new TreeNode("Nivel de experienta: " + p.NivelExperienta);
                TreeNode nepot2 = new TreeNode("Varsta: " + p.Varsta);
                TreeNode nepot3 = new TreeNode("Limbaje de programare cunoscute: " + string.Join(";", p.Limbaje));

                copil.Nodes.Add(nepot1);
                copil.Nodes.Add(nepot2);
                copil.Nodes.Add(nepot3);

                parinte.Nodes.Add(copil);
            }
            tvProgrammers.ExpandAll();
        }


        private void tvProgrammers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodSelectat = tvProgrammers.SelectedNode;
            int nivelExperienta;
            try
            {
                nivelExperienta = Convert.ToInt32(nodSelectat.Text.Split('-')[0]);
            }
            catch
            {
                nivelExperienta = 0;
            }
            //foreach (Programmer p in Programmers)
            //{
            //    if (p.NivelExperienta == nivelExperienta)
            //    {
            //        tbProgrammers.Text += p.ToString() + Environment.NewLine;
            //    }
            //}
        }


        private void stergeElementTVToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode nodSelectat = tvProgrammers.SelectedNode;
            if (nodSelectat.NextNode != null)
            {
                nodSelectat = tvProgrammers.SelectedNode.NextNode;
            }
            else
            {
                if (nodSelectat.PrevNode != null)
                {
                    nodSelectat = tvProgrammers.SelectedNode.PrevNode;
                }
            }
            tvProgrammers.SelectedNode.Remove();
            tvProgrammers.SelectedNode = nodSelectat;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Form1 form1 = new Form1();
                Application.Run(form1);
            }
        }

    }
}
