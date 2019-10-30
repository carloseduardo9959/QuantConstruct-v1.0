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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmdAssentamento = new System.Windows.Forms.Button();
            this.cmdChapisco = new System.Windows.Forms.Button();
            this.Contrapiso = new System.Windows.Forms.Button();
            this.cmdPiso = new System.Windows.Forms.Button();
            this.cmdPisoConcreto = new System.Windows.Forms.Button();
            this.cmdTelhas = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.cmdTelhas);
            this.metroPanel1.Controls.Add(this.cmdPisoConcreto);
            this.metroPanel1.Controls.Add(this.cmdPiso);
            this.metroPanel1.Controls.Add(this.Contrapiso);
            this.metroPanel1.Controls.Add(this.cmdChapisco);
            this.metroPanel1.Controls.Add(this.cmdAssentamento);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(37, 75);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(289, 328);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmdAssentamento
            // 
            this.cmdAssentamento.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdAssentamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAssentamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAssentamento.Location = new System.Drawing.Point(15, 17);
            this.cmdAssentamento.Name = "cmdAssentamento";
            this.cmdAssentamento.Size = new System.Drawing.Size(257, 37);
            this.cmdAssentamento.TabIndex = 2;
            this.cmdAssentamento.Text = "Assentamento de Tijolos";
            this.cmdAssentamento.UseVisualStyleBackColor = false;
            this.cmdAssentamento.Click += new System.EventHandler(this.cmdAssentamento_Click);
            // 
            // cmdChapisco
            // 
            this.cmdChapisco.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdChapisco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdChapisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChapisco.Location = new System.Drawing.Point(15, 60);
            this.cmdChapisco.Name = "cmdChapisco";
            this.cmdChapisco.Size = new System.Drawing.Size(257, 37);
            this.cmdChapisco.TabIndex = 2;
            this.cmdChapisco.Text = "Chapisco";
            this.cmdChapisco.UseVisualStyleBackColor = false;
            // 
            // Contrapiso
            // 
            this.Contrapiso.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Contrapiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contrapiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrapiso.Location = new System.Drawing.Point(15, 103);
            this.Contrapiso.Name = "Contrapiso";
            this.Contrapiso.Size = new System.Drawing.Size(257, 37);
            this.Contrapiso.TabIndex = 2;
            this.Contrapiso.Text = "Contrapiso";
            this.Contrapiso.UseVisualStyleBackColor = false;
            // 
            // cmdPiso
            // 
            this.cmdPiso.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdPiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPiso.Location = new System.Drawing.Point(15, 146);
            this.cmdPiso.Name = "cmdPiso";
            this.cmdPiso.Size = new System.Drawing.Size(257, 37);
            this.cmdPiso.TabIndex = 2;
            this.cmdPiso.Text = "Piso";
            this.cmdPiso.UseVisualStyleBackColor = false;
            // 
            // cmdPisoConcreto
            // 
            this.cmdPisoConcreto.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdPisoConcreto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPisoConcreto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPisoConcreto.Location = new System.Drawing.Point(15, 189);
            this.cmdPisoConcreto.Name = "cmdPisoConcreto";
            this.cmdPisoConcreto.Size = new System.Drawing.Size(257, 37);
            this.cmdPisoConcreto.TabIndex = 2;
            this.cmdPisoConcreto.Text = "Piso Concreto";
            this.cmdPisoConcreto.UseVisualStyleBackColor = false;
            // 
            // cmdTelhas
            // 
            this.cmdTelhas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdTelhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdTelhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTelhas.Location = new System.Drawing.Point(15, 232);
            this.cmdTelhas.Name = "cmdTelhas";
            this.cmdTelhas.Size = new System.Drawing.Size(257, 37);
            this.cmdTelhas.TabIndex = 2;
            this.cmdTelhas.Text = "Telhas";
            this.cmdTelhas.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmPrincipal";
            this.Text = "Quant Construct";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button cmdPiso;
        private System.Windows.Forms.Button Contrapiso;
        private System.Windows.Forms.Button cmdChapisco;
        private System.Windows.Forms.Button cmdAssentamento;
        private System.Windows.Forms.Button cmdTelhas;
        private System.Windows.Forms.Button cmdPisoConcreto;
    }
}

