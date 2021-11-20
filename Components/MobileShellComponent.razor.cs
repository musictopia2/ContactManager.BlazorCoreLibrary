namespace ContactManager.BlazorCoreLibrary.Components;
public partial class MobileShellComponent
{
    protected override void OnInitialized()
    {
        DataContext!.StateChanged = StateHasChanged;
        base.OnInitialized();
    }
    protected override async Task OnInitializedAsync()
    {
        await DataContext!.InitAsync();
    }
}