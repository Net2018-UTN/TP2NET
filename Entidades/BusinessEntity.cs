using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BusinessEntity
    {
        private int id;
        private States state;

        public BusinessEntity()
        {
            this.State = States.New;
        }

        public enum States
        {
            Deleted, New, Modified, Unmodified
        }

        public States State { get => state; set => state = value; }
        public int Id { get => id; set => id = value; }
    }

}
