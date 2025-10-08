using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUi;
    [SerializeField] private bool isPaused;

    //toggling escape key toggles if pause menu should or shouldn't be active
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        //cursor.visable may not be needed, but pressing esc in the editor will force the mouse to be visable regardless of code
        else
        {
            DeactivateMenu();
            Cursor.visible = false;
        }
    }

    //these controll the visability of the pause menu
    //audio listener is for wether the player should be able to hear sound while paused. 
    void ActivateMenu()
    {
        Cursor.visible = true;
        AudioListener.pause = true;
        Time.timeScale = 0;
        pauseMenuUi.SetActive(true);
    }

    //this is public so the resume key can also activate this
    public void DeactivateMenu()
    {
        Cursor.visible = false;
        AudioListener.pause = false;
        Time.timeScale = 1;
        pauseMenuUi.SetActive(false);
        isPaused = false;
    }
}
