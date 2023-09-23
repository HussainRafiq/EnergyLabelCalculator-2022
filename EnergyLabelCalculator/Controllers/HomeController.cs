using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DBManager.Interfaces;
using EnergyLabelCalculator;
using EnergyLabelCalculator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Multilingual.ASPNETCore.Models;
using Newtonsoft.Json;

namespace Multilingual.ASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDBManager _dBManager;
        private readonly IConfiguration _configuration;
        public HomeController(IDBManager dBManager, IConfiguration configuration)
        {
            _dBManager = dBManager;
            _configuration = configuration;
        }
        public IActionResult ForgotPassword()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ForgotPassword(IFormCollection formcollection)
        {
            if (formcollection != null && formcollection.ContainsKey("Email"))
            {
                string Email = formcollection["Email"]; Dictionary<String, object> parameters = new Dictionary<String, object>();
                parameters.Add("ID", DBNull.Value);
                parameters.Add("Email", Email);
                parameters.Add("Role", "User");
                DataTable User = _dBManager.GetData("GetUser", parameters);
                if (User != null && User.Rows.Count > 0)
                {
                    String UserID = User.Rows[0]["ID"].ToString();
                    String Code = Guid.NewGuid().ToString();
                    parameters = new Dictionary<String, object>();
                    parameters.Add("UserID", UserID);
                    parameters.Add("Token", Code);
                    _dBManager.UpdateOrDelete("InsertToken", parameters);
                    String Link = HttpContext.Request.Scheme + Uri.SchemeDelimiter + HttpContext.Request.Host.Value+"/Home/ResetPassword?Code="+Code;
                    EmailSender emailSender = new EmailSender()
                    {
                        UseDefaultCredentials = "false",
                        AliasEmail = _configuration.GetSection("EmailSetting").GetSection("Email").Value,
                        AliasName = _configuration.GetSection("EmailSetting").GetSection("AliasName").Value,
                        Config = "LIVE",
                        From = _configuration.GetSection("EmailSetting").GetSection("From").Value,
                        Host = "smtp.gmail.com",
                        IsSSLEnabled = _configuration.GetSection("EmailSetting").GetSection("IsSSLEnabled").Value,
                        Password = _configuration.GetSection("EmailSetting").GetSection("password").Value,
                        Port = "587",
                        Subject = _configuration.GetSection("EmailSetting").GetSection("Subject").Value,
                        Timeout = "600000",
                        Body = HttpContext.Request.Host.Value+" has received a request to reset the password for your account. If you did not request to reset your password, please ignore this email. <br/>" + Link,
                        To = new string[] {Email }
                    };
                    bool isSend=emailSender.SendBulkMail();
                    if (isSend)
                    {
                        ViewBag.AfterEmailSendMessage = "AfterEmailSendMessage";
                        ViewBag.Email = Email;
                    }
                    else
                    {
                        ViewBag.Error = "SomeErrorOccurred";
                    }
                    return View();
                }
                else
                {
                    ViewBag.Error = "UserNotFound";

                    return View();
                }

            }

            else
            {
                ViewBag.Error = "EmailRequired";

                return View();
            }

        }
        [UserFilterAttribute]
        public IActionResult Index()
        {
           
            return View();
        }
        private string EncryptString(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (System.Security.Cryptography.Aes encryptor = System.Security.Cryptography.Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (System.Security.Cryptography.Aes encryptor = System.Security.Cryptography.Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }


        public IActionResult ResetPassword(string Code)
        {
            try
            {
                if (Code != null)
                {
                    var parameters = new Dictionary<String, object>();                  
                    parameters.Add("Token", Code);
                    DataTable dt=_dBManager.GetData("GetToken", parameters);
                    if(dt==null || dt.Rows.Count > 0)
                    {
                        ViewBag.UserID = dt.Rows[0]["UserID"];
                        parameters = new Dictionary<String, object>();
                        parameters.Add("UserID", dt.Rows[0]["UserID"]);
                        _dBManager.UpdateOrDelete("RedeemedToken", parameters);
                        return View();
                    }
                    else
                    {
                        throw new Exception();
                    }

                }

                return View();
            }catch(Exception ex)
            {
                return Content("Link is incorrect or expired.");
            }
        }
        [HttpPost]
        public IActionResult ResetPassword(IFormCollection FormCollection)
        {
           
                if (FormCollection != null && FormCollection.Keys.Contains("UserID") && FormCollection.Keys.Contains("Password") && FormCollection.Keys.Contains("ConfirmPassword"))
                {
                    string UserID = FormCollection["UserID"];
                    string Password = FormCollection["Password"];
                    string ConfirmPassword = FormCollection["ConfirmPassword"];
                    if (Password == ConfirmPassword) {
                         Dictionary<String, object> parameters = new Dictionary<String, object>();
                         
                         parameters.Add("ID", UserID);
                         parameters.Add("FirstName", DBNull.Value);
                         parameters.Add("LastName", DBNull.Value);
                         parameters.Add("Email", DBNull.Value);
                         parameters.Add("Password", Password);
                         parameters.Add("Role", (object)"User");
                         parameters.Add("CompanyTitle", DBNull.Value);
                         parameters.Add("CompanyLogo", DBNull.Value);
                         
                         string insertedID = _dBManager.Insert("InsertUser", parameters).ToString();
                         if (int.Parse(insertedID) > 0)
                         {
                        TempData["Success"] = "PasswordReseted";
                        return RedirectToAction("Index", "Home");
                         }
                        else
                        {
                             ViewBag.Error = "SomeErrorOccurred";
                        }
                    }
                    else
                    {
                       ViewBag.Error = "ConfirmPasswordError";
                    }
                }
            else
            {
                ViewBag.Error = "FillFields";
            }
                return View();
            
        }

        [UserFilterAttribute]
        public IActionResult GenerateReport(FormModel formModel=null)
        {
            if (formModel != null && formModel.Street!=null)
            {
                HttpContext.Session.SetString("Model", JsonConvert.SerializeObject(formModel));
            }
            else
            {
                if(HttpContext.Session.Keys.Contains("Model"))
                formModel = JsonConvert.DeserializeObject<FormModel>(HttpContext.Session.GetString("Model"));
            }
            if (formModel != null && formModel.Street != null)
            {
                HttpContext.Session.SetString("Model", JsonConvert.SerializeObject(formModel));
                
                DataTable GenericValues = _dBManager.GetData("GetGenericValue");
                if (GenericValues != null && GenericValues.Rows.Count > 0)
                {
                    Dictionary<string, string> GenericInfo = new Dictionary<string, string>();
                    foreach (DataRow dr in GenericValues.Rows)
                    {
                        GenericInfo.Add(dr["ParameterKey"].ToString(), dr["Value"].ToString());
                    }
                    ViewBag.Value = GenericInfo;
                }
                return View(formModel);
            }
            else
            {
                
                return RedirectToAction("Index");
            }
        }

        public IActionResult Login()
        {
            DataTable dt = _dBManager.GetData("GetCompany");
            ViewBag.Companies = dt;
            return View();
        }
        public IActionResult Register()
        {
            DataTable dt = _dBManager.GetData("GetCompany");
            ViewBag.Companies = dt;
            return View();
        }
       
        [HttpPost]
        public IActionResult Register(IFormCollection collection)
        {
            DataTable dt = _dBManager.GetData("GetCompany");
            ViewBag.Companies = dt;
            if (collection != null && ((collection.Keys.Contains("ID")) || (collection.Keys.Contains("FirstName") && collection.Keys.Contains("LastName") && collection.Keys.Contains("Email") && collection.Keys.Contains("Password") && collection.Keys.Contains("CompanyID") && collection["CompanyID"].ToString()!="0")))
            {
               
                Dictionary<String, object> parameters = new Dictionary<String, object>();

                    parameters.Add("ID", DBNull.Value);
                    parameters.Add("FirstName", collection["FirstName"].ToString());
                    parameters.Add("LastName", collection["LastName"].ToString());
                    parameters.Add("Email", collection["Email"].ToString());
                    parameters.Add("Password", collection["Password"].ToString());
                    parameters.Add("Role", (object)"User");
                    parameters.Add("CompanyID", collection["CompanyID"].ToString());
                
                var insertedID = _dBManager.Insert("InsertUser", parameters);
                if (insertedID!=null && int.Parse(insertedID.ToString()) > 0)
                {
                    Dictionary<string, StringValues> Dict = new Dictionary<string, StringValues>();
                    Dict.Add("Email", collection["Email"].ToString());
                    Dict.Add("Password", collection["Password"].ToString());
                    Dict.Add("CompanyID", collection["CompanyID"]);
                    IFormCollection form = new FormCollection(Dict);
                    return Login(form);
                }
                ViewBag.Error = "SomeErrorOccurred";
                return View();


            }
            else
            {
                ViewBag.Error = "FillTheField";
                return View();
            }

        }
        [HttpPost]
        public IActionResult Login(IFormCollection formCollection)
        {
            DataTable dt = _dBManager.GetData("GetCompany");
            ViewBag.Companies = dt;
            if(formCollection==null || !formCollection.Keys.Contains("CompanyID") || formCollection["CompanyID"].ToString() == "0")
            {
                ViewBag.Error = "CompanyNotSelected";
                return View();
            }
            if (formCollection == null || !formCollection.Keys.Contains("Email") || !formCollection.Keys.Contains("Password"))
            {
                ViewBag.Error = "FillTheField";
                return View();
            }
            Dictionary<String, object> parameters = new Dictionary<String, object>();
            parameters.Add("CompanyID", formCollection["CompanyID"].ToString());
            parameters.Add("ID", DBNull.Value);
            parameters.Add("Email", formCollection["Email"].ToString());
            parameters.Add("Role", "User");
            DataTable User = _dBManager.GetData("GetUser", parameters);
            if (User != null && User.Rows.Count > 0 && User.Rows[0]["Password"] == formCollection["Password"])
            {
                HttpContext.Session.SetString("UserID", User.Rows[0]["ID"].ToString());
                HttpContext.Session.SetString("Name", User.Rows[0]["FirstName"].ToString() + " " + User.Rows[0]["LastName"].ToString());
                HttpContext.Session.SetString("Role", User.Rows[0]["Role"].ToString());
                HttpContext.Session.SetString("CompanyName", User.Rows[0]["CompanyName"].ToString());
                HttpContext.Session.SetString("CompanyLogo", User.Rows[0]["CompanyLogo"].ToString());
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "IncorrectEmailPassword";
                return View();
            }
        }
        private static string SaveFile(IFormFile file, string Entity)
        {
            try
            {




                var path = Path.Combine(
                            "IMAGES", Entity
                            ).Replace(" ", "");

                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", path).Replace(" ", "")))
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", path).Replace(" ", ""));

                String Code = Guid.NewGuid().ToString();
                using (var stream = new FileStream(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", path).Replace(" ", ""),
                            Code + "_" + file.FileName).Replace(" ", ""), FileMode.Create))
                {
                    file.CopyTo(stream);
                }



                return Path.Combine(path,
                            Code + "_" + file.FileName).Replace(" ", "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
