using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;
    [SerializeField] Transform hamburgerParent;
    [SerializeField] float extraStackDistance;
    public List<GameObject> hamburgerStack;
    [SerializeField] Transform topBun;

    private void Awake()
    {
        instance = this;
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HamburgerStackPositioner()
    {
        
        foreach (var item in hamburgerStack.Skip(1))
        {
            
            item.transform.position = hamburgerStack[hamburgerStack.IndexOf(item)-1].transform.position + new Vector3(0,item.GetComponent<BoxCollider>().size.y + extraStackDistance,0);
            item.transform.SetParent(hamburgerParent);
            
            
        }

        UpdateTopBunPosition();


    }

    public void RemoveFromHamburgerStack()
    {
        hamburgerStack[hamburgerStack.Count - 1].SetActive(false);
        hamburgerStack.RemoveAt(hamburgerStack.Count-1);
        
    }

    public void RemoveAllStack()
    {
        foreach (var item in hamburgerStack.Skip(1))
        {
            item.SetActive(false);
            hamburgerStack.Remove(item);
        }
        // hamburgerStack.RemoveRange(1, hamburgerStack.Count);
    }

    void UpdateTopBunPosition()
    {
        topBun.position = StackManager.instance.hamburgerStack[StackManager.instance.hamburgerStack.Count - 1].transform.position + new Vector3(0, 0.3f, 0);
    }


}
