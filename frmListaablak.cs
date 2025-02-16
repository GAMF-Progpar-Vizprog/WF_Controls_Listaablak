using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listaablak
{
	public partial class frmListaablak : Form
	{
		public frmListaablak()
		{
			InitializeComponent();
		}
		private void btFeltölt_Click(object sender, System.EventArgs e)
		{
			string[] nevek = { "Alma", "Körte", "Banán", "Narancs" };
			lbListaablak.Items.AddRange(nevek);
		}

		private void lbListaablak_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			tbListaelem.Text = (string)lbListaablak.SelectedItem;
		}

	}
}
