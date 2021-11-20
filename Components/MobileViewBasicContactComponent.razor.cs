namespace ContactManager.BlazorCoreLibrary.Components;
public partial class MobileViewBasicContactComponent
{
    private static string GetDisplay(EnumPhoneCategory phone) => phone.ToString().GetWords();
}