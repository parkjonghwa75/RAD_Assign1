namespace RAD_Assignment1
{
    partial class AutoCenter
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.navigationCheckBox = new System.Windows.Forms.CheckBox();
            this.leatherCheckBox = new System.Windows.Forms.CheckBox();
            this.stereoCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detailingRadio = new System.Windows.Forms.RadioButton();
            this.pearlizedRadio = new System.Windows.Forms.RadioButton();
            this.standardRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.carSalesPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accessoriesFinishTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.tradeinAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.amountDueTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WP Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "VB Auto Center";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.navigationCheckBox);
            this.groupBox1.Controls.Add(this.leatherCheckBox);
            this.groupBox1.Controls.Add(this.stereoCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accessories";
            // 
            // navigationCheckBox
            // 
            this.navigationCheckBox.AutoSize = true;
            this.navigationCheckBox.Location = new System.Drawing.Point(18, 108);
            this.navigationCheckBox.Name = "navigationCheckBox";
            this.navigationCheckBox.Size = new System.Drawing.Size(125, 17);
            this.navigationCheckBox.TabIndex = 2;
            this.navigationCheckBox.Text = "Computer &Navigation";
            this.navigationCheckBox.UseVisualStyleBackColor = true;
            // 
            // leatherCheckBox
            // 
            this.leatherCheckBox.AutoSize = true;
            this.leatherCheckBox.Location = new System.Drawing.Point(18, 74);
            this.leatherCheckBox.Name = "leatherCheckBox";
            this.leatherCheckBox.Size = new System.Drawing.Size(97, 17);
            this.leatherCheckBox.TabIndex = 1;
            this.leatherCheckBox.Text = "Leather &Interior";
            this.leatherCheckBox.UseVisualStyleBackColor = true;
            // 
            // stereoCheckBox
            // 
            this.stereoCheckBox.AutoSize = true;
            this.stereoCheckBox.Location = new System.Drawing.Point(18, 37);
            this.stereoCheckBox.Name = "stereoCheckBox";
            this.stereoCheckBox.Size = new System.Drawing.Size(94, 17);
            this.stereoCheckBox.TabIndex = 0;
            this.stereoCheckBox.Text = "&Stereo System";
            this.stereoCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.detailingRadio);
            this.groupBox2.Controls.Add(this.pearlizedRadio);
            this.groupBox2.Controls.Add(this.standardRadio);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exterior Finish";
            // 
            // detailingRadio
            // 
            this.detailingRadio.AutoSize = true;
            this.detailingRadio.Location = new System.Drawing.Point(17, 110);
            this.detailingRadio.Name = "detailingRadio";
            this.detailingRadio.Size = new System.Drawing.Size(123, 17);
            this.detailingRadio.TabIndex = 2;
            this.detailingRadio.TabStop = true;
            this.detailingRadio.Text = "Customized &Detailing";
            this.detailingRadio.UseVisualStyleBackColor = true;
            this.detailingRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // pearlizedRadio
            // 
            this.pearlizedRadio.AutoSize = true;
            this.pearlizedRadio.Location = new System.Drawing.Point(17, 74);
            this.pearlizedRadio.Name = "pearlizedRadio";
            this.pearlizedRadio.Size = new System.Drawing.Size(68, 17);
            this.pearlizedRadio.TabIndex = 1;
            this.pearlizedRadio.TabStop = true;
            this.pearlizedRadio.Text = "&Pearlized";
            this.pearlizedRadio.UseVisualStyleBackColor = true;
            this.pearlizedRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // standardRadio
            // 
            this.standardRadio.AutoSize = true;
            this.standardRadio.Location = new System.Drawing.Point(17, 39);
            this.standardRadio.Name = "standardRadio";
            this.standardRadio.Size = new System.Drawing.Size(68, 17);
            this.standardRadio.TabIndex = 0;
            this.standardRadio.TabStop = true;
            this.standardRadio.Text = "S&tandard";
            this.standardRadio.UseVisualStyleBackColor = true;
            this.standardRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "C&ar Sales Price:";
            // 
            // carSalesPriceTextBox
            // 
            this.carSalesPriceTextBox.Location = new System.Drawing.Point(348, 69);
            this.carSalesPriceTextBox.Name = "carSalesPriceTextBox";
            this.carSalesPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.carSalesPriceTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Accessories & Finish:";
            // 
            // accessoriesFinishTextBox
            // 
            this.accessoriesFinishTextBox.Location = new System.Drawing.Point(348, 114);
            this.accessoriesFinishTextBox.Name = "accessoriesFinishTextBox";
            this.accessoriesFinishTextBox.ReadOnly = true;
            this.accessoriesFinishTextBox.Size = new System.Drawing.Size(100, 20);
            this.accessoriesFinishTextBox.TabIndex = 6;
            this.accessoriesFinishTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub Total:";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(348, 157);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subTotalTextBox.TabIndex = 8;
            this.subTotalTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sales Tax (15%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "T&rade-in Allowance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Amount Due:";
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(348, 201);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.salesTaxTextBox.TabIndex = 13;
            this.salesTaxTextBox.TabStop = false;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(348, 244);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 14;
            this.totalTextBox.TabStop = false;
            // 
            // tradeinAllowanceTextBox
            // 
            this.tradeinAllowanceTextBox.Location = new System.Drawing.Point(348, 295);
            this.tradeinAllowanceTextBox.Name = "tradeinAllowanceTextBox";
            this.tradeinAllowanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.tradeinAllowanceTextBox.TabIndex = 15;
            // 
            // amountDueTextBox
            // 
            this.amountDueTextBox.Location = new System.Drawing.Point(348, 331);
            this.amountDueTextBox.Name = "amountDueTextBox";
            this.amountDueTextBox.ReadOnly = true;
            this.amountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountDueTextBox.TabIndex = 16;
            this.amountDueTextBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(346, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Jong-Hwa (Jay) Park";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(196, 391);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(287, 391);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(378, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AutoCenter
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 459);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amountDueTextBox);
            this.Controls.Add(this.tradeinAllowanceTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accessoriesFinishTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carSalesPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AutoCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VB Auto Center";
            this.Load += new System.EventHandler(this.AutoCenter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox navigationCheckBox;
        private System.Windows.Forms.CheckBox leatherCheckBox;
        private System.Windows.Forms.CheckBox stereoCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton detailingRadio;
        private System.Windows.Forms.RadioButton pearlizedRadio;
        private System.Windows.Forms.RadioButton standardRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carSalesPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accessoriesFinishTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox tradeinAllowanceTextBox;
        private System.Windows.Forms.TextBox amountDueTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

