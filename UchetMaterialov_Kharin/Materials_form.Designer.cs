namespace UchetMaterialov_Kharin
{
    partial class Materials_form
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
            this.Material_dataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Material_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Material_dataGrid
            // 
            this.Material_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Material_dataGrid.Location = new System.Drawing.Point(12, 185);
            this.Material_dataGrid.Name = "Material_dataGrid";
            this.Material_dataGrid.RowTemplate.Height = 25;
            this.Material_dataGrid.Size = new System.Drawing.Size(776, 253);
            this.Material_dataGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Materials_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Material_dataGrid);
            this.Name = "Materials_form";
            this.Text = "Materials";
            this.Load += new System.EventHandler(this.Materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Material_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Material_dataGrid;
        private Button button1;
    }
}