
namespace ЛР_1._2
{
    partial class Form1
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
            this.GenerateCollBtn = new System.Windows.Forms.Button();
            this.AscendingBtn = new System.Windows.Forms.Button();
            this.DescendingBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.PrintAllBtn = new System.Windows.Forms.Button();
            this.ListAm = new System.Windows.Forms.TextBox();
            this.List = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateCollBtn
            // 
            this.GenerateCollBtn.BackColor = System.Drawing.SystemColors.Control;
            this.GenerateCollBtn.Location = new System.Drawing.Point(232, 64);
            this.GenerateCollBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateCollBtn.Name = "GenerateCollBtn";
            this.GenerateCollBtn.Size = new System.Drawing.Size(309, 58);
            this.GenerateCollBtn.TabIndex = 0;
            this.GenerateCollBtn.Text = "Генерировать коллекцию";
            this.GenerateCollBtn.UseVisualStyleBackColor = false;
            this.GenerateCollBtn.Click += new System.EventHandler(this.GenerateCollBtn_Click);
            // 
            // AscendingBtn
            // 
            this.AscendingBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.AscendingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AscendingBtn.Location = new System.Drawing.Point(41, 64);
            this.AscendingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AscendingBtn.Name = "AscendingBtn";
            this.AscendingBtn.Size = new System.Drawing.Size(161, 44);
            this.AscendingBtn.TabIndex = 1;
            this.AscendingBtn.Text = "По возрастанию";
            this.AscendingBtn.UseVisualStyleBackColor = false;
            this.AscendingBtn.Click += new System.EventHandler(this.AscendingBtn_Click);
            // 
            // DescendingBtn
            // 
            this.DescendingBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.DescendingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DescendingBtn.Location = new System.Drawing.Point(41, 116);
            this.DescendingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DescendingBtn.Name = "DescendingBtn";
            this.DescendingBtn.Size = new System.Drawing.Size(161, 44);
            this.DescendingBtn.TabIndex = 2;
            this.DescendingBtn.Text = "По убыванию";
            this.DescendingBtn.UseVisualStyleBackColor = false;
            this.DescendingBtn.Click += new System.EventHandler(this.DescendingBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinBtn.Location = new System.Drawing.Point(41, 220);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(161, 44);
            this.MinBtn.TabIndex = 3;
            this.MinBtn.Text = "Минимальный";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackColor = System.Drawing.Color.Linen;
            this.MaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaxBtn.Location = new System.Drawing.Point(41, 168);
            this.MaxBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(161, 44);
            this.MaxBtn.TabIndex = 4;
            this.MaxBtn.Text = "Максимальный";
            this.MaxBtn.UseVisualStyleBackColor = false;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // PrintAllBtn
            // 
            this.PrintAllBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PrintAllBtn.Location = new System.Drawing.Point(231, 130);
            this.PrintAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintAllBtn.Name = "PrintAllBtn";
            this.PrintAllBtn.Size = new System.Drawing.Size(309, 44);
            this.PrintAllBtn.TabIndex = 5;
            this.PrintAllBtn.Text = "Показать все";
            this.PrintAllBtn.UseVisualStyleBackColor = false;
            this.PrintAllBtn.Click += new System.EventHandler(this.PrintAllBtn_Click);
            // 
            // ListAm
            // 
            this.ListAm.Location = new System.Drawing.Point(323, 30);
            this.ListAm.Margin = new System.Windows.Forms.Padding(4);
            this.ListAm.Name = "ListAm";
            this.ListAm.Size = new System.Drawing.Size(132, 22);
            this.ListAm.TabIndex = 6;
            this.ListAm.TextChanged += new System.EventHandler(this.ListAm_TextChanged);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(231, 179);
            this.List.Margin = new System.Windows.Forms.Padding(4);
            this.List.Multiline = true;
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(308, 84);
            this.List.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Размер коллекции";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(595, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List);
            this.Controls.Add(this.ListAm);
            this.Controls.Add(this.PrintAllBtn);
            this.Controls.Add(this.MaxBtn);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.DescendingBtn);
            this.Controls.Add(this.AscendingBtn);
            this.Controls.Add(this.GenerateCollBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateCollBtn;
        private System.Windows.Forms.Button AscendingBtn;
        private System.Windows.Forms.Button DescendingBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button PrintAllBtn;
        private System.Windows.Forms.TextBox ListAm;
        private System.Windows.Forms.TextBox List;
        private System.Windows.Forms.Label label1;
    }
}

