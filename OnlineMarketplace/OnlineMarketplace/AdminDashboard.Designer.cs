namespace OnlineMarketPlace
{
    partial class AdminDashboard
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
            this.lblAdminControlPanel = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnResolveDisputes = new System.Windows.Forms.Button();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminControlPanel
            // 
            this.lblAdminControlPanel.AutoSize = true;
            this.lblAdminControlPanel.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminControlPanel.Location = new System.Drawing.Point(465, 168);
            this.lblAdminControlPanel.Name = "lblAdminControlPanel";
            this.lblAdminControlPanel.Size = new System.Drawing.Size(313, 34);
            this.lblAdminControlPanel.TabIndex = 0;
            this.lblAdminControlPanel.Text = "Admin Control Panel";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(242, 263);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(195, 38);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(523, 263);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(195, 38);
            this.btnViewOrders.TabIndex = 2;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            // 
            // btnResolveDisputes
            // 
            this.btnResolveDisputes.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolveDisputes.Location = new System.Drawing.Point(798, 263);
            this.btnResolveDisputes.Name = "btnResolveDisputes";
            this.btnResolveDisputes.Size = new System.Drawing.Size(228, 38);
            this.btnResolveDisputes.TabIndex = 3;
            this.btnResolveDisputes.Text = "Resolve Disputes";
            this.btnResolveDisputes.UseVisualStyleBackColor = true;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifications.Location = new System.Drawing.Point(242, 418);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(195, 34);
            this.lblNotifications.TabIndex = 4;
            this.lblNotifications.Text = "Notifications";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(248, 560);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 38);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 889);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblNotifications);
            this.Controls.Add(this.btnResolveDisputes);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.lblAdminControlPanel);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminControlPanel;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnResolveDisputes;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Button btnLogout;
    }
}