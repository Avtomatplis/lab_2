
namespace lab_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CreateObject = new System.Windows.Forms.Button();
            this.CloseProject = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.NumberOfChildren = new System.Windows.Forms.NumericUpDown();
            this.Weight = new System.Windows.Forms.NumericUpDown();
            this.NumberOfObjects = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CreateException = new System.Windows.Forms.Button();
            this.SeeObject = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateObject
            // 
            this.CreateObject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateObject.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateObject.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CreateObject.Location = new System.Drawing.Point(598, 329);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(190, 43);
            this.CreateObject.TabIndex = 0;
            this.CreateObject.Text = "Создать обьект";
            this.CreateObject.UseVisualStyleBackColor = false;
            this.CreateObject.Click += new System.EventHandler(this.CreateObject_Click);
            // 
            // CloseProject
            // 
            this.CloseProject.BackColor = System.Drawing.SystemColors.Info;
            this.CloseProject.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseProject.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CloseProject.Location = new System.Drawing.Point(598, 402);
            this.CloseProject.Name = "CloseProject";
            this.CloseProject.Size = new System.Drawing.Size(190, 36);
            this.CloseProject.TabIndex = 4;
            this.CloseProject.Text = "Закрыть проект";
            this.CloseProject.UseVisualStyleBackColor = false;
            this.CloseProject.Click += new System.EventHandler(this.CloseProject_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(511, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.Chartreuse;
            this.Change.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.ForeColor = System.Drawing.Color.Blue;
            this.Change.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Change.Location = new System.Drawing.Point(12, 387);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(169, 51);
            this.Change.TabIndex = 6;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(578, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // NewName
            // 
            this.NewName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.NewName.Location = new System.Drawing.Point(665, 22);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(100, 22);
            this.NewName.TabIndex = 8;
            // 
            // SecondName
            // 
            this.SecondName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SecondName.Location = new System.Drawing.Point(665, 50);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(100, 22);
            this.SecondName.TabIndex = 10;
            // 
            // Country
            // 
            this.Country.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Country.Location = new System.Drawing.Point(665, 78);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(100, 22);
            this.Country.TabIndex = 12;
            // 
            // Age
            // 
            this.Age.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Age.Location = new System.Drawing.Point(665, 107);
            this.Age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(120, 22);
            this.Age.TabIndex = 14;
            this.Age.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // Height
            // 
            this.Height.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Height.Location = new System.Drawing.Point(665, 135);
            this.Height.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(120, 22);
            this.Height.TabIndex = 16;
            this.Height.Value = new decimal(new int[] {
            176,
            0,
            0,
            0});
            // 
            // NumberOfChildren
            // 
            this.NumberOfChildren.BackColor = System.Drawing.Color.AntiqueWhite;
            this.NumberOfChildren.Location = new System.Drawing.Point(665, 196);
            this.NumberOfChildren.Name = "NumberOfChildren";
            this.NumberOfChildren.Size = new System.Drawing.Size(120, 22);
            this.NumberOfChildren.TabIndex = 18;
            // 
            // Weight
            // 
            this.Weight.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Weight.Location = new System.Drawing.Point(665, 166);
            this.Weight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(120, 22);
            this.Weight.TabIndex = 20;
            this.Weight.Value = new decimal(new int[] {
            76,
            0,
            0,
            0});
            // 
            // NumberOfObjects
            // 
            this.NumberOfObjects.AutoSize = true;
            this.NumberOfObjects.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfObjects.ForeColor = System.Drawing.Color.Red;
            this.NumberOfObjects.Location = new System.Drawing.Point(300, 22);
            this.NumberOfObjects.Name = "NumberOfObjects";
            this.NumberOfObjects.Size = new System.Drawing.Size(179, 20);
            this.NumberOfObjects.TabIndex = 21;
            this.NumberOfObjects.Text = "Добавлено обьектов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 22;
            // 
            // CreateException
            // 
            this.CreateException.BackColor = System.Drawing.SystemColors.InfoText;
            this.CreateException.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateException.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateException.Location = new System.Drawing.Point(396, 387);
            this.CreateException.Name = "CreateException";
            this.CreateException.Size = new System.Drawing.Size(182, 51);
            this.CreateException.TabIndex = 23;
            this.CreateException.Text = "Не нажимать";
            this.CreateException.UseVisualStyleBackColor = false;
            this.CreateException.Click += new System.EventHandler(this.CreateException_Click);
            // 
            // SeeObject
            // 
            this.SeeObject.BackColor = System.Drawing.SystemColors.Info;
            this.SeeObject.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeObject.ForeColor = System.Drawing.Color.IndianRed;
            this.SeeObject.Location = new System.Drawing.Point(206, 387);
            this.SeeObject.Name = "SeeObject";
            this.SeeObject.Size = new System.Drawing.Size(169, 51);
            this.SeeObject.TabIndex = 24;
            this.SeeObject.Text = "Показать";
            this.SeeObject.UseVisualStyleBackColor = false;
            this.SeeObject.Click += new System.EventHandler(this.SeeObject_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(379, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Выберите объект для изменения/показа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(560, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Фамилия";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(574, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Город";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(475, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Количество детей";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(578, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Вес";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(578, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Рост";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(571, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Информация об объекте";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SeeObject);
            this.Controls.Add(this.CreateException);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumberOfObjects);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.NumberOfChildren);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CloseProject);
            this.Controls.Add(this.CreateObject);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа№2 Жигалов Бобков";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button CreateObject;
        private System.Windows.Forms.Button CloseProject;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.NumericUpDown NumberOfChildren;
        private System.Windows.Forms.NumericUpDown Weight;
        private System.Windows.Forms.Label NumberOfObjects;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CreateException;
        private System.Windows.Forms.Button SeeObject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
    }
}

