# 🎵 Tag Editor Pro

Um editor de tags de áudio completo e com interface moderna para Windows, desenvolvido em C# com Windows Forms.

## ✨ Funcionalidades

- **Edição completa de metadados**: Título, Artista, Álbum, Ano, Número da Faixa, Gênero, Comentário, Compositor e muito mais
- **Suporte a capas de álbum**: Visualize, altere ou remova a arte do álbum
- **Múltiplos formatos**: Compatível com MP3, MP4, M4A, WAV, OGG, FLAC, AIFF, WMA e APE
- **Interface comercial**: Design moderno, intuitivo e profissional
- **Salvamento seguro**: Salva as tags diretamente no arquivo de áudio
- **Controle de alterações**: Cancele mudanças não salvas e receba avisos antes de fechar

## 🖥️ Preview

![Tag Editor Pro](https://img.shields.io/badge/Platform-Windows-blue.svg)
![.NET](https://img.shields.io/badge/.NET-4.7.2-purple.svg)
![License](https://img.shields.io/badge/License-MIT-green.svg)

## 📋 Requisitos

- Windows 7 ou superior
- .NET Framework 4.7.2 ou superior

## 🚀 Instalação e Uso

### Opção 1: Executar diretamente

1. Baixe a versão mais recente em [Releases](https://github.com/seu-usuario/TagEditor/releases)
2. Extraia o arquivo ZIP
3. Execute `TagEditor.exe`

### Opção 2: Compilar o projeto

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/TagEditor.git
cd TagEditor
```

2. Abra o arquivo `TagEditor.slnx` no Visual Studio 2017+

3. Compile e execute (F5)

### Usando o aplicativo

1. **Clique em "..."** para selecionar um arquivo de áudio
2. **Edite os campos** desejados (título, artista, álbum, ano, etc.)
3. **Altere a capa** clicando em "Alterar Capa" ou remova com "Remover Capa"
4. **Clique em "SALVAR TAGS"** para aplicar as alterações ao arquivo

## 📁 Estrutura do Projeto

```
TagEditor/
├── Form1.cs                 # Lógica principal do aplicativo
├── Form1.Designer.cs        # Design da interface
├── Program.cs               # Ponto de entrada
├── TagEditor.csproj         # Arquivo do projeto
├── packages/
│   └── TagLibSharp/         # Biblioteca de manipulação de tags
└── bin/
    └── Debug/
        └── TagEditor.exe    # Executável
```

## 🛠️ Tecnologias Utilizadas

- **C# (.NET Framework 4.7.2)**
- **Windows Forms** para a interface gráfica
- **TagLibSharp** para leitura e escrita de tags em arquivos de áudio

## 📦 Formatos Suportados

| Formato | Extensões |
|---------|-----------|
| MP3 | `.mp3` |
| MPEG-4/AAC | `.mp4`, `.m4a` |
| WAV | `.wav` |
| Ogg Vorbis | `.ogg` |
| FLAC | `.flac` |
| AIFF | `.aiff` |
| Windows Media | `.wma` |
| Monkey's Audio | `.ape` |

## 📝 Campos Editáveis

- **Título** - Nome da música
- **Artista** - Nome do artista/banda
- **Álbum** - Nome do álbum
- **Ano** - Ano de lançamento
- **Nº da Faixa** - Número da faixa no álbum
- **Total de Faixas** - Número total de faixas
- **Disco** - Número do disco
- **Total de Discos** - Número total de discos
- **Gênero** - Gênero musical (separar múltiplos com `;`)
- **Comentário** - Comentários sobre a faixa
- **Compositor** - Compositor da música (separar múltiplos com `;`)

## 🤝 Contribuindo

1. Faça um Fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/NovaFuncionalidade`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. Push para a branch (`git push origin feature/NovaFuncionalidade`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 🐛 Bugs e Sugestões

Encontrou um bug ou tem uma sugestão? Abra uma [Issue](https://github.com/seu-usuario/TagEditor/issues)!

## 📧 Contato

- **Author**: Seu Nome
- **GitHub**: [@seu-usuario](https://github.com/seu-usuario)

---

⭐ Se este projeto foi útil, deixe uma estrela!
