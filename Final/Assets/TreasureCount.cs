using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TreasureCount : MonoBehaviour
{
     [SerializeField] private TextMeshProUGUI endText;
    

  

    public void collectTreasure(){
        
        endText.text = "You Win!";
        StartCoroutine(timerRoutine());
        IEnumerator timerRoutine(){
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("Main Menu"); 
        }
        
    }
}
