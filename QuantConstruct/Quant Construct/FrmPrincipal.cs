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

        private void cmdChapisco_Click(object sender, EventArgs e)
        {
            FrmChapisco CH = new FrmChapisco();
            CH.ShowDialog();
        }

        private void Contrapiso_Click(object sender, EventArgs e)
        {
            Frm_Contrapiso_CimentoeAreia Cnt = new Frm_Contrapiso_CimentoeAreia();
            Cnt.ShowDialog();
        }

        private void cmdPiso_Click(object sender, EventArgs e)
        {
            FrmPiso Ps = new FrmPiso();
            Ps.ShowDialog();
        }

        private void cmdPisoConcreto_Click(object sender, EventArgs e)
        {
            FrmPisoConcreto PsC = new FrmPisoConcreto();
            PsC.ShowDialog();
        }

        private void cmdTelhas_Click(object sender, EventArgs e)
        {
            FrmTelhas Tl = new FrmTelhas();
            Tl.ShowDialog();
        }
    }
}
