using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopesGames
{
    class Produit
    {
        // NOPRODUIT, LIBELLE, PRIXHT, TAUXTVA
        private int noProduit, disponible,vitrine;
        private string libelle, nominage;
        private double prixHT, tauxTVA, quantiteStock;
        private DateTime dateAjout; 
        
        public Produit(int noProduit, string libelle, double prixHT, double tauxTVA,string nominage,
            double quantiteStock,DateTime dateAjout,int disponible,int vitrine)
        {
            this.noProduit = noProduit;
            this.libelle = libelle;
            this.prixHT = prixHT;
            this.tauxTVA = tauxTVA;
            this.nominage = nominage;
            this.quantiteStock = quantiteStock;
            this.dateAjout = dateAjout;
            this.disponible = disponible;
            this.vitrine = vitrine;
        }
        public int GetNoProduit()
        {
            return noProduit;
        }
        public string GetLibelle()
        {
            return libelle;
        }
        public double GetPrixHT()
        {
            return prixHT;
        }
        public double GetTauxTVA()
        {
            return tauxTVA;
        }
        public string GetNominage()
        {
            return nominage;
        }
        public double GetQuantiteStock()
        {
            return quantiteStock;
        }
        public DateTime GetDateAjout()
        {
            return dateAjout;
        }
        public int GetDisponible()
        {
            return disponible;
        }
      
        public int GetVitrine()
        {
            return vitrine;
        }
        public override string ToString()
        {
            return noProduit.ToString() + " - " + libelle + " - " + prixHT.ToString();
        }
    }
}
