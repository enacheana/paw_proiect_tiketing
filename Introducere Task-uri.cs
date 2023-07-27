using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paw_proiect_tiketing
{
    public partial class Introducere_Task_uri : Form
    {
        string connString;
        public Introducere_Task_uri()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Task.accdb";
        }
        private void LoadTasksFromDatabase()
        {
            listView1.Items.Clear();

            using (OleDbConnection conexiune = new OleDbConnection(connString))
            {
                try
                {
                    conexiune.Open();
                    string selectQuery = "SELECT * FROM Task";
                    OleDbCommand comanda = new OleDbCommand(selectQuery, conexiune);
                    OleDbDataReader reader = comanda.ExecuteReader();

                    while (reader.Read())
                    {
                        string numeTask = reader["Task_Denumire"].ToString();
                        string dataLimita = reader["Data"].ToString();
                        string taskComplet = reader["EsteComplet"].ToString();

                        ListViewItem item = new ListViewItem(numeTask);
                      //  item.SubItems.Add(numeTask);
                        item.SubItems.Add(dataLimita);
                        item.SubItems.Add(taskComplet);

                        listView1.Items.Add(item);
                    }

                    reader.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdaugaTask_Click(object sender, EventArgs e)
        {
            string numeTask = tbNumeTask.Text;
            string dataLimita = tbData.Text;
            string taskComplet = tbComplet.Text;

            if (string.IsNullOrWhiteSpace(numeTask))
            {
                errorProvider1.SetError(tbNumeTask, "Introduceți numele task-ului.");
                return;
            }

            errorProvider1.SetError(tbNumeTask, "");

            OleDbConnection conexiune = new OleDbConnection(connString);

            try
            {
                conexiune.Open();

                string inserare = "INSERT INTO Task (Task_Denumire, Data, EsteComplet) VALUES (@NumeTask, @Data, @EsteComplet)";

                OleDbCommand comanda = new OleDbCommand(inserare, conexiune);
                comanda.Parameters.AddWithValue("@NumeTask", numeTask);
                comanda.Parameters.AddWithValue("@Data", dataLimita);
                comanda.Parameters.AddWithValue("@EsteComplet", taskComplet);

                int randuriAfectede = comanda.ExecuteNonQuery();
                if (randuriAfectede > 0)
                {
                    MessageBox.Show("Task-ul a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTasksFromDatabase();
                }
                else
                {
                    MessageBox.Show("Nu s-a putut adăuga task-ul.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private string GetSelectedTaskName()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string numeTask = selectedItem.SubItems[0].Text;
                return numeTask;
            }
            return null;
        }



        private void btnStergere_Click(object sender, EventArgs e)

        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vă rugăm să selectați un task înainte de a încerca ștergerea.", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Sigur doriți să ștergeți task-ul?", "Confirmare ștergere", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                string taskName = GetSelectedTaskName();

                using (OleDbConnection conexiune = new OleDbConnection(connString))
                {
                    try
                    {
                        conexiune.Open();
                        string stergere = "DELETE FROM Task WHERE NumeTask = @TaskNume";
                        OleDbCommand comanda = new OleDbCommand(stergere, conexiune);
                        comanda.Parameters.AddWithValue("@TaskNume", taskName);

                        int randuriAfectede = comanda.ExecuteNonQuery();
                        if (randuriAfectede > 0)
                        {
                            MessageBox.Show("Task-ul a fost șters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTasksFromDatabase();
                        }
                        else
                        {
                            MessageBox.Show("Nu s-a putut șterge task-ul.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Utilizatorul a ales să nu șteargă task-ul!");
            }
        }
        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Introducere_Task_uri introducereTaskuri = new Introducere_Task_uri();
                Application.Run(introducereTaskuri);
            }

        }
    }

}

