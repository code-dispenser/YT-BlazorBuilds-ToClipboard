namespace BlazorBuilds.Components.Common.Seeds;

public class GlobalValues
{
    public const string Style_As_Dark  = "dark";
    public const string Style_As_Light = "light";

    public const string Copy_Button_Text_Exception_Message   = "Copy text is for the button name and cannot be null, empty or whitespace.";
    public const string Failed_Button_Text_Exception_Message = "Failed text is for the button name in the failed state and cannot be null, empty or whitespace.";

    public const string ToClipboard_Copying_Text    = "Copying";
    public const string ToClipboard_Failed_Msg      = "Copying failed, please try again.";
    public const string ToClipboard_Copied_Msg      = "Copied successfully.";
    public const string ToClipboard_Unavailable_Msg = "Nothing to copy.";

    

    public const string ToClipboard_Class         = "to-clipboard";
    public const string ToClipboard_Button_Class  = $"{ToClipboard_Class}__button";
    public const string ToClipboard_Text_Class    = $"{ToClipboard_Class}__text";
    public const string ToClipboard_Icon_Class    = $"{ToClipboard_Class}__icon";
    public const string ToClipboard_SR_Only_Class = $"{ToClipboard_Class}__screen-reader-only";

    public const string ToClipboard_Icon_Success_Class = $"{ToClipboard_Icon_Class}--success";
    public const string ToClipboard_Icon_Failure_Class = $"{ToClipboard_Icon_Class}--failure";

    public const string Copy_Icon_Name_Class    = $"clipboard-icon";
    public const string Success_Icon_Name_Class = $"success-icon";
    public const string Fail_Icon_Name_Class    = $"fail-icon";
    public const string Copying_Icon_Name_Class = $"clock-loader-icon";

    public const string Button_Min_Width_Var_Name = "--_button-min-width";
 

    public static string? GetStyleAsValue(StyleAs styleAs)

        => styleAs switch
        {
            StyleAs.OnLight => Style_As_Light,
            StyleAs.OnDark  => Style_As_Dark,
            _ => null
        };
}
