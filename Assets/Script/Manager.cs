using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    //abbreviations
    public Text[] displayText;

    //MONEY
    public int coinBronze;
    public int coinSilver;
    public int coinGold;
    public Text bronzeText;
    public Text silverText;
    public Text goldText;

    //ITEM
    public int Wood;
    public int Paper;
    public int Wool;
    public int Leather;
    public int Rope;

    public int Planks;

    //TEXT ITEM
    public Text WoodText;
    public Text PaperText;
    public Text WoolText;
    public Text LeatherText;
    public Text RopeText;

    public Text PlanksText;

    //COST
    int costToBuyWood = 100;
    int costToBuyPaper = 300;
    int costToBuyWool = 400;
    int costToBuyLeather = 200;
    int costToBuyRope = 50;

    int costToBuyPlanks = 800;

    //SELL COST
    int costToSellWood = 50;
    int costToSellPaper = 150;
    int costToSellWool = 200;
    int costToSellLeather = 100;
    int costToSellRope = 25;

    int costToSellPlanks = 300;

    //Progress bar


    void Start()
    {
        //PlayerPrefs.DeleteAll();
        

        //LOAD PROGRESS
        coinBronze = PlayerPrefs.GetInt("coinBronze", coinBronze);
        coinSilver = PlayerPrefs.GetInt("coinSilver", coinSilver);
        coinGold = PlayerPrefs.GetInt("coinGold", coinGold);
        Wood = PlayerPrefs.GetInt("Wood", Wood);
        Paper = PlayerPrefs.GetInt("Paper", Paper);
        Wool = PlayerPrefs.GetInt("Wool", Wool);
        Leather = PlayerPrefs.GetInt("Leather", Leather);
        Rope = PlayerPrefs.GetInt("Rope", Rope);
        Planks = PlayerPrefs.GetInt("Planks", Planks);
    }

    void Update()
    {
        bronzeText.text = "" + coinBronze;
        silverText.text = "" + coinSilver;
        goldText.text = "" + coinGold;
        WoodText.text = "" + Wood;
        PaperText.text = "" + Paper;
        WoolText.text = "" + Wool;
        LeatherText.text = "" + Leather;
        RopeText.text = "" + Rope;
        PlanksText.text = "" + Planks;

        for (int i = 0; i < displayText.Length; i++)
        {
            int number = 0;
            switch (i)
            {
                case 0:
                    number = coinBronze;
                    break;
                case 1:
                    number = coinSilver;
                    break;
                case 2:
                    number = coinGold;
                    break;
                case 3:
                    number = Wood;
                    break;
                case 4:
                    number = Paper;
                    break;
                case 5:
                    number = Wool;
                    break;
                case 6:
                    number = Leather;
                    break;
                case 7:
                    number = Rope;
                    break;
                case 8:
                    number = Planks;
                    break;
            }

            displayText[i].text = FormatNumber(number);
        }
    }

    public string FormatNumber(int number)
    {
        if (number >= 1000000000)
        {
            return (number / 1000000000f).ToString("0.#") + "B";
        }
        else if (number >= 1000000)
        {
            return (number / 1000000f).ToString("0.#") + "M";
        }
        else if (number >= 1000)
        {
            return (number / 1000f).ToString("0.#") + "K";
        }
        else
        {
            return number.ToString();
        }
    }


    //BUY ITEMS
    public void BuyWood()
    {
        if (coinBronze >= costToBuyWood)
        {
            coinBronze -= costToBuyWood;
            WoodText.text = "" + Wood;
            Wood++;
            CancelInvoke("AddWood");
            InvokeRepeating("AddWood", 2.0f, 2f);
        }
    }
    public void BuyPaper()
    {
        if (coinBronze > costToBuyPaper)
        {
            coinBronze -= costToBuyPaper;
            PaperText.text = "" + Paper;
            Paper++;
            CancelInvoke("AddPaper");
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
            CancelInvoke("AddWool");
            InvokeRepeating("AddWool", 1.0f, 1.0f);
        }
    }
    
    public void BuyLeather()
    {
        if (coinBronze > costToBuyLeather)
        {
            coinBronze -= costToBuyLeather;
            LeatherText.text = "" + Leather;
            Leather++;
            CancelInvoke("AddLeather");
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
            CancelInvoke("AddRope");
            InvokeRepeating("AddRope", 1.0f, 1.0f);
        }
    }
    public void BuyPlanks()
    {
        if (coinBronze > costToBuyPlanks)
        {
            coinBronze -= costToBuyPlanks;
            PlanksText.text = "" + Planks;
            Planks++;
            CancelInvoke("AddPlanks");
            InvokeRepeating("AddPlanks", 15.0f, 15.0f);
        }
    }
    //SELL STORE
    public void SellWood()
    {
        if (Wood >= 1)
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
    public void SellLeather()
    {
        if (Leather >= 1)
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
    public void SellPlanks()
    {
        if (Planks >= 1)
        {
            Planks--;
            coinBronze += costToSellPlanks;
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
    public void AddLeather()
    {
        Leather++;
    }
    public void AddWool()
    {
        Wool++;
    }
    public void AddPlanks()
    {
        Planks++;
    }

    //SELL MAX EQUELS
    public void SellMaxWood()
    {
        if (Wood > 0)
        {
            int totalWood = Wood;
            Wood = 0;
            coinBronze += totalWood * costToSellWood;
        }
    }
    public void SellMaxPaper()
    {
        if (Paper > 0)
        {
            int totalPaper = Paper;
            Paper = 0;
            coinBronze += totalPaper * costToSellPaper;
        }
    }
    public void SellMaxWool()
    {
        if (Wool > 0)
        {
            int totalWool = Wool;
            Wool = 0;
            coinBronze += totalWool * costToSellWool;
        }
    }
    public void SellMaxLeather()
    {
        if (Leather > 0)
        {
            int totalLeather = Leather;
            Leather = 0;
            coinBronze += totalLeather * costToSellLeather;
        }
    }
    public void SellMaxRope()
    {
        if (Rope > 0)
        {
            int totalRope = Rope;
            Rope = 0;
            coinBronze += totalRope * costToSellRope;
        }
    }
    public void SellMaxPlanks()
    {
        if (Planks > 0)
        {
            int totalPlanks = Planks;
            Planks = 0;
            coinBronze += totalPlanks * costToSellPlanks;
        }
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
        PlayerPrefs.SetInt("Leather", Leather);
        PlayerPrefs.SetInt("Rope", Rope);
        PlayerPrefs.SetInt("Planks", Planks);
        PlayerPrefs.Save();
    }
}
