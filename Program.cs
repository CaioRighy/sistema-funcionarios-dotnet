using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SistemaFuncionarios
{
    public class Profissional
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public decimal Salario { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Profissional> Profissionais { get; set; }

        public AppDbContext() : base("AppDbContext") { }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }

    public class FormPrincipal : Form
    {
        private TabControl tabControl;
        private TabPage tabCadastro;
        private TabPage tabHoraExtra;

        private DataGridView dgvProfissionais;
        private Button btnSalvar, btnEditar, btnExcluir, btnCalcular;

        private TextBox txtNome, txtTelefone, txtRG, txtEndereco, txtSalario;

        private ComboBox cmbProfissionais;
        private NumericUpDown nudHorasExtras;
        private Label lblSalarioAtual, lblTotalComExtras;

        private AppDbContext db = new AppDbContext();

        public FormPrincipal()
        {
            this.Text = "Sistema de Funcionários";
            this.Width = 800;
            this.Height = 600;

            tabControl = new TabControl { Dock = DockStyle.Fill };
            tabCadastro = new TabPage("Cadastro");
            tabHoraExtra = new TabPage("Hora Extra");

            CriarAbaCadastro();
            CriarAbaHoraExtra();

            tabControl.TabPages.Add(tabCadastro);
            tabControl.TabPages.Add(tabHoraExtra);
            this.Controls.Add(tabControl);

            CarregarProfissionais();
        }

        private void CriarAbaCadastro()
        {
            Label lblNome = new Label { Text = "Nome", Top = 20, Left = 20 };
            txtNome = new TextBox { Top = 40, Left = 20, Width = 200 };

            Label lblTelefone = new Label { Text = "Telefone", Top = 70, Left = 20 };
            txtTelefone = new TextBox { Top = 90, Left = 20, Width = 200 };

            Label lblRG = new Label { Text = "RG", Top = 120, Left = 20 };
            txtRG = new TextBox { Top = 140, Left = 20, Width = 200 };

            Label lblEndereco = new Label { Text = "Endereço", Top = 170, Left = 20 };
            txtEndereco = new TextBox { Top = 190, Left = 20, Width = 200 };

            Label lblSalario = new Label { Text = "Salário", Top = 220, Left = 20 };
            txtSalario = new TextBox { Top = 240, Left = 20, Width = 200 };

            btnSalvar = new Button { Text = "Salvar", Top = 280, Left = 20 };
            btnSalvar.Click += BtnSalvar_Click;

            btnEditar = new Button { Text = "Editar", Top = 280, Left = 100 };
            btnEditar.Click += BtnEditar_Click;

            btnExcluir = new Button { Text = "Excluir", Top = 280, Left = 180 };
            btnExcluir.Click += BtnExcluir_Click;

            dgvProfissionais = new DataGridView { Top = 320, Left = 20, Width = 720, Height = 180 };
            dgvProfissionais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            tabCadastro.Controls.AddRange(new Control[] {
                lblNome, txtNome, lblTelefone, txtTelefone,
                lblRG, txtRG, lblEndereco, txtEndereco,
                lblSalario, txtSalario, btnSalvar, btnEditar, btnExcluir, dgvProfissionais
            });
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!TentarObterSalario(out var salario)) return;

            var profissional = new Profissional
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                RG = txtRG.Text,
                Endereco = txtEndereco.Text,
                Salario = salario
            };

            db.Profissionais.Add(profissional);
            db.SaveChanges();
            CarregarProfissionais();
            LimparCampos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProfissionais.SelectedRows.Count == 0) return;
            if (!TentarObterSalario(out var salario)) return;

            int id = (int)dgvProfissionais.SelectedRows[0].Cells[0].Value;
            var profissional = db.Profissionais.Find(id);

            profissional.Nome = txtNome.Text;
            profissional.Telefone = txtTelefone.Text;
            profissional.RG = txtRG.Text;
            profissional.Endereco = txtEndereco.Text;
            profissional.Salario = salario;

            db.SaveChanges();
            CarregarProfissionais();
            LimparCampos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProfissionais.SelectedRows.Count == 0) return;

            int id = (int)dgvProfissionais.SelectedRows[0].Cells[0].Value;
            var profissional = db.Profissionais.Find(id);

            db.Profissionais.Remove(profissional);
            db.SaveChanges();
            CarregarProfissionais();
            LimparCampos();
        }

        private void CarregarProfissionais()
        {
            dgvProfissionais.DataSource = db.Profissionais.ToList();
            cmbProfissionais?.Items.Clear();
            cmbProfissionais?.Items.AddRange(db.Profissionais.ToArray());
            cmbProfissionais.DisplayMember = "Nome";

            if (cmbProfissionais != null && cmbProfissionais.Items.Count > 0)
            {
                cmbProfissionais.SelectedIndex = 0;
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = txtTelefone.Text = txtRG.Text = txtEndereco.Text = txtSalario.Text = "";
        }

        private bool TentarObterSalario(out decimal salario)
        {
            var cultura = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");

            if (decimal.TryParse(txtSalario.Text, System.Globalization.NumberStyles.Number, cultura, out salario))
                return true;

            MessageBox.Show("Salário inválido. Digite apenas números (ex.: 2500,75).",
                            "Erro de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            salario = 0;
            return false;
        }

        private void CriarAbaHoraExtra()
        {
            Label lblSelecionar = new Label { Text = "Profissional:", Top = 20, Left = 20 };
            cmbProfissionais = new ComboBox { Top = 40, Left = 20, Width = 200 };
            cmbProfissionais.SelectedIndexChanged += CmbProfissionais_SelectedIndexChanged;

            Label lblHoras = new Label { Text = "Horas Extras:", Top = 80, Left = 20 };
            nudHorasExtras = new NumericUpDown { Top = 100, Left = 20, Width = 100 };

            btnCalcular = new Button { Text = "Calcular", Top = 140, Left = 20 };
            btnCalcular.Click += BtnCalcular_Click;

            lblSalarioAtual = new Label { Text = "Salário Atual: R$", Top = 180, Left = 20, Width = 300 };
            lblTotalComExtras = new Label { Text = "Total com Hora Extra: R$", Top = 220, Left = 20, Width = 300 };

            tabHoraExtra.Controls.AddRange(new Control[] {
                lblSelecionar, cmbProfissionais,
                lblHoras, nudHorasExtras,
                btnCalcular, lblSalarioAtual, lblTotalComExtras
            });
        }

        private void CmbProfissionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            var profissional = cmbProfissionais.SelectedItem as Profissional;
            if (profissional != null)
            {
                lblSalarioAtual.Text = $"Salário Atual: R$ {profissional.Salario:F2}";
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            var profissional = cmbProfissionais.SelectedItem as Profissional;

            if (profissional == null)
            {
                MessageBox.Show("Nenhum profissional selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var horasExtras = nudHorasExtras.Value;
            var valorExtras = (profissional.Salario * 0.05m) * horasExtras;
            var total = profissional.Salario + valorExtras;

            lblTotalComExtras.Text = $"Total com Hora Extra: R$ {total:F2}";
        }
    }
}
