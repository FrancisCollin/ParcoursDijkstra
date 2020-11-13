using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Francis Collin, 1738286
/// Noeud
/// un noeud est un peu comme le back-end d'une case de la grille dans la classe ParcoursLargeur
/// </summary>
public class Noeud
{
    public int PosX { get; private set; }
    public int PosY { get; private set; }

    public int State; // 0 = Mur | 1 = Non visiter | 2 = Départ | 3 = Arriver | 4 = En traitement | 5 = Visiter | 6 = trajet
    public bool CaseArriver;

    public int Distance;
    public Noeud Pere;

    /// <summary>
    /// Constructeur de la classe Noeud
    /// </summary>
    /// <param name="PosX"> Position x de la case </param>
    /// <param name="PosY"> Position y de la case </param>
    /// <param name="State"> L'état de la case </param>
    /// <param name="Distance"> Distance de la case entre elle et le départ </param>
    /// <param name="Pere"> La case père de cette case </param>
    /// <param name="CaseArriver"> Si cette case est la case arriver </param>
    public Noeud(int PosX, int PosY, int State = 0, int Distance = int.MaxValue, Noeud Pere = null, bool CaseArriver = false)
    {
        this.PosX = PosX;
        this.PosY = PosY;
        this.State = State;
        this.Distance = Distance;
        this.Pere = Pere;
        this.CaseArriver = CaseArriver;
    }
}
