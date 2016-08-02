using BirdingLog.Models;
using BirdingLog.Services;
using BirdingLog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdingLog.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;
        private BirdingLogContext _context;

        public AppController(IMailService mailService, IConfigurationRoot config, BirdingLogContext context)
        {
            _mailService = mailService;
            _config = config;
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Photos.ToList();

            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }

        public IActionResult ProfileInfo()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (model.Email.Contains("darthmooska@gmail.com"))
            {
                ModelState.AddModelError("", "Why would you message yourself?");
            }

            if (ModelState.IsValid)
            {
                _mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, model.Name, model.Message);

                ModelState.Clear();
                ViewBag.UserMessage = "Message Sent";
            }

            return View();
        }
    }
}
