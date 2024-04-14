using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CouponAPIController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _context.Coupons.ToList();

                return objList;
            }
            catch (Exception ex)
            {

                throw;
            }

            return null;
        }

        [HttpGet]
        [Route("{id:int}")] 
        public object Get(int id)
        {
            try
            {
                Coupon objList = _context.Coupons.First(c => c.CouponId == id);
                return objList;
            }
            catch (Exception ex)
            {

                throw;
            }

            return null;
        }
    }
}
