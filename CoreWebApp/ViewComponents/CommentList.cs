using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName = "Cengiz"
                },
                new UserComment
                {
                    ID = 2,
                    UserName = "Emre"
                },
                new UserComment
                {
                    ID = 3,
                    UserName = "Deniz"
                }
            };
            return View(commentValues);
        }
    }
}
