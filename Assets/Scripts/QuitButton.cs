using UnityEngine;

public class QuitButton : MonoBehaviour
{
    //quit does nothing in editor so debugLog is added to confirm if it works.
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
