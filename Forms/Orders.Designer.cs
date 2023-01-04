namespace InventoryManagment.Forms
{
    partial class Orders
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
            this.components = new System.ComponentModel.Container();
            this.textBoxPoductID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.lblPaymentValue = new System.Windows.Forms.Label();
            this.textBoxDeleteID = new System.Windows.Forms.TextBox();
            this.textBoxAttribute = new System.Windows.Forms.TextBox();
            this.textBoxEditID = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.lblAttribute = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblnewInput = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.buttonShipOrder = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblShipID = new System.Windows.Forms.Label();
            this.textBoxShipID = new System.Windows.Forms.TextBox();
            this.lblProfitDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPoductID
            // 
            this.textBoxPoductID.Location = new System.Drawing.Point(71, 106);
            this.textBoxPoductID.Multiline = true;
            this.textBoxPoductID.Name = "textBoxPoductID";
            this.textBoxPoductID.Size = new System.Drawing.Size(114, 36);
            this.textBoxPoductID.TabIndex = 3;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(286, 106);
            this.textBoxCustomerID.Multiline = true;
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 36);
            this.textBoxCustomerID.TabIndex = 4;
            // 
            // textBoxProductQuantity
            // 
            this.textBoxProductQuantity.Location = new System.Drawing.Point(499, 106);
            this.textBoxProductQuantity.Multiline = true;
            this.textBoxProductQuantity.Name = "textBoxProductQuantity";
            this.textBoxProductQuantity.Size = new System.Drawing.Size(100, 36);
            this.textBoxProductQuantity.TabIndex = 5;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(-1, 109);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(66, 16);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "ProductID";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(203, 109);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(77, 16);
            this.lblCustomerID.TabIndex = 7;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(392, 109);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(101, 16);
            this.lblProductQuantity.TabIndex = 8;
            this.lblProductQuantity.Text = "ProductQuantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Orders";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(71, 179);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(508, 388);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "deleteByID";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(530, 231);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 230);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(488, 208);
            this.dataGridView.TabIndex = 13;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(679, 106);
            this.textBoxPayment.Multiline = true;
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(100, 36);
            this.textBoxPayment.TabIndex = 14;
            // 
            // lblPaymentValue
            // 
            this.lblPaymentValue.AutoSize = true;
            this.lblPaymentValue.Location = new System.Drawing.Point(613, 109);
            this.lblPaymentValue.Name = "lblPaymentValue";
            this.lblPaymentValue.Size = new System.Drawing.Size(60, 16);
            this.lblPaymentValue.TabIndex = 15;
            this.lblPaymentValue.Text = "Payment";
            // 
            // textBoxDeleteID
            // 
            this.textBoxDeleteID.Location = new System.Drawing.Point(610, 389);
            this.textBoxDeleteID.Name = "textBoxDeleteID";
            this.textBoxDeleteID.Size = new System.Drawing.Size(49, 22);
            this.textBoxDeleteID.TabIndex = 16;
            // 
            // textBoxAttribute
            // 
            this.textBoxAttribute.Location = new System.Drawing.Point(611, 231);
            this.textBoxAttribute.Name = "textBoxAttribute";
            this.textBoxAttribute.Size = new System.Drawing.Size(62, 22);
            this.textBoxAttribute.TabIndex = 17;
            // 
            // textBoxEditID
            // 
            this.textBoxEditID.Location = new System.Drawing.Point(611, 259);
            this.textBoxEditID.Name = "textBoxEditID";
            this.textBoxEditID.Size = new System.Drawing.Size(62, 22);
            this.textBoxEditID.TabIndex = 18;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(611, 287);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(62, 22);
            this.textBoxInput.TabIndex = 19;
            // 
            // lblAttribute
            // 
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Location = new System.Drawing.Point(679, 234);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(87, 16);
            this.lblAttribute.TabIndex = 20;
            this.lblAttribute.Text = "OrderFeature";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(679, 262);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            // 
            // lblnewInput
            // 
            this.lblnewInput.AutoSize = true;
            this.lblnewInput.Location = new System.Drawing.Point(679, 290);
            this.lblnewInput.Name = "lblnewInput";
            this.lblnewInput.Size = new System.Drawing.Size(35, 16);
            this.lblnewInput.TabIndex = 22;
            this.lblnewInput.Text = "input";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(286, 166);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(96, 36);
            this.textBoxName.TabIndex = 23;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(239, 169);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 16);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "name";
            // 
            // buttonShipOrder
            // 
            this.buttonShipOrder.Location = new System.Drawing.Point(513, 335);
            this.buttonShipOrder.Name = "buttonShipOrder";
            this.buttonShipOrder.Size = new System.Drawing.Size(91, 23);
            this.buttonShipOrder.TabIndex = 27;
            this.buttonShipOrder.Text = "Ship Order";
            this.buttonShipOrder.UseVisualStyleBackColor = true;
            this.buttonShipOrder.Click += new System.EventHandler(this.buttonShipOrder_Click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(613, 29);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(37, 16);
            this.lblProfit.TabIndex = 28;
            this.lblProfit.Text = "Profit";
            // 
            // lblShipID
            // 
            this.lblShipID.AutoSize = true;
            this.lblShipID.Location = new System.Drawing.Point(680, 338);
            this.lblShipID.Name = "lblShipID";
            this.lblShipID.Size = new System.Drawing.Size(20, 16);
            this.lblShipID.TabIndex = 29;
            this.lblShipID.Text = "ID";
            // 
            // textBoxShipID
            // 
            this.textBoxShipID.Location = new System.Drawing.Point(610, 335);
            this.textBoxShipID.Name = "textBoxShipID";
            this.textBoxShipID.Size = new System.Drawing.Size(64, 22);
            this.textBoxShipID.TabIndex = 30;
            // 
            // lblProfitDisplay
            // 
            this.lblProfitDisplay.AutoSize = true;
            this.lblProfitDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitDisplay.Location = new System.Drawing.Point(667, 13);
            this.lblProfitDisplay.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblProfitDisplay.Name = "lblProfitDisplay";
            this.lblProfitDisplay.Size = new System.Drawing.Size(32, 36);
            this.lblProfitDisplay.TabIndex = 31;
            this.lblProfitDisplay.Text = "0";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProfitDisplay);
            this.Controls.Add(this.textBoxShipID);
            this.Controls.Add(this.lblShipID);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.buttonShipOrder);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblnewInput);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAttribute);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxEditID);
            this.Controls.Add(this.textBoxAttribute);
            this.Controls.Add(this.textBoxDeleteID);
            this.Controls.Add(this.lblPaymentValue);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.textBoxProductQuantity);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.textBoxPoductID);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPoductID;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxProductQuantity;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.Label lblPaymentValue;
        private System.Windows.Forms.TextBox textBoxDeleteID;
        private System.Windows.Forms.TextBox textBoxAttribute;
        private System.Windows.Forms.TextBox textBoxEditID;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label lblAttribute;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblnewInput;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button buttonShipOrder;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblShipID;
        private System.Windows.Forms.TextBox textBoxShipID;
        private System.Windows.Forms.Label lblProfitDisplay;
    }
}