using CIC_TT15.Core.EFCore;
using CIC_TT15.Core.Entities;
using CIC_TT15.Core.Models;
using CIC_TT15.Core.Utils;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class D32_CHOVAYController : ControllerBase
    {
        private readonly MyDBContex _context;
        public D32_CHOVAYController(MyDBContex context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<D32_CHOVAY> Get()
        {
            List<D32_CHOVAY> lst = _context.D32_CHOVAYs.ToList();
            return lst;
        }

        [HttpGet("GetByKey")]
        public IActionResult GetByKey(string YYYYMMDD, string TTC01, string TTC03, string HD001)
        {
            D32_CHOVAY entity = _context.D32_CHOVAYs.FirstOrDefault(s => s.YYYYMMDD == YYYYMMDD && s.TTC01 == TTC01 && s.TTC03 == TTC03 && s.HD001 == HD001);
            if (entity != null) 
                return Ok(entity);
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post(D32_CHOVAYModel model)
        {
            D32_CHOVAY entity = Util.Map<D32_CHOVAY>(model);
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        public IActionResult Put(string YYYYMMDD, string TTC01, string TTC03, string HD001, D32_CHOVAYModel model)
        {
            try
            {
                D32_CHOVAY entity = _context.D32_CHOVAYs.FirstOrDefault(s => s.YYYYMMDD == YYYYMMDD && s.TTC01 == TTC01 && s.TTC03 == TTC03 && s.HD001 == HD001);
                if(entity != null)
                {
                    entity.TTC02 = model.TTC02;
                    entity.TTC04 = model.TTC04;
                    entity.HD002 = model.HD002;
                    entity.HD003 = model.HD003;
                    entity.HD004 = model.HD004;
                    entity.HD005 = model.HD005;

                    _context.Update(entity);
                    _context.SaveChanges();
                    return NoContent();
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(string YYYYMMDD, string TTC01, string TTC03, string HD001)
        {
            try
            {
                D32_CHOVAY entity = _context.D32_CHOVAYs.FirstOrDefault(s => s.YYYYMMDD == YYYYMMDD && s.TTC01 == TTC01 && s.TTC03 == TTC03 && s.HD001 == HD001);
                if (entity != null)
                {
                    _context.Remove(entity);
                    _context.SaveChanges();
                    return Ok(1);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public IActionResult Create(D32_CHOVAY_KHEUOC__D32_CHOVAY_KHEUOCModel model)
        {
            try
            {
                D32_CHOVAY entity = Util.Map<D32_CHOVAY>(model);
                _context.Database.BeginTransaction();

                _context.Add(entity);
                _context.SaveChanges();

                List<D32_CHOVAY_KHEUOC> d32_CHOVAY_KHEUOCs = new List<D32_CHOVAY_KHEUOC>();
                foreach (var item in model.d32_CHOVAY_KHEUOCModels)
                    d32_CHOVAY_KHEUOCs.Add(Util.Map<D32_CHOVAY_KHEUOC>(item));
                _context.AddRange(d32_CHOVAY_KHEUOCs);
                _context.SaveChanges();

                _context.Database.CommitTransaction();
                return Ok(model);
            }
            catch (Exception ex)
            {
                _context.Database.RollbackTransaction();
                return BadRequest(ex.Message);
            }
        }
    }
}
