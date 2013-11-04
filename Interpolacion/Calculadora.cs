using System;

namespace Interpolacion {    
    class Calculadora {
	
	    public long[,] listaXY { get; set; }
        public long cantPtos { get; set; }
        public int grado { get; set; }
	
    //	Metodo Newton-Gregory 	
        public long[,] tabla { get; set; }		//	Es la tabla que se arma para obtener los Ai y Bi
        public float[] listaAi { get; set; }
        public float[] listaBi { get; set; }
        public int dist { get; set; }
        public String pProgresivo { get; set; }
        public String pRegresivo { get; set; }

    //	Metodo Newton-Gregory Generalizado
        public long[,] tablaGral { get; set; }		//	Es la tabla que se arma para obtener los Ai y Bi
        
        /*
        private float[] listaAiGral { get; set; }
        private float[] listaBiGral { get; set; }
        private String pProgresivoGral { get; set; }
        private String pRegresivoGral { get; set; }
         */

	
	    public Calculadora(long[,] listaXY_, int dist_){
		    listaXY = listaXY_;
		    cantPtos = listaXY_.LongLength;
		    tabla = genTabla();
		    grado = genGrado();
		    dist = dist_;
	    }
	
	    public Calculadora(long[,] listaXY_) {
		    listaXY = listaXY_;
		    cantPtos = listaXY_.LongLength;
		    tabla = genTablaGral();
		    grado = genGradoGral();
	    }

	    private long[,] genTablaGral() {
		
		    tablaGral = new long[cantPtos, cantPtos+1];
		
		    for(int i=0;i<cantPtos;i++){
			    tablaGral[i,0] = listaXY[i,0];
			    tablaGral[i,1] = listaXY[i,1];
		    }

		    for(int c=2; c<=cantPtos; c++){
			    long limF = cantPtos-c;
			    for(int f=0;f<=limF;f++){
				    long numerador = tablaGral[f+1,c-1] - tablaGral[f,c-1];
				    long denominador = tablaGral[f+c-1,0] - tablaGral[f,0];
				    tablaGral[f,c] = numerador/denominador;
			    }
		    }

		    return tablaGral;
	    }

	    private int genGradoGral() {
    //		Recorre la tabla hasta encontrar una columna cuyos elementos tienen el mismo valor y es distinto de cero.

			    for(int c=1;c<=cantPtos;c++){
				    long vant = tabla[0,c];
				    Boolean bgrado = true;

				    for(int f=0;f<=(cantPtos-c);f++){
					
					    if(vant!=tabla[f,c]){
						    bgrado = false;
					    }
					    vant=tabla[f,c];
				    }

				    if(bgrado && vant!=0){
					    grado = c-1;
					    return grado;
				    }
			    }
			    return 0;
		    }


	    private long[,] genTabla(){
				
		    tabla = new long[cantPtos,cantPtos];
		
		    for(int i=0;i<cantPtos;i++)
			    tabla[i,0] = listaXY[i,1];			


		    for(int c=1; c<cantPtos; c++){
			    long limF = cantPtos-c;
			    for(int f=0;f<limF;f++){
				    tabla[f,c] = tabla[f+1,c-1] - tabla[f,c-1];
			    }
			
			
		    }
		    return tabla;
	    }

	    private int genGrado() {
    //	Recorre la tabla hasta encontrar una columna cuyos elementos tienen el mismo valor y es distinto de cero.

		    for(int c=0;c<cantPtos;c++){
			    long vant = tabla[0,c];
			    Boolean bgrado = true;

			    for(int f=0;f<(cantPtos-c);f++){
				
				    if(vant!=tabla[f,c]){
					    bgrado = false;
				    }
				    vant=tabla[f,c];
			    }

			    if(bgrado && vant!=0){
				    grado = c;
				    return grado;
			    }
		    }
		    return 0;
	    }

	    public void genListaAi(){
		    int lim = grado+1;
		
		    listaAi = new float[lim];
		
		    for(int c=0;c<lim;c++){			
			    long ai = tabla[0,c];
			    long exp = (long) Math.Pow(dist, c);
			    long fac = factorial(c);
			
			    listaAi[c] = (float)ai / (exp * fac);
		    }
	    }

	    public void genListaAiGral(){
		    int lim = grado+1;
		    listaAi = new float[lim];
		
		    for(int c=1;c<=lim;c++){
			    listaAi[c-1] = tablaGral[0,c];
		    }
	    }
	
	    public void genListaBi(){
		    int lim = grado+1;
		    listaBi = new float[lim];
		
		    for(int c=0;c<lim;c++){
			    long ai = tabla[cantPtos-c-1,c];
			    long exp = (long) Math.Pow(dist, c);
			    long fac = factorial(c);

			    listaBi[c] = (float)ai / (exp * fac);
		    }		
	    }

	    public void genListaBiGral(){
		    int lim = grado+1;
		    listaBi = new float[lim];

		    for(int c=1;c<=lim;c++){
			    listaBi[c-1] = tabla[cantPtos-c,c];
		    }		
	    }

	    public String genProgresivo(){

		    pProgresivo="P(x)=";
		    String r = "";

	        if(listaAi[0]!=0)
			    pProgresivo += "" + listaAi[0];

		
		    for(int i=1; i<=grado;i++){
			    String numX = getNumX(listaXY[i-1,0]);
			    r += "*(x" + numX +")";

			    if(listaAi[i]!=0){
				    String num = getNum(listaAi[i]);
				    pProgresivo += num;
				    pProgresivo += r;
			    }
		    }
		
		    Console.WriteLine(pProgresivo);
		    return pProgresivo;
	    }

	    public String genRegresivo(){

		    pRegresivo="R(x)=";
		    String r = "";

	        if(listaBi[0]!=0)
			    pRegresivo += "" + listaBi[0];
		
		    for(int i=1; i<=grado;i++){
			    String numX = getNumX(listaXY[cantPtos-i,0]);
			    r += "*(x" + numX +")";

			    if(listaBi[i]!=0){
				    String num = getNum(listaBi[i]);
				    pRegresivo += num;
				    pRegresivo += r;
			    }
		    }
		
		    Console.WriteLine(pRegresivo);
		    return pRegresivo;
	    }

	    public float evalProgresivo(float x){

		    float res=0;
		    float vant=1;

		    res += listaAi[0];
		
		    for(int i=1; i<=grado;i++){
			    vant = vant*(x-listaXY[i-1,0]);
			    if(listaAi[i]!=0)
				    res += listaAi[i] * vant;
		    }
		
		    Console.WriteLine("P("+x+")="+ res);
		    return res;
	    }

	    public float evalRegresivo(float x){

		    float res=0;
		    float vant=1;

		    res += listaBi[0];

		    for(int i=1; i<=grado;i++){
			    vant = vant*(x-listaXY[cantPtos-i,0]);
			    if(listaBi[i]!=0)
				    res += listaBi[i] * vant;
		    }
		
		    Console.WriteLine("R("+x+")="+ res);
		    return res;
	    }
	
	    private String getNumX(long n)
	    {
	        if(n<0){
			    n = -1 * n;
			    return "+"+n;
		    }
	        if(n==0){
	            return "-"+0;
	        }
	        return "-"+n;
	    }

    private String getNum(float n)
    {
        if(n>0){
			    return "+"+n;
		    }
        return ""+n;
    }

    public long factorial(long n)
	    {
	        if(n == 0)
			    return 1;
	        return n * factorial(n-1);
	    }

    public long exp(long a, int exp){
		    long num=1;

		    for(int i=0;i<exp;i++)
			    num = num*a;

		    return num;
	    }	
    }        
}
