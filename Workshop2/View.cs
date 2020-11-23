using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop2
{
    class View
    {
        private ViewModel viewModel;
        public View()
        {
            this.viewModel = new ViewModel();
        }

        private void DisplayMessage(string text)
        {
            Console.WriteLine(text);
        }

        public void GetInput()
        {
            string input = Console.ReadLine();
            if (input.Length >=1 && input.Length < 9)
            {
                viewModel.model.Message = input;
                viewModel.ToUpperCase();
                string output = viewModel.model.Message;
                this.DisplayMessage(output);
            }
            else
            {
                this.DisplayMessage("Le mot doit contenir entre 1 et 8 lettres");
            }
        }
    }
}
