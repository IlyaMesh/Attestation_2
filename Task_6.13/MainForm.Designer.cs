namespace Task_6._13
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wayBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.paramsTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.par1TB = new System.Windows.Forms.TextBox();
            this.par2TB = new System.Windows.Forms.TextBox();
            this.par3TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.par1LB = new System.Windows.Forms.Label();
            this.par2LB = new System.Windows.Forms.Label();
            this.par3LB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 169);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // wayBTN
            // 
            this.wayBTN.Location = new System.Drawing.Point(12, 12);
            this.wayBTN.Name = "wayBTN";
            this.wayBTN.Size = new System.Drawing.Size(130, 43);
            this.wayBTN.TabIndex = 2;
            this.wayBTN.Text = "Выберете путь к библиотеке";
            this.wayBTN.UseVisualStyleBackColor = true;
            this.wayBTN.Click += new System.EventHandler(this.wayBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // paramsTB
            // 
            this.paramsTB.Location = new System.Drawing.Point(354, 187);
            this.paramsTB.Name = "paramsTB";
            this.paramsTB.Size = new System.Drawing.Size(100, 20);
            this.paramsTB.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.par3LB);
            this.panel1.Controls.Add(this.par2LB);
            this.panel1.Controls.Add(this.par1LB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.par3TB);
            this.panel1.Controls.Add(this.par2TB);
            this.panel1.Controls.Add(this.par1TB);
            this.panel1.Location = new System.Drawing.Point(148, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 104);
            this.panel1.TabIndex = 5;
            // 
            // par1TB
            // 
            this.par1TB.Location = new System.Drawing.Point(97, 18);
            this.par1TB.Name = "par1TB";
            this.par1TB.Size = new System.Drawing.Size(100, 20);
            this.par1TB.TabIndex = 0;
            // 
            // par2TB
            // 
            this.par2TB.Location = new System.Drawing.Point(97, 45);
            this.par2TB.Name = "par2TB";
            this.par2TB.Size = new System.Drawing.Size(100, 20);
            this.par2TB.TabIndex = 1;
            // 
            // par3TB
            // 
            this.par3TB.Location = new System.Drawing.Point(97, 71);
            this.par3TB.Name = "par3TB";
            this.par3TB.Size = new System.Drawing.Size(100, 20);
            this.par3TB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Параметры";
            // 
            // par1LB
            // 
            this.par1LB.AutoSize = true;
            this.par1LB.Location = new System.Drawing.Point(33, 24);
            this.par1LB.Name = "par1LB";
            this.par1LB.Size = new System.Drawing.Size(35, 13);
            this.par1LB.TabIndex = 4;
            this.par1LB.Text = "label2";
            // 
            // par2LB
            // 
            this.par2LB.AutoSize = true;
            this.par2LB.Location = new System.Drawing.Point(36, 51);
            this.par2LB.Name = "par2LB";
            this.par2LB.Size = new System.Drawing.Size(35, 13);
            this.par2LB.TabIndex = 5;
            this.par2LB.Text = "label2";
            // 
            // par3LB
            // 
            this.par3LB.AutoSize = true;
            this.par3LB.Location = new System.Drawing.Point(36, 77);
            this.par3LB.Name = "par3LB";
            this.par3LB.Size = new System.Drawing.Size(35, 13);
            this.par3LB.TabIndex = 6;
            this.par3LB.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 303);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paramsTB);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.wayBTN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "Reflexy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button wayBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox paramsTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label par3LB;
        private System.Windows.Forms.Label par2LB;
        private System.Windows.Forms.Label par1LB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox par3TB;
        private System.Windows.Forms.TextBox par2TB;
        private System.Windows.Forms.TextBox par1TB;
    }
}

