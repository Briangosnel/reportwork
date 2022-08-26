

namespace BiblioBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbReader = new System.Windows.Forms.GroupBox();
            this.txtKol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rdbStatus3 = new System.Windows.Forms.RadioButton();
            this.rdbStatus2 = new System.Windows.Forms.RadioButton();
            this.rdbStatus1 = new System.Windows.Forms.RadioButton();
            this.cmbReader = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVisibleInform = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInform = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbInform = new System.Windows.Forms.GroupBox();
            this.lstInform = new System.Windows.Forms.ListBox();
            this.grbReader.SuspendLayout();
            this.grbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.grbInform.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbReader
            // 
            this.grbReader.Controls.Add(this.txtKol);
            this.grbReader.Controls.Add(this.label3);
            this.grbReader.Controls.Add(this.label2);
            this.grbReader.Controls.Add(this.lstBooks);
            this.grbReader.Controls.Add(this.grbStatus);
            this.grbReader.Controls.Add(this.cmbReader);
            this.grbReader.Controls.Add(this.label1);
            this.grbReader.Location = new System.Drawing.Point(30, 65);
            this.grbReader.Name = "grbReader";
            this.grbReader.Size = new System.Drawing.Size(373, 316);
            this.grbReader.TabIndex = 0;
            this.grbReader.TabStop = false;
            this.grbReader.Text = "Карточка читателя";
            // 
            // txtKol
            // 
            this.txtKol.Location = new System.Drawing.Point(171, 235);
            this.txtKol.Name = "txtKol";
            this.txtKol.Size = new System.Drawing.Size(129, 23);
            this.txtKol.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество дней";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(180, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список книг фондов";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 15;
            this.lstBooks.Location = new System.Drawing.Point(180, 103);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(187, 94);
            this.lstBooks.TabIndex = 3;
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rdbStatus3);
            this.grbStatus.Controls.Add(this.rdbStatus2);
            this.grbStatus.Controls.Add(this.rdbStatus1);
            this.grbStatus.Location = new System.Drawing.Point(24, 78);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(132, 119);
            this.grbStatus.TabIndex = 2;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Статус";
            // 
            // rdbStatus3
            // 
            this.rdbStatus3.AutoSize = true;
            this.rdbStatus3.Location = new System.Drawing.Point(16, 86);
            this.rdbStatus3.Name = "rdbStatus3";
            this.rdbStatus3.Size = new System.Drawing.Size(77, 19);
            this.rdbStatus3.TabIndex = 2;
            this.rdbStatus3.Text = "Работник";
            this.rdbStatus3.UseVisualStyleBackColor = true;
            // 
            // rdbStatus2
            // 
            this.rdbStatus2.AutoSize = true;
            this.rdbStatus2.Location = new System.Drawing.Point(16, 61);
            this.rdbStatus2.Name = "rdbStatus2";
            this.rdbStatus2.Size = new System.Drawing.Size(68, 19);
            this.rdbStatus2.TabIndex = 1;
            this.rdbStatus2.Text = "Студент";
            this.rdbStatus2.UseVisualStyleBackColor = true;
            // 
            // rdbStatus1
            // 
            this.rdbStatus1.AutoSize = true;
            this.rdbStatus1.Checked = true;
            this.rdbStatus1.Location = new System.Drawing.Point(16, 36);
            this.rdbStatus1.Name = "rdbStatus1";
            this.rdbStatus1.Size = new System.Drawing.Size(82, 19);
            this.rdbStatus1.TabIndex = 0;
            this.rdbStatus1.TabStop = true;
            this.rdbStatus1.Text = "Школьник";
            this.rdbStatus1.UseVisualStyleBackColor = true;
            // 
            // cmbReader
            // 
            this.cmbReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReader.FormattingEnabled = true;
            this.cmbReader.Location = new System.Drawing.Point(107, 36);
            this.cmbReader.Name = "cmbReader";
            this.cmbReader.Size = new System.Drawing.Size(121, 23);
            this.cmbReader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Читатель";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(BiblioBook.Form1);
            // 
            // btnVisibleInform
            // 
            this.btnVisibleInform.Enabled = false;
            this.btnVisibleInform.Location = new System.Drawing.Point(419, 185);
            this.btnVisibleInform.Name = "btnVisibleInform";
            this.btnVisibleInform.Size = new System.Drawing.Size(110, 23);
            this.btnVisibleInform.TabIndex = 5;
            this.btnVisibleInform.Text = "Скрыть информацию";
            this.btnVisibleInform.UseVisualStyleBackColor = true;
            this.btnVisibleInform.Click += new System.EventHandler(this.btnVisibleInform_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(454, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInform
            // 
            this.btnInform.Location = new System.Drawing.Point(419, 98);
            this.btnInform.Name = "btnInform";
            this.btnInform.Size = new System.Drawing.Size(110, 23);
            this.btnInform.TabIndex = 2;
            this.btnInform.Text = "Получить";
            this.btnInform.UseVisualStyleBackColor = true;
            this.btnInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(419, 127);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Удалить строку";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(419, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grbInform
            // 
            this.grbInform.Controls.Add(this.lstInform);
            this.grbInform.Location = new System.Drawing.Point(30, 406);
            this.grbInform.Name = "grbInform";
            this.grbInform.Size = new System.Drawing.Size(426, 193);
            this.grbInform.TabIndex = 6;
            this.grbInform.TabStop = false;
            this.grbInform.Text = "Информация";
            // 
            // lstInform
            // 
            this.lstInform.FormattingEnabled = true;
            this.lstInform.ItemHeight = 15;
            this.lstInform.Location = new System.Drawing.Point(8, 19);
            this.lstInform.Name = "lstInform";
            this.lstInform.Size = new System.Drawing.Size(418, 169);
            this.lstInform.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 634);
            this.Controls.Add(this.grbInform);
            this.Controls.Add(this.btnVisibleInform);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInform);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbReader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача литературы на дом";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbReader.ResumeLayout(false);
            this.grbReader.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.grbInform.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbReader;
        private TextBox txtKol;
        private Label label3;
        private Label label2;
        private ListBox lstBooks;
        private GroupBox grbStatus;
        private RadioButton rdbStatus3;
        private RadioButton rdbStatus2;
        private RadioButton rdbStatus1;
        private ComboBox cmbReader;
        private Label label1;
        private Button btnExit;
        private Button btnInform;
        private Button btnRemove;
        private Button btnClear;
        private Button btnVisibleInform;
        private GroupBox grbInform;
        private ListBox lstInform;
        private BindingSource form1BindingSource;
    }
}