using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameUIManager : MonoBehaviour
{
    public GameObject loadCanvas;
    public GameObject instantiatedLoadCanvas;
    private string instantiatedLoadCanvasTag;
    private bool isActive;
    public GameObject loadData;
    public void ActivateCanvas()
    {
        if(loadCanvas != null)
        {
            if (instantiatedLoadCanvas == null)
            {
                instantiatedLoadCanvas = Instantiate(loadCanvas);
                instantiatedLoadCanvasTag = instantiatedLoadCanvas.tag;
                
                Transform childTransform = instantiatedLoadCanvas.transform.GetChild(0);
                GameObject outerPanel = childTransform.gameObject;
                Transform outerPanelTransform = outerPanel.transform;
                GameObject innerPanel = Instantiate(loadData, outerPanelTransform);
                innerPanel.transform.SetParent(outerPanelTransform, true);
                

            }
        }
    }

    public void closedLoadUI()
    {
        try
        {
            GameObject loadUI = GameObject.FindGameObjectWithTag(instantiatedLoadCanvasTag);
            Debug.Log(instantiatedLoadCanvasTag);
            Destroy(loadUI);
            instantiatedLoadCanvas = null;

        }
        catch (System.Exception e)
        {
            Debug.Log(e.ToString());
        }
    }
}
