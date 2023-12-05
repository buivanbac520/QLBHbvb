namespace quanlybanhang
{
    partial class Formloaihang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtth = new System.Windows.Forms.TextBox();
            this.txtmh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maLoaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet2 = new quanlybanhang.QLBHDataSet2();
            this.lOAIHANGTableAdapter = new quanlybanhang.QLBHDataSet2TableAdapters.LOAIHANGTableAdapter();
            this.btnboqua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.btnboqua);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtth);
            this.groupBox1.Controls.Add(this.txtmh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(53, 265);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 37);
            this.btnluu.TabIndex = 7;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(213, 196);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 37);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(115, 196);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 37);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(13, 196);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 37);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtth
            // 
            this.txtth.Enabled = false;
            this.txtth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtth.Location = new System.Drawing.Point(149, 136);
            this.txtth.Name = "txtth";
            this.txtth.Size = new System.Drawing.Size(159, 29);
            this.txtth.TabIndex = 4;
            // 
            // txtmh
            // 
            this.txtmh.Enabled = false;
            this.txtmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmh.Location = new System.Drawing.Point(149, 47);
            this.txtmh.Name = "txtmh";
            this.txtmh.Size = new System.Drawing.Size(159, 29);
            this.txtmh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Loại Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Loại Hàng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiHangDataGridViewTextBoxColumn,
            this.tenLoaiHangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lOAIHANGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(323, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 308);
            this.dataGridView1.TabIndex = 2;
            // 
            // maLoaiHangDataGridViewTextBoxColumn
            // 
            this.maLoaiHangDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiHang";
            this.maLoaiHangDataGridViewTextBoxColumn.HeaderText = "MaLoaiHang";
            this.maLoaiHangDataGridViewTextBoxColumn.Name = "maLoaiHangDataGridViewTextBoxColumn";
            // 
            // tenLoaiHangDataGridViewTextBoxColumn
            // 
            this.tenLoaiHangDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiHang";
            this.tenLoaiHangDataGridViewTextBoxColumn.HeaderText = "TenLoaiHang";
            this.tenLoaiHangDataGridViewTextBoxColumn.Name = "tenLoaiHangDataGridViewTextBoxColumn";
            // 
            // lOAIHANGBindingSource
            // 
            this.lOAIHANGBindingSource.DataMember = "LOAIHANG";
            this.lOAIHANGBindingSource.DataSource = this.qLBHDataSet2;
            // 
            // qLBHDataSet2
            // 
            this.qLBHDataSet2.DataSetName = "QLBHDataSet2";
            this.qLBHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIHANGTableAdapter
            // 
            this.lOAIHANGTableAdapter.ClearBeforeFill = true;
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnboqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.Location = new System.Drawing.Point(149, 265);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(83, 37);
            this.btnboqua.TabIndex = 8;
            this.btnboqua.Text = "Bỏ Qua";
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // Formloaihang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Formloaihang";
            this.Text = "Formtheloai";
            this.Load += new System.EventHandler(this.Formloaihang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtth;
        private System.Windows.Forms.TextBox txtmh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLBHDataSet2 qLBHDataSet2;
        private System.Windows.Forms.BindingSource lOAIHANGBindingSource;
        private QLBHDataSet2TableAdapters.LOAIHANGTableAdapter lOAIHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
    }
}