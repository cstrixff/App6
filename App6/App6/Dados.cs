using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using Xamarin.Forms;

namespace App6
{
    static class Dados
    {
        static public string conString = "server=cstrix.com; database=esffpap_exemplo; uid=esffpap_mocho; pwd=filped13;";
        static public MySqlConnection conn = null;
  
        static private void AbrirLigacao()
        {
            try
            {
                conn = new MySqlConnection(conString);
                conn.Open();
               
            }
            catch (Exception ex)
            {

             
            }
        }

        static public List<Jogo> Jogos()
        {
            AbrirLigacao();

            List<Jogo> listaJogos = new List<Jogo>();

            var querysql = "SELECT * FROM Jogo";

            MySqlDataReader leitor = null;
            MySqlCommand cmd = new MySqlCommand(querysql, conn);
            
            leitor = cmd.ExecuteReader();
            
            while (leitor.Read())
            {
                Jogo jogo = new Jogo(leitor["ID"].ToString(), leitor["titulo"].ToString(), leitor["preco"].ToString(), leitor["capa"].ToString());

                listaJogos.Add(jogo);


            }
            FecharLigacao();
            return listaJogos;

        }

        static private void FecharLigacao()
        {
            try
            {
               
                conn.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}