
namespace papeSraErika
{
    partial class Princial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Venta = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Venta);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 561);
            this.panel1.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(183, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1063, 561);
            this.panelCenter.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::papeSraErika.Properties.Resources.Azul;
            this.button2.Location = new System.Drawing.Point(39, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ventas Realizadas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Venta
            // 
            this.Venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Venta.FlatAppearance.BorderSize = 0;
            this.Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Venta.ForeColor = System.Drawing.Color.Transparent;
            this.Venta.Image = global::papeSraErika.Properties.Resources.Azul;
            this.Venta.Location = new System.Drawing.Point(39, 70);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(114, 50);
            this.Venta.TabIndex = 2;
            this.Venta.Text = "Ventas";
            this.Venta.UseVisualStyleBackColor = true;
            this.Venta.Click += new System.EventHandler(this.Venta_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImage = global::papeSraErika.Properties.Resources.Azul;
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnProduct.Image = global::papeSraErika.Properties.Resources.Azul;
            this.btnProduct.Location = new System.Drawing.Point(39, 173);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(114, 50);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Productos";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // Princial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 561);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panel1);
            this.Name = "Princial";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Venta;
    }
}

