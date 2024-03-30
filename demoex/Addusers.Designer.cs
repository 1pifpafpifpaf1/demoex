namespace demoex
{
    partial class Addusers
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
            this.logtext = new MetroFramework.Controls.MetroTextBox();
            this.passtext = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rolebox = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя пользователя";
            // 
            // logtext
            // 
            // 
            // 
            // 
            this.logtext.CustomButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logtext.CustomButton.Image = null;
            this.logtext.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.logtext.CustomButton.Name = "";
            this.logtext.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.logtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.logtext.CustomButton.TabIndex = 1;
            this.logtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logtext.CustomButton.UseSelectable = true;
            this.logtext.CustomButton.Visible = false;
            this.logtext.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.logtext.Lines = new string[0];
            this.logtext.Location = new System.Drawing.Point(42, 125);
            this.logtext.MaxLength = 32767;
            this.logtext.Name = "logtext";
            this.logtext.PasswordChar = '\0';
            this.logtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.logtext.SelectedText = "";
            this.logtext.SelectionLength = 0;
            this.logtext.SelectionStart = 0;
            this.logtext.ShortcutsEnabled = true;
            this.logtext.Size = new System.Drawing.Size(289, 40);
            this.logtext.Style = MetroFramework.MetroColorStyle.Red;
            this.logtext.TabIndex = 19;
            this.logtext.UseSelectable = true;
            this.logtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logtext.WaterMarkFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // passtext
            // 
            // 
            // 
            // 
            this.passtext.CustomButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passtext.CustomButton.Image = null;
            this.passtext.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.passtext.CustomButton.Name = "";
            this.passtext.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.passtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passtext.CustomButton.TabIndex = 1;
            this.passtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passtext.CustomButton.UseSelectable = true;
            this.passtext.CustomButton.Visible = false;
            this.passtext.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passtext.Lines = new string[0];
            this.passtext.Location = new System.Drawing.Point(42, 224);
            this.passtext.MaxLength = 32767;
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '\0';
            this.passtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passtext.SelectedText = "";
            this.passtext.SelectionLength = 0;
            this.passtext.SelectionStart = 0;
            this.passtext.ShortcutsEnabled = true;
            this.passtext.Size = new System.Drawing.Size(289, 40);
            this.passtext.Style = MetroFramework.MetroColorStyle.Red;
            this.passtext.TabIndex = 20;
            this.passtext.UseSelectable = true;
            this.passtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passtext.WaterMarkFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Введите пароль для пользователя";
            // 
            // rolebox
            // 
            this.rolebox.AutoCompleteCustomSource.AddRange(new string[] {
            "Официант",
            "Повор"});
            this.rolebox.FormattingEnabled = true;
            this.rolebox.ItemHeight = 23;
            this.rolebox.Items.AddRange(new object[] {
            "Официант",
            "Повор"});
            this.rolebox.Location = new System.Drawing.Point(42, 322);
            this.rolebox.Name = "rolebox";
            this.rolebox.Size = new System.Drawing.Size(289, 29);
            this.rolebox.Style = MetroFramework.MetroColorStyle.Red;
            this.rolebox.TabIndex = 22;
            this.rolebox.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(103, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Роль пользователя";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbutton.Location = new System.Drawing.Point(78, 376);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(217, 51);
            this.addbutton.TabIndex = 24;
            this.addbutton.Text = "Добавить";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // Addusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rolebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.logtext);
            this.Controls.Add(this.label1);
            this.Name = "Addusers";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Добавление пользователей";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Addusers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox logtext;
        private MetroFramework.Controls.MetroTextBox passtext;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox rolebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addbutton;
    }
}