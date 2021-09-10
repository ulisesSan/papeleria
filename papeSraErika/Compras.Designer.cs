
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
            this.idventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableVenta
            // 
            this.DataTableVenta.AllowUserToAddRows = false;
            this.DataTableVenta.AllowUserToDeleteRows = false;
            this.DataTableVenta.AutoGenerateColumns = false;
            this.DataTableVenta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataTableVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataTableVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idventaDataGridViewTextBoxColumn,
            this.fechaventaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.DataTableVenta.DataSource = this.mapCompraBindingSource;
            this.DataTableVenta.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DataTableVenta.Location = new System.Drawing.Point(220, 161);
            this.DataTableVenta.Name = "DataTableVenta";
            this.DataTableVenta.ReadOnly = true;
            this.DataTableVenta.RowHeadersVisible = false;
            this.DataTableVenta.Size = new System.Drawing.Size(605, 279);
            this.DataTableVenta.TabIndex = 0;
            // 
            // idventaDataGridViewTextBoxColumn
            // 
            this.idventaDataGridViewTextBoxColumn.DataPropertyName = "Id_venta";
            this.idventaDataGridViewTextBoxColumn.HeaderText = "Numero de venta";
            this.idventaDataGridViewTextBoxColumn.Name = "idventaDataGridViewTextBoxColumn";
            this.idventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idventaDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaventaDataGridViewTextBoxColumn
            // 
            this.fechaventaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_venta";
            this.fechaventaDataGridViewTextBoxColumn.HeaderText = "Fecha de venta";
            this.fechaventaDataGridViewTextBoxColumn.Name = "fechaventaDataGridViewTextBoxColumn";
            this.fechaventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaventaDataGridViewTextBoxColumn.Width = 300;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // mapCompraBindingSource
            // 
            this.mapCompraBindingSource.DataSource = typeof(papeSraErika.MapCompra);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(866, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(866, 399);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(97, 26);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Copia de seguridad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnUpdate);
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
        private System.Windows.Forms.BindingSource mapCompraBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}