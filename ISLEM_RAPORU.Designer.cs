namespace teknikServisPro
{
    partial class ISLEM_RAPORU
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
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sumIskonto = new System.Windows.Forms.Label();
            this.sumKdv = new System.Windows.Forms.Label();
            this.sumGenelToplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dataGridView1.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnList;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 409);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Dönem ";
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(173, 2);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(110, 20);
            this.date2.TabIndex = 12;
            this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(59, 2);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(110, 20);
            this.date1.TabIndex = 10;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.sumIskonto);
            this.panel2.Controls.Add(this.sumKdv);
            this.panel2.Controls.Add(this.sumGenelToplam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 41);
            this.panel2.TabIndex = 16;
            // 
            // sumIskonto
            // 
            this.sumIskonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumIskonto.Dock = System.Windows.Forms.DockStyle.Right;
            this.sumIskonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sumIskonto.Location = new System.Drawing.Point(176, 0);
            this.sumIskonto.Name = "sumIskonto";
            this.sumIskonto.Size = new System.Drawing.Size(200, 41);
            this.sumIskonto.TabIndex = 1;
            this.sumIskonto.Text = "TUTAR : 0.00";
            this.sumIskonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sumKdv
            // 
            this.sumKdv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumKdv.Dock = System.Windows.Forms.DockStyle.Right;
            this.sumKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sumKdv.Location = new System.Drawing.Point(376, 0);
            this.sumKdv.Name = "sumKdv";
            this.sumKdv.Size = new System.Drawing.Size(200, 41);
            this.sumKdv.TabIndex = 2;
            this.sumKdv.Text = "ÖDENEN : 0.00";
            this.sumKdv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sumGenelToplam
            // 
            this.sumGenelToplam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumGenelToplam.Dock = System.Windows.Forms.DockStyle.Right;
            this.sumGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sumGenelToplam.Location = new System.Drawing.Point(576, 0);
            this.sumGenelToplam.Name = "sumGenelToplam";
            this.sumGenelToplam.Size = new System.Drawing.Size(200, 41);
            this.sumGenelToplam.TabIndex = 3;
            this.sumGenelToplam.Text = "KALAN : 0.00";
            this.sumGenelToplam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ISLEM_RAPORU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ISLEM_RAPORU";
            this.Text = "İŞLEM RAPORU";
            this.Load += new System.EventHandler(this.ISLEM_RAPORU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sumIskonto;
        private System.Windows.Forms.Label sumKdv;
        private System.Windows.Forms.Label sumGenelToplam;
    }
}