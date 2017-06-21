using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTimer.Models;
using Xamarin.Forms;

namespace TodoTimer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here

            var items = new List<TodoItem>();
            items.Add(new TodoItem() { ID = 1, Name = "Görev 1", Done = true });
            items.Add(new TodoItem() { ID = 1, Name = "Görev 2", Done = false });
            listView.ItemsSource = items;
        }

        private void CheckButton_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Image == "check.jpg")
            {
                button.Image = "check2.png";
            } else
            {
                button.Image = "check.jpg";
            }
        }
    }
}
