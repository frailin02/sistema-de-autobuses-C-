namespace SISTEMA_DE_AUTOBUSES
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChoferes = new System.Windows.Forms.Button();
            this.btnAutobus = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE CONTROL DE AUTOBUSES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnChoferes
            // 
            this.btnChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChoferes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoferes.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnChoferes.FlatAppearance.BorderSize = 2;
            this.btnChoferes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnChoferes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoferes.Location = new System.Drawing.Point(86, 130);
            this.btnChoferes.Name = "btnChoferes";
            this.btnChoferes.Size = new System.Drawing.Size(186, 58);
            this.btnChoferes.TabIndex = 1;
            this.btnChoferes.Text = "REGISTRAR CHOFERES";
            this.btnChoferes.UseVisualStyleBackColor = false;
            this.btnChoferes.Click += new System.EventHandler(this.btnChoferes_Click);
            // 
            // btnAutobus
            // 
            this.btnAutobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAutobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutobus.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAutobus.FlatAppearance.BorderSize = 2;
            this.btnAutobus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAutobus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAutobus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutobus.Location = new System.Drawing.Point(445, 130);
            this.btnAutobus.Name = "btnAutobus";
            this.btnAutobus.Size = new System.Drawing.Size(186, 58);
            this.btnAutobus.TabIndex = 2;
            this.btnAutobus.Text = "REGISTRAR AUTOBUS";
            this.btnAutobus.UseVisualStyleBackColor = false;
            this.btnAutobus.Click += new System.EventHandler(this.btnAutobus_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuta.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnRuta.FlatAppearance.BorderSize = 2;
            this.btnRuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuta.Location = new System.Drawing.Point(264, 130);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(186, 58);
            this.btnRuta.TabIndex = 3;
            this.btnRuta.Text = "REGISTRAR RUTA";
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(264, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "VIAJES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnViaje);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnAutobus);
            this.Controls.Add(this.btnChoferes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SISTEMA DE AUTOBUSES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnChoferes;
        private Button btnAutobus;
        private Button btnRuta;
        private Button button2;
    }
}