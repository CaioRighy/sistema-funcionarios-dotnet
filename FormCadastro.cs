using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaFuncionarios
{
    public partial class FormCadastro : Form
    {
        private AppDbContext db = new AppDbContext();

        public FormCadastro()
        {
            InitializeComponent();
            CarregarProfissionais();

            txtSalario.KeyPress += txtSalario_KeyPress;
            dgvProfissionais.SelectionChanged += dgvProfissionais_SelectionChanged;
            btnSalvar.Click += BtnSalvar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnExcluir.Click += BtnExcluir_Click;
            btnCalcularHoraExtra.Click += btnCalcularHoraExtra_Click; // adiciona o clique do botão de hora extra
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
            cmbFuncionario.DataSource = db.Profissionais.ToList(); // preenche a comboBox da aba Hora Extra
            cmbFuncionario.DisplayMember = "Nome";
            cmbFuncionario.ValueMember = "Id";
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

        private void dgvProfissionais_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProfissionais.SelectedRows.Count > 0)
            {
                int id = (int)dgvProfissionais.SelectedRows[0].Cells[0].Value;
                var profissional = db.Profissionais.Find(id);

                txtNome.Text = profissional.Nome;
                txtTelefone.Text = profissional.Telefone;
                txtRG.Text = profissional.RG;
                txtEndereco.Text = profissional.Endereco;
                txtSalario.Text = profissional.Salario.ToString("N2", new System.Globalization.CultureInfo("pt-BR"));
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)8)
                e.Handled = true;

            if (e.KeyChar == ',' && txtSalario.Text.Contains(","))
                e.Handled = true;
        }

        private void btnCalcularHoraExtra_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFuncionario.SelectedItem is Profissional profissionalSelecionado)
                {
                    decimal salarioBase = profissionalSelecionado.Salario;
                    decimal horasExtras = (decimal)numHorasExtras.Value;

                    decimal valorHora = salarioBase / 220;
                    decimal totalComExtras = salarioBase + (valorHora * horasExtras * 1.5m);

                    txtSalarioAtual.Text = salarioBase.ToString("N2");
                    txtTotalHoraExtra.Text = totalComExtras.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                txtTotalHoraExtra.Text = "Erro no cálculo.";
            }
        }

        
private void cmbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFuncionario.SelectedItem != null)
            {
                var funcionario = cmbFuncionario.SelectedItem as Profissional;
                if (funcionario != null)
                {
                    txtSalarioAtual.Text = funcionario.Salario.ToString("C");
                }
            }
        }

    }
}

