var heroes = new List<Hero>() { 
    new("Wade", "Wilson", "Deadpool", false),
    new(string.Empty, string.Empty, "Homelander", true),
    new("Bruce", "Wayne", "Batman", false),
    new(string.Empty, string.Empty, "Stormfront", true),
};

//var result = FilterHeroesWhoCanFly(heroes);
//var heroesWhoCanFly = string.Join(", ", result);
//Console.WriteLine(heroesWhoCanFly);

//var result = FilterHeroesWhoesLastNameIsUnknown(heroes);
//var heroesWhoesLastNameIsUnknown = string.Join(", ", result);
//Console.WriteLine(heroesWhoesLastNameIsUnknown);

var result = Filter(heroes, h => string.IsNullOrEmpty(h.LastName));
var heroesRestul = string.Join(", ", result);
Console.WriteLine(heroesRestul);

List<Hero> FilterHeroesWhoCanFly(List<Hero> heroes)
{
    var result = new List<Hero>();

    foreach (var hero in heroes)
    {
        if(hero.CanFly)
            result.Add(hero);
    }

    return result;
}

List<Hero> FilterHeroesWhoesLastNameIsUnknown(List<Hero> heroes)
{
    var result = new List<Hero>();

    foreach (var hero in heroes)
    {
        if (string.IsNullOrEmpty(hero.LastName))
            result.Add(hero);
    }

    return result;
}

// Linq: Where
IEnumerable<T> Filter<T>(IEnumerable<T> items, Func<T, bool> f)
{
    foreach (var item in items)
    {
        if (f(item))
            yield return item;
    }
}

delegate bool Filter<T>(T h);

record Hero(string FirstName, string LastName, string HeroName, bool CanFly);