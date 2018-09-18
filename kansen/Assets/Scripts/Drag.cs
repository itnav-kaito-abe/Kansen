using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class Drag : MonoBehaviour {

    Vector2 startPosition;
    Rigidbody2D bk;
    float speed = 1;
    bool Mobe = true;
    GameObject arrow;
    GameObject pc;

	// Use this for initialization
	void Start () {

        pc = GameObject.Find("baikin_hana");
        
        arrow = GameObject.Find("baikin_hana").transform.Find("arrow").gameObject;
        arrow.gameObject.SetActive(false);

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
        pc.transform.rotation = Quaternion.identity;

        if(Mobe == false) {
            speed = speed * 0.99f;
        }

        if(speed < 0.5) {
            bk.velocity = Vector3.zero;
            pc.transform.rotation = Quaternion.identity;
            Mobe = true;
        }
	}

    void OnBeginDrag(PointerEventData data)
    {
        startPosition = data.position;
        speed = 1;
        arrow.SetActive(true);
    }

    void OnDrag(PointerEventData data)
    {
        var diff = startPosition - data.position;
        float arrowx = data.position.x - startPosition.x;
        float arrowy = data.position.y - startPosition.y;
        float rad = Mathf.Atan2(arrowy,arrowx);
        rad = rad * Mathf.Rad2Deg;
        rad = 90 + rad;
        arrow.transform.rotation = Quaternion.Euler(0,0,rad);
   
        arrow.transform.localScale = new Vector2(3,(diff.magnitude)/200);       
    }

    void OnEndDrag(PointerEventData data)
    {
        bk = pc.GetComponent<Rigidbody2D>();
        var diff = startPosition - data.position;
        bk.velocity = diff*speed;
        Mobe = false;
        arrow.SetActive(false);
    }

}
