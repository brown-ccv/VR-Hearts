using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeMainModel : MonoBehaviour
{

    public InputActionReference changeModelReference = null;
    
    public GameObject[] hearts;
    public GameObject[] labels;

    
    private int currentObject = 0;

    private void Awake()
    {
        changeModelReference.action.started += Change;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void Change(InputAction.CallbackContext ctx)
    {

        int nextObject = (currentObject + 1) % hearts.Length;

        // swap models
        Vector3  centralObjectPosition = hearts[currentObject].transform.position;
        Quaternion centralObjectRotation = hearts[currentObject].transform.rotation;
        Vector3 nextObjectPosition = hearts[nextObject].transform.position;
        Quaternion nextObjectRotation = hearts[nextObject].transform.rotation;

        hearts[currentObject].transform.position = nextObjectPosition;
        hearts[currentObject].transform.rotation = nextObjectRotation;
        hearts[nextObject].transform.position = centralObjectPosition;
        hearts[nextObject].transform.rotation = centralObjectRotation;
        

        //swap labels
        Vector3 centralLabelPosition = labels[currentObject].transform.position;
        Vector3 nextLabelPosition = labels[nextObject].transform.position;

        labels[currentObject].transform.position = nextLabelPosition;
        labels[nextObject].transform.position = centralLabelPosition;
        

        currentObject = nextObject;
    }
}
