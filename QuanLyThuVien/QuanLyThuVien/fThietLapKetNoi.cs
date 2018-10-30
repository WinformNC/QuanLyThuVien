using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class fThietLapKetNoi : Form
    {
        public fThietLapKetNoi()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtUserName.Enabled = txtPass.Enabled = false;
            }
            else
            {
                txtUserName.Enabled = txtPass.Enabled = true;
            }
        }

        private void cboDatabase_Enter(object sender, EventArgs e)
        {
            cboDatabase.Items.Clear();
            if (!txtUserName.Enabled)
            {
                using (SqlConnection con = new SqlConnection("Data Source=" + cboServerName.Text + "; Integrated Security=true;"))
                {
                    con.Open();
                    DataTable databases = con.GetSchema("Databases");
                    if (databases != null)
                    {
                        foreach (DataRow database in databases.Rows)
                        {
                            String databaseName = database.Field<String>("database_name");
                            short dbID = database.Field<short>("dbid");
                            cboDatabase.Items.Add(databaseName);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=" + cboServerName.Text + "; User ID=" + txtUserName.Text + "; password=" + txtPass.Text + ";"))
                    {
                        con.Open();
                        DataTable databases = con.GetSchema("Databases");
                        if (databases != null)
                        {
                            foreach (DataRow database in databases.Rows)
                            {
                                String databaseName = database.Field<String>("database_name");
                                short dbID = database.Field<short>("dbid");
                                cboDatabase.Items.Add(databaseName);
                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void cboServerName_Click(object sender, EventArgs e)
        {
            if (cboServerName.Items.Count == 0)
            {
                string myServer = Environment.MachineName;
                DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();

                for (int i = 0; i < servers.Rows.Count; i++)
                {
                    if (myServer == servers.Rows[i]["ServerName"].ToString())
                    {
                        cboServerName.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);

                    }
                    else
                    {
                        cboServerName.Items.Add(servers.Rows[i]["ServerName"]);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string s = "Data Source=" + cboServerName.Text + "; Initial Catalog=" + cboDatabase.Text;
            if (checkBox1.Checked)
            {
                s += "; Integrated Security=true;";
            }
            else
            {
                s += "; User ID=" + txtUserName.Text + "; password=" + txtPass.Text + ";";
            }

            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["cn"].ConnectionString = s;
            configuration.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
            Properties.Settings.Default.connectionString = s;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
