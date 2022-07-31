void update()
{
    activeTiles= new List<GameObject>();
    playerTransform = GameObject.FindGameObjectWithTag("Player").trasform;
    for (int i = 0;i<amnTilesOnScreen;i++)
    {
        if (i<3)
        {
            SpawnTile(0);

        }
        else
        {
            SpawnTile();
        }
    }
}
private void Update()
{
    if(playerTransform.position.z-safeZone > 2+(spawnz*amnTilesOnScreen*tilelength))
    {
        SpawnTile();
        DeleteTile();
    }
}

private void SpawnTile(int prefabIndex=-1)
{
    GameObject go;
    if(prefabIndex == -1)
    {
        go=Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
    }
    else
    {
        go=Instantiate(tilePrefabs[prefabIndex]) as GameObject;
    }
    go.transform.SetParent(transform);
    go.transform.position= Vector3.forward*spawnz;
    spawnz+=tilelength;
    activeTiles.Add(go);

}

private Void DeleteTile()
{
    Destroy(activeTiles[0]);
    activeTiles.RemoveAt(0);
}
private int RandomPrefabIndex()
{
    if (tilePrefabs.Length <= 1)
    {
        return 0;
    }
    int randomIndex= lastprefabIIndex
    while (randomIndex== lastprefabIIndex)
    {
        randomIndex= Random.Range(0,tilePrefabs.Length);
    }
    lastprefabIIndex= randomIndex;
    return randomIndex;
}