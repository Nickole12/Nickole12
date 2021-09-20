public class Program 
{
    public static void Main()
    {
		int doces = 0, salgdo = 0, produto;
		int contador = 0;
		
		while(contador<=7)
		{   
			Console.Clear();
			Console.Write("Digite Para o mais vendido(1-Para doce, 2-Para salgado:");
			produto=Int32.Parse(Console.ReadLine());
			
			  if(produto== 1){
			    
			    doces = doces + produto;
			  }
			 else{
			    salgdo = salgdo + produto;
			    
			 }
			    contador = contador +1;
			    
		}
		    
		    Console.WriteLine("Doce:"+doces);
		    Console.Write("salgdo:"+salgdo);
		    
		    
		    
		    
		  
		    
		    
    }
}
