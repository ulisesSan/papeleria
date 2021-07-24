
namespace papeSraErika
{
    partial class productView
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
            this.productTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Location = new System.Drawing.Point(40, 78);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.Size = new System.Drawing.Size(970, 389);
            this.productTable.TabIndex = 0;
            // 
            // productView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 561);
            this.Controls.Add(this.productTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productView";
            this.Text = "productView";
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productTable;
    }
}