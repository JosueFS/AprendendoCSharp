namespace ESTAGIO
{
    partial class Tabela
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCampeao = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.pcbCup = new System.Windows.Forms.PictureBox();
            this.RankList = new System.Windows.Forms.ListView();
            this.RankPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pontos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vitorias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Empates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Derrotas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCup)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(855, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rodadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.lblCampeao);
            this.tabPage2.Controls.Add(this.lblPrize);
            this.tabPage2.Controls.Add(this.pcbCup);
            this.tabPage2.Controls.Add(this.RankList);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classificação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCampeao
            // 
            this.lblCampeao.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampeao.Location = new System.Drawing.Point(432, 6);
            this.lblCampeao.Name = "lblCampeao";
            this.lblCampeao.Size = new System.Drawing.Size(417, 51);
            this.lblCampeao.TabIndex = 2;
            this.lblCampeao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrize
            // 
            this.lblPrize.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(432, 405);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(417, 51);
            this.lblPrize.TabIndex = 2;
            this.lblPrize.Text = "CAMPEÃO LIGA GEOhub";
            this.lblPrize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbCup
            // 
            this.pcbCup.Image = global::WF01.Properties.Resources.cup;
            this.pcbCup.Location = new System.Drawing.Point(460, 38);
            this.pcbCup.Name = "pcbCup";
            this.pcbCup.Size = new System.Drawing.Size(359, 396);
            this.pcbCup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCup.TabIndex = 1;
            this.pcbCup.TabStop = false;
            this.pcbCup.WaitOnLoad = true;
            // 
            // RankList
            // 
            this.RankList.AllowColumnReorder = true;
            this.RankList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RankList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RankPosition,
            this.Time,
            this.Pontos,
            this.Vitorias,
            this.Empates,
            this.Derrotas});
            this.RankList.FullRowSelect = true;
            this.RankList.GridLines = true;
            this.RankList.Location = new System.Drawing.Point(8, 6);
            this.RankList.Name = "RankList";
            this.RankList.Size = new System.Drawing.Size(417, 450);
            this.RankList.TabIndex = 0;
            this.RankList.UseCompatibleStateImageBehavior = false;
            this.RankList.View = System.Windows.Forms.View.Details;
            // 
            // RankPosition
            // 
            this.RankPosition.Text = "";
            this.RankPosition.Width = 30;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time.Width = 202;
            // 
            // Pontos
            // 
            this.Pontos.Text = "Pontos";
            this.Pontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pontos.Width = 71;
            // 
            // Vitorias
            // 
            this.Vitorias.Text = "V";
            this.Vitorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Vitorias.Width = 40;
            // 
            // Empates
            // 
            this.Empates.Text = "E";
            this.Empates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Empates.Width = 38;
            // 
            // Derrotas
            // 
            this.Derrotas.Text = "D";
            this.Derrotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Derrotas.Width = 36;
            // 
            // Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liga GEOhub 2019";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tabela_FormClosed);
            this.Load += new System.EventHandler(this.Tabela_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView RankList;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Pontos;
        private System.Windows.Forms.ColumnHeader Vitorias;
        private System.Windows.Forms.ColumnHeader Empates;
        private System.Windows.Forms.ColumnHeader Derrotas;
        private System.Windows.Forms.ColumnHeader RankPosition;
        private System.Windows.Forms.PictureBox pcbCup;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label lblCampeao;
    }
}