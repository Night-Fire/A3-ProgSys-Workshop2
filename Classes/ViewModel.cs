using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
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
            string text = model.Message;
            if (text.Length >= 1 && text.Length > 8)
            {
                text = text.ToUpper();
            }
            else
            {
                text = "Le mot doit faire entre 1 et 8 caractères";
            }
            model.Message = text;
        }
    }
}
