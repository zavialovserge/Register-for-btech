namespace List_Of_Goods
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procurementPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnIndexation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_col,
            this.Amount,
            this.procurementPrice,
            this.Category});
            this.listView1.Location = new System.Drawing.Point(176, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 205);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name_col
            // 
            this.Name_col.Text = "Name";
            this.Name_col.Width = 80;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 80;
            // 
            // procurementPrice
            // 
            this.procurementPrice.Text = "Procurement Price";
            this.procurementPrice.Width = 125;
            // 
            // Category
            // 
            this.Category.Text = "Category of goods";
            this.Category.Width = 109;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnIndexation
            // 
            this.btnIndexation.Location = new System.Drawing.Point(29, 123);
            this.btnIndexation.Name = "btnIndexation";
            this.btnIndexation.Size = new System.Drawing.Size(98, 23);
            this.btnIndexation.TabIndex = 2;
            this.btnIndexation.Text = "INDEXATION";
            this.btnIndexation.UseVisualStyleBackColor = true;
            this.btnIndexation.Click += new System.EventHandler(this.btnIndexation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(29, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 284);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnIndexation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnIndexation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader Name_col;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader procurementPrice;
        private System.Windows.Forms.ColumnHeader Category;
    }
}

