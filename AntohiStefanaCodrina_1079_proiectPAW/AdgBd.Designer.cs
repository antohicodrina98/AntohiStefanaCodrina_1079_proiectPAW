
namespace AntohiStefanaCodrina_1079_proiectPAW
{
    partial class AdgBd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdgBd));
            this.cbBlat = new System.Windows.Forms.ComboBox();
            this.cbSos = new System.Windows.Forms.ComboBox();
            this.cbExtraTopping = new System.Windows.Forms.ComboBox();
            this.cbNumePizza = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Blat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBlat
            // 
            this.cbBlat.FormattingEnabled = true;
            this.cbBlat.Items.AddRange(new object[] {
            "Subtire",
            "Pufos"});
            this.cbBlat.Location = new System.Drawing.Point(290, 137);
            this.cbBlat.Name = "cbBlat";
            this.cbBlat.Size = new System.Drawing.Size(121, 24);
            this.cbBlat.TabIndex = 32;
            // 
            // cbSos
            // 
            this.cbSos.FormattingEnabled = true;
            this.cbSos.Items.AddRange(new object[] {
            "dulce",
            "picant",
            "bbq",
            "usturoi"});
            this.cbSos.Location = new System.Drawing.Point(290, 286);
            this.cbSos.Name = "cbSos";
            this.cbSos.Size = new System.Drawing.Size(121, 24);
            this.cbSos.TabIndex = 31;
            // 
            // cbExtraTopping
            // 
            this.cbExtraTopping.FormattingEnabled = true;
            this.cbExtraTopping.Items.AddRange(new object[] {
            "Fara extra topping",
            "Salam",
            "Masline",
            "Ciuperci",
            "Ananas",
            "Ardei",
            "Ceapa"});
            this.cbExtraTopping.Location = new System.Drawing.Point(290, 210);
            this.cbExtraTopping.Name = "cbExtraTopping";
            this.cbExtraTopping.Size = new System.Drawing.Size(121, 24);
            this.cbExtraTopping.TabIndex = 30;
            // 
            // cbNumePizza
            // 
            this.cbNumePizza.FormattingEnabled = true;
            this.cbNumePizza.Items.AddRange(new object[] {
            "Margherita",
            "Capricciosa",
            "Pepperoni",
            "Quattro Formaggi",
            "Hawaiana",
            "Marinara",
            "Calzone"});
            this.cbNumePizza.Location = new System.Drawing.Point(290, 57);
            this.cbNumePizza.Name = "cbNumePizza";
            this.cbNumePizza.Size = new System.Drawing.Size(121, 24);
            this.cbNumePizza.TabIndex = 29;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Castellar", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(574, 158);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(185, 100);
            this.btnAdauga.TabIndex = 28;
            this.btnAdauga.Text = "Adauga Comanda";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(290, 361);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(100, 22);
            this.tbAdresa.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "sos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "extraTopping";
            // 
            // Blat
            // 
            this.Blat.AutoSize = true;
            this.Blat.BackColor = System.Drawing.Color.Transparent;
            this.Blat.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blat.Location = new System.Drawing.Point(57, 129);
            this.Blat.Name = "Blat";
            this.Blat.Size = new System.Drawing.Size(76, 32);
            this.Blat.TabIndex = 23;
            this.Blat.Text = "Blat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "numePizza";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdgBd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbBlat);
            this.Controls.Add(this.cbSos);
            this.Controls.Add(this.cbExtraTopping);
            this.Controls.Add(this.cbNumePizza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Blat);
            this.Controls.Add(this.label1);
            this.Name = "AdgBd";
            this.Text = "AdgBd";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBlat;
        private System.Windows.Forms.ComboBox cbSos;
        private System.Windows.Forms.ComboBox cbExtraTopping;
        private System.Windows.Forms.ComboBox cbNumePizza;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Blat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}