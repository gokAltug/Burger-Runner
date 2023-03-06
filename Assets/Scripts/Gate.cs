using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Player.Instance.playerAnimator.SetTrigger("Dance");
        gameObject.GetComponent<BoxCollider>().enabled = false;
        CoinCollectionAnimation.Instance.CoinCollectAnim(transform.position);
        AudioManager.instance.PlaySound(AudioManager.instance.coinPickup);
        AudioManager.instance.PlaySound(AudioManager.instance.yuppie);
        StackManager.instance.RemoveAllStack();
        StackManager.instance.HamburgerStackPositioner();
        UIManager.Instance.UpdateCoinUI(25);
        UIManager.Instance.UpdateStackCountUI();
    }
}
