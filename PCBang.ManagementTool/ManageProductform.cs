using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerForm
{
    public partial class ManageProductform : Form
    {
        public ManageProductform()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txbPhoto.Text == null)
                return;
           
            DataRepository.Product.AddPhoto((int)cbbProduct.SelectedValue, "C:\\git\\PCBang\\FoodPhoto\\" + txbPhoto.Text);
            MessageBox.Show($"{cbbProduct.SelectedValue}{txbPhoto.Text}");
        }

        private void ManageProductform_Load(object sender, EventArgs e)
        {
            bdsProduct.DataSource = DataRepository.Product.GetAll();
        }
    }
}
