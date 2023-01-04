namespace InventoryManagment
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
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textBoxDeleteID = new System.Windows.Forms.TextBox();
            this.textBoxAttribute = new System.Windows.Forms.TextBox();
            this.textBoxEditID = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.lblAttribute = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblnewInput = new System.Windows.Forms.Label();
            this.buttonCustomerForm = new System.Windows.Forms.Button();
            this.buttonOrdersForm = new System.Windows.Forms.Button();
            this.buttonProfits = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(71, 106);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(114, 36);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(286, 106);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 36);
            this.textBoxPrice.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(204, 109);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 16);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "SinglePrice";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(414, 109);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inventory";
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
            this.buttonDelete.Location = new System.Drawing.Point(524, 230);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "deleteByID";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(524, 302);
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
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(673, 106);
            this.textBoxQuantity.Multiline = true;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 36);
            this.textBoxQuantity.TabIndex = 14;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(614, 109);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 16);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "quantity";
            // 
            // textBoxDeleteID
            // 
            this.textBoxDeleteID.Location = new System.Drawing.Point(626, 231);
            this.textBoxDeleteID.Name = "textBoxDeleteID";
            this.textBoxDeleteID.Size = new System.Drawing.Size(45, 22);
            this.textBoxDeleteID.TabIndex = 16;
            // 
            // textBoxAttribute
            // 
            this.textBoxAttribute.Location = new System.Drawing.Point(617, 302);
            this.textBoxAttribute.Name = "textBoxAttribute";
            this.textBoxAttribute.Size = new System.Drawing.Size(62, 22);
            this.textBoxAttribute.TabIndex = 17;
            // 
            // textBoxEditID
            // 
            this.textBoxEditID.Location = new System.Drawing.Point(617, 330);
            this.textBoxEditID.Name = "textBoxEditID";
            this.textBoxEditID.Size = new System.Drawing.Size(62, 22);
            this.textBoxEditID.TabIndex = 18;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(617, 358);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(62, 22);
            this.textBoxInput.TabIndex = 19;
            // 
            // lblAttribute
            // 
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Location = new System.Drawing.Point(689, 305);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(99, 16);
            this.lblAttribute.TabIndex = 20;
            this.lblAttribute.Text = "ProductFeature";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(689, 333);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            // 
            // lblnewInput
            // 
            this.lblnewInput.AutoSize = true;
            this.lblnewInput.Location = new System.Drawing.Point(689, 361);
            this.lblnewInput.Name = "lblnewInput";
            this.lblnewInput.Size = new System.Drawing.Size(35, 16);
            this.lblnewInput.TabIndex = 22;
            this.lblnewInput.Text = "input";
            // 
            // buttonCustomerForm
            // 
            this.buttonCustomerForm.Location = new System.Drawing.Point(27, 29);
            this.buttonCustomerForm.Name = "buttonCustomerForm";
            this.buttonCustomerForm.Size = new System.Drawing.Size(138, 36);
            this.buttonCustomerForm.TabIndex = 23;
            this.buttonCustomerForm.Text = "Go to Customers";
            this.buttonCustomerForm.UseVisualStyleBackColor = true;
            this.buttonCustomerForm.Click += new System.EventHandler(this.buttonCustomerForm_Click);
            // 
            // buttonOrdersForm
            // 
            this.buttonOrdersForm.Location = new System.Drawing.Point(673, 29);
            this.buttonOrdersForm.Name = "buttonOrdersForm";
            this.buttonOrdersForm.Size = new System.Drawing.Size(100, 46);
            this.buttonOrdersForm.TabIndex = 24;
            this.buttonOrdersForm.Text = "Go to Orders";
            this.buttonOrdersForm.UseVisualStyleBackColor = true;
            this.buttonOrdersForm.Click += new System.EventHandler(this.buttonOrdersForm_Click);
            // 
            // buttonProfits
            // 
            this.buttonProfits.Location = new System.Drawing.Point(542, 30);
            this.buttonProfits.Name = "buttonProfits";
            this.buttonProfits.Size = new System.Drawing.Size(100, 46);
            this.buttonProfits.TabIndex = 25;
            this.buttonProfits.Text = "Go to Profits";
            this.buttonProfits.UseVisualStyleBackColor = true;
            this.buttonProfits.Click += new System.EventHandler(this.buttonProfits_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(524, 398);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 26;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "meyve ",
            "sebze"});
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "kuru meyve ",
            "taze meyve",
            "kuru sebze",
            "taze sebze"});
            this.comboBoxCategory.Location = new System.Drawing.Point(478, 106);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategory.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonProfits);
            this.Controls.Add(this.buttonOrdersForm);
            this.Controls.Add(this.buttonCustomerForm);
            this.Controls.Add(this.lblnewInput);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAttribute);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxEditID);
            this.Controls.Add(this.textBoxAttribute);
            this.Controls.Add(this.textBoxDeleteID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textBoxDeleteID;
        private System.Windows.Forms.TextBox textBoxAttribute;
        private System.Windows.Forms.TextBox textBoxEditID;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label lblAttribute;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblnewInput;
        private System.Windows.Forms.Button buttonCustomerForm;
        private System.Windows.Forms.Button buttonOrdersForm;
        private System.Windows.Forms.Button buttonProfits;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}

