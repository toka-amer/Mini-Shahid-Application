
namespace Shahid
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
            this.RateButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.CategoriesLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.Label();
            this.CategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.NamesComboBox = new System.Windows.Forms.ComboBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.TotalRateLabel = new System.Windows.Forms.Label();
            this.UserRateTxt = new System.Windows.Forms.TextBox();
            this.TotalRateTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RateButton
            // 
            this.RateButton.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateButton.Location = new System.Drawing.Point(150, 364);
            this.RateButton.Name = "RateButton";
            this.RateButton.Size = new System.Drawing.Size(121, 46);
            this.RateButton.TabIndex = 0;
            this.RateButton.Text = "Rate";
            this.RateButton.UseVisualStyleBackColor = true;
            this.RateButton.Click += new System.EventHandler(this.RateButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(145, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(129, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Give Rate";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(51, 79);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(81, 17);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(51, 126);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(77, 17);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.AutoSize = true;
            this.CategoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLabel.Location = new System.Drawing.Point(51, 192);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(86, 17);
            this.CategoriesLabel.TabIndex = 4;
            this.CategoriesLabel.Text = "Categories";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(51, 241);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateLabel.Location = new System.Drawing.Point(51, 293);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(81, 17);
            this.RateLabel.TabIndex = 6;
            this.RateLabel.Text = "Your Rate";
            // 
            // CategoriesComboBox
            // 
            this.CategoriesComboBox.FormattingEnabled = true;
            this.CategoriesComboBox.Location = new System.Drawing.Point(150, 189);
            this.CategoriesComboBox.Name = "CategoriesComboBox";
            this.CategoriesComboBox.Size = new System.Drawing.Size(121, 24);
            this.CategoriesComboBox.TabIndex = 7;
            this.CategoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesComboBox_SelectedIndexChanged);
            // 
            // NamesComboBox
            // 
            this.NamesComboBox.FormattingEnabled = true;
            this.NamesComboBox.Location = new System.Drawing.Point(150, 238);
            this.NamesComboBox.Name = "NamesComboBox";
            this.NamesComboBox.Size = new System.Drawing.Size(121, 24);
            this.NamesComboBox.TabIndex = 8;
            this.NamesComboBox.SelectedIndexChanged += new System.EventHandler(this.NamesBomboBox_SelectedIndexChanged);
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(150, 76);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(100, 22);
            this.UserNameTxt.TabIndex = 9;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(150, 121);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(100, 22);
            this.PasswordTxt.TabIndex = 10;
            // 
            // TotalRateLabel
            // 
            this.TotalRateLabel.AutoSize = true;
            this.TotalRateLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRateLabel.Location = new System.Drawing.Point(283, 246);
            this.TotalRateLabel.Name = "TotalRateLabel";
            this.TotalRateLabel.Size = new System.Drawing.Size(88, 19);
            this.TotalRateLabel.TabIndex = 11;
            this.TotalRateLabel.Text = "Total Rate";
            // 
            // UserRateTxt
            // 
            this.UserRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRateTxt.Location = new System.Drawing.Point(150, 287);
            this.UserRateTxt.MaxLength = 2;
            this.UserRateTxt.Name = "UserRateTxt";
            this.UserRateTxt.Size = new System.Drawing.Size(34, 30);
            this.UserRateTxt.TabIndex = 12;
            // 
            // TotalRateTxt
            // 
            this.TotalRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRateTxt.Location = new System.Drawing.Point(387, 239);
            this.TotalRateTxt.Name = "TotalRateTxt";
            this.TotalRateTxt.ReadOnly = true;
            this.TotalRateTxt.Size = new System.Drawing.Size(60, 30);
            this.TotalRateTxt.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.TotalRateTxt);
            this.Controls.Add(this.UserRateTxt);
            this.Controls.Add(this.TotalRateLabel);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.NamesComboBox);
            this.Controls.Add(this.CategoriesComboBox);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CategoriesLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RateButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.ComboBox CategoriesComboBox;
        private System.Windows.Forms.ComboBox NamesComboBox;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label TotalRateLabel;
        private System.Windows.Forms.TextBox UserRateTxt;
        private System.Windows.Forms.TextBox TotalRateTxt;
    }
}

