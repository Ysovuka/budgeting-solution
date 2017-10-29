using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solutiuons.Budgeting.Web.Models;
using Solutiuons.Budgeting.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace Solutiuons.Budgeting.Web.Controllers
{
    [Produces("application/json")]
    [Route("Calendar/Events")]
    public class CalendarEventsController : Controller
    {
        private readonly BillContext _context;

        public CalendarEventsController(BillContext context)
        {
            _context = context;

            if (_context.Database.GetPendingMigrations().Count() != 0)
            {
                _context.Database.Migrate();
            }
        }

        [HttpGet]
        public List<Bill> GetEvents(string date)
        {
            var bills = _context.Bills.ToList();
            return bills;
        }

        [HttpPost]
        public Bill PostEvent([FromBody] Bill bill)
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();

            return bill;
        }

        [HttpPut]
        public Bill PutEvent([FromBody] Bill bill)
        {
            if (_context.Bills.FirstOrDefault(b => b.Id.Equals(bill.Id)) != null)
            {
                _context.Bills.Update(bill);
                _context.SaveChanges();
            }
            else
            {
                _context.Bills.Add(bill);
                _context.SaveChanges();
            }
            return bill;
        }

        [HttpPatch]
        public Bill Patchevent([FromBody] Bill bill)
        {
            _context.Bills.Update(bill);
            _context.SaveChanges();

            return bill;
        }

        [HttpDelete]
        public Bill DeleteEvent(Guid id)
        {
            var bill = _context.Bills.FirstOrDefault(b => b.Id.Equals(id));
            if (bill != null)
            {
                _context.Bills.Remove(bill);
                _context.SaveChanges();
            }

            return bill;
        }
    }
}