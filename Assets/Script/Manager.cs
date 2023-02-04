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
    public int _stone;  
    public int _coal;
    public int _copper;
    public int _silver;
    public int _gold;
    public int _zinc;

    public int _coalClear;
    public int _copperClear;
    public int _silverClear;
    public int _goldClear;
    public int _zincClear;

    //TEXT ITEM
    public Text _stoneText;
    public Text _coalText;
    public Text _copperText;
    public Text _silverText;
    public Text _goldText;
    public Text _zincText;

    public Text _coalClearText;
    public Text _copperClearText;
    public Text _silverClearText;
    public Text _goldClearText;
    public Text _zincClearText;


    //COST
    int costToBuy_stone = 50;
    int costToBuyP_coal = 400;
    int costToBuy_copper = 800;
    int costToBuy_silver = 600;
    int costToBuy_gold = 2800;
    int costToBuy_zinc = 400;


    //SELL COST
    int costToSell_stone = 25;
    int costToSell_coal = 50;
    int costToSell_copper = 100;
    int costToSell_silver = 75;
    int costToSell_gold = 400;
    int costToSell_zinc = 50;


    void Start()
    {
        //PlayerPrefs.DeleteAll();


        //LOAD PROGRESS
        coinBronze = PlayerPrefs.GetInt("coinBronze", coinBronze);
        coinSilver = PlayerPrefs.GetInt("coinSilver", coinSilver);
        coinGold = PlayerPrefs.GetInt("coinGold", coinGold);
        _stone = PlayerPrefs.GetInt("_stone", _stone);
        _coal = PlayerPrefs.GetInt("_coal", _coal);
        _copper = PlayerPrefs.GetInt("_copper", _copper);
        _silver = PlayerPrefs.GetInt("_silver", _silver);
        _gold = PlayerPrefs.GetInt("_gold", _gold);
        _zinc = PlayerPrefs.GetInt("_zinc", _zinc);
        _coalClear = PlayerPrefs.GetInt("_coalClear", _coalClear);
        _copperClear = PlayerPrefs.GetInt("_coalClear", _copperClear);
        _silverClear = PlayerPrefs.GetInt("_silverClear", _silverClear);
        _goldClear = PlayerPrefs.GetInt("_goldClear", _goldClear);
        _zincClear = PlayerPrefs.GetInt("_zincClear", _zincClear);
    }
    //SAVE PROGRESS
    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("coinBronze", coinBronze);
        PlayerPrefs.SetInt("coinSilver", coinSilver);
        PlayerPrefs.SetInt("coinGold", coinGold);
        PlayerPrefs.SetInt("_stone", _stone);
        PlayerPrefs.SetInt("_coal", _coal);
        PlayerPrefs.SetInt("_copper", _copper);
        PlayerPrefs.SetInt("_silver", _silver);
        PlayerPrefs.SetInt("_gold", _gold);
        PlayerPrefs.SetInt("_zinc", _zinc);
        PlayerPrefs.SetInt("_clearCoal", _coalClear);
        PlayerPrefs.SetInt("_copperClear", _copperClear);
        PlayerPrefs.SetInt("_silverClear", _silverClear);
        PlayerPrefs.SetInt("_goldClear", _goldClear);
        PlayerPrefs.SetInt("_zincClear", _zincClear);
        PlayerPrefs.Save();
    }

    void Update()
    {
        bronzeText.text = "" + coinBronze;
        silverText.text = "" + coinSilver;
        goldText.text = "" + coinGold;

        _stoneText.text = "" + _stoneText;
        _coalText.text = "" + _coalText;
        _copperText.text = "" + _copperText;
        _silverText.text = "" + _silverText;
        _goldText.text = "" + _goldText;
        _zincText.text = "" + _zincText;
        _coalClearText.text = "" + _coalClear;


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
                    number = _stone;
                    break;
                case 4:
                    number = _coal;
                    break;
                case 5:
                    number = _copper;
                    break;
                case 6:
                    number = _silver;
                    break;
                case 7:
                    number = _gold;
                    break;
                case 8:
                    number = _zinc;
                    break;
                case 9:
                    number = _coalClear;
                    break;
                case 10:
                    number = _copperClear;
                    break;
                case 11:
                    number = _silverClear;
                    break;
                case 12:
                    number = _goldClear;
                    break;
                case 13:
                    number = _zincClear;
                    break;
            }

    displayText[i].text = FormatNumber(number);
        }
    }

    public int GetResourceAmount(string resourceName)
    {
        switch (resourceName)
        {
            case "Coal":
                return _coal;
            case "CoalClear":
                return _coalClear;
            case "Copper":
                return _copper;
            case "CopperClear":
                return _copperClear;
            case "Silver":
                return _silver;
            case "SilverClear":
                return _silverClear;
            case "Gold":
                return _gold;
            case "Goldclear":
                return _goldClear;
            case "Zinc":
                return _zinc;
            case "ZincClear":
                return _zincClear;
            default:
                return 0;
        }
    }
    public void ModifyResourceAmount(string resourceName, int amount)
    {
        switch (resourceName)
        {
            case "Coal":
                _coal += amount;
                break;
            case "CoalClear":
                _coalClear += amount;
                break;
            case "Copper":
                _copper += amount;
                break;
            case "CopperClear":
                _copperClear += amount;
                break;
            case "Silver":
                _silver += amount;
                break;
            case "SilverClear":
                _silverClear += amount;
                break;
            case "Gold":
                _gold += amount;
                break;
            case "GoldClear":
                _goldClear += amount;
                break;
            case "Zinc":
                _zinc += amount;
                break;
            case "ZincClear":
                _zincClear += amount;
                break;
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

    //BUY
    public void BuyResource(string resourceType)
    {
        switch (resourceType)
        {
            case "stone":
                if (coinBronze >= costToBuy_stone)
                {
                    coinBronze -= costToBuy_stone;
                    _stoneText.text = "" + _stone;
                    _stone++;
                    CancelInvoke("Add_stone");
                    InvokeRepeating("Add_stone", 5.0f, 5.0f);
                }
                break;
            case "coal":
                if (coinBronze > costToBuyP_coal)
                {
                    coinBronze -= costToBuyP_coal;
                    _coalText.text = "" + _coal;
                    _coal++;
                    CancelInvoke("Add_coal");
                    InvokeRepeating("Add_coal", 10.0f, 10.0f);
                }
                break;
            case "copper":
                if (coinBronze > costToBuy_copper)
                {
                    coinBronze -= costToBuy_copper;
                    _copperText.text = "" + _copper;
                    _copper++;
                    CancelInvoke("Add_copper");
                    InvokeRepeating("Add_copper", 17.0f, 17.0f);
                }
                break;
            case "silver":
                if (coinBronze > costToBuy_silver)
                {
                    coinBronze -= costToBuy_silver;
                    _silverText.text = "" + _silver;
                    _silver++;
                    CancelInvoke("Add_silver");
                    InvokeRepeating("Add_silver", 12.0f, 12.0f);
                }
                break;
            case "gold":
                if (coinBronze > costToBuy_gold)
                {
                    coinBronze -= costToBuy_gold;
                    _goldText.text = "" + _gold;
                    _gold++;
                    CancelInvoke("Add_gold");
                    InvokeRepeating("Add_gold", 25.0f, 25.0f);
                }
                break;
            case "zinc":
                if (coinBronze > costToBuy_zinc)
                {
                    coinBronze -= costToBuy_zinc;
                    _zincText.text = "" + _zinc;
                    _zinc++;
                    CancelInvoke("Add_zinc");
                    InvokeRepeating("Add_zinc", 14.0f, 14.0f);
                }
                break;
        }
    }

    //ADD ITEMS
    public void Add_stone()
    {
        _stone++;
    }
    public void Add_coal()
    {
        _coal++;
    }
    public void Add_copper()
    {
        _copper++;
    }
    public void Add_silver()
    {
        _silver++;
    }
    public void Add_gold()
    {
        _gold++;
    }
    public void Add_zinc()
    {
        _zinc++;
    }

    //SELL ONE
    public void Sell(string resource)
    {
        switch (resource)
        {
            case "stone":
                if (_stone >= 1)
                {
                    _stone--;
                    coinBronze += costToSell_stone;
                }
                break;
            case "coal":
                if (_coal >= 1)
                {
                    _coal--;
                    coinBronze += costToSell_coal;
                }
                break;
            case "copper":
                if (_copper >= 1)
                {
                    _copper--;
                    coinBronze += costToSell_copper;
                }
                break;
            case "silver":
                if (_silver >= 1)
                {
                    _silver--;
                    coinBronze += costToSell_silver;
                }
                break;
            case "gold":
                if (_gold >= 1)
                {
                    _gold--;
                    coinBronze += costToSell_gold;
                }
                break;
            case "zinc":
                if (_zinc >= 1)
                {
                    _zinc--;
                    coinBronze += costToSell_zinc;
                }
                break;
            default:
                break;
        }
    }
    
    //SELL ALL
    public void SellResource(string resourceType)
    {
        switch (resourceType)
        {
            case "stone":
                if (_stone >= 0)
                {
                    int total_stone = _stone;
                    _stone = 0;
                    coinBronze += total_stone * costToSell_stone;
                }
                break;
            case "coal":
                if (_coal >= 0)
                {
                    int total_coal = _coal;
                    _coal = 0;
                    coinBronze += total_coal * costToSell_coal;
                }
                break;
            case "copper":
                if (_copper >= 0)
                {
                    int total_copper = _copper;
                    _copper = 0;
                    coinBronze += total_copper * costToSell_copper;
                }
                break;
            case "silver":
                if (_silver >= 0)
                {
                    int total_silver = _silver;
                    _silver = 0;
                    coinBronze += total_silver * costToSell_silver;
                }
                break;
            case "gold":
                if (_gold >= 0)
                {
                    int total_gold = _gold;
                    _gold = 0;
                    coinBronze += total_gold * costToSell_gold;
                }
                break;
            case "zinc":
                if (_zinc >= 0)
                {
                    int total_zinc = _zinc;
                    _zinc = 0;
                    coinBronze += total_zinc * costToSell_zinc;
                }
                break;
        }
    }
}