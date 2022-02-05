using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tutorial.DataConnection;
using System.Data;

namespace tutorial
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTutorialData();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.TutorialId = Convert.ToInt32(txtTutorialId.Text);
            tutorialModel.TutorialName = txtTutorialName.Text;
            tutorialModel.TutorialDesc = txtTutorialDesc.Text;
            tutorialModel.Published = Convert.ToInt32(txtPublished.Text);

            string msg = tutorialDBConnectionObj.InsertTutorial(tutorialModel);
            lblResult.Text = msg;

            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {


        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            DataTable dtResult = tutorialDBConnectionObj.EditTutorialById(Convert.ToInt32(txtTutorialId.Text));
            txtTutorialName.Text = dtResult.Rows[0][1].ToString();
            txtTutorialDesc.Text = dtResult.Rows[0][2].ToString();
            txtPublished.Text = dtResult.Rows[0][3].ToString();
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.TutorialId = Convert.ToInt32(txtTutorialId.Text);
            tutorialModel.TutorialName = txtTutorialName.Text;
            tutorialModel.TutorialDesc = txtTutorialDesc.Text;
            tutorialModel.Published = Convert.ToInt32(txtPublished.Text);

            string msg = tutorialDBConnectionObj.UpdateTutorial(tutorialModel);
            lblResult.Text = msg;

            LoadTutorialData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            string msg = tutorialDBConnectionObj.DeleteTutorialById(Convert.ToInt32(txtTutorialId.Text));
            lblResult.Text = msg;

            LoadTutorialData();
        }
        public void LoadTutorialData()
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }
    }
}