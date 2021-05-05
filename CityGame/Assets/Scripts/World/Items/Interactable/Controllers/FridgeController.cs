﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps; 

/// <summary>
/// 1.When Creating a new ite, set the item parent down below;
/// </summary>
public class FridgeController : InteractableController
{
    public InteractableItem interactableItem;

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Doing something for fridge Eventually");

    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public InteractableItem GetItem()
    {
        return interactableItem;
    }
}
