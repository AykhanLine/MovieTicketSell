using MovieTicketSell.SERVICE;
using MovieTicketSell.MODELS;

ProductService services = new();

foreach (var smth in services.GetAll())
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine(smth.Movie + ", " + "Category: " + smth.Category + ", "   + "Hour: " + smth.Hour + ", " + "IMBD: " + smth.Imbd);
}