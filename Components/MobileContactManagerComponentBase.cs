namespace ContactManager.BlazorCoreLibrary.Components;
public abstract class MobileContactManagerComponentBase : ComponentBase
{
    [Inject]
    [AllowNull]
    protected MobileContactViewModel? DataContext { get; set; }
}