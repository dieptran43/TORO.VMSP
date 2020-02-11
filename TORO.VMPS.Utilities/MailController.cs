using System.Net;
using System.Net.Mail;
using System.Web;

namespace TORO.VMPS.Utilities
{
    public class MailController
    {
        public string _host { get; set; }
        public int _port { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
        public string _displayName { get; set; }
        public bool _enableSSL { get; set; }

        public MailController(string host, int port, string username, string password, string displayName, bool enableSSL = true)
        {
            _host = host;
            _port = port;
            _username = username;
            _password = password;
            _displayName = displayName;
            _enableSSL = enableSSL;
        }

        public bool SendMail(MailAddress mailFrom, MailAddress[] mailTo, string subject, string body, Attachment[] attachments)
        {
            try
            {
                MailAddress senderAuthenticated = new MailAddress(_username, _displayName);
                MailMessage mess = new MailMessage();
                mess.From = mailFrom;
                for (int i = 0; i < mailTo.Length; i++)
                {
                    mess.To.Add(mailTo[i]);
                }
                mess.IsBodyHtml = true;
                mess.Sender = senderAuthenticated;
                mess.Subject = subject;
                mess.Body = HttpUtility.HtmlDecode(body);
                mess.Priority = MailPriority.High;
                if (attachments != null)
                {
                    for (int i = 0; i < attachments.Length; i++)
                    {
                        mess.Attachments.Add(attachments[i]);
                    }

                }
                SmtpClient smtp = new SmtpClient();
                smtp.Host = _host;
                smtp.Port = _port;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = _enableSSL;
                smtp.Credentials = new NetworkCredential(_username, _password);
                smtp.Send(mess);
                mess.Dispose();
                return true;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    return false;
                }
                return false;
            }
        }

        public bool SendMail(MailAddress[] mailTo, string subject, string body, Attachment[] attachments)
        {
            try
            {

                    MailAddress senderAuthenticated = new MailAddress(_username, _displayName);
                    MailMessage mess = new MailMessage();
                    mess.From = senderAuthenticated;
                    for (int i = 0; i < mailTo.Length; i++)
                    {
                        mess.To.Add(mailTo[i]);
                    }
                    mess.IsBodyHtml = true;
                    mess.Sender = senderAuthenticated;
                    mess.Subject = subject;
                    mess.Body = HttpUtility.HtmlDecode(body);
                    mess.Priority = MailPriority.High;
                    if (attachments != null)
                    {
                        for (int i = 0; i < attachments.Length; i++)
                        {
                            mess.Attachments.Add(attachments[i]);
                        }

                    }
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = _host;
                    smtp.Port = _port;
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = _enableSSL;

                    smtp.Credentials = new NetworkCredential(_username, _password);
                    smtp.Send(mess);

                    return true;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    return false;
                }
                return false;
            }
        }

        public bool MailWithResponse(MailAddress[] mailTo, string subject, string body, Attachment[] attachments)
        {
            try
            {
                    MailAddress senderAuthenticated = new MailAddress(_username, _displayName);
                    MailMessage mess = new MailMessage();
                    mess.From = senderAuthenticated;
                    for (int i = 0; i < mailTo.Length; i++)
                    {
                        mess.To.Add(mailTo[i]);
                    }
                    mess.IsBodyHtml = true;
                    mess.Sender = senderAuthenticated;
                    mess.Subject = subject;
                    mess.Body = HttpUtility.HtmlDecode(body);
                    mess.Priority = MailPriority.High;
                    if (attachments != null)
                    {
                        for (int i = 0; i < attachments.Length; i++)
                        {
                            mess.Attachments.Add(attachments[i]);
                        }

                    }
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = _host;
                    smtp.Port = _port;
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = _enableSSL;
                    smtp.Credentials = new NetworkCredential(_username, _password);
                    smtp.Send(mess);
                    return true;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    return false;
                }
                return false;
            }
        }

        public bool SendMail(MailAddress[] mailTo, MailAddress[] mailCc, MailAddress[] mailBcc, string subject, string body, Attachment[] attachments)
        {
            try
            {

                    MailAddress senderAuthenticated = new MailAddress(_username, _displayName);
                    MailMessage mess = new MailMessage();
                    mess.From = senderAuthenticated;
                    for (int i = 0; i < mailTo.Length; i++)
                    {
                        mess.To.Add(mailTo[i]);
                    }
                    if (mailCc != null)
                    {
                        for (int i = 0; i < mailCc.Length; i++)
                        {
                            mess.CC.Add(mailCc[i]);
                        }
                    }
                    if (mailBcc != null)
                    {
                        for (int i = 0; i < mailBcc.Length; i++)
                        {
                            mess.Bcc.Add(mailBcc[i]);
                        }
                    }
                    mess.IsBodyHtml = true;
                    mess.Sender = senderAuthenticated;
                    mess.Subject = subject;
                    mess.Body = HttpUtility.HtmlDecode(body);
                    mess.Priority = MailPriority.High;
                    if (attachments != null)
                    {
                        for (int i = 0; i < attachments.Length; i++)
                        {
                            mess.Attachments.Add(attachments[i]);
                        }

                    }
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = _host;
                    smtp.Port = _port;
                    smtp.EnableSsl = _enableSSL;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(_username, _password);
                    smtp.Send(mess);
                return true;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    return false;
                }
                return false;
            }
        }
        public bool SendMail(MailAddress mailFrom, MailAddress[] mailTo, MailAddress[] mailCc, MailAddress[] mailBcc, string subject, string body, Attachment[] attachments)
        {
            try
            {

                    MailAddress senderAuthenticated = new MailAddress(_username, _displayName);
                    MailMessage mess = new MailMessage();
                    mess.From = mailFrom;
                    for (int i = 0; i < mailTo.Length; i++)
                    {
                        mess.To.Add(mailTo[i]);
                    }
                    if (mailCc != null)
                    {
                        for (int i = 0; i < mailCc.Length; i++)
                        {
                            mess.CC.Add(mailCc[i]);
                        }
                    }
                    if (mailBcc != null)
                    {
                        for (int i = 0; i < mailBcc.Length; i++)
                        {
                            mess.Bcc.Add(mailBcc[i]);
                        }
                    }
                    mess.IsBodyHtml = true;
                    mess.Sender = senderAuthenticated;
                    mess.Subject = subject;
                    mess.Body = HttpUtility.HtmlDecode(body);
                    mess.Priority = MailPriority.High;
                    if (attachments != null)
                    {
                        for (int i = 0; i < attachments.Length; i++)
                        {
                            mess.Attachments.Add(attachments[i]);
                        }

                    }
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = _host;
                    smtp.Port = _port;
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = _enableSSL;
                    smtp.Credentials = new NetworkCredential(_username, _password);
                    smtp.Send(mess);
                    mess.Dispose();
                return true;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    return false;
                }
                return false;
            }
        }
    }
}
