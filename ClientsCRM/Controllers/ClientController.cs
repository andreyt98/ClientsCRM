using ClientsCRM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ClientsCRM.Controllers {

    public class ClientController : Controller {

        private readonly CRMCLIENTSContext _context;

        public ClientController(CRMCLIENTSContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {

            return View(await _context.Clients.ToListAsync());
        }
        [HttpPost]
        public IActionResult Create(Client client) {

            if (ModelState.IsValid) {
                _context.Add(client);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            } else {
                return View(client);

            }


        }
    }
}
