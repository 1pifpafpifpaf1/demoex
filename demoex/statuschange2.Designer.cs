namespace demoex
{
    partial class statuschange2
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
            this.label2 = new System.Windows.Forms.Label();
            this.statusbox = new MetroFramework.Controls.MetroComboBox();
            this.nomerbox = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Статус";
            // 
            // statusbox
            // 
            this.statusbox.AutoCompleteCustomSource.AddRange(new string[] {
            "Официант",
            "Повор"});
            this.statusbox.FormattingEnabled = true;
            this.statusbox.ItemHeight = 23;
            this.statusbox.Items.AddRange(new object[] {
            "Готовится",
            "Готов"});
            this.statusbox.Location = new System.Drawing.Point(22, 210);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(289, 29);
            this.statusbox.Style = MetroFramework.MetroColorStyle.Red;
            this.statusbox.TabIndex = 37;
            this.statusbox.UseSelectable = true;
            // 
            // nomerbox
            // 
            this.nomerbox.AutoCompleteCustomSource.AddRange(new string[] {
            "Официант",
            "Повор"});
            this.nomerbox.FormattingEnabled = true;
            this.nomerbox.ItemHeight = 23;
            this.nomerbox.Location = new System.Drawing.Point(22, 115);
            this.nomerbox.Name = "nomerbox";
            this.nomerbox.Size = new System.Drawing.Size(289, 29);
            this.nomerbox.Style = MetroFramework.MetroColorStyle.Red;
            this.nomerbox.TabIndex = 36;
            this.nomerbox.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Номер заказа";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbutton.Location = new System.Drawing.Point(53, 280);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(217, 51);
            this.addbutton.TabIndex = 34;
            this.addbutton.Text = "Сменить";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click_1);
            // 
            // statuschange2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.nomerbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbutton);
            this.Name = "statuschange2";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Смена статуса заказа";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.statuschange2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox statusbox;
        private MetroFramework.Controls.MetroComboBox nomerbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
    }
}