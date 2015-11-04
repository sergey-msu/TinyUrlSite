using NFX.DataAccess.CRUD;

namespace TinyUrlSite.Models
{
    [Table(name: "UrlMap")]
    public class UrlMap : TypedRow
    {
        [Field(key: true)]
        public string Id { get; set; }
                  
        [Field]
        public string URL { get; set; }
    }
}