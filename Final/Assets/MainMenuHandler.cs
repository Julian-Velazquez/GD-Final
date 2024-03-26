using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] CreatureSO creatureSO;
    void Start(){
        creatureSO.coins =0;
        creatureSO.deaths = 0;
        creatureSO.doubleJump = 0;
    }

    public void Play()
    {
       SceneManager.LoadScene("SampleScene"); 
    }

    public void Quit(){
        Application.Quit();
    }

}
