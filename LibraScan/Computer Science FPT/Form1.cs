namespace Computer_Science_FPT
{
    public partial class Form1 : Form
    {
        List<Book> bookList = new List<Book>();
        List<User> userList = new List<User>();

        public int bookSearchID;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (authorTextbox.Text != "" && titleTextbox.Text != "")
                {
                    bookList.Add(new Book(titleTextbox.Text, authorTextbox.Text, int.Parse(bookIdTextbox.Text), int.Parse(isbnTextbox.Text), 0));
                    MessageBox.Show("Book Added");
                    titleTextbox.Clear();
                    authorTextbox.Clear();
                    isbnTextbox.Clear();
                    bookIdTextbox.Clear();
                }
                else
                {
                    MessageBox.Show("Text Field Blank");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
            foreach (Book x in bookList)
            {
                displayTextBox.AppendText(x.Title + " by " + x.Author);
                displayTextBox.AppendText(Environment.NewLine);

            }


        }

        private void bookIdTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Book x in bookList)
            {
                if (int.Parse(bookIdTextbox.Text) == x.BookID)
                {
                    x.ISBN = int.Parse(isbnTextbox.Text);
                    x.Title = titleTextbox.Text;
                    x.Author = authorTextbox.Text;
                    MessageBox.Show("Edits Made Successfully");
                }
                else
                {
                    MessageBox.Show("Book Does Not Exist");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Book x in bookList)
            {
                if (int.Parse(bookIdTextbox.Text) == x.BookID)
                {
                    bookList.Remove(x);
                    MessageBox.Show("Book Deleted Successfully");
                    break;
                }
                else
                {
                    MessageBox.Show("Book Does Not Exist");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (signUpPass1.Text != "" && signUpPass2.Text != "" && signUpUser.Text != "")
            {
                if (signUpPass1.Text == signUpPass2.Text)
                {
                    userList.Add(new User(signUpUser.Text, signUpPass1.Text));
                    MessageBox.Show("Account Succesfully Registered!");
                }
                else
                {
                    MessageBox.Show("Details Invalid: Sign up unsuccessful!");
                }
                signUpUser.Clear();
                signUpPass1.Clear();
                signUpPass2.Clear();
            }
            else
            {
                MessageBox.Show("Text Feild Blank");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (signInPass.Text != "" && signInUser.Text != "")
            {
                foreach (User x in userList)
                {
                    if ((signInUser.Text == x.UserName) && (signInPass.Text == x.Password))
                    {
                        bookOpenBtn.Visible = true;
                        MessageBox.Show("Succesfully Signed In");
                    }
                    else
                    {
                        MessageBox.Show("Account Does Not Exist");
                    }
                    signInUser.Clear();
                    signInPass.Clear();
                }
            }
            else
            {
                MessageBox.Show("Text Field Blank");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bookSearch.Text != "")
            {
                foreach (Book x in bookList)
                {

                    if ((bookSearch.Text == x.Title || bookSearch.Text == x.Author))
                    {
                        MessageBox.Show("Book Successfully Located");
                        bookSearchID = x.BookID;
                        bookOpenBtn.Enabled = true;
                        x.SetNumberOfBookReaders();
                    }
                }
                bookSearch.Clear();
            }
            else
            {
                MessageBox.Show("Text Field Blank");
            }

        }

        private void bookOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader bookread = new StreamReader("b" + bookSearchID + ".txt");
                bookTextbox.Text = bookread.ReadToEnd();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int numOpen = 0;
            foreach (Book x in bookList)
            {
                if (x.GetNumberOfBookReaders() > numOpen)
                {
                    numOpen = x.GetNumberOfBookReaders();
                    displayTextBox.Clear();
                    displayTextBox.AppendText(x.Title + " by " + x.Author + " is the most read book");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (User x in userList)
            {
                displayTextBox.Clear();
                displayTextBox.AppendText(x.UserName);
                displayTextBox.AppendText(Environment.NewLine);
            }
        }

        private void bookSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}