using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class isMouseHoover : MonoBehaviour
{   
    public UnityEvent onHoverEvent;
    public UnityEvent onUnhoverEvent;
    bool isHovered;


    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

        
    void OnMouseEnter() {
        isHovered = true;
        Debug.Log("on object");
        onHoverEvent.Invoke();
    }

    void OnMouseExit() {
        isHovered = false;
        Debug.Log("not on object");
        onUnhoverEvent.Invoke();
        
    }

    void OnMouseDown(){
        Debug.Log(inkJSON.text);
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
}
