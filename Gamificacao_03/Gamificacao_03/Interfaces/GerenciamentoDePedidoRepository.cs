namespace gamificacao03.Interfaces;

public interface GerenciamentoDePedidoRepository
{
    void CriarPedido();
    void AdicionarItemPedidos();
    void AtualizarStatus();
    void RemoverPedido();
    void ListarPedidos(string filtro);
    void CalcularValorPedido();
}