namespace UT_KIT2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGV_Clicks = new System.Windows.Forms.DataGridView();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.TB_TempoAtraso = new System.Windows.Forms.TrackBar();
            this.txt_TempoAtraso = new System.Windows.Forms.TextBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.Timer_AtrasoInicio = new System.Windows.Forms.Timer(this.components);
            this.Timer_EntreClicks = new System.Windows.Forms.Timer(this.components);
            this.TB_Intervalo = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_Intervalo = new System.Windows.Forms.TextBox();
            this.LBL_Help = new System.Windows.Forms.Label();
            this.btnAddEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_TempoAtraso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Intervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Clicks
            // 
            this.DGV_Clicks.AllowUserToAddRows = false;
            this.DGV_Clicks.AllowUserToDeleteRows = false;
            this.DGV_Clicks.AllowUserToOrderColumns = true;
            this.DGV_Clicks.AllowUserToResizeColumns = false;
            this.DGV_Clicks.AllowUserToResizeRows = false;
            this.DGV_Clicks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Clicks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordem,
            this.X_Value,
            this.Y_Value});
            this.DGV_Clicks.Location = new System.Drawing.Point(12, 12);
            this.DGV_Clicks.Name = "DGV_Clicks";
            this.DGV_Clicks.RowHeadersVisible = false;
            this.DGV_Clicks.Size = new System.Drawing.Size(248, 150);
            this.DGV_Clicks.TabIndex = 1;
            // 
            // Ordem
            // 
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.ReadOnly = true;
            this.Ordem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ordem.Width = 60;
            // 
            // X_Value
            // 
            this.X_Value.HeaderText = "X_Value";
            this.X_Value.Name = "X_Value";
            this.X_Value.ReadOnly = true;
            this.X_Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.X_Value.Width = 80;
            // 
            // Y_Value
            // 
            this.Y_Value.HeaderText = "Y_Value";
            this.Y_Value.Name = "Y_Value";
            this.Y_Value.ReadOnly = true;
            this.Y_Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Y_Value.Width = 80;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(266, 115);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // TB_TempoAtraso
            // 
            this.TB_TempoAtraso.Location = new System.Drawing.Point(12, 168);
            this.TB_TempoAtraso.Maximum = 20;
            this.TB_TempoAtraso.Name = "TB_TempoAtraso";
            this.TB_TempoAtraso.Size = new System.Drawing.Size(304, 45);
            this.TB_TempoAtraso.TabIndex = 3;
            this.toolTip1.SetToolTip(this.TB_TempoAtraso, "Atraso Inicial (s)");
            this.TB_TempoAtraso.Scroll += new System.EventHandler(this.TB_TempoAtraso_Scroll);
            // 
            // txt_TempoAtraso
            // 
            this.txt_TempoAtraso.Location = new System.Drawing.Point(322, 168);
            this.txt_TempoAtraso.Name = "txt_TempoAtraso";
            this.txt_TempoAtraso.ReadOnly = true;
            this.txt_TempoAtraso.Size = new System.Drawing.Size(61, 20);
            this.txt_TempoAtraso.TabIndex = 4;
            this.txt_TempoAtraso.Text = "0 (s)";
            this.txt_TempoAtraso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(12, 270);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar.TabIndex = 5;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // Timer_AtrasoInicio
            // 
            this.Timer_AtrasoInicio.Tick += new System.EventHandler(this.Timer_AtrasoInicio_Tick);
            // 
            // Timer_EntreClicks
            // 
            this.Timer_EntreClicks.Tick += new System.EventHandler(this.Timer_EntreClicks_Tick);
            // 
            // TB_Intervalo
            // 
            this.TB_Intervalo.Location = new System.Drawing.Point(12, 219);
            this.TB_Intervalo.Maximum = 10000;
            this.TB_Intervalo.Minimum = 500;
            this.TB_Intervalo.Name = "TB_Intervalo";
            this.TB_Intervalo.Size = new System.Drawing.Size(304, 45);
            this.TB_Intervalo.SmallChange = 50;
            this.TB_Intervalo.TabIndex = 6;
            this.TB_Intervalo.TickFrequency = 1000;
            this.toolTip1.SetToolTip(this.TB_Intervalo, "Intervalo entre Clicks (ms)");
            this.TB_Intervalo.Value = 500;
            this.TB_Intervalo.Scroll += new System.EventHandler(this.TB_Intervalo_Scroll);
            // 
            // txt_Intervalo
            // 
            this.txt_Intervalo.Location = new System.Drawing.Point(322, 219);
            this.txt_Intervalo.Name = "txt_Intervalo";
            this.txt_Intervalo.ReadOnly = true;
            this.txt_Intervalo.Size = new System.Drawing.Size(72, 20);
            this.txt_Intervalo.TabIndex = 7;
            this.txt_Intervalo.Text = "100 (ms)";
            this.txt_Intervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBL_Help
            // 
            this.LBL_Help.AutoSize = true;
            this.LBL_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Help.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Help.Location = new System.Drawing.Point(350, 9);
            this.LBL_Help.Name = "LBL_Help";
            this.LBL_Help.Size = new System.Drawing.Size(34, 13);
            this.LBL_Help.TabIndex = 8;
            this.LBL_Help.Text = "Ajuda";
            this.LBL_Help.Click += new System.EventHandler(this.LBL_Help_Click);
            // 
            // btnAddEnter
            // 
            this.btnAddEnter.Location = new System.Drawing.Point(266, 41);
            this.btnAddEnter.Name = "btnAddEnter";
            this.btnAddEnter.Size = new System.Drawing.Size(75, 23);
            this.btnAddEnter.TabIndex = 9;
            this.btnAddEnter.Text = "Add Enter";
            this.btnAddEnter.UseVisualStyleBackColor = true;
            this.btnAddEnter.Click += new System.EventHandler(this.btnAddEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(396, 303);
            this.Controls.Add(this.btnAddEnter);
            this.Controls.Add(this.LBL_Help);
            this.Controls.Add(this.txt_Intervalo);
            this.Controls.Add(this.TB_Intervalo);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.txt_TempoAtraso);
            this.Controls.Add(this.TB_TempoAtraso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.DGV_Clicks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UT_Kit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_TempoAtraso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Intervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Clicks;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TrackBar TB_TempoAtraso;
        private System.Windows.Forms.TextBox txt_TempoAtraso;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer Timer_AtrasoInicio;
        private System.Windows.Forms.Timer Timer_EntreClicks;
        private System.Windows.Forms.TrackBar TB_Intervalo;
        private System.Windows.Forms.TextBox txt_Intervalo;
        private System.Windows.Forms.Label LBL_Help;
        private System.Windows.Forms.Button btnAddEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Value;
    }
}

