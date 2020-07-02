# DeveloperTest
Softplan developer test

### Hospedagem
As apis do exercicio estão hospedadas na cloud Heroku. O Heroku Free após um tempo sem uso da API ele as coloca em modo "sleep" fazendo com que a primeira chamada após esse tempo seja mais lenta.


**Endereços**

https://api1developertest.herokuapp.com/swagger/

https://api2developertest.herokuapp.com/swagger/


**Considerações**

 - Os Dockerfile estão em seus respectivos .csproj para que sejam independentes.
 - Caso decida rodar a Api1 no Docker, alterar o config da Api2 para apontar para o endereço correto da Api1