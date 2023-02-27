using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Utad.Lab.G03.MobileDroid.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Utad.Lab.G03.MobileDroid.ViewModels
{
    /// <summary>
    /// ViewModel for selectable name page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class ProductListViewModel : BaseViewModel
    {
        #region Fields

        private Command<object> itemTappedCommand;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="ProductListViewModel"/> class.
        /// </summary>
        public ProductListViewModel()
        {
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets the command that will be executed when an item is selected.
        /// </summary>
        public Command<object> ItemTappedCommand
        {
            get
            {
                return this.itemTappedCommand ?? (this.itemTappedCommand = new Command<object>(this.NavigateToNextPage));
            }
        }

        /// <summary>
        /// Gets or sets a collction of value to be displayed in selectable name page
        /// </summary>
        [DataMember(Name = "selectableName")]
        public ObservableCollection<Contact> SelectableName { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected from the selectable names list.
        /// </summary>
        /// <param name="selectedItem">Selected item from the list view.</param>
        private void NavigateToNextPage(object selectedItem)
        {
            // Do something
        }

        #endregion
    }
}
