using UnityEngine;

public class Shop : MonoBehaviour
{
    
    

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void purchaseStandardTurret()
    {
        Debug.Log("Standard turret purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void purchaseMissileTurret()
    {
        Debug.Log("Missile turret purchased");
        buildManager.SetTurretToBuild(buildManager.MissileTurretPrefab);
    }
}