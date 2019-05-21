using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ExpandableList
{
    class FoodImageCell : ImageCell
    {
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var food = (Food)BindingContext;
        }
    }
}
