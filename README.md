# CryptoPorto Manaus: Rastreabilidade e Smart Contracts na Logística Amazônica

## 📌 Sobre o Projeto
O **CryptoPorto Manaus** é uma simulação imersiva em Realidade Virtual (VR) desenvolvida dentro do ecossistema Unity 3D como projeto final para o curso de **Metaverso**, integrante da **Residência em TIC 29 | Capacitação Web 3.0**. 

O objetivo central é simular de forma prática e interativa a complexa cadeia de suprimentos e o fluxo de despacho jurídico de mercadorias na região amazônica. O projeto explora o uso de tecnologias Web 3.0, como **Smart Contracts** e redes descentralizadas, aplicadas ao contexto hidroviário regional, promovendo soluções para rastreabilidade de cadeias produtivas, automação documental e conformidade ambiental (compliance).

O projeto adota como referência conceitual e prática as diretrizes da **YAKAMI TECH (Sentinel)**.

---

## 🛠️ Especificações Técnicas e Tecnologias
* **Engine Gráfica:** Unity 6000.3.9f1 (LTS)
* **Pipeline de Renderização:** Universal Render Pipeline (URP)
* **SDK Base:** Meta XR All-in-One SDK
* **Interações:** XR Interaction Toolkit
* **Plataforma de Destino:** Android (Dispositivos Standalone da linha Meta Quest)
* **Compressão de Textura:** ASTC (Otimizada para Mobile VR)
* **API Mínima do Android:** Android 10 (API Level 29)

---

## 🗺️ Estrutura do Ambiente Virtual
O cenário representa uma réplica metodológica e imersiva de uma seção estratégica do Cais do Porto de Manaus (região da Manaus Moderna), dividida em duas zonas operacionais conectadas:

### 1. Área Externa de Transbordo Fluvial
* **Malha Hidrográfica:** Modelagem imersiva do rio e do ecossistema portuário.
* **Infraestrutura de Acesso:** Plataforma flutuante de desembarque conectada a solo firme por meio de rampas com colisores detalhados em escala real.
* **Frota Regional:** Embarcações típicas ancoradas que simulam o transporte de cargas e passageiros pelo modal hidroviário amazônico.

### 2. Hub de Inovação e Núcleo Administrativo (Edifício Tech Amazon / Yakami Tech)
* **Sala de Despacho Aduaneiro:** Ambiente corporativo totalmente mobiliado (mesas de trabalho, arquivos e terminais).
* **Terminal Tecnológico Central:** Dispositivo equipado com uma interface de usuário dinâmica (**Canvas em formato World Space**), onde o usuário realiza testes de interação para assinatura digital e execução simulada de Smart Contracts via blockchain.

### 🌟 Diferenciais Cenográficos e Imersivos
* **Lighting Equatorial:** Configuração de luz direcional intensa emulando a iluminação natural característica da região de Manaus em horários de pico.
* **Skybox Personalizado:** Atmosfera realista de céu aberto adaptada à narrativa portuária.
* **Sound Design Espacializado:** Paisagem sonora tridimensional contendo elementos de áudio espacial, incluindo o tráfego de veículos na avenida adjacente ao edifício.

---

## ⚡ Otimizações para Limitação de Hardware
Visando contornar as restrições de desempenho da GPU local no Unity Editor e garantir uma taxa de quadros (FPS) estável e sem travamentos, foram aplicadas as seguintes técnicas de otimização no pipeline de desenvolvimento:
* **Simplificação Geométrica:** Redução da densidade de polígonos nas malhas 3D (Meshes).
* **Racionalização de Assets:** Uso eficiente e enxuto de texturas e materiais externos.
* **Hierarquia Limpa:** Organização estruturada e performática da árvore de objetos (Hierarchy) no Unity.
* **Ajuste de Rendering:** Otimização fina no cálculo de iluminação e sombreamento em tempo real.
* **Culling de Câmera:** Limitação do número de elementos ativos processados simultaneamente pelo campo de visão da câmera do jogador.

---

## 💻 Como Executar e Testar

### No Unity Editor (Testes Rápidos no PC)
1. Certifique-se de ter o **Unity 6000.3.9f1 LTS** instalado.
2. Abra o projeto através do Unity Hub.
3. Certifique-se de que o **XR Device Simulator** está ativo nas configurações.
4. Pressione **Play**. Use o teclado e o mouse para emular a movimentação espacial do headset e os botões dos controladores das mãos, validando as rampas de colisão e o Canvas do terminal blockchain sem a necessidade de conectar fisicamente os óculos.

### Build para Meta Quest (Standalone)
1. Vá em `File > Build Settings`.
2. Altere a plataforma para **Android** (`Switch Platform`).
3. Certifique-se de que as configurações em `XR Plugin Management` estejam com a opção **Oculus** marcada para a aba Android.
4. Certifique-se de que a compressão está em **ASTC**.
5. Clique em **Build and Run** com o dispositivo Meta Quest conectado via Oculus Link/SideQuest.

---

## 👤 Identificação do Desenvolvedor
* **Aluno:** Helen Luciane Silva de Araújo
* **Turma:** 1
* **Curso:** Metaverso / Capacitação Web 3.0
* **Instituição:** Residência em TIC 29
