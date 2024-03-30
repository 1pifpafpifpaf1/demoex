namespace demoex
{
    partial class changestatus
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
            this.addbutton = new System.Windows.Forms.Button();
            this.nomerbox = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusbox = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbutton.Location = new System.Drawing.Point(69, 277);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(217, 51);
            this.addbutton.TabIndex = 27;
            this.addbutton.Text = "Сменить";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // nomerbox
            // 
            this.nomerbox.AutoCompleteCustomSource.AddRange(new string[] {
            "Официант",
            "Повор"});
            this.nomerbox.FormattingEnabled = true;
            this.nomerbox.ItemHeight = 23;
            this.nomerbox.Location = new System.Drawing.Point(23, 110);
            this.nomerbox.Name = "nomerbox";
            this.nomerbox.Size = new System.Drawing.Size(289, 29);
            this.nomerbox.Style = MetroFramework.MetroColorStyle.Red;
            this.nomerbox.TabIndex = 31;
            this.nomerbox.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Номер заказа";
            // 
            // statusbox
            // 
            this.statusbox.AutoCompleteCustomSource.AddRange(new string[] {
            "Официант",
            "Повор"});
            this.statusbox.FormattingEnabled = true;
            this.statusbox.ItemHeight = 23;
            this.statusbox.Items.AddRange(new object[] {
            "Принят",
            "Оплачен"});
            this.statusbox.Location = new System.Drawing.Point(23, 205);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(289, 29);
            this.statusbox.Style = MetroFramework.MetroColorStyle.Red;
            this.statusbox.TabIndex = 32;
            this.statusbox.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Статус";
            // 
            // changestatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.nomerbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbutton);
            this.Name = "changestatus";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Смена статуса заказа";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.changestatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton;
        private MetroFramework.Controls.MetroComboBox nomerbox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox statusbox;
        private System.Windows.Forms.Label label2;
    }
}