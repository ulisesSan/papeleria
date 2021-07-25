
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
            this.components = new System.ComponentModel.Container();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.productMapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AutoGenerateColumns = false;
            this.productTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.brand1DataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.price1DataGridViewTextBoxColumn,
            this.stock1DataGridViewTextBoxColumn});
            this.productTable.DataSource = this.productMapBindingSource;
            this.productTable.Location = new System.Drawing.Point(130, 87);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.Size = new System.Drawing.Size(763, 389);
            this.productTable.TabIndex = 0;
            // 
            // productMapBindingSource
            // 
            this.productMapBindingSource.DataSource = typeof(papeSraErika.productMap);
            // 
            // barCodeDataGridViewTextBoxColumn
            // 
            this.barCodeDataGridViewTextBoxColumn.DataPropertyName = "BarCode";
            this.barCodeDataGridViewTextBoxColumn.Frozen = true;
            this.barCodeDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.barCodeDataGridViewTextBoxColumn.Name = "barCodeDataGridViewTextBoxColumn";
            this.barCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.barCodeDataGridViewTextBoxColumn.Width = 120;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Frozen = true;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Nombre Del Producto";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // brand1DataGridViewTextBoxColumn
            // 
            this.brand1DataGridViewTextBoxColumn.DataPropertyName = "Brand1";
            this.brand1DataGridViewTextBoxColumn.Frozen = true;
            this.brand1DataGridViewTextBoxColumn.HeaderText = "Marca";
            this.brand1DataGridViewTextBoxColumn.Name = "brand1DataGridViewTextBoxColumn";
            this.brand1DataGridViewTextBoxColumn.ReadOnly = true;
            this.brand1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.brand1DataGridViewTextBoxColumn.Width = 120;
            // 
            // description1DataGridViewTextBoxColumn
            // 
            this.description1DataGridViewTextBoxColumn.DataPropertyName = "Description1";
            this.description1DataGridViewTextBoxColumn.Frozen = true;
            this.description1DataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.description1DataGridViewTextBoxColumn.Name = "description1DataGridViewTextBoxColumn";
            this.description1DataGridViewTextBoxColumn.ReadOnly = true;
            this.description1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.description1DataGridViewTextBoxColumn.Width = 120;
            // 
            // price1DataGridViewTextBoxColumn
            // 
            this.price1DataGridViewTextBoxColumn.DataPropertyName = "Price1";
            this.price1DataGridViewTextBoxColumn.Frozen = true;
            this.price1DataGridViewTextBoxColumn.HeaderText = "Precio";
            this.price1DataGridViewTextBoxColumn.Name = "price1DataGridViewTextBoxColumn";
            this.price1DataGridViewTextBoxColumn.ReadOnly = true;
            this.price1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price1DataGridViewTextBoxColumn.Width = 120;
            // 
            // stock1DataGridViewTextBoxColumn
            // 
            this.stock1DataGridViewTextBoxColumn.DataPropertyName = "Stock1";
            this.stock1DataGridViewTextBoxColumn.Frozen = true;
            this.stock1DataGridViewTextBoxColumn.HeaderText = "Existencias";
            this.stock1DataGridViewTextBoxColumn.Name = "stock1DataGridViewTextBoxColumn";
            this.stock1DataGridViewTextBoxColumn.ReadOnly = true;
            this.stock1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stock1DataGridViewTextBoxColumn.Width = 120;
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
            ((System.ComponentModel.ISupportInitialize)(this.productMapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn barCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productMapBindingSource;
    }
}