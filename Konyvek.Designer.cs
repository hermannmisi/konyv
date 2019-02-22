namespace Konyv
{
    partial class Konyvek
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Megjelenites = new System.Windows.Forms.TabPage();
            this.btnTorles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rogzites = new System.Windows.Forms.TabPage();
            this.btnAdatRogzitese = new System.Windows.Forms.Button();
            this.txtBxKonyvcim = new System.Windows.Forms.TextBox();
            this.txtBxSzerzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Megjelenites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Rogzites.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Megjelenites);
            this.tabControl1.Controls.Add(this.Rogzites);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 427);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Megjelenites
            // 
            this.Megjelenites.Controls.Add(this.btnTorles);
            this.Megjelenites.Controls.Add(this.dataGridView1);
            this.Megjelenites.Location = new System.Drawing.Point(4, 22);
            this.Megjelenites.Name = "Megjelenites";
            this.Megjelenites.Padding = new System.Windows.Forms.Padding(3);
            this.Megjelenites.Size = new System.Drawing.Size(772, 401);
            this.Megjelenites.TabIndex = 0;
            this.Megjelenites.Text = "Megjelenítés";
            this.Megjelenites.UseVisualStyleBackColor = true;
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(626, 6);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(140, 23);
            this.btnTorles.TabIndex = 1;
            this.btnTorles.Text = "Kijelölt adat törlése";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // Rogzites
            // 
            this.Rogzites.Controls.Add(this.btnAdatRogzitese);
            this.Rogzites.Controls.Add(this.txtBxKonyvcim);
            this.Rogzites.Controls.Add(this.txtBxSzerzo);
            this.Rogzites.Controls.Add(this.label2);
            this.Rogzites.Controls.Add(this.label1);
            this.Rogzites.Location = new System.Drawing.Point(4, 22);
            this.Rogzites.Name = "Rogzites";
            this.Rogzites.Padding = new System.Windows.Forms.Padding(3);
            this.Rogzites.Size = new System.Drawing.Size(772, 401);
            this.Rogzites.TabIndex = 1;
            this.Rogzites.Text = "Rögzítés";
            this.Rogzites.UseVisualStyleBackColor = true;
            // 
            // btnAdatRogzitese
            // 
            this.btnAdatRogzitese.Location = new System.Drawing.Point(306, 196);
            this.btnAdatRogzitese.Name = "btnAdatRogzitese";
            this.btnAdatRogzitese.Size = new System.Drawing.Size(75, 23);
            this.btnAdatRogzitese.TabIndex = 3;
            this.btnAdatRogzitese.Text = "Adatok felvitele";
            this.btnAdatRogzitese.UseVisualStyleBackColor = true;
            this.btnAdatRogzitese.Click += new System.EventHandler(this.btnAdatRogzitese_Click);
            // 
            // txtBxKonyvcim
            // 
            this.txtBxKonyvcim.Location = new System.Drawing.Point(60, 153);
            this.txtBxKonyvcim.MaxLength = 255;
            this.txtBxKonyvcim.Name = "txtBxKonyvcim";
            this.txtBxKonyvcim.Size = new System.Drawing.Size(186, 20);
            this.txtBxKonyvcim.TabIndex = 2;
            // 
            // txtBxSzerzo
            // 
            this.txtBxSzerzo.Location = new System.Drawing.Point(60, 66);
            this.txtBxSzerzo.MaxLength = 255;
            this.txtBxSzerzo.Name = "txtBxSzerzo";
            this.txtBxSzerzo.Size = new System.Drawing.Size(186, 20);
            this.txtBxSzerzo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Könyv címe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szerző(k) neve(i):";
            // 
            // Konyvek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(460, 330);
            this.Name = "Konyvek";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyvek";
            this.Load += new System.EventHandler(this.Konyvek_Load);
            this.Resize += new System.EventHandler(this.Konyvek_Resize);
            this.tabControl1.ResumeLayout(false);
            this.Megjelenites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Rogzites.ResumeLayout(false);
            this.Rogzites.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Megjelenites;
        private System.Windows.Forms.TabPage Rogzites;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdatRogzitese;
        private System.Windows.Forms.TextBox txtBxKonyvcim;
        private System.Windows.Forms.TextBox txtBxSzerzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

