using NFX.DataAccess.CRUD;

namespace TinyUrlSite.Models
{
    public class UrlMap : TypedRow
    {
        [Field(key: true, required: true)]
        public long Id { get; set; }
                  
        [Field(required: true)]
        public string URL { get; set; }
    }
}