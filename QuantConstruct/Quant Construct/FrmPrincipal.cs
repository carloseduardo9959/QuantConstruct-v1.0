using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quant_Construct
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdAssentamento_Click(object sender, EventArgs e)
        {
            Frm_tijolos_assentamento AT = new Frm_tijolos_assentamento();
            AT.ShowDialog();
        }
    }
}
