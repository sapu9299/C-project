using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using firstform.DataConnection;
using System.Data;

namespace firstform
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            SalesmanDBconnection salesmandbconnectionobj = new SalesmanDBconnection();
            SalesmanModel salesmanmodel = new SalesmanModel();
            
            salesmanmodel.salesman_id = Convert.ToInt32(txtSalesmanId.Text);
           
            salesmanmodel.name = txtsalesman_name.Text;
            salesmanmodel.city = txtcity.Text;

            string msg = salesmandbconnectionobj.InsertSalesman(salesmanmodel);
            lblResult.Text = msg;

            DataTable dtResult = salesmandbconnectionobj.SelectSalesman();
            gvSalesmanDetails.DataSource = dtResult;
            gvSalesmanDetails.DataBind();


        }
    }
}