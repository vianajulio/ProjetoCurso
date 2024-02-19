using System.Text.Json.Serialization;

namespace ProjetoCurso.Exercicios.CheapShark;

internal class CheapShark
{
    [JsonPropertyName("internalName")]
    public string internalName { get; set; }

    [JsonPropertyName("title")]
    public string title { get; set; }

    [JsonPropertyName("metacriticLink")]
    public string metacriticLink { get; set; }

    [JsonPropertyName("storeID ")]
    public int storeID { get; set; }

    [JsonPropertyName("gameID")]
    public string gameID { get; set; }

    [JsonPropertyName("salePrice")]
    public string salePrice { get; set; }

    [JsonPropertyName("normalPrice")]
    public string normalPrice { get; set; }

    [JsonPropertyName("isOnSale")]
    public string isOnSale { get; set; }

    [JsonPropertyName("savings")]
    public string savings { get; set; }

    [JsonPropertyName("metacriticScore")]
    public string metacriticScore { get; set; }

    [JsonPropertyName("steamRatingText")]
    public string steamRatingText { get; set; }

    [JsonPropertyName("steamRatingPercent")]
    public string steamRatingPercent { get; set; }

    [JsonPropertyName("steamRatingCount")]
    public string steamRatingCount { get; set; }

    [JsonPropertyName("steamAppID")]
    public string steamAppID { get; set; }

    [JsonPropertyName("releseDate")]
    public int releseDate { get; set; }

    [JsonPropertyName("lastChange")]
    public int lastChange { get; set; }

    [JsonPropertyName("dealRating")]
    public string dealRating { get; set; }

    [JsonPropertyName("thumb")]
    public string thumb { get; set; }


    public void MostrarDados()
    {
        Console.WriteLine($"internalName: {internalName} \ntitle: {title} \nmetacriticLink: {metacriticLink} \nstoreID: {storeID} \ngameID: {gameID} \nsalePrice: {salePrice} \nnormalPrice: {normalPrice} \nisOnSale: {isOnSale} \nsaving: {savings} \nmetacriticScore: {metacriticScore} \nsteamRatingText: {steamRatingText} \nsteamRatingPercent: {steamRatingPercent} \nsteamRatingCount: {steamRatingCount} \nsteamAppID: {steamAppID} \nreleseDate: {releseDate} \nlastChange: {lastChange} \ndealRating: {dealRating} \nthumb: {thumb}");
    }
}
