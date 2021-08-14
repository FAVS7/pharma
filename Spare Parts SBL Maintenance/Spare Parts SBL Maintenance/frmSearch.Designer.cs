
namespace Spare_Parts_SBL_Maintenance
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnConsult;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.REPORTES = new System.Windows.Forms.TabControl();
            this.BUSQUEDA = new System.Windows.Forms.TabPage();
            this.txtCritery = new System.Windows.Forms.TextBox();
            this.dgvConsult = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbxImageSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReportPart = new System.Windows.Forms.Button();
            this.txtEndStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateStart = new System.Windows.Forms.TextBox();
            this.txtCriteryPart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            btnConsult = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.REPORTES.SuspendLayout();
            this.BUSQUEDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsult)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(350, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Spare Parts Maintenance ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.REPORTES);
            this.panel3.Location = new System.Drawing.Point(13, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 507);
            this.panel3.TabIndex = 2;
            // 
            // REPORTES
            // 
            this.REPORTES.Controls.Add(this.BUSQUEDA);
            this.REPORTES.Controls.Add(this.tabPage2);
            this.REPORTES.Location = new System.Drawing.Point(5, 12);
            this.REPORTES.Name = "REPORTES";
            this.REPORTES.SelectedIndex = 0;
            this.REPORTES.Size = new System.Drawing.Size(834, 476);
            this.REPORTES.TabIndex = 5;
            // 
            // BUSQUEDA
            // 
            this.BUSQUEDA.Controls.Add(this.txtCritery);
            this.BUSQUEDA.Controls.Add(this.pbxImageSearch);
            this.BUSQUEDA.Controls.Add(this.dgvConsult);
            this.BUSQUEDA.Controls.Add(btnConsult);
            this.BUSQUEDA.Controls.Add(this.label2);
            this.BUSQUEDA.Location = new System.Drawing.Point(4, 22);
            this.BUSQUEDA.Name = "BUSQUEDA";
            this.BUSQUEDA.Padding = new System.Windows.Forms.Padding(3);
            this.BUSQUEDA.Size = new System.Drawing.Size(826, 450);
            this.BUSQUEDA.TabIndex = 0;
            this.BUSQUEDA.Text = "BUSQUEDA";
            this.BUSQUEDA.UseVisualStyleBackColor = true;
            // 
            // txtCritery
            // 
            this.txtCritery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCritery.Location = new System.Drawing.Point(101, 51);
            this.txtCritery.Name = "txtCritery";
            this.txtCritery.Size = new System.Drawing.Size(366, 31);
            this.txtCritery.TabIndex = 2;
            this.txtCritery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvConsult
            // 
            this.dgvConsult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsult.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvConsult.Location = new System.Drawing.Point(3, 213);
            this.dgvConsult.Name = "dgvConsult";
            this.dgvConsult.Size = new System.Drawing.Size(817, 231);
            this.dgvConsult.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Introduzca el criterio de busqueda";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnReportPart);
            this.tabPage2.Controls.Add(this.txtEndStart);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtDateStart);
            this.tabPage2.Controls.Add(this.txtCriteryPart);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "REPORTES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbxImageSearch
            // 
            this.pbxImageSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImageSearch.Location = new System.Drawing.Point(560, 6);
            this.pbxImageSearch.Name = "pbxImageSearch";
            this.pbxImageSearch.Size = new System.Drawing.Size(255, 201);
            this.pbxImageSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImageSearch.TabIndex = 0;
            this.pbxImageSearch.TabStop = false;
            // 
            // btnConsult
            // 
            btnConsult.BackColor = System.Drawing.Color.White;
            btnConsult.BackgroundImage = global::Spare_Parts_SBL_Maintenance.Properties.Resources.search;
            btnConsult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsult.ForeColor = System.Drawing.Color.Transparent;
            btnConsult.Location = new System.Drawing.Point(230, 102);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new System.Drawing.Size(109, 90);
            btnConsult.TabIndex = 4;
            btnConsult.Text = "BUSCAR";
            btnConsult.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            btnConsult.UseVisualStyleBackColor = false;
            btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Spare_Parts_SBL_Maintenance.Properties.Resources.logo_sblpharma;
            this.pictureBox1.Location = new System.Drawing.Point(175, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Introduzca el criterio";
            // 
            // btnReportPart
            // 
            this.btnReportPart.BackColor = System.Drawing.Color.White;
            this.btnReportPart.BackgroundImage = global::Spare_Parts_SBL_Maintenance.Properties.Resources.enter;
            this.btnReportPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportPart.ForeColor = System.Drawing.Color.Transparent;
            this.btnReportPart.Location = new System.Drawing.Point(293, 93);
            this.btnReportPart.Margin = new System.Windows.Forms.Padding(0);
            this.btnReportPart.Name = "btnReportPart";
            this.btnReportPart.Size = new System.Drawing.Size(90, 77);
            this.btnReportPart.TabIndex = 19;
            this.btnReportPart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReportPart.UseVisualStyleBackColor = false;
            // 
            // txtEndStart
            // 
            this.txtEndStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndStart.Location = new System.Drawing.Point(675, 51);
            this.txtEndStart.Name = "txtEndStart";
            this.txtEndStart.Size = new System.Drawing.Size(116, 31);
            this.txtEndStart.TabIndex = 17;
            this.txtEndStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(704, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selecione el criterio";
            // 
            // txtDateStart
            // 
            this.txtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateStart.Location = new System.Drawing.Point(547, 51);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(116, 31);
            this.txtDateStart.TabIndex = 15;
            this.txtDateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCriteryPart
            // 
            this.txtCriteryPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriteryPart.Location = new System.Drawing.Point(290, 53);
            this.txtCriteryPart.Name = "txtCriteryPart";
            this.txtCriteryPart.Size = new System.Drawing.Size(244, 29);
            this.txtCriteryPart.TabIndex = 13;
            this.txtCriteryPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Inicio";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::Spare_Parts_SBL_Maintenance.Properties.Resources.excel;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(442, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 77);
            this.button2.TabIndex = 19;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(4, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(817, 266);
            this.dataGridView1.TabIndex = 22;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(877, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.REPORTES.ResumeLayout(false);
            this.BUSQUEDA.ResumeLayout(false);
            this.BUSQUEDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsult)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCritery;
        private System.Windows.Forms.DataGridView dgvConsult;
        private System.Windows.Forms.PictureBox pbxImageSearch;
        private System.Windows.Forms.TabControl REPORTES;
        private System.Windows.Forms.TabPage BUSQUEDA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReportPart;
        private System.Windows.Forms.TextBox txtEndStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDateStart;
        private System.Windows.Forms.TextBox txtCriteryPart;
        private System.Windows.Forms.Label label6;
    }
}