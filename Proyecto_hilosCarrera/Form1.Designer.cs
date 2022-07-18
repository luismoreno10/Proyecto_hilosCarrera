namespace Proyecto_hilosCarrera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_carretera = new System.Windows.Forms.Panel();
            this.btn_Start = new System.Windows.Forms.Button();
            this.box_meta = new System.Windows.Forms.PictureBox();
            this.box_auto2 = new System.Windows.Forms.PictureBox();
            this.box_auto1 = new System.Windows.Forms.PictureBox();
            this.pnl_carretera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_meta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_auto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_auto1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_carretera
            // 
            this.pnl_carretera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_carretera.BackgroundImage")));
            this.pnl_carretera.Controls.Add(this.btn_Start);
            this.pnl_carretera.Controls.Add(this.box_meta);
            this.pnl_carretera.Controls.Add(this.box_auto2);
            this.pnl_carretera.Controls.Add(this.box_auto1);
            this.pnl_carretera.Location = new System.Drawing.Point(1, 245);
            this.pnl_carretera.Name = "pnl_carretera";
            this.pnl_carretera.Size = new System.Drawing.Size(798, 241);
            this.pnl_carretera.TabIndex = 3;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(359, 13);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start!";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // box_meta
            // 
            this.box_meta.BackColor = System.Drawing.Color.Transparent;
            this.box_meta.Image = ((System.Drawing.Image)(resources.GetObject("box_meta.Image")));
            this.box_meta.Location = new System.Drawing.Point(785, 50);
            this.box_meta.Name = "box_meta";
            this.box_meta.Size = new System.Drawing.Size(10, 159);
            this.box_meta.TabIndex = 2;
            this.box_meta.TabStop = false;
            // 
            // box_auto2
            // 
            this.box_auto2.BackColor = System.Drawing.Color.Transparent;
            this.box_auto2.Image = ((System.Drawing.Image)(resources.GetObject("box_auto2.Image")));
            this.box_auto2.Location = new System.Drawing.Point(3, 130);
            this.box_auto2.Name = "box_auto2";
            this.box_auto2.Size = new System.Drawing.Size(75, 74);
            this.box_auto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_auto2.TabIndex = 1;
            this.box_auto2.TabStop = false;
            this.box_auto2.Click += new System.EventHandler(this.Box_auto2_Click);
            // 
            // box_auto1
            // 
            this.box_auto1.BackColor = System.Drawing.Color.Transparent;
            this.box_auto1.Image = ((System.Drawing.Image)(resources.GetObject("box_auto1.Image")));
            this.box_auto1.Location = new System.Drawing.Point(3, 65);
            this.box_auto1.Name = "box_auto1";
            this.box_auto1.Size = new System.Drawing.Size(75, 45);
            this.box_auto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_auto1.TabIndex = 0;
            this.box_auto1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.pnl_carretera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Need for Speed ";
            this.pnl_carretera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_meta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_auto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_auto1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_carretera;
        private System.Windows.Forms.PictureBox box_auto1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.PictureBox box_meta;
        private System.Windows.Forms.PictureBox box_auto2;
    }
}

