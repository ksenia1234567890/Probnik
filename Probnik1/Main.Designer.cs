namespace Probnik1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TBsearch = new System.Windows.Forms.TextBox();
            this.sort = new System.Windows.Forms.ComboBox();
            this.filter = new System.Windows.Forms.ComboBox();
            this.left = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.third = new System.Windows.Forms.Label();
            this.panelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.addProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBsearch
            // 
            this.TBsearch.Location = new System.Drawing.Point(35, 44);
            this.TBsearch.Multiline = true;
            this.TBsearch.Name = "TBsearch";
            this.TBsearch.Size = new System.Drawing.Size(314, 20);
            this.TBsearch.TabIndex = 0;
            // 
            // sort
            // 
            this.sort.FormattingEnabled = true;
            this.sort.Items.AddRange(new object[] {
            "Без сортировки",
            "Наименование - по возрастанию",
            "Наименование - по убыванию",
            "Номер производственного цеха - по возрастанию",
            "Номер производственного цеха - по убыванию",
            "Минимальная стоимость для агента - по возрастанию",
            "Минимальная стоимость для агента - по убыванию"});
            this.sort.Location = new System.Drawing.Point(364, 43);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(233, 21);
            this.sort.TabIndex = 1;
            this.sort.Text = "Без сортировки";
            this.sort.SelectedIndexChanged += new System.EventHandler(this.sort_SelectedIndexChanged);
            // 
            // filter
            // 
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "Все типы"});
            this.filter.Location = new System.Drawing.Point(610, 44);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(142, 21);
            this.filter.TabIndex = 1;
            this.filter.Text = "Все типы";
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.left.Location = new System.Drawing.Point(632, 627);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(16, 17);
            this.left.TabIndex = 3;
            this.left.Text = "<";
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.AutoSize = true;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.right.Location = new System.Drawing.Point(735, 627);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(16, 17);
            this.right.TabIndex = 3;
            this.right.Text = ">";
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first.Location = new System.Drawing.Point(664, 627);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(16, 17);
            this.first.TabIndex = 3;
            this.first.Text = "1";
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.second.Location = new System.Drawing.Point(686, 627);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(16, 17);
            this.second.TabIndex = 3;
            this.second.Text = "2";
            this.second.Click += new System.EventHandler(this.second_Click);
            // 
            // third
            // 
            this.third.AutoSize = true;
            this.third.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.third.Location = new System.Drawing.Point(708, 627);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(16, 17);
            this.third.TabIndex = 3;
            this.third.Text = "3";
            this.third.Click += new System.EventHandler(this.third_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.AutoScroll = true;
            this.panelProduct.Location = new System.Drawing.Point(35, 80);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(717, 538);
            this.panelProduct.TabIndex = 4;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(35, 624);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(134, 25);
            this.addProduct.TabIndex = 5;
            this.addProduct.Text = "Добавить продукцию";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дважды нажмите по пустому пространству окна, \r\nчтобы произвести поиск";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(778, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.TBsearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Лопушок";
            this.Load += new System.EventHandler(this.Main_Load);
            this.DoubleClick += new System.EventHandler(this.Main_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBsearch;
        private System.Windows.Forms.ComboBox sort;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.Label left;
        private System.Windows.Forms.Label right;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label third;
        private System.Windows.Forms.FlowLayoutPanel panelProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Label label1;
    }
}

