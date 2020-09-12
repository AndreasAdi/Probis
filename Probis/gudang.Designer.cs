namespace Probis
{
    partial class gudang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gudang));
            this.dataGridView_stock = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Stock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_login = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_stock
            // 
            this.dataGridView_stock.AllowUserToAddRows = false;
            this.dataGridView_stock.AllowUserToDeleteRows = false;
            this.dataGridView_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_stock,
            this.Nama_stock,
            this.Stock,
            this.Status,
            this.Add_Stock});
            this.dataGridView_stock.Location = new System.Drawing.Point(0, 182);
            this.dataGridView_stock.Name = "dataGridView_stock";
            this.dataGridView_stock.ReadOnly = true;
            this.dataGridView_stock.RowHeadersWidth = 51;
            this.dataGridView_stock.RowTemplate.Height = 24;
            this.dataGridView_stock.Size = new System.Drawing.Size(1207, 379);
            this.dataGridView_stock.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-363, -11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1938, 96);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 52);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stock";
            // 
            // id_stock
            // 
            this.id_stock.HeaderText = "id";
            this.id_stock.MinimumWidth = 6;
            this.id_stock.Name = "id_stock";
            this.id_stock.ReadOnly = true;
            // 
            // Nama_stock
            // 
            this.Nama_stock.HeaderText = "Name";
            this.Nama_stock.MinimumWidth = 6;
            this.Nama_stock.Name = "Nama_stock";
            this.Nama_stock.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Add_Stock
            // 
            this.Add_Stock.HeaderText = "Add Stock";
            this.Add_Stock.MinimumWidth = 6;
            this.Add_Stock.Name = "Add_Stock";
            this.Add_Stock.ReadOnly = true;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            this.button_login.BorderColor = System.Drawing.Color.Transparent;
            this.button_login.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Transparent;
            this.button_login.Location = new System.Drawing.Point(991, 107);
            this.button_login.Name = "button_login";
            this.button_login.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_login.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.button_login.OnHoverTextColor = System.Drawing.Color.White;
            this.button_login.Size = new System.Drawing.Size(191, 52);
            this.button_login.TabIndex = 13;
            this.button_login.Text = "+ Add New Item";
            this.button_login.TextColor = System.Drawing.Color.White;
            this.button_login.UseVisualStyleBackColor = false;
            // 
            // gudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dataGridView_stock);
            this.Name = "gudang";
            this.Text = "gudang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_stock;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ePOSOne.btnProduct.Button_WOC button_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Add_Stock;
    }
}