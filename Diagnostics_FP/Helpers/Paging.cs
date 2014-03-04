using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;

namespace Diagnostics_FP.Helpers
{
    public static class Paging
    {

        public static MvcHtmlString PagingNavigatorMBAnalysis(this HtmlHelper helper,
            int pageNum, int itemsCount, int pageSize, int linksPerPage,
            string activeSortOrder = "",
            string clinicMaterialFilter = "", 
            string sampleFilter = "", 
            string analysisFilter = "",
            string actionName = "MBAnalysisList")
        {
            StringBuilder sb = new StringBuilder();
            int pagesCount = (int)Math.Ceiling((double)itemsCount / pageSize);
            int startPage = pageNum / linksPerPage * linksPerPage;
            int visiblePages = startPage + linksPerPage
                <= pagesCount ? linksPerPage : pagesCount - startPage;
            sb.Append("Страница " + (int)(pageNum + 1) + " из " + pagesCount + ".    ");
            if (pageNum > 0)
            {

                sb.Append(helper.ActionLink(" |<< ", actionName,
                    new { pageNum = 0, sortOrder = activeSortOrder, 
                        clinicMaterialFilter = clinicMaterialFilter,
                    sampleFilter = sampleFilter,
                    analysisFilter = analysisFilter}));
                sb.Append(" ");
                int pageBackNum = pageNum - 1;
                if (pageBackNum >= 0)
                {
                    sb.Append(helper.ActionLink(" < ", actionName,
                        new
                        {
                            pageNum = pageBackNum,
                            sortOrder = activeSortOrder,
                            clinicMaterialFilter = clinicMaterialFilter,
                            sampleFilter = sampleFilter,
                            analysisFilter = analysisFilter
                        }));
                }
                else
                {
                    sb.Append(HttpUtility.HtmlEncode(" < "));
                }
            }
            else
            {
                sb.Append(HttpUtility.HtmlEncode(" |<<  < "));
            }

            sb.Append(" ");

            for (int i = 0; i < visiblePages; i++)
            {
                int currentPage = i + startPage;
                string currentPageText = (currentPage + 1).ToString();
                if (currentPage != pageNum)
                {
                    sb.Append(helper.ActionLink(currentPageText, actionName,
                        new
                        {
                            pageNum = currentPage,
                            sortOrder = activeSortOrder,
                            clinicMaterialFilter = clinicMaterialFilter,
                            sampleFilter = sampleFilter,
                            analysisFilter = analysisFilter
                        }));
                }
                else
                {
                    sb.Append(currentPageText);
                }
                sb.Append(" ");
            }
            if (pageNum < pagesCount - 1)
            {
                int pageNextNum = pageNum + 1;
                if (pageNextNum < pagesCount)
                {
                    sb.Append(helper.ActionLink(" > ", actionName,
                        new
                        {
                            pageNum = pageNextNum,
                            sortOrder = activeSortOrder,
                            clinicMaterialFilter = clinicMaterialFilter,
                            sampleFilter = sampleFilter,
                            analysisFilter = analysisFilter
                        }));
                }
                else
                {
                    sb.Append(HttpUtility.HtmlEncode(" > "));
                }
                sb.Append(" ");
                sb.Append(helper.ActionLink(">>|", actionName, new
                {
                    pageNum = (pagesCount - 1),
                    sortOrder = activeSortOrder,
                    clinicMaterialFilter = clinicMaterialFilter,
                    sampleFilter = sampleFilter,
                    analysisFilter = analysisFilter
                }));
            }
            else
            {
                sb.Append(HttpUtility.HtmlEncode(" >  >>| "));
            }
            return MvcHtmlString.Create(sb.ToString());
        }

