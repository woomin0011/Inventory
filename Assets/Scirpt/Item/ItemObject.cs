using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IInteractable
{
    public string GetInteractPrompt();
    public void OnInteract();
}
public class ItemObject : MonoBehaviour, IInteractable
{
    public ItemData data;

    public string GetInteractPrompt()
    {
        throw new System.NotImplementedException();
    }
    public void OnInteract()
    {
        throw new System.NotImplementedException();
    }
}
