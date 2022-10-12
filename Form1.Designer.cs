namespace HW5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPageNum = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxAuthors = new System.Windows.Forms.TextBox();
            this.textBoxExpireTime = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxMeasurementUnit = new System.Windows.Forms.TextBox();
            this.buttonBookTable = new System.Windows.Forms.Button();
            this.buttonFoodTable = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPageNum = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.labelExpireDate = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelMeasurementUnit = new System.Windows.Forms.Label();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.pictureBoxBooksFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooksFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.RowHeadersWidth = 51;
            this.dataGridViewFood.RowTemplate.Height = 29;
            this.dataGridViewFood.Size = new System.Drawing.Size(727, 521);
            this.dataGridViewFood.TabIndex = 0;
            this.dataGridViewFood.Visible = false;
            this.dataGridViewFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(745, 516);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(131, 42);
            this.buttonAddBook.TabIndex = 1;
            this.buttonAddBook.Text = "Додати книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Visible = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Location = new System.Drawing.Point(1090, 515);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(132, 42);
            this.buttonAddFood.TabIndex = 2;
            this.buttonAddFood.Text = "Додати продукт";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Visible = false;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(895, 90);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 27);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Visible = false;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(895, 143);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(207, 27);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.Visible = false;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(895, 196);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(207, 27);
            this.textBoxCountry.TabIndex = 5;
            this.textBoxCountry.Visible = false;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(895, 249);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(207, 27);
            this.textBoxDate.TabIndex = 6;
            this.textBoxDate.Visible = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(895, 302);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(207, 27);
            this.textBoxDescription.TabIndex = 7;
            this.textBoxDescription.Visible = false;
            // 
            // textBoxPageNum
            // 
            this.textBoxPageNum.Location = new System.Drawing.Point(778, 367);
            this.textBoxPageNum.Name = "textBoxPageNum";
            this.textBoxPageNum.Size = new System.Drawing.Size(156, 27);
            this.textBoxPageNum.TabIndex = 8;
            this.textBoxPageNum.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(882, 516);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(202, 42);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Видалити останній товар";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(778, 420);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(156, 27);
            this.textBoxPublisher.TabIndex = 10;
            this.textBoxPublisher.Visible = false;
            // 
            // textBoxAuthors
            // 
            this.textBoxAuthors.Location = new System.Drawing.Point(778, 473);
            this.textBoxAuthors.Name = "textBoxAuthors";
            this.textBoxAuthors.Size = new System.Drawing.Size(156, 27);
            this.textBoxAuthors.TabIndex = 11;
            this.textBoxAuthors.Visible = false;
            // 
            // textBoxExpireTime
            // 
            this.textBoxExpireTime.Location = new System.Drawing.Point(1040, 367);
            this.textBoxExpireTime.Name = "textBoxExpireTime";
            this.textBoxExpireTime.Size = new System.Drawing.Size(156, 27);
            this.textBoxExpireTime.TabIndex = 12;
            this.textBoxExpireTime.Visible = false;
            this.textBoxExpireTime.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(1040, 420);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(156, 27);
            this.textBoxQuantity.TabIndex = 13;
            this.textBoxQuantity.Visible = false;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBoxMeasurementUnit
            // 
            this.textBoxMeasurementUnit.Location = new System.Drawing.Point(1040, 471);
            this.textBoxMeasurementUnit.Name = "textBoxMeasurementUnit";
            this.textBoxMeasurementUnit.Size = new System.Drawing.Size(156, 27);
            this.textBoxMeasurementUnit.TabIndex = 14;
            this.textBoxMeasurementUnit.Visible = false;
            // 
            // buttonBookTable
            // 
            this.buttonBookTable.Location = new System.Drawing.Point(755, 12);
            this.buttonBookTable.Name = "buttonBookTable";
            this.buttonBookTable.Size = new System.Drawing.Size(179, 35);
            this.buttonBookTable.TabIndex = 15;
            this.buttonBookTable.Text = "Таблиця книг";
            this.buttonBookTable.UseVisualStyleBackColor = true;
            this.buttonBookTable.Click += new System.EventHandler(this.buttonBookTable_Click);
            // 
            // buttonFoodTable
            // 
            this.buttonFoodTable.Location = new System.Drawing.Point(1040, 12);
            this.buttonFoodTable.Name = "buttonFoodTable";
            this.buttonFoodTable.Size = new System.Drawing.Size(179, 35);
            this.buttonFoodTable.TabIndex = 16;
            this.buttonFoodTable.Text = "Таблиця продуктів";
            this.buttonFoodTable.UseVisualStyleBackColor = true;
            this.buttonFoodTable.Click += new System.EventHandler(this.buttonFoodTable_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(968, 67);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Назва";
            this.labelName.Visible = false;
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(978, 120);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 20);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Ціна";
            this.labelPrice.Visible = false;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(930, 173);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(147, 20);
            this.labelCountry.TabIndex = 19;
            this.labelCountry.Text = "Країна походження";
            this.labelCountry.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(944, 226);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(118, 20);
            this.labelDate.TabIndex = 20;
            this.labelDate.Text = "Дата пакування";
            this.labelDate.Visible = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(974, 279);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(45, 20);
            this.labelDescription.TabIndex = 21;
            this.labelDescription.Text = "Опис";
            this.labelDescription.Visible = false;
            this.labelDescription.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelPageNum
            // 
            this.labelPageNum.AutoSize = true;
            this.labelPageNum.Location = new System.Drawing.Point(790, 344);
            this.labelPageNum.Name = "labelPageNum";
            this.labelPageNum.Size = new System.Drawing.Size(134, 20);
            this.labelPageNum.TabIndex = 22;
            this.labelPageNum.Text = "Кількість сторінок";
            this.labelPageNum.Visible = false;
            this.labelPageNum.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(804, 397);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(101, 20);
            this.labelPublisher.TabIndex = 23;
            this.labelPublisher.Text = "Видавництво";
            this.labelPublisher.Visible = false;
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Location = new System.Drawing.Point(790, 450);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(120, 20);
            this.labelAuthors.TabIndex = 24;
            this.labelAuthors.Text = "Перелік авторів";
            this.labelAuthors.Visible = false;
            // 
            // labelExpireDate
            // 
            this.labelExpireDate.AutoSize = true;
            this.labelExpireDate.Location = new System.Drawing.Point(1050, 344);
            this.labelExpireDate.Name = "labelExpireDate";
            this.labelExpireDate.Size = new System.Drawing.Size(146, 20);
            this.labelExpireDate.TabIndex = 25;
            this.labelExpireDate.Text = "Термін придатності";
            this.labelExpireDate.Visible = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(1061, 397);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(121, 20);
            this.labelQuantity.TabIndex = 26;
            this.labelQuantity.Text = "Кількість товару";
            this.labelQuantity.Visible = false;
            // 
            // labelMeasurementUnit
            // 
            this.labelMeasurementUnit.AutoSize = true;
            this.labelMeasurementUnit.Location = new System.Drawing.Point(1061, 448);
            this.labelMeasurementUnit.Name = "labelMeasurementUnit";
            this.labelMeasurementUnit.Size = new System.Drawing.Size(124, 20);
            this.labelMeasurementUnit.TabIndex = 27;
            this.labelMeasurementUnit.Text = "Одиниця виміру";
            this.labelMeasurementUnit.Visible = false;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 29;
            this.dataGridViewBooks.Size = new System.Drawing.Size(727, 521);
            this.dataGridViewBooks.TabIndex = 28;
            this.dataGridViewBooks.Visible = false;
            // 
            // pictureBoxBooksFood
            // 
            this.pictureBoxBooksFood.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBooksFood.Image")));
            this.pictureBoxBooksFood.Location = new System.Drawing.Point(12, 36);
            this.pictureBoxBooksFood.Name = "pictureBoxBooksFood";
            this.pictureBoxBooksFood.Size = new System.Drawing.Size(727, 521);
            this.pictureBoxBooksFood.TabIndex = 29;
            this.pictureBoxBooksFood.TabStop = false;
            this.pictureBoxBooksFood.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 569);
            this.Controls.Add(this.pictureBoxBooksFood);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.labelMeasurementUnit);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelExpireDate);
            this.Controls.Add(this.labelAuthors);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelPageNum);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonFoodTable);
            this.Controls.Add(this.buttonBookTable);
            this.Controls.Add(this.textBoxMeasurementUnit);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxExpireTime);
            this.Controls.Add(this.textBoxAuthors);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxPageNum);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddFood);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.dataGridViewFood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooksFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewFood;
        private Button buttonAddBook;
        private Button buttonAddFood;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxCountry;
        private TextBox textBoxDate;
        private TextBox textBoxDescription;
        private TextBox textBoxPageNum;
        private Button buttonDelete;
        private TextBox textBoxPublisher;
        private TextBox textBoxAuthors;
        private TextBox textBoxExpireTime;
        private TextBox textBoxQuantity;
        private TextBox textBoxMeasurementUnit;
        private Button buttonBookTable;
        private Button buttonFoodTable;
        private Label labelName;
        private Label labelPrice;
        private Label labelCountry;
        private Label labelDate;
        private Label labelDescription;
        private Label labelPageNum;
        private Label labelPublisher;
        private Label labelAuthors;
        private Label labelExpireDate;
        private Label labelQuantity;
        private Label labelMeasurementUnit;
        private DataGridView dataGridViewBooks;
        private PictureBox pictureBoxBooksFood;
    }
}