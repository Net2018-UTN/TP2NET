using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BusinessEntity
    {
        public BusinessEntity()
        {
            this.State = States.New;
        }

        public enum States
        {
            Deleted, New, Modified, Unmodified
        }

        private int id;
        private States state;

        public int Id { get => Id; set => Id = value; }
        public States State { get => state; set => state = value; }
    }

}
