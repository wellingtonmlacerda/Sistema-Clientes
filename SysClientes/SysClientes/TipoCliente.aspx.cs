using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SysClientes.WcfTipoCliente;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SysClientes
{
    public partial class TipoClienteCrud : Page
    {
        #region Variable Declaration  
        ServiceTipoClienteClient obj = new ServiceTipoClienteClient();
        #endregion
        #region User Define Methods  
        private void ClearControls()
        {
            txtTipo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            btnSubmit.Text = "Salvar";
            txtTipo.Focus();
        }
        private void BindClientes(int? Id)
        {
            try
            {
                TipoCliente eDetails = new TipoCliente();
                DataSet ds = new DataSet();
                ds = obj.GetTipoCliente(eDetails);
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
                TipoCliente eDetails = new TipoCliente();
                eDetails.GetSetTICL_TIPO = txtTipo.Text.Trim();
                eDetails.GetSetTICL_DESCRICAO = txtDescricao.Text.Trim();
                lblStatus.Text = obj.InsertTipoCliente(eDetails);
                ClearControls();
                BindClientes(null);
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
                TipoCliente eDetails = new TipoCliente();
                eDetails.GetSetTICL_PK_ID = Convert.ToInt32(ViewState["ID"].ToString());
                eDetails.GetSetTICL_TIPO = txtTipo.Text.Trim();
                eDetails.GetSetTICL_DESCRICAO = txtDescricao.Text.Trim();
                obj.UpdateTipoCliente(eDetails);
                lblStatus.Text = obj.UpdateTipoCliente(eDetails);
                ClearControls();
                BindClientes(null);
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
                TipoCliente eDetails = new TipoCliente();
                eDetails.GetSetTICL_PK_ID = int.Parse(e.CommandArgument.ToString());
                ViewState["ID"] = eDetails.GetSetTICL_PK_ID;
                DataSet ds = new DataSet();
                ds = obj.FetchUpdatedRecords(eDetails);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtTipo.Text = ds.Tables[0].Rows[0]["TICL_TIPO"].ToString();
                    txtDescricao.Text = ds.Tables[0].Rows[0]["TICL_DESCRICAO"].ToString();
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
                TipoCliente eDetails = new TipoCliente();
                eDetails.GetSetTICL_PK_ID = int.Parse(e.CommandArgument.ToString());
                if (obj.DeleteTipoCliente(eDetails) == true)
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
    }
}