namespace TopoSauro
{
    partial class TopoSauro
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopoSauro));
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.Top1 = new System.Windows.Forms.PictureBox();
            this.Top2 = new System.Windows.Forms.PictureBox();
            this.TickSfondo = new System.Windows.Forms.Timer(this.components);
            this.Top3 = new System.Windows.Forms.PictureBox();
            this.Topo = new System.Windows.Forms.PictureBox();
            this.Salto = new System.Windows.Forms.Timer(this.components);
            this.Discesa = new System.Windows.Forms.Timer(this.components);
            this.TopoBasso = new System.Windows.Forms.PictureBox();
            this.SpawnTick = new System.Windows.Forms.Timer(this.components);
            this.HitBoxTopo = new System.Windows.Forms.PictureBox();
            this.HitBoxTopoBasso = new System.Windows.Forms.PictureBox();
            this.Punteggio = new System.Windows.Forms.Label();
            this.AfterDeath = new System.Windows.Forms.Timer(this.components);
            this.Continua = new System.Windows.Forms.PictureBox();
            this.record = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Top1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Topo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopoBasso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitBoxTopo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitBoxTopoBasso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continua)).BeginInit();
            this.SuspendLayout();
            // 
            // Tick
            // 
            this.Tick.Interval = 10;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // Top1
            // 
            this.Top1.Image = ((System.Drawing.Image)(resources.GetObject("Top1.Image")));
            this.Top1.Location = new System.Drawing.Point(0, 0);
            this.Top1.Name = "Top1";
            this.Top1.Size = new System.Drawing.Size(800, 157);
            this.Top1.TabIndex = 0;
            this.Top1.TabStop = false;
            // 
            // Top2
            // 
            this.Top2.Image = ((System.Drawing.Image)(resources.GetObject("Top2.Image")));
            this.Top2.Location = new System.Drawing.Point(0, 0);
            this.Top2.Name = "Top2";
            this.Top2.Size = new System.Drawing.Size(800, 157);
            this.Top2.TabIndex = 1;
            this.Top2.TabStop = false;
            // 
            // TickSfondo
            // 
            this.TickSfondo.Interval = 10;
            this.TickSfondo.Tick += new System.EventHandler(this.TickSfondo_Tick);
            // 
            // Top3
            // 
            this.Top3.Image = ((System.Drawing.Image)(resources.GetObject("Top3.Image")));
            this.Top3.Location = new System.Drawing.Point(0, 0);
            this.Top3.Name = "Top3";
            this.Top3.Size = new System.Drawing.Size(800, 157);
            this.Top3.TabIndex = 2;
            this.Top3.TabStop = false;
            // 
            // Topo
            // 
            this.Topo.BackColor = System.Drawing.Color.Transparent;
            this.Topo.Image = ((System.Drawing.Image)(resources.GetObject("Topo.Image")));
            this.Topo.Location = new System.Drawing.Point(0, 271);
            this.Topo.Name = "Topo";
            this.Topo.Size = new System.Drawing.Size(100, 100);
            this.Topo.TabIndex = 3;
            this.Topo.TabStop = false;
            // 
            // Salto
            // 
            this.Salto.Interval = 10;
            this.Salto.Tick += new System.EventHandler(this.Salto_Tick);
            // 
            // Discesa
            // 
            this.Discesa.Interval = 10;
            this.Discesa.Tick += new System.EventHandler(this.Discesa_Tick);
            // 
            // TopoBasso
            // 
            this.TopoBasso.BackColor = System.Drawing.Color.Transparent;
            this.TopoBasso.Image = ((System.Drawing.Image)(resources.GetObject("TopoBasso.Image")));
            this.TopoBasso.Location = new System.Drawing.Point(0, 296);
            this.TopoBasso.Name = "TopoBasso";
            this.TopoBasso.Size = new System.Drawing.Size(100, 75);
            this.TopoBasso.TabIndex = 4;
            this.TopoBasso.TabStop = false;
            this.TopoBasso.Visible = false;
            // 
            // SpawnTick
            // 
            this.SpawnTick.Interval = 700;
            this.SpawnTick.Tick += new System.EventHandler(this.SpawnTick_Tick);
            // 
            // HitBoxTopo
            // 
            this.HitBoxTopo.BackColor = System.Drawing.Color.Black;
            this.HitBoxTopo.Location = new System.Drawing.Point(39, 276);
            this.HitBoxTopo.Name = "HitBoxTopo";
            this.HitBoxTopo.Size = new System.Drawing.Size(52, 95);
            this.HitBoxTopo.TabIndex = 5;
            this.HitBoxTopo.TabStop = false;
            this.HitBoxTopo.Visible = false;
            // 
            // HitBoxTopoBasso
            // 
            this.HitBoxTopoBasso.BackColor = System.Drawing.Color.Black;
            this.HitBoxTopoBasso.Location = new System.Drawing.Point(39, 296);
            this.HitBoxTopoBasso.Name = "HitBoxTopoBasso";
            this.HitBoxTopoBasso.Size = new System.Drawing.Size(52, 75);
            this.HitBoxTopoBasso.TabIndex = 6;
            this.HitBoxTopoBasso.TabStop = false;
            this.HitBoxTopoBasso.Visible = false;
            // 
            // Punteggio
            // 
            this.Punteggio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Punteggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punteggio.Location = new System.Drawing.Point(637, 169);
            this.Punteggio.Name = "Punteggio";
            this.Punteggio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Punteggio.Size = new System.Drawing.Size(145, 16);
            this.Punteggio.TabIndex = 8;
            this.Punteggio.Text = "0";
            this.Punteggio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AfterDeath
            // 
            this.AfterDeath.Interval = 250;
            this.AfterDeath.Tick += new System.EventHandler(this.AfterDeath_Tick);
            // 
            // Continua
            // 
            this.Continua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Continua.Image = ((System.Drawing.Image)(resources.GetObject("Continua.Image")));
            this.Continua.Location = new System.Drawing.Point(297, 169);
            this.Continua.Name = "Continua";
            this.Continua.Size = new System.Drawing.Size(200, 100);
            this.Continua.TabIndex = 9;
            this.Continua.TabStop = false;
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.record.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.Location = new System.Drawing.Point(81, 172);
            this.record.Name = "record";
            this.record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.record.Size = new System.Drawing.Size(16, 16);
            this.record.TabIndex = 10;
            this.record.Text = "0";
            this.record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Record:";
            // 
            // TopoSauro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(794, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.record);
            this.Controls.Add(this.Continua);
            this.Controls.Add(this.Punteggio);
            this.Controls.Add(this.HitBoxTopoBasso);
            this.Controls.Add(this.HitBoxTopo);
            this.Controls.Add(this.TopoBasso);
            this.Controls.Add(this.Topo);
            this.Controls.Add(this.Top3);
            this.Controls.Add(this.Top2);
            this.Controls.Add(this.Top1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopoSauro";
            this.Text = "TopoSauro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Top1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Topo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopoBasso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitBoxTopo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitBoxTopoBasso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.PictureBox Top1;
        private System.Windows.Forms.PictureBox Top2;
        private System.Windows.Forms.Timer TickSfondo;
        private System.Windows.Forms.PictureBox Top3;
        private System.Windows.Forms.PictureBox Topo;
        private System.Windows.Forms.Timer Salto;
        private System.Windows.Forms.Timer Discesa;
        private System.Windows.Forms.PictureBox TopoBasso;
        private AxWMPLib.AxWindowsMediaPlayer Jump;
        private System.Windows.Forms.Timer SpawnTick;
        private System.Windows.Forms.PictureBox HitBoxTopo;
        private System.Windows.Forms.PictureBox HitBoxTopoBasso;
        private System.Windows.Forms.Label Punteggio;
        private System.Windows.Forms.Timer AfterDeath;
        private System.Windows.Forms.PictureBox Continua;
        private System.Windows.Forms.Label record;
        private System.Windows.Forms.Label label2;
    }
}

