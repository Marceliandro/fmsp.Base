namespace fmsp.Base.Interfaces
{
    public interface IServicoBase<TEntity, TId>
    {
        TEntity GetById(TId id);
        TEntity Salvar(TEntity dto);
        TEntity Editar(TEntity dto);
        void Excluir(TId id);
    }
}
