using UnityEngine;
using UnityEngine.Events;

public class UIController : MonoBehaviour
{
    public GameObject quitDialog;
    public UnityEvent myEvent;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")) {
            quitDialog.SetActive(true);
            myEvent.Invoke();
        }   
    }
    
    public void QuitApp() {
        print("The App has Quit!");
        Application.Quit();
    }
}
