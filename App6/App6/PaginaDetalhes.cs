using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App6
{
    public class PaginaDetalhes : ContentPage
    {
        public PaginaDetalhes(Jogo oJogo)
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = oJogo.Titulo }
                }
            };
        }
    }
}