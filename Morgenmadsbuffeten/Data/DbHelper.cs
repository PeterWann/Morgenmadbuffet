using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.Extensions.Logging;

namespace Morgenmadsbuffeten.Data
{
    public class DbHelper
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager, ILogger log)
        {
            const string receptionEmail = "reception@mail.dk";
            const string receptionPassword = "Reception1/";

            if (userManager.FindByNameAsync(receptionEmail).Result == null)
            {
                log.LogWarning("Seeding the reception user");
                var user = new IdentityUser
                {
                    UserName = receptionEmail,
                    Email = receptionEmail
                };
                IdentityResult result = userManager.CreateAsync
                    (user, receptionPassword).GetAwaiter().GetResult();
                if (result.Succeeded)
                {
                    var receptionClaim = new Claim("Reception", "Yes");
                    userManager.AddClaimAsync(user, receptionClaim).GetAwaiter().GetResult();
                }
            }

            const string waiterEmail = "waiter@mail.dk";
            const string waiterPassword = "Waiter1/";

            if (userManager.FindByNameAsync(waiterEmail).Result == null)
            {
                log.LogWarning("Seeding the waiter user");
                var user = new IdentityUser
                {
                    UserName = waiterEmail,
                    Email = waiterEmail
                };
                IdentityResult result = userManager.CreateAsync
                    (user, waiterPassword).GetAwaiter().GetResult();
                if (result.Succeeded)
                {
                    var waiterClaim = new Claim("Waiter", "Yes");
                    userManager.AddClaimAsync(user, waiterClaim).GetAwaiter().GetResult();
                }
            }

            const string kitchenEmail = "kitchen@mail.dk";
            const string kitchenPassword = "Kitchen1/";

            if (userManager.FindByNameAsync(kitchenEmail).Result == null)
            {
                log.LogWarning("Seeding the kitchen user");
                var user = new IdentityUser
                {
                    UserName = kitchenEmail,
                    Email = kitchenEmail
                };
                IdentityResult result = userManager.CreateAsync
                    (user, kitchenPassword).GetAwaiter().GetResult();
                if (result.Succeeded)
                {
                    var kitchenClaim = new Claim("Kitchen", "Yes");
                    userManager.AddClaimAsync(user, kitchenClaim).GetAwaiter().GetResult();
                }
            }
        }
    }
}
