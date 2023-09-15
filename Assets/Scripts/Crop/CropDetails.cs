using UnityEngine;

[System.Serializable]
public class CropDetails
{
    [ItemCodeDescription]
    public int seedItemCode;  // this is the item code for the corresponding seed
    public int[] growthDays; // days growth for each stage
    public GameObject[] growthPrefab;// prefab to use when instantiating growth stages
    public Sprite[] growthSprite; // growth sprite
    public Season[] seasons; // growth seasons
    public Sprite harvestedSprite; // sprite used once harvested
    [ItemCodeDescription]
    public int harvestedTransformItemCode; // if the item transforms into another item when harvested this item code will be populated
    public bool hideCropBeforeHarvestedAnimation; // if the crop should be disabled before the harvested animation
    public bool disableCropCollidersBeforeHarvestedAnimation;// if colliders on crop should be disabled to avoid the harvested animation effecting any other game objects
    public bool isHarvestedAnimation; // true if harvested animation to be played on final growth stage prefab
    public bool isHarvestActionEffect = false; // flag to determine whether there is a harvest action effect
    public bool spawnCropProducedAtPlayerPosition;
    public HarvestActionEffect harvestActionEffect; // the harvest action effect for the crop
    // public SoundName harvestSound; // the harvest sound for the crop

    [ItemCodeDescription]
    public int[] harvestToolItemCode; // array of item codes for the tools that can harvest or 0 array elements if no tool required
    public int[] requiredHarvestActions; // number of harvest actions required for corressponding tool in harvest tool item code array
    [ItemCodeDescription]
    public int[] cropProducedItemCode; // array of item codes produced for the harvested crop
    public int[] cropProducedMinQuantity; // array of minimum quantities produced for the harvested crop
    public int[] cropProducedMaxQuantity; // if max quantity is > min quantity then a random number of crops between min and max are produced
    public int daysToRegrow; // days to regrow next crop or -1 if a single crop


    /// <summary>
    /// returns true if the tool item code can be used to harvest this crop, else returns false
    /// </summary>
    public bool CanUseToolToHarvestCrop(int toolItemCode)
    {
        if (RequiredHarvestActionsForTool(toolItemCode) == -1)
        {
            return false;
        }
        else
        {
            return true;
        }

    }


    /// <summary>
    /// returns -1 if the tool can't be used to harvest this crop, else returns the number of harvest actions required by this tool
    /// </summary>
    public int RequiredHarvestActionsForTool(int toolItemCode)
    {
        for (int i = 0; i < harvestToolItemCode.Length; i++)
        {
            if (harvestToolItemCode[i] == toolItemCode)
            {
                return requiredHarvestActions[i];
            }
        }
        return -1;
    }

}

