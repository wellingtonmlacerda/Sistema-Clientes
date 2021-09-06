using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace WCF_CRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceCliente
    {
        //CLIENTES
        [OperationContract]
        string InsertClientes(Clientes eDatils);
        [OperationContract]
        DataSet GetClientes(Clientes eDatils);
        [OperationContract]
        DataSet FetchUpdatedRecords(Clientes eDatils);
        [OperationContract]
        string UpdateClientes(Clientes eDatils);
        [OperationContract]
        bool DeleteClientes(Clientes eDatils);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Clientes
    {
        int? CLIE_PK_ID;
        string CLIE_CPF = string.Empty;
        string CLIE_NOME = string.Empty;
        DateTime? CLIE_NASCIMENTO;
        string CLIE_SEXO = string.Empty;
        int? CLIE_FK_PK_TICL;
        int? CLIE_FK_PK_SICL;

        [DataMember]
        public int? GetSetCLIE_PK_ID
        {
            get { return CLIE_PK_ID; }
            set { CLIE_PK_ID = value; }
        }

        [DataMember]
        public string GetSetCLIE_CPF
        {
            get { return CLIE_CPF; }
            set { CLIE_CPF = value; }
        }
        [DataMember]
        public string GetSetCLIE_NOME
        {
            get { return CLIE_NOME; }
            set { CLIE_NOME = value; }
        }
        [DataMember]
        public DateTime? GetSetCLIE_NASCIMENTO
        {
            get { return CLIE_NASCIMENTO; }
            set { CLIE_NASCIMENTO = value; }
        }
        [DataMember]
        public string GetSetCLIE_SEXO
        {
            get { return CLIE_SEXO; }
            set { CLIE_SEXO = value; }
        }
        [DataMember]
        public int? GetSetCLIE_FK_PK_TICL
        {
            get { return CLIE_FK_PK_TICL; }
            set { CLIE_FK_PK_TICL = value; }
        }
        [DataMember]
        public int? GetSetCLIE_FK_PK_SICL
        {
            get { return CLIE_FK_PK_SICL; }
            set { CLIE_FK_PK_SICL = value; }
        }
    }
}
