using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using SampleCRUD.VO;

namespace SampleCRUD
{
    public partial class ConsultaPessoa : Form
    {
        private Helpers.dbs db;
        private VO.PessoasVO cruds;
        private Int32 catchRowIndex;
        private Int32 tela;

        public string Descricao { get; private set; }

        public Int32 PessoaSelecionado;
        public String PessoaNome;
        public String PessoaCpf;

        public ConsultaPessoa(Int32 ctela)
        {
            tela = ctela;
            InitializeComponent();
        }

        private void carregaDados()
        {
            db = new Helpers.dbs();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            String cDescricao;
            cDescricao = textBox1.Text;

            string connectionString = db.getConnectionString();
            string query = "SELECT Pessoa.Id, Pessoa.Cnpj, Pessoa.RazaoSocial, Pessoa.NomeFantasia,  Pessoa.InscrEstadual, ";
            query += "Pessoa.InscrMunicipal, Pessoa.DataCadastro, Pessoa.Email, Pessoa.Celular, Pessoa.IeDestinatario, Pessoa.Usuario, Pessoa.Senha ";
            query += "FROM Pessoa WHERE RazaoSocial like '%" + cDescricao + "%'";
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {
                        DataTable dataPessoa= new DataTable();
                        adapter.Fill(dataPessoa);
                        for (int i = 0; i < dataPessoa.Rows.Count; i++)
                        {

                            VO.PessoasVO Pessoa = new PessoasVO();
                            Pessoa.Id = ConverteReader.ConverteInt(dataPessoa?.Rows[i][0]);
                            Pessoa.Cnpj = ConverteReader.ConverteString(dataPessoa.Rows[i][1]);
                            Pessoa.RazaoSocial = ConverteReader.ConverteString(dataPessoa.Rows[i][2]);
                            Pessoa.NomeFantasia = ConverteReader.ConverteString(dataPessoa.Rows[i][3]);
                            Pessoa.InscrEstadual = ConverteReader.ConverteString(dataPessoa.Rows[i][4]);
                            Pessoa.InscrMunicipal = ConverteReader.ConverteString(dataPessoa.Rows[i][5]);
                            Pessoa.DataCadastro = (DateTime)ConverteReader.ConverteDateTime(dataPessoa.Rows[i][6]);
                            Pessoa.Email = ConverteReader.ConverteString(dataPessoa.Rows[i][7]);
                            Pessoa.Celular = ConverteReader.ConverteString(dataPessoa.Rows[i][8]);
                            Pessoa.IeDestinatario = ConverteReader.ConverteString(dataPessoa.Rows[i][9]);
                            Pessoa.Usuario = ConverteReader.ConverteString(dataPessoa.Rows[i][10]);
                            Pessoa.Senha = ConverteReader.ConverteString(dataPessoa.Rows[i][11]);

                            dataGridView1.Rows.Add(Pessoa.Id,
                                Pessoa.Cnpj,
                                Pessoa.RazaoSocial,
                                Pessoa.NomeFantasia,
                                Pessoa.InscrEstadual,
                                Pessoa.InscrMunicipal,
                                Pessoa.DataCadastro,
                                Pessoa.Email,
                                Pessoa.Celular,
                                Pessoa.IeDestinatario,
                                Pessoa.Usuario,
                                Pessoa.Senha); 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } 
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                switch (tela)
                {
                    case 1:
                        int Id = Convert.ToInt32(row.Cells[0].Value.ToString());
                        string Cnpj = row.Cells[1].Value.ToString();
                        string RazaoSocial = row.Cells[2].Value.ToString();
                        string NomeFantasia = row.Cells[3].Value.ToString();             
                        string InscrEstadual = row.Cells[4].Value.ToString();
                        string InscrMunicipal = row.Cells[5].Value.ToString();
                        DateTime DataCadastro = Convert.ToDateTime(row.Cells[6].Value.ToString());
                        string Email = row.Cells[7].Value.ToString();
                        string Celular = row.Cells[8].Value.ToString();
                        string IeDestinatario = row.Cells[9].Value.ToString();
                        string Usuario = row.Cells[10].Value.ToString();
                        string Senha = row.Cells[11].Value.ToString();
 
                        Pessoas pessoa = new Pessoas();
                        pessoa.RazaoSocial = RazaoSocial;
                        pessoa.NomeFantasia = NomeFantasia;
                        pessoa.Cnpj = Cnpj;
                        pessoa.InscrEstadual = InscrEstadual;
                        pessoa.InscrMunicipal = InscrMunicipal;
                        pessoa.DataCadastro = DataCadastro;
                        pessoa.Email = Email;
                        pessoa.Celular = Celular;
                        pessoa.Usuario = Usuario;
                        pessoa.Senha = Senha;
                        pessoa.IeDestinatario = IeDestinatario;
                        pessoa.Id = Id;
                        pessoa.StartPosition = FormStartPosition.CenterScreen;
                        pessoa.ShowDialog();
                        if (pessoa != null && !pessoa.IsDisposed)
                            pessoa.BringToFront();
                        break;
                    case 2:
                        Descricao = row.Cells[1].Value.ToString();
                        this.Close();
                        break;

                    case 3:
                        PessoaSelecionado = Convert.ToInt32(row.Cells[0].Value.ToString());
                        PessoaNome = row.Cells[1].Value.ToString();
                        PessoaCpf = row.Cells[3].Value.ToString();
                        this.Close();
                        break;
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Pessoas pessoa = new Pessoas();
            pessoa.StartPosition = FormStartPosition.CenterScreen;
            pessoa.ShowDialog();
            if (pessoa != null && !pessoa.IsDisposed)
                pessoa.BringToFront();
        }

        private void ConsultaPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}