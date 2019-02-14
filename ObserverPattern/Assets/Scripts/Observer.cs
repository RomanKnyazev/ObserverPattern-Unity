using UnityEngine;

public abstract class Observer
{
    public abstract void OnNotify();
}

public class Box : Observer
{
    private GameObject _simpleObject;
    private BoxEvents boxEvent;

    public Box(GameObject boxObj, BoxEvents boxEvent)
    {
        _simpleObject = boxObj;
        this.boxEvent = boxEvent;
    }

    public override void OnNotify()
    {
        MoveForward(boxEvent.GetForce());
    }

    private void MoveForward(float jumpForce)
    {
        if (_simpleObject.transform.position.y < 0.55f)
        {
            var gameobjectRigidbody = _simpleObject.GetComponent<Rigidbody>();
            gameobjectRigidbody.AddForce(Vector3.forward * jumpForce);
        }
    }
}
