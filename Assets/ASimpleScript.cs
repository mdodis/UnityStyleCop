using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script does something interesting.
/// </summary>
public class ASimpleScript : MonoBehaviour
{
    [SerializeField]
    private bool simulateMovemet = false;

    private void Update()
    {
        var currentPosition = transform.position;
        currentPosition.x += Time.deltaTime * 1.0f;
        transform.position = currentPosition;

        var random = 2;
    }
}
