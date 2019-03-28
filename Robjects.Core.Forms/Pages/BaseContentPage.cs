using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Robjects.Core.Forms.Services;
using Robjects.Core.ViewModels;
using Xamarin.Forms;

namespace Robjects.Core.Forms.Pages
{
    public abstract class BaseContentPage : ContentPage
    { }

    public abstract class BaseContentPage<T> : BaseContentPage, IViewFor<T> where T : BaseNavigationViewModel
    {
        T _viewModel;

        public T ViewModel
        {
            get
            {
                return _viewModel;
            }
            set
            {
                BindingContext = _viewModel = value;

                if (_viewModel != null)
                {
                    Task.Run(async () =>
                    {
                        try
                        {
                            await _viewModel.InitAsync();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
                    });
                }
            }
        }

        public string Test { get; set; }

        object IViewFor.ViewModel
        {
            get => _viewModel; 
            set =>  ViewModel = (T)value;
        }

        protected BaseContentPage()
        { }

        async void Init() => await ViewModel.InitAsync();
    }
}

