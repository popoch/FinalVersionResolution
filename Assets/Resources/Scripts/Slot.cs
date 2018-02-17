using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{

    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }



    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            draggable.itemBeginDragged.transform.SetParent(transform);
            ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
            //Debug.Log("dropped");
            ApplicationModel.dropNumberCount++;
        }
        else
        {
            Transform aux = draggable.itemBeginDragged.transform.parent;
            draggable.itemBeginDragged.transform.SetParent(transform);
            item.transform.SetParent(aux);
            //Debug.Log("switched");
        }

        
    }
}
