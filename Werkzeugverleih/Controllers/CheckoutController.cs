using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WerkzeugverleihData;
using WerkzeugverleihData.Models;

namespace Werkzeugverleih.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private readonly WerkzeugverleihContext _context;

        public CheckoutController(WerkzeugverleihContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Checkout>> GetCheckoutsById(int id)
        {
           
                List<Checkout> ergebnis = _context.Checkouts
                .Include(checkout => checkout.Werkzeug)
                .Where(checkout => checkout.Werkzeug.ID == id)
                .ToList();

            return ergebnis;
             
        }

    }
}
