using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchEGRUL_v2
{
    public partial class NameOrg : Form
    {
        public NameOrg()
        {
            InitializeComponent();
        }
        protected internal string orgName;
        protected internal int orgKod;
        BindingSource bs;
        private void NameOrg_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlDataReader dr = sqlCommand1.ExecuteReader();
            if (!dr.HasRows)
                return;
            bs = new BindingSource
            {
                DataSource = dr
            };
            dataGridView1.DataSource = bs;
            dr.Close();
            sqlConnection1.Close();
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                orgKod = (int)dataGridView1[0, bs.Position].Value;
                orgName = (string)dataGridView1[1, bs.Position].Value;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Невозможно определить текущую строку справочника");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            buttonReady.PerformClick();
        }
    }
}
