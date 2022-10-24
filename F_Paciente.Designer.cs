
namespace HMS
{
    partial class F_Paciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Paciente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_celular = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.cb_sangue = new System.Windows.Forms.ComboBox();
            this.tb_enfermidade = new System.Windows.Forms.TextBox();
            this.dgv_doutor = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doutor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 92);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(404, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(205, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Management System";
            // 
            // tb_celular
            // 
            this.tb_celular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_celular.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_celular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_celular.Location = new System.Drawing.Point(27, 290);
            this.tb_celular.MaxLength = 25;
            this.tb_celular.Multiline = true;
            this.tb_celular.Name = "tb_celular";
            this.tb_celular.PlaceholderText = "Celular";
            this.tb_celular.Size = new System.Drawing.Size(240, 45);
            this.tb_celular.TabIndex = 4;
            this.tb_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_endereco
            // 
            this.tb_endereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_endereco.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_endereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_endereco.Location = new System.Drawing.Point(27, 230);
            this.tb_endereco.MaxLength = 25;
            this.tb_endereco.Multiline = true;
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.PlaceholderText = "Endereço";
            this.tb_endereco.Size = new System.Drawing.Size(240, 45);
            this.tb_endereco.TabIndex = 3;
            this.tb_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_id.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_id.Location = new System.Drawing.Point(27, 110);
            this.tb_id.MaxLength = 25;
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.PlaceholderText = "ID";
            this.tb_id.Size = new System.Drawing.Size(240, 45);
            this.tb_id.TabIndex = 1;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_nome.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_nome.Location = new System.Drawing.Point(27, 170);
            this.tb_nome.MaxLength = 25;
            this.tb_nome.Multiline = true;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.PlaceholderText = "Nome";
            this.tb_nome.Size = new System.Drawing.Size(240, 45);
            this.tb_nome.TabIndex = 2;
            this.tb_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_idade
            // 
            this.tb_idade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_idade.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_idade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_idade.Location = new System.Drawing.Point(27, 350);
            this.tb_idade.MaxLength = 25;
            this.tb_idade.Multiline = true;
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.PlaceholderText = "Idade";
            this.tb_idade.Size = new System.Drawing.Size(240, 45);
            this.tb_idade.TabIndex = 5;
            this.tb_idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.btn_adicionar);
            this.panel2.Controls.Add(this.btn_deletar);
            this.panel2.Controls.Add(this.btn_atualizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 70);
            this.panel2.TabIndex = 10;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_home.Location = new System.Drawing.Point(687, 13);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(220, 45);
            this.btn_home.TabIndex = 12;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_adicionar.Location = new System.Drawing.Point(27, 13);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(220, 45);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderSize = 0;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_deletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_deletar.Location = new System.Drawing.Point(467, 13);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(220, 45);
            this.btn_deletar.TabIndex = 11;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_atualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_atualizar.Location = new System.Drawing.Point(247, 13);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(220, 45);
            this.btn_atualizar.TabIndex = 10;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            // 
            // cb_genero
            // 
            this.cb_genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.cb_genero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_genero.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_genero.Location = new System.Drawing.Point(27, 410);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(240, 33);
            this.cb_genero.TabIndex = 6;
            this.cb_genero.Text = "Gênero";
            // 
            // cb_sangue
            // 
            this.cb_sangue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.cb_sangue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_sangue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_sangue.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_sangue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cb_sangue.FormattingEnabled = true;
            this.cb_sangue.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cb_sangue.Location = new System.Drawing.Point(27, 455);
            this.cb_sangue.Name = "cb_sangue";
            this.cb_sangue.Size = new System.Drawing.Size(240, 33);
            this.cb_sangue.TabIndex = 7;
            this.cb_sangue.Text = "Tipo Sanguíneo";
            // 
            // tb_enfermidade
            // 
            this.tb_enfermidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_enfermidade.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_enfermidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_enfermidade.Location = new System.Drawing.Point(27, 500);
            this.tb_enfermidade.MaxLength = 25;
            this.tb_enfermidade.Multiline = true;
            this.tb_enfermidade.Name = "tb_enfermidade";
            this.tb_enfermidade.PlaceholderText = "Enfermidade";
            this.tb_enfermidade.Size = new System.Drawing.Size(240, 45);
            this.tb_enfermidade.TabIndex = 8;
            this.tb_enfermidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_doutor
            // 
            this.dgv_doutor.AllowUserToAddRows = false;
            this.dgv_doutor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_doutor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_doutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_doutor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.dgv_doutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_doutor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_doutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_doutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doutor.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_doutor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_doutor.EnableHeadersVisualStyles = false;
            this.dgv_doutor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.dgv_doutor.Location = new System.Drawing.Point(282, 110);
            this.dgv_doutor.MultiSelect = false;
            this.dgv_doutor.Name = "dgv_doutor";
            this.dgv_doutor.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_doutor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_doutor.RowHeadersVisible = false;
            this.dgv_doutor.RowTemplate.Height = 25;
            this.dgv_doutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doutor.Size = new System.Drawing.Size(625, 435);
            this.dgv_doutor.TabIndex = 13;
            // 
            // F_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.dgv_doutor);
            this.Controls.Add(this.tb_enfermidade);
            this.Controls.Add(this.cb_sangue);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.tb_celular);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente - HMS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_celular;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.ComboBox cb_sangue;
        private System.Windows.Forms.TextBox tb_enfermidade;
        private System.Windows.Forms.DataGridView dgv_doutor;
    }
}