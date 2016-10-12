using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace wyUpdate.Common
{
    public abstract class ClientFileBase
    {
        public Hashtable Languages = new Hashtable();
        public string InstalledVersion;
        public UpdateOn CurrentlyUpdating = UpdateOn.DownloadingUpdate;
        public List<string> ServerFileSites = new List<string>(1);
        public List<string> ClientServerSites = new List<string>(1);
        public string CompanyName;
        public string ProductName;
        public ImageAlign HeaderImageAlign = ImageAlign.Left;
        public string HeaderTextColorName;
        public int HeaderTextIndent = -1;
        public bool HideHeaderDivider;
        public Image TopImage;
        public Image SideImage;
        public string TopImageFilename;
        public string SideImageFilename;
        public bool CloseOnSuccess;
        public string CustomWyUpdateTitle;
        public string PublicSignKey;
        public string UpdatePassword;
        public abstract string GUID { get; set; }
        public abstract void OpenObsoleteClientFile(string fileName);
        public abstract void LoadClientData(string filename);
        public abstract void OpenClientFile(string m_Filename, ClientLanguage lang, string forcedCulture, string updatePathVar, string customUrlArgs);
        public abstract void SaveClientFile(List<UpdateFile> files, string outputFilename);

        public static void AddUniqueString(string newString, List<string> list)
        {
            // if the string already exists, bail out
            foreach (string site in list)
                if (string.Equals(newString, site, StringComparison.OrdinalIgnoreCase))
                    return;

            // add the string
            list.Add(newString);
        }
    }
}