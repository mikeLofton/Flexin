using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorBehavior : MonoBehaviour
{
    private MeshRenderer _renderer;
    private RoutineBehavior.TimedAction _currentAction;

    // Start is called before the first frame update
    void Start()
    {
        _renderer.GetComponent<MeshRenderer>();
        RoutineBehavior.Instance.StartNewTimedAction(args => ChangeColor(), TimedActionCountType.SCALEDTIME, 3);
    }

    public void ChangeColor()
    {
        _renderer.material.color = new Color(Random.value, Random.value, Random.value, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentAction.IsActive)
            _currentAction = RoutineBehavior.Instance.StartNewTimedAction()
    }
}
