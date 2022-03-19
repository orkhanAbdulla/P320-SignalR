using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using SignalRP320.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRP320.HUBs
{
    public class ChatHub:Hub
    {
        private readonly UserManager<AppUser> _userManager;

        public ChatHub(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task SendMessage(string singleUserId, string message)
        {

            if (Context.User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(Context.User.Identity.Name);
                if (string.IsNullOrEmpty(singleUserId))
                {
                    await Clients.All.SendAsync("ReceiveMessage", user.FullName, message, DateTime.Now.ToString("dd MM yyyy HH:hh"));
                }
                else
                {
                    var singleUser =await _userManager.FindByIdAsync(singleUserId);
                    if (singleUser.ConnectionId!=null)
                    {
                        await Clients.Client(singleUser.ConnectionId).SendAsync("ReceiveMessage", user.FullName, message, DateTime.Now.ToString("dd MM yyyy HH:hh"));
                    }

                    
                }
         
            }
        }
        public async override Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                var user =await _userManager.FindByNameAsync(Context.User.Identity.Name);

                user.ConnectionId = Context.ConnectionId;

               await _userManager.UpdateAsync(user);

               await Clients.All.SendAsync("UserConnected", user.Id);
            }
        }
        public async override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(Context.User.Identity.Name);

                user.ConnectionId = null;

                await _userManager.UpdateAsync(user);

                await Clients.All.SendAsync("UserDisConnected", user.Id);
            }
        }
    }
}
