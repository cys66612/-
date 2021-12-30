
namespace 数据库大作业图书管理系统
{
    partial class user_select
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.admin_selectbook_id = new System.Windows.Forms.TextBox();
            this.admin_selectbook_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_admin_selectbook1 = new System.Windows.Forms.Label();
            this.label_admin_selectbook2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_booktype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(631, 519);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "书名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 126;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "作者";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出版社";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 126;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "借出数量";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "入库数量";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "图书类型";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "图书单价";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "图书状态";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 513);
            this.panel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(886, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 65);
            this.button5.TabIndex = 7;
            this.button5.Text = "书号查询";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(886, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 65);
            this.button6.TabIndex = 8;
            this.button6.Text = "书名查询";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // admin_selectbook_id
            // 
            this.admin_selectbook_id.Font = new System.Drawing.Font("宋体", 13F);
            this.admin_selectbook_id.Location = new System.Drawing.Point(658, 31);
            this.admin_selectbook_id.Name = "admin_selectbook_id";
            this.admin_selectbook_id.Size = new System.Drawing.Size(186, 32);
            this.admin_selectbook_id.TabIndex = 9;
            // 
            // admin_selectbook_name
            // 
            this.admin_selectbook_name.Font = new System.Drawing.Font("宋体", 13F);
            this.admin_selectbook_name.Location = new System.Drawing.Point(658, 147);
            this.admin_selectbook_name.Name = "admin_selectbook_name";
            this.admin_selectbook_name.Size = new System.Drawing.Size(186, 32);
            this.admin_selectbook_name.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(867, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "我要租借";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_admin_selectbook1
            // 
            this.label_admin_selectbook1.AutoSize = true;
            this.label_admin_selectbook1.Location = new System.Drawing.Point(676, 374);
            this.label_admin_selectbook1.Name = "label_admin_selectbook1";
            this.label_admin_selectbook1.Size = new System.Drawing.Size(142, 15);
            this.label_admin_selectbook1.TabIndex = 12;
            this.label_admin_selectbook1.Text = "当前选择的图书是：";
            // 
            // label_admin_selectbook2
            // 
            this.label_admin_selectbook2.AutoSize = true;
            this.label_admin_selectbook2.Location = new System.Drawing.Point(864, 374);
            this.label_admin_selectbook2.Name = "label_admin_selectbook2";
            this.label_admin_selectbook2.Size = new System.Drawing.Size(39, 15);
            this.label_admin_selectbook2.TabIndex = 13;
            this.label_admin_selectbook2.Text = "NULL";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(669, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 69);
            this.button2.TabIndex = 14;
            this.button2.Text = "展示全部图书";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(886, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 71);
            this.button3.TabIndex = 15;
            this.button3.Text = "类型查找";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox_booktype
            // 
            this.comboBox_booktype.FormattingEnabled = true;
            this.comboBox_booktype.Location = new System.Drawing.Point(658, 263);
            this.comboBox_booktype.Name = "comboBox_booktype";
            this.comboBox_booktype.Size = new System.Drawing.Size(186, 23);
            this.comboBox_booktype.TabIndex = 16;
            // 
            // user_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 531);
            this.Controls.Add(this.comboBox_booktype);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_admin_selectbook2);
            this.Controls.Add(this.label_admin_selectbook1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.admin_selectbook_name);
            this.Controls.Add(this.admin_selectbook_id);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "user_select";
            this.Text = "图书查看和借阅";
            this.Load += new System.EventHandler(this.user_select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox admin_selectbook_id;
        private System.Windows.Forms.TextBox admin_selectbook_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_admin_selectbook1;
        private System.Windows.Forms.Label label_admin_selectbook2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ComboBox comboBox_booktype;
    }
}