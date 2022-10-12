namespace HW5
{
    public partial class Form1 : Form
    {
        private List<Books> booksList=new List<Books>();
        private List<Foods> foodList=new List<Foods>();
        public Form1()
        {
            InitializeComponent();
            dataGridViewFood.ColumnCount = 8;
            dataGridViewFood.Columns[0].Name = "�����";
            dataGridViewFood.Columns[1].Name = "ֳ��";
            dataGridViewFood.Columns[2].Name = "����� ����������";
            dataGridViewFood.Columns[3].Name = "���� ���������";
            dataGridViewFood.Columns[4].Name = "����� ����������";
            dataGridViewFood.Columns[5].Name = "ʳ������";
            dataGridViewFood.Columns[6].Name = "������� �����";
            dataGridViewFood.Columns[7].Name = "����";
            dataGridViewFood.AllowUserToAddRows= false;

            dataGridViewBooks.ColumnCount = 8;
            dataGridViewBooks.Columns[0].Name = "�����";
            dataGridViewBooks.Columns[1].Name = "ֳ��";
            dataGridViewBooks.Columns[2].Name = "����� ����������";
            dataGridViewBooks.Columns[3].Name = "���� ���������";
            dataGridViewBooks.Columns[4].Name = "ʳ������ �������";
            dataGridViewBooks.Columns[5].Name = "�����������";
            dataGridViewBooks.Columns[6].Name = "������ ������";
            dataGridViewBooks.Columns[7].Name = "����";
            dataGridViewBooks.AllowUserToAddRows = false;
        }

        private bool CheckString(string line, string phrase)
        {
            if (line == "")
            {
                MessageBox.Show($"{phrase} �� �������!");
                return false;
            }
            else return true;
        }

        private bool CheckDouble(string line, string phrase)
        {
            double temporary;
            if (line == "")
            {
                MessageBox.Show($"{phrase} �� �������!");
                return false;
            }
            else if (!double.TryParse(line, out temporary))
            {
                MessageBox.Show($"{phrase} ������� �����������!");
                return false;
            }
            else if (temporary <= 0)
            {
                MessageBox.Show($"{phrase} ������� ��������� ���������!");
                return false;
            }
            else return true;
        }

        private bool CheckInt(string line, string phrase)
        {
            int temporary;
            if (line == "")
            {
                MessageBox.Show($"{phrase} �� �������!");
                return false;
            }
            else if (!int.TryParse(line, out temporary))
            {
                MessageBox.Show($"{phrase} ������� �����������!");
                return false;
            }
            else if (temporary <= 0)
            {
                MessageBox.Show($"{phrase} ������� ��������� ���������!");
                return false;
            }
            else return true;
        }

        private bool CheckDate(string line, string phrase)
        {
            DateTime dateTemp;
            if (line == "")
            {
                MessageBox.Show($"{phrase} �� �������!");
                return false;
            }
            else if (!DateTime.TryParse(line, out dateTemp))
            {
                MessageBox.Show($"{phrase} ������� �����������!");
                return false;
            }
            else return true;
        }

        private bool StandartFilling(Goods goods)
        {
            bool success = true;
            if (!CheckString(textBoxName.Text, "�����")) success = false;
            else goods.Name=textBoxName.Text;

            if (!CheckDouble(textBoxPrice.Text, "ֳ��"))
            {
                success = false;
                textBoxPrice.Clear();
            }
            else goods.Price=double.Parse(textBoxPrice.Text);

            if (!CheckString(textBoxCountry.Text, "����� ����������")) success = false;
            else goods.Country=textBoxCountry.Text;

            if (!CheckDate(textBoxDate.Text, "���� ���������"))
            {
                success = false;
                textBoxDate.Clear();
            }
            else goods.Date=DateTime.Parse(textBoxDate.Text);

            if (!CheckString(textBoxDescription.Text, "���� ������")) success = false;
            else goods.Description=textBoxDescription.Text;
            return success;
        }

        private bool AddBook()
        {
            Books book = new Books();
            bool success=StandartFilling(book);
            
            if (!CheckInt(textBoxPageNum.Text, "ʳ������ �������"))
            {
                success = false;
                textBoxPageNum.Clear();
            }
            else book.PageNum=int.Parse(textBoxPageNum.Text);

            if (!CheckString(textBoxPublisher.Text, "�����������")) success = false;
            else book.Publisher=textBoxPublisher.Text;

            if (!CheckString(textBoxAuthors.Text, "������ ������")) success = false;
            else book.Authors=textBoxAuthors.Text;
            booksList.Add(book);
            return success;
        }
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            
            if (AddBook())
            {
                dataGridViewBooks.Rows.Add(booksList.Last().Name, booksList.Last().Price, booksList.Last().Country, booksList.Last().Date, booksList.Last().PageNum, booksList.Last().Publisher, booksList.Last().Authors, booksList.Last().Description);
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

        private void ShowBookMenu()
        {
            textBoxName.Visible = true;
            textBoxPrice.Visible = true;
            textBoxCountry.Visible = true;
            textBoxDate.Visible = true;
            textBoxDescription.Visible = true;
            textBoxPageNum.Visible = true;
            textBoxPublisher.Visible = true;
            textBoxAuthors.Visible = true;
            textBoxExpireTime.Visible = false;
            textBoxQuantity.Visible = false;
            textBoxMeasurementUnit.Visible = false;
            buttonAddBook.Visible = true;
            buttonAddFood.Visible = false;
            buttonDelete.Visible = true;
            labelName.Visible = true;
            labelPrice.Visible = true;
            labelCountry.Visible = true;
            labelDate.Visible = true;
            labelDescription.Visible = true;
            labelPageNum.Visible = true;
            labelPublisher.Visible = true;
            labelAuthors.Visible = true;
            labelExpireDate.Visible = false;
            labelQuantity.Visible = false;
            labelMeasurementUnit.Visible = false;
            ClearTextbox();
            dataGridViewFood.Visible = false;
            dataGridViewBooks.Visible = true;
            pictureBoxBooksFood.Visible = false;
        }
        private void buttonBookTable_Click(object sender, EventArgs e)
        {
            ShowBookMenu();
        }

        private void ShowFoodMenu()
        {
            textBoxName.Visible = true;
            textBoxPrice.Visible = true;
            textBoxCountry.Visible = true;
            textBoxDate.Visible = true;
            textBoxDescription.Visible = true;
            textBoxPageNum.Visible = false;
            textBoxPublisher.Visible = false;
            textBoxAuthors.Visible = false;
            textBoxExpireTime.Visible = true;
            textBoxQuantity.Visible = true;
            textBoxMeasurementUnit.Visible = true;
            buttonAddBook.Visible = false;
            buttonAddFood.Visible = true;
            buttonDelete.Visible = true;
            labelName.Visible= true;
            labelPrice.Visible= true;
            labelCountry.Visible= true;
            labelDate.Visible= true;
            labelDescription.Visible= true;
            labelPageNum.Visible= false;
            labelPublisher.Visible= false;
            labelAuthors.Visible= false;
            labelExpireDate.Visible= true;
            labelQuantity.Visible= true;
            labelMeasurementUnit.Visible= true;
            ClearTextbox();
            dataGridViewBooks.Visible = false;
            dataGridViewFood.Visible = true;
            pictureBoxBooksFood.Visible = false;
        }

        private void buttonFoodTable_Click(object sender, EventArgs e)
        {
            ShowFoodMenu();
        }
        public void ClearTextbox()
        {
            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxCountry.Clear();
            textBoxDate.Clear();
            textBoxDescription.Clear();
            textBoxPageNum.Clear();
            textBoxPublisher.Clear();
            textBoxAuthors.Clear();
            textBoxExpireTime.Clear();
            textBoxQuantity.Clear();
            textBoxMeasurementUnit.Clear();
        }

        private bool AddFood()
        {
            Foods food = new Foods();
            bool success=StandartFilling(food);
            

            if (!CheckString(textBoxExpireTime.Text, "����� ����������")) success = false;
            else food.ExpireTime=textBoxExpireTime.Text;


            if (!CheckString(textBoxMeasurementUnit.Text, "������� �����")) success = false;
            else food.MeasurementUnit=textBoxMeasurementUnit.Text;

            if (!CheckDouble(textBoxQuantity.Text, "ʳ������ ������"))
            {
                success = false;
                textBoxQuantity.Clear();
            }
            else food.Quantity=double.Parse(textBoxQuantity.Text);
            foodList.Add(food);
            return success;
            
        }
        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            

            if (AddFood())
            {
                dataGridViewFood.Rows.Add(foodList.Last().Name, foodList.Last().Price, foodList.Last().Country, foodList.Last().Date, foodList.Last().ExpireTime, foodList.Last().Quantity, foodList.Last().MeasurementUnit, foodList.Last().Description);
                ClearTextbox();
                
            }
        }
        private void DeleteLastRow()
        {
            if (dataGridViewBooks.Visible == true)
            {
                int rowNumber = dataGridViewBooks.RowCount;
                if (rowNumber == 0)
                {
                    MessageBox.Show("������ ����");
                }
                else
                { 
                    dataGridViewBooks.Rows.RemoveAt(rowNumber - 1);
                    booksList.RemoveAt(rowNumber - 1);
                } 
            }

            else if (dataGridViewFood.Visible == true)
            {
                int rowNumber = dataGridViewFood.RowCount;
                if (rowNumber == 0)
                {
                    MessageBox.Show("�������� ����");
                }
                else 
                { 
                    dataGridViewFood.Rows.RemoveAt(rowNumber - 1);
                    foodList.RemoveAt(rowNumber - 1);
                }
                
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteLastRow();
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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}