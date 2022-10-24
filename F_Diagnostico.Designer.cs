
namespace HMS
{
    partial class F_Diagnostico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_idPaciente = new System.Windows.Forms.ComboBox();
            this.tb_diagnostico = new System.Windows.Forms.TextBox();
            this.tb_nomePaciente = new System.Windows.Forms.TextBox();
            this.tb_sintomas = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_remedios = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_doutor = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doutor)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(380, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diagnóstico";
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
            // cb_idPaciente
            // 
            this.cb_idPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.cb_idPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_idPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_idPaciente.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_idPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cb_idPaciente.FormattingEnabled = true;
            this.cb_idPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_idPaciente.Location = new System.Drawing.Point(268, 112);
            this.cb_idPaciente.Name = "cb_idPaciente";
            this.cb_idPaciente.Size = new System.Drawing.Size(240, 33);
            this.cb_idPaciente.TabIndex = 14;
            this.cb_idPaciente.Text = "Id do Paciente";
            // 
            // tb_diagnostico
            // 
            this.tb_diagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_diagnostico.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_diagnostico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_diagnostico.Location = new System.Drawing.Point(22, 214);
            this.tb_diagnostico.MaxLength = 25;
            this.tb_diagnostico.Multiline = true;
            this.tb_diagnostico.Name = "tb_diagnostico";
            this.tb_diagnostico.PlaceholderText = "Diagnóstico";
            this.tb_diagnostico.Size = new System.Drawing.Size(240, 45);
            this.tb_diagnostico.TabIndex = 5;
            this.tb_diagnostico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_nomePaciente
            // 
            this.tb_nomePaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_nomePaciente.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nomePaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_nomePaciente.Location = new System.Drawing.Point(268, 163);
            this.tb_nomePaciente.MaxLength = 25;
            this.tb_nomePaciente.Multiline = true;
            this.tb_nomePaciente.Name = "tb_nomePaciente";
            this.tb_nomePaciente.PlaceholderText = "Nome do Paciente";
            this.tb_nomePaciente.Size = new System.Drawing.Size(240, 45);
            this.tb_nomePaciente.TabIndex = 4;
            this.tb_nomePaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_sintomas
            // 
            this.tb_sintomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_sintomas.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_sintomas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_sintomas.Location = new System.Drawing.Point(22, 163);
            this.tb_sintomas.MaxLength = 25;
            this.tb_sintomas.Multiline = true;
            this.tb_sintomas.Name = "tb_sintomas";
            this.tb_sintomas.PlaceholderText = "Sintomas";
            this.tb_sintomas.Size = new System.Drawing.Size(240, 45);
            this.tb_sintomas.TabIndex = 3;
            this.tb_sintomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_id.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_id.Location = new System.Drawing.Point(22, 112);
            this.tb_id.MaxLength = 25;
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.PlaceholderText = "ID";
            this.tb_id.Size = new System.Drawing.Size(240, 45);
            this.tb_id.TabIndex = 1;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_remedios
            // 
            this.tb_remedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.tb_remedios.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_remedios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tb_remedios.Location = new System.Drawing.Point(268, 214);
            this.tb_remedios.MaxLength = 25;
            this.tb_remedios.Multiline = true;
            this.tb_remedios.Name = "tb_remedios";
            this.tb_remedios.PlaceholderText = "Remédios";
            this.tb_remedios.Size = new System.Drawing.Size(240, 45);
            this.tb_remedios.TabIndex = 2;
            this.tb_remedios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_home.TabIndex = 8;
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
            this.btn_adicionar.TabIndex = 5;
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
            this.btn_deletar.TabIndex = 7;
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
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.btn_adicionar);
            this.panel2.Controls.Add(this.btn_deletar);
            this.panel2.Controls.Add(this.btn_atualizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 70);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(514, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 407);
            this.panel3.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(101)))), ((int)(((byte)(118)))));
            this.label10.Location = new System.Drawing.Point(82, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Hospital Management System";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label9.Location = new System.Drawing.Point(12, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Remédios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(12, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sintomas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Diagnóstico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome do paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(350, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(109, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diagnóstico";
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
            this.dgv_doutor.Location = new System.Drawing.Point(22, 319);
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
            this.dgv_doutor.Size = new System.Drawing.Size(486, 200);
            this.dgv_doutor.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(118, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lista de pacientes";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(22, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 45);
            this.panel4.TabIndex = 18;
            // 
            // F_Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(934, 595);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_doutor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cb_idPaciente);
            this.Controls.Add(this.tb_diagnostico);
            this.Controls.Add(this.tb_nomePaciente);
            this.Controls.Add(this.tb_sintomas);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_remedios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Diagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnostico - HMS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doutor)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_idPaciente;
        private System.Windows.Forms.TextBox tb_diagnostico;
        private System.Windows.Forms.TextBox tb_nomePaciente;
        private System.Windows.Forms.TextBox tb_sintomas;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_remedios;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_doutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}