using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinCollectionAnimation : MonoBehaviour
{


    public static CoinCollectionAnimation Instance;
    [SerializeField] GameObject m_coin3D;
    [SerializeField] float m_Coin3DAnimTime;
    [SerializeField] Transform m_CoinTargetPosition;
    

    private void Awake()
    {
        Instance = this;
    }

    

    public void CoinCollectAnim(Vector3 currentPosition)
    {
        var collectedCoin = Instantiate(m_coin3D, currentPosition, Quaternion.identity) as GameObject;
        collectedCoin.transform.DOMove(m_CoinTargetPosition.position, m_Coin3DAnimTime).OnComplete(() => collectedCoin.SetActive(false));
       

    }

    
}
