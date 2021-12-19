namespace Shamsi_pour_CSharp_Project
{
    partial class Ditalis_Student
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
            this.DataGrid_Money = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGrid_Number = new System.Windows.Forms.DataGridView();
            this.Avg_lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Money
            // 
            this.DataGrid_Money.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Money.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrid_Money.Location = new System.Drawing.Point(12, 64);
            this.DataGrid_Money.Name = "DataGrid_Money";
            this.DataGrid_Money.ReadOnly = true;
            this.DataGrid_Money.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataGrid_Money.Size = new System.Drawing.Size(885, 173);
            this.DataGrid_Money.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "وضعیت مالی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "وضعیت نمره";
            // 
            // DataGrid_Number
            // 
            this.DataGrid_Number.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Number.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Number.Location = new System.Drawing.Point(12, 274);
            this.DataGrid_Number.Name = "DataGrid_Number";
            this.DataGrid_Number.ReadOnly = true;
            this.DataGrid_Number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataGrid_Number.Size = new System.Drawing.Size(885, 173);
            this.DataGrid_Number.TabIndex = 2;
            // 
            // Avg_lable
            // 
            this.Avg_lable.AutoSize = true;
            this.Avg_lable.Location = new System.Drawing.Point(424, 469);
            this.Avg_lable.Name = "Avg_lable";
            this.Avg_lable.Size = new System.Drawing.Size(63, 13);
            this.Avg_lable.TabIndex = 5;
            this.Avg_lable.Text = "وضعیت نمره";
            // 
            // Ditalis_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 491);
            this.Controls.Add(this.Avg_lable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGrid_Number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGrid_Money);
            this.Name = "Ditalis_Student";
            this.Load += new System.EventHandler(this.Ditalis_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGrid_Number;
        private System.Windows.Forms.Label Avg_lable;

    }
}