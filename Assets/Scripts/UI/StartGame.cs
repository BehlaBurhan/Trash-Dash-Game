using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Button loadGame;

    private void OnEnable()
    {
        loadGame.onClick.RemoveAllListeners();
        loadGame.onClick.AddListener(() => loadGame.gameObject.SetActive(false));
    }
    
}
