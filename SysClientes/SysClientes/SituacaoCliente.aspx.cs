using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysClientes.WcfSituacaoClientes;
using System.Data;

namespace SysClientes
{
    public partial class SituacaoClienteCrud : Page
    {
        #region Variable Declaration  
        ServiceSituacaoClienteClient obj = new ServiceSituacaoClienteClient();
        #endregion
        #region User Define Methods  
        private void ClearControls()
        {
            txtDescricao.Text = string.Empty;
            btnSubmit.Text = "Salvar";
            txtDescricao.Focus();
        }
        private void BindSituacaoClientes(int? Id)
        {
            SituacaoCliente eDetails = new SituacaoCliente();
            DataSet ds = new DataSet();
            ds = obj.GetSituacaoCliente(eDetails);
            grdWcfTest.DataSource = ds;
            grdWcfTest.DataBind();
        }
        private void SaveClientes()
        {
            SituacaoCliente eDetails = new SituacaoCliente();
            eDetails.GetSetSICL_DESCRICAO = txtDescricao.Text.Trim();
            lblStatus.Text = obj.InsertSituacaoCliente(eDetails);
            ClearControls();
            BindSituacaoClientes(null);
        }
        private void UpdateClientes()
        {
            SituacaoCliente eDetails = new SituacaoCliente();
            eDetails.GetSetSICL_PK_ID = Convert.ToInt32(ViewState["ID"].ToString());
            eDetails.GetSetSICL_DESCRICAO = txtDescricao.Text.Trim();
            obj.UpdateSituacaoCliente(eDetails);
            lblStatus.Text = obj.UpdateSituacaoCliente(eDetails);
            ClearControls();
            BindSituacaoClientes(null);
        }
        #endregion
        #region Page Event Handlers  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindSituacaoClientes(null);
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
            SituacaoCliente eDetails = new SituacaoCliente();
            eDetails.GetSetSICL_PK_ID = int.Parse(e.CommandArgument.ToString());
            ViewState["ID"] = eDetails.GetSetSICL_PK_ID;
            DataSet ds = new DataSet();
            ds = obj.FetchUpdatedRecords(eDetails);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtDescricao.Text = ds.Tables[0].Rows[0]["SICL_DESCRICAO"].ToString();
                btnSubmit.Text = "Atualizar";
            }
        }
        protected void lnkDelete_Command(object sender, CommandEventArgs e)
        {
            SituacaoCliente eDetails = new SituacaoCliente();
            eDetails.GetSetSICL_PK_ID = int.Parse(e.CommandArgument.ToString());
            if (obj.DeleteSituacaoCliente(eDetails) == true)
            {
                lblStatus.Text = "Registro excluido com sucesso";
            }
            else
            {
                lblStatus.Text = "Não foi possível excluir o registro";
            }
            BindSituacaoClientes(null);
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            lblStatus.Text = string.Empty;
        }
        #endregion
    }
}