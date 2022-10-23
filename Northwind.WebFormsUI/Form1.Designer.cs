
namespace Northwind.WebFormsUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.grpEvents = new System.Windows.Forms.GroupBox();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtUnitsInStockAction = new System.Windows.Forms.TextBox();
            this.txtQuantityPerUnitAction = new System.Windows.Forms.TextBox();
            this.txtUnitPriceAction = new System.Windows.Forms.TextBox();
            this.cmbCategoryAction = new System.Windows.Forms.ComboBox();
            this.txtProductNameAction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.grpEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1381, 50);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İsmine Göre Ara";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(3, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1375, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1381, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriye Göre Listele";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(3, 18);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(1375, 24);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 303);
            this.panel1.TabIndex = 4;
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwProduct.Location = new System.Drawing.Point(0, 0);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1381, 303);
            this.dgwProduct.TabIndex = 2;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // grpEvents
            // 
            this.grpEvents.Controls.Add(this.rbDelete);
            this.grpEvents.Controls.Add(this.rbUpdate);
            this.grpEvents.Controls.Add(this.rbInsert);
            this.grpEvents.Controls.Add(this.btnProcess);
            this.grpEvents.Controls.Add(this.txtUnitsInStockAction);
            this.grpEvents.Controls.Add(this.txtQuantityPerUnitAction);
            this.grpEvents.Controls.Add(this.txtUnitPriceAction);
            this.grpEvents.Controls.Add(this.cmbCategoryAction);
            this.grpEvents.Controls.Add(this.txtProductNameAction);
            this.grpEvents.Controls.Add(this.label5);
            this.grpEvents.Controls.Add(this.label4);
            this.grpEvents.Controls.Add(this.label3);
            this.grpEvents.Controls.Add(this.label2);
            this.grpEvents.Controls.Add(this.label1);
            this.grpEvents.Location = new System.Drawing.Point(51, 438);
            this.grpEvents.Name = "grpEvents";
            this.grpEvents.Size = new System.Drawing.Size(928, 165);
            this.grpEvents.TabIndex = 5;
            this.grpEvents.TabStop = false;
            this.grpEvents.Text = "ÜRÜN EKLE";
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(637, 111);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(49, 21);
            this.rbDelete.TabIndex = 12;
            this.rbDelete.Text = "SİL";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbAction);
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(637, 72);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(103, 21);
            this.rbUpdate.TabIndex = 11;
            this.rbUpdate.Text = "GÜNCELLE";
            this.rbUpdate.UseVisualStyleBackColor = true;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbAction);
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Location = new System.Drawing.Point(637, 35);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(64, 21);
            this.rbInsert.TabIndex = 10;
            this.rbInsert.Text = "EKLE";
            this.rbInsert.UseVisualStyleBackColor = true;
            this.rbInsert.CheckedChanged += new System.EventHandler(this.rbAction);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(778, 34);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(127, 98);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "Tamam";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtUnitsInStockAction
            // 
            this.txtUnitsInStockAction.Location = new System.Drawing.Point(463, 35);
            this.txtUnitsInStockAction.Name = "txtUnitsInStockAction";
            this.txtUnitsInStockAction.Size = new System.Drawing.Size(121, 22);
            this.txtUnitsInStockAction.TabIndex = 8;
            // 
            // txtQuantityPerUnitAction
            // 
            this.txtQuantityPerUnitAction.Location = new System.Drawing.Point(463, 76);
            this.txtQuantityPerUnitAction.Name = "txtQuantityPerUnitAction";
            this.txtQuantityPerUnitAction.Size = new System.Drawing.Size(121, 22);
            this.txtQuantityPerUnitAction.TabIndex = 8;
            // 
            // txtUnitPriceAction
            // 
            this.txtUnitPriceAction.Location = new System.Drawing.Point(137, 118);
            this.txtUnitPriceAction.Name = "txtUnitPriceAction";
            this.txtUnitPriceAction.Size = new System.Drawing.Size(121, 22);
            this.txtUnitPriceAction.TabIndex = 7;
            // 
            // cmbCategoryAction
            // 
            this.cmbCategoryAction.FormattingEnabled = true;
            this.cmbCategoryAction.Location = new System.Drawing.Point(137, 81);
            this.cmbCategoryAction.Name = "cmbCategoryAction";
            this.cmbCategoryAction.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoryAction.TabIndex = 6;
            // 
            // txtProductNameAction
            // 
            this.txtProductNameAction.Location = new System.Drawing.Point(137, 41);
            this.txtProductNameAction.Name = "txtProductNameAction";
            this.txtProductNameAction.Size = new System.Drawing.Size(121, 22);
            this.txtProductNameAction.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birim Adedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Adeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 599);
            this.Controls.Add(this.grpEvents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "öö";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.grpEvents.ResumeLayout(false);
            this.grpEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox grpEvents;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtUnitsInStockAction;
        private System.Windows.Forms.TextBox txtQuantityPerUnitAction;
        private System.Windows.Forms.TextBox txtUnitPriceAction;
        private System.Windows.Forms.ComboBox cmbCategoryAction;
        private System.Windows.Forms.TextBox txtProductNameAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.RadioButton rbDelete;
    }
}

