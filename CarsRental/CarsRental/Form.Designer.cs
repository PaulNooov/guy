namespace CarsRental
{
    partial class Form
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
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridView fuelsDataGridView;
        private System.Windows.Forms.DataGridView typesDataGridView;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridView carsAndfuelsDataGridView;
        private System.Windows.Forms.DataGridView carsAndtypesDataGridView;
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.carsFinder = new System.Windows.Forms.Button();
            this.DataGridFinder1 = new System.Windows.Forms.TextBox();
            this.carsSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carservice_BakhmutovDataSet = new CarsRental.carservice_BakhmutovDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clientsSave = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carservice_BakhmutovDataSet1 = new CarsRental.carservice_BakhmutovDataSet1();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fuelsFinder = new System.Windows.Forms.Button();
            this.DataGridFinder3 = new System.Windows.Forms.TextBox();
            this.fuelsSave = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carservice_BakhmutovDataSet2 = new CarsRental.carservice_BakhmutovDataSet2();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.typesFinder = new System.Windows.Forms.Button();
            this.DataGridFinder4 = new System.Windows.Forms.TextBox();
            this.typesSave = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carservice_BakhmutovDataSet3 = new CarsRental.carservice_BakhmutovDataSet3();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ordersFinder = new System.Windows.Forms.Button();
            this.DataGridFinder5 = new System.Windows.Forms.TextBox();
            this.ordersSave = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.oidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ostartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oisactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carservice_BakhmutovDataSet4 = new CarsRental.carservice_BakhmutovDataSet4();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.carsAndfuelsFinder = new System.Windows.Forms.Button();
            this.DataGridFinder6 = new System.Windows.Forms.TextBox();
            this.carsAndfuelsSave = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2mcarsfuelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carservice_BakhmutovDataSet5 = new CarsRental.carservice_BakhmutovDataSet5();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.carsAndtypesFinder = new System.Windows.Forms.Button();
            this.DataGridFinder7 = new System.Windows.Forms.TextBox();
            this.carsAndtypesSave = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2mcarstypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carservice_BakhmutovDataSet6 = new CarsRental.carservice_BakhmutovDataSet6();
            this.carsTableAdapter = new CarsRental.carservice_BakhmutovDataSetTableAdapters.carsTableAdapter();
            this.clientsTableAdapter = new CarsRental.carservice_BakhmutovDataSet1TableAdapters.clientsTableAdapter();
            this.fuelsTableAdapter = new CarsRental.carservice_BakhmutovDataSet2TableAdapters.fuelsTableAdapter();
            this.typesTableAdapter = new CarsRental.carservice_BakhmutovDataSet3TableAdapters.typesTableAdapter();
            this.ordersTableAdapter = new CarsRental.carservice_BakhmutovDataSet4TableAdapters.ordersTableAdapter();
            this.m2m_cars_fuelsTableAdapter = new CarsRental.carservice_BakhmutovDataSet5TableAdapters.m2m_cars_fuelsTableAdapter();
            this.m2m_cars_typesTableAdapter = new CarsRental.carservice_BakhmutovDataSet6TableAdapters.m2m_cars_typesTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet3)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet4)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2mcarsfuelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet5)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2mcarstypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(674, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.carsFinder);
            this.tabPage1.Controls.Add(this.DataGridFinder1);
            this.tabPage1.Controls.Add(this.carsSave);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автомобили";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // carsFinder
            // 
            this.carsFinder.Location = new System.Drawing.Point(585, 395);
            this.carsFinder.Name = "carsFinder";
            this.carsFinder.Size = new System.Drawing.Size(75, 23);
            this.carsFinder.TabIndex = 3;
            this.carsFinder.Text = "Поиск";
            this.carsFinder.UseVisualStyleBackColor = true;
            // 
            // DataGridFinder1
            // 
            this.DataGridFinder1.Location = new System.Drawing.Point(87, 396);
            this.DataGridFinder1.Name = "DataGridFinder1";
            this.DataGridFinder1.Size = new System.Drawing.Size(492, 20);
            this.DataGridFinder1.TabIndex = 2;
            // 
            // carsSave
            // 
            this.carsSave.Location = new System.Drawing.Point(6, 395);
            this.carsSave.Name = "carsSave";
            this.carsSave.Size = new System.Drawing.Size(75, 23);
            this.carsSave.TabIndex = 1;
            this.carsSave.Text = "Сохранить";
            this.carsSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cyearDataGridViewTextBoxColumn,
            this.cquantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "c_name";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // cyearDataGridViewTextBoxColumn
            // 
            this.cyearDataGridViewTextBoxColumn.DataPropertyName = "c_year";
            this.cyearDataGridViewTextBoxColumn.HeaderText = "c_year";
            this.cyearDataGridViewTextBoxColumn.Name = "cyearDataGridViewTextBoxColumn";
            // 
            // cquantityDataGridViewTextBoxColumn
            // 
            this.cquantityDataGridViewTextBoxColumn.DataPropertyName = "c_quantity";
            this.cquantityDataGridViewTextBoxColumn.HeaderText = "c_quantity";
            this.cquantityDataGridViewTextBoxColumn.Name = "cquantityDataGridViewTextBoxColumn";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.carservice_BakhmutovDataSet;
            // 
            // carservice_BakhmutovDataSet
            // 
            this.carservice_BakhmutovDataSet.DataSetName = "carservice_BakhmutovDataSet";
            this.carservice_BakhmutovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clientsSave);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clientsSave
            // 
            this.clientsSave.Location = new System.Drawing.Point(294, 395);
            this.clientsSave.Name = "clientsSave";
            this.clientsSave.Size = new System.Drawing.Size(75, 23);
            this.clientsSave.TabIndex = 1;
            this.clientsSave.Text = "Сохранить";
            this.clientsSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidDataGridViewTextBoxColumn,
            this.clnameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clientsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(660, 386);
            this.dataGridView2.TabIndex = 0;
            // 
            // clidDataGridViewTextBoxColumn
            // 
            this.clidDataGridViewTextBoxColumn.DataPropertyName = "cl_id";
            this.clidDataGridViewTextBoxColumn.HeaderText = "cl_id";
            this.clidDataGridViewTextBoxColumn.Name = "clidDataGridViewTextBoxColumn";
            this.clidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clnameDataGridViewTextBoxColumn
            // 
            this.clnameDataGridViewTextBoxColumn.DataPropertyName = "cl_name";
            this.clnameDataGridViewTextBoxColumn.HeaderText = "cl_name";
            this.clnameDataGridViewTextBoxColumn.Name = "clnameDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.carservice_BakhmutovDataSet1;
            // 
            // carservice_BakhmutovDataSet1
            // 
            this.carservice_BakhmutovDataSet1.DataSetName = "carservice_BakhmutovDataSet1";
            this.carservice_BakhmutovDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fuelsFinder);
            this.tabPage3.Controls.Add(this.DataGridFinder3);
            this.tabPage3.Controls.Add(this.fuelsSave);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(666, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Топливо";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fuelsFinder
            // 
            this.fuelsFinder.Location = new System.Drawing.Point(585, 395);
            this.fuelsFinder.Name = "fuelsFinder";
            this.fuelsFinder.Size = new System.Drawing.Size(75, 23);
            this.fuelsFinder.TabIndex = 3;
            this.fuelsFinder.Text = "Поиск";
            this.fuelsFinder.UseVisualStyleBackColor = true;
            // 
            // DataGridFinder3
            // 
            this.DataGridFinder3.Location = new System.Drawing.Point(87, 396);
            this.DataGridFinder3.Name = "DataGridFinder3";
            this.DataGridFinder3.Size = new System.Drawing.Size(492, 20);
            this.DataGridFinder3.TabIndex = 2;
            // 
            // fuelsSave
            // 
            this.fuelsSave.Location = new System.Drawing.Point(6, 395);
            this.fuelsSave.Name = "fuelsSave";
            this.fuelsSave.Size = new System.Drawing.Size(75, 23);
            this.fuelsSave.TabIndex = 1;
            this.fuelsSave.Text = "Сохранить";
            this.fuelsSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fidDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.fuelsBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(660, 386);
            this.dataGridView3.TabIndex = 0;
            // 
            // fidDataGridViewTextBoxColumn
            // 
            this.fidDataGridViewTextBoxColumn.DataPropertyName = "f_id";
            this.fidDataGridViewTextBoxColumn.HeaderText = "f_id";
            this.fidDataGridViewTextBoxColumn.Name = "fidDataGridViewTextBoxColumn";
            this.fidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "f_name";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "f_name";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // fuelsBindingSource
            // 
            this.fuelsBindingSource.DataMember = "fuels";
            this.fuelsBindingSource.DataSource = this.carservice_BakhmutovDataSet2;
            // 
            // carservice_BakhmutovDataSet2
            // 
            this.carservice_BakhmutovDataSet2.DataSetName = "carservice_BakhmutovDataSet2";
            this.carservice_BakhmutovDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.typesFinder);
            this.tabPage4.Controls.Add(this.DataGridFinder4);
            this.tabPage4.Controls.Add(this.typesSave);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(666, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Типы авто";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // typesFinder
            // 
            this.typesFinder.Location = new System.Drawing.Point(585, 395);
            this.typesFinder.Name = "typesFinder";
            this.typesFinder.Size = new System.Drawing.Size(75, 23);
            this.typesFinder.TabIndex = 3;
            this.typesFinder.Text = "Поиск";
            this.typesFinder.UseVisualStyleBackColor = true;
            // 
            // DataGridFinder4
            // 
            this.DataGridFinder4.Location = new System.Drawing.Point(87, 396);
            this.DataGridFinder4.Name = "DataGridFinder4";
            this.DataGridFinder4.Size = new System.Drawing.Size(492, 20);
            this.DataGridFinder4.TabIndex = 2;
            // 
            // typesSave
            // 
            this.typesSave.Location = new System.Drawing.Point(6, 395);
            this.typesSave.Name = "typesSave";
            this.typesSave.Size = new System.Drawing.Size(75, 23);
            this.typesSave.TabIndex = 1;
            this.typesSave.Text = "Сохранить";
            this.typesSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tidDataGridViewTextBoxColumn,
            this.tnameDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.typesBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(660, 386);
            this.dataGridView4.TabIndex = 0;
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "t_id";
            this.tidDataGridViewTextBoxColumn.HeaderText = "t_id";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            this.tidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tnameDataGridViewTextBoxColumn
            // 
            this.tnameDataGridViewTextBoxColumn.DataPropertyName = "t_name";
            this.tnameDataGridViewTextBoxColumn.HeaderText = "t_name";
            this.tnameDataGridViewTextBoxColumn.Name = "tnameDataGridViewTextBoxColumn";
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "types";
            this.typesBindingSource.DataSource = this.carservice_BakhmutovDataSet3;
            // 
            // carservice_BakhmutovDataSet3
            // 
            this.carservice_BakhmutovDataSet3.DataSetName = "carservice_BakhmutovDataSet3";
            this.carservice_BakhmutovDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ordersFinder);
            this.tabPage5.Controls.Add(this.DataGridFinder5);
            this.tabPage5.Controls.Add(this.ordersSave);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage5.Size = new System.Drawing.Size(666, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Арендаторы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ordersFinder
            // 
            this.ordersFinder.Location = new System.Drawing.Point(585, 395);
            this.ordersFinder.Name = "ordersFinder";
            this.ordersFinder.Size = new System.Drawing.Size(75, 23);
            this.ordersFinder.TabIndex = 3;
            this.ordersFinder.Text = "Поиск";
            this.ordersFinder.UseVisualStyleBackColor = true;
            // 
            // DataGridFinder5
            // 
            this.DataGridFinder5.Location = new System.Drawing.Point(87, 396);
            this.DataGridFinder5.Name = "DataGridFinder5";
            this.DataGridFinder5.Size = new System.Drawing.Size(492, 20);
            this.DataGridFinder5.TabIndex = 2;
            // 
            // ordersSave
            // 
            this.ordersSave.Location = new System.Drawing.Point(6, 395);
            this.ordersSave.Name = "ordersSave";
            this.ordersSave.Size = new System.Drawing.Size(75, 23);
            this.ordersSave.TabIndex = 1;
            this.ordersSave.Text = "Сохранить";
            this.ordersSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oidDataGridViewTextBoxColumn,
            this.oclientDataGridViewTextBoxColumn,
            this.ocarDataGridViewTextBoxColumn,
            this.ostartDataGridViewTextBoxColumn,
            this.ofinishDataGridViewTextBoxColumn,
            this.oisactiveDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.ordersBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(660, 386);
            this.dataGridView5.TabIndex = 0;
            // 
            // oidDataGridViewTextBoxColumn
            // 
            this.oidDataGridViewTextBoxColumn.DataPropertyName = "o_id";
            this.oidDataGridViewTextBoxColumn.HeaderText = "o_id";
            this.oidDataGridViewTextBoxColumn.Name = "oidDataGridViewTextBoxColumn";
            this.oidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oclientDataGridViewTextBoxColumn
            // 
            this.oclientDataGridViewTextBoxColumn.DataPropertyName = "o_client";
            this.oclientDataGridViewTextBoxColumn.HeaderText = "o_client";
            this.oclientDataGridViewTextBoxColumn.Name = "oclientDataGridViewTextBoxColumn";
            // 
            // ocarDataGridViewTextBoxColumn
            // 
            this.ocarDataGridViewTextBoxColumn.DataPropertyName = "o_car";
            this.ocarDataGridViewTextBoxColumn.HeaderText = "o_car";
            this.ocarDataGridViewTextBoxColumn.Name = "ocarDataGridViewTextBoxColumn";
            // 
            // ostartDataGridViewTextBoxColumn
            // 
            this.ostartDataGridViewTextBoxColumn.DataPropertyName = "o_start";
            this.ostartDataGridViewTextBoxColumn.HeaderText = "o_start";
            this.ostartDataGridViewTextBoxColumn.Name = "ostartDataGridViewTextBoxColumn";
            // 
            // ofinishDataGridViewTextBoxColumn
            // 
            this.ofinishDataGridViewTextBoxColumn.DataPropertyName = "o_finish";
            this.ofinishDataGridViewTextBoxColumn.HeaderText = "o_finish";
            this.ofinishDataGridViewTextBoxColumn.Name = "ofinishDataGridViewTextBoxColumn";
            // 
            // oisactiveDataGridViewTextBoxColumn
            // 
            this.oisactiveDataGridViewTextBoxColumn.DataPropertyName = "o_is_active";
            this.oisactiveDataGridViewTextBoxColumn.HeaderText = "o_is_active";
            this.oisactiveDataGridViewTextBoxColumn.Name = "oisactiveDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.carservice_BakhmutovDataSet4;
            // 
            // carservice_BakhmutovDataSet4
            // 
            this.carservice_BakhmutovDataSet4.DataSetName = "carservice_BakhmutovDataSet4";
            this.carservice_BakhmutovDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.carsAndfuelsFinder);
            this.tabPage6.Controls.Add(this.DataGridFinder6);
            this.tabPage6.Controls.Add(this.carsAndfuelsSave);
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(666, 424);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Авто и топливо";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // carsAndfuelsFinder
            // 
            this.carsAndfuelsFinder.Location = new System.Drawing.Point(585, 395);
            this.carsAndfuelsFinder.Name = "carsAndfuelsFinder";
            this.carsAndfuelsFinder.Size = new System.Drawing.Size(75, 23);
            this.carsAndfuelsFinder.TabIndex = 3;
            this.carsAndfuelsFinder.Text = "Поиск";
            this.carsAndfuelsFinder.UseVisualStyleBackColor = true;
            // 
            // DataGridFinder6
            // 
            this.DataGridFinder6.Location = new System.Drawing.Point(87, 396);
            this.DataGridFinder6.Name = "DataGridFinder6";
            this.DataGridFinder6.Size = new System.Drawing.Size(492, 20);
            this.DataGridFinder6.TabIndex = 2;
            // 
            // carsAndfuelsSave
            // 
            this.carsAndfuelsSave.Location = new System.Drawing.Point(6, 395);
            this.carsAndfuelsSave.Name = "carsAndfuelsSave";
            this.carsAndfuelsSave.Size = new System.Drawing.Size(75, 23);
            this.carsAndfuelsSave.TabIndex = 1;
            this.carsAndfuelsSave.Text = "Сохранить";
            this.carsAndfuelsSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn1,
            this.fidDataGridViewTextBoxColumn1});
            this.dataGridView6.DataSource = this.m2mcarsfuelsBindingSource;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(660, 386);
            this.dataGridView6.TabIndex = 0;
            // 
            // cidDataGridViewTextBoxColumn1
            // 
            this.cidDataGridViewTextBoxColumn1.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn1.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn1.Name = "cidDataGridViewTextBoxColumn1";
            // 
            // fidDataGridViewTextBoxColumn1
            // 
            this.fidDataGridViewTextBoxColumn1.DataPropertyName = "f_id";
            this.fidDataGridViewTextBoxColumn1.HeaderText = "f_id";
            this.fidDataGridViewTextBoxColumn1.Name = "fidDataGridViewTextBoxColumn1";
            // 
            // m2mcarsfuelsBindingSource
            // 
            this.m2mcarsfuelsBindingSource.DataMember = "m2m_cars_fuels";
            this.m2mcarsfuelsBindingSource.DataSource = this.carservice_BakhmutovDataSet5;
            // 
            // carservice_BakhmutovDataSet5
            // 
            this.carservice_BakhmutovDataSet5.DataSetName = "carservice_BakhmutovDataSet5";
            this.carservice_BakhmutovDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.carsAndtypesFinder);
            this.tabPage7.Controls.Add(this.DataGridFinder7);
            this.tabPage7.Controls.Add(this.carsAndtypesSave);
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(666, 424);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Авто и типы";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // carsAndtypesFinder
            // 
            this.carsAndtypesFinder.Location = new System.Drawing.Point(585, 395);
            this.carsAndtypesFinder.Name = "carsAndtypesFinder";
            this.carsAndtypesFinder.Size = new System.Drawing.Size(75, 23);
            this.carsAndtypesFinder.TabIndex = 3;
            this.carsAndtypesFinder.Text = "Поиск";
            this.carsAndtypesFinder.UseVisualStyleBackColor = true;
            // 
            // DataGridFinder7
            // 
            this.DataGridFinder7.Location = new System.Drawing.Point(87, 396);
            this.DataGridFinder7.Name = "DataGridFinder7";
            this.DataGridFinder7.Size = new System.Drawing.Size(492, 20);
            this.DataGridFinder7.TabIndex = 2;
            // 
            // carsAndtypesSave
            // 
            this.carsAndtypesSave.Location = new System.Drawing.Point(6, 395);
            this.carsAndtypesSave.Name = "carsAndtypesSave";
            this.carsAndtypesSave.Size = new System.Drawing.Size(75, 23);
            this.carsAndtypesSave.TabIndex = 1;
            this.carsAndtypesSave.Text = "Сохранить";
            this.carsAndtypesSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn2,
            this.tidDataGridViewTextBoxColumn1});
            this.dataGridView7.DataSource = this.m2mcarstypesBindingSource;
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView7.Location = new System.Drawing.Point(3, 3);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(660, 386);
            this.dataGridView7.TabIndex = 0;
            // 
            // cidDataGridViewTextBoxColumn2
            // 
            this.cidDataGridViewTextBoxColumn2.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn2.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn2.Name = "cidDataGridViewTextBoxColumn2";
            // 
            // tidDataGridViewTextBoxColumn1
            // 
            this.tidDataGridViewTextBoxColumn1.DataPropertyName = "t_id";
            this.tidDataGridViewTextBoxColumn1.HeaderText = "t_id";
            this.tidDataGridViewTextBoxColumn1.Name = "tidDataGridViewTextBoxColumn1";
            // 
            // m2mcarstypesBindingSource
            // 
            this.m2mcarstypesBindingSource.DataMember = "m2m_cars_types";
            this.m2mcarstypesBindingSource.DataSource = this.carservice_BakhmutovDataSet6;
            // 
            // carservice_BakhmutovDataSet6
            // 
            this.carservice_BakhmutovDataSet6.DataSetName = "carservice_BakhmutovDataSet6";
            this.carservice_BakhmutovDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // fuelsTableAdapter
            // 
            this.fuelsTableAdapter.ClearBeforeFill = true;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // m2m_cars_fuelsTableAdapter
            // 
            this.m2m_cars_fuelsTableAdapter.ClearBeforeFill = true;
            // 
            // m2m_cars_typesTableAdapter
            // 
            this.m2m_cars_typesTableAdapter.ClearBeforeFill = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form";
            this.Text = "Сервис аренды автомобилей";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet3)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet4)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2mcarsfuelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet5)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2mcarstypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservice_BakhmutovDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private carservice_BakhmutovDataSet carservice_BakhmutovDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private carservice_BakhmutovDataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private carservice_BakhmutovDataSet1 carservice_BakhmutovDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private carservice_BakhmutovDataSet1TableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private carservice_BakhmutovDataSet2 carservice_BakhmutovDataSet2;
        private System.Windows.Forms.BindingSource fuelsBindingSource;
        private carservice_BakhmutovDataSet2TableAdapters.fuelsTableAdapter fuelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private carservice_BakhmutovDataSet3 carservice_BakhmutovDataSet3;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private carservice_BakhmutovDataSet3TableAdapters.typesTableAdapter typesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private carservice_BakhmutovDataSet4 carservice_BakhmutovDataSet4;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private carservice_BakhmutovDataSet4TableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ostartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oisactiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView6;
        private carservice_BakhmutovDataSet5 carservice_BakhmutovDataSet5;
        private System.Windows.Forms.BindingSource m2mcarsfuelsBindingSource;
        private carservice_BakhmutovDataSet5TableAdapters.m2m_cars_fuelsTableAdapter m2m_cars_fuelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView7;
        private carservice_BakhmutovDataSet6 carservice_BakhmutovDataSet6;
        private System.Windows.Forms.BindingSource m2mcarstypesBindingSource;
        private carservice_BakhmutovDataSet6TableAdapters.m2m_cars_typesTableAdapter m2m_cars_typesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button ordersSave;
        private System.Windows.Forms.Button carsSave;
        private System.Windows.Forms.Button clientsSave;
        private System.Windows.Forms.Button fuelsSave;
        private System.Windows.Forms.Button typesSave;
        private System.Windows.Forms.Button carsAndfuelsSave;
        private System.Windows.Forms.Button carsAndtypesSave;
        private System.Windows.Forms.Button carsFinder;
        private System.Windows.Forms.TextBox DataGridFinder1;
        private System.Windows.Forms.Button fuelsFinder;
        private System.Windows.Forms.TextBox DataGridFinder3;
        private System.Windows.Forms.Button typesFinder;
        private System.Windows.Forms.TextBox DataGridFinder4;
        private System.Windows.Forms.Button ordersFinder;
        private System.Windows.Forms.TextBox DataGridFinder5;
        private System.Windows.Forms.Button carsAndfuelsFinder;
        private System.Windows.Forms.TextBox DataGridFinder6;
        private System.Windows.Forms.Button carsAndtypesFinder;
        private System.Windows.Forms.TextBox DataGridFinder7;
    }
}