namespace UchetMaterialov_Kharin
{
    partial class User_form
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
            this.Products_btn = new System.Windows.Forms.Button();
            this.Materials_btn = new System.Windows.Forms.Button();
            this.Inventory_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Products_btn
            // 
            this.Products_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Products_btn.Location = new System.Drawing.Point(130, 144);
            this.Products_btn.Name = "Products_btn";
            this.Products_btn.Size = new System.Drawing.Size(126, 52);
            this.Products_btn.TabIndex = 0;
            this.Products_btn.Text = "Продукция фирмы";
            this.Products_btn.UseVisualStyleBackColor = true;
            // 
            // Materials_btn
            // 
            this.Materials_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Materials_btn.Location = new System.Drawing.Point(130, 61);
            this.Materials_btn.Name = "Materials_btn";
            this.Materials_btn.Size = new System.Drawing.Size(126, 52);
            this.Materials_btn.TabIndex = 0;
            this.Materials_btn.Text = "Материалы";
            this.Materials_btn.UseVisualStyleBackColor = true;
            this.Materials_btn.Click += new System.EventHandler(this.Materials_btn_Click);
            // 
            // Inventory_btn
            // 
            this.Inventory_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Inventory_btn.Location = new System.Drawing.Point(130, 230);
            this.Inventory_btn.Name = "Inventory_btn";
            this.Inventory_btn.Size = new System.Drawing.Size(126, 52);
            this.Inventory_btn.TabIndex = 0;
            this.Inventory_btn.Text = "Инвентарь";
            this.Inventory_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Materials_btn);
            this.Controls.Add(this.Inventory_btn);
            this.Controls.Add(this.Products_btn);
            this.Name = "User_form";
            this.Text = "Учет материалов";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Products_btn;
        private Button Materials_btn;
        private Button Inventory_btn;
        private Button button1;
    }
}