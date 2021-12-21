using aspnet_config.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_config.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IWebHostEnvironment _appEnvironment;

        private ApplicationContext db;
        ApplicationContext _context;
        public HomeController(ApplicationContext context, IWebHostEnvironment appEnvironment)
        {
            db = context;
            _context = context;
            _appEnvironment = appEnvironment;
        }

        #region Protocol God Eye
        public async Task<IActionResult> Index()
        {
            return View(await db.Users.ToListAsync());
        }
        #endregion

        #region Create profile
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Details profile
        public async Task<IActionResult> Details(int? id)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Id_User == id);
            return View(user);
        }
        #endregion

        #region Find profile

        //[HttpPost]
        //public string FindProfile(string searchString, bool notUsed)
        //{
        //    TestClass.TestStr = searchString;
        //    return "From [HttpPost]FindProfile: filter on " + searchString;
        //}

        public async Task<IActionResult> FindProfile(string SearchString)
        {
            var origins = from m in db.Users select m;
            if (!String.IsNullOrEmpty(SearchString))
            {
                TestClass.TestStr = SearchString;
                origins = origins.Where(s => s.Login_User.Contains(SearchString));
            }
            return View(await origins.ToListAsync());
        }
        #endregion

        #region Delete profile
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                User user = await db.Users.FirstOrDefaultAsync(p => p.Id_User == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                User user = new User { Id_User = id.Value };
                db.Entry(user).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("ProfileShow");
            }
            return NotFound();
        }
        #endregion

        #region Edit profile
        [HttpGet]
        public async Task<IActionResult> EditProfile(int? id)
        {
            //if (id != null)
            //{
                User user = await db.Users.FirstOrDefaultAsync(p => p.Id_User == id);
                //if (user != null)
                    return View(user);
            //}
            //return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(User user)
        {
            db.Users.Update(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Showing profile
        public IActionResult ProfileShow()
        {
            var model = new UserPost
            {
                Posts = db.Posts.ToList(),
                Users = db.Users.ToList()
            };
            return View(model);
        }
        #endregion

        #region Create post
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost(Post post, IFormFile uploadedFile)
        {
            string path = "/Files/" + uploadedFile.FileName;
            // сохраняем файл в папку Files в каталоге wwwroot
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(fileStream);
            }
            post.Photo_post = path;
            post.Owner_Post = TestClass.TestInt;
            db.Posts.Add(post);
            await db.SaveChangesAsync();
            return RedirectToAction("ProfileShow");
        }
        #endregion

        #region Show profile posts
        public async Task<IActionResult> DetailsProfilePost(int? id)
        {
            TestClass.TestOwner = (int)id;
            return View(await db.Posts.ToListAsync());
        }
        #endregion

        #region Delete post
        [HttpGet]
        [ActionName("DeletePost")]
        public async Task<IActionResult> ConfirmDeletePost(int? id)
        {
            if (id != null)
            {
                Post post = await db.Posts.FirstOrDefaultAsync(p => p.Id_Post == id);
                if (post != null)
                    return View(post);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id != null)
            {
                Post post = new Post { Id_Post = id.Value };
                db.Entry(post).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("ProfileShow");
            }
            return NotFound();
        }
        #endregion

        #region Edit post
        [HttpGet]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id != null)
            {
                Post post = await db.Posts.FirstOrDefaultAsync(p => p.Id_Post == id);
                if (post != null)
                    return View(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditPost(Post post)
        {
            db.Posts.Update(post);
            await db.SaveChangesAsync();
            return RedirectToAction("ProfileShow");
        }
        #endregion

        #region Showing posts
        public IActionResult Posts()
        {
            var model = new UserPost
            {
                Posts = db.Posts.ToList(),
                Users = db.Users.ToList()
            };
            return View(model);
        }
        #endregion
    }
}