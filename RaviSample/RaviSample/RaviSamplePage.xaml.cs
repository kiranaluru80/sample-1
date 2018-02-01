using System.Collections.Generic;
using Xamarin.Forms;

namespace RaviSample
{
    public partial class RaviSamplePage : ContentPage
    {
        public RaviSamplePage()
        {
            InitializeComponent();

            var majorGroupList = new List<string>();
            majorGroupList.Add("Major group 1");
            majorGroupList.Add("Major group 2");
            majorGroupList.Add("Major group 3");
            majorGroupList.Add("Major group 4");
            majorGroupPicker.ItemsSource = majorGroupList;

            var organizationList = new List<string>();
            organizationList.Add("Organization 1");
            organizationList.Add("Organization 2");
            organizationList.Add("Organization 3");
            organizationList.Add("Organization 4");
            organizationPicker.ItemsSource = organizationList;

            var jsseUserList = new List<string>();
            jsseUserList.Add("JSSE user 1");
            jsseUserList.Add("JSSE user 2");
            jsseUserList.Add("JSSE user 3");
            jsseUserList.Add("JSSE user 4");
            jsseUserPicker.ItemsSource = jsseUserList;

        }
    }
}
