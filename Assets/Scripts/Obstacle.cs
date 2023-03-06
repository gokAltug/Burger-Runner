using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        AudioManager.instance.PlaySound(AudioManager.instance.ouch);
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.SetActive(false);
        Player.Instance.playerAnimator.SetTrigger("Hit");
        StackManager.instance.RemoveFromHamburgerStack();
        StackManager.instance.HamburgerStackPositioner();
        UIManager.Instance.UpdateStackCountUI();
    }
}
