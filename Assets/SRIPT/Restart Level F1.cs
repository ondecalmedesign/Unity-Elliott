using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class RestartLevelF1 : MonoBehaviour
{

            

    void Update()

    
    
      {  

        if (Input.GetKeyDown(KeyCode.O))
    
     { ResetTheGame();

    }
    }
        public void ResetTheGame()
{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}

