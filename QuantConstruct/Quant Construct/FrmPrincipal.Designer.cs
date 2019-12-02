namespace Quant_Construct
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.cmdAssentamentoTijolo = new MetroFramework.Controls.MetroTile();
            this.cmdChapisco = new MetroFramework.Controls.MetroTile();
            this.cmdPiso = new MetroFramework.Controls.MetroTile();
            this.cmdContrapiso = new MetroFramework.Controls.MetroTile();
            this.cmdPisoConcreto = new MetroFramework.Controls.MetroTile();
            this.cmdTelha = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAssentamentoTijolo
            // 
            this.cmdAssentamentoTijolo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAssentamentoTijolo.Location = new System.Drawing.Point(435, 94);
            this.cmdAssentamentoTijolo.Name = "cmdAssentamentoTijolo";
            this.cmdAssentamentoTijolo.Size = new System.Drawing.Size(253, 68);
            this.cmdAssentamentoTijolo.TabIndex = 1;
            this.cmdAssentamentoTijolo.Text = "Assentamento de Tijolos";
            this.cmdAssentamentoTijolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdAssentamentoTijolo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cmdAssentamentoTijolo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.cmdAssentamentoTijolo.Click += new System.EventHandler(this.cmdAssentamentoTijolo_Click);
            // 
            // cmdChapisco
            // 
            this.cmdChapisco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdChapisco.Location = new System.Drawing.Point(435, 170);
            this.cmdChapisco.Name = "cmdChapisco";
            this.cmdChapisco.Size = new System.Drawing.Size(178, 68);
            this.cmdChapisco.TabIndex = 2;
            this.cmdChapisco.Text = "Chapisco";
            this.cmdChapisco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdChapisco.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cmdChapisco.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.cmdChapisco.Click += new System.EventHandler(this.cmdChapisco_Click_1);
            // 
            // cmdPiso
            // 
            this.cmdPiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPiso.Location = new System.Drawing.Point(693, 94);
            this.cmdPiso.Name = "cmdPiso";
            this.cmdPiso.Size = new System.Drawing.Size(106, 68);
            this.cmdPiso.TabIndex = 3;
            this.cmdPiso.Text = "Piso ";
            this.cmdPiso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdPiso.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cmdPiso.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.cmdPiso.Click += new System.EventHandler(this.cmdPiso_Click_1);
            // 
            // cmdContrapiso
            // 
            this.cmdContrapiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdContrapiso.Location = new System.Drawing.Point(435, 250);
            this.cmdContrapiso.Name = "cmdContrapiso";
            this.cmdContrapiso.Size = new System.Drawing.Size(211, 68);
            this.cmdContrapiso.TabIndex = 4;
            this.cmdContrapiso.Text = "Regularização do piso";
            this.cmdContrapiso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdContrapiso.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cmdContrapiso.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.cmdContrapiso.Click += new System.EventHandler(this.cmdContrapiso_Click);
            // 
            // cmdPisoConcreto
            // 
            this.cmdPisoConcreto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPisoConcreto.Location = new System.Drawing.Point(619, 170);
            this.cmdPisoConcreto.Name = "cmdPisoConcreto";
            this.cmdPisoConcreto.Size = new System.Drawing.Size(180, 68);
            this.cmdPisoConcreto.TabIndex = 5;
            this.cmdPisoConcreto.Text = "Contrapiso";
            this.cmdPisoConcreto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdPisoConcreto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cmdPisoConcreto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.cmdPisoConcreto.Click += new System.EventHandler(this.cmdPisoConcreto_Click_1);
            // 
            // cmdTelha
            // 
            this.cmdTelha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdTelha.Location = new System.Drawing.Point(652, 250);
            this.cmdTelha.Name = "cmdTelha";
            this.cmdTelha.Size = new System.Drawing.Size(147, 68);
            this.cmdTelha.TabIndex = 6;
            this.cmdTelha.Text = "Telhas";
            this.cmdTelha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdTelha.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cmdTelha.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.cmdTelha.Click += new System.EventHandler(this.cmdTelha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quant_Construct.Properties.Resources.LogoQUant;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(833, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdTelha);
            this.Controls.Add(this.cmdPisoConcreto);
            this.Controls.Add(this.cmdContrapiso);
            this.Controls.Add(this.cmdPiso);
            this.Controls.Add(this.cmdChapisco);
            this.Controls.Add(this.cmdAssentamentoTijolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile cmdAssentamentoTijolo;
        private MetroFramework.Controls.MetroTile cmdChapisco;
        private MetroFramework.Controls.MetroTile cmdPiso;
        private MetroFramework.Controls.MetroTile cmdContrapiso;
        private MetroFramework.Controls.MetroTile cmdPisoConcreto;
        private MetroFramework.Controls.MetroTile cmdTelha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

