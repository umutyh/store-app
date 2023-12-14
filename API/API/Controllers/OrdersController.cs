using Microsoft.AspNetCore.Mvc;
using store.Service.Models;
using store.Service.OrderService;
using Swashbuckle.AspNetCore.Annotations;

namespace store.API.Controllers
{
    [Route("api/orders")]
    //[Route("[action]")]
    public class OrdersController : Controller
    {
        private readonly IOrderService _ordersService;

        public OrdersController(IOrderService ordersService)
        {
            _ordersService = ordersService;
        }

        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<OrderInfoServiceDB>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpGet("orderInformation", Name = "getOrderInformation")]
        public async Task<ActionResult<List<OrderInfoServiceDB>>> getOrderInformation()
        {
            var orders = await _ordersService.GetAllOrdersInformation();
            if (orders is null)
            {
                return NotFound();
            }
            return Ok(orders);
        }

        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<OrderDetailServiceDB>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpGet("orderDetails",Name = "getOrderDetails")]
        public async Task<ActionResult<List<OrderDetailServiceDB>>> getOrderDetail()
        {
            var orders = await _ordersService.GetAllOrdersDetails();
            if (orders is null)
            {
                return NotFound();
            }
            return Ok(orders);
        }


        [SwaggerResponse(StatusCodes.Status201Created)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [HttpPost("orderInformation", Name = "createOrderInfo")]
        public async Task<IActionResult> createOrderInfo([FromBody] OrderInfoCreation orderCreation)
        {
            var createdOrder = await _ordersService.CreateOrderInfo(orderCreation);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(createdOrder);
        }

        [SwaggerResponse(StatusCodes.Status201Created)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [HttpPost("orderDetails", Name = "createOrderDetails")]
        public async Task<IActionResult> createOrderDetails([FromBody] OrderDetailCreation orderDetailCreation)
        {
            var createdOrder = await _ordersService.CreateOrderDet(orderDetailCreation);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(createdOrder);
        }

        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<OrderDetailsCombined>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpGet("joinedOrderDetails", Name = "JoinedOrderDetailsAndInformation")]
        public async Task<ActionResult<List<OrderDetailsCombined>>> getJoinedOrderDetails()
        {
            var ordersData = await _ordersService.GetOrdersCombined();
            if (ordersData is null)
            {
                return NotFound();
            }
            return Ok(ordersData);
        }

        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<OrderInfoServiceDB>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpGet("{orderNumber}",Name = "GetOrderByOrderNumber")]
        public async Task<ActionResult<List<OrderInfoServiceDB>>>GetOrderByNumber(int orderNumber)
        {
            var order = await _ordersService.OrderByOrderNumber(orderNumber);
            if(order is null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OrderDetailServiceDB))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpPut("{orderNumber}",Name = "UpdateOrderPrice")]
        public async Task<ActionResult<OrderDetailServiceDB>>UpdateOrderPrice([FromBody] OrderForUpdatingPriceAndQuantity orderDetail, int orderNumber)
        {
            var data = await _ordersService.UpdateOrderPrice(orderDetail, orderNumber);
            if (data == null)
            {
               return NotFound();
            }
            return Ok(data);
        }

        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OrderDetailServiceDB))]
        [SwaggerResponse(StatusCodes.Status401Unauthorized)]
        [SwaggerResponse(StatusCodes.Status403Forbidden)]
        [HttpPut(Name = "UpdateOrderPriceAndQuantity")]
        public async Task<ActionResult> UpdateOrderRow([FromBody] OrderForUpdatingPriceAndQuantity orderDetail, int orderNumber)
        {
            await _ordersService.UpdateOrderRow(orderDetail, orderNumber);
            return Ok();
        }
    }
}
