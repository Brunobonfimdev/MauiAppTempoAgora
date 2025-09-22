🌦️ Aplicativo Tempo Agora (.NET MAUI)
Repositório do aplicativo de previsão do tempo desenvolvido para a Agenda 7 da disciplina Desenvolvimento de Sistemas III do curso Técnico em Desenvolvimento de Sistemas.

Este aplicativo permite a consulta de informações climáticas em tempo real, oferecendo a funcionalidade de pesquisar pelo nome da cidade ou utilizar a localização atual do dispositivo. Ele exibe dados climáticos detalhados e um mapa meteorológico dinâmico.

Principais Características:

Interface intuitiva e responsiva

Consulta rápida da previsão do tempo

Exibição de informações completas (temperatura, vento, descrição, nascer e pôr do sol, etc.)

Compatível com Android, iOS e Windows

Integração com API OpenWeatherMap e mapa do Windy

📝 Descrição do Projeto
O sistema tem como objetivo principal consultar as condições climáticas de uma cidade, integrando dados de uma API pública de clima com recursos de geolocalização do dispositivo.

Funcionalidades Detalhadas:

Pesquisa de cidade manualmente

Detecção automática da cidade via geolocalização

Exibição de temperatura mínima e máxima

Velocidade do vento

Visibilidade em metros

Descrição textual do clima (nublado, ensolarado, etc.)

Horários de nascer e pôr do sol

Exibição em mapa dinâmico do Windy

✨ Recursos Implementados
✅ Entrada de dados via Entry para o nome da cidade

✅ Integração com a API OpenWeatherMap para dados climáticos

✅ Integração com a API de geolocalização para obtenção de latitude e longitude do dispositivo

✅ Exibição de dados climáticos organizados em texto formatado

✅ Exibição de mapa meteorológico via componente WebView

✅ Tratamento de erros aprimorado com mensagens específicas para:

Cidade não encontrada

Falha de conexão com a internet

Erros gerais da API

✅ Layout moderno e responsivo desenvolvido com .NET MAUI

🛠 Tecnologias Utilizadas
Front-end: XAML (.NET MAUI)

Back-end: C# (Lógica da aplicação e integração com APIs)

APIs Externas: OpenWeatherMap (dados climáticos) e Windy (mapa meteorológico)

Plataforma: .NET MAUI (Multi-platform App UI)

📂 Estrutura do Projeto
MauiAppTempoAgora/
├── Models/
│   └── Tempo.cs                   # Modelo de dados para informações climáticas
├── Services/
│   └── DataService.cs             # Serviço para consumo da API OpenWeatherMap
├── MainPage.xaml                  # Tela principal com campos de entrada e exibição de resultados
├── App.xaml                       # Definições globais da aplicação e estilos
└── README.md                      # Documentação do projeto
🚀 Como Executar
Pré-requisitos:

.NET 8.0 SDK instalado

Visual Studio 2022 ou superior (com carga de trabalho de desenvolvimento .NET MAUI)

Chave de API do OpenWeatherMap

Passos para Execução:

Clone o repositório:

Bash

git clone https://github.com/beatrisAS/MauiAppTempoAgora.git
Navegue até o diretório do projeto:

Bash

cd MauiAppTempoAgora
Restaure os pacotes e compile o projeto:

Bash

dotnet build
Execute o projeto em sua plataforma preferida:
(Exemplos para Android, iOS ou Windows via Visual Studio)
Você pode abrir a solução no Visual Studio e selecionar o emulador/dispositivo desejado para rodar.

🎥 Demonstração do App
Um vídeo demonstrativo foi criado para apresentar o funcionamento prático do aplicativo, incluindo a pesquisa por cidades e a exibição de dados climáticos e do mapa meteorológico.

📌 Link do vídeo: Assista à demonstração do aplicativo aqui!

📌 Informações Acadêmicas
Item	Detalhe
Disciplina	Desenvolvimento de Sistemas III
Curso	Técnico em Desenvolvimento de Sistemas
Agenda	Agenda 7
Objetivo	Sistema para consulta de previsão do tempo em tempo real

Exportar para as Planilhas
