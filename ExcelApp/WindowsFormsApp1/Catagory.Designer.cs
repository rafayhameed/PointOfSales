namespace WindowsFormsApp1
{
    partial class Catagory
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.purchaseText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sellingText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(12, 46);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(143, 20);
            this.nameText.TabIndex = 0;
            // 
            // purchaseText
            // 
            this.purchaseText.Location = new System.Drawing.Point(176, 46);
            this.purchaseText.Name = "purchaseText";
            this.purchaseText.Size = new System.Drawing.Size(134, 20);
            this.purchaseText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purchase Cost";
            // 
            // sellingText
            // 
            this.sellingText.Location = new System.Drawing.Point(332, 46);
            this.sellingText.Name = "sellingText";
            this.sellingText.Size = new System.Drawing.Size(134, 20);
            this.sellingText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selling Cost";
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(481, 46);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(134, 20);
            this.quantityText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Addbutton.Location = new System.Drawing.Point(218, 92);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(109, 34);
            this.Addbutton.TabIndex = 8;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(635, 46);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(134, 20);
            this.codeBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Item Code";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(616, 92);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.HotPink;
            this.clearButton.Location = new System.Drawing.Point(374, 92);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 34);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Catagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 167);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellingText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchaseText);
            this.Controls.Add(this.nameText);
            this.Name = "Catagory";
            this.Text = "Catagory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox purchaseText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sellingText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button clearButton;
    }
}