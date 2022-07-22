using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetUI : MonoBehaviour
{
    [Header("Detecting Planets-Variables")]
    private Camera _mainCamera;
    private Ray _ray;
    private RaycastHit _hit;

    [Header("Reach out other scripts")]
    public CameraRotater cameraRotater;

    [Header("UI Elements")]
    public GameObject venusUI, marsUI,mercuryUI, sunUI, earthUI;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(_ray, out _hit, 1000f))
            {
                if(_hit.collider.gameObject.CompareTag("Venus"))
                {
                    cameraRotater.isClicked = true;
                    venusUI.gameObject.SetActive(true);
                }
                else if (_hit.collider.gameObject.CompareTag("Earth"))
                {
                    cameraRotater.isClicked = true;
                    earthUI.gameObject.SetActive(true);
                }
                else if (_hit.collider.gameObject.CompareTag("Mars"))
                {
                    cameraRotater.isClicked = true;
                    marsUI.gameObject.SetActive(true);
                }
                else if (_hit.collider.gameObject.CompareTag("Mercury"))
                {
                    cameraRotater.isClicked = true;
                    mercuryUI.gameObject.SetActive(true);
                }
                else
                {
                    cameraRotater.isClicked = true;
                    sunUI.gameObject.SetActive(true);
                }
            }
        }

        if(!venusUI.activeSelf && !marsUI.activeSelf && !mercuryUI.activeSelf && !sunUI.activeSelf && !earthUI.activeSelf)
        {
            cameraRotater.isClicked = false;
        }


    }
}
