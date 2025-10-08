using UnityEngine;

public class DialougeMouseScript : MonoBehaviour
{
    //this shows/hides the mouse when dialouge occurs/ends 
    public void DisplayMouse()
    {
        Cursor.visible = true;
    }

    public void HideMouse()
    {
        Cursor.visible = false;
    }
}
