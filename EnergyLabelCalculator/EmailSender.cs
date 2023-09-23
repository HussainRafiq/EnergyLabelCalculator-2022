using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EnergyLabelCalculator
{
    public class EmailSender
    {
        public string From { get; set; }
        public string[] To { get; set; }
        public string AliasName { get; set; }
        public string AliasEmail { get; set; }
        public string Password { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string[] Cc { get; set; }
        public string[] Bcc { get; set; }
        public string Config { get; set; }
        public string Port { get; set; }
        public string Host { get; set; }
        public string IsSSLEnabled { get; set; }
        public string UseDefaultCredentials { get; set; }
        public string Timeout { get; set; }
        public List<byte[]> Attachments { get; set; } = new List<byte[]>();
        public byte[] attach { get; set; }


        public MailPriority Priority { get; set; }

        public bool SendBulkMail()
        {
            string EmailConfig = Config;
            if (EmailConfig == "OFF")
                return true;

            bool IsMailSuccessful = false;
            string MailStatus = string.Empty;

            //string Port = System.Configuration.ConfigurationManager.AppSettings["Email_Port"].ToString();
            //string Host = System.Configuration.ConfigurationManager.AppSettings["Email_Host"].ToString();
            //string IsSSLEnabled = System.Configuration.ConfigurationManager.AppSettings["Email_IsSSLEnabled"].ToString();
            //string UseDefaultCredentials = System.Configuration.ConfigurationManager.AppSettings["Email_UseDefaultCredentials"].ToString();
            //string Timeout = System.Configuration.ConfigurationManager.AppSettings["Email_Timeout"].ToString();

            SmtpClient client = new SmtpClient();
            client.Port = Convert.ToInt32(Port);
            client.Host = Host;
            client.EnableSsl = !string.IsNullOrEmpty(IsSSLEnabled) && IsSSLEnabled.Trim().ToLower() == "true" ? true : false;
            client.Timeout = Convert.ToInt32(Timeout);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = !string.IsNullOrEmpty(UseDefaultCredentials) && UseDefaultCredentials.Trim().ToLower() == "true" ? true : false;
            client.Credentials = new System.Net.NetworkCredential(From, Password);

            MailMessage mm = new MailMessage();
            //  mm.Attachments.Add(new Attachment("C:\\Users\\Hussain\\Downloads\\ihdinaa-bg.jpg"));
            mm.Body = Body;
            mm.Subject = Subject;
            mm.From = new MailAddress(AliasEmail, AliasName);
            mm.Priority = Priority;
            if (attach != null)
            {
                mm.Attachments.Add(new Attachment(new MemoryStream(attach), "Certificate.jpg"));

            }
            if (EmailConfig == "LIVE")
            {
                if (To != null && To.Length > 0)
                {
                    foreach (string User in To)
                    {
                        mm.To.Add(User);
                    }
                }

                if (Cc != null && Cc.Length > 0)
                {
                    foreach (string User in Cc)
                    {
                        mm.CC.Add(User);
                    }
                }

                if (Bcc != null && Bcc.Length > 0)
                {
                    foreach (string User in Bcc)
                    {
                        mm.Bcc.Add(User);
                    }
                }
            }
            
            mm.BodyEncoding = System.Text.UTF8Encoding.UTF8;
            mm.IsBodyHtml = true;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            try
            {
                client.Send(mm);

                IsMailSuccessful = true;
                MailStatus = "Successfully sent.";
            }
            catch (Exception ex)
            {
                MailStatus = ex.Message;
                IsMailSuccessful = false;

                throw ex;
            }
            finally
            {
                string fileSavePath = "";

                try
                {
                   
                    string htmlToSave = "From: " + From;
                    htmlToSave += "; To: ";

                    if (To != null && To.Length > 0)
                    {
                        foreach (string User in To)
                        {
                            htmlToSave += User + ";";
                        }
                    }

                    htmlToSave += " Subject: " + Subject;
                    htmlToSave += "; Status: " + MailStatus;
                    htmlToSave += Body;

                    System.IO.File.WriteAllText(fileSavePath, htmlToSave);
                }
                catch (Exception ex)
                {
                    fileSavePath += string.Format("{0} - {1}", ex.Message, ex.InnerException);
                }
            }


            return IsMailSuccessful;
        }

    }
}
