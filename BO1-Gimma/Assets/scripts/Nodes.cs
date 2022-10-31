
using UnityEngine;
using UnityEngine.EventSystems;

public class Nodes : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;
    private GameObject turret;

    BuildManager buildManager;

    private Renderer Rend;
    private Color startcolor;
    void Start()
    {
        Rend = GetComponent<Renderer>();
        startcolor = Rend.material.color;

        buildManager = BuildManager.instance;

        
    }

   //public Vector3 GetBuildPosition()
    //{
   //     return transform.position + positionOffset;
    //}

   void OnMouseDown()
    {
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if (turret != null)
        {
            Debug.Log("You Cant Build Here!");
            return;
        }

        //buildManager.BuildTurretOn(this);
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);

    }
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        
        if (!buildManager.standardTurretPrefab)
            return;

        

        Rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        Rend.material.color = startcolor;
    }
}
