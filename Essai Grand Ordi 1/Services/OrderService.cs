using Essai_Grand_Ordi_1.DataAccess;
using Essai_Grand_Ordi_1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai_Grand_Ordi_1.Services
{
    public class OrderService
    {
        private IUnitOfWork _unit;
        public OrderService()
        {
            _unit = new UnitOfWork();
        }
        public IEnumerable<OrderDTO> GetOrders()
        {
            var orders = _unit.Orders.GetAll();
            var orderDetails = _unit.OrderDetils.GetAll();
            var orderMethod = _unit.OrderMethod.GetAll();
            var client = _unit.Client.GetAll();
            var product = _unit.Menu.GetAll();
            var city = _unit.City.GetAll();

            var ordersList = from o in orders
                             join c in client on o.CLIENT_ID equals c.ID
                             join od in orderDetails on o.ORDER_DETAILS_ID equals od.ID
                             join pr in product on od.DISH_ID equals pr.ID
                             join ci in city on c.CITY_ID equals ci.ID
                             select new OrderDTO
                             {
                                 FIRST_NAME = c.FIRST_NAME,
                                 LAST_NAME = c.LAST_NAME,
                                 STREET = c.STREET,
                                 APARTMENT_NUMBER = c.APARTMENT_NUMBER,
                                 HOME_NUMBER = c.HOME_NUMBER,
                                 FLOOR = c.FLOOR,
                                 CITY = ci.NAME,
                                 PHONE_NUMBER = c.PHONE_NUMBER,
                                 NAME = pr.NAME,
                                 PRICE = pr.PRICE,
                                 QUANTITY = od.QUANTITY,
                                 TOTAL_PRICE = pr.PRICE * od.QUANTITY,
                                 DATE_ORDERED = o.DATE_ORDERED,
                                 ORDER_RECIEVED = o.ORDER_RECIEVED,
                                 ORDER_TYPE = o.ORDER_TYPE

                             };
            return ordersList;




        }
    }
}
