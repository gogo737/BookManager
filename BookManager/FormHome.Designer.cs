namespace BookManager
{
    partial class FormHome
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_allDelayedBook = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Borrow = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_allBorrowedBook = new System.Windows.Forms.Label();
            this.label_allUserCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_bookName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.label_allBookCount = new System.Windows.Forms.Label();
            this.dataGridView_BookManager = new System.Windows.Forms.DataGridView();
            this.dataGridView_UserManager = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBorrowedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.borrowedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 548);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 10);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(975, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 558);
            this.panel4.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 22);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "전체 도서 수 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "사용자 수 :";
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Return.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.button_Return.ForeColor = System.Drawing.Color.White;
            this.button_Return.Location = new System.Drawing.Point(742, 78);
            this.button_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(117, 43);
            this.button_Return.TabIndex = 37;
            this.button_Return.Text = "반납";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(29, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "대출 중인 도서의 수 :";
            // 
            // label_allDelayedBook
            // 
            this.label_allDelayedBook.AutoSize = true;
            this.label_allDelayedBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_allDelayedBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_allDelayedBook.ForeColor = System.Drawing.Color.White;
            this.label_allDelayedBook.Location = new System.Drawing.Point(201, 115);
            this.label_allDelayedBook.Name = "label_allDelayedBook";
            this.label_allDelayedBook.Size = new System.Drawing.Size(58, 19);
            this.label_allDelayedBook.TabIndex = 36;
            this.label_allDelayedBook.Text = "label8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(29, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "연체 중인 도서의 수 : ";
            // 
            // button_Borrow
            // 
            this.button_Borrow.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Borrow.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.button_Borrow.ForeColor = System.Drawing.Color.White;
            this.button_Borrow.Location = new System.Drawing.Point(742, 28);
            this.button_Borrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(117, 40);
            this.button_Borrow.TabIndex = 35;
            this.button_Borrow.Text = "대여";
            this.button_Borrow.UseVisualStyleBackColor = false;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(412, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Isbn : ";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.textBox_id.Location = new System.Drawing.Point(487, 97);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(238, 33);
            this.textBox_id.TabIndex = 33;
            // 
            // label_allBorrowedBook
            // 
            this.label_allBorrowedBook.AutoSize = true;
            this.label_allBorrowedBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_allBorrowedBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_allBorrowedBook.ForeColor = System.Drawing.Color.White;
            this.label_allBorrowedBook.Location = new System.Drawing.Point(201, 92);
            this.label_allBorrowedBook.Name = "label_allBorrowedBook";
            this.label_allBorrowedBook.Size = new System.Drawing.Size(58, 19);
            this.label_allBorrowedBook.TabIndex = 34;
            this.label_allBorrowedBook.Text = "label7";
            // 
            // label_allUserCount
            // 
            this.label_allUserCount.AutoSize = true;
            this.label_allUserCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_allUserCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_allUserCount.ForeColor = System.Drawing.Color.White;
            this.label_allUserCount.Location = new System.Drawing.Point(125, 61);
            this.label_allUserCount.Name = "label_allUserCount";
            this.label_allUserCount.Size = new System.Drawing.Size(58, 19);
            this.label_allUserCount.TabIndex = 32;
            this.label_allUserCount.Text = "label6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(374, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "도서 이름 : ";
            // 
            // textBox_bookName
            // 
            this.textBox_bookName.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.textBox_bookName.Location = new System.Drawing.Point(487, 61);
            this.textBox_bookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_bookName.Name = "textBox_bookName";
            this.textBox_bookName.Size = new System.Drawing.Size(238, 33);
            this.textBox_bookName.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(373, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "사용자 ID : ";
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.textBox_isbn.Location = new System.Drawing.Point(487, 23);
            this.textBox_isbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(238, 33);
            this.textBox_isbn.TabIndex = 28;
            // 
            // label_allBookCount
            // 
            this.label_allBookCount.AutoSize = true;
            this.label_allBookCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_allBookCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_allBookCount.ForeColor = System.Drawing.Color.White;
            this.label_allBookCount.Location = new System.Drawing.Point(147, 37);
            this.label_allBookCount.Name = "label_allBookCount";
            this.label_allBookCount.Size = new System.Drawing.Size(58, 19);
            this.label_allBookCount.TabIndex = 31;
            this.label_allBookCount.Text = "label5";
            // 
            // dataGridView_BookManager
            // 
            this.dataGridView_BookManager.AllowUserToAddRows = false;
            this.dataGridView_BookManager.AllowUserToDeleteRows = false;
            this.dataGridView_BookManager.AutoGenerateColumns = false;
            this.dataGridView_BookManager.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_BookManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_BookManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BookManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.publisherDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.isBorrowedDataGridViewCheckBoxColumn,
            this.borrowedAtDataGridViewTextBoxColumn});
            this.dataGridView_BookManager.DataSource = this.bookBindingSource1;
            this.dataGridView_BookManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_BookManager.Location = new System.Drawing.Point(10, 358);
            this.dataGridView_BookManager.Name = "dataGridView_BookManager";
            this.dataGridView_BookManager.ReadOnly = true;
            this.dataGridView_BookManager.RowTemplate.Height = 23;
            this.dataGridView_BookManager.Size = new System.Drawing.Size(965, 200);
            this.dataGridView_BookManager.TabIndex = 38;
            this.dataGridView_BookManager.CurrentCellChanged += new System.EventHandler(this.DataGridView_BookManager_CurrentCellChanged);
            // 
            // dataGridView_UserManager
            // 
            this.dataGridView_UserManager.AllowUserToAddRows = false;
            this.dataGridView_UserManager.AllowUserToDeleteRows = false;
            this.dataGridView_UserManager.AutoGenerateColumns = false;
            this.dataGridView_UserManager.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_UserManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_UserManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UserManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView_UserManager.DataSource = this.userBindingSource;
            this.dataGridView_UserManager.Location = new System.Drawing.Point(10, 158);
            this.dataGridView_UserManager.Name = "dataGridView_UserManager";
            this.dataGridView_UserManager.ReadOnly = true;
            this.dataGridView_UserManager.RowTemplate.Height = 23;
            this.dataGridView_UserManager.Size = new System.Drawing.Size(965, 200);
            this.dataGridView_UserManager.TabIndex = 39;
            this.dataGridView_UserManager.CurrentCellChanged += new System.EventHandler(this.dataGridView_UserManager_CurrentCellChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BookManager.User);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.isbnDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            this.pageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isBorrowedDataGridViewCheckBoxColumn
            // 
            this.isBorrowedDataGridViewCheckBoxColumn.DataPropertyName = "isBorrowed";
            this.isBorrowedDataGridViewCheckBoxColumn.HeaderText = "isBorrowed";
            this.isBorrowedDataGridViewCheckBoxColumn.Name = "isBorrowedDataGridViewCheckBoxColumn";
            this.isBorrowedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // borrowedAtDataGridViewTextBoxColumn
            // 
            this.borrowedAtDataGridViewTextBoxColumn.DataPropertyName = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.HeaderText = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.Name = "borrowedAtDataGridViewTextBoxColumn";
            this.borrowedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookManager.Book);
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataSource = typeof(BookManager.Book);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView_UserManager);
            this.Controls.Add(this.dataGridView_BookManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_allDelayedBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Borrow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_allBorrowedBook);
            this.Controls.Add(this.label_allUserCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_bookName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_isbn);
            this.Controls.Add(this.label_allBookCount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "FormHome";
            this.Size = new System.Drawing.Size(985, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_allDelayedBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Borrow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_allBorrowedBook;
        private System.Windows.Forms.Label label_allUserCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_bookName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.Label label_allBookCount;
        private System.Windows.Forms.DataGridView dataGridView_BookManager;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_UserManager;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBorrowedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource1;
    }
}
