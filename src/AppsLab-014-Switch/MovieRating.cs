namespace AppsLab_014_Switch;
public class MovieRating
{


    public string GetRatingDescription(int rating)
    {
        switch (rating)
        {
            case 1:
                return "Veľmi zlý";
            case 2:
                return "Zlý";
            case 3:
                return "Priemerný";
            case 4:
                return "Dobrý";
            case 5:
                return "Výborný";
            default:
                return "Neplatné hodnotenie";
        }
    }
}
 



