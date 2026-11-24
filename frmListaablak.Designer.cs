
namespace WF_Controls_Listaablak
{
	partial class frmListaablak
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbListaablak = new System.Windows.Forms.ListBox();
			this.btFeltölt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbListaelem = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbListaablak
			// 
			this.lbListaablak.ItemHeight = 25;
			this.lbListaablak.Items.AddRange(new object[] {
            "egy ",
            "kettő",
            "három"});
			this.lbListaablak.Location = new System.Drawing.Point(14, 30);
			this.lbListaablak.Name = "lbListaablak";
			this.lbListaablak.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbListaablak.Size = new System.Drawing.Size(274, 229);
			this.lbListaablak.TabIndex = 0;
			this.lbListaablak.SelectedIndexChanged += new System.EventHandler(this.lbListaablak_SelectedIndexChanged);
			// 
			// btFeltölt
			// 
			this.btFeltölt.Location = new System.Drawing.Point(302, 30);
			this.btFeltölt.Name = "btFeltölt";
			this.btFeltölt.Size = new System.Drawing.Size(135, 42);
			this.btFeltölt.TabIndex = 1;
			this.btFeltölt.Text = "Feltölt";
			this.btFeltölt.Click += new System.EventHandler(this.btFeltölt_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 325);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = "A kiválasztott listaelem:";
			// 
			// tbListaelem
			// 
			this.tbListaelem.Location = new System.Drawing.Point(245, 325);
			this.tbListaelem.Name = "tbListaelem";
			this.tbListaelem.Size = new System.Drawing.Size(259, 31);
			this.tbListaelem.TabIndex = 3;
			// 
			// frmListaablak
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(9, 24);
			this.ClientSize = new System.Drawing.Size(540, 380);
			this.Controls.Add(this.tbListaelem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btFeltölt);
			this.Controls.Add(this.lbListaablak);
			this.Name = "frmListaablak";
			this.Text = "Listaablak használata";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbListaablak;
		private System.Windows.Forms.Button btFeltölt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbListaelem;

	}
}

