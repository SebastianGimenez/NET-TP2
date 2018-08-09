namespace UI.Desktop
{
    partial class frm_BaseABM
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
            this.grd_view = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_modi = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_view)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_view
            // 
            this.grd_view.AllowUserToAddRows = false;
            this.grd_view.AllowUserToDeleteRows = false;
            this.grd_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_view.Location = new System.Drawing.Point(2, 12);
            this.grd_view.Name = "grd_view";
            this.grd_view.ReadOnly = true;
            this.grd_view.Size = new System.Drawing.Size(524, 254);
            this.grd_view.TabIndex = 0;
            // 
            // btn_volver
            // 
            this.btn_volver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_volver.Location = new System.Drawing.Point(0, 384);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(527, 40);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_modi
            // 
            this.btn_modi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_modi.Location = new System.Drawing.Point(0, 344);
            this.btn_modi.Name = "btn_modi";
            this.btn_modi.Size = new System.Drawing.Size(527, 40);
            this.btn_modi.TabIndex = 3;
            this.btn_modi.Text = "MODIFICACION";
            this.btn_modi.UseVisualStyleBackColor = true;
            // 
            // btn_baja
            // 
            this.btn_baja.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_baja.Location = new System.Drawing.Point(0, 304);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(527, 40);
            this.btn_baja.TabIndex = 2;
            this.btn_baja.Text = "BAJA";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_alta.Location = new System.Drawing.Point(0, 264);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(527, 40);
            this.btn_alta.TabIndex = 1;
            this.btn_alta.Text = "ALTA";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // frm_BaseABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 424);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_modi);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.grd_view);
            this.Name = "frm_BaseABM";
            this.ShowIcon = false;
            this.Text = "frm_BaseABM";
            ((System.ComponentModel.ISupportInitialize)(this.grd_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_modi;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_alta;
        protected System.Windows.Forms.DataGridView grd_view;
    }
}