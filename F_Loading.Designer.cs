
namespace HMS
{
    partial class F_Loading
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
            this.components = new System.ComponentModel.Container();
            this.barra = new System.Windows.Forms.Panel();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(101)))), ((int)(((byte)(118)))));
            this.barra.Location = new System.Drawing.Point(0, 394);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(30, 5);
            this.barra.TabIndex = 2;
            // 
            // tempo
            // 
            this.tempo.Enabled = true;
            this.tempo.Interval = 15;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // F_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HMS.Properties.Resources.BGLoading;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading - HMS";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.Timer tempo;
    }
}