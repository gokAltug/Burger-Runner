using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        AudioManager.instance.PlaySound(AudioManager.instance.obstacle);
        gameObject.GetComponent<Collider>().enabled = false;
        StackManager.instance.hamburgerStack.Add(gameObject);
        StackManager.instance.HamburgerStackPositioner();
        UIManager.Instance.UpdateStackCountUI();
    }
}
