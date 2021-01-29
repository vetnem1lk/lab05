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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kodVid;
        int kodOrg;
        int kodSos;
        private void buttonVidLic_Click(object sender, EventArgs e)
        {
            NameVid vName = new NameVid();
            if (vName.ShowDialog() != DialogResult.OK)
            {
                textBoxVidLic.Text = "";
                return;
            }
            else
            {
                kodVid = vName.vidKod;
                textBoxVidLic.Text = vName.vidName;
            }
        }
        string sql;
        private void Form1_Load(object sender, EventArgs e)
        {
            sql = @"SELECT        SostLic.slName, LicOrg.loName, VidLic.vlName, UL.Orgn, UL.Inn, Licenz.NumLic, Licenz.DtResh, Licenz.DtStart, Licenz.DtEnd, Licenz.DtStop, Licenz.DtStartNow, Licenz.MainLic, UL.IdUl
                     FROM            UL INNER JOIN
                         Licenz ON UL.IdUl = Licenz.idUl INNER JOIN
                         LicOrg ON Licenz.LicOrg = LicOrg.IdLicOrg INNER JOIN
                         VidLic ON Licenz.VidLic = VidLic.IdVidLic INNER JOIN
                         SostLic ON Licenz.SostLic = SostLic.IdSostLic";

        }

        private bool isCipher(string s)
        {
            for ( int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                    return false;
            }
            return true;
        }
        private string testOgrn(string s)
        {
            if (s.Length != 13)
                return "Длина ОГРН не равно 13";
            if (!isCipher(s))
                return "В коде ОГРН не цифровая информация";
            return "";
        }
        private string testInn(string s)
        {
            if (s.Length != 10)
                return "Длина ИНн не равно 10";
            if (!isCipher(s))
                return "В коде Инн нецифровая информация";
            return "";
        }
        private string testNumLic(string s)
        {
            if (s.Length > 0)
                return "из-за возможности сломать таблицу ищите данные другим способом!\nРеализацую функции ждите в новой версии!";
            return "";
        }
        
        
        private void buttonReady_Click(object sender, EventArgs e)
        {
            string f = "";
            string mesOgrn = "", mesInn = "", mesNumLic = "";
            if (textBoxOgrn.Text != "")
            {
                mesOgrn = testOgrn(textBoxOgrn.Text);
                if (mesOgrn != "")
                    MessageBox.Show(mesOgrn);
                else
                    f += "(UL.Orgn = '" + textBoxOgrn.Text + "') AND ";
            }
            if (textBoxInn.Text != "")
            {
                mesInn = testInn(textBoxInn.Text);
                if (mesInn != "")
                    MessageBox.Show(mesInn);
                else 
                    f += "(UL.Inn = '" + textBoxInn.Text + "') AND ";
            }
            if (textBoxNumLic.Text != "")
            {
                mesNumLic = testNumLic(textBoxNumLic.Text);
                if (mesNumLic != "")
                    MessageBox.Show(mesNumLic);
            }
            if (textBoxLicOrg.Text != "")
                f += "(Licenz.LicOrg = '" + kodOrg + "') AND ";
            if (textBoxVidLic.Text != "")
                f += "(Licenz.VidLic = '" + kodVid + "') AND ";
            if (textBoxSostLic.Text != "")
                f += "(Licenz.SostLic = '" + kodSos + "') AND ";
            if (f != "")
                f = "\nWHERE " + f.Remove(f.Length - 5);
            BindingSource bs = new BindingSource();
            if ((mesOgrn + mesInn).Length != 0)
                bs = null;
            else
            {
                sqlCommand1.CommandText = sql + f;
                sqlConnection1.Open();
                SqlDataReader dr = sqlCommand1.ExecuteReader();
                if (dr.HasRows)
                    bs.DataSource = dr;
                dataGridView1.DataSource = bs;
                dataGridView1.AutoGenerateColumns = false;
                dr.Close();
                sqlConnection1.Close();
            }
        }

        private void buttonLicOrg_Click(object sender, EventArgs e)
        {
            NameOrg oName = new NameOrg();
            if (oName.ShowDialog() != DialogResult.OK)
            {
                textBoxLicOrg.Text = "";
                return;
            }
            else
            {
                kodOrg = oName.orgKod;
                textBoxLicOrg.Text = oName.orgName;
            }
        }

        private void buttonSostLic_Click(object sender, EventArgs e)
        {
            NameSost sName = new NameSost();
            if (sName.ShowDialog() != DialogResult.OK)
            {
                textBoxSostLic.Text = "";
                return;
            }
            else
            {
                kodSos = sName.sostKod;
                textBoxSostLic.Text = sName.sostName;
            }
        }
    }
}
