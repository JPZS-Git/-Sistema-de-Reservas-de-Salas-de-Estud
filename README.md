# Sistema-de-Reservas-de-Salas-de-Estudo

  Proposta de Trabalho Prático
Tema: Sistema de Reservas de Salas de Estudo com
Configuração de Parâmetros.

 Objetivo
Desenvolver uma aplicação de console em C# para registrar reservas de salas de estudo
na universidade.
O projeto deve reforçar a prática de Programação Orientada a Objetos (OO), com foco em
abstração, encapsulamento, validação e separação de responsabilidades

3. Fluxo da Aplicação
Perguntar ao usuário:
Data mínima e máxima para configuraç
Hora mínima e máxima para configuração.
Criar a instância da configuração.
Após a configuração:
Solicitar dados da reserva: data, hora, descrição da sala e capacidade.
Criar a instância da reserva, validando as informações conforme a configuração.
Mostrar mensagens de sucesso ou de erro, conforme as validações.

----------------------------------------------------------------------------------------

Breve Passo a Passo:

Primeiro, deve-se declarar as variáveis relacionadas a configuração da Reserva,
ao captar cada uma, sempre checamos o seu formato, para na classe ConfiguraçãoReserva
possa ocorrer a validação sobre as regras de negócio, o que é feito pelos métodos da própria classe
para isso deve analisar as seguintes condições.

Dentro da classe ConfiguraçãoReserva:

1 - Se a data minima é maior que a data atual.
2 - Se a data máxima é maior que a data atual, e a data mínima.
3 - Se a hora máxima é maior que a hora mínima.

No main apenas fazemos a validação da configuração da reserva:

4 - Se não houver instanciação, quer dizer que houve falhas na Configuração, logo, o programa para.

*Nesse caso a hora mínima poderia ser qualquer uma, pois a data é no mínimo o próximo dia.

 Segundamente, declara-se as vavriáveis da reserva, sempre checando o formato de cada uma
 depois chamamos o construtor da classe Reserva, passando o objeto configuracaoReserva, e fazemos a checagem na classe Reserva.

 Dentro da classe Reserva:
 1 - Se a data está dentro do intervalo definido.
 2 - Se o horário está dentro do intervalo definido.
 3 - Se a capacidade da sala está entre é maior que 0 e menor que 40.

 *-* Pontos a ressaltar: 
 Na tipagem dos atributos, poderia-se usar qualquer um, assim como a nulabilidade das variáveis.
 As mensagens vem em uma lista, poderia fazer a apresentação dos erros no final.
