using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTask9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OneList list;
        int n;
        Label Add_label, Remove_Label, Search_Label;
        TextBox Add_TextBox, Remove_TextBox, Search_TextBox;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void создатьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_All();
            N_Label.Visible = true;
            N_Input.Visible = true;
            N_Input.Focus();
        }

        private void N_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void N_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                if (int.TryParse(N_Input.Text, out n)) // Введено целое число
                {
                    if (n > 0 && n <= 20) // Число от 1 до 20
                    {
                        Remove_All(); // Очистка формы
                        list = new OneList(n); // Создание списка
                        List_Output.Text = list.Show(); // Вывод списка
                        List_Output.Visible = true;
                        // Доступны другие пункты меню
                        добавитьВСписокToolStripMenuItem.Enabled = true;
                        удалитьИзСпискаToolStripMenuItem.Enabled = true;
                        поискToolStripMenuItem.Enabled = true;
                    }
                    else MessageBox.Show("N должно быть в диапазоне от 1 до 20!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Введите целое число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Add_Attributes(int case_value) // Создание элементов управления для интерфейса
        {
            Label Input_label = new Label()
            {
                Name = "Add_Label",
                Text = "Введите добавляемое число:",
                AutoSize = true,
                Location = new System.Drawing.Point(List_Output.Location.X, List_Output.Location.Y + List_Output.Height + 20),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Font = N_Input.Font
            };
            Controls.Add(Input_label);
            TextBox Input_TextBox = new TextBox() // Текстбокс для ввода
            {
                Size = new Size(60, 50),
                BackColor = Color.FromArgb(255, 245, 248),
                ForeColor = Color.Black,
                Font = N_Input.Font
            };
            Controls.Add(Input_TextBox);
            switch(case_value)
            {
                case 0: // Добавление в список
                    {
                        Input_label.Name = "Add_Label";
                        Input_TextBox.Name = "Add_TextBox";
                        Input_label.Text = "Введите число:";
                        Input_TextBox.KeyDown += new KeyEventHandler(Add_TextBox_KeyDown);
                        Add_label = Input_label;
                        Add_TextBox = Input_TextBox;
                        break;
                    }
                case 1: // Удаление по значению
                    {
                        Input_label.Name = "Remove_Label";
                        Input_TextBox.Name = "Remove_TextBox";
                        Input_label.Text = "Введите число:";
                        Input_TextBox.KeyDown += new KeyEventHandler(Remove_TextBox1_KeyDown);
                        Remove_Label = Input_label;
                        Remove_TextBox = Input_TextBox;
                        break;
                    }
                case 2: // Удаление по номеру
                    {
                        Input_label.Name = "Remove_Label";
                        Input_TextBox.Name = "Remove_TextBox";
                        Input_label.Text = "Введите индекс:";
                        Input_TextBox.KeyDown += new KeyEventHandler(Remove_TextBox2_KeyDown);
                        Remove_Label = Input_label;
                        Remove_TextBox = Input_TextBox;
                        break;
                    }
                case 3: // Поиск по значению
                    {
                        Input_label.Name = "Search_Label";
                        Input_TextBox.Name = "Search_TextBox";
                        Input_label.Text = "Введите число:";
                        Input_TextBox.KeyDown += new KeyEventHandler(Search_TextBox1_KeyDown);
                        Search_Label = Input_label;
                        Search_TextBox = Input_TextBox;
                        break;
                    }
                case 4: // Поиск по номеру
                    {
                        Input_label.Name = "Search_Label";
                        Input_TextBox.Name = "Search_TextBox";
                        Input_label.Text = "Введите индекс:";
                        Input_TextBox.KeyDown += new KeyEventHandler(Search_TextBox2_KeyDown);
                        Search_Label = Input_label;
                        Search_TextBox = Input_TextBox;
                        break;
                    }
            }
            Input_TextBox.Location = new System.Drawing.Point(Input_label.Location.X + Input_label.Width + 10, Input_label.Location.Y);
            Input_TextBox.Focus();
        }
        void Remove_Labels(params Label[] labels) // Удаление всех меток с формы
        {
            for(int i = 0; i < labels.Length; i++)
            {
                if (labels[i] != null)
                {
                    Controls.RemoveByKey(labels[i].Name);
                    labels[i] = null;
                }
            }
        }
        void Remove_TextBoxes(params TextBox[] textboxes) // Удаление всех текстбоксов с формы
        {
            for (int i = 0; i < textboxes.Length; i++)
            {
                if (textboxes[i] != null)
                {
                    Controls.RemoveByKey(textboxes[i].Name);
                    textboxes[i] = null;
                }
            }
        }
        void Remove_All() // Удаление меток и текстбоксов с формы
        { 
            Remove_Labels(Add_label, Remove_Label, Search_Label);
            Remove_TextBoxes(Add_TextBox, Remove_TextBox, Search_TextBox);
        }
        private void Add_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                int number = 0;
                if (int.TryParse(Add_TextBox.Text, out number)) // Введено целое число
                {
                    if (number >= 1)
                    {
                        Point point = new Point(number); // Создание элемента списка с информационным полем number
                        if (list.Search(point) == -1) // Если такого элемента еще нет в списке
                        {
                            list.Add(point); // Добавление в список
                            List_Output.Text = list.Show();
                        }
                        else MessageBox.Show("Такое число уже добавлено в список!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Введено ненатуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Введите натуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Remove_TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                int number = 0;
                if (int.TryParse(Remove_TextBox.Text, out number)) // Введено целое число
                {
                    if (number >= 1)
                    {
                        if (list != null) // Список не пустой
                        {
                            Point point = new Point(number); // Создание элемента списка с информационным полем number
                            if (!list.Remove(point)) MessageBox.Show("Элемент для удаления не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                MessageBox.Show("Элемент удален из списка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                List_Output.Text = list.Show();
                            }
                        }
                        else MessageBox.Show("Список пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Введено ненатуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Введите натуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void поЗначениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_All();
            Add_Attributes(case_value: 1);
        }

        private void поНомеруToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Remove_All();
            Add_Attributes(case_value: 2);
        }

        private void поЗначениюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Remove_All();
            Add_Attributes(case_value: 3);
        }

        private void поНомеруToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Remove_All();
            Add_Attributes(case_value: 4);
        }

        private void Remove_TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                int number = 0;
                if (int.TryParse(Remove_TextBox.Text, out number)) // Введено целое число
                {
                    if (number >= 1)
                    {
                        if (list != null) // Список не пустой
                        {
                            if (!list.Remove(number)) MessageBox.Show("Элемент для удаления не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                MessageBox.Show("Элемент удален из списка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                List_Output.Text = list.Show();
                            }
                        }
                        else MessageBox.Show("Список пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Введено ненатуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Введите натуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Search_TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                int number = 0;
                if (int.TryParse(Search_TextBox.Text, out number)) // Введено целое число
                {
                    if (number >= 1)
                    {
                        if (list != null) // Список не пустой
                        {
                            Point point = new Point(number); // Создание элемента списка с информационным полем number
                            int index = list.Search(point); // Поиск по значению
                            if (index == -1) MessageBox.Show("Элемент не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else MessageBox.Show($"Индекс искомого элемента: {index}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Список пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Введено ненатуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Введите натуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Search_TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                int number = 0;
                if (int.TryParse(Search_TextBox.Text, out number)) // Введено целое число
                {
                    if (number >= 1)
                    {
                        if (list != null) // Список не пустой
                        {
                            Point point = list.Search(number); // Поиск по номеру
                            if (point == null) MessageBox.Show("Элемент не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else MessageBox.Show($"Искомый элемент: {point.Number}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Список пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Введено ненатуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Введите натуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void добавитьВСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_All();
            Add_Attributes(case_value: 0);
        }
    }
}