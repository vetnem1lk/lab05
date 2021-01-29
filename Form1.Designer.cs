namespace SearchEGRUL_v2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxOgrn = new System.Windows.Forms.TextBox();
            this.textBoxInn = new System.Windows.Forms.TextBox();
            this.textBoxNumLic = new System.Windows.Forms.TextBox();
            this.textBoxLicOrg = new System.Windows.Forms.TextBox();
            this.textBoxVidLic = new System.Windows.Forms.TextBox();
            this.textBoxSostLic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLicOrg = new System.Windows.Forms.Button();
            this.buttonVidLic = new System.Windows.Forms.Button();
            this.buttonSostLic = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonReady = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOgrn
            // 
            this.textBoxOgrn.Location = new System.Drawing.Point(12, 38);
            this.textBoxOgrn.Name = "textBoxOgrn";
            this.textBoxOgrn.Size = new System.Drawing.Size(162, 20);
            this.textBoxOgrn.TabIndex = 0;
            // 
            // textBoxInn
            // 
            this.textBoxInn.Location = new System.Drawing.Point(12, 98);
            this.textBoxInn.Name = "textBoxInn";
            this.textBoxInn.Size = new System.Drawing.Size(162, 20);
            this.textBoxInn.TabIndex = 1;
            // 
            // textBoxNumLic
            // 
            this.textBoxNumLic.Location = new System.Drawing.Point(12, 155);
            this.textBoxNumLic.Name = "textBoxNumLic";
            this.textBoxNumLic.Size = new System.Drawing.Size(162, 20);
            this.textBoxNumLic.TabIndex = 2;
            // 
            // textBoxLicOrg
            // 
            this.textBoxLicOrg.Location = new System.Drawing.Point(12, 208);
            this.textBoxLicOrg.Name = "textBoxLicOrg";
            this.textBoxLicOrg.ReadOnly = true;
            this.textBoxLicOrg.Size = new System.Drawing.Size(162, 20);
            this.textBoxLicOrg.TabIndex = 4;
            // 
            // textBoxVidLic
            // 
            this.textBoxVidLic.Location = new System.Drawing.Point(12, 265);
            this.textBoxVidLic.Name = "textBoxVidLic";
            this.textBoxVidLic.ReadOnly = true;
            this.textBoxVidLic.Size = new System.Drawing.Size(162, 20);
            this.textBoxVidLic.TabIndex = 5;
            // 
            // textBoxSostLic
            // 
            this.textBoxSostLic.Location = new System.Drawing.Point(12, 324);
            this.textBoxSostLic.Name = "textBoxSostLic";
            this.textBoxSostLic.ReadOnly = true;
            this.textBoxSostLic.Size = new System.Drawing.Size(162, 20);
            this.textBoxSostLic.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ОГРН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ИНН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер лицензии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Наименование лицензирующего органа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Наименование вида деятельности";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Наименование состояния лицензии";
            // 
            // buttonLicOrg
            // 
            this.buttonLicOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLicOrg.Location = new System.Drawing.Point(180, 208);
            this.buttonLicOrg.Name = "buttonLicOrg";
            this.buttonLicOrg.Size = new System.Drawing.Size(40, 20);
            this.buttonLicOrg.TabIndex = 13;
            this.buttonLicOrg.Text = "...";
            this.buttonLicOrg.UseVisualStyleBackColor = true;
            this.buttonLicOrg.Click += new System.EventHandler(this.buttonLicOrg_Click);
            // 
            // buttonVidLic
            // 
            this.buttonVidLic.Location = new System.Drawing.Point(180, 265);
            this.buttonVidLic.Name = "buttonVidLic";
            this.buttonVidLic.Size = new System.Drawing.Size(39, 20);
            this.buttonVidLic.TabIndex = 14;
            this.buttonVidLic.Text = "...";
            this.buttonVidLic.UseVisualStyleBackColor = true;
            this.buttonVidLic.Click += new System.EventHandler(this.buttonVidLic_Click);
            // 
            // buttonSostLic
            // 
            this.buttonSostLic.Location = new System.Drawing.Point(180, 324);
            this.buttonSostLic.Name = "buttonSostLic";
            this.buttonSostLic.Size = new System.Drawing.Size(40, 20);
            this.buttonSostLic.TabIndex = 15;
            this.buttonSostLic.Text = "...";
            this.buttonSostLic.UseVisualStyleBackColor = true;
            this.buttonSostLic.Click += new System.EventHandler(this.buttonSostLic_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 322);
            this.dataGridView1.TabIndex = 16;
            // 
            // buttonReady
            // 
            this.buttonReady.Location = new System.Drawing.Point(51, 359);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(79, 27);
            this.buttonReady.TabIndex = 17;
            this.buttonReady.Text = "Ready";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\practicerepos\\EGRUL\\Klimen" +
    "tev.mdf;Integrated Security=True;Replication=True;Connect Timeout=30";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 398);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSostLic);
            this.Controls.Add(this.buttonVidLic);
            this.Controls.Add(this.buttonLicOrg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSostLic);
            this.Controls.Add(this.textBoxVidLic);
            this.Controls.Add(this.textBoxLicOrg);
            this.Controls.Add(this.textBoxNumLic);
            this.Controls.Add(this.textBoxInn);
            this.Controls.Add(this.textBoxOgrn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOgrn;
        private System.Windows.Forms.TextBox textBoxInn;
        private System.Windows.Forms.TextBox textBoxNumLic;
        private System.Windows.Forms.TextBox textBoxLicOrg;
        private System.Windows.Forms.TextBox textBoxVidLic;
        private System.Windows.Forms.TextBox textBoxSostLic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLicOrg;
        private System.Windows.Forms.Button buttonVidLic;
        private System.Windows.Forms.Button buttonSostLic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReady;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}

