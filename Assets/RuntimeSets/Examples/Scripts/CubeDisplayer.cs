using System;
using Flamers;
using UnityEngine;
using UnityEngine.UI;

public class CubeDisplayer : MonoBehaviour
{
    [SerializeField]
    private RuntimeCubeBehaviorList runtimeCubeBehaviorList;

    [SerializeField]
    private Text counterCubeEnabledText;

    [SerializeField]
    private Text lastEventText;

    private void Start()
    {
        runtimeCubeBehaviorList.SuccessAddItem += OnEnabledCube;
        runtimeCubeBehaviorList.SuccessRemoveItem += OnDisableCube;
    }

    private void OnDisableCube(CubeBehavior obj)
    {
        if(lastEventText)
            lastEventText.text = "The cube named " + obj.gameObject.name + " is disabled";
    }

    private void OnEnabledCube(CubeBehavior obj)
    {
        if(lastEventText)
            lastEventText.text = "The cube named " + obj.gameObject.name + " is enabled";
    }

    private void Update()
    {
        UpdateCounterText();
    }

    private void UpdateCounterText()
    {
        counterCubeEnabledText.text = "Cubes : " + runtimeCubeBehaviorList.Items.Count + " enabled";
    }
}
