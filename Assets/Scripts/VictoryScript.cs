using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class VictoryScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E was pressed");
                StartCoroutine (VictoryEnd());
                source.PlayOneShot(clip);
            }
        }
    }

    //game closes
    private IEnumerator VictoryEnd()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();
        Debug.Log("Quit");
    }
}
