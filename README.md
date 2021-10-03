# Criando Web API .Net Core 3.1
## Projeto ASP .NET Core Web API para gerenciar informações de usuários

## Rotas:
[Route("api/[Controller]")]
http://localhost.../api/Usuarios/

Para...
- retornar Usuário: Passar seu id na requisição.
- retornar todos os Usuários: Não enviar nada na requisição além do caminho padrão.
- adicionar Usuário: Passar os campos de Nome, Email e Senha no corpo da requsição.
- atualizar Usuário: Passar id na requisição e campos a serem atualizados no corpo.

## Objeto Da Requisição:
``` c# 
        USUARIO.cs
        
        public long Id 
        { 
            get { return Id; }
            set { Id = value } 
        }
        public string Nome 
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string Senha 
        {
            get { return Senha; }
            set { Senha = value; }
        }
        public string Email 
        {
            get { return Email; }
            set { Email = value; }
        }
``` 

## Métodos:
``` c#
Usuario GetUsuario(long id);  
IEnumerable<Usuario> RetornarTodos();
void AdicionarUsuario(Usuario user);
void RemoverUsuario(long id);
void AtualizarUsuario(Usuario user); 
        
``` 

## Autor

- [@AaronCrvl](https://www.github.com/AaronCrvl)
