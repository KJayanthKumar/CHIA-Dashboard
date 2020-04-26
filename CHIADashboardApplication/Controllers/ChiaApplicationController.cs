using CHIADashboardApplication.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.DirectoryServices;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI;

namespace CHIADashboardApplication.Controllers
{
    public class ChiaApplicationController : Controller
    {
        public Rootobject Rootobjectdetails = null;
        public static List<ChiaIssueDetails> listIssues = null;
        public static List<SelectListItem> DeptList = null;
        public static string[] SelectedDept = new string[4];
        public ChiaIssueDetails chiaobj = null;
        public ChiaDetails chia = null;
        public static string user = null;
        public static string pwd = null;
        public static string from = null;
        public static string to = null;
        public static int Getdata = 0;
        public static string ErrorMessage=" ";

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","ChiaApplication");
        }

        public ActionResult GetChia(LoginModel login)
        {
            try
            {
                if (ModelState.IsValid && login.UserName != " " && login.Password != " ")
                {
                    var directoryEntry = new DirectoryEntry("LDAP://corpdcberl01.northamerica.cerner.net");
                    directoryEntry.Username = login.UserName;
                    directoryEntry.Password = login.Password;
                    var directorySearcher = new DirectorySearcher(directoryEntry);
                    SearchResult result = directorySearcher.FindOne();
                    user = login.UserName;
                    pwd = login.Password;
                    FormsAuthentication.SetAuthCookie(user, false);
                    Session["userName"] = user;
                    ErrorMessage = " ";
                    from = DateTime.Today.AddDays(-180).ToString("yyyy-MM-dd");
                    to = DateTime.Now.ToString("yyyy-MM-dd");
                    DeptList = new List<SelectListItem>();
                    GetDeptList(ref DeptList);
                    ViewBag.DeptList = DeptList;
                    SelectedDept[0] = "General_Laboratory";
                    ViewBag.SelectedDept = SelectedDept;

                    Getdata = 1;
                    return Redirect("~/ChiaApplication/GetChiaList");
                }
                else
                {
                    TempData["ErrorMessage"] = "UserName or Password cannot be Empty!";
                    return Redirect("~/ChiaApplication/Login");
                }
            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = e.Message;
                return Redirect("~/ChiaApplication/Login");
            }
        }

