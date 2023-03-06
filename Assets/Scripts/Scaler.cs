using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{

    [SerializeField] float scaleAmount, scaleTime;

    
    void Start()
    {
        transform.DOScale(scaleAmount, scaleTime).SetLoops(-1,LoopType.Yoyo);
    }

    
    void Update()
    {
        
    }
}
