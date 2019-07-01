namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.numericEnd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonBase = new System.Windows.Forms.Button();
            this.dataBaseCoffeeDataSet = new WindowsFormsApplication4.DataBaseCoffeeDataSet();
            this.dataCoffeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataCoffeeTableAdapter = new WindowsFormsApplication4.DataBaseCoffeeDataSetTableAdapters.DataCoffeeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication4.DataBaseCoffeeDataSetTableAdapters.TableAdapterManager();
            this.checkBoxPrice = new System.Windows.Forms.CheckBox();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.checkBoxEvaluation = new System.Windows.Forms.CheckBox();
            this.checkBoxAdvice = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataCoffeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseCoffeeDataSet2 = new WindowsFormsApplication4.DataBaseCoffeeDataSet2();
            this.dataCoffeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataCoffeeTableAdapter2 = new WindowsFormsApplication4.DataBaseCoffeeDataSet2TableAdapters.DataCoffeeTableAdapter();
            this.tableAdapterManager2 = new WindowsFormsApplication4.DataBaseCoffeeDataSet2TableAdapters.TableAdapterManager();
            this.dataCoffeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseCoffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoffeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoffeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseCoffeeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoffeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoffeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(790, 220);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericStart
            // 
            this.numericStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericStart.Location = new System.Drawing.Point(3, 34);
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(205, 26);
            this.numericStart.TabIndex = 2;
            this.numericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericEnd
            // 
            this.numericEnd.Location = new System.Drawing.Point(3, 86);
            this.numericEnd.Name = "numericEnd";
            this.numericEnd.Size = new System.Drawing.Size(205, 26);
            this.numericEnd.TabIndex = 4;
            this.numericEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Page";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(3, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 61);
            this.button2.TabIndex = 6;
            this.button2.Text = "Abort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.buttonBase);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.numericStart);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericEnd);
            this.panel1.Location = new System.Drawing.Point(796, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 581);
            this.panel1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(4, 348);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 226);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Please,  select the criteria which you need and then press start:";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(149)))), ((int)(((byte)(185)))));
            this.panelLeft.Location = new System.Drawing.Point(3, 133);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 66);
            this.panelLeft.TabIndex = 8;
            // 
            // buttonBase
            // 
            this.buttonBase.FlatAppearance.BorderSize = 0;
            this.buttonBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBase.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBase.Location = new System.Drawing.Point(3, 272);
            this.buttonBase.Name = "buttonBase";
            this.buttonBase.Size = new System.Drawing.Size(205, 61);
            this.buttonBase.TabIndex = 7;
            this.buttonBase.Text = "Base Data";
            this.buttonBase.UseVisualStyleBackColor = true;
            this.buttonBase.Click += new System.EventHandler(this.buttonBase_Click);
            // 
            // dataBaseCoffeeDataSet
            // 
            this.dataBaseCoffeeDataSet.DataSetName = "DataBaseCoffeeDataSet";
            this.dataBaseCoffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataCoffeeBindingSource
            // 
            this.dataCoffeeBindingSource.DataMember = "DataCoffee";
            this.dataCoffeeBindingSource.DataSource = this.dataBaseCoffeeDataSet;
            // 
            // dataCoffeeTableAdapter
            // 
            this.dataCoffeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataCoffeeTableAdapter = this.dataCoffeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication4.DataBaseCoffeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // checkBoxPrice
            // 
            this.checkBoxPrice.AutoSize = true;
            this.checkBoxPrice.Checked = true;
            this.checkBoxPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrice.Location = new System.Drawing.Point(243, 300);
            this.checkBoxPrice.Name = "checkBoxPrice";
            this.checkBoxPrice.Size = new System.Drawing.Size(65, 24);
            this.checkBoxPrice.TabIndex = 9;
            this.checkBoxPrice.Text = "Price";
            this.checkBoxPrice.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Checked = true;
            this.checkBoxDiscount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDiscount.Location = new System.Drawing.Point(337, 300);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(91, 24);
            this.checkBoxDiscount.TabIndex = 10;
            this.checkBoxDiscount.Text = "Discount";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // checkBoxEvaluation
            // 
            this.checkBoxEvaluation.AutoSize = true;
            this.checkBoxEvaluation.Checked = true;
            this.checkBoxEvaluation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEvaluation.Location = new System.Drawing.Point(434, 300);
            this.checkBoxEvaluation.Name = "checkBoxEvaluation";
            this.checkBoxEvaluation.Size = new System.Drawing.Size(105, 24);
            this.checkBoxEvaluation.TabIndex = 11;
            this.checkBoxEvaluation.Text = "Evaluation";
            this.checkBoxEvaluation.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdvice
            // 
            this.checkBoxAdvice.AutoSize = true;
            this.checkBoxAdvice.Checked = true;
            this.checkBoxAdvice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdvice.Location = new System.Drawing.Point(544, 300);
            this.checkBoxAdvice.Name = "checkBoxAdvice";
            this.checkBoxAdvice.Size = new System.Drawing.Size(82, 24);
            this.checkBoxAdvice.TabIndex = 12;
            this.checkBoxAdvice.Text = "Advice";
            this.checkBoxAdvice.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(9, 250);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(787, 19);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Please,  select the criteria which you need and then press start:";
            // 
            // dataCoffeeBindingSource1
            // 
            this.dataCoffeeBindingSource1.DataMember = "DataCoffee";
            // 
            // dataBaseCoffeeDataSet2
            // 
            this.dataBaseCoffeeDataSet2.DataSetName = "DataBaseCoffeeDataSet2";
            this.dataBaseCoffeeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataCoffeeBindingSource2
            // 
            this.dataCoffeeBindingSource2.DataMember = "DataCoffee";
            this.dataCoffeeBindingSource2.DataSource = this.dataBaseCoffeeDataSet2;
            // 
            // dataCoffeeTableAdapter2
            // 
            this.dataCoffeeTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.DataCoffeeTableAdapter = this.dataCoffeeTableAdapter2;
            this.tableAdapterManager2.UpdateOrder = WindowsFormsApplication4.DataBaseCoffeeDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataCoffeeDataGridView
            // 
            this.dataCoffeeDataGridView.AutoGenerateColumns = false;
            this.dataCoffeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCoffeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataCoffeeDataGridView.DataSource = this.dataCoffeeBindingSource2;
            this.dataCoffeeDataGridView.Location = new System.Drawing.Point(0, 364);
            this.dataCoffeeDataGridView.Name = "dataCoffeeDataGridView";
            this.dataCoffeeDataGridView.Size = new System.Drawing.Size(790, 220);
            this.dataCoffeeDataGridView.TabIndex = 13;
            this.dataCoffeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCoffeeDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn9.HeaderText = "Price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn10.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CustomerEvaluation";
            this.dataGridViewTextBoxColumn11.HeaderText = "CustomerEvaluation";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ManufacturerAdvice";
            this.dataGridViewTextBoxColumn12.HeaderText = "ManufacturerAdvice";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1027, 610);
            this.Controls.Add(this.dataCoffeeDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxAdvice);
            this.Controls.Add(this.checkBoxEvaluation);
            this.Controls.Add(this.checkBoxDiscount);
            this.Controls.Add(this.checkBoxPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseCoffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoffeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoffeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseCoffeeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoffeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCoffeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.NumericUpDown numericEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBase;
        private System.Windows.Forms.Panel panelLeft;
        private DataBaseCoffeeDataSet dataBaseCoffeeDataSet;
        private System.Windows.Forms.BindingSource dataCoffeeBindingSource;
        private DataBaseCoffeeDataSetTableAdapters.DataCoffeeTableAdapter dataCoffeeTableAdapter;
        private DataBaseCoffeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBoxPrice;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.CheckBox checkBoxEvaluation;
        private System.Windows.Forms.CheckBox checkBoxAdvice;
        private System.Windows.Forms.TextBox textBox1;
        private DataBaseCoffeeDataSet1 dataBaseCoffeeDataSet1;
        private System.Windows.Forms.BindingSource dataCoffeeBindingSource1;
        private DataBaseCoffeeDataSet1TableAdapters.DataCoffeeTableAdapter dataCoffeeTableAdapter1;
        private DataBaseCoffeeDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataBaseCoffeeDataSet2 dataBaseCoffeeDataSet2;
        private System.Windows.Forms.BindingSource dataCoffeeBindingSource2;
        private DataBaseCoffeeDataSet2TableAdapters.DataCoffeeTableAdapter dataCoffeeTableAdapter2;
        private DataBaseCoffeeDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView dataCoffeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

