# DEVOPS VM
GLENDA DELFY VELA MAMANI – RM 552667
LUCAS ALCÂNTARA CARVALHO – RM 95111 
RENAN BEZERRA DOS SANTOS – RM 553228
#
. Solução Geral do Projeto 
O Projeto User em Dotnet MVC é uma API completa utilizando o Swagger, projeto User tem como base cadastrar usuários em um banco de dados Oracle.
 

2. Virtualização do Projeto 
A virtualização, seja através de máquinas virtuais ou containers Docker, oferece uma série de benefícios que podem potencializar a entrega e a manutenção do projeto. Ao permitir a criação de ambientes de software isolados, a virtualização agiliza o desenvolvimento, facilita a escalabilidade e aumenta a flexibilidade da solução.
laaS: A infraestrutura como serviço (laaS) é fundamental para a implementação da solução, fornecendo os recursos computacionais básicos, como servidores virtuais, armazenamento e redes.











3. .NET – Máquina Virtual WINDOWS E LINUX
A escolha de uma máquina virtual para a aplicação .NET API, utilizando o banco de dados Oracle. A VM precisa ter seu próprio sistema operacional, hardware e recursos dedicados. As vantagens de um sistema operacional são: alto nível de isolamento da aplicação, flexibilidade permitindo executar em qualquer sistema operacional, e tecnologia já utilizada no mercado. 
O ambiente de desenvolvimento é a IDE Visual Studio 2022 para a aplicação .NET, utilizando o sistema operacional Windows. A segurança também é um fator importante para a aplicação. 
Configurações do ambiente: .NET Framework, Banco de dados Oracle, um servidor Windows. A máquina virtual é a VM da Azure.
A imagem apresenta uma arquitetura de uma aplicação web hospedada na nuvem Azure, utilizando uma máquina virtual (VM).
No Front-End o nginx.utlizando uma VM Linux.

Arquitetura da solução:


![image](https://github.com/user-attachments/assets/ef42d863-05e6-433f-b0ca-b2ada6303b4a)

 

4. Criação da Máquina Virtual
VM-Front-end
 ![image](https://github.com/user-attachments/assets/07278cb2-5747-4a81-ba8c-c7fda9d10a56)

VM-Back-end
 ![image](https://github.com/user-attachments/assets/03173606-1ea0-463c-808a-b982b66d713b)

IP da maquina: 191.232.240.92
Admin: admglenda
Senha: Adminglenda123
5.Comandos Utilizados  Na VM back-end
docker build -t global-dotnet -f Dockerfile .
docker build -t global-dotnet  .
docker run -d -p 8080:8080 global-dotnet

Comandos usados na VM front-end
docker pull nginx
docker run -p 80:80 nginx























6.Github do projeto: https://github.com/glendadelfy/devops-global.git 
7.Video: https://youtu.be/FQ6LipFz2P4
 

