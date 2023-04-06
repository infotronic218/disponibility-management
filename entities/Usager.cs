/// <summary>
/// la class usager pour avoir le nom de l'usager est ca PeriodeDeDisponibilite
/// </summary>
class Usager
{
    /// <summary>
    /// constructeur pour incrementer le nom et la PeriodeDeDisponibilite de l'usager
    /// </summary>
    /// <param name="nom"></param>
    /// <param name="ppd"></param>
    public Usager(string nom,PeriodeDeDisponibilite ppd){
        this.pdd = ppd;
        this.nom = nom;
    }

    private PeriodeDeDisponibilite? _pdd;

    public PeriodeDeDisponibilite pdd
    {
        get { return _pdd!; }
        set { _pdd = value; }
    }

    private string? _nom;
    public string nom
    {
        get { return _nom!; }
        set { _nom = value; }
    }
}