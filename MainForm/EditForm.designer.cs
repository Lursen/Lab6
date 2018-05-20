namespace Interface
{
    partial class EditForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VarLabel = new System.Windows.Forms.Label();
            this.PasCapBox = new System.Windows.Forms.TextBox();
            this.VarBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passenger Capacity";
            // 
            // VarLabel
            // 
            this.VarLabel.AutoSize = true;
            this.VarLabel.Location = new System.Drawing.Point(31, 165);
            this.VarLabel.Name = "VarLabel";
            this.VarLabel.Size = new System.Drawing.Size(35, 13);
            this.VarLabel.TabIndex = 2;
            this.VarLabel.Text = "label3";
            // 
            // PasCapBox
            // 
            this.PasCapBox.Location = new System.Drawing.Point(154, 122);
            this.PasCapBox.Name = "PasCapBox";
            this.PasCapBox.Size = new System.Drawing.Size(137, 20);
            this.PasCapBox.TabIndex = 3;
            // 
            // VarBox
            // 
            this.VarBox.Location = new System.Drawing.Point(154, 162);
            this.VarBox.Name = "VarBox";
            this.VarBox.Size = new System.Drawing.Size(137, 20);
            this.VarBox.TabIndex = 4;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 245);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(151, 43);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(35, 13);
            this.ClassLabel.TabIndex = 7;
            this.ClassLabel.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(154, 84);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(137, 20);
            this.NameBox.TabIndex = 9;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 282);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.VarBox);
            this.Controls.Add(this.PasCapBox);
            this.Controls.Add(this.VarLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VarLabel;
        private System.Windows.Forms.TextBox PasCapBox;
        private System.Windows.Forms.TextBox VarBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
    }
}

