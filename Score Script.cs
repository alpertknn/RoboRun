private float score=0.0f;
private int difficultyLevel=1;
private int maxDifficultyLevel=10;
private int scoreToNextLevel=10;
private bool isDead=false;
public Text scoreText;
public DeathMenu deathmenu;
public PauseMenu menu;

// Update is called once per frame
void update()
{
    if(score>=scoreToNextLevel) 
    {
        if (isDead)
        {
            return;
        }
        LevelUp();
    }
    if (menu.isPaused == false)
    {
        score+=Time.deltaTime*difficultyLevel+3;
        scoreText.text=((int)score).ToString();
    }
}
void LevelUp()
{
    if (difficultyLevel == maxDifficultyLevel)
        return;
    scoreToNextLevel*=2
    difficultyLevel++;
    GetComponent<PlayerMotor>().SetSpeed(difficultyLevel);
}
public void OnDeath()
{
    if (PlayerPrefs.GetFloat("Highscore")<score)
    {
        PlayerPrefs.SetFloat("Highscore",score);
    }
    deathmenu.ToggleEndMenu(score);
}