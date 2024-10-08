namespace AsperandLabs.Meilisearch.Http.Constants;

public static class Defaults
{
    public static List<string> AllAttributes => ["*"];

    public static string ProximityPrecision => "byWord";

    public static List<string> RankingRules =>
    [
        "words",
        "typo",
        "proximity",
        "attribute",
        "sort",
        "exactness"
    ];
}