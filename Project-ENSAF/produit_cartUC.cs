﻿using System;
using System.Windows.Forms; 
using System.Drawing; 
using System.Linq; 
namespace Project_ENSAF
{
    public partial class produit_cardUC : UserControl
    {
        Produit currentProd=new Produit();
        Form1 formParent;
        public produit_cardUC()
        {
            byte[] buffer = (byte[])new ImageConverter().ConvertTo(Properties.Resources.sweets, typeof(byte[]));
            Produit p = new Produit()
            {
                libelle = "danone2",
                dateExpiration = DateTime.Now,
                prixAchat = (decimal)1.5,
                prixVente = (decimal)2,
                description = "danone banane",
                idFournisseur = 1,
                img = buffer
            }; 
            InitializeComponent(p,1); 
        }
        public produit_cardUC(Produit p,Form1 formParent, int nbProds = 1)
        { 
            this.currentProd = p;
            this.formParent = formParent;
            InitializeComponent(p,nbProds); 
        }  
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Silver;
        }
        private void button2_MouseUp(object sender, MouseEventArgs e)
        {

            (sender as Button).BackColor = System.Drawing.Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
             try
             { 
                var db = new dbContext();
                var p = db.Produits.Where(prod => prod.libelle == currentProd.libelle);
                db.Produits.RemoveRange(p);
                db.SaveChanges();
                this.Dispose();
               // MessageBox.Show("product deleted"); 
             }
             catch (Exception excep)
             {
                MessageBox.Show("Error! cant delete product :" + excep.Message);
             }  
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Produit fAout = new Form_Ajouter_Produit(currentProd,formParent);
            fAout.Show();
        }
        private void btnReadMore_click(object sender, EventArgs e)
        {
            var db = new dbContext();
            var stock = db.Produits.Where(p => p.libelle == currentProd.libelle).ToList<Produit>();  
            FormProdDescri prodDescri = new FormProdDescri(stock);
            prodDescri.Show();
        }

    }
}
