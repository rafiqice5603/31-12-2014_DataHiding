namespace RefrigeratorWeightControlApp
{
    partial class RefrigeratorWeightControlUI
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
            this.noOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maxWeightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightEachTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.remainWeightTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of items";
            // 
            // noOfItemsTextBox
            // 
            this.noOfItemsTextBox.Location = new System.Drawing.Point(71, 101);
            this.noOfItemsTextBox.Name = "noOfItemsTextBox";
            this.noOfItemsTextBox.Size = new System.Drawing.Size(71, 20);
            this.noOfItemsTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maximum Weight it can take";
            // 
            // maxWeightTextBox
            // 
            this.maxWeightTextBox.Location = new System.Drawing.Point(165, 25);
            this.maxWeightTextBox.Name = "maxWeightTextBox";
            this.maxWeightTextBox.Size = new System.Drawing.Size(93, 20);
            this.maxWeightTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight(kg)/Unit";
            // 
            // weightEachTextBox
            // 
            this.weightEachTextBox.Location = new System.Drawing.Point(237, 104);
            this.weightEachTextBox.Name = "weightEachTextBox";
            this.weightEachTextBox.Size = new System.Drawing.Size(93, 20);
            this.weightEachTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current (Weight)";
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Enabled = false;
            this.currentWeightTextBox.Location = new System.Drawing.Point(96, 183);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(93, 20);
            this.currentWeightTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Remaining (Weight)";
            // 
            // remainWeightTextBox
            // 
            this.remainWeightTextBox.Enabled = false;
            this.remainWeightTextBox.Location = new System.Drawing.Point(295, 186);
            this.remainWeightTextBox.Name = "remainWeightTextBox";
            this.remainWeightTextBox.Size = new System.Drawing.Size(93, 20);
            this.remainWeightTextBox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(345, 102);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(286, 25);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RefrigeratorWeightControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 332);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.maxWeightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weightEachTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remainWeightTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noOfItemsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RefrigeratorWeightControlUI";
            this.Text = "RefrigeratorWeightControlUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noOfItemsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxWeightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightEachTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remainWeightTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button saveButton;
    }
}

