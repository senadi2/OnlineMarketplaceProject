namespace Dispute_Resolution
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
            this.lblDisputeResolution = new System.Windows.Forms.Label();
            this.lvComplaints = new System.Windows.Forms.ListView();
            this.colComplaints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisputeResolution
            // 
            this.lblDisputeResolution.AutoSize = true;
            this.lblDisputeResolution.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisputeResolution.Location = new System.Drawing.Point(534, 112);
            this.lblDisputeResolution.Name = "lblDisputeResolution";
            this.lblDisputeResolution.Size = new System.Drawing.Size(280, 34);
            this.lblDisputeResolution.TabIndex = 0;
            this.lblDisputeResolution.Text = "Dispute Resolution";
            // 
            // lvComplaints
            // 
            this.lvComplaints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colComplaints});
            this.lvComplaints.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvComplaints.FullRowSelect = true;
            this.lvComplaints.GridLines = true;
            this.lvComplaints.HideSelection = false;
            this.lvComplaints.Location = new System.Drawing.Point(473, 214);
            this.lvComplaints.Name = "lvComplaints";
            this.lvComplaints.Size = new System.Drawing.Size(400, 97);
            this.lvComplaints.TabIndex = 1;
            this.lvComplaints.UseCompatibleStateImageBehavior = false;
            this.lvComplaints.View = System.Windows.Forms.View.Details;
            // 
            // colComplaints
            // 
            this.colComplaints.Text = "Complaints";
            this.colComplaints.Width = 140;
            // 
            // btnResolve
            // 
            this.btnResolve.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolve.Location = new System.Drawing.Point(514, 351);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(105, 32);
            this.btnResolve.TabIndex = 2;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            // 
            // btnDismiss
            // 
            this.btnDismiss.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDismiss.Location = new System.Drawing.Point(709, 350);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(105, 32);
            this.btnDismiss.TabIndex = 3;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 870);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.lvComplaints);
            this.Controls.Add(this.lblDisputeResolution);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisputeResolution;
        private System.Windows.Forms.ListView lvComplaints;
        private System.Windows.Forms.ColumnHeader colComplaints;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnDismiss;
    }
}

