
namespace HMS
{
    partial class F_Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.pb_sair = new System.Windows.Forms.PictureBox();
            this.pb_doutor = new System.Windows.Forms.PictureBox();
            this.pb_diag = new System.Windows.Forms.PictureBox();
            this.pb_paciente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_doutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_diag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_paciente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System";
            // 
            // pb_sair
            // 
            this.pb_sair.BackColor = System.Drawing.Color.Transparent;
            this.pb_sair.BackgroundImage = global::HMS.Properties.Resources.sair;
            this.pb_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_sair.Location = new System.Drawing.Point(350, 398);
            this.pb_sair.Name = "pb_sair";
            this.pb_sair.Size = new System.Drawing.Size(136, 152);
            this.pb_sair.TabIndex = 4;
            this.pb_sair.TabStop = false;
            this.pb_sair.Click += new System.EventHandler(this.pb_sair_Click);
            // 
            // pb_doutor
            // 
            this.pb_doutor.BackColor = System.Drawing.Color.Transparent;
            this.pb_doutor.BackgroundImage = global::HMS.Properties.Resources.doutor;
            this.pb_doutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_doutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_doutor.Location = new System.Drawing.Point(45, 128);
            this.pb_doutor.Name = "pb_doutor";
            this.pb_doutor.Size = new System.Drawing.Size(136, 152);
            this.pb_doutor.TabIndex = 1;
            this.pb_doutor.TabStop = false;
            this.pb_doutor.Click += new System.EventHandler(this.pb_doutor_Click);
            // 
            // pb_diag
            // 
            this.pb_diag.BackColor = System.Drawing.Color.Transparent;
            this.pb_diag.BackgroundImage = global::HMS.Properties.Resources.diag;
            this.pb_diag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_diag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_diag.Location = new System.Drawing.Point(45, 398);
            this.pb_diag.Name = "pb_diag";
            this.pb_diag.Size = new System.Drawing.Size(136, 152);
            this.pb_diag.TabIndex = 3;
            this.pb_diag.TabStop = false;
            this.pb_diag.Click += new System.EventHandler(this.pb_diag_Click);
            // 
            // pb_paciente
            // 
            this.pb_paciente.BackColor = System.Drawing.Color.Transparent;
            this.pb_paciente.BackgroundImage = global::HMS.Properties.Resources.paciente;
            this.pb_paciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_paciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_paciente.Location = new System.Drawing.Point(350, 128);
            this.pb_paciente.Name = "pb_paciente";
            this.pb_paciente.Size = new System.Drawing.Size(136, 152);
            this.pb_paciente.TabIndex = 2;
            this.pb_paciente.TabStop = false;
            this.pb_paciente.Click += new System.EventHandler(this.pb_paciente_Click);
            // 
            // F_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.BackgroundImage = global::HMS.Properties.Resources.Home2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 595);
            this.Controls.Add(this.pb_sair);
            this.Controls.Add(this.pb_diag);
            this.Controls.Add(this.pb_paciente);
            this.Controls.Add(this.pb_doutor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - HMS";
            ((System.ComponentModel.ISupportInitialize)(this.pb_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_doutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_diag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_paciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_sair;
        private System.Windows.Forms.PictureBox pb_doutor;
        private System.Windows.Forms.PictureBox pb_diag;
        private System.Windows.Forms.PictureBox pb_paciente;
    }
}