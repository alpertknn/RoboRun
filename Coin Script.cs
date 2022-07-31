public CoinRenderer CoinText;
public int coins;
private bool game;
// Start is called before the first frame update
void Start()
{
  if (GameObject.FindGameObjectWithTag("Canvas")!=null)
  {
    CoinText= GameObject.FindGameObjectWithTag("Canvar").GetComponent<CoinRenderer>();
  }
}
// Update is called once per frame.
void Update()
{
    transform.Rotate(0,0,90*Time.deltaTime);


}
private void OnTriggerEnter(Collider other)
{
    if (other.name == "Player" && CoinText !=null)
    {
        CoinText.coins++;
        Destroy(gameObject);
    }
}
