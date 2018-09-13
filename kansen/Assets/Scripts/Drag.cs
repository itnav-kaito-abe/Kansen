using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class Drag : MonoBehaviour {

    Vector2 startPosition;
    Rigidbody2D bk;
    float speed = 1;
    GameObject Arrow_image;
    bool Mobe = true;

	// Use this for initialization
	void Start () {

        //GameObject pc = GameObject.Find("baikin_hana");
        //GameObject arrow = GameObject.Find("baikin_hana").transform.Find("arrow").gameObject;
        
        

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
                OnDrag((PointerEventData)data,(GameObject)Arrow_image);
            });
            eventTrigger.triggers.Add(dragEntry);

            var endDragEntry = new EventTrigger.Entry();
            endDragEntry.eventID = EventTriggerType.EndDrag;
            endDragEntry.callback.AddListener(data =>
            {
                OnEndDrag((PointerEventData)data,(GameObject)Arrow_image);
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
        GameObject Arrow_image = new GameObject("Arrowimage");
        Arrow_image.transform.parent = GameObject.Find("baikin_hana").transform;
        Arrow_image.GetComponent<Transform>().transform.localScale = new Vector2(1,1);
        Arrow_image.GetComponent<Transform>().transform.localPosition = new Vector2(0,5);
        Arrow_image.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/UI/Combat/arrow");
        Arrow_image.GetComponent<SpriteRenderer>().sortingOrder = 3;
      
    }

    void OnDrag(PointerEventData data,GameObject Arrow_image)
    {
        var diff = startPosition - data.position;
        //Arrow_image.transform.rotation = 
    }

    void OnEndDrag(PointerEventData data,GameObject Arrow_image)
    {
        bk = GetComponent<Rigidbody2D>();
        var diff = startPosition - data.position;
        bk.velocity = diff*speed;
        Mobe = false;
        GameObject.Destroy(Arrow_image);
    }

}
