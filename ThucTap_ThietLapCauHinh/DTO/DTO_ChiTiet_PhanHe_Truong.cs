using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTiet_PhanHe_Truong : DTO_Base
    {
        private int iDTruong;
        private int iDPhanHe;
        private string url;
        private string url_2;
        private string url_3;
        private string urlSocket;
        private string subAPI;
        private string subAPI_2;
        private string subAPI_3;
        private string ghiChu;
        private string warning_RequireSurvey;
        private string featuresRequireSurvey;
        private int versionEgovAPI;
        private string urlPayment;
        private int versionStudentAPI;
        private string warningMessage;
        private bool hasAds;
        private string websiteUrl;
        private int versionWeb;
        private bool useHTMLSalaryView;

        public int IDTruong { get => iDTruong; set => iDTruong = value; }
        public int IDPhanHe { get => iDPhanHe; set => iDPhanHe = value; }
        public string Url { get => url; set => url = value; }
        public string Url_2 { get => url_2; set => url_2 = value; }
        public string Url_3 { get => url_3; set => url_3 = value; }
        public string UrlSocket { get => urlSocket; set => urlSocket = value; }
        public string SubAPI { get => subAPI; set => subAPI = value; }
        public string SubAPI_2 { get => subAPI_2; set => subAPI_2 = value; }
        public string SubAPI_3 { get => subAPI_3; set => subAPI_3 = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string Warning_RequireSurvey { get => warning_RequireSurvey; set => warning_RequireSurvey = value; }
        public string FeaturesRequireSurvey { get => featuresRequireSurvey; set => featuresRequireSurvey = value; }
        public int VersionEgovAPI { get => versionEgovAPI; set => versionEgovAPI = value; }
        public string UrlPayment { get => urlPayment; set => urlPayment = value; }
        public int VersionStudentAPI { get => versionStudentAPI; set => versionStudentAPI = value; }
        public string WarningMessage { get => warningMessage; set => warningMessage = value; }
        public bool HasAds { get => hasAds; set => hasAds = value; }
        public string WebsiteUrl { get => websiteUrl; set => websiteUrl = value; }
        public int VersionWeb { get => versionWeb; set => versionWeb = value; }
        public bool UseHTMLSalaryView { get => useHTMLSalaryView; set => useHTMLSalaryView = value; }

        public DTO_ChiTiet_PhanHe_Truong()
        {

        }

        public DTO_ChiTiet_PhanHe_Truong(int id, int iDTruong, int iDPhanHe, string url, string url_2, string url_3, string urlSocket, string subAPI, string subAPI_2, string subAPI_3, string ghiChu, string warning_RequireSurvey, string featuresRequireSurvey, int versionEgovAPI, string urlPayment, int versionStudentAPI, string warningMessage, bool hasAds, string websiteUrl, int versionWeb, bool useHTMLSalaryView, string nguoiTao, DateTime ngayTao, string nguoiCapNhat, DateTime ngayCapNhat) : base(id, nguoiTao, ngayTao, nguoiCapNhat, ngayCapNhat)
        {
            IDTruong = iDTruong;
            IDPhanHe = iDPhanHe;
            Url = url;
            Url_2 = url_2;
            Url_3 = url_3;
            UrlSocket = urlSocket;
            SubAPI = subAPI;
            SubAPI_2 = subAPI_2;
            SubAPI_3 = subAPI_3;
            GhiChu = ghiChu;
            Warning_RequireSurvey = warning_RequireSurvey;
            FeaturesRequireSurvey = featuresRequireSurvey;
            VersionEgovAPI = versionEgovAPI;
            UrlPayment = urlPayment;
            VersionStudentAPI = versionStudentAPI;
            WarningMessage = warningMessage;
            HasAds = hasAds;
            WebsiteUrl = websiteUrl;
            VersionWeb = versionWeb;
            UseHTMLSalaryView = useHTMLSalaryView;
        }
    }
}
