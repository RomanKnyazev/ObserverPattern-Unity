using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.UIElements;


public class GameController : MonoBehaviour
{
    public GameObject FirstBoxGameObject;
    public GameObject SecondBoxGameObject;

    readonly Subject subject = new Subject();


    private void Start()
    {
        var secondBox = new Box(SecondBoxGameObject, new Move());
        subject.AddObserver(secondBox);
    }


    private void Update()
    {
        Debug.Log(FirstBoxGameObject.transform.position.magnitude);
        if (FirstBoxGameObject.transform.position.magnitude < 3.3)  subject.Notify();
    }
}
