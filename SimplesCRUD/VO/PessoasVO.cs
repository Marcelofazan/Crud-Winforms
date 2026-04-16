using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCRUD.VO
{
    class PessoasVO
    {
        private Int32 _Id;
        private String _RazaoSocial, _NomeFantasia, _Cnpj, _InscrEstadual, _InscrMunicipal, _Email, _Celular, _Usuario, _Senha, _IeDestinatario;
        private DateTime _DataCadastro;
        private DAO.PessoaDAO cdao;

        public PessoasVO()
        {

        }

        public Int32 Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public String RazaoSocial
        {
            get { return _RazaoSocial; }
            set { _RazaoSocial = value; }
        }

        public String NomeFantasia
        {
            get { return _NomeFantasia; }
            set { _NomeFantasia = value; }
        }
        public String Cnpj
        {
            get { return _Cnpj; }
            set { _Cnpj = value; }
        }
        public String InscrEstadual
        {
            get { return _InscrEstadual; }
            set { _InscrEstadual = value; }
        }
        public String InscrMunicipal
        {
            get { return _InscrMunicipal; }
            set { _InscrMunicipal = value; }
        }
        public DateTime DataCadastro
        {
            get { return _DataCadastro; }
            set { _DataCadastro = value; }
        }
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public String Celular
        {
            get { return _Celular; }
            set { _Celular = value; }
        }
        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public String Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }
        public String IeDestinatario
        {
            get { return _IeDestinatario; }
            set { _IeDestinatario = value; }
        }


        public void Inserir()
        {
            cdao = new DAO.PessoaDAO();
            cdao.InserirDados(RazaoSocial, NomeFantasia, Cnpj, InscrEstadual, InscrMunicipal, DataCadastro, Email, Celular, Usuario, Senha , IeDestinatario);
        }
        public void Atualizar()
        {
            cdao = new DAO.PessoaDAO();
            cdao.AtualizarDados(RazaoSocial, NomeFantasia, Cnpj, InscrEstadual, InscrMunicipal, DataCadastro, Email, Celular, Usuario, Senha, IeDestinatario, Id);
        }
        public void Remover()
        {
            cdao = new DAO.PessoaDAO();
            cdao.RemoverDados(RazaoSocial, Id);
        }
    }
}

