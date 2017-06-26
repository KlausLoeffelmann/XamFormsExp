using ActiveDevelop.MvvmBaseLib.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Reflection;
using Xamarin.Forms;

namespace XamFormExp.ViewModel
{
    public class MainListViewModel : MvvmViewModelBase
    {
        private ObservableCollection<ImageListItem> myImageListItems;

        private string[] myPictureNames = { "ActiveDevelopUp.jpg",
                                            "JeepRim.jpg",
                                            "KlausTafel.jpg",
                                            "LoheUp.jpg",
                                            "OdoMeter.jpg",
                                            "Wedding.jpg"};

        public static MainListViewModel GetMainListViewModelDemoData(int elementCount)
        {
            var returnList = new MainListViewModel();
            returnList.ImageListItems = new ObservableCollection<ImageListItem>();

            var imageItem = new ImageListItem();
            var currentAss = typeof(MainListViewModel).GetTypeInfo().Assembly;
            var ressourceNames = currentAss.GetManifestResourceNames();

            for (int count = 0; count < elementCount; count++)
            {
                
            }

            return returnList;
        }

        public ObservableCollection<ImageListItem> ImageListItems
        {
            get
            {
                return myImageListItems;
            }

            set
            {
                SetProperty(ref myImageListItems, value);
            }
        }
    }

    public class ImageListItem : MvvmViewModelBase
    {
        private ImageSource imageSource;
        private string myItemText;


        public ImageSource MyProperty
        {
            get
            {
                return imageSource;
            }
            set
            {
                SetProperty(ref imageSource, value);
            }
        }

        public String ItemText
        {
            get
            {
                return myItemText;
            }

            set
            {
                SetProperty(ref myItemText, value);
            }
        }
    }
}
