namespace WindowsFormsApp1.mainview
{
    partial class Editdata
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.addsBtn = new System.Windows.Forms.Button();
            this.confirmAdd = new System.Windows.Forms.Button();
            this.delectBtn = new System.Windows.Forms.Button();
            this.detailsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.White;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.updateBtn.Location = new System.Drawing.Point(1085, 109);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(87, 34);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addsBtn
            // 
            this.addsBtn.BackColor = System.Drawing.Color.White;
            this.addsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addsBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addsBtn.Location = new System.Drawing.Point(1085, 51);
            this.addsBtn.Name = "addsBtn";
            this.addsBtn.Size = new System.Drawing.Size(87, 34);
            this.addsBtn.TabIndex = 2;
            this.addsBtn.Text = "add";
            this.addsBtn.UseVisualStyleBackColor = false;
            this.addsBtn.Click += new System.EventHandler(this.addsBtn_Click);
            // 
            // confirmAdd
            // 
            this.confirmAdd.BackColor = System.Drawing.Color.White;
            this.confirmAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmAdd.Location = new System.Drawing.Point(1085, 165);
            this.confirmAdd.Name = "confirmAdd";
            this.confirmAdd.Size = new System.Drawing.Size(87, 55);
            this.confirmAdd.TabIndex = 3;
            this.confirmAdd.Text = "add to  forever";
            this.confirmAdd.UseVisualStyleBackColor = false;
            this.confirmAdd.Click += new System.EventHandler(this.confirmAdd_Click);
            // 
            // delectBtn
            // 
            this.delectBtn.BackColor = System.Drawing.Color.White;
            this.delectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delectBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delectBtn.Location = new System.Drawing.Point(1085, 238);
            this.delectBtn.Name = "delectBtn";
            this.delectBtn.Size = new System.Drawing.Size(87, 34);
            this.delectBtn.TabIndex = 4;
            this.delectBtn.Text = "delete";
            this.delectBtn.UseVisualStyleBackColor = false;
            this.delectBtn.Click += new System.EventHandler(this.delectBtn_Click);
            // 
            // detailsBtn
            // 
            this.detailsBtn.BackColor = System.Drawing.Color.White;
            this.detailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detailsBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detailsBtn.Location = new System.Drawing.Point(1085, 287);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(87, 70);
            this.detailsBtn.TabIndex = 5;
            this.detailsBtn.Text = "detailed information";
            this.detailsBtn.UseVisualStyleBackColor = false;
            this.detailsBtn.Visible = false;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // Editdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1184, 509);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.delectBtn);
            this.Controls.Add(this.confirmAdd);
            this.Controls.Add(this.addsBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Editdata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑数据";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addsBtn;
        private System.Windows.Forms.Button confirmAdd;
        private System.Windows.Forms.Button delectBtn;
        private System.Windows.Forms.Button detailsBtn;
    }
}