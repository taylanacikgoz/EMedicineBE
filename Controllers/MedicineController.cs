using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EMedicineBE.Models;
using Microsoft.Data.SqlClient;

namespace EMedicineBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public MedicineController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("addToCart")]
        public Response addToCart(Cart cart)
        {
            DAL dAL = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dAL.addToCart(cart, connection);
            return response;
         }

        [HttpPost]
        [Route("placeOrder")]

        public Response placeOrder(Users users)
        {
            DAL dAL = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dAL.placeOrder(users, connection);
            return response;
        }

        [HttpPost]
        [Route("orderList")]

        public Response orderList(Users users) { 
            DAL dAL= new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dAL.OrderList(users, connection);
            return response;
        
        }
    }
}
