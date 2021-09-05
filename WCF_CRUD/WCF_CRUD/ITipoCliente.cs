﻿using System;
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
    public interface ITipoCliente
    {

        //TIPO DE CLIENTE
        string InsertTipoCliente(TipoCliente eDatils);
        [OperationContract]
        DataSet GetTipoCliente(TipoCliente eDatils);
        [OperationContract]
        DataSet FetchUpdatedRecords(TipoCliente eDatils);
        [OperationContract]
        string UpdateTipoCliente(TipoCliente eDatils);
        [OperationContract]
        bool DeleteTipoCliente(TipoCliente eDatils);

        // TODO: Add your service operations here
    }


    [DataContract]
    public class TipoCliente
    {
        int? TICL_PK_ID;
        string TICL_TIPO = string.Empty;
        string TICL_DESCRICAO = string.Empty;

        [DataMember]
        public int? GetSetTICL_PK_ID
        {
            get { return TICL_PK_ID; }
            set { TICL_PK_ID = value; }
        }
        [DataMember]
        public string GetSetTICL_TIPO
        {
            get { return TICL_TIPO; }
            set { TICL_TIPO = value; }
        }
        [DataMember]
        public string GetSetTICL_DESCRICAO
        {
            get { return TICL_DESCRICAO; }
            set { TICL_DESCRICAO = value; }
        }
    }
}
