using DataBindingPrepare.Models;
using Xamarin.Forms;

namespace DataBindingPrepare.Prepare
{
    public partial class DataBinding
    {
        public DataBinding()
        {
            InitializeComponent();

            Label label = new Label
            {
                FontSize = 30
            };

            label.BindingContext = new Person
            {
                Name = "Petko",
                Email = "123@wsa.com"
            };

            label.SetBinding(Label.TextProperty, new Binding("Name", source: new Person { Name = "Ivan" }));
            


            //Optional

            Label opacityLabel = new Label
            {
                Text = "Opacity Changing",
                FontSize = 30
            };

            Slider slider = new Slider
            {
                Value = .5
            };

            opacityLabel.BindingContext = slider;
            opacityLabel.SetBinding(OpacityProperty, "Value");

            Content = new StackLayout
            {
                Children = { label, opacityLabel, slider }
            };
        }
    }
}
