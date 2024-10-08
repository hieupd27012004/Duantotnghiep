using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChatLieuController : Controller
    {
        
        private readonly IChatLieuService _service;
        public ChatLieuController(IChatLieuService service)
        {
            _service = service;
        }
        // GET: ChatLieuContronller
        public async Task<IActionResult> Index()
        {
            var chatLieu = await _service.GetAllChatLieu();
            return View(chatLieu);
        }

        // GET: ChatLieuContronller/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var chatLieu = await _service.GetIdChatLieu(id);
            if(chatLieu == null)
            {
                return NotFound();
            }
            return View(chatLieu);
        }

        // GET: ChatLieuContronller/Create
        public ActionResult Create()
        {
            var chatLieu = new ChatLieu() 
            { 
                IdChatLieu = Guid.NewGuid(),
                TenChatLieu = "Da",
                NgayCapNhat = DateTime.Now,
                NguoiTao = "Kim Hoàng Long",
                KichHoat = 1
            };
            return View(chatLieu);
        }

        // POST: ChatLieuContronller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ChatLieu chatLieu)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateChatLieu(chatLieu);
                return RedirectToAction("Index");
            }
            return View(chatLieu);
        }

        // GET: ChatLieuContronller/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var chatlieu = await _service.GetIdChatLieu(id);
            if(chatlieu == null)
            {
                return NotFound();
            }
            return View(chatlieu);
        }

        // POST: ChatLieuContronller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id,ChatLieu chatLieu)
        {
            if(id != chatLieu.IdChatLieu)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _service.UpdateChatLieu(chatLieu);
                return RedirectToAction("Index");
            }
            return View(chatLieu);
        }

        // GET: ChatLieuContronller/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var chatLieu = await _service.GetIdChatLieu(id);
            if (chatLieu == null)
            {
                return NotFound();
            }
            await _service.DeleteChatLieu(id);
            return RedirectToAction("Index");
        }

        
   
    }
}
