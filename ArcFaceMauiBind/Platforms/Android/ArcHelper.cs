using System.Runtime.CompilerServices;

namespace ArcFaceMauiBind;

public class ArcHelper
{
    public static int ActiveOnline(string? appId, string? sdkKey)
    {
        return Com.Arcsoft.Face.FaceEngine.ActiveOnline(Platform.CurrentActivity, appId, sdkKey);
    }
}