
namespace CursoCsharp.Ejercicios
{
    partial class Ejercicio6
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblejercicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lbloperacion = new System.Windows.Forms.Label();
            this.btncopiar = new System.Windows.Forms.Button();
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.panelnumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnporcent = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblejercicio
            // 
            this.lblejercicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblejercicio.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblejercicio.ForeColor = System.Drawing.Color.White;
            this.lblejercicio.Location = new System.Drawing.Point(0, 0);
            this.lblejercicio.Name = "lblejercicio";
            this.lblejercicio.Size = new System.Drawing.Size(297, 765);
            this.lblejercicio.TabIndex = 0;
            this.lblejercicio.Text = "Ejercicio 6";
            this.lblejercicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CursoCsharp.Properties.Resources.celular;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblnum1);
            this.panel1.Controls.Add(this.lbloperacion);
            this.panel1.Controls.Add(this.btncopiar);
            this.panel1.Controls.Add(this.txtpantalla);
            this.panel1.Controls.Add(this.panelnumerico);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(297, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 765);
            this.panel1.TabIndex = 1;
            // 
            // lblnum1
            // 
            this.lblnum1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.ForeColor = System.Drawing.Color.White;
            this.lblnum1.Location = new System.Drawing.Point(176, 153);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(267, 26);
            this.lblnum1.TabIndex = 4;
            this.lblnum1.Text = "0";
            this.lblnum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblnum1.Visible = false;
            // 
            // lbloperacion
            // 
            this.lbloperacion.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(9)))));
            this.lbloperacion.Location = new System.Drawing.Point(355, 191);
            this.lbloperacion.Name = "lbloperacion";
            this.lbloperacion.Size = new System.Drawing.Size(88, 26);
            this.lbloperacion.TabIndex = 4;
            this.lbloperacion.Text = "0";
            this.lbloperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbloperacion.Visible = false;
            // 
            // btncopiar
            // 
            this.btncopiar.BackgroundImage = global::CursoCsharp.Properties.Resources.copia;
            this.btncopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncopiar.FlatAppearance.BorderSize = 0;
            this.btncopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncopiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncopiar.ForeColor = System.Drawing.Color.White;
            this.btncopiar.Location = new System.Drawing.Point(176, 235);
            this.btncopiar.Name = "btncopiar";
            this.btncopiar.Size = new System.Drawing.Size(30, 32);
            this.btncopiar.TabIndex = 0;
            this.btncopiar.UseVisualStyleBackColor = true;
            this.btncopiar.Click += new System.EventHandler(this.btncopiar_Click);
            // 
            // txtpantalla
            // 
            this.txtpantalla.BackColor = System.Drawing.Color.Black;
            this.txtpantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpantalla.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpantalla.ForeColor = System.Drawing.Color.White;
            this.txtpantalla.Location = new System.Drawing.Point(212, 220);
            this.txtpantalla.Name = "txtpantalla";
            this.txtpantalla.ReadOnly = true;
            this.txtpantalla.Size = new System.Drawing.Size(231, 63);
            this.txtpantalla.TabIndex = 3;
            this.txtpantalla.Text = "0";
            this.txtpantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelnumerico
            // 
            this.panelnumerico.Location = new System.Drawing.Point(173, 358);
            this.panelnumerico.Name = "panelnumerico";
            this.panelnumerico.Size = new System.Drawing.Size(206, 266);
            this.panelnumerico.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btndiv);
            this.flowLayoutPanel2.Controls.Add(this.btnmult);
            this.flowLayoutPanel2.Controls.Add(this.btnresta);
            this.flowLayoutPanel2.Controls.Add(this.btnsuma);
            this.flowLayoutPanel2.Controls.Add(this.btnigual);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(385, 289);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(58, 335);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btndiv
            // 
            this.btndiv.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btndiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndiv.FlatAppearance.BorderSize = 0;
            this.btndiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiv.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.ForeColor = System.Drawing.Color.White;
            this.btndiv.Location = new System.Drawing.Point(3, 3);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(55, 55);
            this.btndiv.TabIndex = 3;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btnmult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmult.FlatAppearance.BorderSize = 0;
            this.btnmult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.ForeColor = System.Drawing.Color.White;
            this.btnmult.Location = new System.Drawing.Point(3, 64);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(55, 55);
            this.btnmult.TabIndex = 4;
            this.btnmult.Text = "X";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btnresta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnresta.FlatAppearance.BorderSize = 0;
            this.btnresta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.ForeColor = System.Drawing.Color.White;
            this.btnresta.Location = new System.Drawing.Point(3, 125);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(55, 55);
            this.btnresta.TabIndex = 5;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btnsuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuma.FlatAppearance.BorderSize = 0;
            this.btnsuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuma.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.ForeColor = System.Drawing.Color.White;
            this.btnsuma.Location = new System.Drawing.Point(3, 186);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(55, 55);
            this.btnsuma.TabIndex = 6;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackgroundImage = global::CursoCsharp.Properties.Resources.circuloNaranja;
            this.btnigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnigual.FlatAppearance.BorderSize = 0;
            this.btnigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.ForeColor = System.Drawing.Color.White;
            this.btnigual.Location = new System.Drawing.Point(3, 247);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(55, 55);
            this.btnigual.TabIndex = 7;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnborrar);
            this.flowLayoutPanel1.Controls.Add(this.btnporcent);
            this.flowLayoutPanel1.Controls.Add(this.btnoff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 289);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 63);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnborrar
            // 
            this.btnborrar.BackgroundImage = global::CursoCsharp.Properties.Resources.circulogrisclaro;
            this.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.White;
            this.btnborrar.Location = new System.Drawing.Point(3, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(55, 55);
            this.btnborrar.TabIndex = 0;
            this.btnborrar.Text = "AC";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnporcent
            // 
            this.btnporcent.BackgroundImage = global::CursoCsharp.Properties.Resources.circulogrisclaro;
            this.btnporcent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnporcent.FlatAppearance.BorderSize = 0;
            this.btnporcent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnporcent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnporcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnporcent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcent.ForeColor = System.Drawing.Color.White;
            this.btnporcent.Location = new System.Drawing.Point(64, 3);
            this.btnporcent.Name = "btnporcent";
            this.btnporcent.Size = new System.Drawing.Size(55, 55);
            this.btnporcent.TabIndex = 1;
            this.btnporcent.Text = "%";
            this.btnporcent.UseVisualStyleBackColor = true;
            this.btnporcent.Click += new System.EventHandler(this.btnporcent_Click);
            // 
            // btnoff
            // 
            this.btnoff.BackgroundImage = global::CursoCsharp.Properties.Resources.circulogrisclaro;
            this.btnoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoff.FlatAppearance.BorderSize = 0;
            this.btnoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoff.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff.ForeColor = System.Drawing.Color.White;
            this.btnoff.Location = new System.Drawing.Point(125, 3);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(55, 55);
            this.btnoff.TabIndex = 2;
            this.btnoff.Text = "Off";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblejercicio);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ejercicio6";
            this.Size = new System.Drawing.Size(1000, 765);
            this.Load += new System.EventHandler(this.Ejercicio6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblejercicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelnumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnporcent;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.TextBox txtpantalla;
        private System.Windows.Forms.Button btncopiar;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lbloperacion;
    }
}