        [HttpPost]
        public ActionResult SaveComments(string key ,string comment)
        {
            var results = listIssues.Where(x => x.key == key).FirstOrDefault();
            results.comment = comment;
            chia = new ChiaDetails();
            chia.issueInfo = listIssues;
            ViewBag.From = from;
            ViewBag.To = to;
            ViewBag.DeptList = DeptList;
            ViewBag.SelectedDept = SelectedDept;
            using (OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="
                    + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data\\CommentsDB.accdb")))
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE CHIAComments SET Comments = ? WHERE key = ?";
                    cmd.Parameters.Add("@p1", OleDbType.VarChar).Value = comment;
                    cmd.Parameters.Add("@p2", OleDbType.VarChar).Value = key;
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    TempData["ErrorMessage"] = ErrorMessage = e.Message;
                }
            }
            return View(chia);
        }

        public ActionResult GetChiaList()
        {
            if (Session["userName"] != null)
            {
                if (Getdata == 1)
                {
                    try
                    {
                        Getdata = 0;
                        return View("GetChiaList", GettingCHIAIssues());
                    }
                    catch (Exception e)
                    {
                        TempData["ErrorMessage"] = "Error in fetching data Check your internet connection and try again ";
                        return View("GetChiaList");
                    }
                }
                else
                {
                    chia = new ChiaDetails();
                    chia.issueInfo = listIssues;
                    chia.DeptList = DeptList;
                    ViewBag.From = from;
                    ViewBag.To = to;
                    ViewBag.DeptList = DeptList;
                    ViewBag.SelectedDept = SelectedDept;

                    return View(chia);
                }
            }
            else
                return View("Login");
        }

        [HttpPost]
        public ActionResult Submit(DateTime? FromDate, DateTime? ToDate, string[] SelDept)
        {
            if (FromDate != null && ToDate != null && SelDept.Length!=0)
            {
                SelectedDept = SelDept;
                from = Convert.ToDateTime(FromDate).ToString("yyyy/MM/dd");
                to = Convert.ToDateTime(ToDate).ToString("yyyy/MM/dd");
                Getdata = 1;
                return Redirect("~/ChiaApplication/GetChiaList");
            }
            else
            {
                ViewBag.DeptList = DeptList;
                ViewBag.SelectedDept = SelectedDept;
                TempData["ErrorMessage"] = "Please select the Originating Team and enter the Vaild dates!";
                return View("GetChiaList");
            }
        }

        public ChiaDetails GettingCHIAIssues()
        {
            Dictionary<string, string> CommentDict = new Dictionary<string, string>();
            ViewBag.From = from;
            ViewBag.To = to;
            ViewBag.DeptList = DeptList;
            ViewBag.SelectedDept = SelectedDept;
            string teams = "(";
            for (int k=0;k<SelectedDept.Length;k++)
            {
                if(SelectedDept[k]!=null)
                { 
                    if (k > 0)
                        teams = teams + " OR ";
                    teams = teams + "\"Originating Team\" ~ "+SelectedDept[k];
                }
            }
            teams = teams + ")";
            string url = "https://jira3.cerner.com/rest/api/2/search?jql=project = CHIA AND issuetype = Assessment AND createdDate >=" + "'" + from + "'" + " AND createdDate<=" + "'" + to + "'" + " AND Assessment = \"CHIA Required\" AND status != Reviewed AND "+teams+" &maxResults=1000";
            WebRequest myReq = WebRequest.Create(url);
            string credentials = user + ":" + pwd;
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();
            Rootobjectdetails = JsonConvert.DeserializeObject<Rootobject>(content);
            getComments(ref CommentDict);
            listIssues = new List<ChiaIssueDetails>();
            for (int i = 0; i < Rootobjectdetails.issues.Length; i++)
            {
                Dictionary<string, string> CRList = new Dictionary<string, string>();
                chiaobj = new ChiaIssueDetails();
                chiaobj.key = Rootobjectdetails.issues[i].key;
                chiaobj.summary = Rootobjectdetails.issues[i].fields.summary.ToString();
                chiaobj.createdDate = Rootobjectdetails.issues[i].fields.created.Date.ToShortDateString();
                chiaobj.status = Rootobjectdetails.issues[i].fields.status.name.ToString();
                chiaobj.CHIA_Id = Rootobjectdetails.issues[i].fields.customfield_13331 == null ? "NA" : Rootobjectdetails.issues[i].fields.customfield_13331.ToString();
                chiaobj.compliance_Analyst = Rootobjectdetails.issues[i].fields.customfield_13310 == null ? "NA" : Rootobjectdetails.issues[i].fields.customfield_13310.displayName.ToString();
                chiaobj.age = (int)Math.Floor((DateTime.Now - Rootobjectdetails.issues[i].fields.created.Date).TotalDays);
                getremotelinks(chiaobj.key.ToString(), ref CRList);

                var results = CommentDict.Where(x => x.Key == chiaobj.key).FirstOrDefault();
                if(results.Key != null)
                {
                    chiaobj.comment = results.Value;
                }
                else
                {
                    createDatabaseEntry(chiaobj.key);
                }

                if (CRList.Count == 0)
                {
                    chiaobj.CHIA_CR = "";
                    chiaobj.CR_url = "";
                }
                else
                {
                    foreach (var obj in CRList)
                    {
                        chiaobj.CHIA_CR = obj.Key;
                        chiaobj.CR_url = obj.Value;
                    }
                }
                listIssues.Add(chiaobj);
            }
            chia = new ChiaDetails();
            listIssues = listIssues.OrderByDescending(o => o.status).ThenBy(o => o.createdDate).ToList();
            chia.issueInfo = listIssues;
            return chia;
        }

        public void getremotelinks(string CHIA, ref Dictionary<string, string> CRList)
        {
            Object1 Rootobjectdetails1 = null;
            string url = "https://jira3.cerner.com/rest/api/2/issue/" + CHIA + "/remotelink";
            WebRequest myReq = WebRequest.Create(url);
            string credentials = user + ":" + pwd;
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();

            //Get CR ID with URL
            JArray array = JArray.Parse(content);
            foreach (JObject obj in array.Children<JObject>())
            {
                foreach (JProperty singleProp in obj.Properties())
                {
                    if (singleProp.Name == "object")
                    {
                        Rootobjectdetails1 = JsonConvert.DeserializeObject<Object1>(singleProp.Value.ToString());
                        if (Rootobjectdetails1.title.StartsWith("GLB") || Rootobjectdetails1.title.StartsWith("SPECMGMT") 
                            || Rootobjectdetails1.title.StartsWith("OSM") || Rootobjectdetails1.title.StartsWith("MIC") 
                            || Rootobjectdetails1.title.StartsWith("AP"))
                        {
                            CRList.Add(Rootobjectdetails1.title, Rootobjectdetails1.url);
                        }
                    }
                }
            };
        }

        public void getComments(ref Dictionary<string, string> CommentDict)
        {
            using (OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="
            + Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"App_Data\\CommentsDB.accdb")))
            {
                try
                {
                    connection.Open();
                    OleDbCommand select = new OleDbCommand();
                    select.Connection = connection;
                    select.CommandText = "Select * From CHIAComments";
                    OleDbDataReader reader1 = select.ExecuteReader();
                    while (reader1.Read())
                    {
                        CommentDict.Add(reader1[1].ToString(), reader1[2].ToString());
                    }
                    connection.Close();
                }
                catch (Exception e)
                {
                    TempData["ErrorMessage"] = ErrorMessage = e.Message;
                }
            }
        }

        public void createDatabaseEntry(string key)
        {
            using (OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="
                    + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data\\CommentsDB.accdb")))
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into CHIAComments ([key],[Comments]) values (?,?)";
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.Parameters.AddWithValue("@Comments", "");
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    TempData["ErrorMessage"] = ErrorMessage = e.Message;
                }
            }
        }

        [NonAction]
        public void GetDeptList(ref List<SelectListItem> DeptList )
        {
            DeptList.Add(new SelectListItem { Text = "Gen Labs", Value = "General_Laboratory" });
            DeptList.Add(new SelectListItem { Text = "Micro", Value = "Micro_Helix" });
            DeptList.Add(new SelectListItem { Text = "Blood Bank", Value = "Blood_Bank" });
            DeptList.Add(new SelectListItem { Text = "AP", Value = "Anatomic_Pathology" });
        }
    }
}