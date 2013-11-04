using System.Collections.Generic;
using System.Data;

namespace Interpolacion
{
    public class Ingresador
    {       
        public ParOrdenado parIngresado = new ParOrdenado(0,0);

        public List<ParOrdenado> listaParesOrdenados
        {
            get
            {
                List<ParOrdenado> lista = new List<ParOrdenado>();
                for (int i = 0; i < tablaParesOrdenados.Rows.Count; i++)
                {
                    lista.Add(
                        new ParOrdenado(
                                (float)tablaParesOrdenados.Rows[i][0],
                                (float)tablaParesOrdenados.Rows[i][1])
                            );
                }
                return lista;
            }
        }

        public DataTable tablaParesOrdenados = new DataTable();

        public Ingresador()
        {
            tablaParesOrdenados.Columns.Add("X").DataType = typeof(float);
            tablaParesOrdenados.Columns.Add("Y").DataType = typeof(float);
        }

        public void agregarPar()
        {
            tablaParesOrdenados.Rows.Add(parIngresado.X, parIngresado.Y);
            parIngresado = new ParOrdenado(0,0);
        }

        
    }
}
