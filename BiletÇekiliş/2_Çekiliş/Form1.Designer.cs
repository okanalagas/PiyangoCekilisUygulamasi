namespace _2_Çekiliş
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_TicketNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_List = new System.Windows.Forms.Button();
            this.button_Random = new System.Windows.Forms.Button();
            this.button_Check = new System.Windows.Forms.Button();
            this.button_Result = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bilet No:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(71, 44);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(152, 20);
            this.textBox_Name.TabIndex = 3;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(71, 70);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(152, 20);
            this.textBox_Surname.TabIndex = 3;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(158, 122);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(65, 26);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Kaydet";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_TicketNo
            // 
            this.textBox_TicketNo.Location = new System.Drawing.Point(71, 96);
            this.textBox_TicketNo.Name = "textBox_TicketNo";
            this.textBox_TicketNo.Size = new System.Drawing.Size(152, 20);
            this.textBox_TicketNo.TabIndex = 7;
            this.textBox_TicketNo.TextChanged += new System.EventHandler(this.textBox_TicketNo_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 263);
            this.dataGridView1.TabIndex = 8;
            // 
            // button_List
            // 
            this.button_List.Location = new System.Drawing.Point(486, 423);
            this.button_List.Name = "button_List";
            this.button_List.Size = new System.Drawing.Size(79, 23);
            this.button_List.TabIndex = 9;
            this.button_List.Text = "Listele";
            this.button_List.UseVisualStyleBackColor = true;
            this.button_List.Click += new System.EventHandler(this.button_List_Click);
            // 
            // button_Random
            // 
            this.button_Random.BackgroundImage = global::_2_Çekiliş.Properties.Resources.dice;
            this.button_Random.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Random.Location = new System.Drawing.Point(300, 73);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(50, 45);
            this.button_Random.TabIndex = 6;
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            // 
            // button_Check
            // 
            this.button_Check.BackgroundImage = global::_2_Çekiliş.Properties.Resources.close;
            this.button_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Check.Location = new System.Drawing.Point(244, 73);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(50, 45);
            this.button_Check.TabIndex = 5;
            this.button_Check.UseVisualStyleBackColor = true;
            // 
            // button_Result
            // 
            this.button_Result.Location = new System.Drawing.Point(12, 423);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(85, 23);
            this.button_Result.TabIndex = 10;
            this.button_Result.Text = ">>";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.button_List);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_TicketNo);
            this.Controls.Add(this.button_Random);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.TextBox textBox_TicketNo;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_List;
        private System.Windows.Forms.Button button_Result;
    }
}

