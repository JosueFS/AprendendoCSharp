namespace WF01
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.linkGit = new System.Windows.Forms.LinkLabel();
            this.checkShuffle = new System.Windows.Forms.CheckBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lvTimes = new System.Windows.Forms.ListView();
            this.Times = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddTime = new System.Windows.Forms.Button();
            this.btDelTime = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.Transparent;
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerar.Location = new System.Drawing.Point(324, 331);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 28);
            this.btnGerar.TabIndex = 10;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.GerarTabela);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(171, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 23);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ESTAGIO 2019 - GEOPOST";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // linkGit
            // 
            this.linkGit.AutoSize = true;
            this.linkGit.BackColor = System.Drawing.Color.Transparent;
            this.linkGit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGit.Location = new System.Drawing.Point(532, 340);
            this.linkGit.Name = "linkGit";
            this.linkGit.Size = new System.Drawing.Size(45, 16);
            this.linkGit.TabIndex = 2;
            this.linkGit.TabStop = true;
            this.linkGit.Text = "GitHub";
            this.linkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGit_LinkClicked);
            // 
            // checkShuffle
            // 
            this.checkShuffle.AutoSize = true;
            this.checkShuffle.BackColor = System.Drawing.Color.Transparent;
            this.checkShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkShuffle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShuffle.Location = new System.Drawing.Point(12, 301);
            this.checkShuffle.Name = "checkShuffle";
            this.checkShuffle.Size = new System.Drawing.Size(130, 20);
            this.checkShuffle.TabIndex = 3;
            this.checkShuffle.Text = "Ordem Aleatória";
            this.checkShuffle.UseVisualStyleBackColor = false;
            // 
            // cbUF
            // 
            this.cbUF.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbUF.Location = new System.Drawing.Point(126, 60);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(133, 24);
            this.cbUF.TabIndex = 1;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.BackColor = System.Drawing.Color.Transparent;
            this.lblUF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUF.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(129, 40);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(52, 16);
            this.lblUF.TabIndex = 5;
            this.lblUF.Text = "Estado";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(12, 60);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(111, 23);
            this.txtTime.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(15, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 16);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // lvTimes
            // 
            this.lvTimes.BackColor = System.Drawing.SystemColors.Window;
            this.lvTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Times,
            this.Estado});
            this.lvTimes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTimes.FullRowSelect = true;
            this.lvTimes.GridLines = true;
            this.lvTimes.Location = new System.Drawing.Point(324, 49);
            this.lvTimes.Name = "lvTimes";
            this.lvTimes.Size = new System.Drawing.Size(250, 280);
            this.lvTimes.TabIndex = 8;
            this.lvTimes.UseCompatibleStateImageBehavior = false;
            this.lvTimes.View = System.Windows.Forms.View.Details;
            // 
            // Times
            // 
            this.Times.Text = "Times";
            this.Times.Width = 115;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 130;
            // 
            // btAddTime
            // 
            this.btAddTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(186)))), ((int)(((byte)(124)))));
            this.btAddTime.BackgroundImage = global::WF01.Properties.Resources.OK;
            this.btAddTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(186)))), ((int)(((byte)(124)))));
            this.btAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddTime.Location = new System.Drawing.Point(263, 60);
            this.btAddTime.Margin = new System.Windows.Forms.Padding(1);
            this.btAddTime.Name = "btAddTime";
            this.btAddTime.Size = new System.Drawing.Size(23, 23);
            this.btAddTime.TabIndex = 2;
            this.btAddTime.UseVisualStyleBackColor = false;
            this.btAddTime.Click += new System.EventHandler(this.btAddTime_Click);
            this.btAddTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btAddTime_KeyDown);
            // 
            // btDelTime
            // 
            this.btDelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(83)))), ((int)(((byte)(72)))));
            this.btDelTime.BackgroundImage = global::WF01.Properties.Resources.Cancel;
            this.btDelTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelTime.Location = new System.Drawing.Point(289, 60);
            this.btDelTime.Margin = new System.Windows.Forms.Padding(0);
            this.btDelTime.Name = "btDelTime";
            this.btDelTime.Size = new System.Drawing.Size(23, 23);
            this.btDelTime.TabIndex = 3;
            this.btDelTime.UseVisualStyleBackColor = false;
            this.btDelTime.Click += new System.EventHandler(this.btDelTime_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.White;
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(13, 90);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(299, 23);
            this.lblMsg.TabIndex = 11;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WF01.Properties.Resources.bgMain;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btDelTime);
            this.Controls.Add(this.btAddTime);
            this.Controls.Add(this.lvTimes);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.checkShuffle);
            this.Controls.Add(this.linkGit);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.Text = "Campeonato Geopost 2019";
            this.TransparencyKey = System.Drawing.Color.LightCyan;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.LinkLabel linkGit;
        private System.Windows.Forms.CheckBox checkShuffle;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ListView lvTimes;
        private System.Windows.Forms.ColumnHeader Times;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.Button btAddTime;
        private System.Windows.Forms.Button btDelTime;
        private System.Windows.Forms.Label lblMsg;
    }
}

