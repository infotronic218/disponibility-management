/// <summary>
/// la class Date est pour definir la heurs et les minutes de la periode
/// </summary>
class Date
{
    /// <summary>
    /// constructeur pour incremontre lheure et les minutes
    /// </summary>
    /// <param name="heur"></param>
    /// <param name="minute"></param>
    public Date(int heur, int minute)
    {
        this.heur = heur;
        this.minute = minute;
    }
    /// <summary>
    /// la variable prive de l'heur
    /// </summary>
    private int _heur;
    /// <summary>
    /// un get et set public pour la variable _heur
    /// </summary>
    /// <value></value>
    public int heur
    {
        get { return _heur; }
        set
        {
            ///verifier c'est l'heur entre et entre 8h et 17h(5h) 
            if (value <= 17 && value >= 8)
                _heur = value;
        }
    }
    /// <summary>
    /// la variable prive de la minute
    /// </summary>
    private int _minute;
    /// <summary>
    /// un get et set public pour la variable _minute
    /// </summary>
    /// <value></value>
    public int minute
    {
        get { return _minute; }
        set
        {
            /// verifier c'est la valeur entre est entre 0 minute et 60 minute
            if (value < 60 && value >= 0)
                _minute = value;
        }
    }
    /// <summary>
    /// la fonction toint nous permit de tronsformer la valur de la date en int avec le calcul heur*60+minute
    /// </summary>
    /// <returns>la resulta du calcule heur*60+minute de la date</returns>
    public int toint()
    {
        return (heur*60)+minute;
    }
    /// <summary>
    /// la fonction tostring nous donne la date en format string de type HH:MM
    /// </summary>
    /// <returns>la date en HH:MM en string</returns>
    public string tostring()
    {
        return (heur>9?heur:"0"+heur)+":"+(minute>9?minute:"0"+minute);
    }
}