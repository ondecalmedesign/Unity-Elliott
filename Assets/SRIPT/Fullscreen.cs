using UnityEngine;
public class Fullscreen : MonoBehaviour
{
    void Start()
    {
        Screen.fullScreen = true; 
         print("fullscreen off");
    }

void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
           Screen.fullScreen = !Screen.fullScreen; 
            print("fullscreen");
        }
    }
}
