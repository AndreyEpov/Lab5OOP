namespace Lab5
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
            this.button2 = new System.Windows.Forms.Button();
            this.galleryEllipse1 = new Lab5.GalleryEllipse();
            this.gallery1 = new Lab5.Gallery();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(998, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 127);
            this.button2.TabIndex = 2;
            this.button2.Text = "Переключить режим";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // galleryEllipse1
            // 
            this.galleryEllipse1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galleryEllipse1.ForeColor = System.Drawing.Color.White;
            this.galleryEllipse1.Location = new System.Drawing.Point(12, 15);
            this.galleryEllipse1.Name = "galleryEllipse1";
            this.galleryEllipse1.Size = new System.Drawing.Size(980, 575);
            this.galleryEllipse1.TabIndex = 3;
            this.galleryEllipse1.Text = "galleryEllipse1";
            this.galleryEllipse1.UseVisualStyleBackColor = true;
            // 
            // gallery1
            // 
            this.gallery1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallery1.ForeColor = System.Drawing.Color.White;
            this.gallery1.Location = new System.Drawing.Point(12, 15);
            this.gallery1.Name = "gallery1";
            this.gallery1.Size = new System.Drawing.Size(980, 575);
            this.gallery1.TabIndex = 0;
            this.gallery1.Text = "gallery1";
            this.gallery1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 602);
            this.Controls.Add(this.galleryEllipse1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gallery1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private Gallery gallery1;
        private System.Windows.Forms.Button button2;
        private GalleryEllipse galleryEllipse1;
    }
}

