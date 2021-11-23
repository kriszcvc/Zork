using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Zork;
using Newtonsoft.Json;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private TextMeshProUGUI LocationText;

    [SerializeField]
    private TextMeshProUGUI MovesText;

    [SerializeField]
    private TextMeshProUGUI ScoreText;

    void Start()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        _game = JsonConvert.DeserializeObject<Game>(gameJsonAsset.text);
        _game.Player.LocationChanged += (sender, newLocation) => LocationText.text = newLocation.ToString();
        _game.Player.MovesChanged += (sender, moves) => MovesText.text = moves.ToString();
        _game.Player.ScoreChanged += (sender, score) => ScoreText.text = score.ToString();

        _game.Start(InputService, OutputService);

        LocationText.text = _game.Player.Location.ToString();

        _game.Commands["LOOK"].Action(_game);
    }

    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    private Game _game;
    private Room _previousLocation;
}
