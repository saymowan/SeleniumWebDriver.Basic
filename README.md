# SeleniumWebDriver.Basic

Projeto criado para estudos nível básico

Dificuldade: fácil

Tecnologias escolhidas:
- Linguagem C#
- Framework .NET
- Framework de testes automatizados: Selenium WebDriver
- Framework de testes automatizados: NUnit
- Padrão de escrita de código de testes: PageObjects

### Arquitetura do projeto:

Classe filha -> Classe mãe herdada

Classe de Teste -> WebDriver

Classe de PageObject -> WebDriver

### Features:

Encontrar path relativo de driver

Básico de WebDriver

Básico de PageObjects

Criar um método de teste

Validar resultados de teste

**************************
### Passo a passo do projeto
**************************
### 1. Classe SeleniumUteis: 
* Método getPathSeleniumDriver: método que encontrar o driver (arquivo) dentro do projeto, necessário
* incluir o mesmo dentro de uma pasta dentro do projeto

### 2. Classe WebDriver
* Instalar NuGet: Selenium WebDriver
* Variável global static IWebDriver driver: o tipo faz referência á um driver utilizado por todas as classes de testes
* Instalar NuGet: NUnit 
* Criar pasta e incluir chromedriver (driver do navegador chrome)
* Método SetUp: ações executada antes a cada teste iniciado
* Método TearDown: últimas ações realizadas após o teste finalizar
* Instalar o NUnit3TestAdapter

### 3. Classe PageObjects
* Instalar NuGet: Selenium Support
* Fazer antes de criar os testes para mapear os elementos da tela que será efetuado ações
* Recomendo utilizar o navegador Mozilla Firefox e usar a extensão SeleniumIDE e Firebug para ajudar a mapear
* Criar classe para cada página existente no sistema
* Mapeie cada elemento: ajuda na hora da manutenção e fica mais legível 

### 4. Classe Tests
* Classe que representa uma suíte de testes que irão ser executados
* Herdar classe WebDriver 
* Método de teste: método que insere informações na tela, navega no sistema e faz validações e verifica o resultado final
* Crie método claros e intuitivos
* Caso haja ações/métodos que podem ser reutilizadas, crie um método na classe de PageObject referente á tela
* Sempre que for usar algum elemento da tela, crie um objeto da classe PageObjects e realize ações no método de teste

### 5. Executar testes criados
* Inclua a tela "Test Explorer"
* Dê um rebuild/build no projeto
* Os testes serão exibidos
* Clique com o botão direito e clique em "Run Selected Tests"
* Após executar: Verde -> Assert validado com sucesso
* Após executar: Vermelho -> Alguma ação não realizada ou Assert não validado
