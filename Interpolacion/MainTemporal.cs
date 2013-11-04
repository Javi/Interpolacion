using System;

namespace Interpolacion
{
    class MainTemporal
    {
        public static void main(String[] args) {

		Console.WriteLine("METODO NEWTON-GREGORY");
//		Genera una matriz con los puntos
		long[,] listaXY = generarPuntos();
		
//		Se instancia la clase datos, recibe la tabla de puntos y la distancia entre ellos		
		Calculadora calculadora = new Calculadora(listaXY,1);
		Console.WriteLine("Cantidad de puntos: " + calculadora.cantPtos + "\tPolinomio de grado: " + calculadora.grado);
		recorrerTabla(calculadora.tabla, calculadora.cantPtos);
		
//		Calcula los Ai para armar el polinomio y los guarda en un vector		
		calculadora.genListaAi();
		recorrerListaAi(calculadora.listaAi, calculadora.grado);
		
//		Calcula los Bi para armar el polinomio y los guarda en un vector		
		calculadora.genListaBi();
		recorrerListaBi(calculadora.listaBi, calculadora.grado);

		Console.WriteLine("\n");
//		Genera los polinomios y los muestra por consola		
		calculadora.genProgresivo();
		calculadora.genRegresivo();
		
//		Evalua los polinomios en un punto
		calculadora.evalProgresivo(4);
		calculadora.evalRegresivo(4);

//	METODO NEWTON-GREGORY (General)
		Console.WriteLine("-----------------------------------------------------------");
		Console.WriteLine("METODO NEWTON-GREGORY (General)");
		listaXY = generarPuntosGral();
		Calculadora datosGral = new Calculadora(listaXY);
		
		Console.WriteLine("Cantidad de puntos: " + datosGral.cantPtos + "\tPolinomio de grado: " + datosGral.grado);
		recorrerTablaGral(datosGral.tablaGral, datosGral.cantPtos);

		datosGral.genListaAiGral();
		recorrerListaAi(datosGral.listaAi, datosGral.grado);

		datosGral.genListaBiGral();
		recorrerListaBi(datosGral.listaBi, datosGral.grado);
		
		Console.WriteLine("\n\n");
		datosGral.genProgresivo();
		datosGral.genRegresivo();
		datosGral.evalProgresivo(4);
		datosGral.evalRegresivo(4);
	}


        private static long[,] generarPuntos()
        {
            long[,] listaXY = new long[6, 2];

            listaXY[0, 0] = -1;
            listaXY[0, 1] = 0;
            listaXY[1, 0] = 0;
            listaXY[1, 1] = 5;
            listaXY[2, 0] = 1;
            listaXY[2, 1] = 4;
            listaXY[3, 0] = 2;
            listaXY[3, 1] = 3;
            listaXY[4, 0] = 3;
            listaXY[4, 1] = 8;
            listaXY[5, 0] = 4;
            listaXY[5, 1] = 25;

            return listaXY;
        }

        private static long[,] generarPuntosGral()
        {
            long[,] listaXY = new long[5, 2];

            listaXY[0, 0] = 1;
            listaXY[0, 1] = 1;
            listaXY[1, 0] = 3;
            listaXY[1, 1] = 3;
            listaXY[2, 0] = 4;
            listaXY[2, 1] = 13;
            listaXY[3, 0] = 5;
            listaXY[3, 1] = 37;
            listaXY[4, 0] = 7;
            listaXY[4, 1] = 151;

            return listaXY;
        }

        private static void recorrerTabla(long[,] tabla, long cantPtos){
		    Console.WriteLine();
		    for(int f=0;f<cantPtos;f++){
			    for(int c=0;c<(cantPtos-f);c++){
				    Console.Write(tabla[f,c] + "\t");
			    }
			    Console.WriteLine();
		    }
	    }

        private static void recorrerTablaGral(long[,] tabla, long cantPtos){
		    Console.WriteLine();

		    for(int f=0;f<=cantPtos;f++){
			    for(int c=1;c<=(cantPtos-f);c++){
                    Console.Write(tabla[f, c] + "\t");
			    }
			    Console.WriteLine();
		    }
	    }

        private static void recorrerListaAi(float[] gs, int grado){
		    Console.WriteLine();
		    for(int f=0;f<(grado+1);f++){
			    Console.WriteLine("A"+ f + " = " + gs[f]);
		    }
	    }

        private static void recorrerListaBi(float[] gs, int grado){
		    Console.WriteLine();
		    for(int f=0;f<(grado+1);f++){
			    Console.WriteLine("B"+ f + " = " + gs[f]);
		    }
	    }
    }
}
