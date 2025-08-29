using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Sidekick.Pages.Ui.Utilities;

public class FlowbiteComponent : ComponentBase
{
    [Inject]
    protected IJSRuntime JsRuntime { get; set; } = null!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeVoidAsync("sidekick.initializeFlowbite");
        }

        await base.OnAfterRenderAsync(firstRender);
    }
}