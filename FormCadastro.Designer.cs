namespace SistemaFuncionarios
{
    partial class FormCadastro
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
            this.Cadastro = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.dgvProfissionais = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabHoraExtra = new System.Windows.Forms.TabPage();
            this.txtTotalHoraExtra = new System.Windows.Forms.TextBox();
            this.lblTotalHoraExtra = new System.Windows.Forms.Label();
            this.numHorasExtras = new System.Windows.Forms.NumericUpDown();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.txtSalarioAtual = new System.Windows.Forms.TextBox();
            this.lblSalarioAtual = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcularHoraExtra = new System.Windows.Forms.Button();
            this.Cadastro.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionais)).BeginInit();
            this.tabHoraExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.tabCadastro);
            this.Cadastro.Controls.Add(this.tabHoraExtra);
            this.Cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cadastro.Location = new System.Drawing.Point(0, 0);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.SelectedIndex = 0;
            this.Cadastro.Size = new System.Drawing.Size(800, 450);
            this.Cadastro.TabIndex = 14;
            // 
            // tabCadastro
            // 
            this.tabCadastro.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabCadastro.Controls.Add(this.dgvProfissionais);
            this.tabCadastro.Controls.Add(this.btnExcluir);
            this.tabCadastro.Controls.Add(this.btnEditar);
            this.tabCadastro.Controls.Add(this.btnSalvar);
            this.tabCadastro.Controls.Add(this.txtSalario);
            this.tabCadastro.Controls.Add(this.lblSalario);
            this.tabCadastro.Controls.Add(this.txtEndereco);
            this.tabCadastro.Controls.Add(this.lblEndereco);
            this.tabCadastro.Controls.Add(this.txtRG);
            this.tabCadastro.Controls.Add(this.lblRG);
            this.tabCadastro.Controls.Add(this.txtTelefone);
            this.tabCadastro.Controls.Add(this.lblTelefone);
            this.tabCadastro.Controls.Add(this.txtNome);
            this.tabCadastro.Controls.Add(this.lblNome);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(792, 424);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // dgvProfissionais
            // 
            this.dgvProfissionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfissionais.Location = new System.Drawing.Point(6, 241);
            this.dgvProfissionais.Name = "dgvProfissionais";
            this.dgvProfissionais.Size = new System.Drawing.Size(737, 164);
            this.dgvProfissionais.TabIndex = 14;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(168, 212);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(87, 212);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 212);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(19, 186);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 10;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(16, 170);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 9;
            this.lblSalario.Text = "\tSalário";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(19, 146);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(16, 126);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(19, 100);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 6;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(16, 84);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 5;
            this.lblRG.Text = "RG";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(19, 61);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(16, 45);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 6);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // tabHoraExtra
            // 
            this.tabHoraExtra.Controls.Add(this.txtTotalHoraExtra);
            this.tabHoraExtra.Controls.Add(this.lblTotalHoraExtra);
            this.tabHoraExtra.Controls.Add(this.numHorasExtras);
            this.tabHoraExtra.Controls.Add(this.lblHorasExtras);
            this.tabHoraExtra.Controls.Add(this.txtSalarioAtual);
            this.tabHoraExtra.Controls.Add(this.lblSalarioAtual);
            this.tabHoraExtra.Controls.Add(this.cmbFuncionario);
            this.tabHoraExtra.Controls.Add(this.lblFuncionario);
            this.tabHoraExtra.Controls.Add(this.lblResultado);
            this.tabHoraExtra.Controls.Add(this.btnCalcularHoraExtra);
            this.tabHoraExtra.Location = new System.Drawing.Point(4, 22);
            this.tabHoraExtra.Name = "tabHoraExtra";
            this.tabHoraExtra.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoraExtra.Size = new System.Drawing.Size(792, 424);
            this.tabHoraExtra.TabIndex = 1;
            this.tabHoraExtra.Text = "Hora Extra";
            this.tabHoraExtra.UseVisualStyleBackColor = true;
            // 
            // txtTotalHoraExtra
            // 
            this.txtTotalHoraExtra.Location = new System.Drawing.Point(13, 164);
            this.txtTotalHoraExtra.Name = "txtTotalHoraExtra";
            this.txtTotalHoraExtra.ReadOnly = true;
            this.txtTotalHoraExtra.Size = new System.Drawing.Size(197, 20);
            this.txtTotalHoraExtra.TabIndex = 13;
            // 
            // lblTotalHoraExtra
            // 
            this.lblTotalHoraExtra.AutoSize = true;
            this.lblTotalHoraExtra.Location = new System.Drawing.Point(10, 148);
            this.lblTotalHoraExtra.Name = "lblTotalHoraExtra";
            this.lblTotalHoraExtra.Size = new System.Drawing.Size(107, 13);
            this.lblTotalHoraExtra.TabIndex = 12;
            this.lblTotalHoraExtra.Text = "Total com Hora Extra";
            // 
            // numHorasExtras
            // 
            this.numHorasExtras.Location = new System.Drawing.Point(13, 111);
            this.numHorasExtras.Name = "numHorasExtras";
            this.numHorasExtras.Size = new System.Drawing.Size(120, 20);
            this.numHorasExtras.TabIndex = 11;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Location = new System.Drawing.Point(13, 95);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(67, 13);
            this.lblHorasExtras.TabIndex = 10;
            this.lblHorasExtras.Text = "Horas Extras";
            // 
            // txtSalarioAtual
            // 
            this.txtSalarioAtual.Location = new System.Drawing.Point(13, 68);
            this.txtSalarioAtual.Name = "txtSalarioAtual";
            this.txtSalarioAtual.ReadOnly = true;
            this.txtSalarioAtual.Size = new System.Drawing.Size(197, 20);
            this.txtSalarioAtual.TabIndex = 9;
            // 
            // lblSalarioAtual
            // 
            this.lblSalarioAtual.AutoSize = true;
            this.lblSalarioAtual.Location = new System.Drawing.Point(13, 51);
            this.lblSalarioAtual.Name = "lblSalarioAtual";
            this.lblSalarioAtual.Size = new System.Drawing.Size(66, 13);
            this.lblSalarioAtual.TabIndex = 8;
            this.lblSalarioAtual.Text = "Salário Atual";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(13, 23);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cmbFuncionario.TabIndex = 7;
            this.cmbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionario_SelectedIndexChanged);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(10, 7);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 6;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(7, 118);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 5;
            // 
            // btnCalcularHoraExtra
            // 
            this.btnCalcularHoraExtra.Location = new System.Drawing.Point(13, 220);
            this.btnCalcularHoraExtra.Name = "btnCalcularHoraExtra";
            this.btnCalcularHoraExtra.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularHoraExtra.TabIndex = 4;
            this.btnCalcularHoraExtra.Text = "Calcular";
            this.btnCalcularHoraExtra.UseVisualStyleBackColor = true;
            this.btnCalcularHoraExtra.Click += new System.EventHandler(this.btnCalcularHoraExtra_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cadastro);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.Cadastro.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionais)).EndInit();
            this.tabHoraExtra.ResumeLayout(false);
            this.tabHoraExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasExtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Cadastro;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabHoraExtra;
        private System.Windows.Forms.Button btnCalcularHoraExtra;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvProfissionais;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox txtSalarioAtual;
        private System.Windows.Forms.Label lblSalarioAtual;
        private System.Windows.Forms.NumericUpDown numHorasExtras;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.TextBox txtTotalHoraExtra;
        private System.Windows.Forms.Label lblTotalHoraExtra;
    }
}