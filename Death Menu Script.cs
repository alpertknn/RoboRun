public Text scoreText;
public Image backgroundImg;
public GameObject coinObject;
public bool isShown = false;
private float transition = 0.0f;
// Start is called before the first frame update
void Start()
{
    gameObject.SetActive(false);
    //GameObject.FindGameObjectWithTag("CoinText").GetComponent<CoinScript>();
}
// Update is called once per frame.
void Update()
{
    if (!isShown)
    {
        return;
    }
    coinObject.transform.parent= this.gameObject.transform;
    transition+=Time.deltaTime;
    backgroundImg.color = Color.Lerp(new Color(0,0,0,0), Color.black, transition);

}
public void ToggleEndMenu(float score)
{
        gameObject.SetActive(true);
        score,.text="Your Score is: "+((int)score).ToString();
        isShown=true;
}
public void ToMenu()
{
    backgroundImg.DisableSpriteOptimizations();
    SceneManager.LoadScene("GameMenu");
}
public void QuitGame()
{
    Application.Quit();
    Debug.Log("Quit!");
}