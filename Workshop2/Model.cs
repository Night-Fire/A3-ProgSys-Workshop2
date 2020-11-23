using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop2
{
    class Model
    {
        private string message;

        public Model()
        {
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                this.message = value;
            }
        }
    }
}
