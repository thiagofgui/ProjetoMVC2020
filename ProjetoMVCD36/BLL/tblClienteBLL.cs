using ProjetoMVCD36.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVCD36.BLL
{
    public class tblClienteBLL
    {
        private DALMVC daoBanco = new DALMVC();

        public Boolean consultarBeneficio(string cpf, string nome_completo, string nome_mae)
        {
            string consulta = string.Format($@"select * from tbl_clienteD36 where cpf_cliente = '{cpf}' and nome_cliente = '{nome_completo}' and nome_mae = '{nome_mae}'");
            DataTable dt = daoBanco.executarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}