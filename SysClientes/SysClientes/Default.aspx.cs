using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysClientes.WcfCliente;
using SysClientes.WcfTipoCliente;
using SysClientes.WcfSituacaoClientes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SysClientes
{
    public partial class _Default : Page
    {
        #region Variable Declaration  
        ServiceClienteClient obj = new ServiceClienteClient();
        ServiceTipoClienteClient objTipCli = new ServiceTipoClienteClient();
        ServiceSituacaoClienteClient objSitCli = new ServiceSituacaoClienteClient();
        #endregion
        #region User Define Methods  
        private void ClearControls()
        {
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtNascimento.Text = string.Empty;
            ddlSexo.SelectedIndex = 0;
            ddlSituacao.SelectedIndex = 0;
            ddlTipoCliente.SelectedIndex = 0;
            btnSubmit.Text = "Salvar";
            txtNome.Focus();
        }
        private void BindClientes(int? Id)
        {
            try
            {
                Clientes eDetails = new Clientes();
                TipoCliente eTipoCliente = new TipoCliente();
                SituacaoCliente eSituacaoCliente = new SituacaoCliente();

                DataSet ds = new DataSet();
                DataSet dsTipCli = new DataSet();
                DataSet dsSitCli = new DataSet();

                ds = obj.GetClientes(eDetails);
                dsTipCli = objTipCli.GetTipoCliente(eTipoCliente);
                dsSitCli = objSitCli.GetSituacaoCliente(eSituacaoCliente);

                ddlTipoCliente.DataSource = dsTipCli;
                ddlTipoCliente.DataBind();
                ddlTipoCliente.Items.Insert(0, new ListItem("Selecione...", "0"));

                ddlSituacao.DataSource = dsSitCli;
                ddlSituacao.DataBind();
                ddlSituacao.Items.Insert(0, new ListItem("Selecione...", "0"));

                grdWcfTest.DataSource = ds;
                grdWcfTest.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Operação Invalida!", "alert('" + ex.Message + "');", true);
            }
        }
        private void SaveClientes()
        {
            try
            {
                Clientes eDetails = new Clientes();
                eDetails.GetSetCLIE_NOME = txtNome.Text.Trim();
                eDetails.GetSetCLIE_CPF = txtCPF.Text.Trim();
                eDetails.GetSetCLIE_NASCIMENTO = Convert.ToDateTime(txtNascimento.Text);
                eDetails.GetSetCLIE_SEXO = ddlSexo.SelectedValue;
                eDetails.GetSetCLIE_FK_PK_SICL = Convert.ToInt32(ddlSituacao.SelectedValue);
                eDetails.GetSetCLIE_FK_PK_TICL = Convert.ToInt32(ddlTipoCliente.SelectedValue);
                lblStatus.Text = obj.InsertClientes(eDetails);
                BindClientes(null);
                ClearControls();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Operação Invalida!", "alert('" + ex.Message + "');", true);
            }
        }
        private void UpdateClientes()
        {
            try
            {
                Clientes eDetails = new Clientes();
                
                if (!ValidaCPF(txtCPF.Text.Trim()))
                    throw new Exception ("CPF invalido");

                eDetails.GetSetCLIE_PK_ID = Convert.ToInt32(ViewState["ID"].ToString());
                eDetails.GetSetCLIE_NOME = txtNome.Text.Trim();
                eDetails.GetSetCLIE_CPF = txtCPF.Text.Trim();
                eDetails.GetSetCLIE_NASCIMENTO = Convert.ToDateTime(txtNascimento.Text);
                eDetails.GetSetCLIE_SEXO = ddlSexo.SelectedValue;
                eDetails.GetSetCLIE_FK_PK_SICL = Convert.ToInt32(ddlSituacao.SelectedValue);
                eDetails.GetSetCLIE_FK_PK_TICL = Convert.ToInt32(ddlTipoCliente.SelectedValue);
                obj.UpdateClientes(eDetails);
                lblStatus.Text = obj.UpdateClientes(eDetails);
                BindClientes(null);
                ClearControls();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Operação Invalida!", "alert('" + ex.Message + "');", true);
            }
        }
        #endregion
        #region Page Event Handlers  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindClientes(null);
                ClearControls();
                lblStatus.Text = String.Empty;
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Atualizar")
            {
                UpdateClientes();
            }
            else
            {
                SaveClientes();
            }
        }
        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            try
            {
                Clientes eDetails = new Clientes();
                eDetails.GetSetCLIE_PK_ID = int.Parse(e.CommandArgument.ToString());
                ViewState["ID"] = eDetails.GetSetCLIE_PK_ID;
                DataSet ds = new DataSet();
                ds = obj.FetchUpdatedRecords(eDetails);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtNome.Text = ds.Tables[0].Rows[0]["CLIE_NOME"].ToString();
                    txtCPF.Text = ds.Tables[0].Rows[0]["CLIE_CPF"].ToString();
                    txtNascimento.Text = ds.Tables[0].Rows[0]["CLIE_NASCIMENTO"].ToString();
                    ddlSexo.SelectedValue = ds.Tables[0].Rows[0]["CLIE_SEXO"].ToString();
                    ddlSituacao.SelectedValue = ds.Tables[0].Rows[0]["CLIE_FK_PK_SICL"].ToString();
                    ddlTipoCliente.SelectedValue = ds.Tables[0].Rows[0]["CLIE_FK_PK_TICL"].ToString();
                    btnSubmit.Text = "Atualizar";
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Operação Invalida!", "alert('" + ex.Message + "');", true);
            }
        }
        protected void lnkDelete_Command(object sender, CommandEventArgs e)
        {
            try
            {
                Clientes eDetails = new Clientes();
                eDetails.GetSetCLIE_PK_ID = int.Parse(e.CommandArgument.ToString());
                if (obj.DeleteClientes(eDetails) == true)
                {
                    lblStatus.Text = "Registro excluido com sucesso";
                }
                else
                {
                    lblStatus.Text = "Não foi possível excluir o registro";
                }
                BindClientes(null);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Operação Invalida!", "alert('" + ex.Message + "');", true);
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            lblStatus.Text = string.Empty;
        }
        #endregion

        private static bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();
            if (cpf.Substring(9, 2) == digito)
                return true;


            return false;
        }
    }
}