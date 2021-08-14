
namespace Spare_Parts_SBL_Maintenance
{
    partial class frmMaterialDischarge
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Paquetes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUSearch = new System.Windows.Forms.Button();
            this.txtUQuantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDUSerial = new System.Windows.Forms.TextBox();
            this.txtDUPart = new System.Windows.Forms.TextBox();
            this.txtDUProduct = new System.Windows.Forms.TextBox();
            this.textDUQuantity = new System.Windows.Forms.TextBox();
            this.pbxImageDischarge = new System.Windows.Forms.PictureBox();
            this.btnSaveDischarge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Paquetes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageDischarge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Spare_Parts_SBL_Maintenance.Properties.Resources.logo_sblpharma;
            this.pictureBox1.Location = new System.Drawing.Point(32, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(152)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(207, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Spare Parts Maintenance ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 58);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Spare_Parts_SBL_Maintenance.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(790, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 11;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Paquetes
            // 
            this.Paquetes.Controls.Add(this.tabPage1);
            this.Paquetes.Location = new System.Drawing.Point(14, 113);
            this.Paquetes.Name = "Paquetes";
            this.Paquetes.SelectedIndex = 0;
            this.Paquetes.Size = new System.Drawing.Size(311, 259);
            this.Paquetes.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUSearch);
            this.tabPage1.Controls.Add(this.txtUQuantity);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDUSerial);
            this.tabPage1.Controls.Add(this.txtDUPart);
            this.tabPage1.Controls.Add(this.txtDUProduct);
            this.tabPage1.Controls.Add(this.textDUQuantity);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(303, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unidades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUSearch
            // 
            this.btnUSearch.BackColor = System.Drawing.Color.White;
            this.btnUSearch.BackgroundImage = global::Spare_Parts_SBL_Maintenance.Properties.Resources.search;
            this.btnUSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnUSearch.Location = new System.Drawing.Point(128, 147);
            this.btnUSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnUSearch.Name = "btnUSearch";
            this.btnUSearch.Size = new System.Drawing.Size(90, 77);
            this.btnUSearch.TabIndex = 8;
            this.btnUSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUSearch.UseVisualStyleBackColor = false;
            // 
            // txtUQuantity
            // 
            this.txtUQuantity.AutoSize = true;
            this.txtUQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUQuantity.Location = new System.Drawing.Point(19, 111);
            this.txtUQuantity.Name = "txtUQuantity";
            this.txtUQuantity.Size = new System.Drawing.Size(62, 16);
            this.txtUQuantity.TabIndex = 7;
            this.txtUQuantity.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "# Parte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Serial";
            // 
            // txtDUSerial
            // 
            this.txtDUSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUSerial.Location = new System.Drawing.Point(104, 8);
            this.txtDUSerial.Name = "txtDUSerial";
            this.txtDUSerial.Size = new System.Drawing.Size(193, 26);
            this.txtDUSerial.TabIndex = 5;
            // 
            // txtDUPart
            // 
            this.txtDUPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUPart.Location = new System.Drawing.Point(104, 40);
            this.txtDUPart.Name = "txtDUPart";
            this.txtDUPart.Size = new System.Drawing.Size(193, 26);
            this.txtDUPart.TabIndex = 4;
            // 
            // txtDUProduct
            // 
            this.txtDUProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUProduct.Location = new System.Drawing.Point(104, 72);
            this.txtDUProduct.Name = "txtDUProduct";
            this.txtDUProduct.Size = new System.Drawing.Size(193, 26);
            this.txtDUProduct.TabIndex = 3;
            // 
            // textDUQuantity
            // 
            this.textDUQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDUQuantity.Location = new System.Drawing.Point(104, 105);
            this.textDUQuantity.Name = "textDUQuantity";
            this.textDUQuantity.Size = new System.Drawing.Size(193, 26);
            this.textDUQuantity.TabIndex = 2;
            // 
            // pbxImageDischarge
            // 
            this.pbxImageDischarge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImageDischarge.Location = new System.Drawing.Point(331, 116);
            this.pbxImageDischarge.Name = "pbxImageDischarge";
            this.pbxImageDischarge.Size = new System.Drawing.Size(255, 256);
            this.pbxImageDischarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImageDischarge.TabIndex = 6;
            this.pbxImageDischarge.TabStop = false;
            // 
            // btnSaveDischarge
            // 
            this.btnSaveDischarge.BackColor = System.Drawing.Color.White;
            this.btnSaveDischarge.BackgroundImage = global::Spare_Parts_SBL_Maintenance.Properties.Resources.enter;
            this.btnSaveDischarge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDischarge.ForeColor = System.Drawing.Color.White;
            this.btnSaveDischarge.Location = new System.Drawing.Point(251, 426);
            this.btnSaveDischarge.Name = "btnSaveDischarge";
            this.btnSaveDischarge.Size = new System.Drawing.Size(123, 81);
            this.btnSaveDischarge.TabIndex = 7;
            this.btnSaveDischarge.UseVisualStyleBackColor = false;
            this.btnSaveDischarge.Click += new System.EventHandler(this.btnSaveDischarge_Click);
            // 
            // frmMaterialDischarge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(599, 541);
            this.Controls.Add(this.btnSaveDischarge);
            this.Controls.Add(this.pbxImageDischarge);
            this.Controls.Add(this.Paquetes);
            this.Controls.Add(this.panel1);
            this.Name = "frmMaterialDischarge";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "frmMaterialDischarge";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Paquetes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageDischarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl Paquetes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUSearch;
        private System.Windows.Forms.Label txtUQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDUSerial;
        private System.Windows.Forms.TextBox txtDUPart;
        private System.Windows.Forms.TextBox txtDUProduct;
        private System.Windows.Forms.TextBox textDUQuantity;
        private System.Windows.Forms.PictureBox pbxImageDischarge;
        private System.Windows.Forms.Button btnSaveDischarge;
    }
}