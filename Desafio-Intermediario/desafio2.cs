using System;  

class minhaClasse { 

  static void Main(string[] args) {  

    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 
  
    salario = Convert.ToDouble(Console.ReadLine()); 
   
    if( salario < 0) { 
      return; 

    } else if (salario <= 400) { 
      percentual = 15; 
    } else if (salario <= 800) { 
      percentual =   12; 
    } else if (salario <= 1200) { 
      percentual = 10; 
    } else if (salario <= 2000) { 
      percentual =  7; 
    } else { 
      percentual = 4; 
    } 
    
    reajuste = salario*(percentual/100); 
    novoSalario = salario + reajuste;

    Console.WriteLine("Novo salario: {0:0.00}",novoSalario); 
    Console.WriteLine("Reajuste ganho: {0:0.00}",reajuste); 
    Console.WriteLine("Em percentual: {0} %", percentual); 

  } 
}