namespace ContactBook
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label incomeLabel;
            System.Windows.Forms.Label debtLabel;
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label educationLabel;
            System.Windows.Forms.Label study_fieldLabel;
            System.Windows.Forms.Label cell_phone1Label;
            System.Windows.Forms.Label cell_phone2Label;
            System.Windows.Forms.Label landline1Label;
            System.Windows.Forms.Label landline2Label;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label web_urlLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zip_codeLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label co_nameLabel;
            System.Windows.Forms.Label activityLabel;
            System.Windows.Forms.Label commentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.phone_book_tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.phone_book_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonebook_ds = new ContactBook.phonebook_ds();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.search_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.debtTextBox = new System.Windows.Forms.TextBox();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.study_fieldTextBox = new System.Windows.Forms.TextBox();
            this.cell_phone1TextBox = new System.Windows.Forms.TextBox();
            this.cell_phone2TextBox = new System.Windows.Forms.TextBox();
            this.landline1TextBox = new System.Windows.Forms.TextBox();
            this.landline2TextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.web_urlTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zip_codeTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.co_nameTextBox = new System.Windows.Forms.TextBox();
            this.activityTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.details_GroupBox = new System.Windows.Forms.GroupBox();
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            this.topBindNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.diplayCountLable = new System.Windows.Forms.Label();
            this.phone_book_tableTableAdapter = new ContactBook.phonebook_dsTableAdapters.phone_book_tableTableAdapter();
            this.tableAdapterManager = new ContactBook.phonebook_dsTableAdapters.TableAdapterManager();
            this.phoneBookToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolButton = new System.Windows.Forms.ToolStripButton();
            this.editToolButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolButton = new System.Windows.Forms.ToolStripButton();
            this.exitToolButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.phone_book_tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reducedInfoButton = new System.Windows.Forms.ToolStripButton();
            this.firstToolStipButton = new System.Windows.Forms.ToolStripButton();
            this.prevToolStipButton = new System.Windows.Forms.ToolStripButton();
            this.nextToolStipButton = new System.Windows.Forms.ToolStripButton();
            this.lastToolStipButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.positionTextBoxStrip = new System.Windows.Forms.ToolStripTextBox();
            this.ofToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.countToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            incomeLabel = new System.Windows.Forms.Label();
            debtLabel = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            educationLabel = new System.Windows.Forms.Label();
            study_fieldLabel = new System.Windows.Forms.Label();
            cell_phone1Label = new System.Windows.Forms.Label();
            cell_phone2Label = new System.Windows.Forms.Label();
            landline1Label = new System.Windows.Forms.Label();
            landline2Label = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            web_urlLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zip_codeLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            co_nameLabel = new System.Windows.Forms.Label();
            activityLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingNavigator)).BeginInit();
            this.phone_book_tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebook_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_DataGridView)).BeginInit();
            this.details_GroupBox.SuspendLayout();
            this.menuToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topBindNavigator)).BeginInit();
            this.topBindNavigator.SuspendLayout();
            this.phoneBookToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(13, 22);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(55, 13);
            first_nameLabel.TabIndex = 0;
            first_nameLabel.Text = "first name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(312, 25);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(55, 13);
            last_nameLabel.TabIndex = 2;
            last_nameLabel.Text = "last name:";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(13, 48);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 4;
            customer_idLabel.Text = "customer id:";
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Location = new System.Drawing.Point(312, 51);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new System.Drawing.Size(44, 13);
            incomeLabel.TabIndex = 6;
            incomeLabel.Text = "income:";
            // 
            // debtLabel
            // 
            debtLabel.AutoSize = true;
            debtLabel.Location = new System.Drawing.Point(312, 74);
            debtLabel.Name = "debtLabel";
            debtLabel.Size = new System.Drawing.Size(31, 13);
            debtLabel.TabIndex = 10;
            debtLabel.Text = "debt:";
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.Location = new System.Drawing.Point(13, 101);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new System.Drawing.Size(54, 13);
            birth_dateLabel.TabIndex = 12;
            birth_dateLabel.Text = "birth date:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(312, 97);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(43, 13);
            genderLabel.TabIndex = 14;
            genderLabel.Text = "gender:";
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Location = new System.Drawing.Point(13, 126);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new System.Drawing.Size(57, 13);
            educationLabel.TabIndex = 16;
            educationLabel.Text = "education:";
            // 
            // study_fieldLabel
            // 
            study_fieldLabel.AutoSize = true;
            study_fieldLabel.Location = new System.Drawing.Point(312, 126);
            study_fieldLabel.Name = "study_fieldLabel";
            study_fieldLabel.Size = new System.Drawing.Size(57, 13);
            study_fieldLabel.TabIndex = 18;
            study_fieldLabel.Text = "study field:";
            // 
            // cell_phone1Label
            // 
            cell_phone1Label.AutoSize = true;
            cell_phone1Label.Location = new System.Drawing.Point(13, 152);
            cell_phone1Label.Name = "cell_phone1Label";
            cell_phone1Label.Size = new System.Drawing.Size(65, 13);
            cell_phone1Label.TabIndex = 20;
            cell_phone1Label.Text = "cell phone1:";
            // 
            // cell_phone2Label
            // 
            cell_phone2Label.AutoSize = true;
            cell_phone2Label.Location = new System.Drawing.Point(312, 152);
            cell_phone2Label.Name = "cell_phone2Label";
            cell_phone2Label.Size = new System.Drawing.Size(65, 13);
            cell_phone2Label.TabIndex = 22;
            cell_phone2Label.Text = "cell phone2:";
            // 
            // landline1Label
            // 
            landline1Label.AutoSize = true;
            landline1Label.Location = new System.Drawing.Point(13, 178);
            landline1Label.Name = "landline1Label";
            landline1Label.Size = new System.Drawing.Size(52, 13);
            landline1Label.TabIndex = 24;
            landline1Label.Text = "landline1:";
            // 
            // landline2Label
            // 
            landline2Label.AutoSize = true;
            landline2Label.Location = new System.Drawing.Point(312, 181);
            landline2Label.Name = "landline2Label";
            landline2Label.Size = new System.Drawing.Size(52, 13);
            landline2Label.TabIndex = 26;
            landline2Label.Text = "landline2:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(13, 204);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(24, 13);
            faxLabel.TabIndex = 28;
            faxLabel.Text = "fax:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 230);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 30;
            emailLabel.Text = "email:";
            // 
            // web_urlLabel
            // 
            web_urlLabel.AutoSize = true;
            web_urlLabel.Location = new System.Drawing.Point(312, 230);
            web_urlLabel.Name = "web_urlLabel";
            web_urlLabel.Size = new System.Drawing.Size(44, 13);
            web_urlLabel.TabIndex = 32;
            web_urlLabel.Text = "web url:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(312, 307);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(45, 13);
            countryLabel.TabIndex = 44;
            countryLabel.Text = "country:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(312, 285);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(33, 13);
            stateLabel.TabIndex = 40;
            stateLabel.Text = "state:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(13, 285);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(26, 13);
            cityLabel.TabIndex = 38;
            cityLabel.Text = "city:";
            // 
            // zip_codeLabel
            // 
            zip_codeLabel.AutoSize = true;
            zip_codeLabel.Location = new System.Drawing.Point(13, 311);
            zip_codeLabel.Name = "zip_codeLabel";
            zip_codeLabel.Size = new System.Drawing.Size(50, 13);
            zip_codeLabel.TabIndex = 42;
            zip_codeLabel.Text = "zip code:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(13, 256);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(53, 13);
            address1Label.TabIndex = 34;
            address1Label.Text = "address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(312, 259);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(53, 13);
            address2Label.TabIndex = 36;
            address2Label.Text = "address2:";
            // 
            // co_nameLabel
            // 
            co_nameLabel.AutoSize = true;
            co_nameLabel.Location = new System.Drawing.Point(13, 74);
            co_nameLabel.Name = "co_nameLabel";
            co_nameLabel.Size = new System.Drawing.Size(51, 13);
            co_nameLabel.TabIndex = 8;
            co_nameLabel.Text = "co name:";
            // 
            // activityLabel
            // 
            activityLabel.AutoSize = true;
            activityLabel.Location = new System.Drawing.Point(13, 337);
            activityLabel.Name = "activityLabel";
            activityLabel.Size = new System.Drawing.Size(43, 13);
            activityLabel.TabIndex = 46;
            activityLabel.Text = "activity:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(13, 363);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(53, 13);
            commentLabel.TabIndex = 48;
            commentLabel.Text = "comment:";
            // 
            // phone_book_tableBindingNavigator
            // 
            this.phone_book_tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phone_book_tableBindingNavigator.BindingSource = this.phone_book_tableBindingSource;
            this.phone_book_tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phone_book_tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phone_book_tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phone_book_tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.phone_book_tableBindingNavigatorSaveItem,
            this.reducedInfoButton,
            this.toolStripSeparator1});
            this.phone_book_tableBindingNavigator.Location = new System.Drawing.Point(0, 580);
            this.phone_book_tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phone_book_tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phone_book_tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phone_book_tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phone_book_tableBindingNavigator.Name = "phone_book_tableBindingNavigator";
            this.phone_book_tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phone_book_tableBindingNavigator.Size = new System.Drawing.Size(995, 25);
            this.phone_book_tableBindingNavigator.TabIndex = 0;
            this.phone_book_tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // phone_book_tableBindingSource
            // 
            this.phone_book_tableBindingSource.DataMember = "phone_book_table";
            this.phone_book_tableBindingSource.DataSource = this.phonebook_ds;
            // 
            // phonebook_ds
            // 
            this.phonebook_ds.DataSetName = "phonebook_ds";
            this.phonebook_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // search_DataGridView
            // 
            this.search_DataGridView.AllowUserToAddRows = false;
            this.search_DataGridView.AllowUserToDeleteRows = false;
            this.search_DataGridView.AllowUserToOrderColumns = true;
            this.search_DataGridView.AllowUserToResizeRows = false;
            this.search_DataGridView.AutoGenerateColumns = false;
            this.search_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.co_name});
            this.search_DataGridView.DataSource = this.phone_book_tableBindingSource;
            this.search_DataGridView.Location = new System.Drawing.Point(12, 71);
            this.search_DataGridView.Name = "search_DataGridView";
            this.search_DataGridView.ReadOnly = true;
            this.search_DataGridView.Size = new System.Drawing.Size(342, 473);
            this.search_DataGridView.TabIndex = 1;
            this.search_DataGridView.SelectionChanged += new System.EventHandler(this.recordUpdateDisplay);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // co_name
            // 
            this.co_name.DataPropertyName = "co_name";
            this.co_name.HeaderText = "Company";
            this.co_name.Name = "co_name";
            this.co_name.ReadOnly = true;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(84, 19);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.first_nameTextBox.TabIndex = 1;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(383, 22);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.last_nameTextBox.TabIndex = 3;
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(84, 45);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.customer_idTextBox.TabIndex = 5;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "income", true));
            this.incomeTextBox.Location = new System.Drawing.Point(383, 48);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.incomeTextBox.TabIndex = 7;
            // 
            // debtTextBox
            // 
            this.debtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "debt", true));
            this.debtTextBox.Location = new System.Drawing.Point(383, 71);
            this.debtTextBox.Name = "debtTextBox";
            this.debtTextBox.Size = new System.Drawing.Size(200, 20);
            this.debtTextBox.TabIndex = 11;
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phone_book_tableBindingSource, "birth_date", true));
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(84, 97);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birth_dateDateTimePicker.TabIndex = 13;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(383, 94);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 15;
            // 
            // educationTextBox
            // 
            this.educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "education", true));
            this.educationTextBox.Location = new System.Drawing.Point(84, 123);
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.Size = new System.Drawing.Size(200, 20);
            this.educationTextBox.TabIndex = 17;
            // 
            // study_fieldTextBox
            // 
            this.study_fieldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "study_field", true));
            this.study_fieldTextBox.Location = new System.Drawing.Point(383, 123);
            this.study_fieldTextBox.Name = "study_fieldTextBox";
            this.study_fieldTextBox.Size = new System.Drawing.Size(200, 20);
            this.study_fieldTextBox.TabIndex = 19;
            // 
            // cell_phone1TextBox
            // 
            this.cell_phone1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "cell_phone1", true));
            this.cell_phone1TextBox.Location = new System.Drawing.Point(84, 149);
            this.cell_phone1TextBox.Name = "cell_phone1TextBox";
            this.cell_phone1TextBox.Size = new System.Drawing.Size(200, 20);
            this.cell_phone1TextBox.TabIndex = 21;
            // 
            // cell_phone2TextBox
            // 
            this.cell_phone2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "cell_phone2", true));
            this.cell_phone2TextBox.Location = new System.Drawing.Point(383, 149);
            this.cell_phone2TextBox.Name = "cell_phone2TextBox";
            this.cell_phone2TextBox.Size = new System.Drawing.Size(200, 20);
            this.cell_phone2TextBox.TabIndex = 23;
            // 
            // landline1TextBox
            // 
            this.landline1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "landline1", true));
            this.landline1TextBox.Location = new System.Drawing.Point(84, 175);
            this.landline1TextBox.Name = "landline1TextBox";
            this.landline1TextBox.Size = new System.Drawing.Size(200, 20);
            this.landline1TextBox.TabIndex = 25;
            // 
            // landline2TextBox
            // 
            this.landline2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "landline2", true));
            this.landline2TextBox.Location = new System.Drawing.Point(383, 178);
            this.landline2TextBox.Name = "landline2TextBox";
            this.landline2TextBox.Size = new System.Drawing.Size(200, 20);
            this.landline2TextBox.TabIndex = 27;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(84, 201);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(200, 20);
            this.faxTextBox.TabIndex = 29;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(84, 227);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 31;
            // 
            // web_urlTextBox
            // 
            this.web_urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "web_url", true));
            this.web_urlTextBox.Location = new System.Drawing.Point(383, 227);
            this.web_urlTextBox.Name = "web_urlTextBox";
            this.web_urlTextBox.Size = new System.Drawing.Size(200, 20);
            this.web_urlTextBox.TabIndex = 33;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(383, 304);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryTextBox.TabIndex = 45;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(383, 282);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(200, 20);
            this.stateTextBox.TabIndex = 41;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(84, 282);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 39;
            // 
            // zip_codeTextBox
            // 
            this.zip_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "zip_code", true));
            this.zip_codeTextBox.Location = new System.Drawing.Point(84, 308);
            this.zip_codeTextBox.Name = "zip_codeTextBox";
            this.zip_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.zip_codeTextBox.TabIndex = 43;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(84, 253);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(200, 20);
            this.address1TextBox.TabIndex = 35;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(383, 256);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(200, 20);
            this.address2TextBox.TabIndex = 37;
            // 
            // co_nameTextBox
            // 
            this.co_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "co_name", true));
            this.co_nameTextBox.Location = new System.Drawing.Point(84, 71);
            this.co_nameTextBox.Name = "co_nameTextBox";
            this.co_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.co_nameTextBox.TabIndex = 9;
            // 
            // activityTextBox
            // 
            this.activityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "activity", true));
            this.activityTextBox.Location = new System.Drawing.Point(84, 334);
            this.activityTextBox.Name = "activityTextBox";
            this.activityTextBox.Size = new System.Drawing.Size(200, 20);
            this.activityTextBox.TabIndex = 47;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(84, 360);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(499, 128);
            this.commentTextBox.TabIndex = 49;
            // 
            // details_GroupBox
            // 
            this.details_GroupBox.Controls.Add(this.first_nameTextBox);
            this.details_GroupBox.Controls.Add(commentLabel);
            this.details_GroupBox.Controls.Add(activityLabel);
            this.details_GroupBox.Controls.Add(this.commentTextBox);
            this.details_GroupBox.Controls.Add(co_nameLabel);
            this.details_GroupBox.Controls.Add(this.activityTextBox);
            this.details_GroupBox.Controls.Add(countryLabel);
            this.details_GroupBox.Controls.Add(this.co_nameTextBox);
            this.details_GroupBox.Controls.Add(web_urlLabel);
            this.details_GroupBox.Controls.Add(this.countryTextBox);
            this.details_GroupBox.Controls.Add(emailLabel);
            this.details_GroupBox.Controls.Add(zip_codeLabel);
            this.details_GroupBox.Controls.Add(cityLabel);
            this.details_GroupBox.Controls.Add(this.zip_codeTextBox);
            this.details_GroupBox.Controls.Add(stateLabel);
            this.details_GroupBox.Controls.Add(this.cityTextBox);
            this.details_GroupBox.Controls.Add(this.web_urlTextBox);
            this.details_GroupBox.Controls.Add(this.stateTextBox);
            this.details_GroupBox.Controls.Add(faxLabel);
            this.details_GroupBox.Controls.Add(this.emailTextBox);
            this.details_GroupBox.Controls.Add(landline2Label);
            this.details_GroupBox.Controls.Add(this.faxTextBox);
            this.details_GroupBox.Controls.Add(landline1Label);
            this.details_GroupBox.Controls.Add(address2Label);
            this.details_GroupBox.Controls.Add(address1Label);
            this.details_GroupBox.Controls.Add(this.address2TextBox);
            this.details_GroupBox.Controls.Add(this.landline2TextBox);
            this.details_GroupBox.Controls.Add(this.address1TextBox);
            this.details_GroupBox.Controls.Add(cell_phone2Label);
            this.details_GroupBox.Controls.Add(this.landline1TextBox);
            this.details_GroupBox.Controls.Add(cell_phone1Label);
            this.details_GroupBox.Controls.Add(this.cell_phone2TextBox);
            this.details_GroupBox.Controls.Add(study_fieldLabel);
            this.details_GroupBox.Controls.Add(this.cell_phone1TextBox);
            this.details_GroupBox.Controls.Add(educationLabel);
            this.details_GroupBox.Controls.Add(this.study_fieldTextBox);
            this.details_GroupBox.Controls.Add(genderLabel);
            this.details_GroupBox.Controls.Add(this.educationTextBox);
            this.details_GroupBox.Controls.Add(birth_dateLabel);
            this.details_GroupBox.Controls.Add(this.genderTextBox);
            this.details_GroupBox.Controls.Add(debtLabel);
            this.details_GroupBox.Controls.Add(this.birth_dateDateTimePicker);
            this.details_GroupBox.Controls.Add(incomeLabel);
            this.details_GroupBox.Controls.Add(this.debtTextBox);
            this.details_GroupBox.Controls.Add(customer_idLabel);
            this.details_GroupBox.Controls.Add(this.incomeTextBox);
            this.details_GroupBox.Controls.Add(last_nameLabel);
            this.details_GroupBox.Controls.Add(this.customer_idTextBox);
            this.details_GroupBox.Controls.Add(first_nameLabel);
            this.details_GroupBox.Controls.Add(this.last_nameTextBox);
            this.details_GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.details_GroupBox.Location = new System.Drawing.Point(384, 71);
            this.details_GroupBox.Name = "details_GroupBox";
            this.details_GroupBox.Size = new System.Drawing.Size(604, 494);
            this.details_GroupBox.TabIndex = 54;
            this.details_GroupBox.TabStop = false;
            this.details_GroupBox.Text = "Contact Details";
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuToolStrip.AutoSize = false;
            this.menuToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolButton,
            this.editToolButton,
            this.deleteToolButton,
            this.saveToolButton,
            this.cancelToolButton,
            this.exitToolButton});
            this.menuToolStrip.Location = new System.Drawing.Point(229, 36);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(756, 36);
            this.menuToolStrip.TabIndex = 55;
            this.menuToolStrip.Text = "toolStrip1";
            // 
            // topBindNavigator
            // 
            this.topBindNavigator.AddNewItem = null;
            this.topBindNavigator.AutoSize = false;
            this.topBindNavigator.BindingSource = this.phone_book_tableBindingSource;
            this.topBindNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.topBindNavigator.DeleteItem = null;
            this.topBindNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.topBindNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
            this.topBindNavigator.Location = new System.Drawing.Point(9, 36);
            this.topBindNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.topBindNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.topBindNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.topBindNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.topBindNavigator.Name = "topBindNavigator";
            this.topBindNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.topBindNavigator.Size = new System.Drawing.Size(220, 36);
            this.topBindNavigator.TabIndex = 56;
            this.topBindNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 33);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 36);
            // 
            // diplayCountLable
            // 
            this.diplayCountLable.AutoSize = true;
            this.diplayCountLable.Location = new System.Drawing.Point(13, 551);
            this.diplayCountLable.Name = "diplayCountLable";
            this.diplayCountLable.Size = new System.Drawing.Size(0, 13);
            this.diplayCountLable.TabIndex = 57;
            // 
            // phone_book_tableTableAdapter
            // 
            this.phone_book_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.phone_book_tableTableAdapter = this.phone_book_tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ContactBook.phonebook_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // phoneBookToolStrip
            // 
            this.phoneBookToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstToolStipButton,
            this.prevToolStipButton,
            this.positionTextBoxStrip,
            this.ofToolStripLabel,
            this.countToolStripLabel,
            this.nextToolStipButton,
            this.lastToolStipButton,
            this.toolStripButton1});
            this.phoneBookToolStrip.Location = new System.Drawing.Point(0, 0);
            this.phoneBookToolStrip.Name = "phoneBookToolStrip";
            this.phoneBookToolStrip.Size = new System.Drawing.Size(995, 25);
            this.phoneBookToolStrip.TabIndex = 58;
            this.phoneBookToolStrip.Text = "toolStrip1";
            // 
            // newToolButton
            // 
            this.newToolButton.Image = global::ContactBook.Properties.Resources.new_butt;
            this.newToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolButton.Name = "newToolButton";
            this.newToolButton.Size = new System.Drawing.Size(60, 33);
            this.newToolButton.Text = "Add New";
            this.newToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newToolButton.Click += new System.EventHandler(this.newToolButton_Click);
            // 
            // editToolButton
            // 
            this.editToolButton.Image = global::ContactBook.Properties.Resources.edit_butt;
            this.editToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolButton.Name = "editToolButton";
            this.editToolButton.Size = new System.Drawing.Size(31, 33);
            this.editToolButton.Text = "Edit";
            this.editToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editToolButton.Click += new System.EventHandler(this.editToolButton_Click);
            // 
            // deleteToolButton
            // 
            this.deleteToolButton.Image = global::ContactBook.Properties.Resources.Delete_butt;
            this.deleteToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolButton.Name = "deleteToolButton";
            this.deleteToolButton.Size = new System.Drawing.Size(44, 33);
            this.deleteToolButton.Text = "Delete";
            this.deleteToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteToolButton.Click += new System.EventHandler(this.deleteToolButton_Click);
            // 
            // saveToolButton
            // 
            this.saveToolButton.Image = global::ContactBook.Properties.Resources.save2;
            this.saveToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolButton.Name = "saveToolButton";
            this.saveToolButton.Size = new System.Drawing.Size(35, 33);
            this.saveToolButton.Text = "Save";
            this.saveToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveToolButton.Click += new System.EventHandler(this.saveToolButton_Click);
            // 
            // cancelToolButton
            // 
            this.cancelToolButton.Image = global::ContactBook.Properties.Resources.cancel_butt;
            this.cancelToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolButton.Name = "cancelToolButton";
            this.cancelToolButton.Size = new System.Drawing.Size(47, 33);
            this.cancelToolButton.Text = "Cancel";
            this.cancelToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelToolButton.Click += new System.EventHandler(this.cancelToolButton_Click);
            // 
            // exitToolButton
            // 
            this.exitToolButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolButton.Image = global::ContactBook.Properties.Resources.exit;
            this.exitToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolButton.Name = "exitToolButton";
            this.exitToolButton.Size = new System.Drawing.Size(23, 33);
            this.exitToolButton.Text = "Exit";
            this.exitToolButton.Click += new System.EventHandler(this.exitToolButton_Click);
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // phone_book_tableBindingNavigatorSaveItem
            // 
            this.phone_book_tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phone_book_tableBindingNavigatorSaveItem.Image")));
            this.phone_book_tableBindingNavigatorSaveItem.Name = "phone_book_tableBindingNavigatorSaveItem";
            this.phone_book_tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.phone_book_tableBindingNavigatorSaveItem.Text = "Save Data";
            this.phone_book_tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.phone_book_tableBindingNavigatorSaveItem_Click);
            // 
            // reducedInfoButton
            // 
            this.reducedInfoButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.reducedInfoButton.Image = global::ContactBook.Properties.Resources.tools;
            this.reducedInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reducedInfoButton.Name = "reducedInfoButton";
            this.reducedInfoButton.Size = new System.Drawing.Size(129, 22);
            this.reducedInfoButton.Text = "Show Reduced Info";
            this.reducedInfoButton.Click += new System.EventHandler(this.reducedInfoButton_Click);
            // 
            // firstToolStipButton
            // 
            this.firstToolStipButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstToolStipButton.Image = global::ContactBook.Properties.Resources.first;
            this.firstToolStipButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.firstToolStipButton.Name = "firstToolStipButton";
            this.firstToolStipButton.Size = new System.Drawing.Size(23, 22);
            this.firstToolStipButton.Click += new System.EventHandler(this.firstToolStipButton_Click);
            // 
            // prevToolStipButton
            // 
            this.prevToolStipButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prevToolStipButton.Image = global::ContactBook.Properties.Resources.prev;
            this.prevToolStipButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prevToolStipButton.Name = "prevToolStipButton";
            this.prevToolStipButton.Size = new System.Drawing.Size(23, 22);
            this.prevToolStipButton.Text = "toolStripButton2";
            this.prevToolStipButton.Click += new System.EventHandler(this.prevToolStipButton_Click);
            // 
            // nextToolStipButton
            // 
            this.nextToolStipButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextToolStipButton.Image = global::ContactBook.Properties.Resources.next;
            this.nextToolStipButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextToolStipButton.Name = "nextToolStipButton";
            this.nextToolStipButton.Size = new System.Drawing.Size(23, 22);
            this.nextToolStipButton.Text = "toolStripButton3";
            this.nextToolStipButton.Click += new System.EventHandler(this.nextToolStipButton_Click);
            // 
            // lastToolStipButton
            // 
            this.lastToolStipButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastToolStipButton.Image = global::ContactBook.Properties.Resources.last;
            this.lastToolStipButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lastToolStipButton.Name = "lastToolStipButton";
            this.lastToolStipButton.Size = new System.Drawing.Size(23, 22);
            this.lastToolStipButton.Text = "toolStripButton4";
            this.lastToolStipButton.Click += new System.EventHandler(this.lastToolStipButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ContactBook.Properties.Resources.exit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.exitToolButton_Click);
            // 
            // positionTextBoxStrip
            // 
            this.positionTextBoxStrip.AutoSize = false;
            this.positionTextBoxStrip.Name = "positionTextBoxStrip";
            this.positionTextBoxStrip.Size = new System.Drawing.Size(50, 25);
            this.positionTextBoxStrip.Leave += new System.EventHandler(this.changeRecPosition);
            // 
            // ofToolStripLabel
            // 
            this.ofToolStripLabel.Name = "ofToolStripLabel";
            this.ofToolStripLabel.Size = new System.Drawing.Size(18, 22);
            this.ofToolStripLabel.Text = "of";
            // 
            // countToolStripLabel
            // 
            this.countToolStripLabel.Name = "countToolStripLabel";
            this.countToolStripLabel.Size = new System.Drawing.Size(13, 22);
            this.countToolStripLabel.Text = "1";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 605);
            this.Controls.Add(this.diplayCountLable);
            this.Controls.Add(this.menuToolStrip);
            this.Controls.Add(this.topBindNavigator);
            this.Controls.Add(this.details_GroupBox);
            this.Controls.Add(this.search_DataGridView);
            this.Controls.Add(this.phone_book_tableBindingNavigator);
            this.Controls.Add(this.phoneBookToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingNavigator)).EndInit();
            this.phone_book_tableBindingNavigator.ResumeLayout(false);
            this.phone_book_tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebook_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_DataGridView)).EndInit();
            this.details_GroupBox.ResumeLayout(false);
            this.details_GroupBox.PerformLayout();
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topBindNavigator)).EndInit();
            this.topBindNavigator.ResumeLayout(false);
            this.topBindNavigator.PerformLayout();
            this.phoneBookToolStrip.ResumeLayout(false);
            this.phoneBookToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private phonebook_ds phonebook_ds;
        private System.Windows.Forms.BindingSource phone_book_tableBindingSource;
        private phonebook_dsTableAdapters.phone_book_tableTableAdapter phone_book_tableTableAdapter;
        private phonebook_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phone_book_tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton phone_book_tableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView search_DataGridView;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.TextBox debtTextBox;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.TextBox study_fieldTextBox;
        private System.Windows.Forms.TextBox cell_phone1TextBox;
        private System.Windows.Forms.TextBox cell_phone2TextBox;
        private System.Windows.Forms.TextBox landline1TextBox;
        private System.Windows.Forms.TextBox landline2TextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox web_urlTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zip_codeTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox co_nameTextBox;
        private System.Windows.Forms.TextBox activityTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.GroupBox details_GroupBox;
        private System.Windows.Forms.ToolStrip menuToolStrip;
        private System.Windows.Forms.ToolStripButton newToolButton;
        private System.Windows.Forms.ToolStripButton editToolButton;
        private System.Windows.Forms.ToolStripButton deleteToolButton;
        private System.Windows.Forms.ToolStripButton saveToolButton;
        private System.Windows.Forms.ToolStripButton cancelToolButton;
        private System.Windows.Forms.ToolStripButton exitToolButton;
        private System.Windows.Forms.ToolStripButton reducedInfoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingNavigator topBindNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_name;
        private System.Windows.Forms.Label diplayCountLable;
        private System.Windows.Forms.ToolStrip phoneBookToolStrip;
        private System.Windows.Forms.ToolStripButton firstToolStipButton;
        private System.Windows.Forms.ToolStripButton prevToolStipButton;
        private System.Windows.Forms.ToolStripButton nextToolStipButton;
        private System.Windows.Forms.ToolStripButton lastToolStipButton;
        private System.Windows.Forms.ToolStripTextBox positionTextBoxStrip;
        private System.Windows.Forms.ToolStripLabel ofToolStripLabel;
        private System.Windows.Forms.ToolStripLabel countToolStripLabel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

