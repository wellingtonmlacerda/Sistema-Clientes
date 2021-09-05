using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WCF_CRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICliente
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

        public string InsertClientes(Clientes eDetails)
        {
            string Status;
            SqlCommand cmd = new SqlCommand("CLIENTE_INSERT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CPF", eDetails.GetSetCLIE_CPF);
            cmd.Parameters.AddWithValue("@NOME", eDetails.GetSetCLIE_NOME);
            cmd.Parameters.AddWithValue("@NASCIMENTO", eDetails.GetSetCLIE_NASCIMENTO);
            cmd.Parameters.AddWithValue("@SEXO", eDetails.GetSetCLIE_SEXO);
            cmd.Parameters.AddWithValue("@TIPO_CLIENTE", eDetails.GetSetCLIE_FK_PK_TICL);
            cmd.Parameters.AddWithValue("@SITUACAO_CLIENTE", eDetails.GetSetCLIE_FK_PK_SICL);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status = eDetails.GetSetCLIE_NOME + " salvo com sucesso";
            }
            else
            {
                Status = eDetails.GetSetCLIE_NOME + " não foi possível salvar o registro";
            }
            con.Close();
            return Status;
        }

        public DataSet GetClientes(Clientes eDetails)
        {
            SqlCommand cmd = new SqlCommand("CLIENTE_LISTA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetCLIE_PK_ID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
        public DataSet FetchUpdatedRecords(Clientes eDetails)
        {
            SqlCommand cmd = new SqlCommand("CLIENTE_LISTA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetCLIE_PK_ID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
        public string UpdateClientes(Clientes eDetails)
        {
            string Status;
            SqlCommand cmd = new SqlCommand("CLIENTE_UPDATE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetCLIE_PK_ID);
            cmd.Parameters.AddWithValue("@CPF", eDetails.GetSetCLIE_CPF);
            cmd.Parameters.AddWithValue("@NOME", eDetails.GetSetCLIE_NOME);
            cmd.Parameters.AddWithValue("@NASCIMENTO", eDetails.GetSetCLIE_NASCIMENTO);
            cmd.Parameters.AddWithValue("@SEXO", eDetails.GetSetCLIE_SEXO);
            cmd.Parameters.AddWithValue("@TIPO_CLIENTE", eDetails.GetSetCLIE_FK_PK_TICL);
            cmd.Parameters.AddWithValue("@SITUACAO_CLIENTE", eDetails.GetSetCLIE_FK_PK_SICL);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status = "Registro atualizado com sucesso";
            }
            else
            {
                Status = "Não foi possível atualizar o registro";
            }
            con.Close();
            return Status;
        }
        public bool DeleteClientes(Clientes eDetails)
        {
            SqlCommand cmd = new SqlCommand("CLIENTE_DELETE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetCLIE_PK_ID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public string InsertTipoCliente(TipoCliente eDetails)
        {
            string Status;
            SqlCommand cmd = new SqlCommand("TIPO_CLIENTE_INSERT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TIPO", eDetails.GetSetTICL_TIPO);
            cmd.Parameters.AddWithValue("@DESCRICAO", eDetails.GetSetTICL_DESCRICAO);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status = eDetails.GetSetTICL_DESCRICAO + " salvo com sucesso";
            }
            else
            {
                Status = eDetails.GetSetTICL_DESCRICAO + " não foi possível salvar o registro";
            }
            con.Close();
            return Status;
        }

        public DataSet GetTipoCliente(TipoCliente eDetails)
        {
            SqlCommand cmd = new SqlCommand("TIPO_CLIENTES_LISTA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetTICL_PK_ID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
        public DataSet FetchUpdatedRecords(TipoCliente eDetails)
        {
            SqlCommand cmd = new SqlCommand("TIPO_CLIENTES_LISTA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetTICL_PK_ID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
        public string UpdateTipoCliente(TipoCliente eDetails)
        {
            string Status;
            SqlCommand cmd = new SqlCommand("TIPO_CLIENTE_UPDATE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetTICL_PK_ID);
            cmd.Parameters.AddWithValue("@TIPO", eDetails.GetSetTICL_TIPO);
            cmd.Parameters.AddWithValue("@DESCRICAO", eDetails.GetSetTICL_DESCRICAO);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status = "Registro atualizado com sucesso";
            }
            else
            {
                Status = "Não foi possível atualizar o registro";
            }
            con.Close();
            return Status;
        }
        public bool DeleteTipoCliente(TipoCliente eDetails)
        {
            SqlCommand cmd = new SqlCommand("TIPO_CLIENTE_DELETE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", eDetails.GetSetTICL_PK_ID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
