
namespace autokereskedes
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMűveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újLétrehozásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMárka = new System.Windows.Forms.TextBox();
            this.txtTipus = new System.Windows.Forms.TextBox();
            this.txtÉv = new System.Windows.Forms.TextBox();
            this.txtSzin = new System.Windows.Forms.TextBox();
            this.txtRendszam = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblMárka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMűveletekToolStripMenuItem,
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMűveletekToolStripMenuItem
            // 
            this.fileMűveletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitásToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.újLétrehozásaToolStripMenuItem});
            this.fileMűveletekToolStripMenuItem.Name = "fileMűveletekToolStripMenuItem";
            this.fileMűveletekToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.fileMűveletekToolStripMenuItem.Text = "File műveletek";
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // újLétrehozásaToolStripMenuItem
            // 
            this.újLétrehozásaToolStripMenuItem.Name = "újLétrehozásaToolStripMenuItem";
            this.újLétrehozásaToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.újLétrehozásaToolStripMenuItem.Text = "Új létrehozása";
            this.újLétrehozásaToolStripMenuItem.Click += new System.EventHandler(this.újLétrehozásaToolStripMenuItem_Click);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.névjegyToolStripMenuItem1,
            this.kilépésToolStripMenuItem});
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            // 
            // névjegyToolStripMenuItem1
            // 
            this.névjegyToolStripMenuItem1.Name = "névjegyToolStripMenuItem1";
            this.névjegyToolStripMenuItem1.Size = new System.Drawing.Size(146, 26);
            this.névjegyToolStripMenuItem1.Text = "Névjegy";
            this.névjegyToolStripMenuItem1.Click += new System.EventHandler(this.névjegyToolStripMenuItem1_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // txtMárka
            // 
            this.txtMárka.Location = new System.Drawing.Point(588, 92);
            this.txtMárka.Name = "txtMárka";
            this.txtMárka.Size = new System.Drawing.Size(144, 22);
            this.txtMárka.TabIndex = 1;
            // 
            // txtTipus
            // 
            this.txtTipus.Location = new System.Drawing.Point(588, 120);
            this.txtTipus.Name = "txtTipus";
            this.txtTipus.Size = new System.Drawing.Size(144, 22);
            this.txtTipus.TabIndex = 2;
            // 
            // txtÉv
            // 
            this.txtÉv.Location = new System.Drawing.Point(588, 148);
            this.txtÉv.Name = "txtÉv";
            this.txtÉv.Size = new System.Drawing.Size(144, 22);
            this.txtÉv.TabIndex = 3;
            // 
            // txtSzin
            // 
            this.txtSzin.Location = new System.Drawing.Point(588, 176);
            this.txtSzin.Name = "txtSzin";
            this.txtSzin.Size = new System.Drawing.Size(144, 22);
            this.txtSzin.TabIndex = 4;
            // 
            // txtRendszam
            // 
            this.txtRendszam.Location = new System.Drawing.Point(588, 204);
            this.txtRendszam.Name = "txtRendszam";
            this.txtRendszam.Size = new System.Drawing.Size(144, 22);
            this.txtRendszam.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(588, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Hozzáad";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(94, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 148);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(269, 232);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Módosít";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(94, 232);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(144, 35);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Törlés";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblMárka
            // 
            this.lblMárka.AutoSize = true;
            this.lblMárka.Location = new System.Drawing.Point(497, 95);
            this.lblMárka.Name = "lblMárka";
            this.lblMárka.Size = new System.Drawing.Size(47, 17);
            this.lblMárka.TabIndex = 10;
            this.lblMárka.Text = "Márka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gyártás éve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Szín";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rendszám";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMárka);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRendszam);
            this.Controls.Add(this.txtSzin);
            this.Controls.Add(this.txtÉv);
            this.Controls.Add(this.txtTipus);
            this.Controls.Add(this.txtMárka);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMűveletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újLétrehozásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMárka;
        private System.Windows.Forms.TextBox txtTipus;
        private System.Windows.Forms.TextBox txtÉv;
        private System.Windows.Forms.TextBox txtSzin;
        private System.Windows.Forms.TextBox txtRendszam;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblMárka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

