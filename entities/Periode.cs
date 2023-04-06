/// <summary>
/// la class periode nous donne la date mais aussi le jour de la disponibilite
/// </summary>
class Periode
{
    /// <summary>
    /// la list des jour de travaill
    /// </summary>
    enum jourdetravaill
    {
        LUNDI,
        MARDI,
        MERCREDI,
        JEUDI,
        VENDREDI
    }
    /// <summary>
    /// le constructeur pour la calss periode
    /// </summary>
    /// <param name="jour">le jour de la disponibilite</param>
    /// <param name="debut">l'heur debut de la disponibilite</param>
    /// <param name="fin">l'heur fin de la disponibilite</param>
    public Periode(string jour, Date debut, Date fin)
    {
        this.jour = jour;
        this.debut = debut;
        this.fin = fin;
    }

    private string? _jour;
    public string jour
    {
        get { return _jour!; }
        set { 
            if(jourdetravaill.IsDefined(typeof(jourdetravaill), value.ToUpper()))
            {
                _jour = value.ToUpper();
            }
         }
    }
    private Date? _debut;
    public Date debut
    {
        get { return _debut!; }
        set { _debut = value; }
    }

    private Date? _fin;
    public Date fin
    {
        get { return _fin!; }
        set { _fin = value; }
    }
    /// <summary>
    /// la fonction verifi c'est la periode actuelle et la Periode entre sont compatible
    /// </summary>
    /// <param name="prod">la periode a test</param>
    /// <returns></returns>
    public bool isavailable(Periode prod)
    {
        if(prod.jour == this.jour)
        if(this.debut.toint()<=prod.debut.toint() && this.fin.toint()>=prod.fin.toint())
        return true;
        return false;
    }
}