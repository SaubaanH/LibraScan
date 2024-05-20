namespace Computer_Science_FPT
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            bookIdTextbox = new TextBox();
            isbnTextbox = new TextBox();
            label2 = new Label();
            titleTextbox = new TextBox();
            label3 = new Label();
            authorTextbox = new TextBox();
            label4 = new Label();
            signInUser = new TextBox();
            label5 = new Label();
            signInPass = new TextBox();
            label6 = new Label();
            button6 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            signUpUser = new TextBox();
            signUpPass1 = new TextBox();
            signUpPass2 = new TextBox();
            label10 = new Label();
            button7 = new Button();
            bookSearch = new TextBox();
            label11 = new Label();
            bookTextbox = new RichTextBox();
            displayTextBox = new RichTextBox();
            bookOpenBtn = new Button();
            button2 = new Button();
            label12 = new Label();
            button8 = new Button();
            button9 = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(319, 205);
            button1.Name = "button1";
            button1.Size = new Size(123, 27);
            button1.TabIndex = 0;
            button1.Text = "Edit Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(317, 238);
            button3.Name = "button3";
            button3.Size = new Size(125, 27);
            button3.TabIndex = 2;
            button3.Text = "Delete Book";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(319, 171);
            button4.Name = "button4";
            button4.Size = new Size(123, 27);
            button4.TabIndex = 3;
            button4.Text = "Add Book";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(319, 272);
            button5.Name = "button5";
            button5.Size = new Size(123, 27);
            button5.TabIndex = 4;
            button5.Text = "Display Books";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 171);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 5;
            label1.Text = "Book ID:";
            label1.Click += label1_Click;
            // 
            // bookIdTextbox
            // 
            bookIdTextbox.Location = new Point(164, 169);
            bookIdTextbox.Name = "bookIdTextbox";
            bookIdTextbox.Size = new Size(125, 27);
            bookIdTextbox.TabIndex = 6;
            bookIdTextbox.TextChanged += bookIdTextbox_TextChanged;
            // 
            // isbnTextbox
            // 
            isbnTextbox.Location = new Point(164, 202);
            isbnTextbox.Name = "isbnTextbox";
            isbnTextbox.Size = new Size(125, 27);
            isbnTextbox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 205);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "ISBN";
            // 
            // titleTextbox
            // 
            titleTextbox.Location = new Point(164, 236);
            titleTextbox.Name = "titleTextbox";
            titleTextbox.Size = new Size(125, 27);
            titleTextbox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 239);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 9;
            label3.Text = "Title";
            label3.Click += label3_Click;
            // 
            // authorTextbox
            // 
            authorTextbox.Location = new Point(164, 269);
            authorTextbox.Name = "authorTextbox";
            authorTextbox.Size = new Size(125, 27);
            authorTextbox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 272);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 11;
            label4.Text = "Author";
            // 
            // signInUser
            // 
            signInUser.Location = new Point(481, 464);
            signInUser.Name = "signInUser";
            signInUser.Size = new Size(125, 27);
            signInUser.TabIndex = 14;
            signInUser.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 464);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 13;
            label5.Text = "Email Address";
            label5.Click += label5_Click;
            // 
            // signInPass
            // 
            signInPass.Location = new Point(481, 503);
            signInPass.Name = "signInPass";
            signInPass.PasswordChar = '*';
            signInPass.Size = new Size(125, 27);
            signInPass.TabIndex = 16;
            signInPass.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 506);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 15;
            label6.Text = "Password";
            label6.Click += label6_Click;
            // 
            // button6
            // 
            button6.Location = new Point(497, 567);
            button6.Name = "button6";
            button6.Size = new Size(78, 27);
            button6.TabIndex = 17;
            button6.Text = "Sign in";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 495);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 18;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 456);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 19;
            label8.Text = "Email Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(136, 411);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 20;
            label9.Text = "Sign Up";
            // 
            // signUpUser
            // 
            signUpUser.Location = new Point(176, 449);
            signUpUser.Name = "signUpUser";
            signUpUser.Size = new Size(125, 27);
            signUpUser.TabIndex = 21;
            // 
            // signUpPass1
            // 
            signUpPass1.Location = new Point(176, 488);
            signUpPass1.Name = "signUpPass1";
            signUpPass1.PasswordChar = '*';
            signUpPass1.Size = new Size(125, 27);
            signUpPass1.TabIndex = 22;
            // 
            // signUpPass2
            // 
            signUpPass2.Location = new Point(176, 531);
            signUpPass2.Name = "signUpPass2";
            signUpPass2.PasswordChar = '*';
            signUpPass2.Size = new Size(125, 27);
            signUpPass2.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 534);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 24;
            label10.Text = "Retype Password";
            label10.Click += label10_Click;
            // 
            // button7
            // 
            button7.Location = new Point(121, 592);
            button7.Name = "button7";
            button7.Size = new Size(78, 27);
            button7.TabIndex = 25;
            button7.Text = "Submit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // bookSearch
            // 
            bookSearch.Location = new Point(927, 341);
            bookSearch.Name = "bookSearch";
            bookSearch.Size = new Size(171, 27);
            bookSearch.TabIndex = 27;
            bookSearch.TextChanged += bookSearch_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(698, 348);
            label11.Name = "label11";
            label11.Size = new Size(223, 20);
            label11.TabIndex = 26;
            label11.Text = "Search a book by Title or Author";
            // 
            // bookTextbox
            // 
            bookTextbox.Location = new Point(698, 374);
            bookTextbox.Name = "bookTextbox";
            bookTextbox.Size = new Size(484, 167);
            bookTextbox.TabIndex = 29;
            bookTextbox.Text = "";
            // 
            // displayTextBox
            // 
            displayTextBox.Location = new Point(704, 123);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(469, 195);
            displayTextBox.TabIndex = 30;
            displayTextBox.Text = "";
            // 
            // bookOpenBtn
            // 
            bookOpenBtn.Enabled = false;
            bookOpenBtn.Location = new Point(868, 547);
            bookOpenBtn.Name = "bookOpenBtn";
            bookOpenBtn.Size = new Size(146, 27);
            bookOpenBtn.TabIndex = 31;
            bookOpenBtn.Text = "Click to open book";
            bookOpenBtn.UseVisualStyleBackColor = true;
            bookOpenBtn.Visible = false;
            bookOpenBtn.Click += bookOpenBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1104, 341);
            button2.Name = "button2";
            button2.Size = new Size(78, 27);
            button2.TabIndex = 32;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(969, 88);
            label12.Name = "label12";
            label12.Size = new Size(84, 20);
            label12.TabIndex = 33;
            label12.Text = "Show Users";
            // 
            // button8
            // 
            button8.Location = new Point(1078, 85);
            button8.Name = "button8";
            button8.Size = new Size(78, 27);
            button8.TabIndex = 34;
            button8.Text = "Show";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(868, 85);
            button9.Name = "button9";
            button9.Size = new Size(78, 27);
            button9.TabIndex = 35;
            button9.Text = "Show";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(748, 92);
            label13.Name = "label13";
            label13.Size = new Size(118, 20);
            label13.TabIndex = 36;
            label13.Text = "Most Read Book";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(508, 411);
            label14.Name = "label14";
            label14.Size = new Size(54, 20);
            label14.TabIndex = 37;
            label14.Text = "Sign In";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ActiveCaptionText;
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(257, 132);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 38;
            label15.Text = "Books";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(394, 21);
            label16.Name = "label16";
            label16.Size = new Size(467, 50);
            label16.TabIndex = 39;
            label16.Text = "Online Library Admin";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(448, 209);
            label17.Name = "label17";
            label17.Size = new Size(129, 20);
            label17.TabIndex = 40;
            label17.Text = "(Input ID w/ Edits)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(448, 241);
            label18.Name = "label18";
            label18.Size = new Size(72, 20);
            label18.TabIndex = 41;
            label18.Text = "(Input ID)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 675);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label12);
            Controls.Add(button2);
            Controls.Add(bookOpenBtn);
            Controls.Add(displayTextBox);
            Controls.Add(bookTextbox);
            Controls.Add(bookSearch);
            Controls.Add(label11);
            Controls.Add(button7);
            Controls.Add(label10);
            Controls.Add(signUpPass2);
            Controls.Add(signUpPass1);
            Controls.Add(signUpUser);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button6);
            Controls.Add(signInPass);
            Controls.Add(label6);
            Controls.Add(signInUser);
            Controls.Add(label5);
            Controls.Add(authorTextbox);
            Controls.Add(label4);
            Controls.Add(titleTextbox);
            Controls.Add(label3);
            Controls.Add(isbnTextbox);
            Controls.Add(label2);
            Controls.Add(bookIdTextbox);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private TextBox bookIdTextbox;
        private TextBox isbnTextbox;
        private Label label2;
        private TextBox titleTextbox;
        private Label label3;
        private TextBox authorTextbox;
        private Label label4;
        private TextBox signInUser;
        private Label label5;
        private TextBox signInPass;
        private Label label6;
        private Button button6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox signUpUser;
        private TextBox signUpPass1;
        private TextBox signUpPass2;
        private Label label10;
        private Button button7;
        private TextBox bookSearch;
        private Label label11;
        private RichTextBox bookTextbox;
        private RichTextBox displayTextBox;
        private Button bookOpenBtn;
        private Button button2;
        private Label label12;
        private Button button8;
        private Button button9;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
    }
}