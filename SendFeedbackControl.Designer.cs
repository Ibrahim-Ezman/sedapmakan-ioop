namespace SedapMakanSystem
{
    partial class SendFeedbackControl
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
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.lblFeedbackStatusMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Us Your Feedback";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(183, 69);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(281, 128);
            this.txtFeedback.TabIndex = 1;
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Location = new System.Drawing.Point(183, 221);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(281, 23);
            this.btnSubmitFeedback.TabIndex = 2;
            this.btnSubmitFeedback.Text = "btnSubmitFeedback";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            // 
            // lblFeedbackStatusMsg
            // 
            this.lblFeedbackStatusMsg.AutoSize = true;
            this.lblFeedbackStatusMsg.Location = new System.Drawing.Point(264, 271);
            this.lblFeedbackStatusMsg.Name = "lblFeedbackStatusMsg";
            this.lblFeedbackStatusMsg.Size = new System.Drawing.Size(115, 13);
            this.lblFeedbackStatusMsg.TabIndex = 3;
            this.lblFeedbackStatusMsg.Text = "lblFeedbackStatusMsg";
            // 
            // SendFeedbackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFeedbackStatusMsg);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.label1);
            this.Name = "SendFeedbackControl";
            this.Size = new System.Drawing.Size(653, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmitFeedback;
        private System.Windows.Forms.Label lblFeedbackStatusMsg;
    }
}
