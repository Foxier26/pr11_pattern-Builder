namespace pr11_sakharov_rest
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.burgerComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(39, 33);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(722, 293);
            this.dataGridView.TabIndex = 0;
            // 
            // burgerComboBox
            // 
            this.burgerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.burgerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burgerComboBox.FormattingEnabled = true;
            this.burgerComboBox.Items.AddRange(new object[] {
            "Бургер стандартный",
            "Бургер с беконом"});
            this.burgerComboBox.Location = new System.Drawing.Point(39, 346);
            this.burgerComboBox.Name = "burgerComboBox";
            this.burgerComboBox.Size = new System.Drawing.Size(257, 33);
            this.burgerComboBox.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(503, 346);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(258, 41);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Добавить бургер";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.burgerComboBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Бургеры Онлайн";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox burgerComboBox;
        private System.Windows.Forms.Button addBtn;
    }
}

