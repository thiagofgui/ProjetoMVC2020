using ProjetoMVCD36.BLL;
using ProjetoMVCD36.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMVCD36.UI
{
    public partial class Formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                msgerro.Visible = false;
                tblClienteDTO cliente = new tblClienteDTO();
                cliente.Cpf_cliente = txtCpfD36.Text;
                cliente.Nome_cliente = txtNomeD36.Text;
                cliente.Nome_mae = txtNomeMaeD36.Text;

                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.consultarBeneficio(cliente.Cpf_cliente, cliente.Nome_cliente, cliente.Nome_mae))
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                }
                else
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                }
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
    }
}