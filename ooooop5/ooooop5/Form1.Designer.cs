namespace ooooop5
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
            this.hoverGallery1 = new ooooop5.HoverGallery();
            this.hoverGalleryOval1 = new ooooop5.HoverGalleryOval();
            this.SuspendLayout();
            // 
            // hoverGallery1
            // 
            this.hoverGallery1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverGallery1.ForeColor = System.Drawing.Color.White;
            this.hoverGallery1.Location = new System.Drawing.Point(3, 3);
            this.hoverGallery1.Name = "hoverGallery1";
            this.hoverGallery1.Size = new System.Drawing.Size(642, 402);
            this.hoverGallery1.TabIndex = 0;
            this.hoverGallery1.Text = "hoverGallery1";
            this.hoverGallery1.UseVisualStyleBackColor = true;
            // 
            // hoverGalleryOval1
            // 
            this.hoverGalleryOval1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverGalleryOval1.ForeColor = System.Drawing.Color.White;
            this.hoverGalleryOval1.Location = new System.Drawing.Point(689, 32);
            this.hoverGalleryOval1.Name = "hoverGalleryOval1";
            this.hoverGalleryOval1.Size = new System.Drawing.Size(449, 399);
            this.hoverGalleryOval1.TabIndex = 1;
            this.hoverGalleryOval1.Text = "hoverGalleryOval1";
            this.hoverGalleryOval1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 587);
            this.Controls.Add(this.hoverGalleryOval1);
            this.Controls.Add(this.hoverGallery1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HoverGallery hoverGallery1;
        private HoverGalleryOval hoverGalleryOval1;
    }
}

