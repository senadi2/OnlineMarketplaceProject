namespace OnlineMarketPlace
{
    partial class DisputeResolution
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
            this.lblDisputeResolution = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colComplaints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisputeResolution
            // 
            this.lblDisputeResolution.AutoSize = true;
            this.lblDisputeResolution.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisputeResolution.Location = new System.Drawing.Point(524, 131);
            this.lblDisputeResolution.Name = "lblDisputeResolution";
            this.lblDisputeResolution.Size = new System.Drawing.Size(290, 34);
            this.lblDisputeResolution.TabIndex = 0;
            this.lblDisputeResolution.Text = "Dispute Resolution ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colComplaints});
            this.listView1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(446, 247);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 141);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colComplaints
            // 
            this.colComplaints.Text = "Complaints";
            this.colComplaints.Width = 150;
            // 
            // btnResolve
            // 
            this.btnResolve.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolve.Location = new System.Drawing.Point(507, 438);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(128, 40);
            this.btnResolve.TabIndex = 2;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            // 
            // btnDismiss
            // 
            this.btnDismiss.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDismiss.Location = new System.Drawing.Point(686, 438);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(128, 40);
            this.btnDismiss.TabIndex = 3;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            // 
            // DisputeResolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 891);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblDisputeResolution);
            this.Name = "DisputeResolution";
            this.Text = "DisputeResolution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisputeResolution;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colComplaints;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnDismiss;
    }
}