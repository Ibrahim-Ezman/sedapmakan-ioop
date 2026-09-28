namespace SedapMakanSystem
{
    partial class BrowseOrderControl
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
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddtocart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEWallet = new System.Windows.Forms.Label();
            this.lblOrderStatusMsg = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse Menu & Place Order";
            // 
            // cboCategories
            // 
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(63, 66);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(377, 21);
            this.cboCategories.TabIndex = 1;
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Location = new System.Drawing.Point(63, 117);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.Size = new System.Drawing.Size(129, 144);
            this.dgvMenuItems.TabIndex = 2;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(334, 117);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 3;
            // 
            // btnAddtocart
            // 
            this.btnAddtocart.Location = new System.Drawing.Point(334, 157);
            this.btnAddtocart.Name = "btnAddtocart";
            this.btnAddtocart.Size = new System.Drawing.Size(106, 23);
            this.btnAddtocart.TabIndex = 4;
            this.btnAddtocart.Text = "btnAddtocart";
            this.btnAddtocart.UseVisualStyleBackColor = true;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(198, 117);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(133, 144);
            this.dgvCart.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(63, 268);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "lblTotal";
            // 
            // lblEWallet
            // 
            this.lblEWallet.AutoSize = true;
            this.lblEWallet.Location = new System.Drawing.Point(63, 285);
            this.lblEWallet.Name = "lblEWallet";
            this.lblEWallet.Size = new System.Drawing.Size(54, 13);
            this.lblEWallet.TabIndex = 7;
            this.lblEWallet.Text = "lblEWallet";
            // 
            // lblOrderStatusMsg
            // 
            this.lblOrderStatusMsg.AutoSize = true;
            this.lblOrderStatusMsg.Location = new System.Drawing.Point(63, 302);
            this.lblOrderStatusMsg.Name = "lblOrderStatusMsg";
            this.lblOrderStatusMsg.Size = new System.Drawing.Size(93, 13);
            this.lblOrderStatusMsg.TabIndex = 8;
            this.lblOrderStatusMsg.Text = "lblOrderStatusMsg";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(334, 268);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(106, 23);
            this.btnConfirmOrder.TabIndex = 9;
            this.btnConfirmOrder.Text = "btnConfirmOrder";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            // 
            // BrowseOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.lblOrderStatusMsg);
            this.Controls.Add(this.lblEWallet);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnAddtocart);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.cboCategories);
            this.Controls.Add(this.label1);
            this.Name = "BrowseOrderControl";
            this.Size = new System.Drawing.Size(511, 351);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddtocart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEWallet;
        private System.Windows.Forms.Label lblOrderStatusMsg;
        private System.Windows.Forms.Button btnConfirmOrder;
    }
}
