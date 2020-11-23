using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Model
    {
        private string message;
        public List<Object> tasks;
        public Dictionary<string, DateTime> editedTime;

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
