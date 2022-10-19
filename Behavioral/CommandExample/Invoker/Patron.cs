using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandExample.Command;
using CommandExample.Receiver;

namespace CommandExample.Invoker
{
    internal class Patron
    {
        private OrderCommand _orderCommand;
        private MenuItem _menuItem;
        private FastFoodOrder _order;
        public Patron()
        {
            _order = new FastFoodOrder();
        }

        public void SetCommand(int commandOption)
        {
            _orderCommand = new CommandFactory().GetCommand(commandOption);
        }

        public void SetMenuItem(MenuItem item)
        {
            _menuItem = item;
        }

        public void ExecuteCommand()
        {
            _order.ExecuteCommand(_orderCommand, _menuItem);
        }

        public void ShowCurrentOrder()
        {
            _order.ShowCurrentItems();
        }
    }
}
