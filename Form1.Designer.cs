namespace CruzPatinoDiego_Practica6_EventosdeBoton
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            btnpares = new Button();
            btnimpares = new Button();
            timerbotones = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // btnpares
            // 
            btnpares.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnpares.Location = new Point(267, 155);
            btnpares.Name = "btnpares";
            btnpares.Size = new Size(130, 90);
            btnpares.TabIndex = 0;
            btnpares.Text = "Pares";
            btnpares.UseVisualStyleBackColor = true;
            // 
            // btnimpares
            // 
            btnimpares.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnimpares.Location = new Point(403, 155);
            btnimpares.Name = "btnimpares";
            btnimpares.Size = new Size(130, 90);
            btnimpares.TabIndex = 1;
            btnimpares.Text = "Impares";
            btnimpares.UseVisualStyleBackColor = true;
            // 
            // timerbotones
            // 
            timerbotones.Enabled = true;
            timerbotones.Interval = 300;
            timerbotones.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 424);
            label1.Name = "label1";
            label1.Size = new Size(221, 18);
            label1.TabIndex = 2;
            label1.Text = "Cruz Patino Diego - 22210297";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 451);
            Controls.Add(label1);
            Controls.Add(btnimpares);
            Controls.Add(btnpares);
            Name = "FrmPrincipal";
            Text = "CruzPatinoDiego_Practica6_EventosBotones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnpares;
        private Button btnimpares;
        private System.Windows.Forms.Timer timerbotones;
        private Label label1;
    }
}
