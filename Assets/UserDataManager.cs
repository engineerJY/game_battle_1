using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int id;
    public string name;
    public int hp;
    public int wp;
}

public class UserDataManager : SingletonMonoBehaviour<UserDataManager>
{
    private List<Character> deckList = new List<Character>();
    public List<Character> DeckList { get { return deckList; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
