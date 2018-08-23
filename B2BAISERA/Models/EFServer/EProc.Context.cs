//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace B2BAISERA.Models.EFServer
{
    public partial class EProcEntities : ObjectContext
    {
        public const string ConnectionString = "name=EProcEntities";
        public const string ContainerName = "EProcEntities";
    
        #region Constructors
    
        public EProcEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public EProcEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public EProcEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<CUSTOM_DOWNLOAD_TRANSACTION> CUSTOM_DOWNLOAD_TRANSACTION
        {
            get { return _cUSTOM_DOWNLOAD_TRANSACTION  ?? (_cUSTOM_DOWNLOAD_TRANSACTION = CreateObjectSet<CUSTOM_DOWNLOAD_TRANSACTION>("CUSTOM_DOWNLOAD_TRANSACTION")); }
        }
        private ObjectSet<CUSTOM_DOWNLOAD_TRANSACTION> _cUSTOM_DOWNLOAD_TRANSACTION;
    
        public ObjectSet<CUSTOM_DOWNLOAD_TRANSACTIONDATA> CUSTOM_DOWNLOAD_TRANSACTIONDATA
        {
            get { return _cUSTOM_DOWNLOAD_TRANSACTIONDATA  ?? (_cUSTOM_DOWNLOAD_TRANSACTIONDATA = CreateObjectSet<CUSTOM_DOWNLOAD_TRANSACTIONDATA>("CUSTOM_DOWNLOAD_TRANSACTIONDATA")); }
        }
        private ObjectSet<CUSTOM_DOWNLOAD_TRANSACTIONDATA> _cUSTOM_DOWNLOAD_TRANSACTIONDATA;
    
        public ObjectSet<CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL> CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL
        {
            get { return _cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL  ?? (_cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL = CreateObjectSet<CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL>("CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL")); }
        }
        private ObjectSet<CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL> _cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL;
    
        public ObjectSet<CUSTOMBPKB> CUSTOMBPKBs
        {
            get { return _cUSTOMBPKBs  ?? (_cUSTOMBPKBs = CreateObjectSet<CUSTOMBPKB>("CUSTOMBPKBs")); }
        }
        private ObjectSet<CUSTOMBPKB> _cUSTOMBPKBs;
    
        public ObjectSet<CUSTOMIR> CUSTOMIRs
        {
            get { return _cUSTOMIRs  ?? (_cUSTOMIRs = CreateObjectSet<CUSTOMIR>("CUSTOMIRs")); }
        }
        private ObjectSet<CUSTOMIR> _cUSTOMIRs;
    
        public ObjectSet<CUSTOM_VENDOR_TRANSACTION> CUSTOM_VENDOR_TRANSACTION
        {
            get { return _cUSTOM_VENDOR_TRANSACTION  ?? (_cUSTOM_VENDOR_TRANSACTION = CreateObjectSet<CUSTOM_VENDOR_TRANSACTION>("CUSTOM_VENDOR_TRANSACTION")); }
        }
        private ObjectSet<CUSTOM_VENDOR_TRANSACTION> _cUSTOM_VENDOR_TRANSACTION;
    
        public ObjectSet<CUSTOM_S02002> CUSTOM_S02002
        {
            get { return _cUSTOM_S02002  ?? (_cUSTOM_S02002 = CreateObjectSet<CUSTOM_S02002>("CUSTOM_S02002")); }
        }
        private ObjectSet<CUSTOM_S02002> _cUSTOM_S02002;
    
        public ObjectSet<CUSTOM_S02007> CUSTOM_S02007
        {
            get { return _cUSTOM_S02007  ?? (_cUSTOM_S02007 = CreateObjectSet<CUSTOM_S02007>("CUSTOM_S02007")); }
        }
        private ObjectSet<CUSTOM_S02007> _cUSTOM_S02007;
    
        public ObjectSet<CUSTOM_LOG> CUSTOM_LOG
        {
            get { return _cUSTOM_LOG  ?? (_cUSTOM_LOG = CreateObjectSet<CUSTOM_LOG>("CUSTOM_LOG")); }
        }
        private ObjectSet<CUSTOM_LOG> _cUSTOM_LOG;
    
        public ObjectSet<CUSTOM_USER> CUSTOM_USER
        {
            get { return _cUSTOM_USER  ?? (_cUSTOM_USER = CreateObjectSet<CUSTOM_USER>("CUSTOM_USER")); }
        }
        private ObjectSet<CUSTOM_USER> _cUSTOM_USER;
    
        public ObjectSet<CUSTOMGR> CUSTOMGRs
        {
            get { return _cUSTOMGRs  ?? (_cUSTOMGRs = CreateObjectSet<CUSTOMGR>("CUSTOMGRs")); }
        }
        private ObjectSet<CUSTOMGR> _cUSTOMGRs;
    
        public ObjectSet<CUSTOMPO> CUSTOMPOes
        {
            get { return _cUSTOMPOes  ?? (_cUSTOMPOes = CreateObjectSet<CUSTOMPO>("CUSTOMPOes")); }
        }
        private ObjectSet<CUSTOMPO> _cUSTOMPOes;

        #endregion

        #region Function Imports
        public ObjectResult<Nullable<int>> sp_UpdateCustomPOStatusPOId(string pONUMBER, string pOSTATUSID)
        {
    
            ObjectParameter pONUMBERParameter;
    
            if (pONUMBER != null)
            {
                pONUMBERParameter = new ObjectParameter("PONUMBER", pONUMBER);
            }
            else
            {
                pONUMBERParameter = new ObjectParameter("PONUMBER", typeof(string));
            }
    
            ObjectParameter pOSTATUSIDParameter;
    
            if (pOSTATUSID != null)
            {
                pOSTATUSIDParameter = new ObjectParameter("POSTATUSID", pOSTATUSID);
            }
            else
            {
                pOSTATUSIDParameter = new ObjectParameter("POSTATUSID", typeof(string));
            }
            return base.ExecuteFunction<Nullable<int>>("sp_UpdateCustomPOStatusPOId", pONUMBERParameter, pOSTATUSIDParameter);
        }
        public ObjectResult<Nullable<int>> sp_UpdateS02002_HS(string pONUMBER, Nullable<int> vERSIONPOSERA, Nullable<int> dATAVERSION, string sTATUSPOSERA, string rEJECTREVISEDPOSERA, string dOCUMENTNO, string aIMATERIALNUMBER, string sERAMATERIALNUMBER, string sERAMATERIALDESCRIPTION, string aICOLOR, string sERACOLOR, string qUOTATIONNO)
        {
    
            ObjectParameter pONUMBERParameter;
    
            if (pONUMBER != null)
            {
                pONUMBERParameter = new ObjectParameter("PONUMBER", pONUMBER);
            }
            else
            {
                pONUMBERParameter = new ObjectParameter("PONUMBER", typeof(string));
            }
    
            ObjectParameter vERSIONPOSERAParameter;
    
            if (vERSIONPOSERA.HasValue)
            {
                vERSIONPOSERAParameter = new ObjectParameter("VERSIONPOSERA", vERSIONPOSERA);
            }
            else
            {
                vERSIONPOSERAParameter = new ObjectParameter("VERSIONPOSERA", typeof(int));
            }
    
            ObjectParameter dATAVERSIONParameter;
    
            if (dATAVERSION.HasValue)
            {
                dATAVERSIONParameter = new ObjectParameter("DATAVERSION", dATAVERSION);
            }
            else
            {
                dATAVERSIONParameter = new ObjectParameter("DATAVERSION", typeof(int));
            }
    
            ObjectParameter sTATUSPOSERAParameter;
    
            if (sTATUSPOSERA != null)
            {
                sTATUSPOSERAParameter = new ObjectParameter("STATUSPOSERA", sTATUSPOSERA);
            }
            else
            {
                sTATUSPOSERAParameter = new ObjectParameter("STATUSPOSERA", typeof(string));
            }
    
            ObjectParameter rEJECTREVISEDPOSERAParameter;
    
            if (rEJECTREVISEDPOSERA != null)
            {
                rEJECTREVISEDPOSERAParameter = new ObjectParameter("REJECTREVISEDPOSERA", rEJECTREVISEDPOSERA);
            }
            else
            {
                rEJECTREVISEDPOSERAParameter = new ObjectParameter("REJECTREVISEDPOSERA", typeof(string));
            }
    
            ObjectParameter dOCUMENTNOParameter;
    
            if (dOCUMENTNO != null)
            {
                dOCUMENTNOParameter = new ObjectParameter("DOCUMENTNO", dOCUMENTNO);
            }
            else
            {
                dOCUMENTNOParameter = new ObjectParameter("DOCUMENTNO", typeof(string));
            }
    
            ObjectParameter aIMATERIALNUMBERParameter;
    
            if (aIMATERIALNUMBER != null)
            {
                aIMATERIALNUMBERParameter = new ObjectParameter("AIMATERIALNUMBER", aIMATERIALNUMBER);
            }
            else
            {
                aIMATERIALNUMBERParameter = new ObjectParameter("AIMATERIALNUMBER", typeof(string));
            }
    
            ObjectParameter sERAMATERIALNUMBERParameter;
    
            if (sERAMATERIALNUMBER != null)
            {
                sERAMATERIALNUMBERParameter = new ObjectParameter("SERAMATERIALNUMBER", sERAMATERIALNUMBER);
            }
            else
            {
                sERAMATERIALNUMBERParameter = new ObjectParameter("SERAMATERIALNUMBER", typeof(string));
            }
    
            ObjectParameter sERAMATERIALDESCRIPTIONParameter;
    
            if (sERAMATERIALDESCRIPTION != null)
            {
                sERAMATERIALDESCRIPTIONParameter = new ObjectParameter("SERAMATERIALDESCRIPTION", sERAMATERIALDESCRIPTION);
            }
            else
            {
                sERAMATERIALDESCRIPTIONParameter = new ObjectParameter("SERAMATERIALDESCRIPTION", typeof(string));
            }
    
            ObjectParameter aICOLORParameter;
    
            if (aICOLOR != null)
            {
                aICOLORParameter = new ObjectParameter("AICOLOR", aICOLOR);
            }
            else
            {
                aICOLORParameter = new ObjectParameter("AICOLOR", typeof(string));
            }
    
            ObjectParameter sERACOLORParameter;
    
            if (sERACOLOR != null)
            {
                sERACOLORParameter = new ObjectParameter("SERACOLOR", sERACOLOR);
            }
            else
            {
                sERACOLORParameter = new ObjectParameter("SERACOLOR", typeof(string));
            }
    
            ObjectParameter qUOTATIONNOParameter;
    
            if (qUOTATIONNO != null)
            {
                qUOTATIONNOParameter = new ObjectParameter("QUOTATIONNO", qUOTATIONNO);
            }
            else
            {
                qUOTATIONNOParameter = new ObjectParameter("QUOTATIONNO", typeof(string));
            }
            return base.ExecuteFunction<Nullable<int>>("sp_UpdateS02002_HS", pONUMBERParameter, vERSIONPOSERAParameter, dATAVERSIONParameter, sTATUSPOSERAParameter, rEJECTREVISEDPOSERAParameter, dOCUMENTNOParameter, aIMATERIALNUMBERParameter, sERAMATERIALNUMBERParameter, sERAMATERIALDESCRIPTIONParameter, aICOLORParameter, sERACOLORParameter, qUOTATIONNOParameter);
        }
        public ObjectResult<Nullable<int>> sp_UpdateS02002_IS(string pONUMBER, Nullable<double> hARGADPP_INPUT, Nullable<double> hARGAPPNUNIT_INPUT, Nullable<double> hARGABBN_INPUT, string dONUMBER, Nullable<System.DateTime> dODATE, Nullable<System.DateTime> aCTUALDATEDELIVEREDUNIT, string nOCHASIS_INPUT, string nOENGINE_INPUT, string nOFAKTUR, Nullable<System.DateTime> tGLFAKTUR, string nOPOLISI_INPUT, Nullable<System.DateTime> tGLSTNK_INPUT, string nOSERTIFIKAT, Nullable<System.DateTime> tGLSERTIFIKAT, string nOFORMULIRA, Nullable<System.DateTime> tGLFORMULIRA, string nOSERTIFIKATREGUJITIPE, Nullable<System.DateTime> dATEDELIVERYTOBRANCHORVENDOR, string nOBPKB, string kETBPKB, Nullable<System.DateTime> rEVISEDATE, string sALESORDERNO, Nullable<bool> sALESORDERSTATUS, string cURRENCY, Nullable<int> yEAR, Nullable<bool> bILLINGSTATUS, string bSTKBNO, Nullable<System.DateTime> rEVISISTNK, string nAMAPENERIMA, string aLAMATPENERIMA)
        {
    
            ObjectParameter pONUMBERParameter;
    
            if (pONUMBER != null)
            {
                pONUMBERParameter = new ObjectParameter("PONUMBER", pONUMBER);
            }
            else
            {
                pONUMBERParameter = new ObjectParameter("PONUMBER", typeof(string));
            }
    
            ObjectParameter hARGADPP_INPUTParameter;
    
            if (hARGADPP_INPUT.HasValue)
            {
                hARGADPP_INPUTParameter = new ObjectParameter("HARGADPP_INPUT", hARGADPP_INPUT);
            }
            else
            {
                hARGADPP_INPUTParameter = new ObjectParameter("HARGADPP_INPUT", typeof(double));
            }
    
            ObjectParameter hARGAPPNUNIT_INPUTParameter;
    
            if (hARGAPPNUNIT_INPUT.HasValue)
            {
                hARGAPPNUNIT_INPUTParameter = new ObjectParameter("HARGAPPNUNIT_INPUT", hARGAPPNUNIT_INPUT);
            }
            else
            {
                hARGAPPNUNIT_INPUTParameter = new ObjectParameter("HARGAPPNUNIT_INPUT", typeof(double));
            }
    
            ObjectParameter hARGABBN_INPUTParameter;
    
            if (hARGABBN_INPUT.HasValue)
            {
                hARGABBN_INPUTParameter = new ObjectParameter("HARGABBN_INPUT", hARGABBN_INPUT);
            }
            else
            {
                hARGABBN_INPUTParameter = new ObjectParameter("HARGABBN_INPUT", typeof(double));
            }
    
            ObjectParameter dONUMBERParameter;
    
            if (dONUMBER != null)
            {
                dONUMBERParameter = new ObjectParameter("DONUMBER", dONUMBER);
            }
            else
            {
                dONUMBERParameter = new ObjectParameter("DONUMBER", typeof(string));
            }
    
            ObjectParameter dODATEParameter;
    
            if (dODATE.HasValue)
            {
                dODATEParameter = new ObjectParameter("DODATE", dODATE);
            }
            else
            {
                dODATEParameter = new ObjectParameter("DODATE", typeof(System.DateTime));
            }
    
            ObjectParameter aCTUALDATEDELIVEREDUNITParameter;
    
            if (aCTUALDATEDELIVEREDUNIT.HasValue)
            {
                aCTUALDATEDELIVEREDUNITParameter = new ObjectParameter("ACTUALDATEDELIVEREDUNIT", aCTUALDATEDELIVEREDUNIT);
            }
            else
            {
                aCTUALDATEDELIVEREDUNITParameter = new ObjectParameter("ACTUALDATEDELIVEREDUNIT", typeof(System.DateTime));
            }
    
            ObjectParameter nOCHASIS_INPUTParameter;
    
            if (nOCHASIS_INPUT != null)
            {
                nOCHASIS_INPUTParameter = new ObjectParameter("NOCHASIS_INPUT", nOCHASIS_INPUT);
            }
            else
            {
                nOCHASIS_INPUTParameter = new ObjectParameter("NOCHASIS_INPUT", typeof(string));
            }
    
            ObjectParameter nOENGINE_INPUTParameter;
    
            if (nOENGINE_INPUT != null)
            {
                nOENGINE_INPUTParameter = new ObjectParameter("NOENGINE_INPUT", nOENGINE_INPUT);
            }
            else
            {
                nOENGINE_INPUTParameter = new ObjectParameter("NOENGINE_INPUT", typeof(string));
            }
    
            ObjectParameter nOFAKTURParameter;
    
            if (nOFAKTUR != null)
            {
                nOFAKTURParameter = new ObjectParameter("NOFAKTUR", nOFAKTUR);
            }
            else
            {
                nOFAKTURParameter = new ObjectParameter("NOFAKTUR", typeof(string));
            }
    
            ObjectParameter tGLFAKTURParameter;
    
            if (tGLFAKTUR.HasValue)
            {
                tGLFAKTURParameter = new ObjectParameter("TGLFAKTUR", tGLFAKTUR);
            }
            else
            {
                tGLFAKTURParameter = new ObjectParameter("TGLFAKTUR", typeof(System.DateTime));
            }
    
            ObjectParameter nOPOLISI_INPUTParameter;
    
            if (nOPOLISI_INPUT != null)
            {
                nOPOLISI_INPUTParameter = new ObjectParameter("NOPOLISI_INPUT", nOPOLISI_INPUT);
            }
            else
            {
                nOPOLISI_INPUTParameter = new ObjectParameter("NOPOLISI_INPUT", typeof(string));
            }
    
            ObjectParameter tGLSTNK_INPUTParameter;
    
            if (tGLSTNK_INPUT.HasValue)
            {
                tGLSTNK_INPUTParameter = new ObjectParameter("TGLSTNK_INPUT", tGLSTNK_INPUT);
            }
            else
            {
                tGLSTNK_INPUTParameter = new ObjectParameter("TGLSTNK_INPUT", typeof(System.DateTime));
            }
    
            ObjectParameter nOSERTIFIKATParameter;
    
            if (nOSERTIFIKAT != null)
            {
                nOSERTIFIKATParameter = new ObjectParameter("NOSERTIFIKAT", nOSERTIFIKAT);
            }
            else
            {
                nOSERTIFIKATParameter = new ObjectParameter("NOSERTIFIKAT", typeof(string));
            }
    
            ObjectParameter tGLSERTIFIKATParameter;
    
            if (tGLSERTIFIKAT.HasValue)
            {
                tGLSERTIFIKATParameter = new ObjectParameter("TGLSERTIFIKAT", tGLSERTIFIKAT);
            }
            else
            {
                tGLSERTIFIKATParameter = new ObjectParameter("TGLSERTIFIKAT", typeof(System.DateTime));
            }
    
            ObjectParameter nOFORMULIRAParameter;
    
            if (nOFORMULIRA != null)
            {
                nOFORMULIRAParameter = new ObjectParameter("NOFORMULIRA", nOFORMULIRA);
            }
            else
            {
                nOFORMULIRAParameter = new ObjectParameter("NOFORMULIRA", typeof(string));
            }
    
            ObjectParameter tGLFORMULIRAParameter;
    
            if (tGLFORMULIRA.HasValue)
            {
                tGLFORMULIRAParameter = new ObjectParameter("TGLFORMULIRA", tGLFORMULIRA);
            }
            else
            {
                tGLFORMULIRAParameter = new ObjectParameter("TGLFORMULIRA", typeof(System.DateTime));
            }
    
            ObjectParameter nOSERTIFIKATREGUJITIPEParameter;
    
            if (nOSERTIFIKATREGUJITIPE != null)
            {
                nOSERTIFIKATREGUJITIPEParameter = new ObjectParameter("NOSERTIFIKATREGUJITIPE", nOSERTIFIKATREGUJITIPE);
            }
            else
            {
                nOSERTIFIKATREGUJITIPEParameter = new ObjectParameter("NOSERTIFIKATREGUJITIPE", typeof(string));
            }
    
            ObjectParameter dATEDELIVERYTOBRANCHORVENDORParameter;
    
            if (dATEDELIVERYTOBRANCHORVENDOR.HasValue)
            {
                dATEDELIVERYTOBRANCHORVENDORParameter = new ObjectParameter("DATEDELIVERYTOBRANCHORVENDOR", dATEDELIVERYTOBRANCHORVENDOR);
            }
            else
            {
                dATEDELIVERYTOBRANCHORVENDORParameter = new ObjectParameter("DATEDELIVERYTOBRANCHORVENDOR", typeof(System.DateTime));
            }
    
            ObjectParameter nOBPKBParameter;
    
            if (nOBPKB != null)
            {
                nOBPKBParameter = new ObjectParameter("NOBPKB", nOBPKB);
            }
            else
            {
                nOBPKBParameter = new ObjectParameter("NOBPKB", typeof(string));
            }
    
            ObjectParameter kETBPKBParameter;
    
            if (kETBPKB != null)
            {
                kETBPKBParameter = new ObjectParameter("KETBPKB", kETBPKB);
            }
            else
            {
                kETBPKBParameter = new ObjectParameter("KETBPKB", typeof(string));
            }
    
            ObjectParameter rEVISEDATEParameter;
    
            if (rEVISEDATE.HasValue)
            {
                rEVISEDATEParameter = new ObjectParameter("REVISEDATE", rEVISEDATE);
            }
            else
            {
                rEVISEDATEParameter = new ObjectParameter("REVISEDATE", typeof(System.DateTime));
            }
    
            ObjectParameter sALESORDERNOParameter;
    
            if (sALESORDERNO != null)
            {
                sALESORDERNOParameter = new ObjectParameter("SALESORDERNO", sALESORDERNO);
            }
            else
            {
                sALESORDERNOParameter = new ObjectParameter("SALESORDERNO", typeof(string));
            }
    
            ObjectParameter sALESORDERSTATUSParameter;
    
            if (sALESORDERSTATUS.HasValue)
            {
                sALESORDERSTATUSParameter = new ObjectParameter("SALESORDERSTATUS", sALESORDERSTATUS);
            }
            else
            {
                sALESORDERSTATUSParameter = new ObjectParameter("SALESORDERSTATUS", typeof(bool));
            }
    
            ObjectParameter cURRENCYParameter;
    
            if (cURRENCY != null)
            {
                cURRENCYParameter = new ObjectParameter("CURRENCY", cURRENCY);
            }
            else
            {
                cURRENCYParameter = new ObjectParameter("CURRENCY", typeof(string));
            }
    
            ObjectParameter yEARParameter;
    
            if (yEAR.HasValue)
            {
                yEARParameter = new ObjectParameter("YEAR", yEAR);
            }
            else
            {
                yEARParameter = new ObjectParameter("YEAR", typeof(int));
            }
    
            ObjectParameter bILLINGSTATUSParameter;
    
            if (bILLINGSTATUS.HasValue)
            {
                bILLINGSTATUSParameter = new ObjectParameter("BILLINGSTATUS", bILLINGSTATUS);
            }
            else
            {
                bILLINGSTATUSParameter = new ObjectParameter("BILLINGSTATUS", typeof(bool));
            }
    
            ObjectParameter bSTKBNOParameter;
    
            if (bSTKBNO != null)
            {
                bSTKBNOParameter = new ObjectParameter("BSTKBNO", bSTKBNO);
            }
            else
            {
                bSTKBNOParameter = new ObjectParameter("BSTKBNO", typeof(string));
            }
    
            ObjectParameter rEVISISTNKParameter;
    
            if (rEVISISTNK.HasValue)
            {
                rEVISISTNKParameter = new ObjectParameter("REVISISTNK", rEVISISTNK);
            }
            else
            {
                rEVISISTNKParameter = new ObjectParameter("REVISISTNK", typeof(System.DateTime));
            }
    
            ObjectParameter nAMAPENERIMAParameter;
    
            if (nAMAPENERIMA != null)
            {
                nAMAPENERIMAParameter = new ObjectParameter("NAMAPENERIMA", nAMAPENERIMA);
            }
            else
            {
                nAMAPENERIMAParameter = new ObjectParameter("NAMAPENERIMA", typeof(string));
            }
    
            ObjectParameter aLAMATPENERIMAParameter;
    
            if (aLAMATPENERIMA != null)
            {
                aLAMATPENERIMAParameter = new ObjectParameter("ALAMATPENERIMA", aLAMATPENERIMA);
            }
            else
            {
                aLAMATPENERIMAParameter = new ObjectParameter("ALAMATPENERIMA", typeof(string));
            }
            return base.ExecuteFunction<Nullable<int>>("sp_UpdateS02002_IS", pONUMBERParameter, hARGADPP_INPUTParameter, hARGAPPNUNIT_INPUTParameter, hARGABBN_INPUTParameter, dONUMBERParameter, dODATEParameter, aCTUALDATEDELIVEREDUNITParameter, nOCHASIS_INPUTParameter, nOENGINE_INPUTParameter, nOFAKTURParameter, tGLFAKTURParameter, nOPOLISI_INPUTParameter, tGLSTNK_INPUTParameter, nOSERTIFIKATParameter, tGLSERTIFIKATParameter, nOFORMULIRAParameter, tGLFORMULIRAParameter, nOSERTIFIKATREGUJITIPEParameter, dATEDELIVERYTOBRANCHORVENDORParameter, nOBPKBParameter, kETBPKBParameter, rEVISEDATEParameter, sALESORDERNOParameter, sALESORDERSTATUSParameter, cURRENCYParameter, yEARParameter, bILLINGSTATUSParameter, bSTKBNOParameter, rEVISISTNKParameter, nAMAPENERIMAParameter, aLAMATPENERIMAParameter);
        }

        #endregion

    }
}
