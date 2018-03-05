namespace teknikServisPro
{
    partial class SERVIS_FISLERI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SERVIS_FISLERI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sumIskonto = new System.Windows.Forms.Label();
            this.sumKdv = new System.Windows.Forms.Label();
            this.sumGenelToplam = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.sumRecord = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fİŞEGİTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.iÇERİĞİSÜZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.date2);
            this.splitContainer1.Panel1.Controls.Add(this.date1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(782, 434);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dataGridView1.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnList;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(782, 368);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Tag = "CariGrid1";
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.sumRecord);
            this.panel2.Controls.Add(this.sumIskonto);
            this.panel2.Controls.Add(this.sumKdv);
            this.panel2.Controls.Add(this.sumGenelToplam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 41);
            this.panel2.TabIndex = 15;
            // 
            // sumIskonto
            // 
            this.sumIskonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumIskonto.Dock = System.Windows.Forms.DockStyle.Right;
            this.sumIskonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sumIskonto.Location = new System.Drawing.Point(182, 0);
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
            this.sumKdv.Location = new System.Drawing.Point(382, 0);
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
            this.sumGenelToplam.Location = new System.Drawing.Point(582, 0);
            this.sumGenelToplam.Name = "sumGenelToplam";
            this.sumGenelToplam.Size = new System.Drawing.Size(200, 41);
            this.sumGenelToplam.TabIndex = 3;
            this.sumGenelToplam.Text = "KALAN : 0.00";
            this.sumGenelToplam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel1.Text = "FİLTRELE";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 25);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(397, 2);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(110, 20);
            this.date2.TabIndex = 17;
            this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(283, 2);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(110, 20);
            this.date1.TabIndex = 16;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // sumRecord
            // 
            this.sumRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumRecord.Dock = System.Windows.Forms.DockStyle.Right;
            this.sumRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sumRecord.Location = new System.Drawing.Point(-18, 0);
            this.sumRecord.Name = "sumRecord";
            this.sumRecord.Size = new System.Drawing.Size(200, 41);
            this.sumRecord.TabIndex = 4;
            this.sumRecord.Text = "KAYIT : ";
            this.sumRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fİŞEGİTToolStripMenuItem,
            this.toolStripSeparator1,
            this.iÇERİĞİSÜZToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 54);
            // 
            // fİŞEGİTToolStripMenuItem
            // 
            this.fİŞEGİTToolStripMenuItem.Name = "fİŞEGİTToolStripMenuItem";
            this.fİŞEGİTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fİŞEGİTToolStripMenuItem.Text = "FİŞE GİT";
            this.fİŞEGİTToolStripMenuItem.Click += new System.EventHandler(this.fİŞEGİTToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // iÇERİĞİSÜZToolStripMenuItem
            // 
            this.iÇERİĞİSÜZToolStripMenuItem.Name = "iÇERİĞİSÜZToolStripMenuItem";
            this.iÇERİĞİSÜZToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iÇERİĞİSÜZToolStripMenuItem.Text = "İÇERİĞİ SÜZ";
            this.iÇERİĞİSÜZToolStripMenuItem.Click += new System.EventHandler(this.iÇERİĞİSÜZToolStripMenuItem_Click);
            // 
            // SERVIS_FISLERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 434);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "SERVIS_FISLERI";
            this.Text = "SERVİS FİŞLERİ";
            this.Load += new System.EventHandler(this.SERVIS_FISLERI_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sumIskonto;
        private System.Windows.Forms.Label sumKdv;
        private System.Windows.Forms.Label sumGenelToplam;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label sumRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fİŞEGİTToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem iÇERİĞİSÜZToolStripMenuItem;
    }
}