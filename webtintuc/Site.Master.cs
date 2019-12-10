using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webtintuc.Models;

namespace webtintuc
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<tacgia> Gettacgia()
        {
            var _db = new webtintuc.Models.tintucContext();
            IQueryable<tacgia> query = _db.tacgia;
            return query;
        }
    }
}