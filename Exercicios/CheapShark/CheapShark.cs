using System.Text.Json.Serialization;

namespace ProjetoCurso.Exercicios.CheapShark;

internal class CheapShark
{
    public string internalName { get; set; }

    public string title { get; set; }

    public string metacriticLink { get; set; }

    public int storeID { get; set; }

    public string gameID { get; set; }

    public string salePrice { get; set; }

    public string normalPrice { get; set; }

    public string isOnSale { get; set; }

    public string savings { get; set; }

    public string metacriticScore { get; set; }

    public string steamRatingText { get; set; }

    public string steamRatingPercent { get; set; }

    public string steamRatingCount { get; set; }

    public string steamAppID { get; set; }

    public int releseDate { get; set; }

    public int lastChange { get; set; }

    public string dealRating { get; set; }

    public string thumb { get; set; }


    public void MostrarDados()
    {
        Console.WriteLine($"internalName: {internalName} \ntitle: {title} \nmetacriticLink: {metacriticLink} \nstoreID: {storeID} \ngameID: {gameID} \nsalePrice: {salePrice} \nnormalPrice: {normalPrice} \nisOnSale: {isOnSale} \nsaving: {savings} \nmetacriticScore: {metacriticScore} \nsteamRatingText: {steamRatingText} \nsteamRatingPercent: {steamRatingPercent} \nsteamRatingCount: {steamRatingCount} \nsteamAppID: {steamAppID} \nreleseDate: {releseDate} \nlastChange: {lastChange} \ndealRating: {dealRating} \nthumb: {thumb}");
    }
}
