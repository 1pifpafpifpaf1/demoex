namespace demoex
{
    partial class setsmena
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
            this.daybox = new MetroFramework.Controls.MetroComboBox();
            this.workerbox = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daybox
            // 
            this.daybox.AutoCompleteCustomSource.AddRange(new string[] {
            "Официант",
            "Повор"});
            this.daybox.FormattingEnabled = true;
            this.daybox.ItemHeight = 23;
            this.daybox.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.daybox.Location = new System.Drawing.Point(23, 196);
            this.daybox.Name = "daybox";
            this.daybox.Size = new System.Drawing.Size(289, 29);
            this.daybox.Style = MetroFramework.MetroColorStyle.Red;
            this.daybox.TabIndex = 35;
            this.daybox.UseSelectable = true;
            // 
            // workerbox
            // 
            this.workerbox.AutoCompleteCustomSource.AddRange(new string[] {
            "Официант",
            "Повор"});
            this.workerbox.FormattingEnabled = true;
            this.workerbox.ItemHeight = 23;
            this.workerbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.workerbox.Location = new System.Drawing.Point(23, 109);
            this.workerbox.Name = "workerbox";
            this.workerbox.Size = new System.Drawing.Size(289, 29);
            this.workerbox.Style = MetroFramework.MetroColorStyle.Red;
            this.workerbox.TabIndex = 34;
            this.workerbox.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "День недели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Работник";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbutton.Location = new System.Drawing.Point(67, 258);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(217, 51);
            this.addbutton.TabIndex = 36;
            this.addbutton.Text = "Назначить";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // setsmena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 343);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.daybox);
            this.Controls.Add(this.workerbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "setsmena";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Назначить смену";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.setsmena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox daybox;
        private MetroFramework.Controls.MetroComboBox workerbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
    }
}