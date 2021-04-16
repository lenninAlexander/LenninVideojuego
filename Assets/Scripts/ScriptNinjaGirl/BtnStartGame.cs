using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnStartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void startGame()
    {
        SceneManager.LoadScene("SceneNinjaGirl");
    }

    // Update is called once per frame
  
}
