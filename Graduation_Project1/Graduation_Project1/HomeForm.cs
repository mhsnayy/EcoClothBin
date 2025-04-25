using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_Project1
{
    public partial class HomeForm : Form
    {
        private UserEditForm ufrm;
        private ClothesForm cfrm;
        private BoxesForm bfrm;
        
        public string _statu;
        public Label lblstatu = new Label();
        
        public HomeForm()
        {
            InitializeComponent();
        }
        //go to Clothes Form    
        private void btnClothesForm_Click(object sender, EventArgs e)
        {
            if (cfrm == null || cfrm.IsDisposed)
            {
                cfrm = new ClothesForm();
            }
            cfrm.Show(); 
            this.Hide();
        }
        //Go to Box Form
        private async void btnBoxForm_Click(object sender, EventArgs e)
        {
            if (bfrm == null || bfrm.IsDisposed)
            {
                bfrm = new BoxesForm();
            }
            bfrm.Show(); 
            this.Hide();
        }
        //go to edit user form
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (ufrm == null || ufrm.IsDisposed)
            {
                ufrm = new UserEditForm();
            }
            ufrm.Show(); 
            this.Hide();
        }

        private  void HomeForm_Load(object sender, EventArgs e)
        {  
            _statu = lblstatu.Text;
            if (_statu=="True")
            {
                btnEditUser.Visible = true;
                btnEditUser.Enabled = true;
            }
            else
            {
                btnEditUser.Visible = false;
                btnEditUser.Enabled = false;
            }
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
