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
    public Text bronzeText, silverText, goldText;

    //ITEM
    public int _stone, _coal, _copper, _silver, _gold, _zinc;

    public int _coalClear, _copperClear, _silverClear, _goldClear, _zincClear;
    
    public int _yellorium, _cianyte, _crypton, _flint, _redstone;

    public int _yelloriumClear, _cianyteClear, _cryptonClear, _flintClear, _redstoneClear;

    //TEXT ITEM
    public Text _stoneText, _coalText, _copperText, _silverText, _goldText, _zincText, _yelloriumText, _cianyteText, _cryptonText, _flintText, _redstoneText;
    public Text _coalClearText, _copperClearText, _silverClearText, _goldClearText, _zincClearText, _yelloriumClearText, _cianyteClearText, _cryptonClearText, _flintClearText, _redstoneClearText;

    //COST
    int costToBuy_stone = 50, costToBuyP_coal = 400, costToBuy_copper = 800;
    int costToBuy_silver = 600, costToBuy_gold = 2800, costToBuy_zinc = 400;

    int costToBuy_coalClear = 800, costToBuy_copperClear = 1600;
    int costToBuy_silverClear = 1200, costToBuy_goldClear = 5600, costToBuy_zincClear = 800;

    int costToBuy_yellorium = 800, costToBuy_cianyte = 700, costToBuy_crypton = 1800;
    int costToBuy_flint = 300, costToBuy_redstone = 500;

    int costToBuy_yelloriumClear = 1900, costToBuy_cianyteClear = 1400, costToBuy_cryptonClear = 3600;
    int costToBuy_flintClear = 600, costToBuy_redstoneClear = 1000;


    //SELL COST
    int costToSell_stone = 25, costToSell_coal = 50, costToSell_copper = 100;
    int costToSell_silver = 75, costToSell_gold = 400, costToSell_zinc = 50;

    int costToSell_yellorium = 200, costToSell_cianyte = 175, costToSell_crypton = 450;
    int costToSell_flint = 75, costToSell_redstone = 125, costToSell_coalClear = 100;
    int costToSell_copperClear = 200, costToSell_silverClear = 150, costToSell_goldClear = 800;

    int costToSell_zincClear = 100, costToSell_yelloriumClear = 400, costToSell_cianyteClear = 350;
    int costToSell_cryptonClear = 900, costToSell_flintClear = 150, costToSell_redstoneClear = 250;


    void Start()
    {
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
        _yellorium = PlayerPrefs.GetInt("_yelloorium", _yellorium);
        _cianyte = PlayerPrefs.GetInt("_cianyte", _cianyte);
        _crypton = PlayerPrefs.GetInt("_crypton", _crypton);
        _flint = PlayerPrefs.GetInt("_flint", _flint);
        _redstone = PlayerPrefs.GetInt("_redstone", _redstone);
        _yelloriumClear = PlayerPrefs.GetInt("_yelloriumClear", _yelloriumClear);
        _cianyteClear = PlayerPrefs.GetInt("_cianyteClear", _cianyteClear);
        _cryptonClear = PlayerPrefs.GetInt("_cryptonClear", _cryptonClear);
        _flintClear = PlayerPrefs.GetInt("_flintClear", _flintClear);
        _redstoneClear = PlayerPrefs.GetInt("_redstoneClear", _redstoneClear);
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
        PlayerPrefs.SetInt("_yellorium", _yellorium);
        PlayerPrefs.SetInt("_cianyte", _cianyte);
        PlayerPrefs.SetInt("_crypton", _crypton);
        PlayerPrefs.SetInt("_flint", _flint);
        PlayerPrefs.SetInt("_redstone", _redstone);
        PlayerPrefs.SetInt("_clearCoal", _coalClear);
        PlayerPrefs.SetInt("_copperClear", _copperClear);
        PlayerPrefs.SetInt("_silverClear", _silverClear);
        PlayerPrefs.SetInt("_goldClear", _goldClear);
        PlayerPrefs.SetInt("_zincClear", _zincClear);
        PlayerPrefs.SetInt("_yelloriumClear", _yelloriumClear);
        PlayerPrefs.SetInt("_cianyteClear", _cianyteClear);
        PlayerPrefs.SetInt("_cryptonClear", _cryptonClear);
        PlayerPrefs.SetInt("_flintClear", _flintClear);
        PlayerPrefs.SetInt("_redstoneClear", _redstoneClear);
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
        _copperClearText.text = "" + _copperClearText;
        _silverClearText.text = "" + _silverClearText;
        _goldClearText.text = "" + _goldClearText;
        _zincClearText.text = "" + _zincClear;

        _yelloriumText.text = "" + _yelloriumText;
        _cianyteText.text = "" + _cianyteText;
        _cryptonText.text = "" + _cryptonText;
        _flintText.text = "" + _flintText;
        _redstoneText.text = "" + _redstoneText;

        _yelloriumClearText.text = "" + _yelloriumClearText;
        _cianyteClearText.text = "" + _cianyteClearText;
        _cryptonClearText.text = "" + _cryptonClearText;
        _flintClearText.text = "" + _flintClearText;
        _redstoneClearText.text = "" + _redstoneClearText;


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
                case 14:
                    number = _yellorium;
                    break;
                case 15:
                    number = _cianyte;
                    break;
                case 16:
                    number = _crypton;
                    break;
                case 17:
                    number = _flint;
                    break;
                case 18:
                    number = _redstone;
                    break;
                case 19:
                    number = _yelloriumClear;
                    break;
                case 20:
                    number = _cianyteClear;
                    break;
                case 21:
                    number = _cryptonClear;
                    break;
                case 22:
                    number = _flintClear;
                    break;
                case 23:
                    number = _redstoneClear;
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
            case "Yellorium":
                return _yellorium;
            case "Cianyte":
                return _cianyte;
            case "Crypton":
                return _crypton;
            case "Flint":
                return _flint;
            case "Redstone":
                return _redstone;
            case "YelloriumClear":
                return _yelloriumClear;
            case "CianyteClear":
                return _cianyteClear;
            case "CryptonClear":
                return _cryptonClear;
            case "FlintClear":
                return _flintClear;
            case "RedstoneClear":
                return _redstoneClear;
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
            case "Yellorium":
                _yellorium += amount;
                break;
            case "Cianyte":
                _cianyte += amount;
                break;
            case "Crypton":
                _crypton += amount;
                break;
            case "Flint":
                _flint += amount;
                break;
            case "Redstone":
                _redstone += amount;
                break;
            case "YelloriumClear":
                _yelloriumClear += amount;
                break;
            case "CianyteClear":
                _cianyteClear += amount;
                break;
            case "CryptonClear":
                _cryptonClear += amount;
                break;
            case "FlintClear":
                _flintClear += amount;
                break;
            case "RedstoneClear":
                _redstoneClear += amount;
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
            case "yellorium":
                if (coinBronze > costToBuy_yellorium)
                {
                    coinBronze -= costToBuy_yellorium;
                    _yelloriumText.text = "" + _yellorium;
                    _yellorium++;
                    CancelInvoke("Add_yellorium");
                    InvokeRepeating("Add_yellorium", 18.0f, 18.0f);
                }
                break;
            case "cianyte":
                if (coinBronze > costToBuy_cianyte)
                {
                    coinBronze -= costToBuy_cianyte;
                    _cianyteText.text = "" + _cianyte;
                    _cianyte++;
                    CancelInvoke("Add_cianyte");
                    InvokeRepeating("Add_cianyte", 22.0f, 22.0f);
                }
                break;
            case "crypton":
                if (coinBronze > costToBuy_crypton)
                {
                    coinBronze -= costToBuy_crypton;
                    _cryptonText.text = "" + _crypton;
                    _crypton++;
                    CancelInvoke("Add_crypton");
                    InvokeRepeating("Add_crypton", 32.0f, 32.0f);
                }
                break;
            case "flint":
                if (coinBronze > costToBuy_flint)
                {
                    coinBronze -= costToBuy_flint;
                    _flintText.text = "" + _flint;
                    _flint++;
                    CancelInvoke("Add_flint");
                    InvokeRepeating("Add_flint", 10.0f, 10.0f);
                }
                break;
            case "redstone":
                if (coinBronze > costToBuy_redstone)
                {
                    coinBronze -= costToBuy_redstone;
                    _redstoneText.text = "" + _redstone;
                    _redstone++;
                    CancelInvoke("Add_redstone");
                    InvokeRepeating("Add_redstone", 24.0f, 24.0f);
                }
                break;
            case "yelloriumClear":
                if (coinBronze > costToBuy_yelloriumClear)
                {
                    coinBronze -= costToBuy_yelloriumClear;
                    _yelloriumClearText.text = "" + _yelloriumClear;
                    _yelloriumClear++;
                }
                break;
            case "cianyteClear":
                if (coinBronze > costToBuy_cianyteClear)
                {
                    coinBronze -= costToBuy_cianyteClear;
                    _cianyteClearText.text = "" + _cianyteClear;
                    _cianyteClear++;
                }
                break;
            case "cryptonClear":
                if (coinBronze > costToBuy_cryptonClear)
                {
                    coinBronze -= costToBuy_cryptonClear;
                    _cryptonClearText.text = "" + _cryptonClear;
                    _cryptonClear++;
                }
                break;
            case "flintClear":
                if (coinBronze > costToBuy_flintClear)
                {
                    coinBronze -= costToBuy_flintClear;
                    _flintClearText.text = "" + _flintClear;
                    _flintClear++;
                }
                break;
            case "redstoneClear":
                if (coinBronze > costToBuy_redstoneClear)
                {
                    coinBronze -= costToBuy_redstoneClear;
                    _redstoneClearText.text = "" + _redstoneClear;
                    _redstoneClear++;
                }
                break;
            case "coalClear":
                if (coinBronze > costToBuy_coalClear)
                {
                    coinBronze -= costToBuy_coalClear;
                    _coalClearText.text = "" + _coalClear;
                    _coalClear++;
                }
                break;
            case "copperClear":
                if (coinBronze > costToBuy_copperClear)
                {
                    coinBronze -= costToBuy_copperClear;
                    _copperClearText.text = "" + _copperClear;
                    _copperClear++;
                }
                break;
            case "silverClear":
                if (coinBronze > costToBuy_silverClear)
                {
                    coinBronze -= costToBuy_silverClear;
                    _silverClearText.text = "" + _silverClear;
                    _silverClear++;
                }
                break;
            case "goldClear":
                if (coinBronze > costToBuy_goldClear)
                {
                    coinBronze -= costToBuy_goldClear;
                    _goldClearText.text = "" + _goldClear;
                    _goldClear++;
                }
                break;
            case "zincClear":
                if (coinBronze > costToBuy_zincClear)
                {
                    coinBronze -= costToBuy_zincClear;
                    _zincClearText.text = "" + _zincClear;
                    _zincClear++;
                }
                break;
        }
    }

    //ADD ITEMS
    private void Add_stone()
    {
        _stone++;
    }
    private void Add_coal()
    {
        _coal++;
    }
    private void Add_copper()
    {
        _copper++;
    }
    private void Add_silver()
    {
        _silver++;
    }
    private void Add_gold()
    {
        _gold++;
    }
    private void Add_zinc()
    {
        _zinc++;
    }
    private void Add_yellorium()
    {
        _yellorium++;
    }
    private void Add_crypton()
    {
        _crypton++;
    }
    private void Add_cianyte()
    {
        _cianyte++;
    }
    private void Add_flint()
    {
        _flint++;
    }
    private void Add_redstone()
    {
        _redstone++;
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
            case "yellorium":
                if (_yellorium >= 1)
                {
                    _yellorium--;
                    coinBronze += costToSell_yellorium;
                }
                break;
            case "cianyte":
                if (_cianyte >= 1)
                {
                    _cianyte--;
                    coinBronze += costToSell_cianyte;
                }
                break;
            case "crypton":
                if (_crypton >= 1)
                {
                    _crypton--;
                    coinBronze += costToSell_crypton;
                }
                break;
            case "flint":
                if (_flint >= 1)
                {
                    _flint--;
                    coinBronze += costToSell_flint;
                }
                break;
            case "redstone":
                if (_redstone >= 1)
                {
                    _redstone--;
                    coinBronze += costToSell_redstone;
                }
                break;
            case "coalClear":
                if (_coalClear >= 1)
                {
                    _coalClear--;
                    coinBronze += costToSell_coalClear;
                }
                break;
            case "copperClear":
                if (_copperClear >= 1)
                {
                    _copperClear--;
                    coinBronze += costToSell_copperClear;
                }
                break;
            case "silverClear":
                if (_silverClear >= 1)
                {
                    _silverClear--;
                    coinBronze += costToSell_silverClear;
                }
                break;
            case "goldClear":
                if (_goldClear >= 1)
                {
                    _goldClear--;
                    coinBronze += costToSell_goldClear;
                }
                break;
            case "zincClear":
                if (_zincClear >= 1)
                {
                    _zincClear--;
                    coinBronze += costToSell_zincClear;
                }
                break;
            case "yelloriumClear":
                if (_yelloriumClear >= 1)
                {
                    _yelloriumClear--;
                    coinBronze += costToSell_yelloriumClear;
                }
                break;
            case "cianyteClear":
                if (_cianyteClear >= 1)
                {
                    _cianyteClear--;
                    coinBronze += costToSell_cianyteClear;
                }
                break;
            case "cryptonClear":
                if (_cryptonClear >= 1)
                {
                    _cryptonClear--;
                    coinBronze += costToSell_cryptonClear;
                }
                break;
            case "flintClear":
                if (_flintClear >= 1)
                {
                    _flintClear--;
                    coinBronze += costToSell_flintClear;
                }
                break;
            case "redstoneClear":
                if (_redstoneClear >= 1)
                {
                    _redstoneClear--;
                    coinBronze += costToSell_redstoneClear;
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
            case "yellorium":
                if (_yellorium >= 0)
                {
                    int total_yellorium = _yellorium;
                    _yellorium = 0;
                    coinBronze += total_yellorium * costToSell_yellorium;
                }
                break;
            case "cianyte":
                if (_cianyte >= 0)
                {
                    int total_cianyte = _cianyte;
                    _cianyte = 0;
                    coinBronze += total_cianyte * costToSell_cianyte;
                }
                break;
            case "crypton":
                if (_crypton >= 0)
                {
                    int total_crypton = _crypton;
                    _crypton = 0;
                    coinBronze += total_crypton * costToSell_crypton;
                }
                break;
            case "flint":
                if (_flint >= 0)
                {
                    int total_flint = _flint;
                    _flint = 0;
                    coinBronze += total_flint * costToSell_flint;
                }
                break;
            case "redstone":
                if (_redstone >= 0)
                {
                    int total_redstone = _redstone;
                    _redstone = 0;
                    coinBronze += total_redstone * costToSell_redstone;
                }
                break;
            case "coalClear":
                if (_coalClear >= 0)
                {
                    int total_coalClear = _coalClear;
                    _coalClear = 0;
                    coinBronze += total_coalClear * costToSell_coalClear;
                }
                break;
            case "copperClear":
                if (_copperClear >= 0)
                {
                    int total_copperClear = _copperClear;
                    _copperClear = 0;
                    coinBronze += total_copperClear * costToSell_copperClear;
                }
                break;
            case "silverClear":
                if (_silverClear >= 0)
                {
                    int total_silverClear = _silverClear;
                    _silverClear = 0;
                    coinBronze += total_silverClear * costToSell_silverClear;
                }
                break;
            case "goldClear":
                if (_goldClear >= 0)
                {
                    int total_goldClear = _goldClear;
                    _goldClear = 0;
                    coinBronze += total_goldClear * costToSell_goldClear;
                }
                break;
            case "zincClear":
                if (_zincClear >= 0)
                {
                    int total_zincClear = _zincClear;
                    _zincClear = 0;
                    coinBronze += total_zincClear * costToSell_zincClear;
                }
                break;
            case "yelloriumClear":
                if (_yelloriumClear >= 0)
                {
                    int total_yelloriumClear = _yelloriumClear;
                    _yelloriumClear = 0;
                    coinBronze += total_yelloriumClear * costToSell_yelloriumClear;
                }
                break;
            case "cianyteClear":
                if (_cianyteClear >= 0)
                {
                    int total_cianyteClear = _cianyteClear;
                    _cianyteClear = 0;
                    coinBronze += total_cianyteClear * costToSell_cianyteClear;
                }
                break;
            case "cryptonClear":
                if (_cryptonClear >= 0)
                {
                    int total_cryptonClear = _cryptonClear;
                    _cryptonClear = 0;
                    coinBronze += total_cryptonClear * costToSell_cryptonClear;
                }
                break;
            case "flintClear":
                if (_flintClear >= 0)
                {
                    int total_flintClear = _flintClear;
                    _flintClear = 0;
                    coinBronze += total_flintClear * costToSell_flintClear;
                }
                break;
            case "redstoneClear":
                if (_redstoneClear >= 0)
                {
                    int total_redstoneClear = _redstoneClear;
                    _redstoneClear = 0;
                    coinBronze += total_redstoneClear * costToSell_redstoneClear;
                }
                break;
        }
    }
}