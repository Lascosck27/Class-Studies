using Design_de_Classes;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

/*Esse código cria duas instâncias: 1 de endereço e 1 de estudante.
Depois de instanciar, as  mostra já formatadas no console.
 */
Endereco principal = new Endereco("Rua 26, Jabaeté", "Vila Velha", "Espírito Santo"); //instaciei um endereco novo
Estudante Lascosck = new Estudante(52867, "Gabriel Lascosck de Oliveira", principal); //instanciei um estudante novo
Lascosck.Display(); //chamei o mostrador formatado
