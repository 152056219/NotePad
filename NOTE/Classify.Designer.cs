﻿namespace NOTE
{
    partial class Classify
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noteDataSet = new NOTE.NoteDataSet();
            this.noteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteDataSet2 = new NOTE.NoteDataSet2();
            this.noteDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersInfoTableAdapter = new NOTE.NoteDataSet2TableAdapters.UsersInfoTableAdapter();
            this.noteInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteInfoTableAdapter = new NOTE.NoteDataSet2TableAdapters.NoteInfoTableAdapter();
            this.classifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::NOTE.Properties.Resources.Classify;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 415);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classifyDataGridViewTextBoxColumn,
            this.Title});
            this.dataGridView1.DataSource = this.noteInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(242, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // noteDataSet
            // 
            this.noteDataSet.DataSetName = "NoteDataSet";
            this.noteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteDataSetBindingSource
            // 
            this.noteDataSetBindingSource.DataSource = this.noteDataSet;
            this.noteDataSetBindingSource.Position = 0;
            // 
            // noteDataSet2
            // 
            this.noteDataSet2.DataSetName = "NoteDataSet2";
            this.noteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteDataSet2BindingSource
            // 
            this.noteDataSet2BindingSource.DataSource = this.noteDataSet2;
            this.noteDataSet2BindingSource.Position = 0;
            // 
            // usersInfoBindingSource
            // 
            this.usersInfoBindingSource.DataMember = "UsersInfo";
            this.usersInfoBindingSource.DataSource = this.noteDataSet2BindingSource;
            // 
            // usersInfoTableAdapter
            // 
            this.usersInfoTableAdapter.ClearBeforeFill = true;
            // 
            // noteInfoBindingSource
            // 
            this.noteInfoBindingSource.DataMember = "NoteInfo";
            this.noteInfoBindingSource.DataSource = this.noteDataSet2BindingSource;
            // 
            // noteInfoTableAdapter
            // 
            this.noteInfoTableAdapter.ClearBeforeFill = true;
            // 
            // classifyDataGridViewTextBoxColumn
            // 
            this.classifyDataGridViewTextBoxColumn.DataPropertyName = "Classify";
            this.classifyDataGridViewTextBoxColumn.HeaderText = "Classify";
            this.classifyDataGridViewTextBoxColumn.Name = "classifyDataGridViewTextBoxColumn";
            this.classifyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("钟齐翰墨毛笔", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(390, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "分类管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("钟齐翰墨毛笔", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(328, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入分类：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("钟齐翰墨毛笔", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(328, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "请输入标题：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 37);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(398, 258);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 37);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "刷新";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Classify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 411);
            this.Controls.Add(this.panel1);
            this.Name = "Classify";
            this.Text = "分类管理";
            this.Load += new System.EventHandler(this.Classify_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource noteDataSet2BindingSource;
        private NoteDataSet2 noteDataSet2;
        private NoteDataSet noteDataSet;
        private System.Windows.Forms.BindingSource noteDataSetBindingSource;
        private System.Windows.Forms.BindingSource usersInfoBindingSource;
        private NoteDataSet2TableAdapters.UsersInfoTableAdapter usersInfoTableAdapter;
        private System.Windows.Forms.BindingSource noteInfoBindingSource;
        private NoteDataSet2TableAdapters.NoteInfoTableAdapter noteInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}