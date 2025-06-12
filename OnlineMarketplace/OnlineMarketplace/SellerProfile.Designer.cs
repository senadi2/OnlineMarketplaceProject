namespace OnlineMarketPlace
{
    partial class SellerProfile
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
            this.lblSellerProfile = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSellerProfile
            // 
            this.lblSellerProfile.AutoSize = true;
            this.lblSellerProfile.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerProfile.Location = new System.Drawing.Point(282, 41);
            this.lblSellerProfile.Name = "lblSellerProfile";
            this.lblSellerProfile.Size = new System.Drawing.Size(122, 21);
            this.lblSellerProfile.TabIndex = 0;
            this.lblSellerProfile.Text = "Seller Profile";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(48, 190);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(66, 21);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Rating";
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerName.Location = new System.Drawing.Point(43, 110);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(109, 21);
            this.lblSellerName.TabIndex = 2;
            this.lblSellerName.Text = "Seller Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(432, 22);
            this.textBox2.TabIndex = 4;
            // 
            // btnReviews
            // 
            this.btnReviews.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.Location = new System.Drawing.Point(101, 290);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(92, 26);
            this.btnReviews.TabIndex = 5;
            this.btnReviews.Text = "Reviews";
            this.btnReviews.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(101, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // SellerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReviews);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSellerName);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblSellerProfile);
            this.Name = "SellerProfile";
            this.Text = "SellerProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSellerProfile;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnBack;
    }
}