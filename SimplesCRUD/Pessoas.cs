using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SampleCRUD
{
    public partial class Pessoas : Form
    {
        private Helpers.dbs db;
        private VO.PessoasVO cruds;
        private Int32 catchRowIndex;

        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string InscrEstadual { get; set; }
        public string InscrMunicipal { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public int Id { get; set; }
        public string Usuario { get;  set; }
        public string Senha { get;  set; }
        public string IeDestinatario { get; set; }

        public DateTime DataCadastro;

        public Pessoas()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

            textBox10.Items.Add("1 - Contribuinte ICMS Pagamento a Vista");
            textBox10.Items.Add("2 - Contribuinte Isento de Inscrição");
            textBox10.Items.Add("9 - Não Contribuinte");

            textBox2.Text = RazaoSocial;
            textBox3.Text = NomeFantasia;
            textBox4.Text = Cnpj;
            textBox5.Text = InscrEstadual;
            textBox6.Text = InscrMunicipal;
            if (DataCadastro <= DateTime.Parse("01/01/0001 00:00:00"))
            {
                textBox7.Value = DateTime.Now;
            }
            else
            {
                textBox7.Value = Convert.ToDateTime(DataCadastro);
            }

            textBox8.Text = Email;
            textBox9.Text = Celular;
            textBox10.Text = IeDestinatario;
            textBox11.Text = Usuario;
            textBox12.Text = Senha;
            textBox1.Text = Convert.ToInt32(Id).ToString();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cruds = new VO.PessoasVO();
                cruds.RazaoSocial = textBox2.Text;
                cruds.NomeFantasia = textBox3.Text;
                cruds.Cnpj = textBox4.Text;
                cruds.InscrEstadual = textBox5.Text;
                cruds.InscrMunicipal = textBox6.Text;
                cruds.DataCadastro = Convert.ToDateTime(textBox7.Text);
                cruds.Email = textBox8.Text;
                cruds.Celular = textBox9.Text;
                cruds.Usuario = textBox11.Text;
                cruds.Senha = textBox12.Text;
                cruds.IeDestinatario = textBox10.Text;
                cruds.Inserir();
                LimpaDados();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void Pessoas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cruds = new VO.PessoasVO();
            try
            {
                cruds.RazaoSocial = textBox2.Text;
                cruds.NomeFantasia = textBox3.Text;
                cruds.Cnpj = textBox4.Text;
                cruds.InscrEstadual = textBox5.Text;
                cruds.InscrMunicipal = textBox6.Text;
                cruds.DataCadastro = Convert.ToDateTime(textBox7.Text);
                cruds.Email = textBox8.Text;
                cruds.Celular = textBox9.Text;
                cruds.Usuario = textBox11.Text;
                cruds.Senha = textBox12.Text;
                cruds.IeDestinatario = textBox10.Text;
                cruds.Id = Convert.ToInt32(textBox1.Text);
                cruds.Atualizar();
                LimpaDados();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            cruds = new VO.PessoasVO();
            try
            {
                cruds.RazaoSocial = textBox2.Text;
                cruds.Id = Convert.ToInt32(textBox1.Text);
                cruds.Remover();
                LimpaDados();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpaDados();
            textBox2.Focus();
        }
        private void LimpaDados()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Value = DateTime.Now;
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}