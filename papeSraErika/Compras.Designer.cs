
namespace papeSraErika
{
    partial class Compras
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
            this.DataTableVenta = new System.Windows.Forms.DataGridView();
            this.mapCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableVenta
            // 
            this.DataTableVenta.AutoGenerateColumns = false;
            this.DataTableVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTableVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idventaDataGridViewTextBoxColumn,
            this.fechaventaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.DataTableVenta.DataSource = this.mapCompraBindingSource;
            this.DataTableVenta.Location = new System.Drawing.Point(187, 160);
            this.DataTableVenta.Name = "DataTableVenta";
            this.DataTableVenta.Size = new System.Drawing.Size(660, 279);
            this.DataTableVenta.TabIndex = 0;
            // 
            // mapCompraBindingSource
            // 
            this.mapCompraBindingSource.DataSource = typeof(papeSraErika.MapCompra);
            // 
            // idventaDataGridViewTextBoxColumn
            // 
            this.idventaDataGridViewTextBoxColumn.DataPropertyName = "Id_venta";
            this.idventaDataGridViewTextBoxColumn.HeaderText = "Id_venta";
            this.idventaDataGridViewTextBoxColumn.Name = "idventaDataGridViewTextBoxColumn";
            // 
            // fechaventaDataGridViewTextBoxColumn
            // 
            this.fechaventaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_venta";
            this.fechaventaDataGridViewTextBoxColumn.HeaderText = "Fecha_venta";
            this.fechaventaDataGridViewTextBoxColumn.Name = "fechaventaDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 561);
            this.Controls.Add(this.DataTableVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.DataTableVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTableVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mapCompraBindingSource;
    }
}