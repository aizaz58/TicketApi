using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketApi.Data;
using TicketApi.DTOs.Stadium;
using TicketApi.Models;
using TicketApi.Services;

namespace TicketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiamController : ControllerBase
    {
        
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _Mapper;

        public StadiamController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            
            this._unitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        // GET: api/Stadiam
        [HttpGet]
        public ActionResult<IEnumerable<GetStadium>> GetStadiums()
        {
            var stds = _unitOfWork.Stadium.GetAll();
          if (stds== null)
          {
              return NotFound();
          }
            return Ok(stds.Select(x=>_Mapper.Map<GetStadium>(x)) );
        }

        // GET: api/Stadiam/5
        [HttpGet("{id}")]
        public ActionResult<GetStadium> GetStadium(int id)
        {
            Stadium stadium= _unitOfWork.Stadium.GetById(id);
          if (stadium== null)
          {
              return NotFound();
          }
         
            return Ok(_Mapper.Map<GetStadium>(stadium));
        }

       //// PUT: api/Stadiam/5
       ////  To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
       // [HttpPut("{id}")]
       // public IActionResult PutStadium(int id, Stadium stadium)
       // {
       //     if (id != stadium.Id)
       //     {
       //         return BadRequest();
       //     }

       //     _context.Entry(stadium).State = EntityState.Modified;

       //     try
       //     {
       //         await _context.SaveChangesAsync();
       //     }
       //     catch (DbUpdateConcurrencyException)
       //     {
       //         if (!StadiumExists(id))
       //         {
       //             return NotFound();
       //         }
       //         else
       //         {
       //             throw;
       //         }
       //     }

       //     return NoContent();
       // }

        // POST: api/Stadiam
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<GetStadium> PostStadium(AddStadium stadium)
        {

            _unitOfWork.Stadium.Add(_Mapper.Map<Stadium>(stadium));
            _unitOfWork.Save(); 
            return Ok(_unitOfWork.Stadium.GetAll());
        }

        // DELETE: api/Stadiam/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStadium(int id)
        {
            Stadium std = _unitOfWork.Stadium.GetById(id);

            if (std == null)
            {
                return NotFound();
            }
          
          

            _unitOfWork.Stadium.Delete(std);
            _unitOfWork.Save();

            return Ok("successfully deletd stadium.");
        }

        //private bool StadiumExists(int id)
        //{
        //    return (_unitOfWork.Stadium?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
