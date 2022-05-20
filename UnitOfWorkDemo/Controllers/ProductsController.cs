using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UnitOfWorkDemo.Core.Configuration;
using UnitOfWorkDemo.Data;
using UnitOfWorkDemo.Models;

namespace UnitOfWorkDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public ProductsController(ILogger<ProductsController> logger,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product user)
        {
            if (ModelState.IsValid)
            {

               
               

                await _unitOfWork.Products.Add(user);
                await _unitOfWork.CompleteAsync();

                return Ok(user);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

    }
}
