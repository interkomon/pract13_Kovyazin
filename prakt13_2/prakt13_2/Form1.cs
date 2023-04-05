using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace prakt13_2
{
    public partial class Form1 : Form
    {
/*        private IList<Student> studentList = new List<Student>();
        private void addStudent(string name, string surname, string recordBookNumber)
        {
            Student s = new Student(name, surname, recordBookNumber);
            studentList.Add(s);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";
            showListInGrid();
        }

        private void deleteStudent(int elementIndex)
        {
            studentList.RemoveAt(elementIndex);
            showListInGrid();
        }

        private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Student s in studentList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new
                DataGridViewTextBoxCell();
                cell1.ValueType = typeof(string);
                cell1.Value = s.getName();
                cell2.ValueType = typeof(string);
                cell2.Value = s.getFam();
                cell3.ValueType = typeof(string);
                cell3.Value = s.getNomer();
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                dataGridView1.Rows.Add(row);
            }
        }
        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;

        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;


        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.AutoResizeColumns();
        }

        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Имя";
                dataGridViewColumn1.ValueType = typeof(string);
                dataGridViewColumn1.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn1;
        }

        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Фамилия";
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn2;
        }

        private DataGridViewColumn getDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Зачетка";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addStudent(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Удалить студента?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    deleteStudent(selectedRow);
                }
                catch (Exception)
                {
                }
            }
        }*/



        private LinkedList<Mebel> mebl = new LinkedList<Mebel>();
        private void addMebel(string name, string material, string mesizg, string pokupatel, string adres)
        {
            Mebel meb = new Mebel(name,material,mesizg,material,adres);
            
            mebl.AddFirst(meb);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
            showListInGrid();
        }

        

        private void deleteMebel(int elementIndex)
        {
            
            mebl.RemoveLast();
            showListInGrid();
        }

        
        private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
            
                foreach (Mebel me in mebl)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell m1 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell m2 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell m3 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell m4 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell m5 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell m6 = new
                DataGridViewTextBoxCell();
                m1.ValueType = typeof(string);
                m1.Value = me.getName();
                m2.ValueType = typeof(int);
                m2.Value = me.getMaterial();
                m3.ValueType = typeof(string);
                m3.Value = me.getMesizg();
                m4.ValueType = typeof(string);
                m4.Value = me.getMaterial();
                m5.ValueType = typeof(int);
                m5.Value = me.getAdres();
                m6.ValueType = typeof(string);
                m6.Value = me.getStoimost();
                row.Cells.Add(m1);
                row.Cells.Add(m2);
                row.Cells.Add(m3);
                row.Cells.Add(m4);
                row.Cells.Add(m5);
                row.Cells.Add(m6);
                dataGridView1.Rows.Add(row);
            }
        }


        

        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;
        private DataGridViewColumn dataGridViewColumn4 = null;
        private DataGridViewColumn dataGridViewColumn5 = null;
        private DataGridViewColumn dataGridViewColumn6 = null;

        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.Columns.Add(getDataGridViewColumn4());
            dataGridView1.Columns.Add(getDataGridViewColumn5());
            dataGridView1.Columns.Add(getDataGridViewColumn6());
            dataGridView1.AutoResizeColumns();
        }

        

        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Название";
                dataGridViewColumn1.ValueType = typeof(string);
                dataGridViewColumn1.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn1;
        }
        
        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Материал";
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn2;
        }
        
        private DataGridViewColumn getDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Месяц изготовления";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn3;
        }

        private DataGridViewColumn getDataGridViewColumn4()
        {
            if (dataGridViewColumn4 == null)
            {
                dataGridViewColumn4 = new DataGridViewTextBoxColumn();
                dataGridViewColumn4.Name = "";
                dataGridViewColumn4.HeaderText = "Покупатель";
                dataGridViewColumn4.ValueType = typeof(string);
                dataGridViewColumn4.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn4;
        }

        private DataGridViewColumn getDataGridViewColumn5()
        {
            if (dataGridViewColumn5 == null)
            {
                dataGridViewColumn5 = new DataGridViewTextBoxColumn();
                dataGridViewColumn5.Name = "";
                dataGridViewColumn5.HeaderText = "Адрес доставки";
                dataGridViewColumn5.ValueType = typeof(string);
                dataGridViewColumn5.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn5;
        }

        private DataGridViewColumn getDataGridViewColumn6()
        {
            if (dataGridViewColumn6 == null)
            {
                dataGridViewColumn6 = new DataGridViewTextBoxColumn();
                dataGridViewColumn6.Name = "";
                dataGridViewColumn6.HeaderText = "Стоимость доставки";
                dataGridViewColumn6.ValueType = typeof(int);
                dataGridViewColumn6.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn6;
        }

        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        

        private void button1_Click(object sender, EventArgs e)
        {
                Regex regex1 = new Regex("^[а-яА-Я]+$");
                
                string name = textBox1.Text;
                if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Проверьте и заполнителе поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else  
                if(!regex1.IsMatch(textBox1.Text))
                {
                MessageBox.Show("Можно вводить только буквы в название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 else if (!regex1.IsMatch(textBox2.Text))
                {
                MessageBox.Show("Можно вводить только буквы в материале", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                else if (!regex1.IsMatch(textBox4.Text))
                 {
                MessageBox.Show("Можно вводить только буквы в материале", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                else
                 if (!regex1.IsMatch(textBox3.Text))
                  {
                MessageBox.Show("Можно вводить только буквы в материале", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                else 


                addMebel(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
              
            
           
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Удалить мебель?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    deleteMebel(selectedRow);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка","Информация");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();

            if(!string.IsNullOrEmpty(name))
            {
                bool exists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(name))
                    {
                        exists = true;
                        break;
                    }
                }
                if(exists)
                {
                    MessageBox.Show("Такое название уже есть", "Ошибка");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

