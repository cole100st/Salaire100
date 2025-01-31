using Life;
using Life.UI;
using Life.Network;
using UnityEngine;
using Life.BizSystem;

namespace _100STKIT
{
    public class Paye100 : Plugin
    {
        private double Salaire;

        public Paye100(IGameAPI api) : base(api) { }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            Debug.Log("Le plugin PAYE100 est bien initialisé ! Made BY COLE100ST ");
            new SChatCommand("/salaire", "Voir son salaire", "/salaire", (player, args) =>
            {
                if (player.serviceMetier)// Le true ne sert a rien dans cette fonction
                {
                    player.Notify("<b>INFORMATION", "<i>VOICI VOTRE SALAIRE !"); // Notify info déja mis de base
                    var Salaire = player.biz.Salaire;
                    player.SendText($"Votre salaire est de {Salaire}€");
                }
            }).Register();
        }
    }
}