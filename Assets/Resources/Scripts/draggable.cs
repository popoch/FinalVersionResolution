using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public static GameObject itemBeginDragged;
    public Transform parentToReturnTo = null;
    public Vector3 positionToReturnTo;
    Transform startParent;
    Vector3 startPosition;



    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeginDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        if (transform.parent.parent.name.Equals("Option"))
        {
            positionToReturnTo = transform.position;
            parentToReturnTo = transform.parent;
        }
        //this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeginDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPosition;

            if (transform.parent.parent.name.Equals("Answer"))
            {
                transform.position = positionToReturnTo;
                transform.SetParent(parentToReturnTo);
            }
        }
        
    }

}
