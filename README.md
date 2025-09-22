# 🌦️ Aplicativo Tempo Agora (.NET MAUI)
![.NET 8](https://img.shields.io/badge/.NET-8.0-blueviolet)
![MAUI](https://img.shields.io/badge/Mobile-MAUI-ff69b4)
![Status](https://img.shields.io/badge/Status-Concluído-brightgreen)
![License](https://img.shields.io/badge/Licença-MIT-blue)

Repositório do aplicativo de previsão do tempo desenvolvido para a **Agenda 7** da disciplina **Desenvolvimento de Sistemas III** do curso **Técnico em Desenvolvimento de Sistemas**.  

Aplicativo para consulta de informações climáticas em tempo real, permitindo pesquisar pelo nome da cidade ou utilizar a localização atual, exibindo dados detalhados e um mapa meteorológico dinâmico.  

✔ Interface intuitiva e responsiva  

✔ Consulta rápida da previsão do tempo  

✔ Exibição de informações completas (temperatura, vento, descrição, nascer e pôr do sol, etc.)  

✔ Compatível com Android, iOS e Windows  

✔ Integração com API OpenWeatherMap e mapa do Windy  

---

## 📝 Descrição do Projeto
Sistema que permite consultar as condições climáticas de uma cidade, integrando dados de uma API pública com recursos de geolocalização do dispositivo.  

Funcionalidades principais:
- Pesquisa de cidade manualmente
- Detecção automática da cidade via geolocalização
- Exibição de temperatura mínima e máxima
- Velocidade do vento
- Visibilidade em metros
- Descrição do clima (nublado, ensolarado, etc.)
- Horários de nascer e pôr do sol
- Exibição em mapa dinâmico do Windy

---

## ✨ Recursos Implementados
✅ Entrada de dados via `Entry` para nome da cidade  

✅ Integração com API [OpenWeatherMap](https://openweathermap.org/api)  

✅ Integração com geolocalização (latitude e longitude do dispositivo)  

✅ Exibição de dados climáticos organizados em texto formatado  

✅ Exibição de mapa meteorológico via componente WebView  

✅ Tratamento de erros com mensagens específicas:  
- Cidade não encontrada  
- Falha de conexão com a internet  
- Erros gerais da API  

✅ Layout moderno e responsivo com **.NET MAUI**  

---

## 🛠 Tecnologias Utilizadas
- **Front-end:** XAML (MAUI)  
- **Back-end:** C# (lógica e integração com APIs)  
- **APIs:** OpenWeatherMap (clima) + Windy (mapa meteorológico)  
- **Plataforma:** .NET MAUI (Multi-platform App UI)  

---

## 📂 Estrutura do Projeto
MauiAppTempoAgora/  
├── Models/  
│   ├── Tempo.cs                 # Modelo de dados do clima  
├── Services/  
│   ├── DataService.cs           # Classe para consumo da API OpenWeatherMap  
├── MainPage.xaml                 # Tela principal com entrada de cidade e resultados  
├── App.xaml                      # Configurações globais e estilos  
└── README.md                     # Esta documentação  

---

## 🚀 Como Executar
**Pré-requisitos:**
- .NET 8.0 SDK instalado  
- Visual Studio 2022 ou superior (com suporte ao MAUI)  
- Chave de API do [OpenWeatherMap](https://openweathermap.org/api)  

**Clone o repositório:**
```bash
git clone https://github.com/beatrisAS/MauiAppTempoAgora.git
````

**Restaure os pacotes e execute o projeto:**

```bash
dotnet build
dotnet run --project MauiAppTempoAgora
```

**Teste no emulador Android, iOS ou Windows.**

---

## 🎥 Demonstração do App

Um vídeo foi gravado demonstrando o funcionamento prático do aplicativo, incluindo a pesquisa por cidades e a exibição em mapa meteorológico.

📌 Link do vídeo: <a href="https://youtu.be/fX9o3FZe4p4" target="_blank">Clique aqui para ver o vídeo!</a>

---

## 📌 Informações Acadêmicas

| Item           | Detalhe                                                  |
| -------------- | -------------------------------------------------------- |
| **Disciplina** | Desenvolvimento de Sistemas III                          |
| **Curso**      | Técnico em Desenvolvimento de Sistemas                   |
| **Agenda**     | Agenda 7                                                 |
| **Objetivo**   | Sistema para consulta de previsão do tempo em tempo real |

---

💡 *Dica:* personalize as cores e estilos no arquivo **Styles.xaml** para deixar o aplicativo com a sua identidade visual.
