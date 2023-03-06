using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public GameObject tap2playButton;
    [SerializeField] TextMeshProUGUI coinCountText,stackCounText;
    int coinCount;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCoinUI(int addCoin)
    {
        coinCount += addCoin;
        coinCountText.text = coinCount.ToString();
    }

    public void UpdateStackCountUI()
    {
        stackCounText.text = (StackManager.instance.hamburgerStack.Count - 1).ToString();
    }
}
