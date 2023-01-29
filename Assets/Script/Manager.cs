using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    //MONEY
    public int coinBronze;
    public int coinSilver;
    public int coinGold;
    public Text bronzeText;
    public Text silverText;
    public Text goldText;

    //ITEM
    int Wood;
    int Paper;
    int Wool;
    int Planks;
    int Leather;
    int Rope;

    //TEXT ITEM
    public Text WoodText;
    public Text PaperText;
    public Text WoolText;
    public Text PlanksText;
    public Text LeatherText;
    public Text RopeText;

    //COST
    int costToBuyWood = 100;
    int costToBuyPaper = 300;
    int costToBuyWool = 400;
    int costToBuyPlanks = 1000;
    int costToBuyLeather = 200;
    int costToBuyRope = 50;

    //SELL COST
    int costToSellWood = 50;
    int costToSellPaper = 150;
    int costToSellWool = 200;
    int costToSellPlanks = 500;
    int costToSellLeather = 100;
    int costToSellRope = 25;


    void Start()
    {
        //PlayerPrefs.DeleteAll();
        //CancelInvoke("AddWood");
        //CancelInvoke("AddWool");
        //CancelInvoke("AddPaper");
        //CancelInvoke("AddPlanks");
        //CancelInvoke("AddLeather");
        //CancelInvoke("AddRope");

        //LOAD PROGRESS
        coinBronze = PlayerPrefs.GetInt("coinBronze", coinBronze);
        coinSilver = PlayerPrefs.GetInt("coinSilver", coinSilver);
        coinGold = PlayerPrefs.GetInt("coinGold", coinGold);
        Wood = PlayerPrefs.GetInt("Wood", Wood);
        Paper = PlayerPrefs.GetInt("Paper", Paper);
        Wool = PlayerPrefs.GetInt("Wool", Wool);
        Planks = PlayerPrefs.GetInt("Planks", Planks);
        Leather = PlayerPrefs.GetInt("Leather", Leather);
        Rope = PlayerPrefs.GetInt("Rope", Rope);
    }

    void Update()
    {
        bronzeText.text = "" + coinBronze;
        silverText.text = "" + coinSilver;
        goldText.text = "" + coinGold;
        WoodText.text = "" + Wood;
        PaperText.text = "" + Paper;
        WoolText.text = "" + Wool;
        PlanksText.text = "" + Planks;
        LeatherText.text = "" + Leather;
        RopeText.text = "" + Rope;

    }
    //BUY ITEMS
    public void BuyWood()
    {
        if (coinBronze >= costToBuyWood)
        {
            coinBronze -= costToBuyWood;
            WoodText.text = "" + Wood;
            Wood++;
            InvokeRepeating("AddWood", 2.0f, 2.0f);
        }
    }
    public void BuyPaper()
    {
        if (coinBronze > costToBuyPaper)
        {
            coinBronze -= costToBuyPaper;
            PaperText.text = "" + Paper;
            Paper++;
            InvokeRepeating("AddPaper", 3.0f, 3.0f);
        }
    }
    public void BuyWool()
    {
        if (coinBronze > costToBuyWool)
        {
            coinBronze -= costToBuyWool;
            WoolText.text = "" + Wool;
            Wool++;
            InvokeRepeating("AddWool", 1.0f, 1.0f);
        }
    }
    public void BuyPlanks()
    {
        if (coinBronze > costToBuyPlanks)
        {
            coinBronze -= costToBuyPlanks;
            PlanksText.text = "" + Planks;
            Planks++;
            InvokeRepeating("AddPlanks", 15.0f, 15.0f);
        }
    }
    public void BuyLeather()
    {
        if (coinBronze > costToBuyLeather)
        {
            coinBronze -= costToBuyLeather;
            LeatherText.text = "" + Leather;
            Leather++;
            InvokeRepeating("AddLeather", 5.0f, 5.0f);
        }
    }
    public void BuyRope()
    {
        if (coinBronze > costToBuyRope)
        {
            coinBronze -= costToBuyRope;
            RopeText.text = "" + Rope;
            Rope++;
            InvokeRepeating("AddRope", 1.0f, 1.0f);
        }
    }
    //SELL STORE
    public void SellWood()
    {
        if (Wood >= 1 || Paper >= 1 || Wool >= 1 || Planks >= 1 || Leather >= 1 || Rope >= 1)
        {
            Wood--;
            coinBronze += costToSellWood;
        }
    }
    public void SellPaper()
    {
        if (Paper >= 1)
        {
            Paper--;
            coinBronze += costToSellPaper;
        }
    }
    public void SellWool()
    {
        if (Wool >= 1)
        {
            Wool--;
            coinBronze += costToSellWool;
        }
    }
    public void SellPlanks()
    {
        if (Planks >= 1)
        {
            Planks--;
            coinBronze += costToSellPlanks;
        }
    }
    public void SellLeather()
    {
        if (Planks >= 1)
        {
            Leather--;
            coinBronze += costToSellLeather;
        }
    }
    public void SellRope()
    {
        if (Rope >= 1)
        {
            Rope--;
            coinBronze += costToSellRope;
        }
    }
    //ADD ITEMS
    public void AddRope()
    {
        Rope++;
    }
    public void AddWood()
    {
        Wood++;
    }
    public void AddPaper()
    {
        Paper++;
    }
    public void AddPlanks()
    {
        Planks++;
    }
    public void AddLeather()
    {
        Leather++;
    }
    public void AddWool()
    {
        Wool++;
    }

    //SAVE PROGRESS
    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("coinBronze", coinBronze);
        PlayerPrefs.SetInt("coinSilver", coinSilver);
        PlayerPrefs.SetInt("coinGold", coinGold);
        PlayerPrefs.SetInt("Wood", Wood);
        PlayerPrefs.SetInt("Paper", Paper);
        PlayerPrefs.SetInt("Wool", Wool);
        PlayerPrefs.SetInt("Planks", Planks);
        PlayerPrefs.SetInt("Leather", Leather);
        PlayerPrefs.SetInt("Rope", Rope);
        PlayerPrefs.Save();
    }
}
