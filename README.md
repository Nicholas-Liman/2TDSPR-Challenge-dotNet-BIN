# Bem vindo a entrega de **ADVANCED BUSINESS DEVELOPMENT WITH .NET** da equipe B.I.N. composta por:
* Igor Gabriel Marcondes - RM553544
* Maria Beatriz Fogolin  - RM552669
* Nicholas Barbosa Lima  - RM552744


## Definição do Projeto da **B.I.N.**
### **Objetivo do Projeto**
O objetivo do projeto é servir como uma camada intermediária entre o front-end desenvolvido em Kotlin e o back-end em Java. 
Ele processa, valida e encaminha os dados de dois tipos de usuários [Profissionais e Usuários], além de gerenciar e validar dados de Endereço, antes de enviá-los para o back-end Java. 
O projeto assegura que os dados cheguem ao back-end já formatados e validados, facilitando a integração entre os sistemas e garantindo a consistência das informações.

### **Escopo**
O projeto irá:
- Receber requisições de entrada de dois tipos de usuários: Profissional e Usuário, bem como dados de Endereço.
- Validar as entradas com base nas regras de negócio específicas de cada entidade.
- Processar e preparar os dados para serem enviados ao back-end Java.
- Implementar a arquitetura MVC.
- Funcionar como uma interface entre o front-end Kotlin e o back-end Java.

### **Requisitos Funcionais e Não Funcionais**
#### **Requisitos Funcionais**:
1. O sistema deve validar os dados do **Profissional**, como nome, sobrenome, telefone, e-mail e outros detalhes obrigatórios antes de enviá-los ao back-end.
2. O sistema deve validar os dados do **Usuário**, como nome e e-mail, garantindo que estejam no formato correto antes de serem processados.
3. O sistema deve permitir a entrada de dados de **Endereço**, validando campos como rua, cidade e estado.
4. O sistema deve tratar e exibir mensagens de erro apropriadas quando os dados não forem válidos.
5. O sistema deve enviar os dados validados ao back-end Java utilizando uma API HTTP.
6. O sistema deve implementar DTOs (Data Transfer Objects) para facilitar a comunicação entre as camadas de apresentação e serviços.
7. O sistema deve ser capaz de se comunicar com o back-end Java utilizando chamadas HTTP, confirmando o sucesso ou falha das operações.
8. O sistema deve seguir o padrão de arquitetura MVC, com separação clara entre controladores, modelos e serviços.

#### **Requisitos Não Funcionais**:
1. O sistema deve ser escalável e modular, permitindo que novos tipos de usuários ou entidades sejam adicionados no futuro com o mínimo de impacto no código existente.
2. O sistema deve ser de fácil manutenção, utilizando injeção de dependências e interfaces para desacoplar as camadas.
3. O sistema deve garantir que as respostas sejam rápidas o suficiente para não impactar a experiência do usuário no front-end.
4. A validação e o processamento de dados devem ser consistentes e confiáveis, minimizando erros ao comunicar com o back-end.
5. O código deve ser claro e seguir boas práticas de codificação, como tratamento de exceções adequado e uso de padrões de projeto.