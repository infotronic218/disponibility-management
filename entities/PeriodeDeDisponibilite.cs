/// <summary>
/// la class PeriodeDeDisponibilite nous donne la list des Disponibilites pour un Usager ou un Employe
/// </summary>
/// 

using System;
using System.Collections.Generic;
class PeriodeDeDisponibilite
{
    /// <summary>
    /// un constructeur pour incrementer la list des periodes
    /// </summary>
    /// <param name="periodes"></param>
    /// 
    
    public PeriodeDeDisponibilite(List<Periode> periodes)
    {
        Disponibilite = periodes;
    }
    public PeriodeDeDisponibilite()
    {
    }

    /// <summary>
    /// un procedure pour ajouter un periode a la list des periodes
    /// </summary>
    /// <param name="periode"></param>
    public void add_periode(Periode periode)
    {
        Disponibilite?.Add(periode);
    }

    List<Periode>? Disponibilite;
    /// <summary>
    /// un fonction qui verifie c'est la PeriodeDeDisponibilite entre est compatible avec la PeriodeDeDisponibilite actuel
    /// </summary>
    /// <param name="pdd"></param>
    /// <returns></returns>
    public bool isavailable(PeriodeDeDisponibilite pdd)
    {
        bool isok = false;
        foreach (var disp1 in Disponibilite!)
        {
            foreach (var disp2 in pdd.Disponibilite!)
            {
                if (disp1.isavailable(disp2))
                {
                    isok = true;
                }
            }
        }
        return isok;
    }
}