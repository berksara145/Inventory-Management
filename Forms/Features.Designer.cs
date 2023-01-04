namespace InventoryManagment.Forms
{
    partial class Features
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDisplayProfits = new System.Windows.Forms.Button();
            this.HistoryOfTransactions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCategories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(122, 160);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(580, 201);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(364, 391);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 33);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDisplayProfits
            // 
            this.buttonDisplayProfits.Location = new System.Drawing.Point(42, 93);
            this.buttonDisplayProfits.Name = "buttonDisplayProfits";
            this.buttonDisplayProfits.Size = new System.Drawing.Size(162, 48);
            this.buttonDisplayProfits.TabIndex = 2;
            this.buttonDisplayProfits.Text = "ProfitsFromCustomers";
            this.buttonDisplayProfits.UseVisualStyleBackColor = true;
            this.buttonDisplayProfits.Click += new System.EventHandler(this.buttonDisplayProfits_Click);
            // 
            // HistoryOfTransactions
            // 
            this.HistoryOfTransactions.Location = new System.Drawing.Point(262, 93);
            this.HistoryOfTransactions.Name = "HistoryOfTransactions";
            this.HistoryOfTransactions.Size = new System.Drawing.Size(162, 48);
            this.HistoryOfTransactions.TabIndex = 3;
            this.HistoryOfTransactions.Text = "History";
            this.HistoryOfTransactions.UseVisualStyleBackColor = true;
            this.HistoryOfTransactions.Click += new System.EventHandler(this.HistoryOfTransactions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Features";
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(469, 93);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(162, 48);
            this.buttonCategories.TabIndex = 5;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistoryOfTransactions);
            this.Controls.Add(this.buttonDisplayProfits);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridView);
            this.Name = "Features";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDisplayProfits;
        private System.Windows.Forms.Button HistoryOfTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCategories;
    }
}