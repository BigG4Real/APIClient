using System;

namespace API;

public class Pokemon
{
    public uint id { get; set; }
    public uint weight { get; set; }
    public string name { get; set; }
    public PokemonSprite Sprites { get; set; }
}
