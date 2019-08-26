namespace WindowsFormsApp1
{
    partial class TransReport
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
            this.Generate = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.EndLabel = new System.Windows.Forms.Label();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.radioButtonPeriod = new System.Windows.Forms.RadioButton();
            this.itemsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(101, 226);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(83, 56);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(19, 56);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(30, 13);
            this.startLabel.TabIndex = 2;
            this.startLabel.Text = "Date";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(83, 111);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.Visible = false;
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(19, 117);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(52, 13);
            this.EndLabel.TabIndex = 4;
            this.EndLabel.Text = "End Date";
            this.EndLabel.Visible = false;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(40, 21);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSingle.TabIndex = 5;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            this.radioButtonSingle.Click += new System.EventHandler(this.radioButtonSingle_CheckedChanged);
            // 
            // radioButtonPeriod
            // 
            this.radioButtonPeriod.AutoSize = true;
            this.radioButtonPeriod.Location = new System.Drawing.Point(140, 21);
            this.radioButtonPeriod.Name = "radioButtonPeriod";
            this.radioButtonPeriod.Size = new System.Drawing.Size(55, 17);
            this.radioButtonPeriod.TabIndex = 6;
            this.radioButtonPeriod.TabStop = true;
            this.radioButtonPeriod.Text = "Period";
            this.radioButtonPeriod.UseVisualStyleBackColor = true;
            this.radioButtonPeriod.Click += new System.EventHandler(this.radioButtonPeriod_CheckedChanged);
            // 
            // itemsComboBox
            // 
            this.itemsComboBox.FormattingEnabled = true;
            this.itemsComboBox.Location = new System.Drawing.Point(83, 169);
            this.itemsComboBox.Name = "itemsComboBox";
            this.itemsComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemsComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Items List";
            // 
            // TransReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemsComboBox);
            this.Controls.Add(this.radioButtonPeriod);
            this.Controls.Add(this.radioButtonSingle);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.Generate);
            this.Name = "TransReport";
            this.Text = "TransReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.RadioButton radioButtonPeriod;
        private System.Windows.Forms.ComboBox itemsComboBox;
        private System.Windows.Forms.Label label1;
    }
}