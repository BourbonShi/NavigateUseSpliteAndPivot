using Demo.BaseObject;
using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Demo.ViewModel
{
    public class MainPageViewModel : ObservableObject
    {
        private string pivotTitle;
        public string PivotTitle
        {
            get
            {
                return pivotTitle;
            }
            set
            {
                pivotTitle = value;
                OnPropertyChanged("PivotTitle");
            }
        }

        private List<MyPivotItem> pivotList;
        public List<MyPivotItem> PivotList
        {
            get
            {
                return pivotList; 
            }
            set
            {
                pivotList = value;
                OnPropertyChanged("PivotList");
            }
        }

        private bool menuOpened;
        public bool MenuOpened
        {
            get
            {
                return menuOpened;
            }
            set
            {
                menuOpened = value;
                OnPropertyChanged("MenuOpened");
            }
        }

        private List<NavItem> navList;
        public List<NavItem> NavList
        {
            get
            {
                return navList;
            }
            set
            {
                navList = value;
            }
        }

        public MainPageViewModel()
        {
            this.PivotTitle = "2015";
            this.PivotList = new List<MyPivotItem>() { new MyPivotItem() };
            this.NavList = new List<NavItem>(
            new[]
            {
                new NavItem()
                {
                    Symbol = Symbol.Favorite,
                    Label = "2015",
                    DestPage = NavItem.NavType.one,
                },
                new NavItem()
                {
                    Symbol = Symbol.Favorite,
                    Label = "12",
                    DestPage = NavItem.NavType.two,
                },
                new NavItem()
                {
                    Symbol = Symbol.Favorite,
                    Label = "24",
                    DestPage = NavItem.NavType.three,
                },
            });
        }

        private DelegateCommand navCommand;
        public DelegateCommand NavCommand
        {
            get
            {
                return navCommand ?? (navCommand = new DelegateCommand(
                    (Object obj) =>
                    {
                        NavItem selectedItem = obj as NavItem;
                        if (selectedItem != null)
                        {
                            this.PivotTitle = selectedItem.Label;
                            switch (selectedItem.DestPage)
                            {
                                case NavItem.NavType.one:
                                    this.PivotList = new List<MyPivotItem>() { new MyPivotItem() };
                                    break;
                                case NavItem.NavType.two:
                                    this.PivotList = new List<MyPivotItem>() { new MyPivotItem(), new MyPivotItem() };
                                    break;
                                case NavItem.NavType.three:
                                    this.PivotList = new List<MyPivotItem>() { new MyPivotItem(), new MyPivotItem(), new MyPivotItem() };
                                    break;
                            }
                            this.MenuOpened = false;
                        }
                    },
                    (Object obj) => true));
            }
        }
    }
}
