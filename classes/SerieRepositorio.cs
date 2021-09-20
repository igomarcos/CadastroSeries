using System;
using System.Collections.Generic;
using catseries.interfaces;

namespace catseries
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSeries = new List<Serie>();
        public void Atualizar(int id, Serie objeto)
        {
           listaSeries[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaSeries[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSeries[id];

        }
    }
}
