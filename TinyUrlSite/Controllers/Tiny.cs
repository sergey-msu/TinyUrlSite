using System;
using NFX;
using NFX.DataAccess.CRUD;
using NFX.Wave.MVC;
using TinyUrlSite.Models;
using TinyUrlSite.Pages;

namespace TinyUrlSite.Controllers
{
    /// <summary>
    /// Main site controller
    /// </summary>
    public class Tiny : Controller
    {
        #region CONSTS

        private const string HTTP_PREFIX = "http://";
        private const string SHORTEN_URL_FORMAT = "http://{0}/Tiny/Away?id={1}";
        private const string MESSAGE_EMPTY_URL = "URL can not be empty";
        private const string MESSAGE_URL_NOT_FOUND = "ERROR: Requested shorten URL does not exist in database.";

        #endregion

        #region Public

        [Action]
        public object Index()
        {
            return new Index();
        }

        [Action]
        public object Shorten(string initialUrl)
        {
            if (initialUrl.IsNullOrWhiteSpace())
                return new Index { Message = MESSAGE_EMPTY_URL };

            var id = Guid.NewGuid().ToString("N");
            var urlMap = new UrlMap { Id = id, URL = initialUrl };
            SiteContext.DataStore.Insert(urlMap);

            var host = WorkContext.Request.UserHostName;
            var shortenUrl = SHORTEN_URL_FORMAT.Args(host, id);

            return new Index { InitialUrl = initialUrl, Message = shortenUrl, IsHyperlink = true };
        }

        [Action]
        public object Away(string id)
        {
            var query = new Query("Data.CRUD.GetUrlMap", typeof(UrlMap))
                            {
                                new Query.Param("id", id)
                            };
            var urlMap = SiteContext.DataStore.LoadOneRow(query) as UrlMap;
            if (urlMap != null && urlMap.URL != null)
            {
                if (!urlMap.URL.StartsWith(HTTP_PREFIX))
                    urlMap.URL = HTTP_PREFIX + urlMap.URL;

                return new Redirect(urlMap.URL);
            }

            return new Error { Message = MESSAGE_URL_NOT_FOUND };
        }

        #endregion
    }
}