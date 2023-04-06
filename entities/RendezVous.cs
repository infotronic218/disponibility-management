
using System;
using System.Collections.Generic;
class RendezVous
{
    /// <summary>
    /// constructeur pour incrementer l'usager du la class RendezVous
    /// </summary>
    /// <param name="usager"></param>
    public RendezVous(Usager usager){
        this._usager = usager;
    }

    private Usager? _usager;
    public Usager usager
    {
        get { return _usager!; }
    }

    private List<Employe>? _employe;
    public List<Employe> employe
    {
        get { return _employe!; }
    }
    /// <summary>
    /// un procedur pour ajouter un employe a la list des employes
    /// </summary>
    /// <param name="employe"></param>
    public void add_employe(Employe employe)
    {
        /// verifier la pdd de l'employe avec celle de l'usager
        if (usager.pdd.isavailable(employe.pdd))
            _employe!.Add(employe);
    }
    /// <summary>
    /// supprimer un employe de la list
    /// </summary>
    /// <param name="employe"></param>
    public void remouve_employe(Employe employe)
    {
        _employe!.Remove(employe);
    }
}