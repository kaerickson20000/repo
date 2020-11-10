using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Add this for Input & Output
using System.IO;

namespace ExcelProject
{
    public partial class UploadMultipleImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // On the page load ----- > At Start up ....
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            // Upload single image here ....
            // ----------------------------------------------------------------------------

            //string filename = Path.GetFileName(FileUploadJquery.PostedFile.FileName);
            //if (filename != "")
            //{
            //    FileUploadJquery.SaveAs(Server.MapPath("~/Multiple_Photo/" + filename));
            //    lblMessage.Text = "Your file uploaded successfully ...";
            //    lblMessage.ForeColor = System.Drawing.Color.Green;
            //}
            //else {
            //    lblMessage.Text = "Your file not uploaded";
            //    lblMessage.ForeColor = System.Drawing.Color.Red;
            //}

            if (FileUploadJquery.HasFile == false)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "key", "<script>alert('No File Uploaded.')</script>", false);
            }
            else
            {
                foreach (var file in FileUploadJquery.PostedFiles)
                {
                    // string filename = Path.GetFileName(fileuploadimages.PostedFile.FileName);
                    string filename = Path.GetFileName(file.FileName);
                    // fileuploadimages.SaveAs(Server.MapPath("~/Multiple_Photo/" + filename));
                    file.SaveAs(Server.MapPath("./Multiple_Photo/" + filename));
                }
                lblMessage.Text = "Your file uploaded successfully ...";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }

        }
    }
}