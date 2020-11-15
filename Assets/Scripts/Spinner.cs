using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

    [SerializeField] float minSpeedOfSpin = 0f;
    [SerializeField] float maxSpeedOfSpin = 180f;

    // Update is called once per frame
    void Update() {
        transform.Rotate(0, 0, Random.Range(minSpeedOfSpin, maxSpeedOfSpin) * Time.deltaTime);
    }
}
