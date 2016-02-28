namespace List_Of_Goods
{
    partial class indexingForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnIndexation = new System.Windows.Forms.Button();
            this.labelindex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(79, 86);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(116, 20);
            this.textBox.TabIndex = 0;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // btnIndexation
            // 
            this.btnIndexation.Location = new System.Drawing.Point(79, 160);
            this.btnIndexation.Name = "btnIndexation";
            this.btnIndexation.Size = new System.Drawing.Size(116, 23);
            this.btnIndexation.TabIndex = 1;
            this.btnIndexation.Text = "Indexation";
            this.btnIndexation.UseVisualStyleBackColor = true;
            this.btnIndexation.Click += new System.EventHandler(this.btnIndexation_Click);
            // 
            // labelindex
            // 
            this.labelindex.AutoSize = true;
            this.labelindex.Location = new System.Drawing.Point(79, 38);
            this.labelindex.MinimumSize = new System.Drawing.Size(116, 20);
            this.labelindex.Name = "labelindex";
            this.labelindex.Size = new System.Drawing.Size(116, 20);
            this.labelindex.TabIndex = 2;
            this.labelindex.Text = "Enter indexation(%)";
            this.labelindex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // indexingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelindex);
            this.Controls.Add(this.btnIndexation);
            this.Controls.Add(this.textBox);
            this.Name = "indexingForm";
            this.Text = "indexingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnIndexation;
        private System.Windows.Forms.Label labelindex;
    }
}