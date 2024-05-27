using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace Portfolio
{
    public class LayoutSwitchManager
    {
        public float TransitionDuration { get; } = 0.2f;

        private NavigationManager _navigationManager;
        EventHandler<LocationChangedEventArgs> locationChangedHandler;

        public event EventHandler<EventArgs> TransitionStateChanged;

        public void NotifyTransitionStateChanged(object sender, EventArgs e)
            => TransitionStateChanged?.Invoke(sender, e);

        public LayoutTransitionState CurrentLayoutState { get; set; } = LayoutTransitionState.Static;

        public LayoutSwitchManager(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            locationChangedHandler = (sender, e) => ResetStateAfterSeconds(TransitionDuration);
        }

        ~LayoutSwitchManager()
        {
            _navigationManager.LocationChanged -= locationChangedHandler;
        }

        public async Task GoToPage(string pageUrl)
        {
            CurrentLayoutState = LayoutTransitionState.Out;
            await Task.Delay(TimeSpan.FromSeconds(TransitionDuration));
            CurrentLayoutState = LayoutTransitionState.In;
            NotifyTransitionStateChanged(this, EventArgs.Empty);
            _navigationManager.LocationChanged += locationChangedHandler;
            _navigationManager.NavigateTo(pageUrl);
            _navigationManager.LocationChanged -= locationChangedHandler;
        }

        private async void ResetStateAfterSeconds(float delayInSeconds)
        {
            await Task.Delay(TimeSpan.FromSeconds(delayInSeconds));
            CurrentLayoutState = LayoutTransitionState.Static;
            NotifyTransitionStateChanged(this, EventArgs.Empty);
        }
    }
}
