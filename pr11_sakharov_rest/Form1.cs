using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pr11_sakharov_rest.BuilderBurger;
using pr11_sakharov_rest.DBCon;

namespace pr11_sakharov_rest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Model1 model = new Model1();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            BurgerBuilder burgerBuilder = new BurgerBuilder();
            BurgerDirector burgerDirector = new BurgerDirector(burgerBuilder);

            if (burgerComboBox.SelectedItem.ToString() == "Бургер стандартный") burgerDirector.BuildDefault();
            else burgerDirector.BuildWithBacon();

            try
            {
                model.Burgers.Add(burgerBuilder.GetBurgers());
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
        }
        private void LoadData()
        {
            burgerComboBox.SelectedIndex = 0;
            dataGridView.DataSource = model.Burgers.ToList();
        }
    }
}
