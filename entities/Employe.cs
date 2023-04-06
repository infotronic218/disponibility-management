/// <summary>
/// la class employe pour avoir le nom et le numero de l'employe est ca PeriodeDeDisponibilite
/// </summary>
/// 
using System;
using System.Collections.Generic;
class Employe
{
    private int _numero;
    /// <summary>
    /// constructeur pour incrementer la class Employe
    /// </summary>
    /// <param name="nom"></param>
    /// <param name="ppd"></param>
    /// 
    
    public Employe(int numero, string nom, PeriodeDeDisponibilite pdd)
    {
        this.numero = numero;
        this.nom = nom;
        this.pdd = pdd;
    }

    public int numero
    {
        get { return _numero; }
        set { _numero = value; }
    }

    private string? _nom;

    public string nom
    {
        get { return _nom!; }
        set { _nom = value; }
    }

    private PeriodeDeDisponibilite? _pdd;

    public PeriodeDeDisponibilite pdd
    {
        get { return _pdd!; }
        set { _pdd = value; }
    }
}