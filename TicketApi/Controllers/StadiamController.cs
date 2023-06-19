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

        public IQueryable<Stadium> stds { get; private set; }

        public StadiamController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            
            this._unitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        // GET: api/Stadiam
        [HttpGet]
        public ActionResult<IEnumerable<GetStadium>> GetStadiums()
        {
            string[] navProps = { "Matches", "Enclosures" };
            stds = _unitOfWork.Stadium.IncludeOther(navProps);
           
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
        [HttpPut]
        public ActionResult<GetStadium> PutStadium(UpdateStadium updateStadium)
        {
           

           Stadium std= _unitOfWork.Stadium.GetById(updateStadium.Id);
            if (std == null)
            {
                return NotFound("no record found");
            }
            var stadium = _Mapper.Map<Stadium> (updateStadium);

            std.Std_Name = updateStadium.Std_Name;

            _unitOfWork.Stadium.Update(stadium);
            try
            {
                _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return Ok();
            
        }

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
