using kaja.App_Code.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaja
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }


        public FormEdit(ANDROID_CAGE kaxa)
        {
            InitializeComponent();
            textEdit1.DataBindings.Add("EditValue", kaxa, "AREA");
            textEdit2.DataBindings.Add("EditValue", kaxa, "ESTANTE");
            textEdit3.DataBindings.Add("EditValue", kaxa, "IDCAGE");
            //textEdit1.Text = kaxa.AREA;
            //textEdit2.Text= kaxa.ESTANTE;
            //textEdit3.Text= kaxa.IDCAGE.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
