namespace SQLite
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
            this.addBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.foodTxtBox = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.randomTxtBox = new System.Windows.Forms.TextBox();
            this.foodGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idnccTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(49, 278);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 48);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(49, 357);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(156, 48);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Tải lại";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // foodTxtBox
            // 
            this.foodTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodTxtBox.Location = new System.Drawing.Point(49, 110);
            this.foodTxtBox.Multiline = true;
            this.foodTxtBox.Name = "foodTxtBox";
            this.foodTxtBox.Size = new System.Drawing.Size(324, 48);
            this.foodTxtBox.TabIndex = 3;
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(217, 278);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(156, 48);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Xóa";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // randomBtn
            // 
            this.randomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomBtn.Location = new System.Drawing.Point(217, 357);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(156, 48);
            this.randomBtn.TabIndex = 5;
            this.randomBtn.Text = "Random";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // randomTxtBox
            // 
            this.randomTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomTxtBox.Location = new System.Drawing.Point(49, 433);
            this.randomTxtBox.Multiline = true;
            this.randomTxtBox.Name = "randomTxtBox";
            this.randomTxtBox.Size = new System.Drawing.Size(324, 48);
            this.randomTxtBox.TabIndex = 6;
            // 
            // foodGridView
            // 
            this.foodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView.Location = new System.Drawing.Point(400, 110);
            this.foodGridView.Name = "foodGridView";
            this.foodGridView.RowHeadersWidth = 51;
            this.foodGridView.RowTemplate.Height = 24;
            this.foodGridView.Size = new System.Drawing.Size(356, 371);
            this.foodGridView.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Món ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thêm món ăn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hôm nay ăn gì?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thêm ID người cung cấp:";
            // 
            // idnccTxtBox
            // 
            this.idnccTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idnccTxtBox.Location = new System.Drawing.Point(49, 186);
            this.idnccTxtBox.Multiline = true;
            this.idnccTxtBox.Name = "idnccTxtBox";
            this.idnccTxtBox.Size = new System.Drawing.Size(324, 48);
            this.idnccTxtBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idnccTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodGridView);
            this.Controls.Add(this.randomTxtBox);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.foodTxtBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Hôm nay ăn gì?";
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox foodTxtBox;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.TextBox randomTxtBox;
        private System.Windows.Forms.DataGridView foodGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idnccTxtBox;
    }
}

