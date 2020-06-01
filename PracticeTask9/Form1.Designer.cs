namespace PracticeTask9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЗначениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЗначениюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.N_Label = new System.Windows.Forms.Label();
            this.N_Input = new System.Windows.Forms.TextBox();
            this.List_Output = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьСписокToolStripMenuItem,
            this.добавитьВСписокToolStripMenuItem,
            this.удалитьИзСпискаToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьСписокToolStripMenuItem
            // 
            this.создатьСписокToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.создатьСписокToolStripMenuItem.Name = "создатьСписокToolStripMenuItem";
            this.создатьСписокToolStripMenuItem.Size = new System.Drawing.Size(121, 25);
            this.создатьСписокToolStripMenuItem.Text = "Создать список";
            this.создатьСписокToolStripMenuItem.Click += new System.EventHandler(this.создатьСписокToolStripMenuItem_Click);
            // 
            // добавитьВСписокToolStripMenuItem
            // 
            this.добавитьВСписокToolStripMenuItem.Enabled = false;
            this.добавитьВСписокToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитьВСписокToolStripMenuItem.Name = "добавитьВСписокToolStripMenuItem";
            this.добавитьВСписокToolStripMenuItem.Size = new System.Drawing.Size(142, 25);
            this.добавитьВСписокToolStripMenuItem.Text = "Добавить в список";
            this.добавитьВСписокToolStripMenuItem.Click += new System.EventHandler(this.добавитьВСписокToolStripMenuItem_Click);
            // 
            // удалитьИзСпискаToolStripMenuItem
            // 
            this.удалитьИзСпискаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЗначениюToolStripMenuItem,
            this.поНомеруToolStripMenuItem1});
            this.удалитьИзСпискаToolStripMenuItem.Enabled = false;
            this.удалитьИзСпискаToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.удалитьИзСпискаToolStripMenuItem.Name = "удалитьИзСпискаToolStripMenuItem";
            this.удалитьИзСпискаToolStripMenuItem.Size = new System.Drawing.Size(140, 25);
            this.удалитьИзСпискаToolStripMenuItem.Text = "Удалить из списка";
            // 
            // поЗначениюToolStripMenuItem
            // 
            this.поЗначениюToolStripMenuItem.Name = "поЗначениюToolStripMenuItem";
            this.поЗначениюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поЗначениюToolStripMenuItem.Text = "По значению";
            this.поЗначениюToolStripMenuItem.Click += new System.EventHandler(this.поЗначениюToolStripMenuItem_Click);
            // 
            // поНомеруToolStripMenuItem1
            // 
            this.поНомеруToolStripMenuItem1.Name = "поНомеруToolStripMenuItem1";
            this.поНомеруToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поНомеруToolStripMenuItem1.Text = "По номеру";
            this.поНомеруToolStripMenuItem1.Click += new System.EventHandler(this.поНомеруToolStripMenuItem1_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЗначениюToolStripMenuItem1,
            this.поНомеруToolStripMenuItem2});
            this.поискToolStripMenuItem.Enabled = false;
            this.поискToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поЗначениюToolStripMenuItem1
            // 
            this.поЗначениюToolStripMenuItem1.Name = "поЗначениюToolStripMenuItem1";
            this.поЗначениюToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поЗначениюToolStripMenuItem1.Text = "По значению";
            this.поЗначениюToolStripMenuItem1.Click += new System.EventHandler(this.поЗначениюToolStripMenuItem1_Click);
            // 
            // поНомеруToolStripMenuItem2
            // 
            this.поНомеруToolStripMenuItem2.Name = "поНомеруToolStripMenuItem2";
            this.поНомеруToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.поНомеруToolStripMenuItem2.Text = "По номеру";
            this.поНомеруToolStripMenuItem2.Click += new System.EventHandler(this.поНомеруToolStripMenuItem2_Click);
            // 
            // N_Label
            // 
            this.N_Label.AutoSize = true;
            this.N_Label.BackColor = System.Drawing.Color.Transparent;
            this.N_Label.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N_Label.Location = new System.Drawing.Point(12, 38);
            this.N_Label.Name = "N_Label";
            this.N_Label.Size = new System.Drawing.Size(130, 33);
            this.N_Label.TabIndex = 7;
            this.N_Label.Text = "Введите N:";
            this.N_Label.Visible = false;
            // 
            // N_Input
            // 
            this.N_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.N_Input.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N_Input.Location = new System.Drawing.Point(148, 34);
            this.N_Input.Name = "N_Input";
            this.N_Input.Size = new System.Drawing.Size(100, 41);
            this.N_Input.TabIndex = 8;
            this.N_Input.Visible = false;
            this.N_Input.TextChanged += new System.EventHandler(this.N_Input_TextChanged);
            this.N_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.N_Input_KeyDown);
            // 
            // List_Output
            // 
            this.List_Output.AutoSize = true;
            this.List_Output.BackColor = System.Drawing.Color.Transparent;
            this.List_Output.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_Output.Location = new System.Drawing.Point(12, 88);
            this.List_Output.Name = "List_Output";
            this.List_Output.Size = new System.Drawing.Size(91, 33);
            this.List_Output.TabIndex = 9;
            this.List_Output.Text = "Список:";
            this.List_Output.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PracticeTask9.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(481, 244);
            this.Controls.Add(this.List_Output);
            this.Controls.Add(this.N_Input);
            this.Controls.Add(this.N_Label);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список из чисел";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЗначениюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНомеруToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЗначениюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поНомеруToolStripMenuItem2;
        private System.Windows.Forms.Label N_Label;
        private System.Windows.Forms.TextBox N_Input;
        private System.Windows.Forms.Label List_Output;
    }
}

