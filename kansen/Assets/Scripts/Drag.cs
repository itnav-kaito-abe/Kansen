using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class Drag : MonoBehaviour {

    Vector2 startPosition;
    Rigidbody2D bk ;
    float speed = 1;
    bool Mobe = true;

	// Use this for initialization
	void Start () {

        var eventTrigger = GetComponent<EventTrigger>();
            var beginDragEntry = new EventTrigger.Entry();
            beginDragEntry.eventID = EventTriggerType.PointerDown;
            beginDragEntry.callback.AddListener(data =>
            {
                OnBeginDrag((PointerEventData)data);
            });
            eventTrigger.triggers.Add(beginDragEntry);

            var dragEntry = new EventTrigger.Entry();
            dragEntry.eventID = EventTriggerType.Drag;
            dragEntry.callback.AddListener(data =>
            {
                OnDrag((PointerEventData)data);
            });
            eventTrigger.triggers.Add(dragEntry);

            var endDragEntry = new EventTrigger.Entry();
            endDragEntry.eventID = EventTriggerType.EndDrag;
            endDragEntry.callback.AddListener(data =>
            {
                OnEndDrag((PointerEventData)data);
            });
            eventTrigger.triggers.Add(endDragEntry);
		
           
           
	}
	
	// Update is called once per frame
	void Update ()
    {

        if(Mobe == false) {
            speed = speed * 0.99f;
        }

        if(speed < 0.5) {
            bk.velocity = Vector2.zero;
            Mobe = true;
        }

	}

    void OnBeginDrag(PointerEventData data)
    {
        startPosition = data.position;
        speed = 1;
    }

    void OnDrag(PointerEventData data)
    {
        var diff = startPosition - data.position;
    }

    void OnEndDrag(PointerEventData data)
    {
        bk = GetComponent<Rigidbody2D>();
        var diff = startPosition - data.position;
        bk.velocity = diff*speed;
        Mobe = false;
    }

}
