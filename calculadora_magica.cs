using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Calculadora_magica
{

    public class Variaveis
    {   
    	static string resposta_usuario;
    	static int N1, N2, total1;
    	static int Num01, Num02, resultado_subtracao;
    	static int multiplicando, multiplicador, total_multiplicacao;
    	static int dividendo, divisor, resultado_Divisão;
    	
    	 static string [] bloco_de_notas = new string[1000];
    	
        public static void Main()
        {       
        	      /*
        	      <<Apresentação do programa.
        	      essa parte é onde o usuário
        	      ira fazer sua escolha de calculo.>>
        	      */
        	     apresentacao:
			    Console.ForegroundColor =
			    ConsoleColor.Cyan;
			    Console.WriteLine("#Digite#");
			    
			    Console.ForegroundColor =
			    ConsoleColor.Yellow;
			    Console.WriteLine("(A)para adição
(S)subtração
(M)multiplicação
(D)Divisão.");
			    Console.ResetColor();
			    Console.ForegroundColor =
			    ConsoleColor.Cyan;
			    Console.Write("$Qual tipo de calculo você deseja?");
			    resposta_usuario=Console.ReadLine();
			    
			      //<<fim da Apresentação.>>
			      
			      
			      
			    // <<inicio:>>
			    switch(resposta_usuario)
			    {   
			     
			     // << caso_1: Adição >>
			    	case "A":
			        case "a":
			        
			    Console.Write("Informe o número:");
			    N1=Int32.Parse(Console.ReadLine());
			    
			    Console.Write("Informe o segundo número:");
			    N2=Int32.Parse(Console.ReadLine());
			    
			       total1 = N1 + N2;
			       
			    Console.Write("Resultado da soma:"+total1);
			    	
			    	break;
			     //<<fim do caso_1.>>
			     
			     
			     // << caso_2: Subtração  >>
			    
			     	case "S":
			    	case "s":
			    
			    Console.Write("Informe o número:");
			    Num01=int.Parse(Console.ReadLine());
			    
	
			    Console.Write("Informe o segundo número:");
			    Num02=Int32.Parse(Console.ReadLine());
			     
			        resultado_subtracao = Num01 - Num02;
			     
			     Console.Write("Resultado da subtração:"+resultado_subtracao);
			    
			     
			    
			    	break;
			    // <<fim do caso_2.>>
			    
			    
			    
			    //<< caso_3: Multiplicação >>
			    	case "M":
			        case "m":  
			        
			    Console.Write("Informe o número:");
			    multiplicando=int.Parse(Console.ReadLine());
			    
			    Console.Write("Informe o segundo número:");
			    multiplicador=int.Parse(Console.ReadLine());
			    
			        total_multiplicacao = multiplicando * multiplicador;
			    
			    Console.Write(total_multiplicacao);
			    
			    	break;
			    // <<fim do caso_3.>>
			    	
			    	
			    	
			    	
			    // << caso_4: Divisão >>
			    	case "D":
			    	case "d":
			    	
			    Console.Write("Informe o número:");
			    dividendo=int.Parse(Console.ReadLine());
			    
			    Console.Write("Informe o segundo número:");
			    divisor=int.Parse(Console.ReadLine());
			    
			    resultado_Divisão = divisor / dividendo;
			    
			    Console.Write(resultado_Divisão);
			    	
			    	break;
			    //<<fim do caso_4.>>
			    
			    
			    //<<caso especial:>>
			    	case "4%10":
			    
			    Console.Write("Criar nota?");
			    string resposta_notabloco=Console.ReadLine();
			    
			       if(resposta_notabloco == "sim")
			       {
			       	  Console.Write("Digite sua anotação:");
			       	  bloco_de_notas[0]=Console.ReadLine();
			       	  Console.Write("anotação salva!");
			       }
			       else{
			       	  
			       	  Console.Clear();
			       	  goto apresentacao;
			       	
			       }
			       	
			       
			       
			       
			       
			       
			    	  break;
			    //<< caso especial>>
			    
			     default:
			    
			     Console.Write("Opção Inválida!");
			    
			     break;

			    
			    
			     
			    
			    }
			  
			    //<<Fim.>>
			    
        }
    }
}
