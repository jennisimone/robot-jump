using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public GameManager gameManager;
    public TextMeshProUGUI currentScore;

    private void LateUpdate() {
        if (target.position.y > transform.position.y) {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
            gameManager.currentScore = (int)newPosition.y;
            currentScore.text = "Current score: " + gameManager.currentScore.ToString() + "m";
        }
    }
}
