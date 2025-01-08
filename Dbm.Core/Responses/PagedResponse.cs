using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Responses
{
    public class PagedResponse<T> : Response<T>
    {
        public int CurrentPage { get; set; } = Configuration.DefaultPageNumber;
        public int PageSize { get; set; } = Configuration.DefaultPageSize;
        public int TotalPages => TotalCount / PageSize;
        public int TotalCount { get; set; }
    }
}
