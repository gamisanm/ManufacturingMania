using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.Windows;

public class SaveLoadProgress : MonoBehaviour
{
    public Manager manager;

    //Load
    void Start()
    {
        manager.coinBronze = PlayerPrefs.GetInt("coinBronze", manager.coinBronze);
        manager.coinSilver = PlayerPrefs.GetInt("coinSilver", manager.coinSilver);
        manager.coinGold = PlayerPrefs.GetInt("coinGold", manager.coinGold);
        manager._stone = PlayerPrefs.GetInt("_stone", manager._stone);
        manager._coal = PlayerPrefs.GetInt("_coal", manager._coal);
        manager._copper = PlayerPrefs.GetInt("_copper", manager._copper);
        manager._silver = PlayerPrefs.GetInt("_silver", manager._silver);
        manager._gold = PlayerPrefs.GetInt("_gold", manager._gold);
        manager._zinc = PlayerPrefs.GetInt("_zinc", manager._zinc);
        manager._coalClear = PlayerPrefs.GetInt("_coalClear", manager._coalClear);
        manager._copperClear = PlayerPrefs.GetInt("_coalClear", manager._copperClear);
        manager._silverClear = PlayerPrefs.GetInt("_silverClear", manager._silverClear);
        manager._goldClear = PlayerPrefs.GetInt("_goldClear", manager._goldClear);
        manager._zincClear = PlayerPrefs.GetInt("_zincClear", manager._zincClear);
        manager._yellorium = PlayerPrefs.GetInt("_yelloorium", manager._yellorium);
        manager._cianyte = PlayerPrefs.GetInt("_cianyte", manager._cianyte);
        manager._crypton = PlayerPrefs.GetInt("_crypton", manager._crypton);
        manager._flint = PlayerPrefs.GetInt("_flint", manager._flint);
        manager._redstone = PlayerPrefs.GetInt("_redstone", manager._redstone);
        manager._yelloriumClear = PlayerPrefs.GetInt("_yelloriumClear", manager._yelloriumClear);
        manager._cianyteClear = PlayerPrefs.GetInt("_cianyteClear", manager._cianyteClear);
        manager._cryptonClear = PlayerPrefs.GetInt("_cryptonClear", manager._cryptonClear);
        manager._flintClear = PlayerPrefs.GetInt("_flintClear", manager._flintClear);
        manager._redstoneClear = PlayerPrefs.GetInt("_redstoneClear", manager._redstoneClear);
        manager._micro = PlayerPrefs.GetInt("_micro", manager._micro);
        manager._solarPanel1 = PlayerPrefs.GetInt("_solarPanel1", manager._solarPanel1);
        manager._solarPanel2 = PlayerPrefs.GetInt("_solarPanel2", manager._solarPanel2);
    }

    //SAVE PROGRESS
    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("coinBronze", manager.coinBronze);
        PlayerPrefs.SetInt("coinSilver", manager.coinSilver);
        PlayerPrefs.SetInt("coinGold", manager.coinGold);
        PlayerPrefs.SetInt("_stone", manager._stone);
        PlayerPrefs.SetInt("_coal", manager._coal);
        PlayerPrefs.SetInt("_copper", manager._copper);
        PlayerPrefs.SetInt("_silver", manager._silver);
        PlayerPrefs.SetInt("_gold", manager._gold);
        PlayerPrefs.SetInt("_zinc", manager._zinc);
        PlayerPrefs.SetInt("_yellorium", manager._yellorium);
        PlayerPrefs.SetInt("_cianyte", manager._cianyte);
        PlayerPrefs.SetInt("_crypton", manager._crypton);
        PlayerPrefs.SetInt("_flint", manager._flint);
        PlayerPrefs.SetInt("_redstone", manager._redstone);
        PlayerPrefs.SetInt("_clearCoal", manager._coalClear);
        PlayerPrefs.SetInt("_copperClear", manager._copperClear);
        PlayerPrefs.SetInt("_silverClear", manager._silverClear);
        PlayerPrefs.SetInt("_goldClear", manager._goldClear);
        PlayerPrefs.SetInt("_zincClear", manager._zincClear);
        PlayerPrefs.SetInt("_yelloriumClear", manager._yelloriumClear);
        PlayerPrefs.SetInt("_cianyteClear", manager._cianyteClear);
        PlayerPrefs.SetInt("_cryptonClear", manager._cryptonClear);
        PlayerPrefs.SetInt("_flintClear", manager._flintClear);
        PlayerPrefs.SetInt("_redstoneClear", manager._redstoneClear);
        PlayerPrefs.SetInt("_micro", manager._micro);
        PlayerPrefs.SetInt("_solarPanel1", manager._solarPanel1);
        PlayerPrefs.SetInt("_solarPanel2", manager._solarPanel2);
        PlayerPrefs.Save();
    }
}
