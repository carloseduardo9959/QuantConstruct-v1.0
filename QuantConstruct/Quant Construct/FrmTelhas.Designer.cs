namespace Quant_Construct
{
    partial class FrmTelhas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtArea = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cbTelhas = new MetroFramework.Controls.MetroComboBox();
            this.btnCalcular = new MetroFramework.Controls.MetroButton();
            this.lblQtdTelha = new System.Windows.Forms.GroupBox();
            this.lblQtdTelhas = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lblQtdTelha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(125, 52);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(75, 23);
            this.txtArea.TabIndex = 7;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(11, 56);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Área do telhado:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(11, 99);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(46, 19);
            this.metroLabel14.TabIndex = 9;
            this.metroLabel14.Text = "Telhas:";
            // 
            // cbTelhas
            // 
            this.cbTelhas.FormattingEnabled = true;
            this.cbTelhas.ItemHeight = 23;
            this.cbTelhas.Items.AddRange(new object[] {
            "Telha Americana",
            "Telha Francesa",
            "Telha Portuguesa",
            "Telha Romana"});
            this.cbTelhas.Location = new System.Drawing.Point(63, 89);
            this.cbTelhas.Name = "cbTelhas";
            this.cbTelhas.Size = new System.Drawing.Size(137, 29);
            this.cbTelhas.TabIndex = 8;
            this.cbTelhas.SelectedIndexChanged += new System.EventHandler(this.cbTelhas_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(234, 222);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 30);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblQtdTelha
            // 
            this.lblQtdTelha.Controls.Add(this.lblQtdTelhas);
            this.lblQtdTelha.Controls.Add(this.metroLabel6);
            this.lblQtdTelha.Location = new System.Drawing.Point(23, 267);
            this.lblQtdTelha.Name = "lblQtdTelha";
            this.lblQtdTelha.Size = new System.Drawing.Size(687, 160);
            this.lblQtdTelha.TabIndex = 24;
            this.lblQtdTelha.TabStop = false;
            this.lblQtdTelha.Text = "Telhas de Barro";
            // 
            // lblQtdTelhas
            // 
            this.lblQtdTelhas.AutoSize = true;
            this.lblQtdTelhas.Location = new System.Drawing.Point(157, 43);
            this.lblQtdTelhas.Name = "lblQtdTelhas";
            this.lblQtdTelhas.Size = new System.Drawing.Size(16, 19);
            this.lblQtdTelhas.TabIndex = 0;
            this.lblQtdTelhas.Text = "0";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(9, 43);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(142, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Quantidade de Telhas: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(487, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.cbTelhas);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.txtArea);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(329, 140);
            this.metroPanel1.TabIndex = 26;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(323, 41);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Dados:";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // FrmTelhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQtdTelha);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FrmTelhas";
            this.Text = "Telhas de Barro";
            this.lblQtdTelha.ResumeLayout(false);
            this.lblQtdTelha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtArea;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroComboBox cbTelhas;
        private MetroFramework.Controls.MetroButton btnCalcular;
        private System.Windows.Forms.GroupBox lblQtdTelha;
        private MetroFramework.Controls.MetroLabel lblQtdTelhas;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}