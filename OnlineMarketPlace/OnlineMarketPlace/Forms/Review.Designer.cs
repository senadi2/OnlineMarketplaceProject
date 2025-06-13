namespace OnlineMarketPlace.Forms
{
    partial class Review
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
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btbSubmit = new System.Windows.Forms.Button();
            this.btncamcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(318, 38);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(200, 30);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "Leave a Review";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(184, 148);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 21);
            this.lblRating.TabIndex = 2;
            this.lblRating.Text = "Rating";
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "★☆☆☆☆",
            "★★☆☆☆",
            "★★★☆☆",
            "★★★★☆",
            "★★★★★"});
            this.cmbRating.Location = new System.Drawing.Point(344, 145);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(211, 24);
            this.cmbRating.TabIndex = 3;
            // 
            // btbSubmit
            // 
            this.btbSubmit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSubmit.Location = new System.Drawing.Point(116, 472);
            this.btbSubmit.Name = "btbSubmit";
            this.btbSubmit.Size = new System.Drawing.Size(128, 47);
            this.btbSubmit.TabIndex = 5;
            this.btbSubmit.Text = "Submit";
            this.btbSubmit.UseVisualStyleBackColor = true;
            // 
            // btncamcel
            // 
            this.btncamcel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncamcel.Location = new System.Drawing.Point(613, 472);
            this.btncamcel.Name = "btncamcel";
            this.btncamcel.Size = new System.Drawing.Size(128, 47);
            this.btncamcel.TabIndex = 6;
            this.btncamcel.Text = "Cancel";
            this.btncamcel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComments);
            this.groupBox1.Controls.Add(this.lblComments);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 192);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Review";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(72, 71);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(432, 100);
            this.txtComments.TabIndex = 6;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(68, 29);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(85, 21);
            this.lblComments.TabIndex = 5;
            this.lblComments.Text = "Comments";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncamcel);
            this.Controls.Add(this.btbSubmit);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblTopic);
            this.Name = "Review";
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Button btbSubmit;
        private System.Windows.Forms.Button btncamcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
    }
}