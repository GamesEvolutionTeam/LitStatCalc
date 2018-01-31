namespace SPECIAL_calc_3
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
            this.Char1 = new System.Windows.Forms.GroupBox();
            this.Stats = new System.Windows.Forms.Button();
            this.Char1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Char1
            // 
            this.Char1.Controls.Add(this.Stats);
            this.Char1.Location = new System.Drawing.Point(13, 13);
            this.Char1.Name = "Char1";
            this.Char1.Size = new System.Drawing.Size(200, 174);
            this.Char1.TabIndex = 0;
            this.Char1.TabStop = false;
            this.Char1.Text = "Персонаж 1";
            // 
            // Stats
            // 
            this.Stats.Location = new System.Drawing.Point(7, 20);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(99, 23);
            this.Stats.TabIndex = 0;
            this.Stats.Text = "Характеристики";
            this.Stats.UseVisualStyleBackColor = true;
            this.Stats.Click += new System.EventHandler(this.Stats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 620);
            this.Controls.Add(this.Char1);
            this.Name = "Form1";
            this.Text = "Экран подготовки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Char1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Char1;
        private System.Windows.Forms.Button Stats;
    }
}

