namespace BlazorBuilds.Components.Common.Extensions;

public static class UtilityExtensions
{
    public static async Task WhenTrueElse(this bool boolValue, Func<Task> do_whenTrue, Func<Task> do_whenFalse)

        => await (boolValue ? do_whenTrue() : do_whenFalse());

    public static async Task WhenTrue(this bool boolValue, Func<Task> do_whenTrue)
    {
        if (boolValue) await do_whenTrue(); 
    }
    public static void WhenTrue(this bool boolValue, Action act_whenTrue)
    {
        if (boolValue) act_whenTrue();
    }
}
