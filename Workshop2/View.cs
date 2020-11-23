using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using ClassLibrary;

namespace Workshop2
{
    class View : IEquatable<View>
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
            viewModel.model.Message = input;
            viewModel.ToUpperCase();
            string output = viewModel.model.Message;
            this.DisplayMessage(output);
        }

        public bool Equals([AllowNull] View other)
        {
            throw new NotImplementedException();
        }
    }
}
