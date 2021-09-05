using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysClientes.WcfTipoCliente;
using System.Data;

namespace SysClientes
{
    public partial class About : Page
    {
        #region Variable Declaration  
        ClienteClient obj = new ClienteClient();
        #endregion
        #region User Define Methods  
        private void ClearControls()
        {
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtNascimento.Text = string.Empty;
            txtSexo.Text = string.Empty;
            txtSituacao.Text = string.Empty;
            txtTipo.Text = string.Empty;
            btnSubmit.Text = "Salvar";
            txtNome.Focus();
        }
        private void BindClientes(int? Id)
        {
            Clientes eDetails = new Clientes();
            DataSet ds = new DataSet();
            ds = obj.GetClientes(eDetails);
            grdWcfTest.DataSource = ds;
            grdWcfTest.DataBind();
        }
        private void SaveClientes()
        {
            Clientes eDetails = new Clientes();
            eDetails.GetSetCLIE_NOME = txtNome.Text.Trim();
            eDetails.GetSetCLIE_CPF = txtCPF.Text.Trim();
            eDetails.GetSetCLIE_NASCIMENTO = Convert.ToDateTime(txtNascimento.Text);
            eDetails.GetSetCLIE_SEXO = txtSexo.Text.Trim();
            eDetails.GetSetCLIE_FK_PK_SICL = Convert.ToInt32(txtSituacao.Text.Trim());
            eDetails.GetSetCLIE_FK_PK_TICL = Convert.ToInt32(txtTipo.Text.Trim());
            lblStatus.Text = obj.InsertClientes(eDetails);
            ClearControls();
            BindClientes(null);
        }
        private void UpdateClientes()
        {
            Clientes eDetails = new Clientes();
            eDetails.GetSetCLIE_PK_ID = Convert.ToInt32(ViewState["ID"].ToString());
            eDetails.GetSetCLIE_NOME = txtNome.Text.Trim();
            eDetails.GetSetCLIE_CPF = txtCPF.Text.Trim();
            eDetails.GetSetCLIE_NASCIMENTO = Convert.ToDateTime(txtNascimento.Text);
            eDetails.GetSetCLIE_SEXO = txtSexo.Text.Trim();
            eDetails.GetSetCLIE_FK_PK_SICL = Convert.ToInt32(txtSituacao.Text.Trim());
            eDetails.GetSetCLIE_FK_PK_TICL = Convert.ToInt32(txtTipo.Text.Trim());
            obj.UpdateClientes(eDetails);
            lblStatus.Text = obj.UpdateClientes(eDetails);
            ClearControls();
            BindClientes(null);
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
                txtSexo.Text = ds.Tables[0].Rows[0]["CLIE_SEXO"].ToString();
                txtSituacao.Text = ds.Tables[0].Rows[0]["CLIE_FK_PK_SICL"].ToString();
                txtTipo.Text = ds.Tables[0].Rows[0]["CLIE_FK_PK_TICL"].ToString();
                btnSubmit.Text = "Atualizar";
            }
        }
        protected void lnkDelete_Command(object sender, CommandEventArgs e)
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
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            lblStatus.Text = string.Empty;
        }
        #endregion
    }
}