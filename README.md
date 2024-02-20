# Teste de Código: Alvenaria

__Objetivo__: Avaliar as habilidades de desenvolvimento de software em C# e .Net, bem como a capacidade de:
- Analisar e resolver problemas da engenharia estrutural.
- Aplicar conhecimentos de geometria computacional.
- Implementar interfaces e classes de forma modular e reutilizável.
- Trabalhar com versionamento de código utilizando Git.

## __Requisitos__:

- Computador com Windows
- Visual Studio 2019 ou superior
- .Net 6.0

## __Instruções__:

Fork o repositório GitHub [link do repositório](https://github.com/DouglasGioielliCP/TesteAlvenaria/tree/main).

Clone o repositório forcado para o seu computador.

Implemente as funcionalidades descritas nos "Itens" do teste, utilizando boas práticas de desenvolvimento e seguindo os princípios da engenharia de software.

Faça commit das suas alterações no repositório local, com mensagens de commit claras e concisas que descrevam as modificações realizadas.

Crie uma pull request no repositório original, submetendo seu código para avaliação.

Caso tenha alguma dúvida pode me enviar por email: douglas@claudiopuga.com.br

## Explicação do sistema:
O sistema visa fazer o projeto da elevação de estruturas de alvenaria a partir do projeto da primeira fiada da alvenaria (primeira linha de blocos de uma parede). As informações sobre os blocos da primeira fiada serão inseridos no sistema a partir de um arquivo de `.txt` de entrada. O processamento deve ser realizado de uma forma que seja possível fazer uma representação tridimensional precisa da estrutura. Para ajudar na visualização do resultado o sistema conta com uma interface gráfica que permitirá a visualização da primeira e segunda fiadas, bem como a elevação de cada uma das paredes do projeto.

### As entidades básicas:

Para esse teste vamos considerar apenas dois tipos de blocos: blocos com 20 cm de comprimento, 20 cm de largura e 20 cm de altura; e blocos com 40 cm de comprimento, 20 cm de largura e 20 cm de altura. Um bloco é representado como na imagem a seguir. Seu ponto de inserção fica localizado no canto inferior esquerdo. O bloco pode aparecer rotacionado para acompanhar uma parede, para esse sistema usaremos apenas os ângulos 0°, 90°, 180° e 270°.

![Imagem Bloco](https://github.com/DouglasGioielliCP/TesteAlvenaria/blob/main/Teste_Block.PNG)

No arquivo da primeira fiada o bloco será indicado pela seguinte linha:
`Bloco [Comprimento]|[Ponto X]|[Ponto Y]|[Ângulo]`, exemplo: `Bloco 40|560|20|90`, o que significa que existe um bloco de 40 cm de comprimento que o ponto de inserção está em 560,20 e está rotacionado em 90°.

Além da representação de blocos de alvenaria o sistema deve ser capaz de reconhecer janelas. Uma janela possui uma representação bastante simples (como na imagem a seguir). Também possui um ponto de inserção localizado no canto inferior esquerdo, podendo ser rotacionada a partir desse ponto como acontece no caso do bloco. Diferente do bloco uma janela pode ter qualquer comprimento desde que este seja um múltiplo de 20 cm, também possui uma altura e uma elevação que podem variar da mesma forma que o comprimento (deve ser multiplo de 20 cm), a elevação se refere à distância do chão até a extremidade inferior da janela. A largura das janelas sempre será de 20 cm.

![Imagem Janela](https://github.com/DouglasGioielliCP/TesteAlvenaria/blob/main/Teste_Window.PNG)

No arquivo da primeira fiada a janela será indicada pela seguinte linha:
`Janela [Comprimento]|[Altura]|[Elevação]|[Ponto X]|[Ponto Y]|[Ângulo]`, exemplo: `Janela 120|100|120|0|320|270`, o que significa que existe uma janela de 120 cm de comprimento, com 100 cm de altura e uma elevação de 120 cm, cujo o ponto de inserção está em 0,320 e está rotacionado em 270°.

Por fim, também teremos a indicação de portas. Uma porta também possui uma representação simples (como na imagem a seguir). Uma porta possui deve seguir as mesmas regras que uma janela com uma diferença a elevação de uma porta sempre será zero.

![Imagem POrta](https://github.com/DouglasGioielliCP/TesteAlvenaria/blob/main/Teste_Door.PNG)

No arquivo da primeira fiada a porta será indicada pela seguinte linha:
`Porta [Comprimento]|[Altura]|[Ponto X]|[Ponto Y]|[Ângulo]`, exemplo: `Porta 80|200|300|20|180`, o que significa que existe uma porta de 80 cm de comprimento, com 200 cm de altura, cujo o ponto de inserção está em 300,20 e está rotacionado em 180°.

### O processamento:

Depois de fazer a leitura dos dados do arquivo de primeira fiada será necessário fazer o reconhecimento de todas as paredes existentes na primeira fiada. Uma parede deve conter ao menos dois blocos que estão no mesmo sentido. Uma parede pode se cruzar com outras paredes (para esse sistema consideraremos apenas encontros nos cantos das paredes) nesse caso é importante considerar que algumas fiadas (linhas de blocos) entram na outra parede enquanto nas demais não. A seguir temos uma imagem de exemplo de primeira fiada.

![Exemplo Primeira Fiada](https://github.com/DouglasGioielliCP/TesteAlvenaria/blob/main/Primeira%20Fiada.PNG)

Uma vez que todas as paredes sejam reconhecidas devemos começar o processamento das fiadas superiores, com base na primeira fiada e nos encontros das paredes. É importante considerar que os blocos de uma fiada devem ficar em uma posição intercalada com relação à fiada anterior e a seguinte, como observado na imagem a seguir.

![Exemplo Fiadas](https://github.com/DouglasGioielliCP/TesteAlvenaria/blob/main/Parede%2001.PNG)

É importante considerar ainda que não podem existir blocos na região das janelas e das portas, o que pode gerar a necessidade de trocar o tamanho de alguns blocos para acomodar de uma forma melhor ao redor da janela, como indicado nas imagens a seguir.

![Exemplo Janela](https://github.com/DouglasGioielliCP/TesteAlvenaria/blob/main/Parede%2002.PNG)
![Exemplo Porta](https://github.com/DouglasGioielliCP/TesteAlvenaria/blob/main/Parede%2003.PNG)

Para concluir os dados da elevação devem ser retornados para a interface gráfica num formato que a interface gráfica seja capaz de interpretar para isso serão utilizadas as interfaces: `IWallData`, `IBlockData` e `IOpeningData`.
A interface `IWallData` possui as seguintes propriedades:
- `Name`: Nome da parede, duas paredes não podem ter um nome repetido.
- `PointX`: Coordenada X no canto inferior esquerdo da parede.
- `PointY`: Coordenada Y no canto inferior esquerdo da parede.
- `Angle`: Ângulo (em graus) da parede com relação ao ponto inferior esquerdo.
- `Length`: Comprimento da parede.
- `Blocks`: Lista de Blocos.
- `Openings`: Lista de aberturas.
As interfaces `IBlockData` e `IOpeningData` possuem as seguintes propriedades:
- `WallPosition`: Distância do início da parede até o início do objeto (bloco ou abertura).
- `Length`: Comprimento do objeto objeto (bloco ou abertura).
- `Height`: Altura do objeto (bloco ou abertura).
- `Elevation`: Elevação do objeto (bloco ou abertura).

Todo o código do teste deve ser criado na pasta Teste. E o código deve ser iniciado na função `RunTest(string path)` que recebe o caminho para o arquivo de primeira fiada que deve ser processado. Na pasta Cases estão disponíveis dois arquivos de `.txt` para teste do funcionamento do sistema. 


## __Itens__:

1. Leitura e processamento do arquivo de entrada:
	- Ler o arquivo de entrada, contendo informações sobre os elementos da primeira fiada da estrutura (blocos, portas, janelas).
	- Validar os dados de entrada, verificando a coerência e o formato das informações.
	- Armazenar os dados dos elementos em estruturas de dados adequadas, como classes ou objetos.
2. Definição das paredes e suas propriedades:
	- Identificar os pontos de interseção entre os elementos da primeira fiada.
	- Criar linhas que conectam os pontos de interseção, definindo as paredes da estrutura.
	- Associar às paredes as informações dos elementos que a compõem.
3. Identificação de cruzamentos entre as paredes:
	- Identificar todos os pares de paredes que se cruzam no projeto.
4. Criação das fiadas superiores:
	- Considerar um pé direito de 260 cm e altura dos blocos de 20 cm.
5. Integração com a interface gráfica:
	- Adaptar o código para fornecer os dados das paredes, blocos e aberturas para a interface gráfica fornecida.
