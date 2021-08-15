using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JohnnyGuru.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Mail;

namespace JohnnyGuru.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
    
        }

        [BindProperty]
        public EmailMessage EmailForm { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //string To = EmailForm.To;
            //string Name = EmailForm.Name;
            //string Email = EmailForm.Email;
            //string Subject = EmailForm.Subject;
            string Body = EmailForm.Body;
            MailMessage mm = new MailMessage(EmailForm.Email, "elmer4metallica@gmail.com");
            //MailMessage mm = new MailMessage();
            //mm.To.Add(To);
            //mm.Name = Name;
            mm.Subject = EmailForm.Subject;
            mm.Body = "Name: " + EmailForm.Name;
            mm.Body += "\nEmail: " + EmailForm.Email;
            mm.Body += "\nBody: " + EmailForm.Body;
            //mm.From = new MailAddress("elmer1998@gmail.com");
            mm.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new System.Net.NetworkCredential("elmer4metallica@gmail.com", "badazzjohnny1");
            smtp.Send(mm);
            return RedirectToPage("./ThankYou");
        }



    }
}
