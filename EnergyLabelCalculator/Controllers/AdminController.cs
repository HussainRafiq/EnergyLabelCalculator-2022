using DBManager.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyLabelCalculator.Controllers
{
    public class AdminController : Controller
    {
        IDBManager _dBManager;
        public AdminController(IDBManager dBManager)
        {
            _dBManager = dBManager;
        }
        [AdminFilter]
        public IActionResult Index()
        {
            Dictionary<String, object> parameters = new Dictionary<String, object>();
            parameters.Add("ID", DBNull.Value);
            parameters.Add("Email", DBNull.Value);
            parameters.Add("Role", "User");
            parameters.Add("CompanyID", DBNull.Value);

            DataTable companies = _dBManager.GetData("GetUser", parameters);
            ViewBag.Companies = companies;

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
            return View();
        }

        [AdminFilter]
        public IActionResult ManageCompanies()
        {
            DataTable dt = _dBManager.GetData("GetCompany");
            ViewBag.Companies = dt;

            return View();
        }
        [HttpPost]
        [AdminFilter]
        public IActionResult ManageCompanies(IFormCollection collection)
        {
            if (collection != null &&  collection.Files.Where(x => x.Name == "CompanyLogo").Count() > 0  && collection.Keys.Contains("CompanyTitle") && collection.Files.Count() > 0)
            {
                String Path = collection.Files.Where(x => x.Name == "CompanyLogo").Count() > 0 ? SaveFile(collection.Files[0], "CompanyLogo_" + collection["CompanyTitle"]) : null;
                string Title = collection["CompanyTitle"];
                if (String.IsNullOrEmpty(Title))
                {
                    ViewBag.Error = "FillTheField";
                }
                Dictionary<String, object> parameters = new Dictionary<String, object>();
                    parameters.Add("CompanyTitle", Title);
                    parameters.Add("CompanyLogo", Path);
                 string insertedID = _dBManager.Insert("InsertCompany", parameters).ToString();
                if (int.Parse(insertedID) > 0)
                {
                    TempData["Succes"] = "CompanyAdded";
                }
                else
                {
                    ViewBag.Error = "SomeError";
                }
                DataTable dt = _dBManager.GetData("GetCompany");
                ViewBag.Companies = dt;

                return View();


            }
            else
            {
                ViewBag.Error = "FillTheField";
                return View();
            }

            return View();
        }
        [AdminFilter]
        public IActionResult DeleteCompany(string ID)
        {
            Dictionary<String, object> parameters = new Dictionary<String, object>();
            parameters.Add("ID", ID);
            int isDeleted = _dBManager.UpdateOrDelete("DeleteCompany", parameters);
            if (isDeleted > 0)
            {
                TempData["Success"] = "CompanyDeleted";
            }
            else
            {

                TempData["Error"] = "SomeError";
            }

            return RedirectToAction("ManageCompanies");
        }
        public IActionResult Login()
        {
            if (HttpContext.Session.Keys.Contains("UserID") && HttpContext.Session.Keys.Contains("Role") && HttpContext.Session.GetString("Role") == "Admin")
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection collection)
        {
            if (collection != null && collection.Keys.Contains("Email") && collection.Keys.Contains("Password") && !String.IsNullOrEmpty(collection["Email"]) && !String.IsNullOrEmpty(collection["Password"]) )
            {
                Dictionary<String, object> parameters = new Dictionary<String, object>();
                parameters.Add("ID", DBNull.Value);
                parameters.Add("Email", collection["Email"].ToString());
                parameters.Add("Role", "Admin");
                parameters.Add("CompanyID", DBNull.Value);
                DataTable User = _dBManager.GetData("GetUser", parameters);
                if (User != null && User.Rows.Count > 0 && User.Rows[0]["Password"] == collection["Password"])
                {
                    HttpContext.Session.SetString("UserID", User.Rows[0]["ID"].ToString());
                    HttpContext.Session.SetString("Name", User.Rows[0]["FirstName"].ToString() + " " + User.Rows[0]["LastName"].ToString());
                    HttpContext.Session.SetString("Role", User.Rows[0]["Role"].ToString());
                    return RedirectToAction("Index");
                }

            }
            ViewBag.Error = "IncorrectEmailPassword";
            return View();
        }
        [AdminFilter]
        public IActionResult AddUser()
        {
            DataTable dt = _dBManager.GetData("GetCompany");
            ViewBag.Companies = dt;
            return View();
        }
        [AdminFilter]
        [HttpPost]
        public IActionResult AddUser(IFormCollection collection)
        {
            if (collection != null && ((collection.Keys.Contains("ID")) || (collection.Keys.Contains("FirstName") && collection.Keys.Contains("LastName") && collection.Keys.Contains("Email") && collection.Keys.Contains("Password") && collection.Keys.Contains("CompanyID") && collection["CompanyID"].ToString() != "0")))
            {
               
                Dictionary<String, object> parameters = new Dictionary<String, object>();
                if (collection.Keys.Contains("ID"))
                    parameters.Add("ID", collection["ID"].ToString());
                else
                    parameters.Add("ID", DBNull.Value);

                if (collection.Keys.Contains("FirstName"))
                    parameters.Add("FirstName", collection["FirstName"].ToString());
                else
                    parameters.Add("FirstName", DBNull.Value);

                if (collection.Keys.Contains("LastName"))
                    parameters.Add("LastName", collection["LastName"].ToString());
                else
                    parameters.Add("LastName", DBNull.Value);

                if (collection.Keys.Contains("Email"))
                    parameters.Add("Email", collection["Email"].ToString());
                else
                    parameters.Add("Email", DBNull.Value);

                if (collection.Keys.Contains("Password"))
                    parameters.Add("Password", collection["Password"].ToString());
                else
                    parameters.Add("Password", DBNull.Value);

                if (collection.Keys.Contains("CompanyID"))
                    parameters.Add("CompanyID", collection["CompanyID"].ToString());
                else
                    parameters.Add("CompanyID", DBNull.Value);

                parameters.Add("Role", (object)"User");

               

                var insertedID = _dBManager.Insert("InsertUser", parameters);
                if (insertedID !=null && int.Parse(insertedID.ToString()) > 0)
                {
                    if (collection.Keys.Contains("ID"))
                        TempData["SuccesMessage"] = "UserUpdated";
                    else
                        TempData["SuccesMessage"] = "UserAdded";
                    return RedirectToAction("Index", "Admin");
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
        [AdminFilter]
        public IActionResult UpdateUser(string ID)
        {
            DataTable dt = _dBManager.GetData("GetCompany");
            ViewBag.Companies = dt;
            Dictionary<String, object> parameters = new Dictionary<String, object>();
            parameters.Add("ID", ID);
            parameters.Add("Email", DBNull.Value);
            parameters.Add("Role", "User");
            parameters.Add("CompanyID", DBNull.Value);


            DataTable companies = _dBManager.GetData("GetUser", parameters);
            if (companies.Rows.Count > 0)
            {
                ViewBag.Data = companies.Rows[0];
                return View("AddUser");

            }
            ViewBag.Error = "SomeErrorOccurred";
            return RedirectToAction("Index", "Admin");
        }
        [AdminFilter]
        public IActionResult DeleteUser(string ID)
        {
            Dictionary<String, object> parameters = new Dictionary<String, object>();
            parameters.Add("ID", ID);
            int isDeleted = _dBManager.UpdateOrDelete("DeleteUser", parameters);
            if (isDeleted > 0)
            {
                TempData["SuccesMessage"] = "UserDeleted";
                return RedirectToAction("Index", "Admin");
            }
            return RedirectToAction("Index", "Admin");
        }
        [AdminFilter]
        [HttpPost]
        public IActionResult SetValue(IFormCollection collection)
        {
            if(collection!=null && collection.Keys.Contains("AverageElectric") && collection.Keys.Contains("AverageGas"))
            {
                Dictionary<String, object> parameters = new Dictionary<String, object>();
                parameters.Add("AverageElectric", collection["AverageElectric"].ToString());
                parameters.Add("AverageGas", collection["AverageGas"].ToString());
                object isInserted=_dBManager.Insert("UpdateGenericVlaue", parameters);
                if (int.Parse(isInserted.ToString()) > 0)
                {
                    TempData["SuccesMessage"] = "GenericInfoChanged";
                    return RedirectToAction("Index");

                }

            }
            TempData["Error"] = "SomeErrorOccurred";
            return RedirectToAction("Index");

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
    }
}
