using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace Portfolio
{
    public class LayoutSwitchManager
    {
        private NavigationManager _navigationManager;
        EventHandler<LocationChangedEventArgs> locationChangedHandler;

        public LayoutTransitionState CurrentLayoutState { get; set; } = LayoutTransitionState.Static;

        public LayoutSwitchManager(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            locationChangedHandler = (sender, e) => ResetStateAfterSeconds(0.2f);
            _navigationManager.LocationChanged += locationChangedHandler;
        }

        ~LayoutSwitchManager()
        {
            _navigationManager.LocationChanged -= locationChangedHandler;
        }

        public async Task GoToPage(string pageUrl)
        {
            CurrentLayoutState = LayoutTransitionState.Out;
            await Task.Delay(200);
            CurrentLayoutState = LayoutTransitionState.In;
            _navigationManager.NavigateTo(pageUrl);

        }

        private void ResetStateAfterSeconds(float delayInSeconds)
        {
            Task.Delay(TimeSpan.FromSeconds(delayInSeconds));
            CurrentLayoutState = LayoutTransitionState.Static;
        }
    }
}
