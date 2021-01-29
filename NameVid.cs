using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SearchEGRUL_v2
{
    public partial class NameVid : Form
    {
        public NameVid()
        {
            InitializeComponent();
        }
        protected internal string vidName;
        protected internal int vidKod;
        BindingSource bs;
        private void NameVid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klimentevDataSet.VidLic". При необходимости она может быть перемещена или удалена.
            sqlConnection1.Open();
            SqlDataReader dr = sqlCommand1.ExecuteReader(); 
            if (!dr.HasRows)
                return;
            bs = new BindingSource
            {
                DataSource = dr
            };
            dr.Close();
            sqlConnection1.Close();
            dataGridView1.DataSource = bs;
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                vidKod = (int)dataGridView1[0, bs.Position].Value;
                vidName = (string)dataGridView1[1, bs.Position].Value;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Невозможно определить текущую строку справочника");
        }

        

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonReady.PerformClick();
        }
    }
}
