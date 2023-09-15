using System.Collections.Generic;

[System.Serializable]
public class SceneSave
{
    public Dictionary<string, int> intDictionary;
    public Dictionary<string, bool> boolDictionary;    // string key is an identifier name we choose for this list
    public Dictionary<string, string> stringDictionary;
    public Dictionary<string, Vector3Serializable> vector3Dictionary;
    public Dictionary<string, int[]> intArrayDictionary;
    public List<SceneItem> listSceneItem;
    public Dictionary<string, GridPropertyDetails> gridPropertyDetailsDictionary;
    public List<InventoryItem>[] listInvItemArray;
}

