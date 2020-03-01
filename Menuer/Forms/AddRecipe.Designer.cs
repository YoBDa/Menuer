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
            this.label3 = new System.Windows.Forms.Label();
            this.cbNoon = new System.Windows.Forms.CheckBox();
            this.cbMorning = new System.Windows.Forms.CheckBox();
            this.cbEvening = new System.Windows.Forms.CheckBox();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btAddRecipe = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.panAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(91, 14);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
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
            this.panAdd.Controls.Add(this.btAddProduct);
            this.panAdd.Controls.Add(this.label8);
            this.panAdd.Controls.Add(this.tbImportace);
            this.panAdd.Controls.Add(this.label7);
            this.panAdd.Controls.Add(this.label6);
            this.panAdd.Controls.Add(this.tbAmount);
            this.panAdd.Controls.Add(this.label5);
            this.panAdd.Controls.Add(this.label4);
            this.panAdd.Controls.Add(this.cbName);
            this.panAdd.Location = new System.Drawing.Point(390, 45);
            this.panAdd.Name = "panAdd";
            this.panAdd.Size = new System.Drawing.Size(343, 49);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ингредиенты:";
            // 
            // cbNoon
            // 
            this.cbNoon.AutoSize = true;
            this.cbNoon.Location = new System.Drawing.Point(197, 44);
            this.cbNoon.Name = "cbNoon";
            this.cbNoon.Size = new System.Drawing.Size(64, 21);
            this.cbNoon.TabIndex = 7;
            this.cbNoon.Text = "День";
            this.cbNoon.UseVisualStyleBackColor = true;
            // 
            // cbMorning
            // 
            this.cbMorning.AutoSize = true;
            this.cbMorning.Location = new System.Drawing.Point(129, 44);
            this.cbMorning.Name = "cbMorning";
            this.cbMorning.Size = new System.Drawing.Size(62, 21);
            this.cbMorning.TabIndex = 8;
            this.cbMorning.Text = "Утро";
            this.cbMorning.UseVisualStyleBackColor = true;
            // 
            // cbEvening
            // 
            this.cbEvening.AutoSize = true;
            this.cbEvening.Location = new System.Drawing.Point(267, 44);
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
            this.lbProducts.Location = new System.Drawing.Point(390, 100);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(343, 340);
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
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 482);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAddRecipe);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.cbEvening);
            this.Controls.Add(this.cbMorning);
            this.Controls.Add(this.cbNoon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panAdd);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "AddRecipe";
            this.Text = "AddRecipe";
            this.Load += new System.EventHandler(this.AddRecipe_Load);
            this.panAdd.ResumeLayout(false);
            this.panAdd.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbNoon;
        private System.Windows.Forms.CheckBox cbMorning;
        private System.Windows.Forms.CheckBox cbEvening;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Button btAddRecipe;
        private System.Windows.Forms.Button btCancel;
    }
}