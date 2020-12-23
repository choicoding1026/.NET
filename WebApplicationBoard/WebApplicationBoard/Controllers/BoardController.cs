using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplicationBoard.DataContext;
using WebApplicationBoard.Models;

namespace WebApplicationBoard.Controllers
{
    public class BoardController : Controller
    {
        /// <summary>
        /// 게시판 리스트 출력
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안 된 상태
                return RedirectToAction("Login", "Account");
            }

            using (var db = new BoardDBContext())
            {
                var list = db.Boards.ToList();
                return View(list);
            }
        }

        /// <summary>
        /// 게시판 상세 보기
        /// </summary>
        /// <param name="boardNo"></param>
        /// <returns></returns>
        public IActionResult Detail(int boardNo)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안 된 상태
                return RedirectToAction("Login", "Account");
            }

            using (var db = new BoardDBContext())
            {
                var board = db.Boards.FirstOrDefault(n=>n.BoardNo.Equals(boardNo));
                return View(board);
            }
        }

        /// <summary>
        /// 게시물 추가
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안 된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Add(Board model)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안 된 상태
                return RedirectToAction("Login", "Account");
            }
            model.UserNo = int.Parse(HttpContext.Session.GetInt32("USER_LOGIN_KEY").ToString());

            if (ModelState.IsValid)
            {
                using(var db = new BoardDBContext())
                {
                    db.Boards.Add(model);

                    if (db.SaveChanges() > 0)
                    {
                        return Redirect("Index");
                    }
                }
                ModelState.AddModelError(string.Empty, "게시물을 저장할 수 없습니다.");
            }
            return View(model);
        }

        /// <summary>
        /// 게시물 수정
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안 된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        /// <summary>
        /// 게시물 삭제
        /// </summary>
        /// <returns></returns>
        public IActionResult Delete()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안 된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
    }
}
