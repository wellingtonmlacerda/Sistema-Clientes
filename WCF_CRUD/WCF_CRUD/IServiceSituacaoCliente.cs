using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceSituacaoCliente" in both code and config file together.
    [ServiceContract]
    public interface IServiceSituacaoCliente
    {
        //SITUAÇÃO DO CLIENTE
        [OperationContract]
        string InsertSituacaoCliente(SituacaoCliente eDatils);
        [OperationContract]
        DataSet GetSituacaoCliente(SituacaoCliente eDatils);
        [OperationContract]
        DataSet FetchUpdatedRecords(SituacaoCliente eDatils);
        [OperationContract]
        string UpdateSituacaoCliente(SituacaoCliente eDatils);
        [OperationContract]
        bool DeleteSituacaoCliente(SituacaoCliente eDatils);
    }
    [DataContract]
    public class SituacaoCliente
    {
        int? SICL_PK_ID;
        string SICL_DESCRICAO = string.Empty;

        [DataMember]
        public int? GetSetSICL_PK_ID
        {
            get { return SICL_PK_ID; }
            set { SICL_PK_ID = value; }
        }
        [DataMember]
        public string GetSetSICL_DESCRICAO
        {
            get { return SICL_DESCRICAO; }
            set { SICL_DESCRICAO = value; }
        }
    }
}
