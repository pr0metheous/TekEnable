using Microsoft.AspNetCore.Mvc;
using TekEnable.Data;
using TekEnable.Models;

namespace TekEnable.Controllers
{
    public class SubscriptionsController : Controller
    {
        private readonly TekEnableDbContext _context;

        public SubscriptionsController(TekEnableDbContext context)
        {
            _context = context;
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(Subscription model)
        {
            if (ModelState.IsValid)
            {
                if (_context.Subscriptions.Any(x => x.EmailAddress == model.EmailAddress))
                {
                    ViewBag.Message = "You are already signed up!";
                }
                else
                {
                    _context.Subscriptions.Add(model);
                    _context.SaveChanges();
                    ViewBag.Message = "You have been signed up to the newsletter!";
                }
            }
            return PartialView("_SignUpConfirmation", model); // Return the partial view for the acknowledgment message.
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReturnToSignUp(Subscription model)
        {
            return RedirectToPage("/Index");
        }
    }
}