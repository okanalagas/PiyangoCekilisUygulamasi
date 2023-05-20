namespace _2_Çekiliş
{
    partial class Form2
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
            this.textBox_TicketNo = new System.Windows.Forms.TextBox();
            this.button_Random = new System.Windows.Forms.Button();
            this.button_Get = new System.Windows.Forms.Button();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_TicketNo
            // 
            this.textBox_TicketNo.Location = new System.Drawing.Point(73, 12);
            this.textBox_TicketNo.Name = "textBox_TicketNo";
            this.textBox_TicketNo.Size = new System.Drawing.Size(152, 20);
            this.textBox_TicketNo.TabIndex = 16;
            // 
            // button_Random
            // 
            this.button_Random.BackgroundImage = global::_2_Çekiliş.Properties.Resources.dice;
            this.button_Random.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Random.Location = new System.Drawing.Point(246, 12);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(50, 45);
            this.button_Random.TabIndex = 15;
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            // 
            // button_Get
            // 
            this.button_Get.Location = new System.Drawing.Point(160, 38);
            this.button_Get.Name = "button_Get";
            this.button_Get.Size = new System.Drawing.Size(65, 26);
            this.button_Get.TabIndex = 13;
            this.button_Get.Text = "Getir";
            this.button_Get.UseVisualStyleBackColor = true;
            this.button_Get.Click += new System.EventHandler(this.button_Get_Click);
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(73, 96);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(152, 20);
            this.textBox_Surname.TabIndex = 11;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(73, 70);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(152, 20);
            this.textBox_Name.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bilet No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_TicketNo);
            this.Controls.Add(this.button_Random);
            this.Controls.Add(this.button_Get);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TicketNo;
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.Button button_Get;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}