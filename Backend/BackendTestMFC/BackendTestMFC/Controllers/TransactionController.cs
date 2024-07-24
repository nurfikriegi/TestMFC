using BackendTestMFC.Data;
using BackendTestMFC.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BackendTestMFC.Controllers
{
    public class TransactionController : Controller
    {
        private readonly DataContext _context;
        public TransactionController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("InsertUpdateTransaction")]
        public async Task<IActionResult> InsertTransaction(TrxBpkbRequest request)
        {
            var result = _context.tr_bpkb.Where(p=> p.agreement_number == request.agreement_number).FirstOrDefault();
            if (result==null)
            {
                //insert
                tr_bpkb trx = new tr_bpkb();
                trx.agreement_number = request.agreement_number;
                trx.branch_id = request.branch_id;
                trx.bpkb_date = request.bpkb_date;
                trx.bpkb_date_in = request.bpkb_date_in;
                trx.bpkb_no = request.bpkb_no;
                trx.faktur_date = request.faktur_date;
                trx.faktur_no = request.faktur_no;
                trx.police_no = request.police_no;
                trx.location_id = request.location_id;
                trx.created_by = request.user;
                trx.created_on = DateTime.Now;

                await _context.tr_bpkb.AddAsync(trx);
                await _context.SaveChangesAsync();
            }
            else
            {
                //update
                tr_bpkb trx = new tr_bpkb();
                trx.agreement_number = result.agreement_number;
                trx.branch_id = result.branch_id;
                trx.bpkb_date = result.bpkb_date;
                trx.bpkb_date_in = result.bpkb_date_in;
                trx.bpkb_no = result.bpkb_no;
                trx.faktur_date = result.faktur_date;
                trx.faktur_no = result.faktur_no;
                trx.police_no = result.police_no;
                trx.location_id = result.location_id;
                trx.created_by = result.created_by;
                trx.created_on = result.created_on;
                trx.last_updated_by = request.user;
                trx.last_updated_on = DateTime.Now;
                _context.tr_bpkb.Update(result);
                await _context.SaveChangesAsync();

            }
            return Ok();
        }
    }
}