        public static MvcHtmlString PagingNavigator(this HtmlHelper helper,
            int pageNum, int itemsCount, int pageSize, int linksPerPage, 
            string activeFilterString = "", string activeSortOrder = "",
            string actionName = "Index")
        {
            StringBuilder sb = new StringBuilder();
            int pagesCount = (int)Math.Ceiling((double)itemsCount / pageSize);
            int startPage = pageNum / linksPerPage * linksPerPage;
            int visiblePages = startPage + linksPerPage
                <= pagesCount ? linksPerPage : pagesCount - startPage;
            sb.Append("Страница " + (int)(pageNum + 1) + " из " + pagesCount + ".    ");
            if (pageNum > 0)
            {
              
                sb.Append(helper.ActionLink(" |<< ", actionName, 
                    new { pageNum = 0, sortOrder = activeSortOrder, currentFilter = activeFilterString  }));
                sb.Append(" ");
                int pageBackNum = pageNum - 1;
                if (pageBackNum >= 0)
                {
                    sb.Append(helper.ActionLink(" < ", actionName, 
                        new { pageNum = pageBackNum, sortOrder = activeSortOrder, currentFilter = activeFilterString }));
                }
                else
                {
                    sb.Append(HttpUtility.HtmlEncode(" < "));
                }
            }
            else
            {
                sb.Append(HttpUtility.HtmlEncode(" |<<  < "));
            }

            sb.Append(" ");

            for (int i = 0; i < visiblePages; i++)
            {
                int currentPage = i + startPage;
                string currentPageText = (currentPage + 1).ToString();
                if (currentPage != pageNum)
                {
                    sb.Append(helper.ActionLink(currentPageText, actionName, 
                        new { pageNum = currentPage, sortOrder = activeSortOrder, currentFilter = activeFilterString }));
                }
                else
                {
                    sb.Append(currentPageText);
                }
                sb.Append(" ");
                    }
            if (pageNum < pagesCount - 1)
            {
                int pageNextNum = pageNum + 1;
                if (pageNextNum < pagesCount)
                {
                    sb.Append(helper.ActionLink(" > ", actionName, 
                        new { pageNum = pageNextNum, sortOrder = activeSortOrder, currentFilter = activeFilterString }));
                }
                else
                {
                    sb.Append(HttpUtility.HtmlEncode(" > "));
                }
                sb.Append(" ");
                sb.Append(helper.ActionLink(">>|", actionName, new { pageNum = (pagesCount - 1), sortOrder = activeSortOrder, currentFilter = activeFilterString }));
            }
            else
            {
                sb.Append(HttpUtility.HtmlEncode(" >  >>| "));
            }
            return MvcHtmlString.Create(sb.ToString());
        }

        public static MvcHtmlString PagingNavigatorAJAX(this AjaxHelper helper,
            int pageNum, int itemsCount, int pageSize, int linksPerPage,
            string activeFilterString = "", string activeSortOrder = "",
            string actionName = "IndexAjax")
        {
            StringBuilder sb = new StringBuilder();
            AjaxOptions ao = new AjaxOptions();
            ao.UpdateTargetId = "divAntibioticTypesIndex"; 
            int pagesCount = (int)Math.Ceiling((double)itemsCount / pageSize);
            int startPage = pageNum / linksPerPage * linksPerPage;
            int visiblePages = startPage + linksPerPage
                <= pagesCount ? linksPerPage : pagesCount - startPage;
            sb.Append("Страница " + (int)(pageNum + 1) + " из " + pagesCount + ".    ");
            if (pageNum > 0)
            {

                sb.Append(helper.ActionLink(" |<< ", actionName,
                    new { pageNum = 0, sortOrder = activeSortOrder, currentFilter = activeFilterString }, ao));
                sb.Append(" ");
                int pageBackNum = pageNum - 1;
                if (pageBackNum >= 0)
                {
                    sb.Append(helper.ActionLink(" < ", actionName,
                        new { pageNum = pageBackNum, sortOrder = activeSortOrder, currentFilter = activeFilterString }, ao));
                }
                else
                {
                    sb.Append(HttpUtility.HtmlEncode(" < "));
                }
            }
            else
            {
                sb.Append(HttpUtility.HtmlEncode(" |<<  < "));
            }

            sb.Append(" ");

            for (int i = 0; i < visiblePages; i++)
            {
                int currentPage = i + startPage;
                string currentPageText = (currentPage + 1).ToString();
                if (currentPage != pageNum)
                {
                    sb.Append(helper.ActionLink(currentPageText, actionName,
                        new { pageNum = currentPage, sortOrder = activeSortOrder, currentFilter = activeFilterString }, ao));
                }
                else
                {
                    sb.Append(currentPageText);
                }
                sb.Append(" ");
            }
            if (pageNum < pagesCount - 1)
            {
                int pageNextNum = pageNum + 1;
                if (pageNextNum < pagesCount)
                {
                    sb.Append(helper.ActionLink(" > ", actionName,
                        new { pageNum = pageNextNum, sortOrder = activeSortOrder, currentFilter = activeFilterString }, ao));
                }
                else
                {
                    sb.Append(HttpUtility.HtmlEncode(" > "));
                }
                sb.Append(" ");
                sb.Append(helper.ActionLink(">>|", actionName, new { pageNum = (pagesCount - 1), sortOrder = activeSortOrder, currentFilter = activeFilterString }, ao));
            }
            else
            {
                sb.Append(HttpUtility.HtmlEncode(" >  >>| "));
            }
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}