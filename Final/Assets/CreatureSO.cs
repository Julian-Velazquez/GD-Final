using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CreatureSO")]
public class CreatureSO : ScriptableObject
{
    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
    public int coins = 0;
    public int deaths = 0;
    public int doubleJump = 0;

    public string sceneLoad = "";
}
