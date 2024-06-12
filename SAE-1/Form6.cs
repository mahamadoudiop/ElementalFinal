using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_1
{
    public partial class Form6 : Form
    {
        private FormPause formPause;

        public Form6()
        {
            InitializeComponent();
            formPause = null;
        }
        public Form6(FormPause formPause)
        {
            InitializeComponent();
            this.formPause = formPause;
        }


        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (formPause != null)
            {
                
                formPause.Show();
                this.Hide();
            }
            else
            {
                FormMenu FormMenu = new FormMenu();
                FormMenu.Show();
                this.Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}

//public partial class FormMenuOptions : Form
//{
//    private FormMenuPrincipal formMenuPrincipal;
//    private FormMenuPause formMenuPause;
//    private bool isBtnRetourClicked = false;

//    public FormMenuOptions(FormMenuPrincipal formMenuPrincipal)
//    {
//        InitializeComponent();
//        this.formMenuPrincipal = formMenuPrincipal;
//        formMenuPause = null;
//    }

//    public FormMenuOptions(FormMenuPrincipal formMenuPrincipal, FormMenuPause formMenuPause)
//    {
//        InitializeComponent();
//        this.formMenuPrincipal = formMenuPrincipal;
//        this.formMenuPause = formMenuPause;
//    }