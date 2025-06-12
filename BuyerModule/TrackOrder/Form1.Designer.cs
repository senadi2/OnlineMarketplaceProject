namespace TrackOrder
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
            this.lblTrack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpTrackOrder = new System.Windows.Forms.GroupBox();
            this.lblOrderIdTitle = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEstiDTitle = new System.Windows.Forms.Label();
            this.lblEstimatedDelivery = new System.Windows.Forms.Label();
            this.grpTrackOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrack.Location = new System.Drawing.Point(265, 45);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(256, 30);
            this.lblTrack.TabIndex = 0;
            this.lblTrack.Text = "Track Order Status ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(99, 383);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // grpTrackOrder
            // 
            this.grpTrackOrder.Controls.Add(this.lblOrderIdTitle);
            this.grpTrackOrder.Controls.Add(this.lblOrderId);
            this.grpTrackOrder.Controls.Add(this.lblStatusTitle);
            this.grpTrackOrder.Controls.Add(this.lblStatus);
            this.grpTrackOrder.Controls.Add(this.lblEstiDTitle);
            this.grpTrackOrder.Controls.Add(this.lblEstimatedDelivery);
            this.grpTrackOrder.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTrackOrder.Location = new System.Drawing.Point(99, 101);
            this.grpTrackOrder.Name = "grpTrackOrder";
            this.grpTrackOrder.Size = new System.Drawing.Size(612, 247);
            this.grpTrackOrder.TabIndex = 8;
            this.grpTrackOrder.TabStop = false;
            this.grpTrackOrder.Text = "Track Order Status";
            // 
            // lblOrderIdTitle
            // 
            this.lblOrderIdTitle.AutoSize = true;
            this.lblOrderIdTitle.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIdTitle.Location = new System.Drawing.Point(97, 56);
            this.lblOrderIdTitle.Name = "lblOrderIdTitle";
            this.lblOrderIdTitle.Size = new System.Drawing.Size(79, 21);
            this.lblOrderIdTitle.TabIndex = 12;
            this.lblOrderIdTitle.Text = "Order ID:";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(304, 56);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(0, 21);
            this.lblOrderId.TabIndex = 11;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(97, 110);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(58, 21);
            this.lblStatusTitle.TabIndex = 10;
            this.lblStatusTitle.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(304, 110);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 21);
            this.lblStatus.TabIndex = 9;
            // 
            // lblEstiDTitle
            // 
            this.lblEstiDTitle.AutoSize = true;
            this.lblEstiDTitle.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstiDTitle.Location = new System.Drawing.Point(97, 173);
            this.lblEstiDTitle.Name = "lblEstiDTitle";
            this.lblEstiDTitle.Size = new System.Drawing.Size(154, 21);
            this.lblEstiDTitle.TabIndex = 8;
            this.lblEstiDTitle.Text = "Estimated Delivery:";
            // 
            // lblEstimatedDelivery
            // 
            this.lblEstimatedDelivery.AutoSize = true;
            this.lblEstimatedDelivery.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedDelivery.Location = new System.Drawing.Point(304, 173);
            this.lblEstimatedDelivery.Name = "lblEstimatedDelivery";
            this.lblEstimatedDelivery.Size = new System.Drawing.Size(0, 21);
            this.lblEstimatedDelivery.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTrackOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTrackOrder.ResumeLayout(false);
            this.grpTrackOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpTrackOrder;
        private System.Windows.Forms.Label lblOrderIdTitle;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEstiDTitle;
        private System.Windows.Forms.Label lblEstimatedDelivery;
    }
}

