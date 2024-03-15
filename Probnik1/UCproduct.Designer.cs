namespace Probnik1
{
    partial class UCproduct
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.type = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.articul = new System.Windows.Forms.Label();
            this.materials = new System.Windows.Forms.Label();
            this.material1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.type.Location = new System.Drawing.Point(165, 18);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(44, 24);
            this.type.TabIndex = 1;
            this.type.Text = "Тип";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.line.Location = new System.Drawing.Point(311, 17);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(14, 24);
            this.line.TabIndex = 1;
            this.line.Text = "|";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.name.Location = new System.Drawing.Point(331, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(144, 24);
            this.name.TabIndex = 1;
            this.name.Text = "Наименование";
            // 
            // articul
            // 
            this.articul.AutoSize = true;
            this.articul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.articul.Location = new System.Drawing.Point(165, 55);
            this.articul.Name = "articul";
            this.articul.Size = new System.Drawing.Size(72, 20);
            this.articul.TabIndex = 1;
            this.articul.Text = "Артикул";
            // 
            // materials
            // 
            this.materials.AutoSize = true;
            this.materials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materials.Location = new System.Drawing.Point(165, 93);
            this.materials.Name = "materials";
            this.materials.Size = new System.Drawing.Size(101, 20);
            this.materials.TabIndex = 1;
            this.materials.Text = "Материалы:";
            // 
            // material1
            // 
            this.material1.AutoSize = true;
            this.material1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.material1.Location = new System.Drawing.Point(272, 93);
            this.material1.Name = "material1";
            this.material1.Size = new System.Drawing.Size(84, 20);
            this.material1.TabIndex = 1;
            this.material1.Text = "материал";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.price.Location = new System.Drawing.Point(589, 21);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(93, 20);
            this.price.TabIndex = 1;
            this.price.Text = "Стоимость";
            // 
            // UCproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.line);
            this.Controls.Add(this.name);
            this.Controls.Add(this.material1);
            this.Controls.Add(this.materials);
            this.Controls.Add(this.price);
            this.Controls.Add(this.articul);
            this.Controls.Add(this.type);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCproduct";
            this.Size = new System.Drawing.Size(711, 148);
            this.Click += new System.EventHandler(this.UCproduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label articul;
        private System.Windows.Forms.Label materials;
        private System.Windows.Forms.Label material1;
        private System.Windows.Forms.Label price;
    }
}
