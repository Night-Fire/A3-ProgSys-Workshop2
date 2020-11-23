using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop2
{
    class ViewModel
    {
        public Model model { get; set; }
        public ViewModel()
        {
            this.model = new Model();
        }

        public void ToUpperCase()
        {
            model.Message = model.Message.ToUpper();
        }
    }
}
