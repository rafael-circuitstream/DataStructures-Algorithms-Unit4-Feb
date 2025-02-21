using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler
{
    Vector3 dragPosition;
    public void OnDrag(PointerEventData eventData)
    {
        dragPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        transform.position = new Vector3(dragPosition.x, dragPosition.y, transform.position.z);
    }

}
