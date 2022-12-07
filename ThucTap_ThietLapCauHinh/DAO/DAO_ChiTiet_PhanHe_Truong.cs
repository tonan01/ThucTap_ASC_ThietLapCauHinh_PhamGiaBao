using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_ChiTiet_PhanHe_Truong
    {
        ThietLapCauHinhDataContext db = new ThietLapCauHinhDataContext();
        #region Xử lý
        //Thêm
        public bool Them(DTO_ChiTiet_PhanHe_Truong pPHT)
        {
            try
            {
                db.sp_Them_Truong_PhanHe(pPHT.IDTruong, pPHT.IDPhanHe, pPHT.Url, pPHT.Url_2, pPHT.Url_3, pPHT.UrlSocket, pPHT.SubAPI,
                    pPHT.SubAPI_2, pPHT.SubAPI_3, pPHT.GhiChu, pPHT.Warning_RequireSurvey, pPHT.FeaturesRequireSurvey, pPHT.VersionEgovAPI,
                    pPHT.UrlPayment, pPHT.VersionStudentAPI, pPHT.WarningMessage, pPHT.HasAds, pPHT.WebsiteUrl, pPHT.VersionWeb,
                    pPHT.UseHTMLSalaryView);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //sửa
        public bool Sua(DTO_ChiTiet_PhanHe_Truong pPHT)
        {
            try
            {
                db.sp_Sua_Truong_PhanHe(pPHT.Id, pPHT.IDTruong, pPHT.IDPhanHe, pPHT.Url, pPHT.Url_2, pPHT.Url_3, pPHT.UrlSocket, pPHT.SubAPI,
                    pPHT.SubAPI_2, pPHT.SubAPI_3, pPHT.GhiChu, pPHT.Warning_RequireSurvey, pPHT.FeaturesRequireSurvey, pPHT.VersionEgovAPI,
                    pPHT.UrlPayment, pPHT.VersionStudentAPI, pPHT.WarningMessage, pPHT.HasAds, pPHT.WebsiteUrl, pPHT.VersionWeb,
                    pPHT.UseHTMLSalaryView);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Xóa
        public bool Xoa(int pId)
        {
            try
            {
                db.sp_Xoa_Truong_PhanHe(pId);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}

