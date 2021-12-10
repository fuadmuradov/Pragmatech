
namespace Student_delete_update
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
            this.menu_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_update = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_group = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.datagv = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_delete,
            this.menu_update});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_delete
            // 
            this.menu_delete.Name = "menu_delete";
            this.menu_delete.Size = new System.Drawing.Size(67, 24);
            this.menu_delete.Text = "Delete";
            this.menu_delete.Click += new System.EventHandler(this.menu_delete_Click);
            // 
            // menu_update
            // 
            this.menu_update.Name = "menu_update";
            this.menu_update.Size = new System.Drawing.Size(72, 24);
            this.menu_update.Text = "Update";
            this.menu_update.Click += new System.EventHandler(this.menu_update_Click);
            // 
            // cmb_group
            // 
            this.cmb_group.FormattingEnabled = true;
            this.cmb_group.Location = new System.Drawing.Point(0, 68);
            this.cmb_group.Name = "cmb_group";
            this.cmb_group.Size = new System.Drawing.Size(153, 24);
            this.cmb_group.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 204);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(221, 22);
            this.txt_name.TabIndex = 2;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(288, 203);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(237, 22);
            this.txt_surname.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(588, 197);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(131, 35);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // datagv
            // 
            this.datagv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv.Location = new System.Drawing.Point(0, 259);
            this.datagv.Name = "datagv";
            this.datagv.RowHeadersWidth = 51;
            this.datagv.RowTemplate.Height = 24;
            this.datagv.Size = new System.Drawing.Size(800, 191);
            this.datagv.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagv);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.cmb_group);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_delete;
        private System.Windows.Forms.ToolStripMenuItem menu_update;
        private System.Windows.Forms.ComboBox cmb_group;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView datagv;
    }
}

