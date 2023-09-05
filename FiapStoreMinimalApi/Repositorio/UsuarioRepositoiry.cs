using FiapStoreMinimalApi.Entidade;
using FiapStoreMinimalApi.Interface;

namespace FiapStoreMinimalApi.Repositorio
{
    public class UsuarioRepositoiry : IUsuarioRepository
    {
        IList<Usuario> usuarios = new List<Usuario>();

        public IList<Usuario> MostrarTodosUsuarios()
        {
            return usuarios;
        }
        public Usuario? MostrarUsuariosPeloId(int id)
        {
         return usuarios.FirstOrDefault(usuarios => usuarios.Id == id);
            
        }
        public void CriarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void EditarUsuario(Usuario usuario)
        {
        var usuarioEditar = MostrarUsuariosPeloId(usuario.Id);
            usuarioEditar.Idade = usuario.Idade;
            usuarioEditar.Nome = usuario.Nome;
            usuarioEditar.Sobrenome = usuario.Sobrenome;

        }

        public void ExcluirUsuario(int id)
        {
            usuarios.Remove(MostrarUsuariosPeloId(id));
        }

    }
}
