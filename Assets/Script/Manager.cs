using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    //abbreviations
    public Text[] displayText;

    public MoveSprite ms;

    //ads
    public static Manager S;
    [SerializeField] private float _persentShowAds;

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


    //ITEMS
    public int _micro, _solarPanel1, _solarPanel2;

    public Text _microText, _solarPanel1Text, _solarPanel2Text;


    public Dictionary<string, int> costToBuy = new Dictionary<string, int>()
    {
        {"stone", 50},
        {"coal", 400},
        {"copper", 800},
        {"silver", 600},
        {"gold", 2800},
        {"zinc", 400},
        {"coalClear", 800},
        {"copperClear", 1600},
        {"silverClear", 1200},
        {"goldClear", 5600},
        {"zincClear", 800},
        {"yellorium", 800},
        {"cianyte", 700},
        {"crypton", 1800},
        {"flint", 300},
        {"redstone", 500},
        {"yelloriumClear", 1900},
        {"cianyteClear", 1400},
        {"cryptonClear", 3600},
        {"flintClear", 600},
        {"redstoneClear", 1000},
        {"micro", 4000 },
        {"solarPanel1", 8000},
        {"solarPanel2", 10000}
    };

    public Dictionary<string, int> costToSell = new Dictionary<string, int>()
    {
        {"stone", 25},
        {"coal", 50},
        {"copper", 100},
        {"silver", 75},
        {"gold", 400},
        {"zinc", 50},
        {"yellorium", 200},
        {"cianyte", 175},
        {"crypton", 450},
        {"flint", 75},
        {"redstone", 125},
        {"coalClear", 100},
        {"copperClear", 200},
        {"silverClear", 150},
        {"goldClear", 800},
        {"zincClear", 100},
        {"yelloriumClear", 400},
        {"cianyteClear", 350},
        {"cryptonClear", 900},
        {"flintClear", 150},
        {"redstoneClear", 250},
        {"micro", 2000},
        {"solarPanel1", 4000},
        {"solarPanel2", 5000},
    };

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

        _microText.text = "" + _microText;
        _solarPanel1Text.text = "" + _solarPanel1;
        _solarPanel2Text.text = "" + _solarPanel2;


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
                case 24:
                    number = _micro;
                    break;
                case 25:
                    number = _solarPanel1;
                    break;
                case 26:
                    number = _solarPanel2;
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
            case "Micro":
                return _micro;
            case "SolarPanel1":
                return _solarPanel1;
            case "SolarPanel2":
                return _solarPanel2;
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
            case "Micro":
                _micro += amount;
                break;
            case "SolarPanel1":
                _solarPanel1 += amount;
                break;
            case "SolarPanel2":
                _solarPanel2 += amount;
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
    //ADDS

    //private void Start()
    //{
    //    InterstitialAd.S.LoadAd();
    //}
    //private void Awake()
    //{
    //    S = this;
    //}

    //float tempPersent = Random.Range(0f, 1f);
    //if (tempPersent < _persentShowAds)
    //    InterstitialAd.S.ShowAd();

    //BUY
    public void BuyResource(string resourceType)
    {
        switch (resourceType)
        {
            case "stone":
                if (coinBronze >= costToBuy["stone"])
                {
                    coinBronze -= costToBuy["stone"];
                    _stoneText.text = "" + _stone;
                    _stone++;
                    CancelInvoke("Add_stone");
                    InvokeRepeating("Add_stone", 5.0f, 5.0f);
                    InvokeRepeating("Add_stoneMove", 0.01f, 0.01f);
                }
                break;
            case "coal":
                if (coinBronze > costToBuy["coal"])
                {
                    coinBronze -= costToBuy["coal"];
                    _coalText.text = "" + _coal;
                    _coal++;
                    CancelInvoke("Add_coal");
                    InvokeRepeating("Add_coal", 10.0f, 10.0f);
                }
                break;
            case "copper":
                if (coinBronze > costToBuy["copper"])
                {
                    coinBronze -= costToBuy["copper"];
                    _copperText.text = "" + _copper;
                    _copper++;
                    CancelInvoke("Add_copper");
                    InvokeRepeating("Add_copper", 17.0f, 17.0f);
                }
                break;
            case "silver":
                if (coinBronze > costToBuy["silver"])
                {
                    coinBronze -= costToBuy["silver"];
                    _silverText.text = "" + _silver;
                    _silver++;
                    CancelInvoke("Add_silver");
                    InvokeRepeating("Add_silver", 12.0f, 12.0f);
                }
                break;
            case "gold":
                if (coinBronze > costToBuy["gold"])
                {
                    coinBronze -= costToBuy["gold"];
                    _goldText.text = "" + _gold;
                    _gold++;
                    CancelInvoke("Add_gold");
                    InvokeRepeating("Add_gold", 25.0f, 25.0f);
                }
                break;
            case "zinc":
                if (coinBronze > costToBuy["zinc"])
                {
                    coinBronze -= costToBuy["zinc"];
                    _zincText.text = "" + _zinc;
                    _zinc++;
                    CancelInvoke("Add_zinc");
                    InvokeRepeating("Add_zinc", 14.0f, 14.0f);
                }
                break;
            case "yellorium":
                if (coinBronze > costToBuy["yellorium"])
                {
                    coinBronze -= costToBuy["yellorium"];
                    _yelloriumText.text = "" + _yellorium;
                    _yellorium++;
                    CancelInvoke("Add_yellorium");
                    InvokeRepeating("Add_yellorium", 18.0f, 18.0f);
                }
                break;
            case "cianyte":
                if (coinBronze > costToBuy["cianyte"])
                {
                    coinBronze -= costToBuy["cianyte"];
                    _cianyteText.text = "" + _cianyte;
                    _cianyte++;
                    CancelInvoke("Add_cianyte");
                    InvokeRepeating("Add_cianyte", 22.0f, 22.0f);
                }
                break;
            case "crypton":
                if (coinBronze > costToBuy["crypton"])
                {
                    coinBronze -= costToBuy["crypton"];
                    _cryptonText.text = "" + _crypton;
                    _crypton++;
                    CancelInvoke("Add_crypton");
                    InvokeRepeating("Add_crypton", 32.0f, 32.0f);
                }
                break;
            case "flint":
                if (coinBronze > costToBuy["flint"])
                {
                    coinBronze -= costToBuy["flint"];
                    _flintText.text = "" + _flint;
                    _flint++;
                    CancelInvoke("Add_flint");
                    InvokeRepeating("Add_flint", 10.0f, 10.0f);
                }
                break;
            case "redstone":
                if (coinBronze > costToBuy["redstone"])
                {
                    coinBronze -= costToBuy["redstone"];
                    _redstoneText.text = "" + _redstone;
                    _redstone++;
                    CancelInvoke("Add_redstone");
                    InvokeRepeating("Add_redstone", 24.0f, 24.0f);
                }
                break;
            case "yelloriumClear":
                if (coinBronze > costToBuy["yelloriumClear"])
                {
                    coinBronze -= costToBuy["yelloriumClear"];
                    _yelloriumClearText.text = "" + _yelloriumClear;
                    _yelloriumClear++;
                }
                break;
            case "cianyteClear":
                if (coinBronze > costToBuy["cianyteClear"])
                {
                    coinBronze -= costToBuy["cianyteClear"];
                    _cianyteClearText.text = "" + _cianyteClear;
                    _cianyteClear++;
                }
                break;
            case "cryptonClear":
                if (coinBronze > costToBuy["cryptonClear"])
                {
                    coinBronze -= costToBuy["cryptonClear"];
                    _cryptonClearText.text = "" + _cryptonClear;
                    _cryptonClear++;
                }
                break;
            case "flintClear":
                if (coinBronze > costToBuy["flintClear"])
                {
                    coinBronze -= costToBuy["flintClear"];
                    _flintClearText.text = "" + _flintClear;
                    _flintClear++;
                }
                break;
            case "redstoneClear":
                if (coinBronze > costToBuy["redstoneClear"])
                {
                    coinBronze -= costToBuy["redstoneClear"];
                    _redstoneClearText.text = "" + _redstoneClear;
                    _redstoneClear++;
                }
                break;
            case "coalClear":
                if (coinBronze > costToBuy["coalClear"])
                {
                    coinBronze -= costToBuy["coalClear"];
                    _coalClearText.text = "" + _coalClear;
                    _coalClear++;
                }
                break;
            case "copperClear":
                if (coinBronze > costToBuy["copperClear"])
                {
                    coinBronze -= costToBuy["copperClear"];
                    _copperClearText.text = "" + _copperClear;
                    _copperClear++;
                }
                break;
            case "silverClear":
                if (coinBronze > costToBuy["silverClear"])
                {
                    coinBronze -= costToBuy["silverClear"];
                    _silverClearText.text = "" + _silverClear;
                    _silverClear++;
                }
                break;
            case "goldClear":
                if (coinBronze > costToBuy["goldClear"])
                {
                    coinBronze -= costToBuy["goldClear"];
                    _goldClearText.text = "" + _goldClear;
                    _goldClear++;
                }
                break;
            case "zincClear":
                if (coinBronze > costToBuy["zincClear"])
                {
                    coinBronze -= costToBuy["zincClear"];
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
    private void Add_stoneMove()
    {
        ms.StartMove();
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
                    coinBronze += costToBuy["stone"];
                }
                break;
            case "coal":
                if (_coal >= 1)
                {
                    _coal--;
                    coinBronze += costToBuy["coal"];
                }
                break;
            case "copper":
                if (_copper >= 1)
                {
                    _copper--;
                    coinBronze += costToBuy["copper"];
                }
                break;
            case "silver":
                if (_silver >= 1)
                {
                    _silver--;
                    coinBronze += costToBuy["silver"];
                }
                break;
            case "gold":
                if (_gold >= 1)
                {
                    _gold--;
                    coinBronze += costToBuy["gold"];
                }
                break;
            case "zinc":
                if (_zinc >= 1)
                {
                    _zinc--;
                    coinBronze += costToBuy["zinc"];
                }
                break;
            case "yellorium":
                if (_yellorium >= 1)
                {
                    _yellorium--;
                    coinBronze += costToBuy["yellorium"];
                }
                break;
            case "cianyte":
                if (_cianyte >= 1)
                {
                    _cianyte--;
                    coinBronze += costToBuy["cianyte"];
                }
                break;
            case "crypton":
                if (_crypton >= 1)
                {
                    _crypton--;
                    coinBronze += costToBuy["crypton"];
                }
                break;
            case "flint":
                if (_flint >= 1)
                {
                    _flint--;
                    coinBronze += costToBuy["flint"];
                }
                break;
            case "redstone":
                if (_redstone >= 1)
                {
                    _redstone--;
                    coinBronze += costToBuy["redstone"];
                }
                break;
            case "coalClear":
                if (_coalClear >= 1)
                {
                    _coalClear--;
                    coinBronze += costToBuy["coalClear"];
                }
                break;
            case "copperClear":
                if (_copperClear >= 1)
                {
                    _copperClear--;
                    coinBronze += costToBuy["copperClear"];
                }
                break;
            case "silverClear":
                if (_silverClear >= 1)
                {
                    _silverClear--;
                    coinBronze += costToBuy["silverClear"];
                }
                break;
            case "goldClear":
                if (_goldClear >= 1)
                {
                    _goldClear--;
                    coinBronze += costToBuy["goldClear"];
                }
                break;
            case "zincClear":
                if (_zincClear >= 1)
                {
                    _zincClear--;
                    coinBronze += costToBuy["zincClear"];
                }
                break;
            case "yelloriumClear":
                if (_yelloriumClear >= 1)
                {
                    _yelloriumClear--;
                    coinBronze += costToBuy["yelloriumClear"];
                }
                break;
            case "cianyteClear":
                if (_cianyteClear >= 1)
                {
                    _cianyteClear--;
                    coinBronze += costToBuy["cianyteClear"];
                }
                break;
            case "cryptonClear":
                if (_cryptonClear >= 1)
                {
                    _cryptonClear--;
                    coinBronze += costToBuy["cryptonClear"];
                }
                break;
            case "flintClear":
                if (_flintClear >= 1)
                {
                    _flintClear--;
                    coinBronze += costToBuy["flintClear"];
                }
                break;
            case "redstoneClear":
                if (_redstoneClear >= 1)
                {
                    _redstoneClear--;
                    coinBronze += costToBuy["redstoneClear"];
                }
                break;
            case "micro":
                if (_micro >= 1)
                {
                    _micro--;
                    coinBronze += costToBuy["micro"];
                }
                break;
            case "solarPanel1":
                if (_solarPanel1 >= 1)
                {
                    _solarPanel1--;
                    coinBronze += costToBuy["solarPanel1"];
                }
                break;
            case "solarPanel2":
                if (_solarPanel2 >= 1)
                {
                    _solarPanel2--;
                    coinBronze += costToBuy["solarPanel2"];
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
                    coinBronze += total_stone * costToBuy["stone"];
                }
                break;
            case "coal":
                if (_coal >= 0)
                {
                    int total_coal = _coal;
                    _coal = 0;
                    coinBronze += total_coal * costToBuy["coal"];
                }
                break;
            case "copper":
                if (_copper >= 0)
                {
                    int total_copper = _copper;
                    _copper = 0;
                    coinBronze += total_copper * costToBuy["copper"];
                }
                break;
            case "silver":
                if (_silver >= 0)
                {
                    int total_silver = _silver;
                    _silver = 0;
                    coinBronze += total_silver * costToBuy["silver"];
                }
                break;
            case "gold":
                if (_gold >= 0)
                {
                    int total_gold = _gold;
                    _gold = 0;
                    coinBronze += total_gold * costToBuy["gold"];
                }
                break;
            case "zinc":
                if (_zinc >= 0)
                {
                    int total_zinc = _zinc;
                    _zinc = 0;
                    coinBronze += total_zinc * costToBuy["zinc"];
                }
                break;
            case "yellorium":
                if (_yellorium >= 0)
                {
                    int total_yellorium = _yellorium;
                    _yellorium = 0;
                    coinBronze += total_yellorium * costToBuy["yellorium"];
                }
                break;
            case "cianyte":
                if (_cianyte >= 0)
                {
                    int total_cianyte = _cianyte;
                    _cianyte = 0;
                    coinBronze += total_cianyte * costToBuy["cianyte"];
                }
                break;
            case "crypton":
                if (_crypton >= 0)
                {
                    int total_crypton = _crypton;
                    _crypton = 0;
                    coinBronze += total_crypton * costToBuy["crypton"];
                }
                break;
            case "flint":
                if (_flint >= 0)
                {
                    int total_flint = _flint;
                    _flint = 0;
                    coinBronze += total_flint * costToBuy["flint"];
                }
                break;
            case "redstone":
                if (_redstone >= 0)
                {
                    int total_redstone = _redstone;
                    _redstone = 0;
                    coinBronze += total_redstone * costToBuy["redstone"];
                }
                break;
            case "coalClear":
                if (_coalClear >= 0)
                {
                    int total_coalClear = _coalClear;
                    _coalClear = 0;
                    coinBronze += total_coalClear * costToBuy["coalClear"];
                }
                break;
            case "copperClear":
                if (_copperClear >= 0)
                {
                    int total_copperClear = _copperClear;
                    _copperClear = 0;
                    coinBronze += total_copperClear * costToBuy["copperClear"];
                }
                break;
            case "silverClear":
                if (_silverClear >= 0)
                {
                    int total_silverClear = _silverClear;
                    _silverClear = 0;
                    coinBronze += total_silverClear * costToBuy["silverClear"];
                }
                break;
            case "goldClear":
                if (_goldClear >= 0)
                {
                    int total_goldClear = _goldClear;
                    _goldClear = 0;
                    coinBronze += total_goldClear * costToBuy["goldClear"];
                }
                break;
            case "zincClear":
                if (_zincClear >= 0)
                {
                    int total_zincClear = _zincClear;
                    _zincClear = 0;
                    coinBronze += total_zincClear * costToBuy["zincClear"];
                }
                break;
            case "yelloriumClear":
                if (_yelloriumClear >= 0)
                {
                    int total_yelloriumClear = _yelloriumClear;
                    _yelloriumClear = 0;
                    coinBronze += total_yelloriumClear * costToBuy["yelloriumClear"];
                }
                break;
            case "cianyteClear":
                if (_cianyteClear >= 0)
                {
                    int total_cianyteClear = _cianyteClear;
                    _cianyteClear = 0;
                    coinBronze += total_cianyteClear * costToBuy["cianyteClear"];
                }
                break;
            case "cryptonClear":
                if (_cryptonClear >= 0)
                {
                    int total_cryptonClear = _cryptonClear;
                    _cryptonClear = 0;
                    coinBronze += total_cryptonClear * costToBuy["cryptonClear"];
                }
                break;
            case "flintClear":
                if (_flintClear >= 0)
                {
                    int total_flintClear = _flintClear;
                    _flintClear = 0;
                    coinBronze += total_flintClear * costToBuy["flintClear"];
                }
                break;
            case "redstoneClear":
                if (_redstoneClear >= 0)
                {
                    int total_redstoneClear = _redstoneClear;
                    _redstoneClear = 0;
                    coinBronze += total_redstoneClear * costToBuy["redstoneClear"];
                }
                break;
            case "micro":
                if (_micro >= 0)
                {
                    int total_micro = _micro;
                    _micro = 0;
                    coinBronze += total_micro * costToBuy["micro"];
                }
                break;
            case "solarPanel1":
                if (_solarPanel1 >= 0)
                {
                    int total_solarPanel1 = _solarPanel1;
                    _solarPanel1 = 0;
                    coinBronze += total_solarPanel1 * costToBuy["solarPanel1"];
                }
                break;
            case "solarPanel2":
                if (_solarPanel2 >= 0)
                {
                    int total_solarPanel2 = _solarPanel2;
                    _solarPanel2 = 0;
                    coinBronze += total_solarPanel2 * costToBuy["solarPanel2"];
                }
                break;
        }
    }
}