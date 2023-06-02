namespace loggs_dapiton
{
    partial class Main
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bttnSettings = new System.Windows.Forms.Button();
            this.bttnSales = new System.Windows.Forms.Button();
            this.bttnInventory = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bttnSettings
            // 
            this.bttnSettings.Location = new System.Drawing.Point(537, 24);
            this.bttnSettings.Name = "bttnSettings";
            this.bttnSettings.Size = new System.Drawing.Size(75, 23);
            this.bttnSettings.TabIndex = 2;
            this.bttnSettings.Text = "Settings";
            this.bttnSettings.UseVisualStyleBackColor = true;
            // 
            // bttnSales
            // 
            this.bttnSales.Location = new System.Drawing.Point(629, 24);
            this.bttnSales.Name = "bttnSales";
            this.bttnSales.Size = new System.Drawing.Size(75, 23);
            this.bttnSales.TabIndex = 3;
            this.bttnSales.Text = "Sales Performance";
            this.bttnSales.UseVisualStyleBackColor = true;
            // 
            // bttnInventory
            // 
            this.bttnInventory.Location = new System.Drawing.Point(713, 24);
            this.bttnInventory.Name = "bttnInventory";
            this.bttnInventory.Size = new System.Drawing.Size(75, 23);
            this.bttnInventory.TabIndex = 4;
            this.bttnInventory.Text = "Inventory";
            this.bttnInventory.UseVisualStyleBackColor = true;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(456, 24);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(75, 23);
            this.txtProduct.TabIndex = 5;
            this.txtProduct.Text = "Product";
            this.txtProduct.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.bttnInventory);
            this.Controls.Add(this.bttnSales);
            this.Controls.Add(this.bttnSettings);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageList1;
        private Button bttnSettings;
        private Button bttnSales;
        private Button bttnInventory;
        private Button txtProduct;
    }
}