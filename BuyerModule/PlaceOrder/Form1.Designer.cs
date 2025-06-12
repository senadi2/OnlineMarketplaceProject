namespace PlaceOrder
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
            this.lblConfirmOrder = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpConfirmOrder = new System.Windows.Forms.GroupBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPriceT = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblQuantityT = new System.Windows.Forms.Label();
            this.grpConfirmOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfirmOrder
            // 
            this.lblConfirmOrder.AutoSize = true;
            this.lblConfirmOrder.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmOrder.Location = new System.Drawing.Point(298, 29);
            this.lblConfirmOrder.Name = "lblConfirmOrder";
            this.lblConfirmOrder.Size = new System.Drawing.Size(208, 30);
            this.lblConfirmOrder.TabIndex = 0;
            this.lblConfirmOrder.Text = " Confirm Order ";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(514, 370);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(93, 35);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(645, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpConfirmOrder
            // 
            this.grpConfirmOrder.Controls.Add(this.numQuantity);
            this.grpConfirmOrder.Controls.Add(this.lblProductTitle);
            this.grpConfirmOrder.Controls.Add(this.lblName);
            this.grpConfirmOrder.Controls.Add(this.lblPriceT);
            this.grpConfirmOrder.Controls.Add(this.lblProductPrice);
            this.grpConfirmOrder.Controls.Add(this.lblQuantityT);
            this.grpConfirmOrder.Location = new System.Drawing.Point(77, 110);
            this.grpConfirmOrder.Name = "grpConfirmOrder";
            this.grpConfirmOrder.Size = new System.Drawing.Size(648, 235);
            this.grpConfirmOrder.TabIndex = 9;
            this.grpConfirmOrder.TabStop = false;
            this.grpConfirmOrder.Text = "Confirm Order";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(226, 162);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 12;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTitle.Location = new System.Drawing.Point(93, 41);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(72, 21);
            this.lblProductTitle.TabIndex = 11;
            this.lblProductTitle.Text = "Product:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(222, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 21);
            this.lblName.TabIndex = 10;
            // 
            // lblPriceT
            // 
            this.lblPriceT.AutoSize = true;
            this.lblPriceT.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceT.Location = new System.Drawing.Point(93, 103);
            this.lblPriceT.Name = "lblPriceT";
            this.lblPriceT.Size = new System.Drawing.Size(53, 21);
            this.lblPriceT.TabIndex = 9;
            this.lblPriceT.Text = "Price:";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(222, 103);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(0, 21);
            this.lblProductPrice.TabIndex = 8;
            // 
            // lblQuantityT
            // 
            this.lblQuantityT.AutoSize = true;
            this.lblQuantityT.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityT.Location = new System.Drawing.Point(93, 163);
            this.lblQuantityT.Name = "lblQuantityT";
            this.lblQuantityT.Size = new System.Drawing.Size(75, 21);
            this.lblQuantityT.TabIndex = 7;
            this.lblQuantityT.Text = "Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpConfirmOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblConfirmOrder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpConfirmOrder.ResumeLayout(false);
            this.grpConfirmOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmOrder;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpConfirmOrder;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPriceT;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblQuantityT;
    }
}

