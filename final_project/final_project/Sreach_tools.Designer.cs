namespace _329_final_project
{
    partial class Sreach_tools
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
            this.button1 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wINETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wINEKINDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new _329_final_project.DataSet1();
            this.Sreach = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.wINETableAdapter = new _329_final_project.DataSet1TableAdapters.WINETableAdapter();
            this.dataSet2 = new _329_final_project.DataSet2();
            this.wINEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wINETableAdapter1 = new _329_final_project.DataSet2TableAdapters.WINETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboKind = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.Sreach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wINEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sreach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.Controls.Add(this.dataGridView1);
            this.Result.Location = new System.Drawing.Point(13, 82);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(569, 441);
            this.Result.TabIndex = 3;
            this.Result.TabStop = false;
            this.Result.Text = "Result";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wIDDataGridViewTextBoxColumn,
            this.bIDDataGridViewTextBoxColumn,
            this.wNAMEDataGridViewTextBoxColumn,
            this.wINETYPEDataGridViewTextBoxColumn,
            this.wINEKINDSDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.yEARSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wINEBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 402);
            this.dataGridView1.TabIndex = 3;
            // 
            // wIDDataGridViewTextBoxColumn
            // 
            this.wIDDataGridViewTextBoxColumn.DataPropertyName = "WID";
            this.wIDDataGridViewTextBoxColumn.HeaderText = "WID";
            this.wIDDataGridViewTextBoxColumn.Name = "wIDDataGridViewTextBoxColumn";
            this.wIDDataGridViewTextBoxColumn.Visible = false;
            this.wIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "BID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "BID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // wNAMEDataGridViewTextBoxColumn
            // 
            this.wNAMEDataGridViewTextBoxColumn.DataPropertyName = "WNAME";
            this.wNAMEDataGridViewTextBoxColumn.HeaderText = "WNAME";
            this.wNAMEDataGridViewTextBoxColumn.Name = "wNAMEDataGridViewTextBoxColumn";
            // 
            // wINETYPEDataGridViewTextBoxColumn
            // 
            this.wINETYPEDataGridViewTextBoxColumn.DataPropertyName = "WINE_TYPE";
            this.wINETYPEDataGridViewTextBoxColumn.HeaderText = "WINE_TYPE";
            this.wINETYPEDataGridViewTextBoxColumn.Name = "wINETYPEDataGridViewTextBoxColumn";
            // 
            // wINEKINDSDataGridViewTextBoxColumn
            // 
            this.wINEKINDSDataGridViewTextBoxColumn.DataPropertyName = "WINE_KINDS";
            this.wINEKINDSDataGridViewTextBoxColumn.HeaderText = "WINE_KINDS";
            this.wINEKINDSDataGridViewTextBoxColumn.Name = "wINEKINDSDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // yEARSDataGridViewTextBoxColumn
            // 
            this.yEARSDataGridViewTextBoxColumn.DataPropertyName = "YEARS";
            this.yEARSDataGridViewTextBoxColumn.HeaderText = "YEARS";
            this.yEARSDataGridViewTextBoxColumn.Name = "yEARSDataGridViewTextBoxColumn";
            // 
            // wINEBindingSource
            // 
            this.wINEBindingSource.DataMember = "WINE";
            this.wINEBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sreach
            // 
            this.Sreach.Controls.Add(this.textBoxYear);
            this.Sreach.Controls.Add(this.textBoxPrice);
            this.Sreach.Controls.Add(this.comboKind);
            this.Sreach.Controls.Add(this.comboType);
            this.Sreach.Controls.Add(this.label5);
            this.Sreach.Controls.Add(this.label4);
            this.Sreach.Controls.Add(this.label3);
            this.Sreach.Controls.Add(this.label2);
            this.Sreach.Controls.Add(this.label1);
            this.Sreach.Controls.Add(this.textBoxName);
            this.Sreach.Controls.Add(this.button1);
            this.Sreach.Location = new System.Drawing.Point(13, 12);
            this.Sreach.Name = "Sreach";
            this.Sreach.Size = new System.Drawing.Size(569, 68);
            this.Sreach.TabIndex = 4;
            this.Sreach.TabStop = false;
            this.Sreach.Text = "Sreach";
            this.Sreach.Enter += new System.EventHandler(this.Sreach_Enter);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxName.Location = new System.Drawing.Point(73, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(64, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Text = "ALL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 529);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // wINETableAdapter
            // 
            this.wINETableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wINEBindingSource1
            // 
            this.wINEBindingSource1.DataMember = "WINE";
            this.wINEBindingSource1.DataSource = this.dataSet2;
            // 
            // wINETableAdapter1
            // 
            this.wINETableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Years:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wine Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kind:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price:";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(169, 29);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(45, 21);
            this.comboType.TabIndex = 12;
            this.comboType.Text = "ALL";
            // 
            // comboKind
            // 
            this.comboKind.FormattingEnabled = true;
            this.comboKind.Location = new System.Drawing.Point(257, 29);
            this.comboKind.Name = "comboKind";
            this.comboKind.Size = new System.Drawing.Size(45, 21);
            this.comboKind.TabIndex = 13;
            this.comboKind.Text = "ALL";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxPrice.Location = new System.Drawing.Point(349, 29);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(48, 20);
            this.textBoxPrice.TabIndex = 16;
            this.textBoxPrice.Text = "ALL";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxYear.Location = new System.Drawing.Point(446, 29);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(48, 20);
            this.textBoxYear.TabIndex = 17;
            this.textBoxYear.Text = "ALL";
            // 
            // Sreach_tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 584);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sreach);
            this.Controls.Add(this.Result);
            this.Name = "Sreach_tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sreach_tools(Example)";
            this.Load += new System.EventHandler(this.Sreach_tools_Load);
            this.Result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.Sreach.ResumeLayout(false);
            this.Sreach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wINEBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.GroupBox Sreach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource wINEBindingSource;
        private DataSet1TableAdapters.WINETableAdapter wINETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wINETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wINEKINDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARSDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxName;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource wINEBindingSource1;
        private DataSet2TableAdapters.WINETableAdapter wINETableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboKind;
        private System.Windows.Forms.ComboBox comboType;
    }
}