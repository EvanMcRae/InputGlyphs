using UnityEngine;

namespace InputGlyphs.Loaders
{
    [AddComponentMenu("InputGlyphs/Initializer/SteamGamepadGlyphInitializer")]
    public class SteamGamepadGlyphInitializer : MonoBehaviour
    {
#if STEAMWORKS_NET && !DISABLESTEAMWORKS && SUPPORT_ADAPTER
        private void Start()
        {
            if (InputGlyphManager.HasLoader<SteamGamepadGlyphLoader>())
            {
                return;
            }
            
            var loader = new SteamGamepadGlyphLoader();
            InputGlyphManager.RegisterLoader(loader);
        }
#endif
    }
}
