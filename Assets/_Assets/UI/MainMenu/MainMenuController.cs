using UnityEngine;
using NatureVoice.Core;

namespace NatureVoice.UI
{
    /// <summary>
    /// Handles Main Menu button events.
    /// SRP: Only reacts to UI and delegates scene changes.
    /// </summary>
    public class MainMenuController : MonoBehaviour
    {
        // Called by the "Play with AR" button
        public void OnPlayWithAR()
        {
            SceneLoader.Instance.LoadScene(SceneNames.ARForestScene);
        }

        // Called by the "Play with Mobile" button
        public void OnPlayWithMobile()
        {
            SceneLoader.Instance.LoadScene(SceneNames.MobileForestScene);
        }
    }
}
