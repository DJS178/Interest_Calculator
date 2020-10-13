using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{

    public GameObject cube;
    public float interestRate;
    Transform cube_transform;
    Vector3 currentVolumeVector;
    float cubeLength,cubeHeight,cubeWidth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            CalculateInterest();
        }
    }


    public void CalculateInterest() {
        Transform transform = cube.transform;
        float cubeLength = transform.localScale.x;
        float cubeWidth = transform.localScale.z;
        float cubeHeight = transform.localScale.y;

        cubeLength *= interestRate;
        cubeWidth *= interestRate;
        cubeHeight *= interestRate;

        transform.localScale = new Vector3(cubeLength,cubeHeight,cubeWidth);
        float newVolume = cubeLength * cubeHeight * cubeWidth;
        Debug.Log("New Volume: " + newVolume);

    }
}
