using Microsoft.AspNetCore.Components;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace Portfolio
{
    public class LayoutSwitchManager
    {
        private NavigationManager _navigationManager;

        public LayoutTransitionState CurrentLayoutState { get; set; } = LayoutTransitionState.Static;

        public LayoutSwitchManager(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public async Task GoToPage(string pageUrl)
        {
            CurrentLayoutState = LayoutTransitionState.Out;
            await Task.Delay(200);
            CurrentLayoutState = LayoutTransitionState.In;
            _navigationManager.NavigateTo(pageUrl);
        }
    }
}
