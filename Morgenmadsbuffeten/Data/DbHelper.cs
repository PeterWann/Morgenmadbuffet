using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Morgenmadsbuffeten.Data
{
    public class DbHelper
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            const string kitchenMail = "kitchen@mail.dk";
            const string kitchenPassword = "Kitchen1!";

            if (userManager.FindByNameAsync(kitchenMail).Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = kitchenMail,
                    Email = kitchenMail,
                };
                IdentityResult result = userManager.CreateAsync(user, kitchenPassword).Result;
                if (result.Succeeded)
                {
                    var kitchenClaim = new Claim("Kitchen", "Yes");
                    userManager.AddClaimAsync(user, kitchenClaim);
                }
            }

            const string waiterMail = "waiter@mail.dk";
            const string waiterPassword = "Waiter1!";

            if (userManager.FindByNameAsync(waiterMail).Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = waiterMail,
                    Email = waiterMail,
                };
                IdentityResult result = userManager.CreateAsync(user, waiterPassword).Result;
                if (result.Succeeded)
                {
                    var waiterClaim = new Claim("Waiter", "Yes");
                    userManager.AddClaimAsync(user, waiterClaim);
                }
            }

            const string receptionMail = "reception@mail.dk";
            const string receptionPassword = "Reception1!";

            if (userManager.FindByNameAsync(receptionMail).Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = receptionMail,
                    Email = receptionMail,
                };
                IdentityResult result = userManager.CreateAsync(user, receptionPassword).Result;
                if (result.Succeeded)
                {
                    var receptionClaim = new Claim("Reception", "Yes");
                    userManager.AddClaimAsync(user, receptionClaim);
                }
            }
        }
    }
}
