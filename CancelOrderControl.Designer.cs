namespace SedapMakanSystem
{
    partial class CancelOrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCancellableOrders = new System.Windows.Forms.DataGridView();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnRequestCancellation = new System.Windows.Forms.Button();
            this.lblCancellationStatusMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancellableOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancel Order / Request Refund";
            // 
            // dgvCancellableOrders
            // 
            this.dgvCancellableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancellableOrders.Location = new System.Drawing.Point(78, 56);
            this.dgvCancellableOrders.Name = "dgvCancellableOrders";
            this.dgvCancellableOrders.Size = new System.Drawing.Size(407, 208);
            this.dgvCancellableOrders.TabIndex = 1;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(92, 71);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(380, 20);
            this.txtReason.TabIndex = 2;
            // 
            // btnRequestCancellation
            // 
            this.btnRequestCancellation.Location = new System.Drawing.Point(92, 222);
            this.btnRequestCancellation.Name = "btnRequestCancellation";
            this.btnRequestCancellation.Size = new System.Drawing.Size(180, 23);
            this.btnRequestCancellation.TabIndex = 3;
            this.btnRequestCancellation.Text = "btnRequestCancellation";
            this.btnRequestCancellation.UseVisualStyleBackColor = true;
            // 
            // lblCancellationStatusMsg
            // 
            this.lblCancellationStatusMsg.AutoSize = true;
            this.lblCancellationStatusMsg.Location = new System.Drawing.Point(278, 232);
            this.lblCancellationStatusMsg.Name = "lblCancellationStatusMsg";
            this.lblCancellationStatusMsg.Size = new System.Drawing.Size(125, 13);
            this.lblCancellationStatusMsg.TabIndex = 4;
            this.lblCancellationStatusMsg.Text = "lblCancellationStatusMsg";
            // 
            // CancelOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCancellationStatusMsg);
            this.Controls.Add(this.btnRequestCancellation);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.dgvCancellableOrders);
            this.Controls.Add(this.label1);
            this.Name = "CancelOrderControl";
            this.Size = new System.Drawing.Size(587, 317);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancellableOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCancellableOrders;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnRequestCancellation;
        private System.Windows.Forms.Label lblCancellationStatusMsg;
    }
}
