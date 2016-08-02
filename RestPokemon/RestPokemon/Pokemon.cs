using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestPokemon
{
    class Pokemon
    {
        int id;
        string name;
        int base_experience;
        decimal height;
        bool is_default;
        int order;
        decimal weight;
        //List<Ability> abilities;
        //List<Move> moves;
        string type;

        public Pokemon()
        {

        }

        public Pokemon(int id, string name, decimal height, decimal weight, int base_experience, bool is_default, int order, string type)
        {
            this.id = id;
            this.name = name;
            this.height = height;
            this.weight = weight;
            this.base_experience = base_experience;
            this.is_default = is_default;
            this.order = order;
            this.type = type;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class PokemonType
    {
        public string type;

        public static Dictionary<int, string> types = new Dictionary<int, string> {
            { 0, "Normal" },
            { 1,  "Fire" },
            { 2, "Water" },
            { 3, "Grass" },
            { 4, "Flying" },
            { 5, "Fighting" },
            { 6, "Poison" },
            { 7, "Electric" },
            { 8, "Ground" },
            { 9, "Psychic" },
            { 10, "Rock" },
            { 11, "Ice" },
            { 12, "Bug" },
            { 13, "Dragon" },
            { 14, "Ghost" },
            { 15, "Dark" },
            { 16, "Steel" },
            { 17, "Fairy" }
        };
        //enum PokemonType
        //{
        //    Normal,
        //    Fire,
        //    Water,
        //    Grass,
        //    Flying,
        //    Fighting,
        //    Poison,
        //    Electric,
        //    Ground,
        //    Psychic,
        //    Rock,
        //    Ice,
        //    Bug,
        //    Dragon,
        //    Ghost,
        //    Dark,
        //    Steel,
        //    Fairy
        //}
    }
}
/*
{
"id": 1,
"name": "bulbasaur",
"base_experience": 64,
"height": 7,
"is_default": true,
"order": 1,
"weight": 69,
"abilities": [
    {
        "is_hidden": true,
        "slot": 3,
        "ability": {
            "name": "chlorophyll",
            "url": "http://pokeapi.co/api/v2/ability/34/"
        }
}
],
"forms": [
    {
        "name": "bulbasaur",
        "url": "http://pokeapi.co/api/v2/pokemon-form/1/"
    }
],
"game_indices": [
    {
        "game_index": 1,
        "version": {
            "name": "white-2",
            "url": "http://pokeapi.co/api/v2/version/22/"
        }
    }
],
"held_items": [],
"location_area_encounters": [],
"moves": [
    {
        "move": {
            "name": "captivate",
            "url": "http://pokeapi.co/api/v2/move/445/"
        },
        "version_group_details": [
            {
                "level_learned_at": 0,
                "version_group": {
                    "name": "heartgold-soulsilver",
                    "url": "http://pokeapi.co/api/v2/version-group/10/"
                },
                "move_learn_method": {
                    "name": "machine",
                    "url": "http://pokeapi.co/api/v2/move-learn-method/4/"
                }
            },
            {
                "level_learned_at": 0,
                "version_group": {
                    "name": "platinum",
                    "url": "http://pokeapi.co/api/v2/version-group/9/"
                },
                "move_learn_method": {
                    "name": "machine",
                    "url": "http://pokeapi.co/api/v2/move-learn-method/4/"
                }
            },
            {
                "level_learned_at": 0,
                "version_group": {
                    "name": "diamond-pearl",
                    "url": "http://pokeapi.co/api/v2/version-group/8/"
                },
                "move_learn_method": {
                    "name": "machine",
                    "url": "http://pokeapi.co/api/v2/move-learn-method/4/"
                }
            }
        ]
    }
],
"species": {
    "name": "bulbasaur",
    "url": "http://pokeapi.co/api/v2/pokemon-species/1/"
},
"stats": [
    {
        "base_stat": 45,
        "effort": 0,
        "stat": {
            "name": "speed",
            "url": "http://pokeapi.co/api/v2/stat/6/"
        }
    }
],
"types": [
    {
        "slot": 2,
        "type": {
            "name": "poison",
            "url": "http://pokeapi.co/api/v2/type/4/"
        }
    }
]
}

}
*/
