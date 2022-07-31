public int coins;
public Text coinText;
// Start is called before the first frame update
void Start()
{

}
// Update is called once per frame.
void Update()
{
    coinText.text= "Coins:"+coins.ToString();
}