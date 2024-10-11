using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Knight : MonoBehaviour
{
    float speed = 5.0f;

    public void Move(Vector2 position)
    {
        StartCoroutine(MoveCoroutine(position));
    }

    private IEnumerator MoveCoroutine(Vector2 targetPosition)
    {
        Vector2 startPosition = transform.position;
        float journeyLength = (targetPosition - startPosition).magnitude;
        float traveled = 0f;

        if (journeyLength == 0)
        {
            transform.position = targetPosition;
            yield break;
        }

        while (traveled < journeyLength)
        {
            transform.position = Vector2.Lerp(startPosition, targetPosition, (traveled / journeyLength));
            traveled += speed * Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
