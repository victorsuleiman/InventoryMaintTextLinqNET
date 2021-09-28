namespace InventoryMaintenance
{
    partial class frmInvMaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.comboBoxShow = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 20;
            this.lstItems.Location = new System.Drawing.Point(21, 101);
            this.lstItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(349, 204);
            this.lstItems.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(404, 103);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 152);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(404, 201);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(21, 35);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(48, 20);
            this.labelShow.TabIndex = 11;
            this.labelShow.Text = "Show:";
            // 
            // comboBoxShow
            // 
            this.comboBoxShow.FormattingEnabled = true;
            this.comboBoxShow.Items.AddRange(new object[] {
            "All",
            "Under $10",
            "Order By Price"});
            this.comboBoxShow.Location = new System.Drawing.Point(85, 32);
            this.comboBoxShow.Name = "comboBoxShow";
            this.comboBoxShow.Size = new System.Drawing.Size(151, 28);
            this.comboBoxShow.TabIndex = 12;
            this.comboBoxShow.Text = "All";
            this.comboBoxShow.SelectedIndexChanged += new System.EventHandler(this.comboBoxShow_SelectedIndexChanged);
            // 
            // frmInvMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(544, 339);
            this.Controls.Add(this.comboBoxShow);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstItems);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmInvMaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Maintenance";
            this.Load += new System.EventHandler(this.frmInvMaint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.ComboBox comboBoxShow;
    }
}

