namespace Menuer.Forms
{
    partial class AddRecipe
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.panAdd = new System.Windows.Forms.Panel();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbImportace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbNoon = new System.Windows.Forms.CheckBox();
            this.cbMorning = new System.Windows.Forms.CheckBox();
            this.cbEvening = new System.Windows.Forms.CheckBox();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btAddRecipe = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.nudTime2Cook = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btRemoveProduct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime2Cook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(91, 14);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(184, 22);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 65);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(359, 375);
            this.tbDescription.TabIndex = 4;
            this.tbDescription.Text = "";
            // 
            // panAdd
            // 
            this.panAdd.Controls.Add(this.btRemoveProduct);
            this.panAdd.Controls.Add(this.btAddProduct);
            this.panAdd.Controls.Add(this.label8);
            this.panAdd.Controls.Add(this.tbImportace);
            this.panAdd.Controls.Add(this.label7);
            this.panAdd.Controls.Add(this.label6);
            this.panAdd.Controls.Add(this.tbAmount);
            this.panAdd.Controls.Add(this.label5);
            this.panAdd.Controls.Add(this.label4);
            this.panAdd.Controls.Add(this.cbName);
            this.panAdd.Location = new System.Drawing.Point(13, 21);
            this.panAdd.Name = "panAdd";
            this.panAdd.Size = new System.Drawing.Size(392, 49);
            this.panAdd.TabIndex = 5;
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(299, 3);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(41, 43);
            this.btAddProduct.TabIndex = 8;
            this.btAddProduct.Text = " +";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.BtAddProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "%";
            // 
            // tbImportace
            // 
            this.tbImportace.Location = new System.Drawing.Point(213, 22);
            this.tbImportace.Name = "tbImportace";
            this.tbImportace.Size = new System.Drawing.Size(54, 22);
            this.tbImportace.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Важность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Штук";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(112, 22);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(54, 22);
            this.tbAmount.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Кол-во:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Название:";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(3, 20);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(94, 24);
            this.cbName.TabIndex = 0;
            // 
            // cbNoon
            // 
            this.cbNoon.AutoSize = true;
            this.cbNoon.Location = new System.Drawing.Point(85, 18);
            this.cbNoon.Name = "cbNoon";
            this.cbNoon.Size = new System.Drawing.Size(64, 21);
            this.cbNoon.TabIndex = 7;
            this.cbNoon.Text = "День";
            this.cbNoon.UseVisualStyleBackColor = true;
            // 
            // cbMorning
            // 
            this.cbMorning.AutoSize = true;
            this.cbMorning.Location = new System.Drawing.Point(17, 18);
            this.cbMorning.Name = "cbMorning";
            this.cbMorning.Size = new System.Drawing.Size(62, 21);
            this.cbMorning.TabIndex = 8;
            this.cbMorning.Text = "Утро";
            this.cbMorning.UseVisualStyleBackColor = true;
            // 
            // cbEvening
            // 
            this.cbEvening.AutoSize = true;
            this.cbEvening.Location = new System.Drawing.Point(155, 18);
            this.cbEvening.Name = "cbEvening";
            this.cbEvening.Size = new System.Drawing.Size(71, 21);
            this.cbEvening.TabIndex = 9;
            this.cbEvening.Text = "Вечер";
            this.cbEvening.UseVisualStyleBackColor = true;
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 16;
            this.lbProducts.Location = new System.Drawing.Point(13, 74);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(392, 292);
            this.lbProducts.TabIndex = 10;
            // 
            // btAddRecipe
            // 
            this.btAddRecipe.Location = new System.Drawing.Point(547, 446);
            this.btAddRecipe.Name = "btAddRecipe";
            this.btAddRecipe.Size = new System.Drawing.Size(90, 32);
            this.btAddRecipe.TabIndex = 11;
            this.btAddRecipe.Text = "Добавить";
            this.btAddRecipe.UseVisualStyleBackColor = true;
            this.btAddRecipe.Click += new System.EventHandler(this.BtAddRecipe_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(643, 446);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(90, 32);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // nudTime2Cook
            // 
            this.nudTime2Cook.Location = new System.Drawing.Point(685, 7);
            this.nudTime2Cook.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudTime2Cook.Name = "nudTime2Cook";
            this.nudTime2Cook.Size = new System.Drawing.Size(52, 22);
            this.nudTime2Cook.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 14;
            // 
            // btRemoveProduct
            // 
            this.btRemoveProduct.Location = new System.Drawing.Point(346, 3);
            this.btRemoveProduct.Name = "btRemoveProduct";
            this.btRemoveProduct.Size = new System.Drawing.Size(41, 43);
            this.btRemoveProduct.TabIndex = 9;
            this.btRemoveProduct.Text = " -";
            this.btRemoveProduct.UseVisualStyleBackColor = true;
            this.btRemoveProduct.Click += new System.EventHandler(this.BtRemoveProduct_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(526, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Время приготовления:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(743, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Мин.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMorning);
            this.groupBox1.Controls.Add(this.cbNoon);
            this.groupBox1.Controls.Add(this.cbEvening);
            this.groupBox1.Location = new System.Drawing.Point(281, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 50);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Время суток:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Категория:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(613, 34);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(169, 24);
            this.cbCategory.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panAdd);
            this.groupBox2.Controls.Add(this.lbProducts);
            this.groupBox2.Location = new System.Drawing.Point(377, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 375);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ингредиенты:";
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudTime2Cook);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAddRecipe);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "AddRecipe";
            this.Text = "AddRecipe";
            this.Load += new System.EventHandler(this.AddRecipe_Load);
            this.panAdd.ResumeLayout(false);
            this.panAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime2Cook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Panel panAdd;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbImportace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.CheckBox cbNoon;
        private System.Windows.Forms.CheckBox cbMorning;
        private System.Windows.Forms.CheckBox cbEvening;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Button btAddRecipe;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRemoveProduct;
        private System.Windows.Forms.NumericUpDown nudTime2Cook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}