namespace HW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "Назва";
            dataGridView1.Columns[1].Name = "Ціна";
            dataGridView1.Columns[2].Name = "Країна походження";
            dataGridView1.Columns[3].Name = "Дата пакування";
            dataGridView1.Columns[4].Name = "Термін придатності";
            dataGridView1.Columns[5].Name = "Кількість";
            dataGridView1.Columns[6].Name = "Одиниця виміру";
            dataGridView1.Columns[7].Name = "Кількість сторінок";
            dataGridView1.Columns[8].Name = "Видавництво";
            dataGridView1.Columns[9].Name = "Перелік авторів";
            dataGridView1.Columns[10].Name = "Опис";
            dataGridView1.AllowUserToAddRows= false;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Books book = new Books();
            bool success = true;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Назву не введено!");
                success = false;
            }
            else book.setName(textBox1.Text);

            double temporaryPrice;
            if (textBox2.Text == "")
            {
                success = false;
                MessageBox.Show("Ціну не введено!");
            }
            else if (!Double.TryParse(textBox2.Text, out temporaryPrice))
            {
                MessageBox.Show("Ви ввели неправильну ціну!");
                success = false;
                textBox2.Clear();
            }
            else book.setPrice(temporaryPrice);

            if (textBox3.Text == "")
            {
                MessageBox.Show("Країну не введено!");
                success = false;
            }
            else book.setCountry(textBox3.Text);


            DateTime dateTemp;
            if (textBox4.Text == "")
            {
                MessageBox.Show("Дату пакування не введено!");
                success = false;
            }
            else if(!DateTime.TryParse(textBox4.Text, out dateTemp))
            {
                MessageBox.Show("Дату пакування введено неправильно!");
                success=false;
                textBox4.Clear();
            }
            else book.setDate(dateTemp);




            if (textBox5.Text == "")
            {
                MessageBox.Show("Опис не введено!");
                success = false;
            }
            else book.setDescription(textBox5.Text);

            int tempPageNum;
            if (textBox6.Text == "")
            {
                MessageBox.Show("Кількість сторінок не введено!");
                success = false;
            }
            else if (!int.TryParse(textBox6.Text, out tempPageNum))
            {
                MessageBox.Show("Кількість сторінок введено неправильно!");
                success = false;
                textBox2.Clear();
            }
            else book.setPageNum(tempPageNum);


            if (textBox7.Text == "")
            {
                MessageBox.Show("Видавництво не введено!");
                success = false;
            }
            else book.setPublisher(textBox7.Text);

            if (textBox8.Text == "")
            {
                MessageBox.Show("Список авторів не введено!");
                success = false;
            }
            else book.setAuthors(textBox8.Text);

            if (success)
            {
                dataGridView1.Rows.Add(book.getName(), book.getPrice(), book.getCountry(), book.getDate(), "", "", "", book.getPageNum(), book.getPublisher(), book.getAuthors(), book.getDescription());
                ClearTextbox();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            ClearTextbox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            label1.Visible= true;
            label2.Visible= true;
            label3.Visible= true;
            label4.Visible= true;
            label5.Visible= true;
            label6.Visible= false;
            label7.Visible= false;
            label8.Visible= false;
            label9.Visible= true;
            label10.Visible= true;
            label11.Visible= true;
            ClearTextbox();
        }
        public void ClearTextbox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Foods food = new Foods();
            bool success = true;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Назву не введено!");
                success = false;
            }
            else food.setName(textBox1.Text);

            double temporaryPrice;
            if (textBox2.Text == "")
            {
                success = false;
                MessageBox.Show("Ціну не введено!");
            }
            else if (!Double.TryParse(textBox2.Text, out temporaryPrice))
            {
                MessageBox.Show("Ви ввели неправильну ціну!");
                success = false;
                textBox2.Clear();
            }
            else food.setPrice(temporaryPrice);

            if (textBox3.Text == "")
            {
                MessageBox.Show("Країну не введено!");
                success = false;
            }
            else food.setCountry(textBox3.Text);



            DateTime dateTemp;
            if (textBox4.Text == "")
            {
                MessageBox.Show("Дату пакування не введено!");
                success = false;
            }
            else if (!DateTime.TryParse(textBox4.Text, out dateTemp))
            {
                MessageBox.Show("Дату пакування введено неправильно!");
                success = false;
                textBox4.Clear();
            }
            else food.setDate(dateTemp);


            if (textBox5.Text == "")
            {
                MessageBox.Show("Опис не введено!");
                success = false;
            }
            else food.setDescription(textBox5.Text);



            if (textBox9.Text == "")
            {
                MessageBox.Show("Термін придатності не введено!");
                success = false;
            }
            else food.setExpire(textBox9.Text);

            if (textBox11.Text == "")
            {
                MessageBox.Show("Одиницю виміру не введено!");
                success = false;
            }
            else food.setMeasurement(textBox11.Text);

            double temporaryQuantity;
            if (textBox10.Text == "")
            {
                success = false;
                MessageBox.Show("Кількість товару не введено!");
            }
            else if (!Double.TryParse(textBox10.Text, out temporaryQuantity))
            {
                MessageBox.Show("Ви ввели неправильну кількість товару!");
                success = false;
                textBox2.Clear();
            }
            else food.setQuantity(temporaryQuantity);

            if (success)
            {
                dataGridView1.Rows.Add(food.getName(), food.getPrice(), food.getCountry(), food.getDate(), food.getExpire(), food.getQuantity(), food.getMeasurement(), "", "", "", food.getDescription());
                ClearTextbox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowNumber = dataGridView1.RowCount;
            dataGridView1.Rows.RemoveAt(rowNumber - 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}