using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace wyUpdate.Common
{
    public class MemoryClientFile : ClientFileBase
    {
        public MemoryClientFile(string companyName, string productName, string guid, string installedVersion, string serverSite, string selfUpdateSite)
        {
            // Oy
            CompanyName = companyName;
            // Sander
            ProductName = productName;           
            // 1116755f-8d79-45e3-a33b-17c8a77ecf81
            m_GUID = guid;
            // 1.0
            InstalledVersion = installedVersion;

            // http://dl.edonics.com/FVRO/Sander.wys
            AddUniqueString(serverSite, ServerFileSites);

            AddUniqueString(selfUpdateSite, ClientServerSites);
            CloseOnSuccess = true;
            

            HeaderImageAlign = ImageAlign.Fill;
            HeaderTextColorName = "White";
            HeaderTextIndent = 80;
            HideHeaderDivider = true;

            var language = new LanguageCulture("en-US");
            Languages.Add(language.Culture, language);

            // not needed as silent install
//            TopImage=
//                SideImage=

            // IFREQ:
            //            PublicSignKey = 
//            UpdatePassword =

        }
        string m_GUID;
        public override string GUID
        {
            get
            {
                return m_GUID;
            }
            set
            {
                m_GUID = value;
            }
        }


        public override void OpenObsoleteClientFile(string fileName)
        {
        
        }


        public override void LoadClientData(string filename)
        {

        }


        public override void OpenClientFile(string m_Filename, ClientLanguage lang, string forcedCulture, string updatePathVar, string customUrlArgs)
        {
        }

        public override void SaveClientFile(List<UpdateFile> files, string outputFilename)
        {
            
        }
    }
}