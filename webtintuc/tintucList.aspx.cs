using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webtintuc.Models;
using System.Web.ModelBinding;

namespace webtintuc
{
    public partial class tintucList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<tintuc> Gettintuc([QueryString("id")] int? tacgiaId)
        {
            var _db = new webtintuc.Models.tintucContext();
            IQueryable<tintuc> query = _db.tintucs;
            if (tacgiaId.HasValue && tacgiaId > 0)
            {
                query = query.Where(p => p.tacgiaID == tacgiaId);
            }
            return query;
        }
    }
}