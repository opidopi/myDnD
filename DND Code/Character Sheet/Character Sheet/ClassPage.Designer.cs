namespace Character_Sheet
{
    partial class ClassPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ClassTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SubClassTabs = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ClassTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Page";
            // 
            // ClassTable
            // 
            this.ClassTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClassTable.Location = new System.Drawing.Point(0, 0);
            this.ClassTable.Name = "ClassTable";
            this.ClassTable.ReadOnly = true;
            this.ClassTable.Size = new System.Drawing.Size(523, 136);
            this.ClassTable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(334, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 276);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class Features";
            // 
            // SubClassTabs
            // 
            this.SubClassTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubClassTabs.Location = new System.Drawing.Point(0, 136);
            this.SubClassTabs.Name = "SubClassTabs";
            this.SubClassTabs.SelectedIndex = 0;
            this.SubClassTabs.Size = new System.Drawing.Size(334, 276);
            this.SubClassTabs.TabIndex = 3;
            // 
            // ClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.SubClassTabs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClassTable);
            this.Controls.Add(this.label1);
            this.Name = "ClassPage";
            this.Size = new System.Drawing.Size(523, 412);
            ((System.ComponentModel.ISupportInitialize)(this.ClassTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView ClassTable;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabControl SubClassTabs;
    }
}
