using FiapStoreMinimalApi.Entidade;

namespace FiapStoreMinimalApi.Interface
{
    public interface IUsuarioRepository
    {

        public IList<Usuario> MostrarTodosUsuarios();

        public Usuario MostrarUsuariosPeloId(int id);

        public void CriarUsuario(Usuario usuario);

        public void EditarUsuario(Usuario usuario);

        public void ExcluirUsuario(int id);
    }
}
