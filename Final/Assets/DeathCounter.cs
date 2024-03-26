using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DeathCounterText;
    [SerializeField] CreatureSO creatureSO;
    int deathsTotal = 0;
    string textD = "Deaths: ";
    
    void Start(){
        if(creatureSO != null){
            deathsTotal = creatureSO.deaths;
        }
        DeathCounterText.text = textD + deathsTotal.ToString();
    }

    public void CountDeath(){
        deathsTotal += 1;
        
        DeathCounterText.text = textD + deathsTotal.ToString();
        if(creatureSO != null){
            creatureSO.deaths++;
        }
    }
}
