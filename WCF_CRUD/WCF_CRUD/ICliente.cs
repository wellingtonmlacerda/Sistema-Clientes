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
    public interface ICliente
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

        ////SITUAÇÃO DO CLIENTE
        //string InsertSituacaoCliente(SituacaoCliente eDatils);
        //[OperationContract]
        //DataSet GetSituacaoCliente(SituacaoCliente eDatils);
        //[OperationContract]
        //DataSet FetchUpdatedRecords(SituacaoCliente eDatils);
        //[OperationContract]
        //string UpdateSituacaoCliente(SituacaoCliente eDatils);
        //[OperationContract]
        //bool DeleteSituacaoCliente(SituacaoCliente eDatils);

        ////TIPO DE CLIENTE
        //string InsertTipoCliente(TipoCliente eDatils);
        //[OperationContract]
        //DataSet GetTipoCliente(TipoCliente eDatils);
        //[OperationContract]
        //DataSet FetchUpdatedRecords(TipoCliente eDatils);
        //[OperationContract]
        //string UpdateTipoCliente(TipoCliente eDatils);
        //[OperationContract]
        //bool DeleteTipoCliente(TipoCliente eDatils);

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
    //[DataContract]
    //public class SituacaoCliente
    //{
    //    int? SICL_PK_ID;
    //    string SICL_DESCRICAO = string.Empty;
        
    //    [DataMember]
    //    public int? GetSetSICL_PK_ID
    //    {
    //        get { return SICL_PK_ID; }
    //        set { SICL_PK_ID = value; }
    //    }
    //    [DataMember]
    //    public string GetSetSICL_DESCRICAO
    //    {
    //        get { return SICL_DESCRICAO; }
    //        set { SICL_DESCRICAO = value; }
    //    }

    //}
    //[DataContract]
    //public class TipoCliente
    //{
    //    int? TICL_PK_ID;
    //    string TICL_TIPO = string.Empty;
    //    string TICL_DESCRICAO = string.Empty;

    //    [DataMember]
    //    public int? GetSetTICL_PK_ID
    //    {
    //        get { return TICL_PK_ID; }
    //        set { TICL_PK_ID = value; }
    //    }
    //    [DataMember]
    //    public string GetSetTICL_TIPO
    //    {
    //        get { return TICL_TIPO; }
    //        set { TICL_TIPO = value; }
    //    }
    //    [DataMember]
    //    public string GetSetTICL_DESCRICAO
    //    {
    //        get { return TICL_DESCRICAO; }
    //        set { TICL_DESCRICAO = value; }
    //    }
    //}
}
