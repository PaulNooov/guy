using System;
using System.Windows.Forms;

namespace CarsRental
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            // Привязка обработчиков событий кнопок "Сохранить"
            this.carsSave.Click += new System.EventHandler(this.carsSave_Click);
            this.clientsSave.Click += new System.EventHandler(this.clientsSave_Click);
            this.fuelsSave.Click += new System.EventHandler(this.fuelsSave_Click);
            this.typesSave.Click += new System.EventHandler(this.typesSave_Click);
            this.ordersSave.Click += new System.EventHandler(this.ordersSave_Click);
            this.carsAndfuelsSave.Click += new System.EventHandler(this.carsAndfuelsSave_Click);
            this.carsAndtypesSave.Click += new System.EventHandler(this.carsAndtypesSave_Click);

            // Привязка обработчиков событий кнопок "Поиск"
            this.carsFinder.Click += new System.EventHandler(this.carsFinder_Click);
            this.fuelsFinder.Click += new System.EventHandler(this.fuelsFinder_Click);
            this.typesFinder.Click += new System.EventHandler(this.typesFinder_Click);
            this.ordersFinder.Click += new System.EventHandler(this.ordersFinder_Click);
            this.carsAndfuelsFinder.Click += new System.EventHandler(this.carsAndfuelsFinder_Click);
            this.carsAndtypesFinder.Click += new System.EventHandler(this.carsAndtypesFinder_Click);

        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Загрузка данных во все таблицы
            this.m2m_cars_typesTableAdapter.Fill(this.carservice_BakhmutovDataSet6.m2m_cars_types);
            this.m2m_cars_fuelsTableAdapter.Fill(this.carservice_BakhmutovDataSet5.m2m_cars_fuels);
            this.ordersTableAdapter.Fill(this.carservice_BakhmutovDataSet4.orders);
            this.typesTableAdapter.Fill(this.carservice_BakhmutovDataSet3.types);
            this.fuelsTableAdapter.Fill(this.carservice_BakhmutovDataSet2.fuels);
            this.clientsTableAdapter.Fill(this.carservice_BakhmutovDataSet1.clients);
            this.carsTableAdapter.Fill(this.carservice_BakhmutovDataSet.cars);
        }

        // Обработчики кнопок "Сохранить"
        private void carsSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carsBindingSource.EndEdit();
                this.carsTableAdapter.Update(this.carservice_BakhmutovDataSet.cars);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void clientsSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientsBindingSource.EndEdit();
                this.clientsTableAdapter.Update(this.carservice_BakhmutovDataSet1.clients);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void fuelsSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.fuelsBindingSource.EndEdit();
                this.fuelsTableAdapter.Update(this.carservice_BakhmutovDataSet2.fuels);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void typesSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.typesBindingSource.EndEdit();
                this.typesTableAdapter.Update(this.carservice_BakhmutovDataSet3.types);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void ordersSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ordersBindingSource.EndEdit();
                this.ordersTableAdapter.Update(this.carservice_BakhmutovDataSet4.orders);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void carsAndfuelsSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m2mcarsfuelsBindingSource.EndEdit();
                this.m2m_cars_fuelsTableAdapter.Update(this.carservice_BakhmutovDataSet5.m2m_cars_fuels);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void carsAndtypesSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m2mcarstypesBindingSource.EndEdit();
                this.m2m_cars_typesTableAdapter.Update(this.carservice_BakhmutovDataSet6.m2m_cars_types);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        // Обработчики кнопок "Поиск" — замените имена DataGridView на реальные из вашего проекта
        private void carsFinder_Click(object sender, EventArgs e)
        {
            SearchInDataGridView(this.carsDataGridView, DataGridFinder1.Text);
        }
        private void fuelsFinder_Click(object sender, EventArgs e)
        {
            SearchInDataGridView(this.fuelsDataGridView, DataGridFinder3.Text);
        }

        private void typesFinder_Click(object sender, EventArgs e)
        {
            SearchInDataGridView(this.typesDataGridView, DataGridFinder4.Text);
        }

        private void ordersFinder_Click(object sender, EventArgs e)
        {
            SearchInDataGridView(this.ordersDataGridView, DataGridFinder5.Text);
        }

        private void carsAndfuelsFinder_Click(object sender, EventArgs e)
        {
            SearchInDataGridView(this.carsAndfuelsDataGridView, DataGridFinder6.Text);
        }

        private void carsAndtypesFinder_Click(object sender, EventArgs e)
        {
            SearchInDataGridView(this.carsAndtypesDataGridView, DataGridFinder7.Text);
        }

        // Универсальный метод поиска и выделения строки в DataGridView
        private void SearchInDataGridView(DataGridView dgv, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Введите текст для поиска.");
                return;
            }

            dgv.ClearSelection();

            bool found = false;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Selected = true;
                        dgv.FirstDisplayedScrollingRowIndex = row.Index;
                        found = true;
                        break;
                    }
                }

                if (found) break;
            }

            if (!found)
            {
                MessageBox.Show("Информация не найдена.");
            }
        }
    }
}
