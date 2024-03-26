using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinCounterText;
    [SerializeField] CreatureSO creatureSO;
    int coinsCollected = 0;
    
    string score = "Score: ";
    void Start(){
        if(creatureSO != null){
            coinsCollected = creatureSO.coins;
        }
        coinCounterText.text = score + coinsCollected.ToString();
    }

    public void CountCoin(){
        coinsCollected += 1;
        
        coinCounterText.text = score + coinsCollected.ToString();
        if(creatureSO != null){
            creatureSO.coins++;
        }
    }
}
