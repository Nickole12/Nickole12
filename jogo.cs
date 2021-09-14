using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{
    public class jogo{
    	
    static void Main(string[]args){
    	
    
    //programa: jogo da adivinhação//	
    
         string resposta_usuario;
         string entrar = "sim";
         string resposta;
         int resposta_fase1;
         int fase1__certa = 2;
         int resposta_fase2;
         int fase2__certa = 24;
         string retorno_de_fases2;
         string  positivo = "sim";
         string  fase3_certa = "par";
        inicio: 
    
       Console.WriteLine("-------------------------------");
       Console.ForegroundColor =
       ConsoleColor.Yellow;
       Console.BackgroundColor =
       ConsoleColor.Blue;
       Console.WriteLine("DESEJA JOGAR?");
       
       
       Console.BackgroundColor =
       ConsoleColor.Red;
       Console.Write("	sim	");Console.WriteLine("Não");
       Console.ResetColor();

       Console.WriteLine("-------------------------------");
       Console.Write("Resposta:");
      
       resposta_usuario=Console.ReadLine();
       
   
       
      
      
      
      if(resposta_usuario == entrar){
      
      
       Console.BackgroundColor =
       ConsoleColor.Cyan;
       Console.ForegroundColor =
       ConsoleColor.DarkRed;
       Console.WriteLine("BEM VINDO AO JOGO RESPONDE AÍ!");
       fases:
       Console.ResetColor();
       Console.WriteLine("Escolha a fase:");
       
       Console.ForegroundColor =
       ConsoleColor.Cyan;
       Console.WriteLine("fase1-fase2-	fase3fase4-fase5");
       
       Console.ResetColor();
       Console.WriteLine("Digite a fase que escolheu:");
       resposta=Console.ReadLine();
      
      	
           // fases do jogo //
      
      switch(resposta){
    
    
       
       case "fase1":	
     
     Console.Write("

#Resolva o problema a seguir:");
     Console.WriteLine("Quanto é a raiz quadrada de 4?");
     resposta_fase1=int.Parse(Console.ReadLine());
     
     if(resposta_fase1 == fase1__certa){
     Console.ForegroundColor =
     ConsoleColor.Green;
     Console.WriteLine("Muito bem!você a certou.");	
     	
     }else{
     	
     	
     Console.ForegroundColor =
     ConsoleColor.Red;
     Console.WriteLine("Que pena você errou!");	

Console.WriteLine (" voltar para área de fases?");
retornar_fases1= Console.ReadLine ( );

if ( retornar_fases1 == verdadeiro){

        goto fases;

}else{
              goto início;

}

     }	
     	
     	
       break;
     	
     	
      case "fase2":
      
     Console.WriteLine("Resolva o seguinte problema:
");
     Console.WriteLine("Quanto é 12 dividido por 5?");
     resposta_fase2=int.Parse(Console.ReadLine());
     
     if(resposta_fase2 == fase2__certa){
     	
     	Console.WriteLine("parabéns você acertou");
     	
     }else{
     	
       Console.ForegroundColor =
       ConsoleColor.Red;
       Console.WriteLine("poxa! você errou ");
       Console.ResetColor();
       Console.WriteLine("voltar para área de fases?");
       retorno_de_fases2=Console.ReadLine();
       
       if(retorno_de_fases2 == positivo ){
       	
       	goto fases;
       }else{
       	
       	goto inicio;
       }
     }
     
     
     
      break;
   
      case "fase3":
   Console.Write("--------------------------------------");
Console.WriteLine ("Resolva o seguinte problema: ");

Console.Write("Sempre no meio de números ímpares tem um número ______?");  
     
     if (resposta_fase3 ==  fase3_certa){

   Console.Write("  Isso aí! mandou bem.      ");

}else
     
     
      break;
     
     
     case "fase4":
     
     
     Console.Write("Amd");
     
     
     break;
     	
     	
     	
     	
     }
    	
    	
      }else{
      	
      Console.Write("oi");
      	
      	
      }
    	
    
    	
    	
    	
    	
    }	
    	
    	
    	
    	
    	
    	
    }
			 public static class Program
			 {
						  public static void Main()
						  {
									   Console.WriteLine("Hello, World!");
						  }
			 }
}
